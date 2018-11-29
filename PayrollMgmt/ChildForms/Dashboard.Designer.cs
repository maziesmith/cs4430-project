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
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.PayrollGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EmployeeGroup = new System.Windows.Forms.GroupBox();
            this.EmployeeTable = new System.Windows.Forms.TableLayoutPanel();
            this.AddEmployee_button = new System.Windows.Forms.Button();
            this.TimeEmployee_button = new System.Windows.Forms.Button();
            this.ViewEmployee_button = new System.Windows.Forms.Button();
            this.addLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.viewLabel = new System.Windows.Forms.Label();
            this.employeeTimeID = new System.Windows.Forms.TextBox();
            this.employeeDetailsID = new System.Windows.Forms.TextBox();
            this.JobsAndDeptGroup = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MainTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.EmployeeGroup.SuspendLayout();
            this.EmployeeTable.SuspendLayout();
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
            this.MainTable.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.Size = new System.Drawing.Size(800, 450);
            this.MainTable.TabIndex = 0;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // PayrollGroup
            // 
            this.PayrollGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayrollGroup.Location = new System.Drawing.Point(3, 228);
            this.PayrollGroup.Name = "PayrollGroup";
            this.PayrollGroup.Size = new System.Drawing.Size(794, 219);
            this.PayrollGroup.TabIndex = 2;
            this.PayrollGroup.TabStop = false;
            this.PayrollGroup.Text = "Payroll";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.EmployeeGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.JobsAndDeptGroup, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 219);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // EmployeeGroup
            // 
            this.EmployeeGroup.Controls.Add(this.EmployeeTable);
            this.EmployeeGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeGroup.Location = new System.Drawing.Point(400, 3);
            this.EmployeeGroup.Name = "EmployeeGroup";
            this.EmployeeGroup.Size = new System.Drawing.Size(391, 213);
            this.EmployeeGroup.TabIndex = 2;
            this.EmployeeGroup.TabStop = false;
            this.EmployeeGroup.Text = "Employees";
            // 
            // EmployeeTable
            // 
            this.EmployeeTable.ColumnCount = 2;
            this.EmployeeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.EmployeeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.EmployeeTable.Controls.Add(this.comboBox1, 0, 1);
            this.EmployeeTable.Controls.Add(this.AddEmployee_button, 1, 1);
            this.EmployeeTable.Controls.Add(this.TimeEmployee_button, 1, 3);
            this.EmployeeTable.Controls.Add(this.ViewEmployee_button, 1, 5);
            this.EmployeeTable.Controls.Add(this.addLabel, 0, 0);
            this.EmployeeTable.Controls.Add(this.timeLabel, 0, 2);
            this.EmployeeTable.Controls.Add(this.viewLabel, 0, 4);
            this.EmployeeTable.Controls.Add(this.employeeTimeID, 0, 3);
            this.EmployeeTable.Controls.Add(this.employeeDetailsID, 0, 5);
            this.EmployeeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeTable.Location = new System.Drawing.Point(3, 16);
            this.EmployeeTable.Name = "EmployeeTable";
            this.EmployeeTable.RowCount = 6;
            this.EmployeeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10832F));
            this.EmployeeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.5827F));
            this.EmployeeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10832F));
            this.EmployeeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.5827F));
            this.EmployeeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10832F));
            this.EmployeeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.50964F));
            this.EmployeeTable.Size = new System.Drawing.Size(385, 194);
            this.EmployeeTable.TabIndex = 0;
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
            // 
            // ViewEmployee_button
            // 
            this.ViewEmployee_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewEmployee_button.Location = new System.Drawing.Point(272, 150);
            this.ViewEmployee_button.Name = "ViewEmployee_button";
            this.ViewEmployee_button.Size = new System.Drawing.Size(110, 40);
            this.ViewEmployee_button.TabIndex = 2;
            this.ViewEmployee_button.Text = "Submit";
            this.ViewEmployee_button.UseVisualStyleBackColor = true;
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addLabel.Location = new System.Drawing.Point(3, 0);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(263, 19);
            this.addLabel.TabIndex = 3;
            this.addLabel.Text = "Add New Employee";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Location = new System.Drawing.Point(3, 64);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(263, 19);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "View Employee Time";
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewLabel.Location = new System.Drawing.Point(3, 128);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(263, 19);
            this.viewLabel.TabIndex = 5;
            this.viewLabel.Text = "View Employee Details";
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
            // 
            // employeeDetailsID
            // 
            this.employeeDetailsID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeDetailsID.ForeColor = System.Drawing.Color.Gray;
            this.employeeDetailsID.Location = new System.Drawing.Point(3, 160);
            this.employeeDetailsID.Name = "employeeDetailsID";
            this.employeeDetailsID.Size = new System.Drawing.Size(263, 20);
            this.employeeDetailsID.TabIndex = 6;
            this.employeeDetailsID.Text = "Employee ID";
            // 
            // JobsAndDeptGroup
            // 
            this.JobsAndDeptGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JobsAndDeptGroup.Location = new System.Drawing.Point(3, 3);
            this.JobsAndDeptGroup.Name = "JobsAndDeptGroup";
            this.JobsAndDeptGroup.Size = new System.Drawing.Size(391, 213);
            this.JobsAndDeptGroup.TabIndex = 3;
            this.JobsAndDeptGroup.TabStop = false;
            this.JobsAndDeptGroup.Text = "Jobs and Departments";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Information Technology"});
            this.comboBox1.Location = new System.Drawing.Point(3, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Department";
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
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.EmployeeGroup.ResumeLayout(false);
            this.EmployeeTable.ResumeLayout(false);
            this.EmployeeTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.GroupBox PayrollGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox EmployeeGroup;
        private System.Windows.Forms.TableLayoutPanel EmployeeTable;
        private System.Windows.Forms.Button AddEmployee_button;
        private System.Windows.Forms.Button TimeEmployee_button;
        private System.Windows.Forms.Button ViewEmployee_button;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.TextBox employeeTimeID;
        private System.Windows.Forms.TextBox employeeDetailsID;
        private System.Windows.Forms.GroupBox JobsAndDeptGroup;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}