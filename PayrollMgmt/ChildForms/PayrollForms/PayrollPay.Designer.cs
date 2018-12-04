namespace PayrollMgmt.ChildForms.PayrollForms {
    partial class PayrollPay {
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
            this.MainTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.DataTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.HoursGroup = new System.Windows.Forms.GroupBox();
            this.HoursDataTable = new System.Windows.Forms.DataGridView();
            this.PayGroup = new System.Windows.Forms.GroupBox();
            this.PayDataTable = new System.Windows.Forms.DataGridView();
            this.SummaryTableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.PromptLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.PayLabel = new System.Windows.Forms.Label();
            this.HourDataLabel = new System.Windows.Forms.Label();
            this.PayDataLabel = new System.Windows.Forms.Label();
            this.PreTotalLabel = new System.Windows.Forms.Label();
            this.PreTotalMathLabel = new System.Windows.Forms.Label();
            this.PreTotalDataLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FinalPayLabel = new System.Windows.Forms.Label();
            this.OvertimeLabel = new System.Windows.Forms.Label();
            this.OvertimePayLabel = new System.Windows.Forms.Label();
            this.DeductionsDataLabel = new System.Windows.Forms.Label();
            this.OvertimeHoursDataLabel = new System.Windows.Forms.Label();
            this.OvertimePayDataLabel = new System.Windows.Forms.Label();
            this.FinalPayDataLabel = new System.Windows.Forms.Label();
            this.BonusesDataLabel = new System.Windows.Forms.Label();
            this.SubmitButtom = new System.Windows.Forms.Button();
            this.MainTableContainer.SuspendLayout();
            this.DataTableContainer.SuspendLayout();
            this.HoursGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursDataTable)).BeginInit();
            this.PayGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PayDataTable)).BeginInit();
            this.SummaryTableContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableContainer
            // 
            this.MainTableContainer.ColumnCount = 2;
            this.MainTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.125F));
            this.MainTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.875F));
            this.MainTableContainer.Controls.Add(this.DataTableContainer, 1, 0);
            this.MainTableContainer.Controls.Add(this.SummaryTableContainer, 0, 0);
            this.MainTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableContainer.Location = new System.Drawing.Point(0, 0);
            this.MainTableContainer.Name = "MainTableContainer";
            this.MainTableContainer.RowCount = 1;
            this.MainTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableContainer.Size = new System.Drawing.Size(800, 450);
            this.MainTableContainer.TabIndex = 0;
            // 
            // DataTableContainer
            // 
            this.DataTableContainer.ColumnCount = 1;
            this.DataTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DataTableContainer.Controls.Add(this.HoursGroup, 0, 0);
            this.DataTableContainer.Controls.Add(this.PayGroup, 0, 1);
            this.DataTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataTableContainer.Location = new System.Drawing.Point(244, 3);
            this.DataTableContainer.Name = "DataTableContainer";
            this.DataTableContainer.RowCount = 2;
            this.DataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DataTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DataTableContainer.Size = new System.Drawing.Size(553, 444);
            this.DataTableContainer.TabIndex = 0;
            // 
            // HoursGroup
            // 
            this.HoursGroup.Controls.Add(this.HoursDataTable);
            this.HoursGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoursGroup.Location = new System.Drawing.Point(3, 3);
            this.HoursGroup.Name = "HoursGroup";
            this.HoursGroup.Size = new System.Drawing.Size(547, 216);
            this.HoursGroup.TabIndex = 0;
            this.HoursGroup.TabStop = false;
            this.HoursGroup.Text = "Weekly Hours";
            // 
            // HoursDataTable
            // 
            this.HoursDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HoursDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoursDataTable.Location = new System.Drawing.Point(3, 16);
            this.HoursDataTable.Name = "HoursDataTable";
            this.HoursDataTable.ReadOnly = true;
            this.HoursDataTable.Size = new System.Drawing.Size(541, 197);
            this.HoursDataTable.TabIndex = 0;
            this.HoursDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HoursDataTable_CellDoubleClick);
            // 
            // PayGroup
            // 
            this.PayGroup.Controls.Add(this.PayDataTable);
            this.PayGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayGroup.Location = new System.Drawing.Point(3, 225);
            this.PayGroup.Name = "PayGroup";
            this.PayGroup.Size = new System.Drawing.Size(547, 216);
            this.PayGroup.TabIndex = 1;
            this.PayGroup.TabStop = false;
            this.PayGroup.Text = "Payments";
            // 
            // PayDataTable
            // 
            this.PayDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PayDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayDataTable.Location = new System.Drawing.Point(3, 16);
            this.PayDataTable.Name = "PayDataTable";
            this.PayDataTable.ReadOnly = true;
            this.PayDataTable.Size = new System.Drawing.Size(541, 197);
            this.PayDataTable.TabIndex = 0;
            // 
            // SummaryTableContainer
            // 
            this.SummaryTableContainer.ColumnCount = 4;
            this.SummaryTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.764784F));
            this.SummaryTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.98267F));
            this.SummaryTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.25254F));
            this.SummaryTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.SummaryTableContainer.Controls.Add(this.PromptLabel, 1, 0);
            this.SummaryTableContainer.Controls.Add(this.HoursLabel, 1, 2);
            this.SummaryTableContainer.Controls.Add(this.PayLabel, 1, 3);
            this.SummaryTableContainer.Controls.Add(this.HourDataLabel, 2, 2);
            this.SummaryTableContainer.Controls.Add(this.PayDataLabel, 2, 3);
            this.SummaryTableContainer.Controls.Add(this.PreTotalLabel, 1, 5);
            this.SummaryTableContainer.Controls.Add(this.PreTotalMathLabel, 2, 5);
            this.SummaryTableContainer.Controls.Add(this.PreTotalDataLabel, 2, 6);
            this.SummaryTableContainer.Controls.Add(this.label1, 1, 7);
            this.SummaryTableContainer.Controls.Add(this.label2, 1, 8);
            this.SummaryTableContainer.Controls.Add(this.FinalPayLabel, 1, 11);
            this.SummaryTableContainer.Controls.Add(this.OvertimeLabel, 1, 9);
            this.SummaryTableContainer.Controls.Add(this.OvertimePayLabel, 1, 10);
            this.SummaryTableContainer.Controls.Add(this.DeductionsDataLabel, 2, 8);
            this.SummaryTableContainer.Controls.Add(this.OvertimeHoursDataLabel, 2, 9);
            this.SummaryTableContainer.Controls.Add(this.OvertimePayDataLabel, 2, 10);
            this.SummaryTableContainer.Controls.Add(this.FinalPayDataLabel, 2, 11);
            this.SummaryTableContainer.Controls.Add(this.BonusesDataLabel, 2, 7);
            this.SummaryTableContainer.Controls.Add(this.SubmitButtom, 1, 12);
            this.SummaryTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SummaryTableContainer.Location = new System.Drawing.Point(3, 3);
            this.SummaryTableContainer.Name = "SummaryTableContainer";
            this.SummaryTableContainer.RowCount = 13;
            this.SummaryTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.SummaryTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.981982F));
            this.SummaryTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.SummaryTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.SummaryTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.SummaryTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.SummaryTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.SummaryTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.SummaryTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.SummaryTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.SummaryTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.SummaryTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.SummaryTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.SummaryTableContainer.Size = new System.Drawing.Size(235, 444);
            this.SummaryTableContainer.TabIndex = 1;
            // 
            // PromptLabel
            // 
            this.PromptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PromptLabel.AutoSize = true;
            this.PromptLabel.Location = new System.Drawing.Point(11, 21);
            this.PromptLabel.Name = "PromptLabel";
            this.PromptLabel.Size = new System.Drawing.Size(107, 13);
            this.PromptLabel.TabIndex = 0;
            this.PromptLabel.Text = "Select a Work Week";
            // 
            // HoursLabel
            // 
            this.HoursLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(11, 89);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(65, 13);
            this.HoursLabel.TabIndex = 1;
            this.HoursLabel.Text = "Total Hours:";
            // 
            // PayLabel
            // 
            this.PayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PayLabel.AutoSize = true;
            this.PayLabel.Location = new System.Drawing.Point(11, 123);
            this.PayLabel.Name = "PayLabel";
            this.PayLabel.Size = new System.Drawing.Size(61, 13);
            this.PayLabel.TabIndex = 2;
            this.PayLabel.Text = "Hourly Pay:";
            // 
            // HourDataLabel
            // 
            this.HourDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HourDataLabel.AutoSize = true;
            this.HourDataLabel.Location = new System.Drawing.Point(210, 89);
            this.HourDataLabel.Name = "HourDataLabel";
            this.HourDataLabel.Size = new System.Drawing.Size(13, 13);
            this.HourDataLabel.TabIndex = 3;
            this.HourDataLabel.Text = "0";
            // 
            // PayDataLabel
            // 
            this.PayDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PayDataLabel.AutoSize = true;
            this.PayDataLabel.Location = new System.Drawing.Point(210, 123);
            this.PayDataLabel.Name = "PayDataLabel";
            this.PayDataLabel.Size = new System.Drawing.Size(13, 13);
            this.PayDataLabel.TabIndex = 4;
            this.PayDataLabel.Text = "0";
            // 
            // PreTotalLabel
            // 
            this.PreTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PreTotalLabel.AutoSize = true;
            this.PreTotalLabel.Location = new System.Drawing.Point(11, 191);
            this.PreTotalLabel.Name = "PreTotalLabel";
            this.PreTotalLabel.Size = new System.Drawing.Size(129, 13);
            this.PreTotalLabel.TabIndex = 5;
            this.PreTotalLabel.Text = "Pre Deductions/Bonuses:";
            // 
            // PreTotalMathLabel
            // 
            this.PreTotalMathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PreTotalMathLabel.AutoSize = true;
            this.PreTotalMathLabel.Location = new System.Drawing.Point(210, 191);
            this.PreTotalMathLabel.Name = "PreTotalMathLabel";
            this.PreTotalMathLabel.Size = new System.Drawing.Size(13, 13);
            this.PreTotalMathLabel.TabIndex = 6;
            this.PreTotalMathLabel.Text = "0";
            this.PreTotalMathLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PreTotalDataLabel
            // 
            this.PreTotalDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PreTotalDataLabel.AutoSize = true;
            this.PreTotalDataLabel.Location = new System.Drawing.Point(210, 225);
            this.PreTotalDataLabel.Name = "PreTotalDataLabel";
            this.PreTotalDataLabel.Size = new System.Drawing.Size(13, 13);
            this.PreTotalDataLabel.TabIndex = 7;
            this.PreTotalDataLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bonuses";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Deductions:";
            // 
            // FinalPayLabel
            // 
            this.FinalPayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FinalPayLabel.AutoSize = true;
            this.FinalPayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalPayLabel.Location = new System.Drawing.Point(11, 395);
            this.FinalPayLabel.Name = "FinalPayLabel";
            this.FinalPayLabel.Size = new System.Drawing.Size(144, 13);
            this.FinalPayLabel.TabIndex = 10;
            this.FinalPayLabel.Text = "Final Paycheck Amount:";
            // 
            // OvertimeLabel
            // 
            this.OvertimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OvertimeLabel.AutoSize = true;
            this.OvertimeLabel.Location = new System.Drawing.Point(11, 327);
            this.OvertimeLabel.Name = "OvertimeLabel";
            this.OvertimeLabel.Size = new System.Drawing.Size(83, 13);
            this.OvertimeLabel.TabIndex = 11;
            this.OvertimeLabel.Text = "Overtime Hours:";
            // 
            // OvertimePayLabel
            // 
            this.OvertimePayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OvertimePayLabel.AutoSize = true;
            this.OvertimePayLabel.Location = new System.Drawing.Point(11, 361);
            this.OvertimePayLabel.Name = "OvertimePayLabel";
            this.OvertimePayLabel.Size = new System.Drawing.Size(73, 13);
            this.OvertimePayLabel.TabIndex = 12;
            this.OvertimePayLabel.Text = "Overtime Pay:";
            // 
            // DeductionsDataLabel
            // 
            this.DeductionsDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeductionsDataLabel.AutoSize = true;
            this.DeductionsDataLabel.Location = new System.Drawing.Point(210, 293);
            this.DeductionsDataLabel.Name = "DeductionsDataLabel";
            this.DeductionsDataLabel.Size = new System.Drawing.Size(13, 13);
            this.DeductionsDataLabel.TabIndex = 13;
            this.DeductionsDataLabel.Text = "0";
            // 
            // OvertimeHoursDataLabel
            // 
            this.OvertimeHoursDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OvertimeHoursDataLabel.AutoSize = true;
            this.OvertimeHoursDataLabel.Location = new System.Drawing.Point(210, 327);
            this.OvertimeHoursDataLabel.Name = "OvertimeHoursDataLabel";
            this.OvertimeHoursDataLabel.Size = new System.Drawing.Size(13, 13);
            this.OvertimeHoursDataLabel.TabIndex = 14;
            this.OvertimeHoursDataLabel.Text = "0";
            // 
            // OvertimePayDataLabel
            // 
            this.OvertimePayDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OvertimePayDataLabel.AutoSize = true;
            this.OvertimePayDataLabel.Location = new System.Drawing.Point(210, 361);
            this.OvertimePayDataLabel.Name = "OvertimePayDataLabel";
            this.OvertimePayDataLabel.Size = new System.Drawing.Size(13, 13);
            this.OvertimePayDataLabel.TabIndex = 15;
            this.OvertimePayDataLabel.Text = "0";
            // 
            // FinalPayDataLabel
            // 
            this.FinalPayDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FinalPayDataLabel.AutoSize = true;
            this.FinalPayDataLabel.Location = new System.Drawing.Point(210, 395);
            this.FinalPayDataLabel.Name = "FinalPayDataLabel";
            this.FinalPayDataLabel.Size = new System.Drawing.Size(13, 13);
            this.FinalPayDataLabel.TabIndex = 16;
            this.FinalPayDataLabel.Text = "0";
            // 
            // BonusesDataLabel
            // 
            this.BonusesDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BonusesDataLabel.AutoSize = true;
            this.BonusesDataLabel.Location = new System.Drawing.Point(210, 259);
            this.BonusesDataLabel.Name = "BonusesDataLabel";
            this.BonusesDataLabel.Size = new System.Drawing.Size(13, 13);
            this.BonusesDataLabel.TabIndex = 17;
            this.BonusesDataLabel.Text = "0";
            // 
            // SubmitButtom
            // 
            this.SubmitButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButtom.Location = new System.Drawing.Point(84, 418);
            this.SubmitButtom.Name = "SubmitButtom";
            this.SubmitButtom.Size = new System.Drawing.Size(75, 23);
            this.SubmitButtom.TabIndex = 18;
            this.SubmitButtom.Text = "Submit Paycheck";
            this.SubmitButtom.UseVisualStyleBackColor = true;
            // 
            // PayrollPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.MainTableContainer);
            this.Name = "PayrollPay";
            this.Text = "PayrollPay";
            this.MainTableContainer.ResumeLayout(false);
            this.DataTableContainer.ResumeLayout(false);
            this.HoursGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HoursDataTable)).EndInit();
            this.PayGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PayDataTable)).EndInit();
            this.SummaryTableContainer.ResumeLayout(false);
            this.SummaryTableContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableContainer;
        private System.Windows.Forms.TableLayoutPanel DataTableContainer;
        private System.Windows.Forms.GroupBox HoursGroup;
        private System.Windows.Forms.DataGridView HoursDataTable;
        private System.Windows.Forms.GroupBox PayGroup;
        private System.Windows.Forms.DataGridView PayDataTable;
        private System.Windows.Forms.TableLayoutPanel SummaryTableContainer;
        private System.Windows.Forms.Label PromptLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label PayLabel;
        private System.Windows.Forms.Label HourDataLabel;
        private System.Windows.Forms.Label PayDataLabel;
        private System.Windows.Forms.Label PreTotalLabel;
        private System.Windows.Forms.Label PreTotalMathLabel;
        private System.Windows.Forms.Label PreTotalDataLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FinalPayLabel;
        private System.Windows.Forms.Label OvertimeLabel;
        private System.Windows.Forms.Label OvertimePayLabel;
        private System.Windows.Forms.Label DeductionsDataLabel;
        private System.Windows.Forms.Label OvertimeHoursDataLabel;
        private System.Windows.Forms.Label OvertimePayDataLabel;
        private System.Windows.Forms.Label FinalPayDataLabel;
        private System.Windows.Forms.Label BonusesDataLabel;
        private System.Windows.Forms.Button SubmitButtom;
    }
}