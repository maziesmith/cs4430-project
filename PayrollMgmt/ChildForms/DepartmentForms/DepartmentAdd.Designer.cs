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
            this.label5 = new System.Windows.Forms.Label();
            this.dDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectManager = new System.Windows.Forms.Button();
            this.createDepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dManager
            // 
            this.dManager.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dManager.Location = new System.Drawing.Point(12, 262);
            this.dManager.MaxLength = 256;
            this.dManager.Name = "dManager";
            this.dManager.ReadOnly = true;
            this.dManager.Size = new System.Drawing.Size(158, 22);
            this.dManager.TabIndex = 17;
            this.dManager.TabStop = false;
            this.dManager.TextChanged += new System.EventHandler(this.dManager_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(9, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Department Manager:";
            // 
            // dDescription
            // 
            this.dDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dDescription.Location = new System.Drawing.Point(12, 133);
            this.dDescription.MaxLength = 256;
            this.dDescription.Multiline = true;
            this.dDescription.Name = "dDescription";
            this.dDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dDescription.Size = new System.Drawing.Size(158, 40);
            this.dDescription.TabIndex = 2;
            this.dDescription.TextChanged += new System.EventHandler(this.dDescription_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(9, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Department Description:";
            // 
            // dLocation
            // 
            this.dLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLocation.Location = new System.Drawing.Point(12, 207);
            this.dLocation.MaxLength = 256;
            this.dLocation.Name = "dLocation";
            this.dLocation.Size = new System.Drawing.Size(158, 22);
            this.dLocation.TabIndex = 3;
            this.dLocation.TextChanged += new System.EventHandler(this.dLocation_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(9, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Department Location:";
            // 
            // dName
            // 
            this.dName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dName.Location = new System.Drawing.Point(12, 65);
            this.dName.MaxLength = 50;
            this.dName.Name = "dName";
            this.dName.Size = new System.Drawing.Size(124, 22);
            this.dName.TabIndex = 1;
            this.dName.TextChanged += new System.EventHandler(this.dName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Department Name:";
            // 
            // selectManager
            // 
            this.selectManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.selectManager.Location = new System.Drawing.Point(176, 257);
            this.selectManager.Name = "selectManager";
            this.selectManager.Size = new System.Drawing.Size(115, 33);
            this.selectManager.TabIndex = 4;
            this.selectManager.Text = "Select Manager";
            this.selectManager.UseVisualStyleBackColor = true;
            this.selectManager.Click += new System.EventHandler(this.selectManager_Click);
            // 
            // createDepartment
            // 
            this.createDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDepartment.Location = new System.Drawing.Point(12, 312);
            this.createDepartment.Name = "createDepartment";
            this.createDepartment.Size = new System.Drawing.Size(141, 46);
            this.createDepartment.TabIndex = 20;
            this.createDepartment.Text = "Create Department";
            this.createDepartment.UseVisualStyleBackColor = true;
            this.createDepartment.Click += new System.EventHandler(this.createDepartment_Click);
            // 
            // DepartmentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createDepartment);
            this.Controls.Add(this.selectManager);
            this.Controls.Add(this.dManager);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dName);
            this.Controls.Add(this.label1);
            this.Name = "DepartmentAdd";
            this.Text = "DepartmentAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dManager;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectManager;
        private System.Windows.Forms.Button createDepartment;
    }
}