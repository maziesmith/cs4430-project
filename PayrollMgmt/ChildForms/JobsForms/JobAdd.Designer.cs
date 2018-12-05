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
            this.label5 = new System.Windows.Forms.Label();
            this.jDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.jPay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createJob
            // 
            this.createJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createJob.Location = new System.Drawing.Point(12, 306);
            this.createJob.Name = "createJob";
            this.createJob.Size = new System.Drawing.Size(141, 46);
            this.createJob.TabIndex = 30;
            this.createJob.Text = "Create Job";
            this.createJob.UseVisualStyleBackColor = true;
            this.createJob.Click += new System.EventHandler(this.createJob_Click);
            // 
            // selectDepartment
            // 
            this.selectDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.selectDepartment.Location = new System.Drawing.Point(176, 251);
            this.selectDepartment.Name = "selectDepartment";
            this.selectDepartment.Size = new System.Drawing.Size(139, 33);
            this.selectDepartment.TabIndex = 24;
            this.selectDepartment.Text = "Select Department";
            this.selectDepartment.UseVisualStyleBackColor = true;
            this.selectDepartment.Click += new System.EventHandler(this.selectDepartment_Click);
            // 
            // jDepartment
            // 
            this.jDepartment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.jDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jDepartment.Location = new System.Drawing.Point(12, 256);
            this.jDepartment.MaxLength = 256;
            this.jDepartment.Name = "jDepartment";
            this.jDepartment.ReadOnly = true;
            this.jDepartment.Size = new System.Drawing.Size(158, 22);
            this.jDepartment.TabIndex = 29;
            this.jDepartment.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(9, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Job Department:";
            // 
            // jDescription
            // 
            this.jDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jDescription.Location = new System.Drawing.Point(12, 127);
            this.jDescription.MaxLength = 256;
            this.jDescription.Multiline = true;
            this.jDescription.Name = "jDescription";
            this.jDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jDescription.Size = new System.Drawing.Size(158, 40);
            this.jDescription.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(9, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Job Description:";
            // 
            // jPay
            // 
            this.jPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jPay.Location = new System.Drawing.Point(12, 201);
            this.jPay.MaxLength = 256;
            this.jPay.Name = "jPay";
            this.jPay.Size = new System.Drawing.Size(158, 22);
            this.jPay.TabIndex = 23;
            this.jPay.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(9, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Job Pay:";
            // 
            // jName
            // 
            this.jName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jName.Location = new System.Drawing.Point(12, 59);
            this.jName.MaxLength = 50;
            this.jName.Name = "jName";
            this.jName.Size = new System.Drawing.Size(124, 22);
            this.jName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Job Name:";
            // 
            // JobAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.createJob);
            this.Controls.Add(this.selectDepartment);
            this.Controls.Add(this.jDepartment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.jDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jName);
            this.Controls.Add(this.label1);
            this.Name = "JobAdd";
            this.Text = "JobAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createJob;
        private System.Windows.Forms.Button selectDepartment;
        private System.Windows.Forms.TextBox jDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox jDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox jPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jName;
        private System.Windows.Forms.Label label1;
    }
}