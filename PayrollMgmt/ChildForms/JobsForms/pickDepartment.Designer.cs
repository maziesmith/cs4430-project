namespace PayrollMgmt.ChildForms.JobsForms
{
    partial class PickDepartment
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
            this.selectDepartment = new System.Windows.Forms.Button();
            this.departmentList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.departmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // selectDepartment
            // 
            this.selectDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.selectDepartment.Location = new System.Drawing.Point(142, 336);
            this.selectDepartment.Name = "selectDepartment";
            this.selectDepartment.Size = new System.Drawing.Size(148, 40);
            this.selectDepartment.TabIndex = 3;
            this.selectDepartment.Text = "Select Department";
            this.selectDepartment.UseVisualStyleBackColor = true;
            this.selectDepartment.Click += new System.EventHandler(this.selectDepartment_Click);
            // 
            // departmentList
            // 
            this.departmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.departmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentList.Location = new System.Drawing.Point(11, 17);
            this.departmentList.MultiSelect = false;
            this.departmentList.Name = "departmentList";
            this.departmentList.ReadOnly = true;
            this.departmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.departmentList.Size = new System.Drawing.Size(419, 313);
            this.departmentList.TabIndex = 2;
            // 
            // PickDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 388);
            this.ControlBox = false;
            this.Controls.Add(this.selectDepartment);
            this.Controls.Add(this.departmentList);
            this.Name = "PickDepartment";
            this.Text = "pickDepartment";
            ((System.ComponentModel.ISupportInitialize)(this.departmentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectDepartment;
        private System.Windows.Forms.DataGridView departmentList;
    }
}