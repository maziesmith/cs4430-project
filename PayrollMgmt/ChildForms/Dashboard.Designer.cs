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
            this.PayEmpTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.PayEmployeeLabel = new System.Windows.Forms.Label();
            this.PayDeptInput = new System.Windows.Forms.ComboBox();
            this.PayEmpInput = new System.Windows.Forms.ComboBox();
            this.PayEmpButton = new System.Windows.Forms.Button();
            this.PayDeptLabel = new System.Windows.Forms.Label();
            this.PayEmpLabel = new System.Windows.Forms.Label();
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
            this.ViewDepartmentButton = new System.Windows.Forms.Button();
            this.ViewDeptEmpTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ViewDeptEmpInput = new System.Windows.Forms.ComboBox();
            this.ViewDeptEmpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewJobsButton = new System.Windows.Forms.Button();
            this.MainTable.SuspendLayout();
            this.PayrollGroup.SuspendLayout();
            this.PayrollTableContainer.SuspendLayout();
            this.PayEmpTableContainer.SuspendLayout();
            this.TopTableContainer.SuspendLayout();
            this.EmployeeGroup.SuspendLayout();
            this.EmployeeTableContainer.SuspendLayout();
            this.JobsAndDeptGroup.SuspendLayout();
            this.DepartmentTableContainer.SuspendLayout();
            this.ViewDeptEmpTableContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.Controls.Add(this.PayrollGroup, 0, 1);
            this.MainTable.Controls.Add(this.TopTableContainer, 0, 0);
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
            this.PayrollTableContainer.Controls.Add(this.PayEmpTableContainer, 0, 0);
            this.PayrollTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayrollTableContainer.Location = new System.Drawing.Point(3, 16);
            this.PayrollTableContainer.Name = "PayrollTableContainer";
            this.PayrollTableContainer.RowCount = 1;
            this.PayrollTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PayrollTableContainer.Size = new System.Drawing.Size(788, 200);
            this.PayrollTableContainer.TabIndex = 0;
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
            this.PayEmpTableContainer.Controls.Add(this.PayEmpLabel, 0, 4);
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
            this.PayEmpTableContainer.TabIndex = 0;
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
            // PayEmpLabel
            // 
            this.PayEmpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PayEmpLabel.AutoSize = true;
            this.PayEmpLabel.Location = new System.Drawing.Point(3, 91);
            this.PayEmpLabel.Name = "PayEmpLabel";
            this.PayEmpLabel.Size = new System.Drawing.Size(53, 13);
            this.PayEmpLabel.TabIndex = 5;
            this.PayEmpLabel.Text = "Employee\r\n";
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
            this.DepartmentTableContainer.Controls.Add(this.ViewDepartmentButton, 0, 1);
            this.DepartmentTableContainer.Controls.Add(this.ViewDeptEmpTableContainer, 0, 5);
            this.DepartmentTableContainer.Controls.Add(this.label1, 0, 2);
            this.DepartmentTableContainer.Controls.Add(this.ViewJobsButton, 0, 3);
            this.DepartmentTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepartmentTableContainer.Location = new System.Drawing.Point(3, 16);
            this.DepartmentTableContainer.Name = "DepartmentTableContainer";
            this.DepartmentTableContainer.RowCount = 6;
            this.DepartmentTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.86207F));
            this.DepartmentTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DepartmentTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.3252F));
            this.DepartmentTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.89431F));
            this.DepartmentTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.DepartmentTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.DepartmentTableContainer.Size = new System.Drawing.Size(385, 194);
            this.DepartmentTableContainer.TabIndex = 0;
            // 
            // ViewDepartmentLabel
            // 
            this.ViewDepartmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ViewDepartmentLabel.AutoSize = true;
            this.ViewDepartmentLabel.Location = new System.Drawing.Point(3, 6);
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
            // ViewDepartmentButton
            // 
            this.ViewDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ViewDepartmentButton.Location = new System.Drawing.Point(134, 22);
            this.ViewDepartmentButton.Name = "ViewDepartmentButton";
            this.ViewDepartmentButton.Size = new System.Drawing.Size(117, 35);
            this.ViewDepartmentButton.TabIndex = 3;
            this.ViewDepartmentButton.Text = "View Departments";
            this.ViewDepartmentButton.UseVisualStyleBackColor = true;
            this.ViewDepartmentButton.Click += new System.EventHandler(this.ViewDepartmentButton_Click);
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
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "View Jobs";
            // 
            // ViewJobsButton
            // 
            this.ViewJobsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ViewJobsButton.Location = new System.Drawing.Point(133, 88);
            this.ViewJobsButton.Name = "ViewJobsButton";
            this.ViewJobsButton.Size = new System.Drawing.Size(118, 32);
            this.ViewJobsButton.TabIndex = 4;
            this.ViewJobsButton.Text = "View Jobs";
            this.ViewJobsButton.UseVisualStyleBackColor = true;
            this.ViewJobsButton.Click += new System.EventHandler(this.ViewJobsButton_Click);
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
            this.PayEmpTableContainer.ResumeLayout(false);
            this.PayEmpTableContainer.PerformLayout();
            this.TopTableContainer.ResumeLayout(false);
            this.EmployeeGroup.ResumeLayout(false);
            this.EmployeeTableContainer.ResumeLayout(false);
            this.EmployeeTableContainer.PerformLayout();
            this.JobsAndDeptGroup.ResumeLayout(false);
            this.DepartmentTableContainer.ResumeLayout(false);
            this.DepartmentTableContainer.PerformLayout();
            this.ViewDeptEmpTableContainer.ResumeLayout(false);
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
        private System.Windows.Forms.Button ViewDepartmentButton;
        private System.Windows.Forms.TableLayoutPanel PayrollTableContainer;
        private System.Windows.Forms.TableLayoutPanel PayEmpTableContainer;
        private System.Windows.Forms.Label PayEmployeeLabel;
        private System.Windows.Forms.ComboBox PayDeptInput;
        private System.Windows.Forms.ComboBox PayEmpInput;
        private System.Windows.Forms.Button PayEmpButton;
        private System.Windows.Forms.Label PayDeptLabel;
        private System.Windows.Forms.Label PayEmpLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewJobsButton;
    }
}