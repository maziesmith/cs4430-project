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
            this.NameTablecontainer = new System.Windows.Forms.TableLayoutPanel();
            this.LnameInput = new System.Windows.Forms.TextBox();
            this.FnameInput = new System.Windows.Forms.TextBox();
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
            this.PhoneInput = new System.Windows.Forms.NumericUpDown();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.HireDateTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.HireDateLabel = new System.Windows.Forms.Label();
            this.HireDateInput = new System.Windows.Forms.DateTimePicker();
            this.JobGroup = new System.Windows.Forms.GroupBox();
            this.JobDetailsTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.BonusTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.BonusLabel = new System.Windows.Forms.Label();
            this.BonusInput = new System.Windows.Forms.ComboBox();
            this.DeductionTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.DeductionLabel = new System.Windows.Forms.Label();
            this.DeductionInput = new System.Windows.Forms.ComboBox();
            this.HoldiayTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.HolidayLabel = new System.Windows.Forms.Label();
            this.HolidayInput = new System.Windows.Forms.ComboBox();
            this.JobTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.JobInput = new System.Windows.Forms.ComboBox();
            this.JobLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ParentTableContainer.SuspendLayout();
            this.DetailsGroup.SuspendLayout();
            this.PersonalTableContainer.SuspendLayout();
            this.NameTablecontainer.SuspendLayout();
            this.StreetTableContainer.SuspendLayout();
            this.CityTableContainer.SuspendLayout();
            this.StateTableContainer.SuspendLayout();
            this.ZipTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZipInput)).BeginInit();
            this.PhoneTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneInput)).BeginInit();
            this.HireDateTableContainer.SuspendLayout();
            this.JobGroup.SuspendLayout();
            this.JobDetailsTableContainer.SuspendLayout();
            this.BonusTableContainer.SuspendLayout();
            this.DeductionTableContainer.SuspendLayout();
            this.HoldiayTableContainer.SuspendLayout();
            this.JobTableContainer.SuspendLayout();
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
            this.PersonalTableContainer.Size = new System.Drawing.Size(388, 425);
            this.PersonalTableContainer.TabIndex = 0;
            // 
            // NameTablecontainer
            // 
            this.NameTablecontainer.ColumnCount = 2;
            this.NameTablecontainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NameTablecontainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NameTablecontainer.Controls.Add(this.LnameInput, 0, 1);
            this.NameTablecontainer.Controls.Add(this.FnameInput, 1, 1);
            this.NameTablecontainer.Controls.Add(this.FnamLabel, 0, 0);
            this.NameTablecontainer.Controls.Add(this.LnameLabel, 1, 0);
            this.NameTablecontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTablecontainer.Location = new System.Drawing.Point(3, 3);
            this.NameTablecontainer.Name = "NameTablecontainer";
            this.NameTablecontainer.RowCount = 2;
            this.NameTablecontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.03704F));
            this.NameTablecontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.96296F));
            this.NameTablecontainer.Size = new System.Drawing.Size(382, 54);
            this.NameTablecontainer.TabIndex = 0;
            // 
            // LnameInput
            // 
            this.LnameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LnameInput.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LnameInput.Location = new System.Drawing.Point(3, 27);
            this.LnameInput.Name = "LnameInput";
            this.LnameInput.Size = new System.Drawing.Size(185, 20);
            this.LnameInput.TabIndex = 0;
            // 
            // FnameInput
            // 
            this.FnameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FnameInput.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FnameInput.Location = new System.Drawing.Point(194, 27);
            this.FnameInput.Name = "FnameInput";
            this.FnameInput.Size = new System.Drawing.Size(185, 20);
            this.FnameInput.TabIndex = 1;
            // 
            // FnamLabel
            // 
            this.FnamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FnamLabel.AutoSize = true;
            this.FnamLabel.Location = new System.Drawing.Point(3, 7);
            this.FnamLabel.Name = "FnamLabel";
            this.FnamLabel.Size = new System.Drawing.Size(57, 13);
            this.FnamLabel.TabIndex = 2;
            this.FnamLabel.Text = "First Name";
            // 
            // LnameLabel
            // 
            this.LnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LnameLabel.AutoSize = true;
            this.LnameLabel.Location = new System.Drawing.Point(194, 7);
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
            this.StreetTableContainer.Location = new System.Drawing.Point(3, 63);
            this.StreetTableContainer.Name = "StreetTableContainer";
            this.StreetTableContainer.RowCount = 2;
            this.StreetTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.StreetTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.StreetTableContainer.Size = new System.Drawing.Size(382, 54);
            this.StreetTableContainer.TabIndex = 1;
            // 
            // StreetLabel
            // 
            this.StreetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(3, 3);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(35, 13);
            this.StreetLabel.TabIndex = 0;
            this.StreetLabel.Text = "Street";
            // 
            // StreetInput
            // 
            this.StreetInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetInput.Location = new System.Drawing.Point(3, 25);
            this.StreetInput.Name = "StreetInput";
            this.StreetInput.Size = new System.Drawing.Size(376, 20);
            this.StreetInput.TabIndex = 1;
            // 
            // CityTableContainer
            // 
            this.CityTableContainer.ColumnCount = 1;
            this.CityTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CityTableContainer.Controls.Add(this.CityInput, 0, 1);
            this.CityTableContainer.Controls.Add(this.CityLabel, 0, 0);
            this.CityTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CityTableContainer.Location = new System.Drawing.Point(3, 123);
            this.CityTableContainer.Name = "CityTableContainer";
            this.CityTableContainer.RowCount = 2;
            this.CityTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.CityTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.CityTableContainer.Size = new System.Drawing.Size(382, 54);
            this.CityTableContainer.TabIndex = 2;
            // 
            // CityInput
            // 
            this.CityInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CityInput.Location = new System.Drawing.Point(3, 25);
            this.CityInput.Name = "CityInput";
            this.CityInput.Size = new System.Drawing.Size(376, 20);
            this.CityInput.TabIndex = 2;
            // 
            // CityLabel
            // 
            this.CityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(3, 3);
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
            this.StateTableContainer.Location = new System.Drawing.Point(3, 183);
            this.StateTableContainer.Name = "StateTableContainer";
            this.StateTableContainer.RowCount = 2;
            this.StateTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.StateTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.StateTableContainer.Size = new System.Drawing.Size(382, 54);
            this.StateTableContainer.TabIndex = 3;
            // 
            // StateLabel
            // 
            this.StateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(3, 3);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(32, 13);
            this.StateLabel.TabIndex = 0;
            this.StateLabel.Text = "State";
            // 
            // StateInput
            // 
            this.StateInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StateInput.FormattingEnabled = true;
            this.StateInput.Location = new System.Drawing.Point(3, 24);
            this.StateInput.Name = "StateInput";
            this.StateInput.Size = new System.Drawing.Size(376, 21);
            this.StateInput.TabIndex = 1;
            // 
            // ZipTableContainer
            // 
            this.ZipTableContainer.ColumnCount = 1;
            this.ZipTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ZipTableContainer.Controls.Add(this.ZipLabel, 0, 0);
            this.ZipTableContainer.Controls.Add(this.ZipInput, 0, 1);
            this.ZipTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZipTableContainer.Location = new System.Drawing.Point(3, 243);
            this.ZipTableContainer.Name = "ZipTableContainer";
            this.ZipTableContainer.RowCount = 2;
            this.ZipTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ZipTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.ZipTableContainer.Size = new System.Drawing.Size(382, 54);
            this.ZipTableContainer.TabIndex = 4;
            // 
            // ZipLabel
            // 
            this.ZipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Location = new System.Drawing.Point(3, 3);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(24, 13);
            this.ZipLabel.TabIndex = 0;
            this.ZipLabel.Text = "ZIP";
            // 
            // ZipInput
            // 
            this.ZipInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ZipInput.Location = new System.Drawing.Point(3, 25);
            this.ZipInput.Name = "ZipInput";
            this.ZipInput.Size = new System.Drawing.Size(376, 20);
            this.ZipInput.TabIndex = 1;
            this.ZipInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PhoneTableContainer
            // 
            this.PhoneTableContainer.ColumnCount = 1;
            this.PhoneTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PhoneTableContainer.Controls.Add(this.PhoneInput, 0, 1);
            this.PhoneTableContainer.Controls.Add(this.PhoneLabel, 0, 0);
            this.PhoneTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneTableContainer.Location = new System.Drawing.Point(3, 303);
            this.PhoneTableContainer.Name = "PhoneTableContainer";
            this.PhoneTableContainer.RowCount = 2;
            this.PhoneTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PhoneTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PhoneTableContainer.Size = new System.Drawing.Size(382, 54);
            this.PhoneTableContainer.TabIndex = 5;
            // 
            // PhoneInput
            // 
            this.PhoneInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneInput.Location = new System.Drawing.Point(3, 25);
            this.PhoneInput.Name = "PhoneInput";
            this.PhoneInput.Size = new System.Drawing.Size(376, 20);
            this.PhoneInput.TabIndex = 2;
            this.PhoneInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(3, 3);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneLabel.TabIndex = 0;
            this.PhoneLabel.Text = "Phone Number";
            // 
            // HireDateTableContainer
            // 
            this.HireDateTableContainer.ColumnCount = 1;
            this.HireDateTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HireDateTableContainer.Controls.Add(this.HireDateLabel, 0, 0);
            this.HireDateTableContainer.Controls.Add(this.HireDateInput, 0, 1);
            this.HireDateTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HireDateTableContainer.Location = new System.Drawing.Point(3, 363);
            this.HireDateTableContainer.Name = "HireDateTableContainer";
            this.HireDateTableContainer.RowCount = 2;
            this.HireDateTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.HireDateTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.HireDateTableContainer.Size = new System.Drawing.Size(382, 59);
            this.HireDateTableContainer.TabIndex = 6;
            // 
            // HireDateLabel
            // 
            this.HireDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HireDateLabel.AutoSize = true;
            this.HireDateLabel.Location = new System.Drawing.Point(3, 4);
            this.HireDateLabel.Name = "HireDateLabel";
            this.HireDateLabel.Size = new System.Drawing.Size(52, 13);
            this.HireDateLabel.TabIndex = 0;
            this.HireDateLabel.Text = "Hire Date";
            // 
            // HireDateInput
            // 
            this.HireDateInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HireDateInput.Location = new System.Drawing.Point(3, 28);
            this.HireDateInput.Name = "HireDateInput";
            this.HireDateInput.Size = new System.Drawing.Size(376, 20);
            this.HireDateInput.TabIndex = 1;
            // 
            // JobGroup
            // 
            this.JobGroup.Controls.Add(this.JobDetailsTableContainer);
            this.JobGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JobGroup.Location = new System.Drawing.Point(403, 3);
            this.JobGroup.Name = "JobGroup";
            this.JobGroup.Size = new System.Drawing.Size(394, 444);
            this.JobGroup.TabIndex = 1;
            this.JobGroup.TabStop = false;
            this.JobGroup.Text = "Job Details";
            // 
            // JobDetailsTableContainer
            // 
            this.JobDetailsTableContainer.ColumnCount = 1;
            this.JobDetailsTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.JobDetailsTableContainer.Controls.Add(this.BonusTableContainer, 0, 3);
            this.JobDetailsTableContainer.Controls.Add(this.DeductionTableContainer, 0, 2);
            this.JobDetailsTableContainer.Controls.Add(this.HoldiayTableContainer, 0, 1);
            this.JobDetailsTableContainer.Controls.Add(this.JobTableContainer, 0, 0);
            this.JobDetailsTableContainer.Controls.Add(this.SubmitButton, 0, 4);
            this.JobDetailsTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JobDetailsTableContainer.Location = new System.Drawing.Point(3, 16);
            this.JobDetailsTableContainer.Name = "JobDetailsTableContainer";
            this.JobDetailsTableContainer.RowCount = 5;
            this.JobDetailsTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.JobDetailsTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.JobDetailsTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.JobDetailsTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.JobDetailsTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.JobDetailsTableContainer.Size = new System.Drawing.Size(388, 425);
            this.JobDetailsTableContainer.TabIndex = 0;
            // 
            // BonusTableContainer
            // 
            this.BonusTableContainer.ColumnCount = 1;
            this.BonusTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BonusTableContainer.Controls.Add(this.BonusLabel, 0, 0);
            this.BonusTableContainer.Controls.Add(this.BonusInput, 0, 1);
            this.BonusTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BonusTableContainer.Location = new System.Drawing.Point(3, 255);
            this.BonusTableContainer.Name = "BonusTableContainer";
            this.BonusTableContainer.RowCount = 2;
            this.BonusTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.BonusTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.BonusTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BonusTableContainer.Size = new System.Drawing.Size(382, 78);
            this.BonusTableContainer.TabIndex = 3;
            // 
            // BonusLabel
            // 
            this.BonusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BonusLabel.AutoSize = true;
            this.BonusLabel.Location = new System.Drawing.Point(3, 10);
            this.BonusLabel.Name = "BonusLabel";
            this.BonusLabel.Size = new System.Drawing.Size(48, 13);
            this.BonusLabel.TabIndex = 4;
            this.BonusLabel.Text = "Bonuses";
            // 
            // BonusInput
            // 
            this.BonusInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BonusInput.FormattingEnabled = true;
            this.BonusInput.Location = new System.Drawing.Point(3, 40);
            this.BonusInput.Name = "BonusInput";
            this.BonusInput.Size = new System.Drawing.Size(376, 21);
            this.BonusInput.TabIndex = 1;
            // 
            // DeductionTableContainer
            // 
            this.DeductionTableContainer.ColumnCount = 1;
            this.DeductionTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DeductionTableContainer.Controls.Add(this.DeductionLabel, 0, 0);
            this.DeductionTableContainer.Controls.Add(this.DeductionInput, 0, 1);
            this.DeductionTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeductionTableContainer.Location = new System.Drawing.Point(3, 171);
            this.DeductionTableContainer.Name = "DeductionTableContainer";
            this.DeductionTableContainer.RowCount = 2;
            this.DeductionTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.DeductionTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.DeductionTableContainer.Size = new System.Drawing.Size(382, 78);
            this.DeductionTableContainer.TabIndex = 2;
            // 
            // DeductionLabel
            // 
            this.DeductionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeductionLabel.AutoSize = true;
            this.DeductionLabel.Location = new System.Drawing.Point(3, 10);
            this.DeductionLabel.Name = "DeductionLabel";
            this.DeductionLabel.Size = new System.Drawing.Size(61, 13);
            this.DeductionLabel.TabIndex = 2;
            this.DeductionLabel.Text = "Deductions";
            // 
            // DeductionInput
            // 
            this.DeductionInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeductionInput.FormattingEnabled = true;
            this.DeductionInput.Location = new System.Drawing.Point(3, 40);
            this.DeductionInput.Name = "DeductionInput";
            this.DeductionInput.Size = new System.Drawing.Size(376, 21);
            this.DeductionInput.TabIndex = 1;
            // 
            // HoldiayTableContainer
            // 
            this.HoldiayTableContainer.ColumnCount = 1;
            this.HoldiayTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HoldiayTableContainer.Controls.Add(this.HolidayLabel, 0, 0);
            this.HoldiayTableContainer.Controls.Add(this.HolidayInput, 0, 1);
            this.HoldiayTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoldiayTableContainer.Location = new System.Drawing.Point(3, 87);
            this.HoldiayTableContainer.Name = "HoldiayTableContainer";
            this.HoldiayTableContainer.RowCount = 2;
            this.HoldiayTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.HoldiayTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.HoldiayTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.HoldiayTableContainer.Size = new System.Drawing.Size(382, 78);
            this.HoldiayTableContainer.TabIndex = 1;
            // 
            // HolidayLabel
            // 
            this.HolidayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HolidayLabel.AutoSize = true;
            this.HolidayLabel.Location = new System.Drawing.Point(3, 10);
            this.HolidayLabel.Name = "HolidayLabel";
            this.HolidayLabel.Size = new System.Drawing.Size(47, 13);
            this.HolidayLabel.TabIndex = 2;
            this.HolidayLabel.Text = "Holidays";
            // 
            // HolidayInput
            // 
            this.HolidayInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HolidayInput.FormattingEnabled = true;
            this.HolidayInput.Location = new System.Drawing.Point(3, 40);
            this.HolidayInput.Name = "HolidayInput";
            this.HolidayInput.Size = new System.Drawing.Size(376, 21);
            this.HolidayInput.TabIndex = 1;
            // 
            // JobTableContainer
            // 
            this.JobTableContainer.ColumnCount = 1;
            this.JobTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.JobTableContainer.Controls.Add(this.JobInput, 0, 1);
            this.JobTableContainer.Controls.Add(this.JobLabel, 0, 0);
            this.JobTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JobTableContainer.Location = new System.Drawing.Point(3, 3);
            this.JobTableContainer.Name = "JobTableContainer";
            this.JobTableContainer.RowCount = 2;
            this.JobTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.JobTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.JobTableContainer.Size = new System.Drawing.Size(382, 78);
            this.JobTableContainer.TabIndex = 0;
            // 
            // JobInput
            // 
            this.JobInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.JobInput.FormattingEnabled = true;
            this.JobInput.Location = new System.Drawing.Point(3, 40);
            this.JobInput.Name = "JobInput";
            this.JobInput.Size = new System.Drawing.Size(376, 21);
            this.JobInput.TabIndex = 0;
            // 
            // JobLabel
            // 
            this.JobLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.JobLabel.AutoSize = true;
            this.JobLabel.Location = new System.Drawing.Point(3, 10);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(44, 13);
            this.JobLabel.TabIndex = 1;
            this.JobLabel.Text = "Position";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitButton.Location = new System.Drawing.Point(151, 369);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(86, 23);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Add Employee";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.PhoneInput)).EndInit();
            this.HireDateTableContainer.ResumeLayout(false);
            this.HireDateTableContainer.PerformLayout();
            this.JobGroup.ResumeLayout(false);
            this.JobDetailsTableContainer.ResumeLayout(false);
            this.BonusTableContainer.ResumeLayout(false);
            this.BonusTableContainer.PerformLayout();
            this.DeductionTableContainer.ResumeLayout(false);
            this.DeductionTableContainer.PerformLayout();
            this.HoldiayTableContainer.ResumeLayout(false);
            this.HoldiayTableContainer.PerformLayout();
            this.JobTableContainer.ResumeLayout(false);
            this.JobTableContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ParentTableContainer;
        private System.Windows.Forms.GroupBox DetailsGroup;
        private System.Windows.Forms.TableLayoutPanel PersonalTableContainer;
        private System.Windows.Forms.TableLayoutPanel NameTablecontainer;
        private System.Windows.Forms.GroupBox JobGroup;
        private System.Windows.Forms.TextBox LnameInput;
        private System.Windows.Forms.TextBox FnameInput;
        private System.Windows.Forms.Label FnamLabel;
        private System.Windows.Forms.Label LnameLabel;
        private System.Windows.Forms.TableLayoutPanel StreetTableContainer;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.TableLayoutPanel CityTableContainer;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TableLayoutPanel StateTableContainer;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.TableLayoutPanel ZipTableContainer;
        private System.Windows.Forms.Label ZipLabel;
        private System.Windows.Forms.TableLayoutPanel PhoneTableContainer;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TableLayoutPanel HireDateTableContainer;
        private System.Windows.Forms.Label HireDateLabel;
        private System.Windows.Forms.TextBox StreetInput;
        private System.Windows.Forms.TextBox CityInput;
        private System.Windows.Forms.ComboBox StateInput;
        private System.Windows.Forms.NumericUpDown ZipInput;
        private System.Windows.Forms.NumericUpDown PhoneInput;
        private System.Windows.Forms.DateTimePicker HireDateInput;
        private System.Windows.Forms.TableLayoutPanel JobDetailsTableContainer;
        private System.Windows.Forms.TableLayoutPanel BonusTableContainer;
        private System.Windows.Forms.TableLayoutPanel DeductionTableContainer;
        private System.Windows.Forms.TableLayoutPanel HoldiayTableContainer;
        private System.Windows.Forms.TableLayoutPanel JobTableContainer;
        private System.Windows.Forms.Label BonusLabel;
        private System.Windows.Forms.ComboBox BonusInput;
        private System.Windows.Forms.Label DeductionLabel;
        private System.Windows.Forms.ComboBox DeductionInput;
        private System.Windows.Forms.ComboBox HolidayInput;
        private System.Windows.Forms.ComboBox JobInput;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.Label HolidayLabel;
        private System.Windows.Forms.Button SubmitButton;
    }
}