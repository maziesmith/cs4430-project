namespace PayrollMgmt {
    partial class Dashboard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.PayrollGroup = new System.Windows.Forms.GroupBox();
            this.PayrollTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DeductionLabel = new System.Windows.Forms.Label();
            this.AddDeductionButton = new System.Windows.Forms.Button();
            this.DeductionInputLabel = new System.Windows.Forms.Label();
            this.DeductionAmountLabel = new System.Windows.Forms.Label();
            this.DeductionInput = new System.Windows.Forms.TextBox();
            this.DeductionAmountInput = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.HolidayLabel = new System.Windows.Forms.Label();
            this.AddHolidayButton = new System.Windows.Forms.Button();
            this.HolidayInputLabel = new System.Windows.Forms.Label();
            this.HolidayPayLabel = new System.Windows.Forms.Label();
            this.HolidayNameInput = new System.Windows.Forms.TextBox();
            this.HolidayPayInput = new System.Windows.Forms.NumericUpDown();
            this.PayEmpTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.PayEmployeeLabel = new System.Windows.Forms.Label();
            this.PayDeptInput = new System.Windows.Forms.ComboBox();
            this.PayEmpInput = new System.Windows.Forms.ComboBox();
            this.PayEmpButton = new System.Windows.Forms.Button();
            this.PayDeptLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BonusTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.BonusLabel = new System.Windows.Forms.Label();
            this.BonusButton = new System.Windows.Forms.Button();
            this.BonusNameLabel = new System.Windows.Forms.Label();
            this.BonusAmountLabel = new System.Windows.Forms.Label();
            this.BonusNameInput = new System.Windows.Forms.TextBox();
            this.BonusAmountInput = new System.Windows.Forms.NumericUpDown();
            this.TopTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.EmployeeGroup = new System.Windows.Forms.GroupBox();
            this.EmployeeTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.DeptInput = new System.Windows.Forms.ComboBox();
            this.AddEmployee_button = new System.Windows.Forms.Button();
            this.TimeEmployee_button = new System.Windows.Forms.Button();
            this.ViewEmployee_button = new System.Windows.Forms.Button();
            this.AddLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ViewLabel = new System.Windows.Forms.Label();
            this.employeeTimeID = new System.Windows.Forms.TextBox();
            this.EmployeeDetailsID = new System.Windows.Forms.TextBox();
            this.JobsAndDeptGroup = new System.Windows.Forms.GroupBox();
            this.DepartmentTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ViewDepartmentLabel = new System.Windows.Forms.Label();
            this.ViewDeptEmpLabel = new System.Windows.Forms.Label();
            this.ViewDeptEmpTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ViewDeptEmpInput = new System.Windows.Forms.ComboBox();
            this.ViewDeptEmpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ViewDepartmentButton = new System.Windows.Forms.Button();
            this.AddDepartmentButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ViewJobButton = new System.Windows.Forms.Button();
            this.AddJobButton = new System.Windows.Forms.Button();
            this.MainTable.SuspendLayout();
            this.PayrollGroup.SuspendLayout();
            this.PayrollTableContainer.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeductionAmountInput)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HolidayPayInput)).BeginInit();
            this.PayEmpTableContainer.SuspendLayout();
            this.BonusTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BonusAmountInput)).BeginInit();
            this.TopTableContainer.SuspendLayout();
            this.EmployeeGroup.SuspendLayout();
            this.EmployeeTableContainer.SuspendLayout();
            this.JobsAndDeptGroup.SuspendLayout();
            this.DepartmentTableContainer.SuspendLayout();
            this.ViewDeptEmpTableContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.Controls.Add(this.PayrollGroup, 0, 1);
            this.MainTable.Controls.Add(this.TopTableContainer, 0, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.Size = new System.Drawing.Size(800, 450);
            this.MainTable.TabIndex = 0;
            // 
            // PayrollGroup
            // 
            this.PayrollGroup.Controls.Add(this.PayrollTableContainer);
            this.PayrollGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayrollGroup.Location = new System.Drawing.Point(3, 228);
            this.PayrollGroup.Name = "PayrollGroup";
            this.PayrollGroup.Size = new System.Drawing.Size(794, 219);
            this.PayrollGroup.TabIndex = 2;
            this.PayrollGroup.TabStop = false;
            this.PayrollGroup.Text = "Payroll";
            // 
            // PayrollTableContainer
            // 
            this.PayrollTableContainer.ColumnCount = 4;
            this.PayrollTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PayrollTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PayrollTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PayrollTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PayrollTableContainer.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.PayrollTableContainer.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.PayrollTableContainer.Controls.Add(this.PayEmpTableContainer, 0, 0);
            this.PayrollTableContainer.Controls.Add(this.BonusTableContainer, 0, 0);
            this.PayrollTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayrollTableContainer.Location = new System.Drawing.Point(3, 16);
            this.PayrollTableContainer.Name = "PayrollTableContainer";
            this.PayrollTableContainer.RowCount = 1;
            this.PayrollTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PayrollTableContainer.Size = new System.Drawing.Size(788, 200);
            this.PayrollTableContainer.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.DeductionLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.AddDeductionButton, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.DeductionInputLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.DeductionAmountLabel, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.DeductionInput, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.DeductionAmountInput, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(397, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.34021F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.185567F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.247422F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.07216F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.762887F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.97938F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.89691F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(191, 194);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // DeductionLabel
            // 
            this.DeductionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeductionLabel.AutoSize = true;
            this.DeductionLabel.Location = new System.Drawing.Point(56, 4);
            this.DeductionLabel.Name = "DeductionLabel";
            this.DeductionLabel.Size = new System.Drawing.Size(78, 13);
            this.DeductionLabel.TabIndex = 0;
            this.DeductionLabel.Text = "Add Deduction";
            // 
            // AddDeductionButton
            // 
            this.AddDeductionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddDeductionButton.Location = new System.Drawing.Point(52, 153);
            this.AddDeductionButton.Name = "AddDeductionButton";
            this.AddDeductionButton.Size = new System.Drawing.Size(87, 23);
            this.AddDeductionButton.TabIndex = 3;
            this.AddDeductionButton.Text = "Add Deduction";
            this.AddDeductionButton.UseVisualStyleBackColor = true;
            this.AddDeductionButton.Click += new System.EventHandler(this.AddDeductionButton_Click);
            // 
            // DeductionInputLabel
            // 
            this.DeductionInputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeductionInputLabel.AutoSize = true;
            this.DeductionInputLabel.Location = new System.Drawing.Point(3, 37);
            this.DeductionInputLabel.Name = "DeductionInputLabel";
            this.DeductionInputLabel.Size = new System.Drawing.Size(87, 13);
            this.DeductionInputLabel.TabIndex = 4;
            this.DeductionInputLabel.Text = "Deduction Name";
            // 
            // DeductionAmountLabel
            // 
            this.DeductionAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeductionAmountLabel.AutoSize = true;
            this.DeductionAmountLabel.Location = new System.Drawing.Point(3, 91);
            this.DeductionAmountLabel.Name = "DeductionAmountLabel";
            this.DeductionAmountLabel.Size = new System.Drawing.Size(60, 13);
            this.DeductionAmountLabel.TabIndex = 5;
            this.DeductionAmountLabel.Text = "Amount (%)";
            // 
            // DeductionInput
            // 
            this.DeductionInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeductionInput.Location = new System.Drawing.Point(3, 58);
            this.DeductionInput.Name = "DeductionInput";
            this.DeductionInput.Size = new System.Drawing.Size(185, 20);
            this.DeductionInput.TabIndex = 6;
            // 
            // DeductionAmountInput
            // 
            this.DeductionAmountInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeductionAmountInput.Location = new System.Drawing.Point(3, 109);
            this.DeductionAmountInput.Name = "DeductionAmountInput";
            this.DeductionAmountInput.Size = new System.Drawing.Size(185, 20);
            this.DeductionAmountInput.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.HolidayLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.AddHolidayButton, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.HolidayInputLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.HolidayPayLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.HolidayNameInput, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.HolidayPayInput, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(594, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.34021F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.185567F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.247422F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.07216F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.762887F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.97938F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.89691F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(191, 194);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // HolidayLabel
            // 
            this.HolidayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HolidayLabel.AutoSize = true;
            this.HolidayLabel.Location = new System.Drawing.Point(63, 4);
            this.HolidayLabel.Name = "HolidayLabel";
            this.HolidayLabel.Size = new System.Drawing.Size(64, 13);
            this.HolidayLabel.TabIndex = 0;
            this.HolidayLabel.Text = "Add Holiday";
            // 
            // AddHolidayButton
            // 
            this.AddHolidayButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddHolidayButton.Location = new System.Drawing.Point(52, 153);
            this.AddHolidayButton.Name = "AddHolidayButton";
            this.AddHolidayButton.Size = new System.Drawing.Size(87, 23);
            this.AddHolidayButton.TabIndex = 3;
            this.AddHolidayButton.Text = "Pay Employee";
            this.AddHolidayButton.UseVisualStyleBackColor = true;
            this.AddHolidayButton.Click += new System.EventHandler(this.AddHolidayButton_Click);
            // 
            // HolidayInputLabel
            // 
            this.HolidayInputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HolidayInputLabel.AutoSize = true;
            this.HolidayInputLabel.Location = new System.Drawing.Point(3, 37);
            this.HolidayInputLabel.Name = "HolidayInputLabel";
            this.HolidayInputLabel.Size = new System.Drawing.Size(73, 13);
            this.HolidayInputLabel.TabIndex = 4;
            this.HolidayInputLabel.Text = "Holiday Name";
            // 
            // HolidayPayLabel
            // 
            this.HolidayPayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HolidayPayLabel.AutoSize = true;
            this.HolidayPayLabel.Location = new System.Drawing.Point(3, 91);
            this.HolidayPayLabel.Name = "HolidayPayLabel";
            this.HolidayPayLabel.Size = new System.Drawing.Size(25, 13);
            this.HolidayPayLabel.TabIndex = 5;
            this.HolidayPayLabel.Text = "Pay";
            // 
            // HolidayNameInput
            // 
            this.HolidayNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HolidayNameInput.Location = new System.Drawing.Point(3, 58);
            this.HolidayNameInput.Name = "HolidayNameInput";
            this.HolidayNameInput.Size = new System.Drawing.Size(185, 20);
            this.HolidayNameInput.TabIndex = 6;
            // 
            // HolidayPayInput
            // 
            this.HolidayPayInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HolidayPayInput.Location = new System.Drawing.Point(3, 109);
            this.HolidayPayInput.Name = "HolidayPayInput";
            this.HolidayPayInput.Size = new System.Drawing.Size(185, 20);
            this.HolidayPayInput.TabIndex = 8;
            // 
            // PayEmpTableContainer
            // 
            this.PayEmpTableContainer.ColumnCount = 1;
            this.PayEmpTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PayEmpTableContainer.Controls.Add(this.PayEmployeeLabel, 0, 0);
            this.PayEmpTableContainer.Controls.Add(this.PayDeptInput, 0, 3);
            this.PayEmpTableContainer.Controls.Add(this.PayEmpInput, 0, 5);
            this.PayEmpTableContainer.Controls.Add(this.PayEmpButton, 0, 6);
            this.PayEmpTableContainer.Controls.Add(this.PayDeptLabel, 0, 2);
            this.PayEmpTableContainer.Controls.Add(this.label4, 0, 4);
            this.PayEmpTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayEmpTableContainer.Location = new System.Drawing.Point(3, 3);
            this.PayEmpTableContainer.Name = "PayEmpTableContainer";
            this.PayEmpTableContainer.RowCount = 7;
            this.PayEmpTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.34021F));
            this.PayEmpTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.185567F));
            this.PayEmpTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.247422F));
            this.PayEmpTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.07216F));
            this.PayEmpTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.762887F));
            this.PayEmpTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.97938F));
            this.PayEmpTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.89691F));
            this.PayEmpTableContainer.Size = new System.Drawing.Size(191, 194);
            this.PayEmpTableContainer.TabIndex = 1;
            // 
            // PayEmployeeLabel
            // 
            this.PayEmployeeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PayEmployeeLabel.AutoSize = true;
            this.PayEmployeeLabel.Location = new System.Drawing.Point(58, 4);
            this.PayEmployeeLabel.Name = "PayEmployeeLabel";
            this.PayEmployeeLabel.Size = new System.Drawing.Size(74, 13);
            this.PayEmployeeLabel.TabIndex = 0;
            this.PayEmployeeLabel.Text = "Pay Employee";
            // 
            // PayDeptInput
            // 
            this.PayDeptInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PayDeptInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PayDeptInput.FormattingEnabled = true;
            this.PayDeptInput.Location = new System.Drawing.Point(3, 58);
            this.PayDeptInput.Name = "PayDeptInput";
            this.PayDeptInput.Size = new System.Drawing.Size(185, 21);
            this.PayDeptInput.TabIndex = 2;
            this.PayDeptInput.SelectedIndexChanged += new System.EventHandler(this.PayDeptInput_SelectedIndexChanged);
            // 
            // PayEmpInput
            // 
            this.PayEmpInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PayEmpInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PayEmpInput.FormattingEnabled = true;
            this.PayEmpInput.Location = new System.Drawing.Point(3, 109);
            this.PayEmpInput.Name = "PayEmpInput";
            this.PayEmpInput.Size = new System.Drawing.Size(185, 21);
            this.PayEmpInput.TabIndex = 1;
            // 
            // PayEmpButton
            // 
            this.PayEmpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PayEmpButton.Location = new System.Drawing.Point(52, 153);
            this.PayEmpButton.Name = "PayEmpButton";
            this.PayEmpButton.Size = new System.Drawing.Size(87, 23);
            this.PayEmpButton.TabIndex = 3;
            this.PayEmpButton.Text = "Pay Employee";
            this.PayEmpButton.UseVisualStyleBackColor = true;
            this.PayEmpButton.Click += new System.EventHandler(this.PayEmpButton_Click);
            // 
            // PayDeptLabel
            // 
            this.PayDeptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PayDeptLabel.AutoSize = true;
            this.PayDeptLabel.Location = new System.Drawing.Point(3, 37);
            this.PayDeptLabel.Name = "PayDeptLabel";
            this.PayDeptLabel.Size = new System.Drawing.Size(62, 13);
            this.PayDeptLabel.TabIndex = 4;
            this.PayDeptLabel.Text = "Department";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Employee\r\n";
            // 
            // BonusTableContainer
            // 
            this.BonusTableContainer.ColumnCount = 1;
            this.BonusTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BonusTableContainer.Controls.Add(this.BonusLabel, 0, 0);
            this.BonusTableContainer.Controls.Add(this.BonusButton, 0, 6);
            this.BonusTableContainer.Controls.Add(this.BonusNameLabel, 0, 2);
            this.BonusTableContainer.Controls.Add(this.BonusAmountLabel, 0, 4);
            this.BonusTableContainer.Controls.Add(this.BonusNameInput, 0, 3);
            this.BonusTableContainer.Controls.Add(this.BonusAmountInput, 0, 5);
            this.BonusTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BonusTableContainer.Location = new System.Drawing.Point(200, 3);
            this.BonusTableContainer.Name = "BonusTableContainer";
            this.BonusTableContainer.RowCount = 7;
            this.BonusTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.34021F));
            this.BonusTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.185567F));
            this.BonusTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.247422F));
            this.BonusTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.07216F));
            this.BonusTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.762887F));
            this.BonusTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.97938F));
            this.BonusTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.89691F));
            this.BonusTableContainer.Size = new System.Drawing.Size(191, 194);
            this.BonusTableContainer.TabIndex = 0;
            // 
            // BonusLabel
            // 
            this.BonusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BonusLabel.AutoSize = true;
            this.BonusLabel.Location = new System.Drawing.Point(66, 4);
            this.BonusLabel.Name = "BonusLabel";
            this.BonusLabel.Size = new System.Drawing.Size(59, 13);
            this.BonusLabel.TabIndex = 0;
            this.BonusLabel.Text = "Add Bonus";
            // 
            // BonusButton
            // 
            this.BonusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BonusButton.Location = new System.Drawing.Point(52, 153);
            this.BonusButton.Name = "BonusButton";
            this.BonusButton.Size = new System.Drawing.Size(87, 23);
            this.BonusButton.TabIndex = 3;
            this.BonusButton.Text = "Add Bonus";
            this.BonusButton.UseVisualStyleBackColor = true;
            this.BonusButton.Click += new System.EventHandler(this.BonusButton_Click);
            // 
            // BonusNameLabel
            // 
            this.BonusNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BonusNameLabel.AutoSize = true;
            this.BonusNameLabel.Location = new System.Drawing.Point(3, 37);
            this.BonusNameLabel.Name = "BonusNameLabel";
            this.BonusNameLabel.Size = new System.Drawing.Size(68, 13);
            this.BonusNameLabel.TabIndex = 4;
            this.BonusNameLabel.Text = "Bonus Name";
            // 
            // BonusAmountLabel
            // 
            this.BonusAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BonusAmountLabel.AutoSize = true;
            this.BonusAmountLabel.Location = new System.Drawing.Point(3, 91);
            this.BonusAmountLabel.Name = "BonusAmountLabel";
            this.BonusAmountLabel.Size = new System.Drawing.Size(60, 13);
            this.BonusAmountLabel.TabIndex = 5;
            this.BonusAmountLabel.Text = "Amount (%)";
            // 
            // BonusNameInput
            // 
            this.BonusNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BonusNameInput.Location = new System.Drawing.Point(3, 58);
            this.BonusNameInput.Name = "BonusNameInput";
            this.BonusNameInput.Size = new System.Drawing.Size(185, 20);
            this.BonusNameInput.TabIndex = 6;
            // 
            // BonusAmountInput
            // 
            this.BonusAmountInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BonusAmountInput.Location = new System.Drawing.Point(3, 109);
            this.BonusAmountInput.Name = "BonusAmountInput";
            this.BonusAmountInput.Size = new System.Drawing.Size(185, 20);
            this.BonusAmountInput.TabIndex = 7;
            // 
            // TopTableContainer
            // 
            this.TopTableContainer.ColumnCount = 2;
            this.TopTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopTableContainer.Controls.Add(this.EmployeeGroup, 0, 0);
            this.TopTableContainer.Controls.Add(this.JobsAndDeptGroup, 0, 0);
            this.TopTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopTableContainer.Location = new System.Drawing.Point(3, 3);
            this.TopTableContainer.Name = "TopTableContainer";
            this.TopTableContainer.RowCount = 1;
            this.TopTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopTableContainer.Size = new System.Drawing.Size(794, 219);
            this.TopTableContainer.TabIndex = 3;
            // 
            // EmployeeGroup
            // 
            this.EmployeeGroup.Controls.Add(this.EmployeeTableContainer);
            this.EmployeeGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeGroup.Location = new System.Drawing.Point(400, 3);
            this.EmployeeGroup.Name = "EmployeeGroup";
            this.EmployeeGroup.Size = new System.Drawing.Size(391, 213);
            this.EmployeeGroup.TabIndex = 2;
            this.EmployeeGroup.TabStop = false;
            this.EmployeeGroup.Text = "Employees";
            // 
            // EmployeeTableContainer
            // 
            this.EmployeeTableContainer.ColumnCount = 2;
            this.EmployeeTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.EmployeeTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.EmployeeTableContainer.Controls.Add(this.DeptInput, 0, 1);
            this.EmployeeTableContainer.Controls.Add(this.AddEmployee_button, 1, 1);
            this.EmployeeTableContainer.Controls.Add(this.TimeEmployee_button, 1, 3);
            this.EmployeeTableContainer.Controls.Add(this.ViewEmployee_button, 1, 5);
            this.EmployeeTableContainer.Controls.Add(this.AddLabel, 0, 0);
            this.EmployeeTableContainer.Controls.Add(this.TimeLabel, 0, 2);
            this.EmployeeTableContainer.Controls.Add(this.ViewLabel, 0, 4);
            this.EmployeeTableContainer.Controls.Add(this.employeeTimeID, 0, 3);
            this.EmployeeTableContainer.Controls.Add(this.EmployeeDetailsID, 0, 5);
            this.EmployeeTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeTableContainer.Location = new System.Drawing.Point(3, 16);
            this.EmployeeTableContainer.Name = "EmployeeTableContainer";
            this.EmployeeTableContainer.RowCount = 6;
            this.EmployeeTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10832F));
            this.EmployeeTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.5827F));
            this.EmployeeTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10832F));
            this.EmployeeTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.5827F));
            this.EmployeeTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10832F));
            this.EmployeeTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.50964F));
            this.EmployeeTableContainer.Size = new System.Drawing.Size(385, 194);
            this.EmployeeTableContainer.TabIndex = 0;
            // 
            // DeptInput
            // 
            this.DeptInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeptInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeptInput.FormattingEnabled = true;
            this.DeptInput.Location = new System.Drawing.Point(3, 31);
            this.DeptInput.Name = "DeptInput";
            this.DeptInput.Size = new System.Drawing.Size(263, 21);
            this.DeptInput.TabIndex = 0;
            // 
            // AddEmployee_button
            // 
            this.AddEmployee_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEmployee_button.Location = new System.Drawing.Point(272, 22);
            this.AddEmployee_button.Name = "AddEmployee_button";
            this.AddEmployee_button.Size = new System.Drawing.Size(110, 39);
            this.AddEmployee_button.TabIndex = 0;
            this.AddEmployee_button.Text = "Add";
            this.AddEmployee_button.UseVisualStyleBackColor = true;
            this.AddEmployee_button.Click += new System.EventHandler(this.AddEmployee_button_Click);
            // 
            // TimeEmployee_button
            // 
            this.TimeEmployee_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeEmployee_button.Location = new System.Drawing.Point(272, 86);
            this.TimeEmployee_button.Name = "TimeEmployee_button";
            this.TimeEmployee_button.Size = new System.Drawing.Size(110, 39);
            this.TimeEmployee_button.TabIndex = 1;
            this.TimeEmployee_button.Text = "Submit";
            this.TimeEmployee_button.UseVisualStyleBackColor = true;
            this.TimeEmployee_button.Click += new System.EventHandler(this.TimeEmployee_button_Click);
            // 
            // ViewEmployee_button
            // 
            this.ViewEmployee_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewEmployee_button.Location = new System.Drawing.Point(272, 150);
            this.ViewEmployee_button.Name = "ViewEmployee_button";
            this.ViewEmployee_button.Size = new System.Drawing.Size(110, 40);
            this.ViewEmployee_button.TabIndex = 2;
            this.ViewEmployee_button.Text = "Search";
            this.ViewEmployee_button.UseVisualStyleBackColor = true;
            this.ViewEmployee_button.Click += new System.EventHandler(this.ViewEmployee_button_Click);
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddLabel.Location = new System.Drawing.Point(3, 0);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(263, 19);
            this.AddLabel.TabIndex = 3;
            this.AddLabel.Text = "Add New Employee";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeLabel.Location = new System.Drawing.Point(3, 64);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(263, 19);
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "View Employee Time";
            // 
            // ViewLabel
            // 
            this.ViewLabel.AutoSize = true;
            this.ViewLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewLabel.Location = new System.Drawing.Point(3, 128);
            this.ViewLabel.Name = "ViewLabel";
            this.ViewLabel.Size = new System.Drawing.Size(263, 19);
            this.ViewLabel.TabIndex = 5;
            this.ViewLabel.Text = "Search Employees";
            // 
            // employeeTimeID
            // 
            this.employeeTimeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeTimeID.ForeColor = System.Drawing.Color.Gray;
            this.employeeTimeID.Location = new System.Drawing.Point(3, 95);
            this.employeeTimeID.Name = "employeeTimeID";
            this.employeeTimeID.Size = new System.Drawing.Size(263, 20);
            this.employeeTimeID.TabIndex = 7;
            this.employeeTimeID.Text = "Employee ID";
            this.employeeTimeID.Enter += new System.EventHandler(this.EmployeeID_Enter);
            this.employeeTimeID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.employeeTimeID_KeyDown);
            this.employeeTimeID.Leave += new System.EventHandler(this.EmployeeID_Leave);
            // 
            // EmployeeDetailsID
            // 
            this.EmployeeDetailsID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeDetailsID.ForeColor = System.Drawing.Color.Black;
            this.EmployeeDetailsID.Location = new System.Drawing.Point(3, 160);
            this.EmployeeDetailsID.Name = "EmployeeDetailsID";
            this.EmployeeDetailsID.Size = new System.Drawing.Size(263, 20);
            this.EmployeeDetailsID.TabIndex = 6;
            this.EmployeeDetailsID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeDetailsID_KeyDown);
            // 
            // JobsAndDeptGroup
            // 
            this.JobsAndDeptGroup.Controls.Add(this.DepartmentTableContainer);
            this.JobsAndDeptGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JobsAndDeptGroup.Location = new System.Drawing.Point(3, 3);
            this.JobsAndDeptGroup.Name = "JobsAndDeptGroup";
            this.JobsAndDeptGroup.Size = new System.Drawing.Size(391, 213);
            this.JobsAndDeptGroup.TabIndex = 3;
            this.JobsAndDeptGroup.TabStop = false;
            this.JobsAndDeptGroup.Text = "Jobs and Departments";
            // 
            // DepartmentTableContainer
            // 
            this.DepartmentTableContainer.ColumnCount = 1;
            this.DepartmentTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DepartmentTableContainer.Controls.Add(this.ViewDepartmentLabel, 0, 0);
            this.DepartmentTableContainer.Controls.Add(this.ViewDeptEmpLabel, 0, 4);
            this.DepartmentTableContainer.Controls.Add(this.ViewDeptEmpTableContainer, 0, 5);
            this.DepartmentTableContainer.Controls.Add(this.label1, 0, 2);
            this.DepartmentTableContainer.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.DepartmentTableContainer.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.DepartmentTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepartmentTableContainer.Location = new System.Drawing.Point(3, 16);
            this.DepartmentTableContainer.Name = "DepartmentTableContainer";
            this.DepartmentTableContainer.RowCount = 6;
            this.DepartmentTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.2F));
            this.DepartmentTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.DepartmentTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.53846F));
            this.DepartmentTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.69231F));
            this.DepartmentTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DepartmentTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.DepartmentTableContainer.Size = new System.Drawing.Size(385, 194);
            this.DepartmentTableContainer.TabIndex = 0;
            // 
            // ViewDepartmentLabel
            // 
            this.ViewDepartmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ViewDepartmentLabel.AutoSize = true;
            this.ViewDepartmentLabel.Location = new System.Drawing.Point(3, 1);
            this.ViewDepartmentLabel.Name = "ViewDepartmentLabel";
            this.ViewDepartmentLabel.Size = new System.Drawing.Size(93, 13);
            this.ViewDepartmentLabel.TabIndex = 0;
            this.ViewDepartmentLabel.Text = "View Departments";
            // 
            // ViewDeptEmpLabel
            // 
            this.ViewDeptEmpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ViewDeptEmpLabel.AutoSize = true;
            this.ViewDeptEmpLabel.Location = new System.Drawing.Point(3, 137);
            this.ViewDeptEmpLabel.Name = "ViewDeptEmpLabel";
            this.ViewDeptEmpLabel.Size = new System.Drawing.Size(142, 13);
            this.ViewDeptEmpLabel.TabIndex = 1;
            this.ViewDeptEmpLabel.Text = "View Department Employees";
            // 
            // ViewDeptEmpTableContainer
            // 
            this.ViewDeptEmpTableContainer.ColumnCount = 2;
            this.ViewDeptEmpTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.62797F));
            this.ViewDeptEmpTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.37203F));
            this.ViewDeptEmpTableContainer.Controls.Add(this.ViewDeptEmpInput, 0, 0);
            this.ViewDeptEmpTableContainer.Controls.Add(this.ViewDeptEmpButton, 1, 0);
            this.ViewDeptEmpTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewDeptEmpTableContainer.Location = new System.Drawing.Point(3, 153);
            this.ViewDeptEmpTableContainer.Name = "ViewDeptEmpTableContainer";
            this.ViewDeptEmpTableContainer.RowCount = 1;
            this.ViewDeptEmpTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ViewDeptEmpTableContainer.Size = new System.Drawing.Size(379, 38);
            this.ViewDeptEmpTableContainer.TabIndex = 2;
            // 
            // ViewDeptEmpInput
            // 
            this.ViewDeptEmpInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewDeptEmpInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ViewDeptEmpInput.FormattingEnabled = true;
            this.ViewDeptEmpInput.Location = new System.Drawing.Point(3, 8);
            this.ViewDeptEmpInput.Name = "ViewDeptEmpInput";
            this.ViewDeptEmpInput.Size = new System.Drawing.Size(291, 21);
            this.ViewDeptEmpInput.TabIndex = 3;
            // 
            // ViewDeptEmpButton
            // 
            this.ViewDeptEmpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewDeptEmpButton.Location = new System.Drawing.Point(300, 3);
            this.ViewDeptEmpButton.Name = "ViewDeptEmpButton";
            this.ViewDeptEmpButton.Size = new System.Drawing.Size(76, 32);
            this.ViewDeptEmpButton.TabIndex = 4;
            this.ViewDeptEmpButton.Text = "View";
            this.ViewDeptEmpButton.UseVisualStyleBackColor = true;
            this.ViewDeptEmpButton.Click += new System.EventHandler(this.ViewDeptEmpButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "View Jobs";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.Controls.Add(this.ViewDepartmentButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddDepartmentButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(379, 46);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // ViewDepartmentButton
            // 
            this.ViewDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ViewDepartmentButton.Location = new System.Drawing.Point(34, 3);
            this.ViewDepartmentButton.Name = "ViewDepartmentButton";
            this.ViewDepartmentButton.Size = new System.Drawing.Size(121, 40);
            this.ViewDepartmentButton.TabIndex = 0;
            this.ViewDepartmentButton.Text = "View Departments";
            this.ViewDepartmentButton.UseVisualStyleBackColor = true;
            this.ViewDepartmentButton.Click += new System.EventHandler(this.ViewDepartmentButton_Click);
            // 
            // AddDepartmentButton
            // 
            this.AddDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AddDepartmentButton.Location = new System.Drawing.Point(224, 3);
            this.AddDepartmentButton.Name = "AddDepartmentButton";
            this.AddDepartmentButton.Size = new System.Drawing.Size(121, 40);
            this.AddDepartmentButton.TabIndex = 1;
            this.AddDepartmentButton.Text = "Add Department";
            this.AddDepartmentButton.UseVisualStyleBackColor = true;
            this.AddDepartmentButton.Click += new System.EventHandler(this.AddDepartmentButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.13193F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.86807F));
            this.tableLayoutPanel4.Controls.Add(this.ViewJobButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.AddJobButton, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 84);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(379, 43);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // ViewJobButton
            // 
            this.ViewJobButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ViewJobButton.Location = new System.Drawing.Point(34, 3);
            this.ViewJobButton.Name = "ViewJobButton";
            this.ViewJobButton.Size = new System.Drawing.Size(121, 37);
            this.ViewJobButton.TabIndex = 0;
            this.ViewJobButton.Text = "View Jobs";
            this.ViewJobButton.UseVisualStyleBackColor = true;
            this.ViewJobButton.Click += new System.EventHandler(this.ViewJobsButton_Click);
            // 
            // AddJobButton
            // 
            this.AddJobButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AddJobButton.Location = new System.Drawing.Point(224, 3);
            this.AddJobButton.Name = "AddJobButton";
            this.AddJobButton.Size = new System.Drawing.Size(121, 37);
            this.AddJobButton.TabIndex = 1;
            this.AddJobButton.Text = "Add Job";
            this.AddJobButton.UseVisualStyleBackColor = true;
            this.AddJobButton.Click += new System.EventHandler(this.AddJobButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.MainTable);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.MainTable.ResumeLayout(false);
            this.PayrollGroup.ResumeLayout(false);
            this.PayrollTableContainer.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeductionAmountInput)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HolidayPayInput)).EndInit();
            this.PayEmpTableContainer.ResumeLayout(false);
            this.PayEmpTableContainer.PerformLayout();
            this.BonusTableContainer.ResumeLayout(false);
            this.BonusTableContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BonusAmountInput)).EndInit();
            this.TopTableContainer.ResumeLayout(false);
            this.EmployeeGroup.ResumeLayout(false);
            this.EmployeeTableContainer.ResumeLayout(false);
            this.EmployeeTableContainer.PerformLayout();
            this.JobsAndDeptGroup.ResumeLayout(false);
            this.DepartmentTableContainer.ResumeLayout(false);
            this.DepartmentTableContainer.PerformLayout();
            this.ViewDeptEmpTableContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.GroupBox PayrollGroup;
        private System.Windows.Forms.TableLayoutPanel TopTableContainer;
        private System.Windows.Forms.GroupBox EmployeeGroup;
        private System.Windows.Forms.TableLayoutPanel EmployeeTableContainer;
        private System.Windows.Forms.Button AddEmployee_button;
        private System.Windows.Forms.Button TimeEmployee_button;
        private System.Windows.Forms.Button ViewEmployee_button;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label ViewLabel;
        private System.Windows.Forms.TextBox employeeTimeID;
        private System.Windows.Forms.TextBox EmployeeDetailsID;
        private System.Windows.Forms.GroupBox JobsAndDeptGroup;
        private System.Windows.Forms.ComboBox DeptInput;
        private System.Windows.Forms.TableLayoutPanel DepartmentTableContainer;
        private System.Windows.Forms.Label ViewDepartmentLabel;
        private System.Windows.Forms.Label ViewDeptEmpLabel;
        private System.Windows.Forms.TableLayoutPanel ViewDeptEmpTableContainer;
        private System.Windows.Forms.ComboBox ViewDeptEmpInput;
        private System.Windows.Forms.Button ViewDeptEmpButton;
        private System.Windows.Forms.TableLayoutPanel PayrollTableContainer;
        private System.Windows.Forms.TableLayoutPanel BonusTableContainer;
        private System.Windows.Forms.Label BonusLabel;
        private System.Windows.Forms.Button BonusButton;
        private System.Windows.Forms.Label BonusNameLabel;
        private System.Windows.Forms.Label BonusAmountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label DeductionLabel;
        private System.Windows.Forms.Button AddDeductionButton;
        private System.Windows.Forms.Label DeductionInputLabel;
        private System.Windows.Forms.Label DeductionAmountLabel;
        private System.Windows.Forms.TextBox DeductionInput;
        private System.Windows.Forms.NumericUpDown DeductionAmountInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label HolidayLabel;
        private System.Windows.Forms.Button AddHolidayButton;
        private System.Windows.Forms.Label HolidayInputLabel;
        private System.Windows.Forms.Label HolidayPayLabel;
        private System.Windows.Forms.TextBox HolidayNameInput;
        private System.Windows.Forms.NumericUpDown HolidayPayInput;
        private System.Windows.Forms.TableLayoutPanel PayEmpTableContainer;
        private System.Windows.Forms.Label PayEmployeeLabel;
        private System.Windows.Forms.ComboBox PayDeptInput;
        private System.Windows.Forms.ComboBox PayEmpInput;
        private System.Windows.Forms.Button PayEmpButton;
        private System.Windows.Forms.Label PayDeptLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BonusNameInput;
        private System.Windows.Forms.NumericUpDown BonusAmountInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ViewDepartmentButton;
        private System.Windows.Forms.Button AddDepartmentButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button ViewJobButton;
        private System.Windows.Forms.Button AddJobButton;
    }
}