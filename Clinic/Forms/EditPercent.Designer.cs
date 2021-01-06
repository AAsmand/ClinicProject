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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.PercentTxt = new System.Windows.Forms.TextBox();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Firebrick;
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitBtn.Location = new System.Drawing.Point(66, 62);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ExitBtn.Size = new System.Drawing.Size(51, 34);
            this.ExitBtn.TabIndex = 19;
            this.ExitBtn.Text = "لغو";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
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
            // ConfirmBtn
            // 
            this.ConfirmBtn.BackColor = System.Drawing.Color.Green;
            this.ConfirmBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConfirmBtn.Location = new System.Drawing.Point(13, 63);
            this.ConfirmBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ConfirmBtn.Size = new System.Drawing.Size(51, 34);
            this.ConfirmBtn.TabIndex = 16;
            this.ConfirmBtn.Text = "تایید";
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
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
            // EditPercent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 110);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.PercentTxt);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Yekan", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditPercent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "تغییر درصد مالکیت";
            this.Load += new System.EventHandler(this.EditPercent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox PercentTxt;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Label label1;
    }
}