namespace PayrollMgmt.ChildForms {
    partial class EmployeeTime {
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
            this.MainTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.TimeDataTable = new System.Windows.Forms.DataGridView();
            this.EditDataTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.WeekStartInput = new System.Windows.Forms.DateTimePicker();
            this.WeekEndInput = new System.Windows.Forms.DateTimePicker();
            this.TotalHoursInput = new System.Windows.Forms.NumericUpDown();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.WeekStartLabel = new System.Windows.Forms.Label();
            this.WeekEndLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.EmployeeIDInput = new System.Windows.Forms.NumericUpDown();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.MainTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeDataTable)).BeginInit();
            this.EditDataTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalHoursInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeIDInput)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTableContainer
            // 
            this.MainTableContainer.ColumnCount = 2;
            this.MainTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.MainTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.MainTableContainer.Controls.Add(this.TimeDataTable, 1, 0);
            this.MainTableContainer.Controls.Add(this.EditDataTableContainer, 0, 0);
            this.MainTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableContainer.Location = new System.Drawing.Point(0, 0);
            this.MainTableContainer.Name = "MainTableContainer";
            this.MainTableContainer.RowCount = 1;
            this.MainTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableContainer.Size = new System.Drawing.Size(800, 450);
            this.MainTableContainer.TabIndex = 0;
            // 
            // TimeDataTable
            // 
            this.TimeDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimeDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeDataTable.Location = new System.Drawing.Point(243, 3);
            this.TimeDataTable.Name = "TimeDataTable";
            this.TimeDataTable.ReadOnly = true;
            this.TimeDataTable.Size = new System.Drawing.Size(554, 444);
            this.TimeDataTable.TabIndex = 0;
            this.TimeDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TimeDataTable_CellDoubleClick);
            // 
            // EditDataTableContainer
            // 
            this.EditDataTableContainer.ColumnCount = 1;
            this.EditDataTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditDataTableContainer.Controls.Add(this.WeekStartInput, 0, 4);
            this.EditDataTableContainer.Controls.Add(this.WeekEndInput, 0, 6);
            this.EditDataTableContainer.Controls.Add(this.TotalHoursInput, 0, 8);
            this.EditDataTableContainer.Controls.Add(this.SubmitButton, 0, 9);
            this.EditDataTableContainer.Controls.Add(this.WeekStartLabel, 0, 3);
            this.EditDataTableContainer.Controls.Add(this.WeekEndLabel, 0, 5);
            this.EditDataTableContainer.Controls.Add(this.HoursLabel, 0, 7);
            this.EditDataTableContainer.Controls.Add(this.EmployeeIDInput, 0, 2);
            this.EditDataTableContainer.Controls.Add(this.EmployeeLabel, 0, 1);
            this.EditDataTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditDataTableContainer.Location = new System.Drawing.Point(3, 3);
            this.EditDataTableContainer.Name = "EditDataTableContainer";
            this.EditDataTableContainer.RowCount = 10;
            this.EditDataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.417973F));
            this.EditDataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.417973F));
            this.EditDataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.835946F));
            this.EditDataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.126658F));
            this.EditDataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.25332F));
            this.EditDataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.126658F));
            this.EditDataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.25332F));
            this.EditDataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.126658F));
            this.EditDataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.25332F));
            this.EditDataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.18818F));
            this.EditDataTableContainer.Size = new System.Drawing.Size(234, 444);
            this.EditDataTableContainer.TabIndex = 1;
            // 
            // WeekStartInput
            // 
            this.WeekStartInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekStartInput.Location = new System.Drawing.Point(3, 102);
            this.WeekStartInput.Name = "WeekStartInput";
            this.WeekStartInput.Size = new System.Drawing.Size(228, 20);
            this.WeekStartInput.TabIndex = 0;
            this.WeekStartInput.ValueChanged += new System.EventHandler(this.WeekStartInput_ValueChanged);
            // 
            // WeekEndInput
            // 
            this.WeekEndInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekEndInput.Enabled = false;
            this.WeekEndInput.Location = new System.Drawing.Point(3, 169);
            this.WeekEndInput.Name = "WeekEndInput";
            this.WeekEndInput.Size = new System.Drawing.Size(228, 20);
            this.WeekEndInput.TabIndex = 1;
            // 
            // TotalHoursInput
            // 
            this.TotalHoursInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalHoursInput.DecimalPlaces = 2;
            this.TotalHoursInput.Location = new System.Drawing.Point(3, 236);
            this.TotalHoursInput.Name = "TotalHoursInput";
            this.TotalHoursInput.Size = new System.Drawing.Size(228, 20);
            this.TotalHoursInput.TabIndex = 2;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SubmitButton.Location = new System.Drawing.Point(79, 281);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // WeekStartLabel
            // 
            this.WeekStartLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WeekStartLabel.AutoSize = true;
            this.WeekStartLabel.Location = new System.Drawing.Point(3, 86);
            this.WeekStartLabel.Name = "WeekStartLabel";
            this.WeekStartLabel.Size = new System.Drawing.Size(87, 13);
            this.WeekStartLabel.TabIndex = 4;
            this.WeekStartLabel.Text = "Week Start Date";
            // 
            // WeekEndLabel
            // 
            this.WeekEndLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WeekEndLabel.AutoSize = true;
            this.WeekEndLabel.Location = new System.Drawing.Point(3, 153);
            this.WeekEndLabel.Name = "WeekEndLabel";
            this.WeekEndLabel.Size = new System.Drawing.Size(84, 13);
            this.WeekEndLabel.TabIndex = 5;
            this.WeekEndLabel.Text = "Week End Date";
            // 
            // HoursLabel
            // 
            this.HoursLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(3, 220);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(62, 13);
            this.HoursLabel.TabIndex = 6;
            this.HoursLabel.Text = "Total Hours";
            // 
            // EmployeeIDInput
            // 
            this.EmployeeIDInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeIDInput.Enabled = false;
            this.EmployeeIDInput.Location = new System.Drawing.Point(3, 41);
            this.EmployeeIDInput.Name = "EmployeeIDInput";
            this.EmployeeIDInput.Size = new System.Drawing.Size(228, 20);
            this.EmployeeIDInput.TabIndex = 7;
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Location = new System.Drawing.Point(3, 25);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(67, 13);
            this.EmployeeLabel.TabIndex = 8;
            this.EmployeeLabel.Text = "Employee ID";
            // 
            // EmployeeTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.MainTableContainer);
            this.Name = "EmployeeTime";
            this.Text = "View Employeee Hours";
            this.MainTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TimeDataTable)).EndInit();
            this.EditDataTableContainer.ResumeLayout(false);
            this.EditDataTableContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalHoursInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeIDInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableContainer;
        private System.Windows.Forms.DataGridView TimeDataTable;
        private System.Windows.Forms.TableLayoutPanel EditDataTableContainer;
        private System.Windows.Forms.DateTimePicker WeekStartInput;
        private System.Windows.Forms.DateTimePicker WeekEndInput;
        private System.Windows.Forms.NumericUpDown TotalHoursInput;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label WeekStartLabel;
        private System.Windows.Forms.Label WeekEndLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.NumericUpDown EmployeeIDInput;
        private System.Windows.Forms.Label EmployeeLabel;
    }
}