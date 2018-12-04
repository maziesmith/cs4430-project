namespace PayrollMgmt.ChildForms.DepartmentForms {
    partial class DepartmentEmployees {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.EmployeesDataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesDataTable
            // 
            this.EmployeesDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeesDataTable.Location = new System.Drawing.Point(0, 0);
            this.EmployeesDataTable.Name = "EmployeesDataTable";
            this.EmployeesDataTable.Size = new System.Drawing.Size(800, 450);
            this.EmployeesDataTable.TabIndex = 0;
            // 
            // DepartmentEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.EmployeesDataTable);
            this.Name = "DepartmentEmployees";
            this.Text = "DepartmentEmployees";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeesDataTable;
    }
}