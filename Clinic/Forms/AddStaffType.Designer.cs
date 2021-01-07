namespace ClinicProject
{
    partial class AddStaffType
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
            this.SalaryTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.AddStaffTypeBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStaffTypeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // SalaryTxt
            // 
            this.SalaryTxt.Location = new System.Drawing.Point(30, 107);
            this.SalaryTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SalaryTxt.Name = "SalaryTxt";
            this.SalaryTxt.Size = new System.Drawing.Size(209, 30);
            this.SalaryTxt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "دستمزد :";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(30, 69);
            this.NameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(209, 30);
            this.NameTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "نام :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(193, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 30);
            this.label4.TabIndex = 32;
            this.label4.Text = "افزودن خدمت";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::ClinicProject.Properties.Resources.cercle_close_delete_dismiss_remove_icon_1320196712448219692_64;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Location = new System.Drawing.Point(109, 144);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(62, 57);
            this.ExitBtn.TabIndex = 61;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // AddStaffTypeBtn
            // 
            this.AddStaffTypeBtn.BackgroundImage = global::ClinicProject.Properties.Resources.confirmation;
            this.AddStaffTypeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddStaffTypeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStaffTypeBtn.Location = new System.Drawing.Point(30, 144);
            this.AddStaffTypeBtn.Name = "AddStaffTypeBtn";
            this.AddStaffTypeBtn.Size = new System.Drawing.Size(62, 57);
            this.AddStaffTypeBtn.TabIndex = 60;
            this.AddStaffTypeBtn.TabStop = false;
            this.AddStaffTypeBtn.Click += new System.EventHandler(this.AddStaffTypeBtn_Click);
            // 
            // AddStaffType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(332, 211);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AddStaffTypeBtn);
            this.Controls.Add(this.SalaryTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTxt);
            this.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddStaffType";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن خدمات";
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStaffTypeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SalaryTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.PictureBox AddStaffTypeBtn;
    }
}