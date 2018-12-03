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
            this.MainTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeDataTable)).BeginInit();
            this.EditDataTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalHoursInput)).BeginInit();
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
            this.TimeDataTable.Size = new System.Drawing.Size(554, 444);
            this.TimeDataTable.TabIndex = 0;
            this.TimeDataTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TimeDataTable_CellMouseClick);
            // 
            // EditDataTableContainer
            // 
            this.EditDataTableContainer.ColumnCount = 1;
            this.EditDataTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditDataTableContainer.Controls.Add(this.WeekStartInput, 0, 2);
            this.EditDataTableContainer.Controls.Add(this.WeekEndInput, 0, 4);
            this.EditDataTableContainer.Controls.Add(this.TotalHoursInput, 0, 6);
            this.EditDataTableContainer.Controls.Add(this.SubmitButton, 0, 7);
            this.EditDataTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditDataTableContainer.Location = new System.Drawing.Point(3, 3);
            this.EditDataTableContainer.Name = "EditDataTableContainer";
            this.EditDataTableContainer.RowCount = 8;
            this.EditDataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.825939F));
            this.EditDataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.802048F));
            this.EditDataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.6041F));
            this.EditDataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.802048F));
            this.EditDataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.6041F));
            this.EditDataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.802048F));
            this.EditDataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.6041F));
            this.EditDataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.95563F));
            this.EditDataTableContainer.Size = new System.Drawing.Size(234, 444);
            this.EditDataTableContainer.TabIndex = 1;
            // 
            // WeekStartInput
            // 
            this.WeekStartInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekStartInput.Location = new System.Drawing.Point(3, 58);
            this.WeekStartInput.Name = "WeekStartInput";
            this.WeekStartInput.Size = new System.Drawing.Size(228, 20);
            this.WeekStartInput.TabIndex = 0;
            // 
            // WeekEndInput
            // 
            this.WeekEndInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekEndInput.Location = new System.Drawing.Point(3, 134);
            this.WeekEndInput.Name = "WeekEndInput";
            this.WeekEndInput.Size = new System.Drawing.Size(228, 20);
            this.WeekEndInput.TabIndex = 1;
            // 
            // TotalHoursInput
            // 
            this.TotalHoursInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalHoursInput.DecimalPlaces = 2;
            this.TotalHoursInput.Location = new System.Drawing.Point(3, 210);
            this.TotalHoursInput.Name = "TotalHoursInput";
            this.TotalHoursInput.Size = new System.Drawing.Size(228, 20);
            this.TotalHoursInput.TabIndex = 2;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SubmitButton.Location = new System.Drawing.Point(79, 261);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.TotalHoursInput)).EndInit();
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
    }
}