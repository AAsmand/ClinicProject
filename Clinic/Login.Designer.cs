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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.UserTxt = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Firebrick;
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitBtn.Location = new System.Drawing.Point(125, 115);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ExitBtn.Size = new System.Drawing.Size(103, 50);
            this.ExitBtn.TabIndex = 13;
            this.ExitBtn.Text = "خروج";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // PassTxt
            // 
            this.PassTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PassTxt.Location = new System.Drawing.Point(13, 70);
            this.PassTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.PasswordChar = '*';
            this.PassTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PassTxt.Size = new System.Drawing.Size(342, 33);
            this.PassTxt.TabIndex = 12;
            // 
            // UserTxt
            // 
            this.UserTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UserTxt.Location = new System.Drawing.Point(13, 25);
            this.UserTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserTxt.Size = new System.Drawing.Size(342, 33);
            this.UserTxt.TabIndex = 11;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Green;
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginBtn.Location = new System.Drawing.Point(13, 115);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LoginBtn.Size = new System.Drawing.Size(103, 50);
            this.LoginBtn.TabIndex = 10;
            this.LoginBtn.Text = "ورود";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "رمز عبور :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "نام کاربری :";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 181);
            this.Controls.Add(this.Errorlbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.UserTxt);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Yekan", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ورود کاربر";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Errorlbl;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.TextBox UserTxt;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

