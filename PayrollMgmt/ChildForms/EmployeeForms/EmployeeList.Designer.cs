namespace PayrollMgmt.ChildForms.EmployeeForms {
    partial class EmployeeList {
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
            this.EmployeeDataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeDataTable
            // 
            this.EmployeeDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeDataTable.Location = new System.Drawing.Point(0, 0);
            this.EmployeeDataTable.Name = "EmployeeDataTable";
            this.EmployeeDataTable.ReadOnly = true;
            this.EmployeeDataTable.Size = new System.Drawing.Size(800, 450);
            this.EmployeeDataTable.TabIndex = 0;
            this.EmployeeDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataTable_CellDoubleClick);
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.EmployeeDataTable);
            this.Name = "EmployeeList";
            this.Text = "EmployeeList";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeDataTable;
    }
}