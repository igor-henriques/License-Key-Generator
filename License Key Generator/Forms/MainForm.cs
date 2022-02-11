using Dapper;
using License_Key_Generator.Data;
using License_Key_Generator.License;
using License_Key_Generator.Properties;
using License_Key_Generator.Repositories;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
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

        private readonly ILicenseRepository licenseRepository = new LicenseRepository();

        public MainForm()
        {
            InitializeComponent();

            this.Load += async (obj, e) => await MainForm_Load();
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
                MessageBox.Show("Key copied to clipboard", "Key on the clipboard");
            }
        }

        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbKey.Text)) return;

                using (new ControlManager(Controls))
                {
                    await licenseRepository.InsertAsync(tbKey.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private async Task MainForm_Load()
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
                dgvTable.DataSource = null;

                dgvTable.DataSource = await licenseRepository.GetAllAsync();

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

                Clipboard.SetText(JsonConvert.SerializeObject(new { clickedLicense.User, clickedLicense.Licensekey, Product = clickedLicense.Product.ToString() }));
            }
        }

        private CoreLicense GetSelectedLicenseOnGrid()
        {
            if (dgvTable.SelectedRows.Count is 1)
            {
                return new CoreLicense()
                {
                    Id = Convert.ToInt16(dgvTable.SelectedRows[0].Cells[0].Value),
                    User = dgvTable.SelectedRows[0].Cells[1].Value?.ToString(),
                    Licensekey = dgvTable.SelectedRows[0].Cells[2].Value?.ToString(),
                    Hwid = dgvTable.SelectedRows[0].Cells[5].Value?.ToString(),
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
                    User = row.Cells[1].Value?.ToString(),
                    Licensekey = row.Cells[2].Value?.ToString(),
                    Hwid = row.Cells[5].Value?.ToString(),
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
                    User = row.Cells[1].Value?.ToString(),
                    Licensekey = row.Cells[2].Value?.ToString(),
                    Hwid = row.Cells[5].Value?.ToString(),
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
                    MessageBox.Show("Selecione uma das opções para pesquisar", "Pesquisando...");
                    return;
                }

                Models.SearchOption option = rbUsername.Checked ? Models.SearchOption.Username : Models.SearchOption.LicenseKey;

                dgvTable.DataSource = await licenseRepository.SearchBy(option, tbSearch.Text);

                FormatColumns();
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
                    dgvTable.DataSource = await licenseRepository.GetAllByStateAsync(true);

                    FormatColumns();
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
                using (new ControlManager(Controls))
                {
                    dgvTable.DataSource = await licenseRepository.GetAllByStateAsync(false);

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
            lblUpdatingIn.Text = "Update records in " + --animationCounter + " seconds";
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadData();
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
                MessageBox.Show("Selecione uma linha para editar", "Editando...");
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

                        await licenseRepository.UpdateStatus(clickedLicense);
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
                    MessageBox.Show("Selecione ao menos uma linha para excluir.", "Quase lá...");
                    return;
                }

                using (new ControlManager(Controls))
                {
                    await licenseRepository.Delete(GetMultipleSelectedLicensesOnGrid().Select(x => x.Licensekey).AsList());

                    await LoadData();

                    MessageBox.Show("Dados deletados com sucesso.", "Sucesso");
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