namespace PayrollMgmt.ChildForms.DepartmentForms
{
    partial class PickManager
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
            this.managerList = new System.Windows.Forms.DataGridView();
            this.selectManager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.managerList)).BeginInit();
            this.SuspendLayout();
            // 
            // managerList
            // 
            this.managerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managerList.Location = new System.Drawing.Point(12, 12);
            this.managerList.MultiSelect = false;
            this.managerList.Name = "managerList";
            this.managerList.ReadOnly = true;
            this.managerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.managerList.Size = new System.Drawing.Size(419, 313);
            this.managerList.TabIndex = 0;
            // 
            // selectManager
            // 
            this.selectManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.selectManager.Location = new System.Drawing.Point(158, 331);
            this.selectManager.Name = "selectManager";
            this.selectManager.Size = new System.Drawing.Size(115, 40);
            this.selectManager.TabIndex = 1;
            this.selectManager.Text = "Pick Manager";
            this.selectManager.UseVisualStyleBackColor = true;
            this.selectManager.Click += new System.EventHandler(this.selectManager_Click);
            // 
            // PickManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 388);
            this.ControlBox = false;
            this.Controls.Add(this.selectManager);
            this.Controls.Add(this.managerList);
            this.Name = "PickManager";
            this.Text = "PickManager";
            ((System.ComponentModel.ISupportInitialize)(this.managerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView managerList;
        private System.Windows.Forms.Button selectManager;
    }
}