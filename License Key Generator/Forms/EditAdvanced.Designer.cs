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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tbHWID = new System.Windows.Forms.TextBox();
            this.tbValidade = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.ForeColor = System.Drawing.Color.DimGray;
            this.tbName.Location = new System.Drawing.Point(20, 18);
            this.tbName.Margin = new System.Windows.Forms.Padding(5);
            this.tbName.Name = "tbName";
            this.tbName.PlaceholderText = "License owner name";
            this.tbName.Size = new System.Drawing.Size(364, 32);
            this.tbName.TabIndex = 0;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbKey
            // 
            this.tbKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbKey.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbKey.ForeColor = System.Drawing.Color.DimGray;
            this.tbKey.Location = new System.Drawing.Point(20, 73);
            this.tbKey.Margin = new System.Windows.Forms.Padding(5);
            this.tbKey.Name = "tbKey";
            this.tbKey.PlaceholderText = "License owner key";
            this.tbKey.Size = new System.Drawing.Size(364, 32);
            this.tbKey.TabIndex = 1;
            this.tbKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHWID
            // 
            this.tbHWID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbHWID.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbHWID.ForeColor = System.Drawing.Color.DimGray;
            this.tbHWID.Location = new System.Drawing.Point(20, 127);
            this.tbHWID.Margin = new System.Windows.Forms.Padding(5);
            this.tbHWID.Name = "tbHWID";
            this.tbHWID.PlaceholderText = "License owner HWID";
            this.tbHWID.Size = new System.Drawing.Size(364, 32);
            this.tbHWID.TabIndex = 2;
            this.tbHWID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbValidade
            // 
            this.tbValidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbValidade.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbValidade.ForeColor = System.Drawing.Color.DimGray;
            this.tbValidade.Location = new System.Drawing.Point(20, 184);
            this.tbValidade.Margin = new System.Windows.Forms.Padding(5);
            this.tbValidade.Name = "tbValidade";
            this.tbValidade.PlaceholderText = "License owner date";
            this.tbValidade.Size = new System.Drawing.Size(364, 32);
            this.tbValidade.TabIndex = 3;
            this.tbValidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.Location = new System.Drawing.Point(-1, 302);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(407, 91);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Save";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVoltar.Location = new System.Drawing.Point(-1, 400);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(407, 51);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Return";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cbProducts
            // 
            this.cbProducts.BackColor = System.Drawing.Color.DimGray;
            this.cbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbProducts.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbProducts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(19, 253);
            this.cbProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(364, 25);
            this.cbProducts.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(20, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select product type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(404, 451);
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditAdvanced";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Update";
            this.Load += new System.EventHandler(this.EditAdvanced_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TextBox tbHWID;
        private System.Windows.Forms.TextBox tbValidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Label label1;
    }
}