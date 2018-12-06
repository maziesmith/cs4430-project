namespace PayrollMgmt.ChildForms.JobsForms
{
    partial class JobAdd
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
            this.createJob = new System.Windows.Forms.Button();
            this.selectDepartment = new System.Windows.Forms.Button();
            this.jDepartment = new System.Windows.Forms.TextBox();
            this.jDescription = new System.Windows.Forms.TextBox();
            this.jPay = new System.Windows.Forms.TextBox();
            this.jName = new System.Windows.Forms.TextBox();
            this.DetailsGroup = new System.Windows.Forms.GroupBox();
            this.PersonalTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.NameTablecontainer = new System.Windows.Forms.TableLayoutPanel();
            this.DnameLabel = new System.Windows.Forms.Label();
            this.StreetTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.DescLabel = new System.Windows.Forms.Label();
            this.CityTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.PayLabel = new System.Windows.Forms.Label();
            this.StateTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.ZipTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.DetailsGroup.SuspendLayout();
            this.PersonalTableContainer.SuspendLayout();
            this.NameTablecontainer.SuspendLayout();
            this.StreetTableContainer.SuspendLayout();
            this.CityTableContainer.SuspendLayout();
            this.StateTableContainer.SuspendLayout();
            this.ZipTableContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // createJob
            // 
            this.createJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.createJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createJob.Location = new System.Drawing.Point(323, 3);
            this.createJob.Name = "createJob";
            this.createJob.Size = new System.Drawing.Size(141, 57);
            this.createJob.TabIndex = 30;
            this.createJob.Text = "Create Job";
            this.createJob.UseVisualStyleBackColor = true;
            this.createJob.Click += new System.EventHandler(this.createJob_Click);
            // 
            // selectDepartment
            // 
            this.selectDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.selectDepartment.Location = new System.Drawing.Point(642, 43);
            this.selectDepartment.Name = "selectDepartment";
            this.selectDepartment.Size = new System.Drawing.Size(143, 33);
            this.selectDepartment.TabIndex = 24;
            this.selectDepartment.Text = "Select Department";
            this.selectDepartment.UseVisualStyleBackColor = true;
            this.selectDepartment.Click += new System.EventHandler(this.selectDepartment_Click);
            // 
            // jDepartment
            // 
            this.jDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.jDepartment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.jDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jDepartment.Location = new System.Drawing.Point(3, 48);
            this.jDepartment.MaxLength = 256;
            this.jDepartment.Name = "jDepartment";
            this.jDepartment.ReadOnly = true;
            this.jDepartment.Size = new System.Drawing.Size(633, 22);
            this.jDepartment.TabIndex = 29;
            this.jDepartment.TabStop = false;
            // 
            // jDescription
            // 
            this.jDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jDescription.Location = new System.Drawing.Point(3, 38);
            this.jDescription.MaxLength = 256;
            this.jDescription.Multiline = true;
            this.jDescription.Name = "jDescription";
            this.jDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jDescription.Size = new System.Drawing.Size(782, 76);
            this.jDescription.TabIndex = 22;
            // 
            // jPay
            // 
            this.jPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.jPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jPay.Location = new System.Drawing.Point(3, 37);
            this.jPay.MaxLength = 256;
            this.jPay.Name = "jPay";
            this.jPay.Size = new System.Drawing.Size(782, 22);
            this.jPay.TabIndex = 23;
            this.jPay.Text = "0.00";
            // 
            // jName
            // 
            this.jName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.jName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jName.Location = new System.Drawing.Point(3, 26);
            this.jName.MaxLength = 50;
            this.jName.Name = "jName";
            this.jName.Size = new System.Drawing.Size(782, 22);
            this.jName.TabIndex = 21;
            // 
            // DetailsGroup
            // 
            this.DetailsGroup.Controls.Add(this.PersonalTableContainer);
            this.DetailsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsGroup.Location = new System.Drawing.Point(0, 0);
            this.DetailsGroup.Name = "DetailsGroup";
            this.DetailsGroup.Size = new System.Drawing.Size(800, 450);
            this.DetailsGroup.TabIndex = 31;
            this.DetailsGroup.TabStop = false;
            this.DetailsGroup.Text = "Personal Details";
            // 
            // PersonalTableContainer
            // 
            this.PersonalTableContainer.ColumnCount = 1;
            this.PersonalTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PersonalTableContainer.Controls.Add(this.NameTablecontainer, 0, 0);
            this.PersonalTableContainer.Controls.Add(this.StreetTableContainer, 0, 1);
            this.PersonalTableContainer.Controls.Add(this.CityTableContainer, 0, 2);
            this.PersonalTableContainer.Controls.Add(this.StateTableContainer, 0, 3);
            this.PersonalTableContainer.Controls.Add(this.ZipTableContainer, 0, 4);
            this.PersonalTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonalTableContainer.Location = new System.Drawing.Point(3, 16);
            this.PersonalTableContainer.Name = "PersonalTableContainer";
            this.PersonalTableContainer.RowCount = 5;
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.47059F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.58824F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.82353F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.29412F));
            this.PersonalTableContainer.Size = new System.Drawing.Size(794, 431);
            this.PersonalTableContainer.TabIndex = 0;
            // 
            // NameTablecontainer
            // 
            this.NameTablecontainer.ColumnCount = 1;
            this.NameTablecontainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NameTablecontainer.Controls.Add(this.DnameLabel, 0, 0);
            this.NameTablecontainer.Controls.Add(this.jName, 0, 1);
            this.NameTablecontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTablecontainer.Location = new System.Drawing.Point(3, 3);
            this.NameTablecontainer.Name = "NameTablecontainer";
            this.NameTablecontainer.RowCount = 2;
            this.NameTablecontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.03704F));
            this.NameTablecontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.96296F));
            this.NameTablecontainer.Size = new System.Drawing.Size(788, 55);
            this.NameTablecontainer.TabIndex = 0;
            // 
            // DnameLabel
            // 
            this.DnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DnameLabel.AutoSize = true;
            this.DnameLabel.Location = new System.Drawing.Point(3, 7);
            this.DnameLabel.Name = "DnameLabel";
            this.DnameLabel.Size = new System.Drawing.Size(35, 13);
            this.DnameLabel.TabIndex = 2;
            this.DnameLabel.Text = "Name";
            // 
            // StreetTableContainer
            // 
            this.StreetTableContainer.ColumnCount = 1;
            this.StreetTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StreetTableContainer.Controls.Add(this.DescLabel, 0, 0);
            this.StreetTableContainer.Controls.Add(this.jDescription, 0, 1);
            this.StreetTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StreetTableContainer.Location = new System.Drawing.Point(3, 64);
            this.StreetTableContainer.Name = "StreetTableContainer";
            this.StreetTableContainer.RowCount = 2;
            this.StreetTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.StreetTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.StreetTableContainer.Size = new System.Drawing.Size(788, 117);
            this.StreetTableContainer.TabIndex = 1;
            // 
            // DescLabel
            // 
            this.DescLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DescLabel.AutoSize = true;
            this.DescLabel.Location = new System.Drawing.Point(3, 22);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(60, 13);
            this.DescLabel.TabIndex = 0;
            this.DescLabel.Text = "Description";
            // 
            // CityTableContainer
            // 
            this.CityTableContainer.ColumnCount = 1;
            this.CityTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CityTableContainer.Controls.Add(this.PayLabel, 0, 0);
            this.CityTableContainer.Controls.Add(this.jPay, 0, 1);
            this.CityTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CityTableContainer.Location = new System.Drawing.Point(3, 187);
            this.CityTableContainer.Name = "CityTableContainer";
            this.CityTableContainer.RowCount = 2;
            this.CityTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.CityTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.CityTableContainer.Size = new System.Drawing.Size(788, 74);
            this.CityTableContainer.TabIndex = 2;
            // 
            // PayLabel
            // 
            this.PayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PayLabel.AutoSize = true;
            this.PayLabel.Location = new System.Drawing.Point(3, 9);
            this.PayLabel.Name = "PayLabel";
            this.PayLabel.Size = new System.Drawing.Size(25, 13);
            this.PayLabel.TabIndex = 0;
            this.PayLabel.Text = "Pay";
            // 
            // StateTableContainer
            // 
            this.StateTableContainer.ColumnCount = 2;
            this.StateTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StateTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.StateTableContainer.Controls.Add(this.DepartmentLabel, 0, 0);
            this.StateTableContainer.Controls.Add(this.jDepartment, 0, 1);
            this.StateTableContainer.Controls.Add(this.selectDepartment, 1, 1);
            this.StateTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StateTableContainer.Location = new System.Drawing.Point(3, 267);
            this.StateTableContainer.Name = "StateTableContainer";
            this.StateTableContainer.RowCount = 2;
            this.StateTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.StateTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.StateTableContainer.Size = new System.Drawing.Size(788, 92);
            this.StateTableContainer.TabIndex = 3;
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(3, 14);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(62, 13);
            this.DepartmentLabel.TabIndex = 0;
            this.DepartmentLabel.Text = "Department";
            // 
            // ZipTableContainer
            // 
            this.ZipTableContainer.ColumnCount = 1;
            this.ZipTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ZipTableContainer.Controls.Add(this.createJob, 0, 0);
            this.ZipTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZipTableContainer.Location = new System.Drawing.Point(3, 365);
            this.ZipTableContainer.Name = "ZipTableContainer";
            this.ZipTableContainer.RowCount = 1;
            this.ZipTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ZipTableContainer.Size = new System.Drawing.Size(788, 63);
            this.ZipTableContainer.TabIndex = 4;
            // 
            // JobAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.DetailsGroup);
            this.Name = "JobAdd";
            this.Text = "JobAdd";
            this.DetailsGroup.ResumeLayout(false);
            this.PersonalTableContainer.ResumeLayout(false);
            this.NameTablecontainer.ResumeLayout(false);
            this.NameTablecontainer.PerformLayout();
            this.StreetTableContainer.ResumeLayout(false);
            this.StreetTableContainer.PerformLayout();
            this.CityTableContainer.ResumeLayout(false);
            this.CityTableContainer.PerformLayout();
            this.StateTableContainer.ResumeLayout(false);
            this.StateTableContainer.PerformLayout();
            this.ZipTableContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createJob;
        private System.Windows.Forms.Button selectDepartment;
        private System.Windows.Forms.TextBox jDepartment;
        private System.Windows.Forms.TextBox jDescription;
        private System.Windows.Forms.TextBox jPay;
        private System.Windows.Forms.TextBox jName;
        private System.Windows.Forms.GroupBox DetailsGroup;
        private System.Windows.Forms.TableLayoutPanel PersonalTableContainer;
        private System.Windows.Forms.TableLayoutPanel NameTablecontainer;
        private System.Windows.Forms.Label DnameLabel;
        private System.Windows.Forms.TableLayoutPanel StreetTableContainer;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.TableLayoutPanel CityTableContainer;
        private System.Windows.Forms.Label PayLabel;
        private System.Windows.Forms.TableLayoutPanel StateTableContainer;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.TableLayoutPanel ZipTableContainer;
    }
}