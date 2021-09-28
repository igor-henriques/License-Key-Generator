using Dapper;
using License_Key_Generator.Data;
using License_Key_Generator.License;
using License_Key_Generator.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace License_Key_Generator.Forms
{
	public partial class MainForm : Form
	{
		ContextMenuStrip ctxMenu = new ContextMenuStrip();

		private bool mouseDown;
		private Point lastLocation;

		private int animationCounter = 60;

		public MainForm()
		{
			InitializeComponent();
			this.Cursor = AnimatedCurs.Create(Path.Combine(Application.StartupPath, "7updot.ani"));
		}

		#region FORM_MOVEMENT
		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			mouseDown = true;
			lastLocation = e.Location;
		}

		private void MainForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				this.Location = new Point(
					(this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

				this.Update();
			}
		}

		private void MainForm_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}
		#endregion

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			tbKey.Text = LicenseGenerator.GenerateKey("licenca");

			while (LicenseAlreadyExists(tbKey.Text))
			{
				tbKey.Text = LicenseGenerator.GenerateKey("licenca");
			}
		}

		private bool LicenseAlreadyExists(string license)
		{
			bool response = false;

			foreach (DataGridViewRow row in dgvTable.Rows)
			{
				if (row.Cells[2].Value.ToString().Equals(license))
				{
					response = true;
				}
			}

			return response;
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			if (tbKey.Text != "")
			{
				Clipboard.SetText(tbKey.Text);
				AutoClosingMessageBox.Show("Key copied to clipboard", "Key on the clipboard", 500);
			}
		}

		private async void BtnRegister_Click(object sender, EventArgs e)
		{
			try
			{
				using (new ControlManager(Controls))
				{
					using (var conn = await DbContext.Get())
					{
						string query = "INSERT into CoreLicense(Licensekey,Hwid,Active,Validade,Product) VALUES (@Licensekey,@Hwid,@Active,@Validade,@Product)";

						await conn.ExecuteAsync(query, new
						{
							Licensekey = tbKey.Text,
							Hwid = "0",
							Active = false,
							Product = Product.Nenhum,
							User = string.Empty,
							Validade = DateTime.Now.Date.AddMonths(1)
						});

						await LoadData();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

		}

		private async void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				await LoadData();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Conexão não encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}
		}

		public async Task LoadData()
		{
			using (new ControlManager(Controls))
			{
				using (var conn = await DbContext.Get())
				{
					string query = "SELECT * FROM CoreLicense ORDER BY User,Hwid ASC";

					var response = await conn.QueryAsync<CoreLicense>(query);

					dgvTable.DataSource = null;
					dgvTable.DataSource = response.AsList().ToList();
				}

				FormatColumns();
			}
		}

		public void FormatColumns()
		{
			if (dgvTable.Rows.Count > 0)
			{
				dgvTable.Columns[0].Visible = false;
				dgvTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				dgvTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				dgvTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
				dgvTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
				dgvTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				dgvTable.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

				dgvTable.Columns[1].HeaderText = "User";
				dgvTable.Columns[2].HeaderText = "Licença";
				dgvTable.Columns[3].HeaderText = "Validade";
				dgvTable.Columns[4].HeaderText = "Ativo";
				dgvTable.Columns[5].HeaderText = "HWID";
				dgvTable.Columns[6].HeaderText = "Produto";

				for (int i = 0; i < dgvTable.RowCount; i++)
				{
					dgvTable.Rows[i].DefaultCellStyle.BackColor = i % 2 is 0 ? Color.Black : Color.DimGray;
				}

				dgvTable.ClearSelection();
			}
		}

		private void lblExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Tem certeza que deseja sair?", "Saindo...", MessageBoxButtons.YesNo) is DialogResult.Yes)
				Application.Exit();
		}

		private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var clickedLicense = GetSelectedLicenseOnGrid();

			if (clickedLicense != null)
			{
				pbOnOff.Image = clickedLicense.Active ? Resources.Onn : Resources.Off;

				var jsonPattern = @"
			{ 
				""user"": ""{user}"",
				""licensekey"": ""{license}"",
				""product"": ""{product}""
			}".Replace("{user}", clickedLicense.User)
			  .Replace("{license}", clickedLicense.Licensekey)
			  .Replace("{product}", clickedLicense.Product.ToString());

				Clipboard.SetText(jsonPattern.Trim());
			}
		}

		private CoreLicense GetSelectedLicenseOnGrid()
		{
			if (dgvTable.SelectedRows.Count is 1)
			{
				return new CoreLicense()
				{
					Id = Convert.ToInt16(dgvTable.SelectedRows[0].Cells[0].Value),
					User = dgvTable.SelectedRows[0].Cells[1].Value.ToString(),
					Licensekey = dgvTable.SelectedRows[0].Cells[2].Value.ToString(),
					Hwid = dgvTable.SelectedRows[0].Cells[5].Value.ToString(),
					Validade = Convert.ToDateTime(dgvTable.SelectedRows[0].Cells[3].Value),
					Active = Convert.ToBoolean(dgvTable.SelectedRows[0].Cells[4].Value),
					Product = (Product)Convert.ToByte(dgvTable.SelectedRows[0].Cells[6].Value)
				};
			}

			return null;
		}

		private CoreLicense GetSelectedLicenseOnGrid(DataGridViewRow row)
		{
			if (row != null)
			{
				return new CoreLicense()
				{
					Id = Convert.ToInt16(row.Cells[0].Value),
					User = row.Cells[1].Value.ToString(),
					Licensekey = row.Cells[2].Value.ToString(),
					Hwid = row.Cells[5].Value.ToString(),
					Validade = Convert.ToDateTime(row.Cells[3].Value),
					Active = Convert.ToBoolean(row.Cells[4].Value),
					Product = (Product)Convert.ToByte(row.Cells[6].Value)
				};
			}

			return null;
		}

		private List<CoreLicense> GetMultipleSelectedLicensesOnGrid()
		{
			List<CoreLicense> selectedLicenses = new List<CoreLicense>();

			foreach (DataGridViewRow row in dgvTable.SelectedRows)
			{
				selectedLicenses.Add(new CoreLicense()
				{
					Id = Convert.ToInt16(row.Cells[0].Value),
					User = row.Cells[1].Value.ToString(),
					Licensekey = row.Cells[2].Value.ToString(),
					Hwid = row.Cells[5].Value.ToString(),
					Validade = Convert.ToDateTime(row.Cells[3].Value),
					Active = Convert.ToBoolean(row.Cells[4].Value),
					Product = (Product)Convert.ToByte(row.Cells[6].Value)
				});
			}

			return selectedLicenses;
		}

		private async Task Search()
		{
			try
			{
				if (!(rbUsername.Checked || rbOnn.Checked))
				{
					AutoClosingMessageBox.Show("Selecione uma das opções para pesquisar", "Pesquisando...", 500);
					return;
				}

				string query = $"SELECT * FROM CoreLicense WHERE {(rbUsername.Checked ? $"User LIKE '%{tbSearch.Text}%'" : $"Licensekey='%{tbSearch.Text}%'")}";

				using (var conn = await DbContext.Get())
				{
					var response = await conn.QueryAsync<CoreLicense>(query);

					if (response.AsList().Count > 0)
					{
						dgvTable.DataSource = response;
						FormatColumns();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private async void btnSearch_Click(object sender, EventArgs e)
		{
			await Search();
		}

		private async void btnResetSearch_Click(object sender, EventArgs e)
		{
			tbSearch.Text = "";
			await LoadData();
		}

		private async void UpdateTime_Tick(object sender, EventArgs e)
		{
			animationCounter = 60;

			await LoadData();
		}

		private async void rbOnn_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				using (new ControlManager(Controls))
				{
					using (var conn = await DbContext.Get())
					{
						string query = "SELECT * FROM CoreLicense WHERE Active=@Active";

						var response = await conn.QueryAsync<CoreLicense>(query, new { Active = true });

						if (response.AsList<CoreLicense>().Count > 0)
						{
							dgvTable.DataSource = response;
						}

						FormatColumns();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private async void rbOff_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				using (var conn = await DbContext.Get())
				{
					string query = "SELECT * FROM CoreLicense WHERE Active=@Active";

					var response = await conn.QueryAsync<CoreLicense>(query, new { Active = false });

					if (response.AsList<CoreLicense>().Count > 0)
					{
						dgvTable.DataSource = response;
					}

					FormatColumns();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void dgvTable_DoubleClick(object sender, EventArgs e)
		{
			btnAdvanced.PerformClick();
		}

		private void dgvTable_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				btnDelete.PerformClick();
			}

			else if (e.KeyCode == Keys.Enter)
			{
				btnAdvanced.PerformClick();
			}
		}

		private void SecTick_Tick(object sender, EventArgs e)
		{
			lblUpdatingIn.Text = "Atualizando tabela automaticamente em " + --animationCounter + " segundos";
		}

		private async void btnRefresh_Click(object sender, EventArgs e)
		{
			await LoadData();

			AutoClosingMessageBox.Show("Atualizado", "Atualizado", 250);
		}

		private async void btnAdvanced_Click(object sender, EventArgs e)
		{
			var clickedLicense = GetSelectedLicenseOnGrid();

			if (clickedLicense != null)
			{
				using (new ControlManager(Controls))
				{
					EditAdvanced callForm = new EditAdvanced(clickedLicense);

					callForm.ShowDialog();
					await LoadData();
				}
			}
			else
				AutoClosingMessageBox.Show("Selecione uma linha para editar", "Editando...", 500);
		}

		private async Task UpdateStatus()
		{
			try
			{
				using (var conn = await DbContext.Get())
				{
					var clickedLicense = GetSelectedLicenseOnGrid();
					string query = "UPDATE CoreLicense SET Active=@Active WHERE Licensekey=@Licensekey";
					await conn.ExecuteAsync(query, new { Active = clickedLicense.Active, Licensekey = clickedLicense.Licensekey });
				}

				AutoClosingMessageBox.Show("Salvo", "Sucesso", 500);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		private async Task UpdateStatus(CoreLicense license)
		{
			try
			{
				using (var conn = await DbContext.Get())
				{
					string query = "UPDATE CoreLicense SET Active=@Active WHERE Licensekey=@Licensekey";
					await conn.ExecuteAsync(query, new { Active = license.Active, Licensekey = license.Licensekey });
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private async void pbOnOff_Click(object sender, EventArgs e)
		{
			using (new ControlManager(Controls))
			{
				foreach (DataGridViewRow row in dgvTable.SelectedRows)
				{
					var clickedLicense = GetSelectedLicenseOnGrid(row);

					if (clickedLicense != null)
					{
						if (clickedLicense.Active is false)
						{
							pbOnOff.Image = Resources.Onn;
							row.Cells[4].Value = 1;
							clickedLicense.Active = true;
						}
						else
						{
							pbOnOff.Image = Resources.Off;
							row.Cells[4].Value = 0;
							clickedLicense.Active = false;
						}

						await UpdateStatus(clickedLicense);
					}
				}
			}
		}

		private async void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (dgvTable.SelectedRows.Count < 0)
				{
					AutoClosingMessageBox.Show("Selecione ao menos uma linha para excluir.", "Quase lá...", 500);
					return;
				}

				using (new ControlManager(Controls))
				{
					using (var conn = await DbContext.Get())
					{
						string query = $"DELETE FROM CoreLicense WHERE Licensekey IN ('{string.Join("','", GetMultipleSelectedLicensesOnGrid().Select(x => x.Licensekey))}')";
						await conn.ExecuteAsync(query);
						await LoadData();
						AutoClosingMessageBox.Show("Dados deletados com sucesso.", "Sucesso", 500);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void tbKey_OnValueChanged(object sender, EventArgs e)
		{
			btnRegister.Enabled = string.IsNullOrEmpty(tbKey.Text) ? false : true;
		}

		private async void tbSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				await Search();
			}
			else if (e.KeyCode == Keys.Escape)
			{
				tbSearch.Text = "";

				await LoadData();
				tbSearch.Focus();
			}
		}

	}
}