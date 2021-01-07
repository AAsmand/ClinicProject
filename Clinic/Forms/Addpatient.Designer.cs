namespace ClinicProject
{
    partial class Addpatient
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
            this.CheckBtn = new System.Windows.Forms.Button();
            this.CodeMelliTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.CodeMelliLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.AddPatientBtn = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPatientBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBtn
            // 
            this.CheckBtn.Location = new System.Drawing.Point(347, 27);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(100, 29);
            this.CheckBtn.TabIndex = 28;
            this.CheckBtn.Text = "بررسی کدملی";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // CodeMelliTxt
            // 
            this.CodeMelliTxt.Location = new System.Drawing.Point(453, 27);
            this.CodeMelliTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CodeMelliTxt.Name = "CodeMelliTxt";
            this.CodeMelliTxt.Size = new System.Drawing.Size(209, 27);
            this.CodeMelliTxt.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "کد ملی :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameLbl);
            this.groupBox1.Controls.Add(this.CodeMelliLbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 78);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات هویتی";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(264, 26);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLbl.Size = new System.Drawing.Size(0, 21);
            this.NameLbl.TabIndex = 29;
            // 
            // CodeMelliLbl
            // 
            this.CodeMelliLbl.AutoSize = true;
            this.CodeMelliLbl.Location = new System.Drawing.Point(594, 26);
            this.CodeMelliLbl.Name = "CodeMelliLbl";
            this.CodeMelliLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CodeMelliLbl.Size = new System.Drawing.Size(0, 21);
            this.CodeMelliLbl.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(686, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "کد ملی :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "نام و نام خانوادگی :";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::ClinicProject.Properties.Resources.cercle_close_delete_dismiss_remove_icon_1320196712448219692_64;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Location = new System.Drawing.Point(103, 145);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(70, 70);
            this.ExitBtn.TabIndex = 57;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // AddPatientBtn
            // 
            this.AddPatientBtn.BackgroundImage = global::ClinicProject.Properties.Resources.confirmation;
            this.AddPatientBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddPatientBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPatientBtn.Location = new System.Drawing.Point(12, 145);
            this.AddPatientBtn.Name = "AddPatientBtn";
            this.AddPatientBtn.Size = new System.Drawing.Size(70, 70);
            this.AddPatientBtn.TabIndex = 56;
            this.AddPatientBtn.TabStop = false;
            this.AddPatientBtn.Click += new System.EventHandler(this.AddPatientBtn_Click);
            // 
            // Addpatient
            // 
            this.ClientSize = new System.Drawing.Size(781, 221);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AddPatientBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.CodeMelliTxt);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("B Yekan", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "Addpatient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن بیمار";
            this.Load += new System.EventHandler(this.Addpatient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPatientBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button CheckBtn;
        protected System.Windows.Forms.TextBox CodeMelliTxt;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label CodeMelliLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.PictureBox AddPatientBtn;
    }
}
