namespace PayrollMgmt.ChildForms {
    partial class EmployeeAdd {
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
            this.ParentTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.DetailsGroup = new System.Windows.Forms.GroupBox();
            this.PersonalTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.JobGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ParentTableContainer.SuspendLayout();
            this.DetailsGroup.SuspendLayout();
            this.PersonalTableContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParentTableContainer
            // 
            this.ParentTableContainer.ColumnCount = 2;
            this.ParentTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ParentTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ParentTableContainer.Controls.Add(this.DetailsGroup, 0, 0);
            this.ParentTableContainer.Controls.Add(this.JobGroup, 1, 0);
            this.ParentTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParentTableContainer.Location = new System.Drawing.Point(0, 0);
            this.ParentTableContainer.Name = "ParentTableContainer";
            this.ParentTableContainer.RowCount = 1;
            this.ParentTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ParentTableContainer.Size = new System.Drawing.Size(800, 450);
            this.ParentTableContainer.TabIndex = 0;
            // 
            // DetailsGroup
            // 
            this.DetailsGroup.Controls.Add(this.PersonalTableContainer);
            this.DetailsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsGroup.Location = new System.Drawing.Point(3, 3);
            this.DetailsGroup.Name = "DetailsGroup";
            this.DetailsGroup.Size = new System.Drawing.Size(394, 444);
            this.DetailsGroup.TabIndex = 0;
            this.DetailsGroup.TabStop = false;
            this.DetailsGroup.Text = "Personal Details";
            // 
            // PersonalTableContainer
            // 
            this.PersonalTableContainer.ColumnCount = 1;
            this.PersonalTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PersonalTableContainer.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.PersonalTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonalTableContainer.Location = new System.Drawing.Point(3, 16);
            this.PersonalTableContainer.Name = "PersonalTableContainer";
            this.PersonalTableContainer.RowCount = 7;
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PersonalTableContainer.Size = new System.Drawing.Size(388, 425);
            this.PersonalTableContainer.TabIndex = 0;
            // 
            // JobGroup
            // 
            this.JobGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JobGroup.Location = new System.Drawing.Point(403, 3);
            this.JobGroup.Name = "JobGroup";
            this.JobGroup.Size = new System.Drawing.Size(394, 444);
            this.JobGroup.TabIndex = 1;
            this.JobGroup.TabStop = false;
            this.JobGroup.Text = "Job Details";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.03704F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.96296F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(382, 54);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // EmployeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ParentTableContainer);
            this.Name = "EmployeeAdd";
            this.Text = "Add New Employee";
            this.ParentTableContainer.ResumeLayout(false);
            this.DetailsGroup.ResumeLayout(false);
            this.PersonalTableContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ParentTableContainer;
        private System.Windows.Forms.GroupBox DetailsGroup;
        private System.Windows.Forms.TableLayoutPanel PersonalTableContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox JobGroup;
    }
}