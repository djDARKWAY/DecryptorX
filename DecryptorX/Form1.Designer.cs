namespace DecryptorX
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblCipher = new System.Windows.Forms.Label();
            this.cboCipher = new System.Windows.Forms.ComboBox();
            this.gbxCaesar = new System.Windows.Forms.GroupBox();
            this.txtLanguageCeasar = new System.Windows.Forms.TextBox();
            this.lblC2 = new System.Windows.Forms.Label();
            this.lblC1 = new System.Windows.Forms.Label();
            this.dgvCeaserResults = new System.Windows.Forms.DataGridView();
            this.shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decryptedText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMessageCaesar = new System.Windows.Forms.TextBox();
            this.btnDecryptCaesar = new System.Windows.Forms.Button();
            this.panelL = new System.Windows.Forms.Panel();
            this.panelR = new System.Windows.Forms.Panel();
            this.panelB = new System.Windows.Forms.Panel();
            this.timerSize = new System.Windows.Forms.Timer(this.components);
            this.gbxMorse = new System.Windows.Forms.GroupBox();
            this.lblMorseI = new System.Windows.Forms.Label();
            this.txtMorseResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessageMorse = new System.Windows.Forms.TextBox();
            this.txtMorseE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMorseL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMorseS = new System.Windows.Forms.TextBox();
            this.panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.gbxCaesar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCeaserResults)).BeginInit();
            this.gbxMorse.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.Gold;
            this.panelToolbar.Controls.Add(this.lblTitle);
            this.panelToolbar.Controls.Add(this.btnClose);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Location = new System.Drawing.Point(0, 0);
            this.panelToolbar.Margin = new System.Windows.Forms.Padding(4);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(1053, 30);
            this.panelToolbar.TabIndex = 8;
            this.panelToolbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelToolbar_MouseDown);
            this.panelToolbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelToolbar_MouseMove);
            this.panelToolbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelToolbar_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(3, 4);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 22);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "DecryptorX v2.2.1";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(11)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::DecryptorX.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1027, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCipher
            // 
            this.lblCipher.AutoSize = true;
            this.lblCipher.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCipher.Location = new System.Drawing.Point(12, 40);
            this.lblCipher.Name = "lblCipher";
            this.lblCipher.Size = new System.Drawing.Size(72, 19);
            this.lblCipher.TabIndex = 7;
            this.lblCipher.Text = "Cipher:";
            // 
            // cboCipher
            // 
            this.cboCipher.BackColor = System.Drawing.Color.Black;
            this.cboCipher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCipher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCipher.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCipher.ForeColor = System.Drawing.Color.Gold;
            this.cboCipher.FormattingEnabled = true;
            this.cboCipher.Items.AddRange(new object[] {
            "Caesar Cipher",
            "Morse Code"});
            this.cboCipher.Location = new System.Drawing.Point(84, 40);
            this.cboCipher.MaxDropDownItems = 3;
            this.cboCipher.Name = "cboCipher";
            this.cboCipher.Size = new System.Drawing.Size(239, 22);
            this.cboCipher.TabIndex = 14;
            this.cboCipher.SelectedIndexChanged += new System.EventHandler(this.cboCipher_SelectedIndexChanged);
            // 
            // gbxCaesar
            // 
            this.gbxCaesar.BackColor = System.Drawing.Color.Transparent;
            this.gbxCaesar.Controls.Add(this.txtLanguageCeasar);
            this.gbxCaesar.Controls.Add(this.lblC2);
            this.gbxCaesar.Controls.Add(this.lblC1);
            this.gbxCaesar.Controls.Add(this.dgvCeaserResults);
            this.gbxCaesar.Controls.Add(this.txtMessageCaesar);
            this.gbxCaesar.Controls.Add(this.btnDecryptCaesar);
            this.gbxCaesar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCaesar.ForeColor = System.Drawing.Color.Gold;
            this.gbxCaesar.Location = new System.Drawing.Point(16, 70);
            this.gbxCaesar.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCaesar.Name = "gbxCaesar";
            this.gbxCaesar.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCaesar.Size = new System.Drawing.Size(307, 342);
            this.gbxCaesar.TabIndex = 21;
            this.gbxCaesar.TabStop = false;
            this.gbxCaesar.Text = "Caesar Cipher";
            // 
            // txtLanguageCeasar
            // 
            this.txtLanguageCeasar.BackColor = System.Drawing.Color.Black;
            this.txtLanguageCeasar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLanguageCeasar.Enabled = false;
            this.txtLanguageCeasar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanguageCeasar.ForeColor = System.Drawing.Color.Gold;
            this.txtLanguageCeasar.Location = new System.Drawing.Point(83, 94);
            this.txtLanguageCeasar.Margin = new System.Windows.Forms.Padding(4);
            this.txtLanguageCeasar.MaxLength = 256;
            this.txtLanguageCeasar.Name = "txtLanguageCeasar";
            this.txtLanguageCeasar.Size = new System.Drawing.Size(200, 16);
            this.txtLanguageCeasar.TabIndex = 23;
            this.txtLanguageCeasar.Text = "-";
            // 
            // lblC2
            // 
            this.lblC2.AutoSize = true;
            this.lblC2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC2.Location = new System.Drawing.Point(13, 94);
            this.lblC2.Name = "lblC2";
            this.lblC2.Size = new System.Drawing.Size(70, 15);
            this.lblC2.TabIndex = 22;
            this.lblC2.Text = "Language:";
            // 
            // lblC1
            // 
            this.lblC1.AutoSize = true;
            this.lblC1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC1.Location = new System.Drawing.Point(13, 27);
            this.lblC1.Name = "lblC1";
            this.lblC1.Size = new System.Drawing.Size(63, 15);
            this.lblC1.TabIndex = 22;
            this.lblC1.Text = "Message:";
            // 
            // dgvCeaserResults
            // 
            this.dgvCeaserResults.AllowUserToAddRows = false;
            this.dgvCeaserResults.AllowUserToDeleteRows = false;
            this.dgvCeaserResults.AllowUserToResizeColumns = false;
            this.dgvCeaserResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCeaserResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCeaserResults.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCeaserResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCeaserResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCeaserResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shift,
            this.decryptedText});
            this.dgvCeaserResults.Location = new System.Drawing.Point(16, 115);
            this.dgvCeaserResults.MultiSelect = false;
            this.dgvCeaserResults.Name = "dgvCeaserResults";
            this.dgvCeaserResults.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCeaserResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCeaserResults.RowHeadersVisible = false;
            this.dgvCeaserResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvCeaserResults.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCeaserResults.RowTemplate.Height = 20;
            this.dgvCeaserResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCeaserResults.Size = new System.Drawing.Size(274, 207);
            this.dgvCeaserResults.TabIndex = 22;
            this.dgvCeaserResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCeaserResults_CellDoubleClick);
            // 
            // shift
            // 
            this.shift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.shift.DefaultCellStyle = dataGridViewCellStyle3;
            this.shift.HeaderText = "→";
            this.shift.MaxInputLength = 10;
            this.shift.Name = "shift";
            this.shift.ReadOnly = true;
            this.shift.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.shift.Width = 35;
            // 
            // decryptedText
            // 
            this.decryptedText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptedText.DefaultCellStyle = dataGridViewCellStyle4;
            this.decryptedText.HeaderText = "Decrypted text";
            this.decryptedText.Name = "decryptedText";
            this.decryptedText.ReadOnly = true;
            this.decryptedText.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtMessageCaesar
            // 
            this.txtMessageCaesar.BackColor = System.Drawing.Color.Black;
            this.txtMessageCaesar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessageCaesar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageCaesar.ForeColor = System.Drawing.Color.Gold;
            this.txtMessageCaesar.Location = new System.Drawing.Point(77, 24);
            this.txtMessageCaesar.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessageCaesar.MaxLength = 1024;
            this.txtMessageCaesar.Name = "txtMessageCaesar";
            this.txtMessageCaesar.Size = new System.Drawing.Size(213, 23);
            this.txtMessageCaesar.TabIndex = 21;
            // 
            // btnDecryptCaesar
            // 
            this.btnDecryptCaesar.BackColor = System.Drawing.Color.Gold;
            this.btnDecryptCaesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecryptCaesar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDecryptCaesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecryptCaesar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptCaesar.ForeColor = System.Drawing.Color.Black;
            this.btnDecryptCaesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecryptCaesar.Location = new System.Drawing.Point(16, 53);
            this.btnDecryptCaesar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDecryptCaesar.Name = "btnDecryptCaesar";
            this.btnDecryptCaesar.Size = new System.Drawing.Size(274, 37);
            this.btnDecryptCaesar.TabIndex = 20;
            this.btnDecryptCaesar.Text = "DECRYPT";
            this.btnDecryptCaesar.UseVisualStyleBackColor = false;
            this.btnDecryptCaesar.Click += new System.EventHandler(this.btnDecryptCaesar_Click);
            // 
            // panelL
            // 
            this.panelL.BackColor = System.Drawing.Color.Gold;
            this.panelL.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelL.Location = new System.Drawing.Point(0, 30);
            this.panelL.Name = "panelL";
            this.panelL.Size = new System.Drawing.Size(3, 398);
            this.panelL.TabIndex = 22;
            // 
            // panelR
            // 
            this.panelR.BackColor = System.Drawing.Color.Gold;
            this.panelR.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelR.Location = new System.Drawing.Point(1050, 30);
            this.panelR.Name = "panelR";
            this.panelR.Size = new System.Drawing.Size(3, 398);
            this.panelR.TabIndex = 23;
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.Color.Gold;
            this.panelB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelB.Location = new System.Drawing.Point(3, 425);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(1047, 3);
            this.panelB.TabIndex = 24;
            // 
            // timerSize
            // 
            this.timerSize.Interval = 1;
            this.timerSize.Tick += new System.EventHandler(this.timerSize_Tick);
            // 
            // gbxMorse
            // 
            this.gbxMorse.BackColor = System.Drawing.Color.Transparent;
            this.gbxMorse.Controls.Add(this.lblMorseI);
            this.gbxMorse.Controls.Add(this.txtMorseResult);
            this.gbxMorse.Controls.Add(this.label4);
            this.gbxMorse.Controls.Add(this.label3);
            this.gbxMorse.Controls.Add(this.txtMessageMorse);
            this.gbxMorse.Controls.Add(this.txtMorseE);
            this.gbxMorse.Controls.Add(this.label2);
            this.gbxMorse.Controls.Add(this.txtMorseL);
            this.gbxMorse.Controls.Add(this.label1);
            this.gbxMorse.Controls.Add(this.txtMorseS);
            this.gbxMorse.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMorse.ForeColor = System.Drawing.Color.LightGray;
            this.gbxMorse.Location = new System.Drawing.Point(345, 70);
            this.gbxMorse.Margin = new System.Windows.Forms.Padding(4);
            this.gbxMorse.Name = "gbxMorse";
            this.gbxMorse.Padding = new System.Windows.Forms.Padding(4);
            this.gbxMorse.Size = new System.Drawing.Size(307, 342);
            this.gbxMorse.TabIndex = 24;
            this.gbxMorse.TabStop = false;
            this.gbxMorse.Text = "Morse Code";
            this.gbxMorse.Visible = false;
            // 
            // lblMorseI
            // 
            this.lblMorseI.AutoSize = true;
            this.lblMorseI.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMorseI.Location = new System.Drawing.Point(90, 85);
            this.lblMorseI.Name = "lblMorseI";
            this.lblMorseI.Size = new System.Drawing.Size(126, 15);
            this.lblMorseI.TabIndex = 30;
            this.lblMorseI.Text = "Invalid settings!";
            this.lblMorseI.Visible = false;
            // 
            // txtMorseResult
            // 
            this.txtMorseResult.BackColor = System.Drawing.Color.Black;
            this.txtMorseResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMorseResult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorseResult.ForeColor = System.Drawing.Color.LightGray;
            this.txtMorseResult.Location = new System.Drawing.Point(16, 104);
            this.txtMorseResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtMorseResult.MaxLength = 1024;
            this.txtMorseResult.Multiline = true;
            this.txtMorseResult.Name = "txtMorseResult";
            this.txtMorseResult.ReadOnly = true;
            this.txtMorseResult.Size = new System.Drawing.Size(274, 220);
            this.txtMorseResult.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Message:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Space:";
            // 
            // txtMessageMorse
            // 
            this.txtMessageMorse.BackColor = System.Drawing.Color.Black;
            this.txtMessageMorse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessageMorse.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageMorse.ForeColor = System.Drawing.Color.LightGray;
            this.txtMessageMorse.Location = new System.Drawing.Point(77, 55);
            this.txtMessageMorse.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessageMorse.MaxLength = 1024;
            this.txtMessageMorse.Name = "txtMessageMorse";
            this.txtMessageMorse.Size = new System.Drawing.Size(213, 23);
            this.txtMessageMorse.TabIndex = 24;
            this.txtMessageMorse.TextChanged += new System.EventHandler(this.txtMessageMorse_TextChanged);
            // 
            // txtMorseE
            // 
            this.txtMorseE.BackColor = System.Drawing.Color.Black;
            this.txtMorseE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMorseE.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorseE.ForeColor = System.Drawing.Color.LightGray;
            this.txtMorseE.Location = new System.Drawing.Point(270, 24);
            this.txtMorseE.Margin = new System.Windows.Forms.Padding(4);
            this.txtMorseE.MaxLength = 1;
            this.txtMorseE.Name = "txtMorseE";
            this.txtMorseE.Size = new System.Drawing.Size(19, 23);
            this.txtMorseE.TabIndex = 28;
            this.txtMorseE.Text = "/";
            this.txtMorseE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMorseE.TextChanged += new System.EventHandler(this.txtMorseE_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Long:";
            // 
            // txtMorseL
            // 
            this.txtMorseL.BackColor = System.Drawing.Color.Black;
            this.txtMorseL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMorseL.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorseL.ForeColor = System.Drawing.Color.LightGray;
            this.txtMorseL.Location = new System.Drawing.Point(161, 24);
            this.txtMorseL.Margin = new System.Windows.Forms.Padding(4);
            this.txtMorseL.MaxLength = 1;
            this.txtMorseL.Name = "txtMorseL";
            this.txtMorseL.Size = new System.Drawing.Size(19, 23);
            this.txtMorseL.TabIndex = 26;
            this.txtMorseL.Text = "-";
            this.txtMorseL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMorseL.TextChanged += new System.EventHandler(this.txtMorseL_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Short:";
            // 
            // txtMorseS
            // 
            this.txtMorseS.BackColor = System.Drawing.Color.Black;
            this.txtMorseS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMorseS.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorseS.ForeColor = System.Drawing.Color.LightGray;
            this.txtMorseS.Location = new System.Drawing.Point(64, 24);
            this.txtMorseS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMorseS.MaxLength = 1;
            this.txtMorseS.Name = "txtMorseS";
            this.txtMorseS.Size = new System.Drawing.Size(19, 23);
            this.txtMorseS.TabIndex = 24;
            this.txtMorseS.Text = ".";
            this.txtMorseS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMorseS.TextChanged += new System.EventHandler(this.txtMorseS_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1053, 428);
            this.ControlBox = false;
            this.Controls.Add(this.gbxMorse);
            this.Controls.Add(this.panelB);
            this.Controls.Add(this.panelR);
            this.Controls.Add(this.panelL);
            this.Controls.Add(this.gbxCaesar);
            this.Controls.Add(this.cboCipher);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.lblCipher);
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.gbxCaesar.ResumeLayout(false);
            this.gbxCaesar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCeaserResults)).EndInit();
            this.gbxMorse.ResumeLayout(false);
            this.gbxMorse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblCipher;
        private System.Windows.Forms.ComboBox cboCipher;
        private System.Windows.Forms.GroupBox gbxCaesar;
        private System.Windows.Forms.TextBox txtMessageCaesar;
        private System.Windows.Forms.DataGridView dgvCeaserResults;
        private System.Windows.Forms.Label lblC2;
        private System.Windows.Forms.Label lblC1;
        private System.Windows.Forms.Panel panelL;
        private System.Windows.Forms.Panel panelR;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn decryptedText;
        private System.Windows.Forms.TextBox txtLanguageCeasar;
        private System.Windows.Forms.Timer timerSize;
        private System.Windows.Forms.GroupBox gbxMorse;
        private System.Windows.Forms.Button btnDecryptCaesar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMorseE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMorseL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMorseS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMessageMorse;
        private System.Windows.Forms.TextBox txtMorseResult;
        private System.Windows.Forms.Label lblMorseI;
    }
}

