namespace ClinicProject
{
    partial class EditPercent
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
            this.PercentTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.EditPercentBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditPercentBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // PercentTxt
            // 
            this.PercentTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PercentTxt.Location = new System.Drawing.Point(13, 24);
            this.PercentTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PercentTxt.Name = "PercentTxt";
            this.PercentTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PercentTxt.Size = new System.Drawing.Size(104, 27);
            this.PercentTxt.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "درصد مالیکت :";
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
            // EditPercentBtn
            // 
            this.EditPercentBtn.BackgroundImage = global::ClinicProject.Properties.Resources.confirmation;
            this.EditPercentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditPercentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditPercentBtn.Location = new System.Drawing.Point(13, 60);
            this.EditPercentBtn.Name = "EditPercentBtn";
            this.EditPercentBtn.Size = new System.Drawing.Size(47, 43);
            this.EditPercentBtn.TabIndex = 62;
            this.EditPercentBtn.TabStop = false;
            this.EditPercentBtn.Click += new System.EventHandler(this.EditPercentBtn_Click);
            // 
            // EditPercent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(214, 111);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EditPercentBtn);
            this.Controls.Add(this.PercentTxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Yekan", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditPercent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تغییر درصد مالکیت";
            this.Load += new System.EventHandler(this.EditPercent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditPercentBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PercentTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.PictureBox EditPercentBtn;
    }
}