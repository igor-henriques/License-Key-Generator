namespace License_Key_Generator.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tbKey = new ns1.BunifuMaterialTextbox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.btnCopy = new ns1.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.tbSearch = new ns1.BunifuMaterialTextbox();
            this.rbUsername = new System.Windows.Forms.RadioButton();
            this.rbOnn = new System.Windows.Forms.RadioButton();
            this.btnResetSearch = new ns1.BunifuImageButton();
            this.pbOnOff = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new ns1.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new ns1.BunifuImageButton();
            this.rbOff = new System.Windows.Forms.RadioButton();
            this.UpdateTime = new System.Windows.Forms.Timer(this.components);
            this.lblUpdatingIn = new System.Windows.Forms.Label();
            this.SecTick = new System.Windows.Forms.Timer(this.components);
            this.rbKey = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResetSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(487, 86);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(223, 43);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Gerar";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbKey
            // 
            this.tbKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbKey.Enabled = false;
            this.tbKey.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.tbKey.ForeColor = System.Drawing.Color.Black;
            this.tbKey.HintForeColor = System.Drawing.Color.Empty;
            this.tbKey.HintText = "";
            this.tbKey.isPassword = false;
            this.tbKey.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbKey.LineIdleColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbKey.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbKey.LineThickness = 4;
            this.tbKey.Location = new System.Drawing.Point(16, 86);
            this.tbKey.Margin = new System.Windows.Forms.Padding(6);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(426, 41);
            this.tbKey.TabIndex = 0;
            this.tbKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbKey.OnValueChanged += new System.EventHandler(this.tbKey_OnValueChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Enabled = false;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(713, 86);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(202, 43);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.headerPanel.Controls.Add(this.tbKey);
            this.headerPanel.Controls.Add(this.btnCopy);
            this.headerPanel.Controls.Add(this.btnRegister);
            this.headerPanel.Controls.Add(this.btnGenerate);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Location = new System.Drawing.Point(-4, 25);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(933, 136);
            this.headerPanel.TabIndex = 0;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.Transparent;
            this.btnCopy.Enabled = false;
            this.btnCopy.Image = global::License_Key_Generator.Properties.Resources.clipboard;
            this.btnCopy.ImageActive = null;
            this.btnCopy.Location = new System.Drawing.Point(444, 86);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(40, 43);
            this.btnCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCopy.TabIndex = 2;
            this.btnCopy.TabStop = false;
            this.btnCopy.Zoom = 10;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Pieces of Eight", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(920, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Controle de Licença";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AllowUserToResizeColumns = false;
            this.dgvTable.AllowUserToResizeRows = false;
            this.dgvTable.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTable.GridColor = System.Drawing.Color.DarkGray;
            this.dgvTable.Location = new System.Drawing.Point(0, 188);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(922, 270);
            this.dgvTable.TabIndex = 3;
            this.dgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellClick);
            this.dgvTable.DoubleClick += new System.EventHandler(this.dgvTable_DoubleClick);
            this.dgvTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTable_KeyDown);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.FlatAppearance.BorderSize = 0;
            this.btnAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvanced.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.btnAdvanced.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdvanced.Location = new System.Drawing.Point(-4, 518);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(415, 71);
            this.btnAdvanced.TabIndex = 2;
            this.btnAdvanced.Text = "Alteração Avançada";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(504, 518);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(425, 71);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblExit
            // 
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblExit.Location = new System.Drawing.Point(874, -14);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(46, 50);
            this.lblExit.TabIndex = 7;
            this.lblExit.Text = "X";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.DimGray;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbSearch.HintForeColor = System.Drawing.Color.Gainsboro;
            this.tbSearch.HintText = "Digite para pesquisar";
            this.tbSearch.isPassword = false;
            this.tbSearch.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.tbSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSearch.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.tbSearch.LineThickness = 3;
            this.tbSearch.Location = new System.Drawing.Point(80, 467);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(331, 44);
            this.tbSearch.TabIndex = 11;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // rbUsername
            // 
            this.rbUsername.AutoSize = true;
            this.rbUsername.Checked = true;
            this.rbUsername.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbUsername.Location = new System.Drawing.Point(639, 469);
            this.rbUsername.Name = "rbUsername";
            this.rbUsername.Size = new System.Drawing.Size(78, 19);
            this.rbUsername.TabIndex = 12;
            this.rbUsername.TabStop = true;
            this.rbUsername.Text = "Username";
            this.rbUsername.UseVisualStyleBackColor = true;
            // 
            // rbOnn
            // 
            this.rbOnn.AutoSize = true;
            this.rbOnn.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOnn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbOnn.Location = new System.Drawing.Point(639, 494);
            this.rbOnn.Name = "rbOnn";
            this.rbOnn.Size = new System.Drawing.Size(111, 19);
            this.rbOnn.TabIndex = 12;
            this.rbOnn.Text = "Situação (Ativo)";
            this.rbOnn.UseVisualStyleBackColor = true;
            this.rbOnn.CheckedChanged += new System.EventHandler(this.rbOnn_CheckedChanged);
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnResetSearch.Image = global::License_Key_Generator.Properties.Resources.bin;
            this.btnResetSearch.ImageActive = null;
            this.btnResetSearch.Location = new System.Drawing.Point(12, 467);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(61, 45);
            this.btnResetSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnResetSearch.TabIndex = 14;
            this.btnResetSearch.TabStop = false;
            this.btnResetSearch.Zoom = 10;
            this.btnResetSearch.Click += new System.EventHandler(this.btnResetSearch_Click);
            // 
            // pbOnOff
            // 
            this.pbOnOff.BackColor = System.Drawing.Color.Transparent;
            this.pbOnOff.Image = global::License_Key_Generator.Properties.Resources.Off;
            this.pbOnOff.Location = new System.Drawing.Point(864, 162);
            this.pbOnOff.Name = "pbOnOff";
            this.pbOnOff.Size = new System.Drawing.Size(27, 25);
            this.pbOnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOnOff.TabIndex = 9;
            this.pbOnOff.TabStop = false;
            this.pbOnOff.Click += new System.EventHandler(this.pbOnOff_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Image = global::License_Key_Generator.Properties.Resources.Refresh;
            this.btnRefresh.ImageActive = null;
            this.btnRefresh.Location = new System.Drawing.Point(423, 527);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 49);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Zoom = 10;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::License_Key_Generator.Properties.Resources.favicon;
            this.pictureBox1.Location = new System.Drawing.Point(13, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = global::License_Key_Generator.Properties.Resources.lupa;
            this.btnSearch.ImageActive = null;
            this.btnSearch.Location = new System.Drawing.Point(423, 467);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 45);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 14;
            this.btnSearch.TabStop = false;
            this.btnSearch.Zoom = 10;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbOff
            // 
            this.rbOff.AutoSize = true;
            this.rbOff.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOff.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbOff.Location = new System.Drawing.Point(753, 494);
            this.rbOff.Name = "rbOff";
            this.rbOff.Size = new System.Drawing.Size(119, 19);
            this.rbOff.TabIndex = 12;
            this.rbOff.Text = "Situação (Inativo)";
            this.rbOff.UseVisualStyleBackColor = true;
            this.rbOff.CheckedChanged += new System.EventHandler(this.rbOff_CheckedChanged);
            // 
            // UpdateTime
            // 
            this.UpdateTime.Enabled = true;
            this.UpdateTime.Interval = 60000;
            this.UpdateTime.Tick += new System.EventHandler(this.UpdateTime_Tick);
            // 
            // lblUpdatingIn
            // 
            this.lblUpdatingIn.AutoSize = true;
            this.lblUpdatingIn.BackColor = System.Drawing.Color.DimGray;
            this.lblUpdatingIn.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatingIn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUpdatingIn.Location = new System.Drawing.Point(5, 169);
            this.lblUpdatingIn.Name = "lblUpdatingIn";
            this.lblUpdatingIn.Size = new System.Drawing.Size(192, 13);
            this.lblUpdatingIn.TabIndex = 15;
            this.lblUpdatingIn.Text = "Atualizando tabela em 60 segundos";
            // 
            // SecTick
            // 
            this.SecTick.Enabled = true;
            this.SecTick.Interval = 1000;
            this.SecTick.Tick += new System.EventHandler(this.SecTick_Tick);
            // 
            // rbKey
            // 
            this.rbKey.AutoSize = true;
            this.rbKey.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKey.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbKey.Location = new System.Drawing.Point(753, 469);
            this.rbKey.Name = "rbKey";
            this.rbKey.Size = new System.Drawing.Size(44, 19);
            this.rbKey.TabIndex = 12;
            this.rbKey.Text = "Key";
            this.rbKey.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(500, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Pesquisar por:";
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(836, -10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 39);
            this.label5.TabIndex = 7;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(923, 591);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUpdatingIn);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnResetSearch);
            this.Controls.Add(this.rbOff);
            this.Controls.Add(this.rbOnn);
            this.Controls.Add(this.rbKey);
            this.Controls.Add(this.rbUsername);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pbOnOff);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Licenças - PW Project";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResetSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private ns1.BunifuMaterialTextbox tbKey;
        private ns1.BunifuImageButton btnCopy;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTable;
        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblExit;
        private ns1.BunifuImageButton btnRefresh;
        private System.Windows.Forms.PictureBox pbOnOff;
        private System.Windows.Forms.RadioButton rbOnn;
        private System.Windows.Forms.RadioButton rbUsername;
        private ns1.BunifuMaterialTextbox tbSearch;
        private ns1.BunifuImageButton btnResetSearch;
        private ns1.BunifuImageButton btnSearch;
        private System.Windows.Forms.RadioButton rbOff;
        private System.Windows.Forms.Timer UpdateTime;
        private System.Windows.Forms.Label lblUpdatingIn;
        private System.Windows.Forms.Timer SecTick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbKey;
        private System.Windows.Forms.Label label5;
    }
}

