namespace PayrollMgmt.ChildForms.DepartmentForms {
    partial class DepartmentDetails {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DetailsGroup = new System.Windows.Forms.GroupBox();
            this.PersonalTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.JobTitleTablecontainer = new System.Windows.Forms.TableLayoutPanel();
            this.DeptNameInput = new System.Windows.Forms.TextBox();
            this.DeptNameLabel = new System.Windows.Forms.Label();
            this.PayTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.JobDescTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.deptDescInput = new System.Windows.Forms.TextBox();
            this.DeptDescLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.EnableEditButton = new System.Windows.Forms.Button();
            this.deptLocationInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.DetailsGroup.SuspendLayout();
            this.PersonalTableContainer.SuspendLayout();
            this.JobTitleTablecontainer.SuspendLayout();
            this.PayTableContainer.SuspendLayout();
            this.JobDescTableContainer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DetailsGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 409);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // DetailsGroup
            // 
            this.DetailsGroup.Controls.Add(this.PersonalTableContainer);
            this.DetailsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsGroup.Location = new System.Drawing.Point(3, 3);
            this.DetailsGroup.Name = "DetailsGroup";
            this.DetailsGroup.Size = new System.Drawing.Size(790, 356);
            this.DetailsGroup.TabIndex = 2;
            this.DetailsGroup.TabStop = false;
            this.DetailsGroup.Text = "Department Details";
            // 
            // PersonalTableContainer
            // 
            this.PersonalTableContainer.ColumnCount = 1;
            this.PersonalTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PersonalTableContainer.Controls.Add(this.JobTitleTablecontainer, 0, 0);
            this.PersonalTableContainer.Controls.Add(this.PayTableContainer, 0, 1);
            this.PersonalTableContainer.Controls.Add(this.JobDescTableContainer, 0, 2);
            this.PersonalTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonalTableContainer.Location = new System.Drawing.Point(3, 16);
            this.PersonalTableContainer.Name = "PersonalTableContainer";
            this.PersonalTableContainer.RowCount = 3;
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PersonalTableContainer.Size = new System.Drawing.Size(784, 337);
            this.PersonalTableContainer.TabIndex = 0;
            // 
            // JobTitleTablecontainer
            // 
            this.JobTitleTablecontainer.ColumnCount = 1;
            this.JobTitleTablecontainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.JobTitleTablecontainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.JobTitleTablecontainer.Controls.Add(this.DeptNameInput, 0, 1);
            this.JobTitleTablecontainer.Controls.Add(this.DeptNameLabel, 0, 0);
            this.JobTitleTablecontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JobTitleTablecontainer.Location = new System.Drawing.Point(3, 3);
            this.JobTitleTablecontainer.Name = "JobTitleTablecontainer";
            this.JobTitleTablecontainer.RowCount = 2;
            this.JobTitleTablecontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.20339F));
            this.JobTitleTablecontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.79661F));
            this.JobTitleTablecontainer.Size = new System.Drawing.Size(778, 106);
            this.JobTitleTablecontainer.TabIndex = 0;
            // 
            // DeptNameInput
            // 
            this.DeptNameInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeptNameInput.Enabled = false;
            this.DeptNameInput.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DeptNameInput.Location = new System.Drawing.Point(3, 60);
            this.DeptNameInput.MaxLength = 50;
            this.DeptNameInput.Name = "DeptNameInput";
            this.DeptNameInput.Size = new System.Drawing.Size(385, 20);
            this.DeptNameInput.TabIndex = 0;
            // 
            // DeptNameLabel
            // 
            this.DeptNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeptNameLabel.AutoSize = true;
            this.DeptNameLabel.Location = new System.Drawing.Point(3, 21);
            this.DeptNameLabel.Name = "DeptNameLabel";
            this.DeptNameLabel.Size = new System.Drawing.Size(93, 13);
            this.DeptNameLabel.TabIndex = 2;
            this.DeptNameLabel.Text = "Department Name";
            // 
            // PayTableContainer
            // 
            this.PayTableContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PayTableContainer.ColumnCount = 1;
            this.PayTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PayTableContainer.Controls.Add(this.deptLocationInput, 0, 1);
            this.PayTableContainer.Controls.Add(this.LocationLabel, 0, 0);
            this.PayTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayTableContainer.Location = new System.Drawing.Point(3, 115);
            this.PayTableContainer.Name = "PayTableContainer";
            this.PayTableContainer.RowCount = 2;
            this.PayTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PayTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PayTableContainer.Size = new System.Drawing.Size(778, 106);
            this.PayTableContainer.TabIndex = 1;
            // 
            // LocationLabel
            // 
            this.LocationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(3, 18);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(48, 13);
            this.LocationLabel.TabIndex = 0;
            this.LocationLabel.Text = "Location";
            // 
            // JobDescTableContainer
            // 
            this.JobDescTableContainer.ColumnCount = 1;
            this.JobDescTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.JobDescTableContainer.Controls.Add(this.deptDescInput, 0, 1);
            this.JobDescTableContainer.Controls.Add(this.DeptDescLabel, 0, 0);
            this.JobDescTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JobDescTableContainer.Location = new System.Drawing.Point(3, 227);
            this.JobDescTableContainer.Name = "JobDescTableContainer";
            this.JobDescTableContainer.RowCount = 2;
            this.JobDescTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.JobDescTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.JobDescTableContainer.Size = new System.Drawing.Size(778, 107);
            this.JobDescTableContainer.TabIndex = 2;
            // 
            // deptDescInput
            // 
            this.deptDescInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deptDescInput.Enabled = false;
            this.deptDescInput.Location = new System.Drawing.Point(3, 35);
            this.deptDescInput.MaxLength = 256;
            this.deptDescInput.Multiline = true;
            this.deptDescInput.Name = "deptDescInput";
            this.deptDescInput.Size = new System.Drawing.Size(385, 68);
            this.deptDescInput.TabIndex = 2;
            // 
            // DeptDescLabel
            // 
            this.DeptDescLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeptDescLabel.AutoSize = true;
            this.DeptDescLabel.Location = new System.Drawing.Point(3, 19);
            this.DeptDescLabel.Name = "DeptDescLabel";
            this.DeptDescLabel.Size = new System.Drawing.Size(118, 13);
            this.DeptDescLabel.TabIndex = 0;
            this.DeptDescLabel.Text = "Department Description";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.UpdateButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.EnableEditButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 365);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(790, 41);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateButton.Enabled = false;
            this.UpdateButton.Location = new System.Drawing.Point(546, 11);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(99, 23);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update Details";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // EnableEditButton
            // 
            this.EnableEditButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnableEditButton.Location = new System.Drawing.Point(154, 11);
            this.EnableEditButton.Name = "EnableEditButton";
            this.EnableEditButton.Size = new System.Drawing.Size(89, 23);
            this.EnableEditButton.TabIndex = 5;
            this.EnableEditButton.Text = "Enable Editing";
            this.EnableEditButton.UseVisualStyleBackColor = true;
            this.EnableEditButton.Click += new System.EventHandler(this.EnableEditButton_Click);

            // 
            // deptLocationInput
            // 
            this.deptLocationInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deptLocationInput.Enabled = false;
            this.deptLocationInput.ForeColor = System.Drawing.SystemColors.InfoText;
            this.deptLocationInput.Location = new System.Drawing.Point(3, 58);
            this.deptLocationInput.MaxLength = 50;
            this.deptLocationInput.Name = "deptLocationInput";
            this.deptLocationInput.Size = new System.Drawing.Size(385, 20);
            this.deptLocationInput.TabIndex = 1;
            // 
            // DepartmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DepartmentDetails";
            this.Text = "DepartmentDetails";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.DetailsGroup.ResumeLayout(false);
            this.PersonalTableContainer.ResumeLayout(false);
            this.JobTitleTablecontainer.ResumeLayout(false);
            this.JobTitleTablecontainer.PerformLayout();
            this.PayTableContainer.ResumeLayout(false);
            this.PayTableContainer.PerformLayout();
            this.JobDescTableContainer.ResumeLayout(false);
            this.JobDescTableContainer.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox DetailsGroup;
        private System.Windows.Forms.TableLayoutPanel PersonalTableContainer;
        private System.Windows.Forms.TableLayoutPanel JobTitleTablecontainer;
        private System.Windows.Forms.TextBox DeptNameInput;
        private System.Windows.Forms.Label DeptNameLabel;
        private System.Windows.Forms.TableLayoutPanel PayTableContainer;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.TableLayoutPanel JobDescTableContainer;
        private System.Windows.Forms.TextBox deptDescInput;
        private System.Windows.Forms.Label DeptDescLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button EnableEditButton;
        private System.Windows.Forms.TextBox deptLocationInput;
    }
}