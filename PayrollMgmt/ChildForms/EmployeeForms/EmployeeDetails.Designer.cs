namespace PayrollMgmt.ChildForms {
    partial class EmployeeDetails {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DetailsGroup = new System.Windows.Forms.GroupBox();
            this.PersonalTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.NameTablecontainer = new System.Windows.Forms.TableLayoutPanel();
            this.FnameInput = new System.Windows.Forms.TextBox();
            this.LnameInput = new System.Windows.Forms.TextBox();
            this.FnamLabel = new System.Windows.Forms.Label();
            this.LnameLabel = new System.Windows.Forms.Label();
            this.StreetTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.StreetInput = new System.Windows.Forms.TextBox();
            this.CityTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.CityInput = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.StateTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.StateLabel = new System.Windows.Forms.Label();
            this.StateInput = new System.Windows.Forms.ComboBox();
            this.ZipTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.ZipInput = new System.Windows.Forms.NumericUpDown();
            this.PhoneTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PhoneInput = new System.Windows.Forms.TextBox();
            this.HireDateTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.HireDateLabel = new System.Windows.Forms.Label();
            this.HireDateInput = new System.Windows.Forms.DateTimePicker();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.DetailsGroup.SuspendLayout();
            this.PersonalTableContainer.SuspendLayout();
            this.NameTablecontainer.SuspendLayout();
            this.StreetTableContainer.SuspendLayout();
            this.CityTableContainer.SuspendLayout();
            this.StateTableContainer.SuspendLayout();
            this.ZipTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZipInput)).BeginInit();
            this.PhoneTableContainer.SuspendLayout();
            this.HireDateTableContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DetailsGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UpdateButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DetailsGroup
            // 
            this.DetailsGroup.Controls.Add(this.PersonalTableContainer);
            this.DetailsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsGroup.Location = new System.Drawing.Point(3, 3);
            this.DetailsGroup.Name = "DetailsGroup";
            this.DetailsGroup.Size = new System.Drawing.Size(794, 392);
            this.DetailsGroup.TabIndex = 2;
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
            this.PersonalTableContainer.Controls.Add(this.PhoneTableContainer, 0, 5);
            this.PersonalTableContainer.Controls.Add(this.HireDateTableContainer, 0, 6);
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
            this.PersonalTableContainer.Size = new System.Drawing.Size(788, 373);
            this.PersonalTableContainer.TabIndex = 0;
            // 
            // NameTablecontainer
            // 
            this.NameTablecontainer.ColumnCount = 2;
            this.NameTablecontainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NameTablecontainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NameTablecontainer.Controls.Add(this.FnameInput, 0, 1);
            this.NameTablecontainer.Controls.Add(this.LnameInput, 1, 1);
            this.NameTablecontainer.Controls.Add(this.FnamLabel, 0, 0);
            this.NameTablecontainer.Controls.Add(this.LnameLabel, 1, 0);
            this.NameTablecontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTablecontainer.Location = new System.Drawing.Point(3, 3);
            this.NameTablecontainer.Name = "NameTablecontainer";
            this.NameTablecontainer.RowCount = 2;
            this.NameTablecontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.03704F));
            this.NameTablecontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.96296F));
            this.NameTablecontainer.Size = new System.Drawing.Size(782, 47);
            this.NameTablecontainer.TabIndex = 0;
            // 
            // FnameInput
            // 
            this.FnameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FnameInput.Enabled = false;
            this.FnameInput.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FnameInput.Location = new System.Drawing.Point(3, 22);
            this.FnameInput.MaxLength = 50;
            this.FnameInput.Name = "FnameInput";
            this.FnameInput.Size = new System.Drawing.Size(385, 20);
            this.FnameInput.TabIndex = 0;
            // 
            // LnameInput
            // 
            this.LnameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LnameInput.Enabled = false;
            this.LnameInput.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LnameInput.Location = new System.Drawing.Point(394, 22);
            this.LnameInput.MaxLength = 50;
            this.LnameInput.Name = "LnameInput";
            this.LnameInput.Size = new System.Drawing.Size(385, 20);
            this.LnameInput.TabIndex = 1;
            // 
            // FnamLabel
            // 
            this.FnamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FnamLabel.AutoSize = true;
            this.FnamLabel.Location = new System.Drawing.Point(3, 4);
            this.FnamLabel.Name = "FnamLabel";
            this.FnamLabel.Size = new System.Drawing.Size(57, 13);
            this.FnamLabel.TabIndex = 2;
            this.FnamLabel.Text = "First Name";
            // 
            // LnameLabel
            // 
            this.LnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LnameLabel.AutoSize = true;
            this.LnameLabel.Location = new System.Drawing.Point(394, 4);
            this.LnameLabel.Name = "LnameLabel";
            this.LnameLabel.Size = new System.Drawing.Size(58, 13);
            this.LnameLabel.TabIndex = 3;
            this.LnameLabel.Text = "Last Name";
            // 
            // StreetTableContainer
            // 
            this.StreetTableContainer.ColumnCount = 1;
            this.StreetTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StreetTableContainer.Controls.Add(this.StreetLabel, 0, 0);
            this.StreetTableContainer.Controls.Add(this.StreetInput, 0, 1);
            this.StreetTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StreetTableContainer.Location = new System.Drawing.Point(3, 56);
            this.StreetTableContainer.Name = "StreetTableContainer";
            this.StreetTableContainer.RowCount = 2;
            this.StreetTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.StreetTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.StreetTableContainer.Size = new System.Drawing.Size(782, 47);
            this.StreetTableContainer.TabIndex = 1;
            // 
            // StreetLabel
            // 
            this.StreetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(3, 1);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(35, 13);
            this.StreetLabel.TabIndex = 0;
            this.StreetLabel.Text = "Street";
            // 
            // StreetInput
            // 
            this.StreetInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetInput.Enabled = false;
            this.StreetInput.Location = new System.Drawing.Point(3, 20);
            this.StreetInput.MaxLength = 256;
            this.StreetInput.Name = "StreetInput";
            this.StreetInput.Size = new System.Drawing.Size(776, 20);
            this.StreetInput.TabIndex = 1;
            // 
            // CityTableContainer
            // 
            this.CityTableContainer.ColumnCount = 1;
            this.CityTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CityTableContainer.Controls.Add(this.CityInput, 0, 1);
            this.CityTableContainer.Controls.Add(this.CityLabel, 0, 0);
            this.CityTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CityTableContainer.Location = new System.Drawing.Point(3, 109);
            this.CityTableContainer.Name = "CityTableContainer";
            this.CityTableContainer.RowCount = 2;
            this.CityTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.CityTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.CityTableContainer.Size = new System.Drawing.Size(782, 47);
            this.CityTableContainer.TabIndex = 2;
            // 
            // CityInput
            // 
            this.CityInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CityInput.Enabled = false;
            this.CityInput.Location = new System.Drawing.Point(3, 20);
            this.CityInput.MaxLength = 256;
            this.CityInput.Name = "CityInput";
            this.CityInput.Size = new System.Drawing.Size(776, 20);
            this.CityInput.TabIndex = 2;
            // 
            // CityLabel
            // 
            this.CityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(3, 1);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(24, 13);
            this.CityLabel.TabIndex = 0;
            this.CityLabel.Text = "City";
            // 
            // StateTableContainer
            // 
            this.StateTableContainer.ColumnCount = 1;
            this.StateTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StateTableContainer.Controls.Add(this.StateLabel, 0, 0);
            this.StateTableContainer.Controls.Add(this.StateInput, 0, 1);
            this.StateTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StateTableContainer.Location = new System.Drawing.Point(3, 162);
            this.StateTableContainer.Name = "StateTableContainer";
            this.StateTableContainer.RowCount = 2;
            this.StateTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.StateTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.StateTableContainer.Size = new System.Drawing.Size(782, 47);
            this.StateTableContainer.TabIndex = 3;
            // 
            // StateLabel
            // 
            this.StateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(3, 1);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(32, 13);
            this.StateLabel.TabIndex = 0;
            this.StateLabel.Text = "State";
            // 
            // StateInput
            // 
            this.StateInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StateInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StateInput.Enabled = false;
            this.StateInput.FormattingEnabled = true;
            this.StateInput.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.StateInput.Location = new System.Drawing.Point(3, 20);
            this.StateInput.Name = "StateInput";
            this.StateInput.Size = new System.Drawing.Size(776, 21);
            this.StateInput.TabIndex = 1;
            // 
            // ZipTableContainer
            // 
            this.ZipTableContainer.ColumnCount = 1;
            this.ZipTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ZipTableContainer.Controls.Add(this.ZipLabel, 0, 0);
            this.ZipTableContainer.Controls.Add(this.ZipInput, 0, 1);
            this.ZipTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZipTableContainer.Location = new System.Drawing.Point(3, 215);
            this.ZipTableContainer.Name = "ZipTableContainer";
            this.ZipTableContainer.RowCount = 2;
            this.ZipTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ZipTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.ZipTableContainer.Size = new System.Drawing.Size(782, 47);
            this.ZipTableContainer.TabIndex = 4;
            // 
            // ZipLabel
            // 
            this.ZipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Location = new System.Drawing.Point(3, 1);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(24, 13);
            this.ZipLabel.TabIndex = 0;
            this.ZipLabel.Text = "ZIP";
            // 
            // ZipInput
            // 
            this.ZipInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ZipInput.Enabled = false;
            this.ZipInput.Location = new System.Drawing.Point(3, 20);
            this.ZipInput.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ZipInput.Name = "ZipInput";
            this.ZipInput.Size = new System.Drawing.Size(776, 20);
            this.ZipInput.TabIndex = 1;
            this.ZipInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PhoneTableContainer
            // 
            this.PhoneTableContainer.ColumnCount = 1;
            this.PhoneTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PhoneTableContainer.Controls.Add(this.PhoneLabel, 0, 0);
            this.PhoneTableContainer.Controls.Add(this.PhoneInput, 0, 1);
            this.PhoneTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneTableContainer.Location = new System.Drawing.Point(3, 268);
            this.PhoneTableContainer.Name = "PhoneTableContainer";
            this.PhoneTableContainer.RowCount = 2;
            this.PhoneTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PhoneTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PhoneTableContainer.Size = new System.Drawing.Size(782, 47);
            this.PhoneTableContainer.TabIndex = 5;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(3, 1);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneLabel.TabIndex = 0;
            this.PhoneLabel.Text = "Phone Number";
            // 
            // PhoneInput
            // 
            this.PhoneInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneInput.Enabled = false;
            this.PhoneInput.Location = new System.Drawing.Point(3, 20);
            this.PhoneInput.MaxLength = 24;
            this.PhoneInput.Name = "PhoneInput";
            this.PhoneInput.Size = new System.Drawing.Size(776, 20);
            this.PhoneInput.TabIndex = 1;
            // 
            // HireDateTableContainer
            // 
            this.HireDateTableContainer.ColumnCount = 1;
            this.HireDateTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HireDateTableContainer.Controls.Add(this.HireDateLabel, 0, 0);
            this.HireDateTableContainer.Controls.Add(this.HireDateInput, 0, 1);
            this.HireDateTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HireDateTableContainer.Location = new System.Drawing.Point(3, 321);
            this.HireDateTableContainer.Name = "HireDateTableContainer";
            this.HireDateTableContainer.RowCount = 2;
            this.HireDateTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.HireDateTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.HireDateTableContainer.Size = new System.Drawing.Size(782, 49);
            this.HireDateTableContainer.TabIndex = 6;
            // 
            // HireDateLabel
            // 
            this.HireDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HireDateLabel.AutoSize = true;
            this.HireDateLabel.Location = new System.Drawing.Point(3, 1);
            this.HireDateLabel.Name = "HireDateLabel";
            this.HireDateLabel.Size = new System.Drawing.Size(52, 13);
            this.HireDateLabel.TabIndex = 0;
            this.HireDateLabel.Text = "Hire Date";
            // 
            // HireDateInput
            // 
            this.HireDateInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HireDateInput.Enabled = false;
            this.HireDateInput.Location = new System.Drawing.Point(3, 21);
            this.HireDateInput.Name = "HireDateInput";
            this.HireDateInput.Size = new System.Drawing.Size(776, 20);
            this.HireDateInput.TabIndex = 1;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateButton.Location = new System.Drawing.Point(350, 412);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(99, 23);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update Details";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmployeeDetails";
            this.Text = "View Employee Details";
            this.tableLayoutPanel1.ResumeLayout(false);
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
            this.ZipTableContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZipInput)).EndInit();
            this.PhoneTableContainer.ResumeLayout(false);
            this.PhoneTableContainer.PerformLayout();
            this.HireDateTableContainer.ResumeLayout(false);
            this.HireDateTableContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox DetailsGroup;
        private System.Windows.Forms.TableLayoutPanel PersonalTableContainer;
        private System.Windows.Forms.TableLayoutPanel NameTablecontainer;
        private System.Windows.Forms.TextBox FnameInput;
        private System.Windows.Forms.TextBox LnameInput;
        private System.Windows.Forms.Label FnamLabel;
        private System.Windows.Forms.Label LnameLabel;
        private System.Windows.Forms.TableLayoutPanel StreetTableContainer;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.TextBox StreetInput;
        private System.Windows.Forms.TableLayoutPanel CityTableContainer;
        private System.Windows.Forms.TextBox CityInput;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TableLayoutPanel StateTableContainer;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.ComboBox StateInput;
        private System.Windows.Forms.TableLayoutPanel ZipTableContainer;
        private System.Windows.Forms.Label ZipLabel;
        private System.Windows.Forms.NumericUpDown ZipInput;
        private System.Windows.Forms.TableLayoutPanel PhoneTableContainer;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox PhoneInput;
        private System.Windows.Forms.TableLayoutPanel HireDateTableContainer;
        private System.Windows.Forms.Label HireDateLabel;
        private System.Windows.Forms.DateTimePicker HireDateInput;
        private System.Windows.Forms.Button UpdateButton;
    }
}