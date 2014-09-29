namespace EldarMailLogParse
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonExportResult = new System.Windows.Forms.Button();
            this.buttonCheckFromTo = new System.Windows.Forms.Button();
            this.buttonCheckTo = new System.Windows.Forms.Button();
            this.buttonClearFilters = new System.Windows.Forms.Button();
            this.buttonCheckFrom = new System.Windows.Forms.Button();
            this.buttonParse = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataTableLogEmailDataGridView = new System.Windows.Forms.DataGridView();
            this.IsMain = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxIncludeCC = new System.Windows.Forms.CheckBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkResultDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDownIntervalTo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxToList = new System.Windows.Forms.ListBox();
            this.buttonDellTo = new System.Windows.Forms.Button();
            this.buttonAddTo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxToMailToAddList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxFromList = new System.Windows.Forms.ListBox();
            this.buttonDellFrom = new System.Windows.Forms.Button();
            this.buttonAddFrom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownIntervalFrom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFromMailToAddList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxDBPassword = new System.Windows.Forms.TextBox();
            this.textBoxDBLogin = new System.Windows.Forms.TextBox();
            this.textBoxDBName = new System.Windows.Forms.TextBox();
            this.textBoxDBHost = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.checkResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMain = new EldarMailLogParse.DataSetMain();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableLogEmailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LateDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableLogEmailDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkResultDataGridView)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalTo)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalFrom)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableLogEmailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonExportResult);
            this.groupBox1.Controls.Add(this.buttonCheckFromTo);
            this.groupBox1.Controls.Add(this.buttonCheckTo);
            this.groupBox1.Controls.Add(this.buttonClearFilters);
            this.groupBox1.Controls.Add(this.buttonCheckFrom);
            this.groupBox1.Location = new System.Drawing.Point(538, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // buttonExportResult
            // 
            this.buttonExportResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportResult.Location = new System.Drawing.Point(494, 20);
            this.buttonExportResult.Name = "buttonExportResult";
            this.buttonExportResult.Size = new System.Drawing.Size(108, 23);
            this.buttonExportResult.TabIndex = 10;
            this.buttonExportResult.Text = "Export Result";
            this.buttonExportResult.UseVisualStyleBackColor = true;
            this.buttonExportResult.Click += new System.EventHandler(this.buttonExportResult_Click);
            // 
            // buttonCheckFromTo
            // 
            this.buttonCheckFromTo.Location = new System.Drawing.Point(252, 20);
            this.buttonCheckFromTo.Name = "buttonCheckFromTo";
            this.buttonCheckFromTo.Size = new System.Drawing.Size(108, 23);
            this.buttonCheckFromTo.TabIndex = 9;
            this.buttonCheckFromTo.Text = "Check From X To";
            this.buttonCheckFromTo.UseVisualStyleBackColor = true;
            this.buttonCheckFromTo.Click += new System.EventHandler(this.buttonCheckFromTo_Click);
            // 
            // buttonCheckTo
            // 
            this.buttonCheckTo.Location = new System.Drawing.Point(138, 20);
            this.buttonCheckTo.Name = "buttonCheckTo";
            this.buttonCheckTo.Size = new System.Drawing.Size(108, 23);
            this.buttonCheckTo.TabIndex = 8;
            this.buttonCheckTo.Text = "Check To";
            this.buttonCheckTo.UseVisualStyleBackColor = true;
            this.buttonCheckTo.Click += new System.EventHandler(this.buttonCheckTo_Click);
            // 
            // buttonClearFilters
            // 
            this.buttonClearFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearFilters.Location = new System.Drawing.Point(608, 20);
            this.buttonClearFilters.Name = "buttonClearFilters";
            this.buttonClearFilters.Size = new System.Drawing.Size(99, 23);
            this.buttonClearFilters.TabIndex = 7;
            this.buttonClearFilters.Text = "Clear Filters";
            this.buttonClearFilters.UseVisualStyleBackColor = true;
            this.buttonClearFilters.Click += new System.EventHandler(this.buttonClearFilters_Click);
            // 
            // buttonCheckFrom
            // 
            this.buttonCheckFrom.Location = new System.Drawing.Point(24, 20);
            this.buttonCheckFrom.Name = "buttonCheckFrom";
            this.buttonCheckFrom.Size = new System.Drawing.Size(108, 23);
            this.buttonCheckFrom.TabIndex = 7;
            this.buttonCheckFrom.Text = "Check From";
            this.buttonCheckFrom.UseVisualStyleBackColor = true;
            this.buttonCheckFrom.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonParse
            // 
            this.buttonParse.Location = new System.Drawing.Point(434, 20);
            this.buttonParse.Name = "buttonParse";
            this.buttonParse.Size = new System.Drawing.Size(75, 23);
            this.buttonParse.TabIndex = 4;
            this.buttonParse.Text = "Parse...";
            this.buttonParse.UseVisualStyleBackColor = true;
            this.buttonParse.Click += new System.EventHandler(this.buttonParse_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(353, 20);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 3;
            this.buttonOpenFile.Text = "Open...";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(100, 22);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(243, 20);
            this.textBoxFilePath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log File Location";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.dataTableLogEmailDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 538);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email Log";
            // 
            // dataTableLogEmailDataGridView
            // 
            this.dataTableLogEmailDataGridView.AllowUserToAddRows = false;
            this.dataTableLogEmailDataGridView.AllowUserToDeleteRows = false;
            this.dataTableLogEmailDataGridView.AutoGenerateColumns = false;
            this.dataTableLogEmailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableLogEmailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.IsMain});
            this.dataTableLogEmailDataGridView.DataSource = this.dataTableLogEmailBindingSource;
            this.dataTableLogEmailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTableLogEmailDataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataTableLogEmailDataGridView.Name = "dataTableLogEmailDataGridView";
            this.dataTableLogEmailDataGridView.ReadOnly = true;
            this.dataTableLogEmailDataGridView.Size = new System.Drawing.Size(514, 519);
            this.dataTableLogEmailDataGridView.TabIndex = 0;
            // 
            // IsMain
            // 
            this.IsMain.DataPropertyName = "IsMain";
            this.IsMain.HeaderText = "IsMain";
            this.IsMain.Name = "IsMain";
            this.IsMain.ReadOnly = true;
            this.IsMain.Width = 50;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.checkBoxIncludeCC);
            this.groupBox3.Controls.Add(this.dateTimePickerTo);
            this.groupBox3.Controls.Add(this.dateTimePickerFrom);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(538, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(725, 620);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Check options";
            // 
            // checkBoxIncludeCC
            // 
            this.checkBoxIncludeCC.AutoSize = true;
            this.checkBoxIncludeCC.Location = new System.Drawing.Point(480, 24);
            this.checkBoxIncludeCC.Name = "checkBoxIncludeCC";
            this.checkBoxIncludeCC.Size = new System.Drawing.Size(78, 17);
            this.checkBoxIncludeCC.TabIndex = 11;
            this.checkBoxIncludeCC.Text = "Include CC";
            this.checkBoxIncludeCC.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(300, 21);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerTo.TabIndex = 13;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(82, 21);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(145, 20);
            this.dateTimePickerFrom.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "To Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "From Date";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.checkResultDataGridView);
            this.groupBox7.Location = new System.Drawing.Point(6, 286);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(713, 328);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "CheckResult";
            // 
            // checkResultDataGridView
            // 
            this.checkResultDataGridView.AllowUserToAddRows = false;
            this.checkResultDataGridView.AllowUserToDeleteRows = false;
            this.checkResultDataGridView.AutoGenerateColumns = false;
            this.checkResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.ID,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.LateDuration});
            this.checkResultDataGridView.DataSource = this.checkResultBindingSource;
            this.checkResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkResultDataGridView.Location = new System.Drawing.Point(3, 16);
            this.checkResultDataGridView.Name = "checkResultDataGridView";
            this.checkResultDataGridView.ReadOnly = true;
            this.checkResultDataGridView.Size = new System.Drawing.Size(707, 309);
            this.checkResultDataGridView.TabIndex = 0;
            this.checkResultDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.checkResultDataGridView_CellDoubleClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Location = new System.Drawing.Point(6, 323);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(602, 146);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Checked result";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDownIntervalTo);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.listBoxToList);
            this.groupBox5.Controls.Add(this.buttonDellTo);
            this.groupBox5.Controls.Add(this.buttonAddTo);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.comboBoxToMailToAddList);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(365, 59);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(350, 221);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "To Options";
            // 
            // numericUpDownIntervalTo
            // 
            this.numericUpDownIntervalTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownIntervalTo.Location = new System.Drawing.Point(214, 37);
            this.numericUpDownIntervalTo.Name = "numericUpDownIntervalTo";
            this.numericUpDownIntervalTo.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownIntervalTo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "time interval (hour)";
            // 
            // listBoxToList
            // 
            this.listBoxToList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxToList.FormattingEnabled = true;
            this.listBoxToList.Location = new System.Drawing.Point(18, 89);
            this.listBoxToList.Name = "listBoxToList";
            this.listBoxToList.Size = new System.Drawing.Size(271, 121);
            this.listBoxToList.TabIndex = 1;
            // 
            // buttonDellTo
            // 
            this.buttonDellTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDellTo.Location = new System.Drawing.Point(295, 89);
            this.buttonDellTo.Name = "buttonDellTo";
            this.buttonDellTo.Size = new System.Drawing.Size(45, 23);
            this.buttonDellTo.TabIndex = 4;
            this.buttonDellTo.Text = "del";
            this.buttonDellTo.UseVisualStyleBackColor = true;
            this.buttonDellTo.Click += new System.EventHandler(this.buttonDellTo_Click);
            // 
            // buttonAddTo
            // 
            this.buttonAddTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTo.Location = new System.Drawing.Point(295, 34);
            this.buttonAddTo.Name = "buttonAddTo";
            this.buttonAddTo.Size = new System.Drawing.Size(45, 23);
            this.buttonAddTo.TabIndex = 4;
            this.buttonAddTo.Text = "add";
            this.buttonAddTo.UseVisualStyleBackColor = true;
            this.buttonAddTo.Click += new System.EventHandler(this.buttonAddTo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "To list";
            // 
            // comboBoxToMailToAddList
            // 
            this.comboBoxToMailToAddList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxToMailToAddList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxToMailToAddList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxToMailToAddList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToMailToAddList.FormattingEnabled = true;
            this.comboBoxToMailToAddList.Location = new System.Drawing.Point(18, 37);
            this.comboBoxToMailToAddList.Name = "comboBoxToMailToAddList";
            this.comboBoxToMailToAddList.Size = new System.Drawing.Size(190, 21);
            this.comboBoxToMailToAddList.Sorted = true;
            this.comboBoxToMailToAddList.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "To";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxFromList);
            this.groupBox4.Controls.Add(this.buttonDellFrom);
            this.groupBox4.Controls.Add(this.buttonAddFrom);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.numericUpDownIntervalFrom);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.comboBoxFromMailToAddList);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(9, 59);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 221);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "From options";
            // 
            // listBoxFromList
            // 
            this.listBoxFromList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFromList.FormattingEnabled = true;
            this.listBoxFromList.Location = new System.Drawing.Point(17, 89);
            this.listBoxFromList.Name = "listBoxFromList";
            this.listBoxFromList.Size = new System.Drawing.Size(273, 121);
            this.listBoxFromList.TabIndex = 1;
            // 
            // buttonDellFrom
            // 
            this.buttonDellFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDellFrom.Location = new System.Drawing.Point(294, 89);
            this.buttonDellFrom.Name = "buttonDellFrom";
            this.buttonDellFrom.Size = new System.Drawing.Size(45, 23);
            this.buttonDellFrom.TabIndex = 4;
            this.buttonDellFrom.Text = "del";
            this.buttonDellFrom.UseVisualStyleBackColor = true;
            this.buttonDellFrom.Click += new System.EventHandler(this.buttonDellFrom_Click);
            // 
            // buttonAddFrom
            // 
            this.buttonAddFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddFrom.Location = new System.Drawing.Point(294, 34);
            this.buttonAddFrom.Name = "buttonAddFrom";
            this.buttonAddFrom.Size = new System.Drawing.Size(45, 23);
            this.buttonAddFrom.TabIndex = 4;
            this.buttonAddFrom.Text = "add";
            this.buttonAddFrom.UseVisualStyleBackColor = true;
            this.buttonAddFrom.Click += new System.EventHandler(this.buttonAddFrom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "From list";
            // 
            // numericUpDownIntervalFrom
            // 
            this.numericUpDownIntervalFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownIntervalFrom.Location = new System.Drawing.Point(213, 37);
            this.numericUpDownIntervalFrom.Name = "numericUpDownIntervalFrom";
            this.numericUpDownIntervalFrom.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownIntervalFrom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "From";
            // 
            // comboBoxFromMailToAddList
            // 
            this.comboBoxFromMailToAddList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFromMailToAddList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFromMailToAddList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFromMailToAddList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFromMailToAddList.FormattingEnabled = true;
            this.comboBoxFromMailToAddList.Location = new System.Drawing.Point(17, 37);
            this.comboBoxFromMailToAddList.Name = "comboBoxFromMailToAddList";
            this.comboBoxFromMailToAddList.Size = new System.Drawing.Size(190, 21);
            this.comboBoxFromMailToAddList.Sorted = true;
            this.comboBoxFromMailToAddList.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "time interval (hour)";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.buttonLoad);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.textBoxDBPassword);
            this.groupBox8.Controls.Add(this.textBoxDBLogin);
            this.groupBox8.Controls.Add(this.textBoxDBName);
            this.groupBox8.Controls.Add(this.textBoxDBHost);
            this.groupBox8.Location = new System.Drawing.Point(15, 78);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(514, 76);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "DataBase";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(434, 17);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 8;
            this.buttonLoad.Text = "Load...";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "password:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(199, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "username:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "database:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "hostname:";
            // 
            // textBoxDBPassword
            // 
            this.textBoxDBPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EldarMailLogParse.Properties.Settings.Default, "db_pwd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDBPassword.Location = new System.Drawing.Point(273, 45);
            this.textBoxDBPassword.Name = "textBoxDBPassword";
            this.textBoxDBPassword.PasswordChar = '*';
            this.textBoxDBPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxDBPassword.TabIndex = 3;
            this.textBoxDBPassword.Text = global::EldarMailLogParse.Properties.Settings.Default.db_pwd;
            // 
            // textBoxDBLogin
            // 
            this.textBoxDBLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EldarMailLogParse.Properties.Settings.Default, "db_login", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDBLogin.Location = new System.Drawing.Point(273, 19);
            this.textBoxDBLogin.Name = "textBoxDBLogin";
            this.textBoxDBLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxDBLogin.TabIndex = 2;
            this.textBoxDBLogin.Text = global::EldarMailLogParse.Properties.Settings.Default.db_login;
            // 
            // textBoxDBName
            // 
            this.textBoxDBName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EldarMailLogParse.Properties.Settings.Default, "db_name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDBName.Location = new System.Drawing.Point(85, 44);
            this.textBoxDBName.Name = "textBoxDBName";
            this.textBoxDBName.Size = new System.Drawing.Size(100, 20);
            this.textBoxDBName.TabIndex = 1;
            this.textBoxDBName.Text = global::EldarMailLogParse.Properties.Settings.Default.db_name;
            // 
            // textBoxDBHost
            // 
            this.textBoxDBHost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EldarMailLogParse.Properties.Settings.Default, "db_host", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxDBHost.Location = new System.Drawing.Point(85, 19);
            this.textBoxDBHost.Name = "textBoxDBHost";
            this.textBoxDBHost.Size = new System.Drawing.Size(100, 20);
            this.textBoxDBHost.TabIndex = 0;
            this.textBoxDBHost.Text = global::EldarMailLogParse.Properties.Settings.Default.db_host;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label1);
            this.groupBox9.Controls.Add(this.buttonOpenFile);
            this.groupBox9.Controls.Add(this.buttonParse);
            this.groupBox9.Controls.Add(this.textBoxFilePath);
            this.groupBox9.Location = new System.Drawing.Point(15, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(514, 59);
            this.groupBox9.TabIndex = 13;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "File";
            // 
            // checkResultBindingSource
            // 
            this.checkResultBindingSource.DataMember = "CheckResult";
            this.checkResultBindingSource.DataSource = this.dataSetMain;
            // 
            // dataSetMain
            // 
            this.dataSetMain.DataSetName = "DataSetMain";
            this.dataSetMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "From";
            this.dataGridViewTextBoxColumn1.HeaderText = "From";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "To";
            this.dataGridViewTextBoxColumn2.HeaderText = "To";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataTableLogEmailBindingSource
            // 
            this.dataTableLogEmailBindingSource.DataMember = "DataTableLogEmail";
            this.dataTableLogEmailBindingSource.DataSource = this.dataSetMain;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FromMail";
            this.dataGridViewTextBoxColumn4.HeaderText = "FromMail";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FromTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "FromTime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AnsweredMail";
            this.dataGridViewTextBoxColumn6.HeaderText = "ToMail";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AnswerTime";
            this.dataGridViewTextBoxColumn7.HeaderText = "AnswerTime";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "LateStatus";
            this.dataGridViewTextBoxColumn8.HeaderText = "LateStatus";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // LateDuration
            // 
            this.LateDuration.DataPropertyName = "LateDuration";
            this.LateDuration.HeaderText = "LateDuration";
            this.LateDuration.Name = "LateDuration";
            this.LateDuration.ReadOnly = true;
            this.LateDuration.Width = 70;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 710);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1010, 602);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableLogEmailDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkResultDataGridView)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalTo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalFrom)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableLogEmailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonParse;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxFromList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonAddFrom;
        private System.Windows.Forms.NumericUpDown numericUpDownIntervalFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBoxToList;
        private System.Windows.Forms.Button buttonAddTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCheckFrom;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonDellTo;
        private System.Windows.Forms.Button buttonDellFrom;
        private System.Windows.Forms.Button buttonClearFilters;
        private System.Windows.Forms.DataGridView dataTableLogEmailDataGridView;
        private System.Windows.Forms.BindingSource dataTableLogEmailBindingSource;
        private DataSetMain dataSetMain;
        private System.Windows.Forms.ComboBox comboBoxToMailToAddList;
        private System.Windows.Forms.ComboBox comboBoxFromMailToAddList;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView checkResultDataGridView;
        private System.Windows.Forms.BindingSource checkResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsMain;
        private System.Windows.Forms.NumericUpDown numericUpDownIntervalTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExportResult;
        private System.Windows.Forms.Button buttonCheckFromTo;
        private System.Windows.Forms.Button buttonCheckTo;
        private System.Windows.Forms.CheckBox checkBoxIncludeCC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxDBPassword;
        private System.Windows.Forms.TextBox textBoxDBLogin;
        private System.Windows.Forms.TextBox textBoxDBName;
        private System.Windows.Forms.TextBox textBoxDBHost;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn LateDuration;
    }
}

