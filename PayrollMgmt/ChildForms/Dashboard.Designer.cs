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
            this.MainTable.SuspendLayout();
            this.EmployeeGroup.SuspendLayout();
            this.EmployeeTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.Controls.Add(this.EmployeeGroup, 0, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.EmployeeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeTable.Location = new System.Drawing.Point(3, 16);
            this.EmployeeTable.Name = "EmployeeTable";
            this.EmployeeTable.RowCount = 6;
            this.EmployeeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.001F));
            this.EmployeeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.33233F));
            this.EmployeeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.001F));
            this.EmployeeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.33233F));
            this.EmployeeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.001F));
            this.EmployeeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.33233F));
            this.EmployeeTable.Size = new System.Drawing.Size(388, 200);
            this.EmployeeTable.TabIndex = 0;
            // 
            // AddEmployee_button
            // 
            this.AddEmployee_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEmployee_button.Location = new System.Drawing.Point(274, 23);
            this.AddEmployee_button.Name = "AddEmployee_button";
            this.AddEmployee_button.Size = new System.Drawing.Size(111, 40);
            this.AddEmployee_button.TabIndex = 0;
            this.AddEmployee_button.Text = "Add New Employee";
            this.AddEmployee_button.UseVisualStyleBackColor = true;
            this.AddEmployee_button.Click += new System.EventHandler(this.AddEmployee_button_Click);
            // 
            // TimeEmployee_button
            // 
            this.TimeEmployee_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeEmployee_button.Location = new System.Drawing.Point(274, 89);
            this.TimeEmployee_button.Name = "TimeEmployee_button";
            this.TimeEmployee_button.Size = new System.Drawing.Size(111, 40);
            this.TimeEmployee_button.TabIndex = 1;
            this.TimeEmployee_button.Text = "View Employee Time";
            this.TimeEmployee_button.UseVisualStyleBackColor = true;
            this.TimeEmployee_button.Click += new System.EventHandler(this.TimeEmployee_button_Click);
            // 
            // ViewEmployee_button
            // 
            this.ViewEmployee_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewEmployee_button.Location = new System.Drawing.Point(274, 155);
            this.ViewEmployee_button.Name = "ViewEmployee_button";
            this.ViewEmployee_button.Size = new System.Drawing.Size(111, 42);
            this.ViewEmployee_button.TabIndex = 2;
            this.ViewEmployee_button.Text = "Employee Details";
            this.ViewEmployee_button.UseVisualStyleBackColor = true;
            this.ViewEmployee_button.Click += new System.EventHandler(this.ViewEmployee_button_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.GroupBox EmployeeGroup;
        private System.Windows.Forms.TableLayoutPanel EmployeeTable;
        private System.Windows.Forms.Button AddEmployee_button;
        private System.Windows.Forms.Button TimeEmployee_button;
        private System.Windows.Forms.Button ViewEmployee_button;
    }
}