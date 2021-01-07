namespace ClinicProject
{
    partial class Login
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
            this.Errorlbl = new System.Windows.Forms.Label();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.UserTxt = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.LoginBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Errorlbl
            // 
            this.Errorlbl.AutoSize = true;
            this.Errorlbl.ForeColor = System.Drawing.Color.Firebrick;
            this.Errorlbl.Location = new System.Drawing.Point(-33, 104);
            this.Errorlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Errorlbl.Name = "Errorlbl";
            this.Errorlbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Errorlbl.Size = new System.Drawing.Size(0, 26);
            this.Errorlbl.TabIndex = 14;
            // 
            // PassTxt
            // 
            this.PassTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PassTxt.Location = new System.Drawing.Point(53, 63);
            this.PassTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.PasswordChar = '*';
            this.PassTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PassTxt.Size = new System.Drawing.Size(267, 33);
            this.PassTxt.TabIndex = 12;
            // 
            // UserTxt
            // 
            this.UserTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UserTxt.Location = new System.Drawing.Point(53, 18);
            this.UserTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserTxt.Size = new System.Drawing.Size(267, 33);
            this.UserTxt.TabIndex = 11;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::ClinicProject.Properties.Resources.PinClipart_com_black_power_fist_clipart_1856543;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Location = new System.Drawing.Point(191, 103);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(68, 66);
            this.ExitBtn.TabIndex = 18;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackgroundImage = global::ClinicProject.Properties.Resources.pngkit_login_icon_png_5186830;
            this.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.Location = new System.Drawing.Point(95, 105);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(68, 66);
            this.LoginBtn.TabIndex = 17;
            this.LoginBtn.TabStop = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ClinicProject.Properties.Resources._lock;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 30);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ClinicProject.Properties.Resources.user_1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 33);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(343, 181);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Errorlbl);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.UserTxt);
            this.Font = new System.Drawing.Font("B Yekan", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود کاربر";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Errorlbl;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.TextBox UserTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox LoginBtn;
        private System.Windows.Forms.PictureBox ExitBtn;
    }
}

