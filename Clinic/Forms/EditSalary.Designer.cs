namespace ClinicProject
{
    partial class EditSalary
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
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.EditSalaryBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditSalaryBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // SalaryTxt
            // 
            this.SalaryTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SalaryTxt.Location = new System.Drawing.Point(13, 24);
            this.SalaryTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SalaryTxt.Name = "SalaryTxt";
            this.SalaryTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SalaryTxt.Size = new System.Drawing.Size(104, 27);
            this.SalaryTxt.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "حقوق :";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::ClinicProject.Properties.Resources.cercle_close_delete_dismiss_remove_icon_1320196712448219692_64;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Location = new System.Drawing.Point(70, 60);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(47, 43);
            this.ExitBtn.TabIndex = 63;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // EditSalaryBtn
            // 
            this.EditSalaryBtn.BackgroundImage = global::ClinicProject.Properties.Resources.confirmation;
            this.EditSalaryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditSalaryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditSalaryBtn.Location = new System.Drawing.Point(13, 60);
            this.EditSalaryBtn.Name = "EditSalaryBtn";
            this.EditSalaryBtn.Size = new System.Drawing.Size(47, 43);
            this.EditSalaryBtn.TabIndex = 62;
            this.EditSalaryBtn.TabStop = false;
            this.EditSalaryBtn.Click += new System.EventHandler(this.EditSalaryBtn_Click);
            // 
            // EditSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 111);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EditSalaryBtn);
            this.Controls.Add(this.SalaryTxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Yekan", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditSalary";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تغییر درصد مالکیت";
            this.Load += new System.EventHandler(this.EditPercent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditSalaryBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SalaryTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.PictureBox EditSalaryBtn;
    }
}