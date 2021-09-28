using Dapper;
using License_Key_Generator.Data;
using License_Key_Generator.License;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace License_Key_Generator.Forms
{
    public partial class EditAdvanced : Form
    {
        private CoreLicense currentLicense;

        public EditAdvanced(CoreLicense currentLicense)
        {
            InitializeComponent();

            this.Cursor = AnimatedCurs.Create(Path.Combine(Application.StartupPath, "7updot.ani"));
            this.currentLicense = currentLicense;

            for (int i = 0; i <= Enum.GetValues(typeof(Product)).Length - 1; i++)
            {
                cbProducts.Items.Add((Product)i);
            }

            cbProducts.SelectedIndex = (int)(Product)Enum.Parse(typeof(Product), currentLicense.Product.ToString(), true);
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {                
                if (MessageBox.Show("Tem certeza que deseja salvar?", "Salvando...", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(tbHWID.Text))
                    {
                        tbHWID.Text = "0";
                    }

                    string query = "UPDATE CoreLicense SET User=@User,Hwid=@Hwid,Licensekey=@Licensekey,Validade=@Validade,Product=@Product WHERE Id=@Id";

                    using (var conn = await DbContext.Get())
                    {
                        await conn.ExecuteAsync(query, new
                        {
                            User = tbName.Text.Trim(),
                            Hwid = tbHWID.Text.Trim(),
                            Licensekey = tbKey.Text.Trim(),
                            Validade = tbValidade.Text == "0" ? Convert.ToDateTime("0000-00-00") : Convert.ToDateTime(Convert.ToDateTime(tbValidade.Text).ToString("yyyy-MM-dd")),
                            Product = cbProducts.SelectedIndex,
                            Id = currentLicense.Id
                        });
                    }

                    AutoClosingMessageBox.Show("Dados atualizados com sucesso", "Sucesso", 500);

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditAdvanced_Load(object sender, EventArgs e)
        {
            if (currentLicense != null)
            {
                tbHWID.Text = currentLicense.Hwid;
                tbKey.Text = currentLicense.Licensekey;
                tbName.Text = currentLicense.User;
                tbValidade.Text = currentLicense.Validade.ToString("dd/MM/yyyy");
            }
        }
    }
}