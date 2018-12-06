namespace PayrollMgmt.ChildForms.DepartmentForms
{
    partial class DepartmentAdd
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
            this.dManager = new System.Windows.Forms.TextBox();
            this.dDescription = new System.Windows.Forms.TextBox();
            this.dLocation = new System.Windows.Forms.TextBox();
            this.dName = new System.Windows.Forms.TextBox();
            this.selectManager = new System.Windows.Forms.Button();
            this.createDepartment = new System.Windows.Forms.Button();
            this.DetailsGroup = new System.Windows.Forms.GroupBox();
            this.PersonalTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.NameTablecontainer = new System.Windows.Forms.TableLayoutPanel();
            this.DNameLabel = new System.Windows.Forms.Label();
            this.StreetTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.DepartmentDescLabel = new System.Windows.Forms.Label();
            this.CityTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.DepartmentLocationLabel = new System.Windows.Forms.Label();
            this.StateTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.DepartmentManagerLabel = new System.Windows.Forms.Label();
            this.DetailsGroup.SuspendLayout();
            this.PersonalTableContainer.SuspendLayout();
            this.NameTablecontainer.SuspendLayout();
            this.StreetTableContainer.SuspendLayout();
            this.CityTableContainer.SuspendLayout();
            this.StateTableContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dManager
            // 
            this.dManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dManager.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dManager.Location = new System.Drawing.Point(3, 29);
            this.dManager.MaxLength = 256;
            this.dManager.Name = "dManager";
            this.dManager.ReadOnly = true;
            this.dManager.Size = new System.Drawing.Size(636, 22);
            this.dManager.TabIndex = 17;
            this.dManager.TabStop = false;
            // 
            // dDescription
            // 
            this.dDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dDescription.Location = new System.Drawing.Point(3, 36);
            this.dDescription.MaxLength = 256;
            this.dDescription.Multiline = true;
            this.dDescription.Name = "dDescription";
            this.dDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dDescription.Size = new System.Drawing.Size(782, 74);
            this.dDescription.TabIndex = 2;
            // 
            // dLocation
            // 
            this.dLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLocation.Location = new System.Drawing.Point(3, 55);
            this.dLocation.MaxLength = 256;
            this.dLocation.Name = "dLocation";
            this.dLocation.Size = new System.Drawing.Size(782, 22);
            this.dLocation.TabIndex = 3;
            // 
            // dName
            // 
            this.dName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dName.Location = new System.Drawing.Point(3, 26);
            this.dName.MaxLength = 50;
            this.dName.Name = "dName";
            this.dName.Size = new System.Drawing.Size(782, 22);
            this.dName.TabIndex = 1;
            // 
            // selectManager
            // 
            this.selectManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.selectManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.selectManager.Location = new System.Drawing.Point(657, 21);
            this.selectManager.Name = "selectManager";
            this.selectManager.Size = new System.Drawing.Size(115, 39);
            this.selectManager.TabIndex = 4;
            this.selectManager.Text = "Select Manager";
            this.selectManager.UseVisualStyleBackColor = true;
            this.selectManager.Click += new System.EventHandler(this.selectManager_Click);
            // 
            // createDepartment
            // 
            this.createDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.createDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDepartment.Location = new System.Drawing.Point(326, 360);
            this.createDepartment.Name = "createDepartment";
            this.createDepartment.Size = new System.Drawing.Size(141, 68);
            this.createDepartment.TabIndex = 20;
            this.createDepartment.Text = "Create Department";
            this.createDepartment.UseVisualStyleBackColor = true;
            this.createDepartment.Click += new System.EventHandler(this.createDepartment_Click);
            // 
            // DetailsGroup
            // 
            this.DetailsGroup.Controls.Add(this.PersonalTableContainer);
            this.DetailsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsGroup.Location = new System.Drawing.Point(0, 0);
            this.DetailsGroup.Name = "DetailsGroup";
            this.DetailsGroup.Size = new System.Drawing.Size(800, 450);
            this.DetailsGroup.TabIndex = 21;
            this.DetailsGroup.TabStop = false;
            this.DetailsGroup.Text = "Department Details";
            // 
            // PersonalTableContainer
            // 
            this.PersonalTableContainer.ColumnCount = 1;
            this.PersonalTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PersonalTableContainer.Controls.Add(this.NameTablecontainer, 0, 0);
            this.PersonalTableContainer.Controls.Add(this.createDepartment, 0, 4);
            this.PersonalTableContainer.Controls.Add(this.StreetTableContainer, 0, 1);
            this.PersonalTableContainer.Controls.Add(this.CityTableContainer, 0, 2);
            this.PersonalTableContainer.Controls.Add(this.StateTableContainer, 0, 3);
            this.PersonalTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonalTableContainer.Location = new System.Drawing.Point(3, 16);
            this.PersonalTableContainer.Name = "PersonalTableContainer";
            this.PersonalTableContainer.RowCount = 5;
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.61021F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.058F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.00928F));
            this.PersonalTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.70534F));
            this.PersonalTableContainer.Size = new System.Drawing.Size(794, 431);
            this.PersonalTableContainer.TabIndex = 0;
            // 
            // NameTablecontainer
            // 
            this.NameTablecontainer.ColumnCount = 1;
            this.NameTablecontainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NameTablecontainer.Controls.Add(this.DNameLabel, 0, 0);
            this.NameTablecontainer.Controls.Add(this.dName, 0, 1);
            this.NameTablecontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTablecontainer.Location = new System.Drawing.Point(3, 3);
            this.NameTablecontainer.Name = "NameTablecontainer";
            this.NameTablecontainer.RowCount = 2;
            this.NameTablecontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.03704F));
            this.NameTablecontainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.96296F));
            this.NameTablecontainer.Size = new System.Drawing.Size(788, 55);
            this.NameTablecontainer.TabIndex = 0;
            // 
            // DNameLabel
            // 
            this.DNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DNameLabel.AutoSize = true;
            this.DNameLabel.Location = new System.Drawing.Point(3, 7);
            this.DNameLabel.Name = "DNameLabel";
            this.DNameLabel.Size = new System.Drawing.Size(35, 13);
            this.DNameLabel.TabIndex = 2;
            this.DNameLabel.Text = "Name";
            // 
            // StreetTableContainer
            // 
            this.StreetTableContainer.ColumnCount = 1;
            this.StreetTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StreetTableContainer.Controls.Add(this.DepartmentDescLabel, 0, 0);
            this.StreetTableContainer.Controls.Add(this.dDescription, 0, 1);
            this.StreetTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StreetTableContainer.Location = new System.Drawing.Point(3, 64);
            this.StreetTableContainer.Name = "StreetTableContainer";
            this.StreetTableContainer.RowCount = 2;
            this.StreetTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.StreetTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.StreetTableContainer.Size = new System.Drawing.Size(788, 113);
            this.StreetTableContainer.TabIndex = 1;
            // 
            // DepartmentDescLabel
            // 
            this.DepartmentDescLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DepartmentDescLabel.AutoSize = true;
            this.DepartmentDescLabel.Location = new System.Drawing.Point(3, 20);
            this.DepartmentDescLabel.Name = "DepartmentDescLabel";
            this.DepartmentDescLabel.Size = new System.Drawing.Size(60, 13);
            this.DepartmentDescLabel.TabIndex = 0;
            this.DepartmentDescLabel.Text = "Description";
            // 
            // CityTableContainer
            // 
            this.CityTableContainer.ColumnCount = 1;
            this.CityTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CityTableContainer.Controls.Add(this.DepartmentLocationLabel, 0, 0);
            this.CityTableContainer.Controls.Add(this.dLocation, 0, 1);
            this.CityTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CityTableContainer.Location = new System.Drawing.Point(3, 183);
            this.CityTableContainer.Name = "CityTableContainer";
            this.CityTableContainer.RowCount = 2;
            this.CityTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.CityTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.CityTableContainer.Size = new System.Drawing.Size(788, 102);
            this.CityTableContainer.TabIndex = 2;
            // 
            // DepartmentLocationLabel
            // 
            this.DepartmentLocationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DepartmentLocationLabel.AutoSize = true;
            this.DepartmentLocationLabel.Location = new System.Drawing.Point(3, 17);
            this.DepartmentLocationLabel.Name = "DepartmentLocationLabel";
            this.DepartmentLocationLabel.Size = new System.Drawing.Size(48, 13);
            this.DepartmentLocationLabel.TabIndex = 0;
            this.DepartmentLocationLabel.Text = "Location";
            // 
            // StateTableContainer
            // 
            this.StateTableContainer.ColumnCount = 2;
            this.StateTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StateTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.StateTableContainer.Controls.Add(this.DepartmentManagerLabel, 0, 0);
            this.StateTableContainer.Controls.Add(this.selectManager, 1, 1);
            this.StateTableContainer.Controls.Add(this.dManager, 0, 1);
            this.StateTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StateTableContainer.Location = new System.Drawing.Point(3, 291);
            this.StateTableContainer.Name = "StateTableContainer";
            this.StateTableContainer.RowCount = 2;
            this.StateTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.StateTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.StateTableContainer.Size = new System.Drawing.Size(788, 63);
            this.StateTableContainer.TabIndex = 3;
            // 
            // DepartmentManagerLabel
            // 
            this.DepartmentManagerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DepartmentManagerLabel.AutoSize = true;
            this.DepartmentManagerLabel.Location = new System.Drawing.Point(3, 5);
            this.DepartmentManagerLabel.Name = "DepartmentManagerLabel";
            this.DepartmentManagerLabel.Size = new System.Drawing.Size(49, 13);
            this.DepartmentManagerLabel.TabIndex = 0;
            this.DepartmentManagerLabel.Text = "Manager";
            // 
            // DepartmentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.DetailsGroup);
            this.Name = "DepartmentAdd";
            this.Text = "DepartmentAdd";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox dManager;
        private System.Windows.Forms.TextBox dDescription;
        private System.Windows.Forms.TextBox dLocation;
        private System.Windows.Forms.TextBox dName;
        private System.Windows.Forms.Button selectManager;
        private System.Windows.Forms.Button createDepartment;
        private System.Windows.Forms.GroupBox DetailsGroup;
        private System.Windows.Forms.TableLayoutPanel PersonalTableContainer;
        private System.Windows.Forms.TableLayoutPanel NameTablecontainer;
        private System.Windows.Forms.Label DNameLabel;
        private System.Windows.Forms.TableLayoutPanel StreetTableContainer;
        private System.Windows.Forms.Label DepartmentDescLabel;
        private System.Windows.Forms.TableLayoutPanel CityTableContainer;
        private System.Windows.Forms.Label DepartmentLocationLabel;
        private System.Windows.Forms.TableLayoutPanel StateTableContainer;
        private System.Windows.Forms.Label DepartmentManagerLabel;
    }
}