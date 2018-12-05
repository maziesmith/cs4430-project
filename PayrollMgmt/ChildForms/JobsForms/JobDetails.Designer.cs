namespace PayrollMgmt.ChildForms.JobsForms
{
    partial class JobDetails
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DetailsGroup = new System.Windows.Forms.GroupBox();
            this.PersonalTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.JobTitleTablecontainer = new System.Windows.Forms.TableLayoutPanel();
            this.JobTitleInput = new System.Windows.Forms.TextBox();
            this.JobTitleLabel = new System.Windows.Forms.Label();
            this.PayTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.PayLabel = new System.Windows.Forms.Label();
            this.JobDescTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.JobDescInput = new System.Windows.Forms.TextBox();
            this.JobDescLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.EnableEditButton = new System.Windows.Forms.Button();
            this.PayInput = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.DetailsGroup.SuspendLayout();
            this.PersonalTableContainer.SuspendLayout();
            this.JobTitleTablecontainer.SuspendLayout();
            this.PayTableContainer.SuspendLayout();
            this.JobDescTableContainer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PayInput)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DetailsGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, -2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // DetailsGroup
            // 
            this.DetailsGroup.Controls.Add(this.PersonalTableContainer);
            this.DetailsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsGroup.Location = new System.Drawing.Point(3, 3);
            this.DetailsGroup.Name = "DetailsGroup";
            this.DetailsGroup.Size = new System.Drawing.Size(790, 393);
            this.DetailsGroup.TabIndex = 2;
            this.DetailsGroup.TabStop = false;
            this.DetailsGroup.Text = "Job Details";
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
            this.PersonalTableContainer.Size = new System.Drawing.Size(784, 374);
            this.PersonalTableContainer.TabIndex = 0;
            // 
            // JobTitleTablecontainer
            // 
            this.JobTitleTablecontainer.ColumnCount = 1;
            this.JobTitleTablecontainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.JobTitleTablecontainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.JobTitleTablecontainer.Controls.Add(this.JobTitleInput, 0, 1);
            this.JobTitleTablecontainer.Controls.Add(this.JobTitleLabel, 0, 0);
            this.JobTitleTablecontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JobTitleTablecontainer.Location = new System.Drawing.Point(3, 3);
            this.JobTitleTablecontainer.Name = "JobTitleTablecontainer";
            this.JobTitleTablecontainer.RowCount = 2;
            this.JobTitleTablecontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.20339F));
            this.JobTitleTablecontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.79661F));
            this.JobTitleTablecontainer.Size = new System.Drawing.Size(778, 118);
            this.JobTitleTablecontainer.TabIndex = 0;
            // 
            // JobTitleInput
            // 
            this.JobTitleInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.JobTitleInput.Enabled = false;
            this.JobTitleInput.ForeColor = System.Drawing.SystemColors.InfoText;
            this.JobTitleInput.Location = new System.Drawing.Point(3, 67);
            this.JobTitleInput.MaxLength = 50;
            this.JobTitleInput.Name = "JobTitleInput";
            this.JobTitleInput.Size = new System.Drawing.Size(385, 20);
            this.JobTitleInput.TabIndex = 0;
            // 
            // JobTitleLabel
            // 
            this.JobTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.JobTitleLabel.AutoSize = true;
            this.JobTitleLabel.Location = new System.Drawing.Point(3, 24);
            this.JobTitleLabel.Name = "JobTitleLabel";
            this.JobTitleLabel.Size = new System.Drawing.Size(47, 13);
            this.JobTitleLabel.TabIndex = 2;
            this.JobTitleLabel.Text = "Job Title";
            // 
            // PayTableContainer
            // 
            this.PayTableContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PayTableContainer.ColumnCount = 1;
            this.PayTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PayTableContainer.Controls.Add(this.PayLabel, 0, 0);
            this.PayTableContainer.Controls.Add(this.PayInput, 0, 1);
            this.PayTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayTableContainer.Location = new System.Drawing.Point(3, 127);
            this.PayTableContainer.Name = "PayTableContainer";
            this.PayTableContainer.RowCount = 2;
            this.PayTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PayTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PayTableContainer.Size = new System.Drawing.Size(778, 118);
            this.PayTableContainer.TabIndex = 1;
            this.PayTableContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.PayTableContainer_Paint);
            // 
            // PayLabel
            // 
            this.PayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PayLabel.AutoSize = true;
            this.PayLabel.Location = new System.Drawing.Point(3, 22);
            this.PayLabel.Name = "PayLabel";
            this.PayLabel.Size = new System.Drawing.Size(25, 13);
            this.PayLabel.TabIndex = 0;
            this.PayLabel.Text = "Pay";
            // 
            // JobDescTableContainer
            // 
            this.JobDescTableContainer.ColumnCount = 1;
            this.JobDescTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.JobDescTableContainer.Controls.Add(this.JobDescInput, 0, 1);
            this.JobDescTableContainer.Controls.Add(this.JobDescLabel, 0, 0);
            this.JobDescTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JobDescTableContainer.Location = new System.Drawing.Point(3, 251);
            this.JobDescTableContainer.Name = "JobDescTableContainer";
            this.JobDescTableContainer.RowCount = 2;
            this.JobDescTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.JobDescTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.JobDescTableContainer.Size = new System.Drawing.Size(778, 120);
            this.JobDescTableContainer.TabIndex = 2;
            // 
            // JobDescInput
            // 
            this.JobDescInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.JobDescInput.Enabled = false;
            this.JobDescInput.Location = new System.Drawing.Point(3, 44);
            this.JobDescInput.MaxLength = 256;
            this.JobDescInput.Multiline = true;
            this.JobDescInput.Name = "JobDescInput";
            this.JobDescInput.Size = new System.Drawing.Size(385, 68);
            this.JobDescInput.TabIndex = 2;
            // 
            // JobDescLabel
            // 
            this.JobDescLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.JobDescLabel.AutoSize = true;
            this.JobDescLabel.Location = new System.Drawing.Point(3, 23);
            this.JobDescLabel.Name = "JobDescLabel";
            this.JobDescLabel.Size = new System.Drawing.Size(80, 13);
            this.JobDescLabel.TabIndex = 0;
            this.JobDescLabel.Text = "Job Description";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.UpdateButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.EnableEditButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 402);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(790, 45);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateButton.Enabled = false;
            this.UpdateButton.Location = new System.Drawing.Point(543, 11);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(99, 23);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update Details";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // EnableEditButton
            // 
            this.EnableEditButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnableEditButton.Location = new System.Drawing.Point(153, 11);
            this.EnableEditButton.Name = "EnableEditButton";
            this.EnableEditButton.Size = new System.Drawing.Size(89, 23);
            this.EnableEditButton.TabIndex = 5;
            this.EnableEditButton.Text = "Enable Editing";
            this.EnableEditButton.UseVisualStyleBackColor = true;
            // 
            // PayInput
            // 
            this.PayInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PayInput.DecimalPlaces = 2;
            this.PayInput.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.PayInput.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PayInput.Location = new System.Drawing.Point(3, 66);
            this.PayInput.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.PayInput.Name = "PayInput";
            this.PayInput.Size = new System.Drawing.Size(201, 20);
            this.PayInput.TabIndex = 1;
            this.PayInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // JobDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "JobDetails";
            this.Text = "JobDetails";
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
            ((System.ComponentModel.ISupportInitialize)(this.PayInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox DetailsGroup;
        private System.Windows.Forms.TableLayoutPanel PersonalTableContainer;
        private System.Windows.Forms.TableLayoutPanel JobTitleTablecontainer;
        private System.Windows.Forms.TextBox JobTitleInput;
        private System.Windows.Forms.Label JobTitleLabel;
        private System.Windows.Forms.TableLayoutPanel PayTableContainer;
        private System.Windows.Forms.Label PayLabel;
        private System.Windows.Forms.TableLayoutPanel JobDescTableContainer;
        private System.Windows.Forms.TextBox JobDescInput;
        private System.Windows.Forms.Label JobDescLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button EnableEditButton;
        private System.Windows.Forms.NumericUpDown PayInput;
    }
}