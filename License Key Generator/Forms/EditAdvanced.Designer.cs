namespace License_Key_Generator.Forms
{
    partial class EditAdvanced
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAdvanced));
            this.tbName = new ns1.BunifuMaterialTextbox();
            this.tbKey = new ns1.BunifuMaterialTextbox();
            this.tbHWID = new ns1.BunifuMaterialTextbox();
            this.tbValidade = new ns1.BunifuMaterialTextbox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.tbName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbName.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbName.HintText = "Insira o novo Username";
            this.tbName.isPassword = false;
            this.tbName.LineFocusedColor = System.Drawing.Color.Brown;
            this.tbName.LineIdleColor = System.Drawing.Color.Gray;
            this.tbName.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.tbName.LineThickness = 3;
            this.tbName.Location = new System.Drawing.Point(17, 11);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(313, 31);
            this.tbName.TabIndex = 0;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbKey
            // 
            this.tbKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbKey.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKey.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbKey.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbKey.HintText = "Insira a nova Key";
            this.tbKey.isPassword = false;
            this.tbKey.LineFocusedColor = System.Drawing.Color.Brown;
            this.tbKey.LineIdleColor = System.Drawing.Color.Gray;
            this.tbKey.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.tbKey.LineThickness = 3;
            this.tbKey.Location = new System.Drawing.Point(17, 59);
            this.tbKey.Margin = new System.Windows.Forms.Padding(4);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(313, 31);
            this.tbKey.TabIndex = 1;
            this.tbKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHWID
            // 
            this.tbHWID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbHWID.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.tbHWID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbHWID.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbHWID.HintText = "Insira a nova HWID";
            this.tbHWID.isPassword = false;
            this.tbHWID.LineFocusedColor = System.Drawing.Color.Brown;
            this.tbHWID.LineIdleColor = System.Drawing.Color.Gray;
            this.tbHWID.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.tbHWID.LineThickness = 3;
            this.tbHWID.Location = new System.Drawing.Point(17, 106);
            this.tbHWID.Margin = new System.Windows.Forms.Padding(4);
            this.tbHWID.Name = "tbHWID";
            this.tbHWID.Size = new System.Drawing.Size(313, 31);
            this.tbHWID.TabIndex = 2;
            this.tbHWID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbValidade
            // 
            this.tbValidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbValidade.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.tbValidade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbValidade.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbValidade.HintText = "Insira a nova validade no padrão dd/mm/yy";
            this.tbValidade.isPassword = false;
            this.tbValidade.LineFocusedColor = System.Drawing.Color.Brown;
            this.tbValidade.LineIdleColor = System.Drawing.Color.Gray;
            this.tbValidade.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.tbValidade.LineThickness = 3;
            this.tbValidade.Location = new System.Drawing.Point(17, 155);
            this.tbValidade.Margin = new System.Windows.Forms.Padding(4);
            this.tbValidade.Name = "tbValidade";
            this.tbValidade.Size = new System.Drawing.Size(313, 31);
            this.tbValidade.TabIndex = 3;
            this.tbValidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.Location = new System.Drawing.Point(-1, 262);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(349, 79);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVoltar.Location = new System.Drawing.Point(-1, 347);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(349, 44);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cbProducts
            // 
            this.cbProducts.BackColor = System.Drawing.Color.DimGray;
            this.cbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbProducts.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(16, 219);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(313, 25);
            this.cbProducts.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(91, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecione o tipo de produto";
            // 
            // EditAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(346, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbValidade);
            this.Controls.Add(this.tbHWID);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditAdvanced";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualização de Licença";
            this.Load += new System.EventHandler(this.EditAdvanced_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuMaterialTextbox tbName;
        private ns1.BunifuMaterialTextbox tbKey;
        private ns1.BunifuMaterialTextbox tbHWID;
        private ns1.BunifuMaterialTextbox tbValidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Label label1;
    }
}