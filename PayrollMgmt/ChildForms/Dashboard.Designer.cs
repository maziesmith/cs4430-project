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
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.MainTable.SuspendLayout();
            this.EmployeeGroup.SuspendLayout();
            this.EmployeeTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.Controls.Add(this.EmployeeGroup, 0, 0);
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.Size = new System.Drawing.Size(800, 450);
            this.MainTable.TabIndex = 0;
            // 
            // EmployeeGroup
            // 
            this.EmployeeGroup.Controls.Add(this.EmployeeTable);
            this.EmployeeGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeGroup.Location = new System.Drawing.Point(3, 3);
            this.EmployeeGroup.Name = "EmployeeGroup";
            this.EmployeeGroup.Size = new System.Drawing.Size(394, 219);
            this.EmployeeGroup.TabIndex = 0;
            this.EmployeeGroup.TabStop = false;
            this.EmployeeGroup.Text = "Employees";
            // 
            // EmployeeTable
            // 
            this.EmployeeTable.ColumnCount = 2;
            this.EmployeeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.EmployeeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
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
            this.EmployeeTable.Size = new System.Drawing.Size(388, 200);
            this.EmployeeTable.TabIndex = 0;
            // 
            // AddEmployee_button
            // 
            this.AddEmployee_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEmployee_button.Location = new System.Drawing.Point(274, 23);
            this.AddEmployee_button.Name = "AddEmployee_button";
            this.AddEmployee_button.Size = new System.Drawing.Size(111, 40);
            this.AddEmployee_button.TabIndex = 0;
            this.AddEmployee_button.Text = "Add";
            this.AddEmployee_button.UseVisualStyleBackColor = true;
            this.AddEmployee_button.Click += new System.EventHandler(this.AddEmployee_button_Click);
            // 
            // TimeEmployee_button
            // 
            this.TimeEmployee_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeEmployee_button.Location = new System.Drawing.Point(274, 90);
            this.TimeEmployee_button.Name = "TimeEmployee_button";
            this.TimeEmployee_button.Size = new System.Drawing.Size(111, 40);
            this.TimeEmployee_button.TabIndex = 1;
            this.TimeEmployee_button.Text = "Submit";
            this.TimeEmployee_button.UseVisualStyleBackColor = true;
            this.TimeEmployee_button.Click += new System.EventHandler(this.TimeEmployee_button_Click);
            // 
            // ViewEmployee_button
            // 
            this.ViewEmployee_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewEmployee_button.Location = new System.Drawing.Point(274, 157);
            this.ViewEmployee_button.Name = "ViewEmployee_button";
            this.ViewEmployee_button.Size = new System.Drawing.Size(111, 40);
            this.ViewEmployee_button.TabIndex = 2;
            this.ViewEmployee_button.Text = "Submit";
            this.ViewEmployee_button.UseVisualStyleBackColor = true;
            this.ViewEmployee_button.Click += new System.EventHandler(this.ViewEmployee_button_Click);
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addLabel.Location = new System.Drawing.Point(3, 0);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(265, 20);
            this.addLabel.TabIndex = 3;
            this.addLabel.Text = "Add New Employee";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Location = new System.Drawing.Point(3, 67);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(265, 20);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "View Employee Time";
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewLabel.Location = new System.Drawing.Point(3, 134);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(265, 20);
            this.viewLabel.TabIndex = 5;
            this.viewLabel.Text = "View Employee Details";
            // 
            // employeeTimeID
            // 
            this.employeeTimeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeTimeID.ForeColor = System.Drawing.Color.Gray;
            this.employeeTimeID.Location = new System.Drawing.Point(3, 100);
            this.employeeTimeID.Name = "employeeTimeID";
            this.employeeTimeID.Size = new System.Drawing.Size(265, 20);
            this.employeeTimeID.TabIndex = 7;
            this.employeeTimeID.Text = "Employee ID";
            this.employeeTimeID.Enter += new System.EventHandler(this.EmployeeID_Enter);
            this.employeeTimeID.Leave += new System.EventHandler(this.EmployeeID_Leave);
            // 
            // employeeDetailsID
            // 
            this.employeeDetailsID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeDetailsID.ForeColor = System.Drawing.Color.Gray;
            this.employeeDetailsID.Location = new System.Drawing.Point(3, 167);
            this.employeeDetailsID.Name = "employeeDetailsID";
            this.employeeDetailsID.Size = new System.Drawing.Size(265, 20);
            this.employeeDetailsID.TabIndex = 6;
            this.employeeDetailsID.Text = "Employee ID";
            this.employeeDetailsID.Enter += new System.EventHandler(this.EmployeeID_Enter);
            this.employeeDetailsID.Leave += new System.EventHandler(this.EmployeeID_Leave);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
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
            this.EmployeeGroup.ResumeLayout(false);
            this.EmployeeTable.ResumeLayout(false);
            this.EmployeeTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.GroupBox EmployeeGroup;
        private System.Windows.Forms.TableLayoutPanel EmployeeTable;
        private System.Windows.Forms.Button AddEmployee_button;
        private System.Windows.Forms.Button TimeEmployee_button;
        private System.Windows.Forms.Button ViewEmployee_button;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.TextBox employeeDetailsID;
        private System.Windows.Forms.TextBox employeeTimeID;
        private System.Diagnostics.EventLog eventLog1;
    }
}