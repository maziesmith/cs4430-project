namespace PayrollMgmt.ChildForms.DepartmentForms {
    partial class DepartmentView {
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
            this.DeptDataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DeptDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DeptDataTable
            // 
            this.DeptDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DeptDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeptDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeptDataTable.Location = new System.Drawing.Point(0, 0);
            this.DeptDataTable.Name = "DeptDataTable";
            this.DeptDataTable.ReadOnly = true;
            this.DeptDataTable.Size = new System.Drawing.Size(800, 450);
            this.DeptDataTable.TabIndex = 0;
            this.DeptDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeptDataTable_CellDoubleClick);
            // 
            // DepartmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.DeptDataTable);
            this.Name = "DepartmentView";
            this.Text = "DepartmentView";
            ((System.ComponentModel.ISupportInitialize)(this.DeptDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DeptDataTable;
    }
}