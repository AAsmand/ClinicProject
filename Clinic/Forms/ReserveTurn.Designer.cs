namespace ClinicProject
{
    partial class ReserveTurn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CodeMelliLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TurnTypeCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DoctorsGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodTypeIdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.FirstTime = new System.Windows.Forms.Label();
            this.IsPaidCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WeekDaysCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddTurnBtn = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddTurnBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(816, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "کد ملی :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "نام و نام خانوادگی :";
            // 
            // CodeMelliLbl
            // 
            this.CodeMelliLbl.AutoSize = true;
            this.CodeMelliLbl.Location = new System.Drawing.Point(731, 26);
            this.CodeMelliLbl.Name = "CodeMelliLbl";
            this.CodeMelliLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CodeMelliLbl.Size = new System.Drawing.Size(0, 23);
            this.CodeMelliLbl.TabIndex = 28;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(363, 26);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLbl.Size = new System.Drawing.Size(0, 23);
            this.NameLbl.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameLbl);
            this.groupBox1.Controls.Add(this.CodeMelliLbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 78);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات هویتی";
            // 
            // TurnTypeCombo
            // 
            this.TurnTypeCombo.FormattingEnabled = true;
            this.TurnTypeCombo.Location = new System.Drawing.Point(575, 99);
            this.TurnTypeCombo.Name = "TurnTypeCombo";
            this.TurnTypeCombo.Size = new System.Drawing.Size(230, 31);
            this.TurnTypeCombo.TabIndex = 31;
            this.TurnTypeCombo.SelectedIndexChanged += new System.EventHandler(this.TurnTypeCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(818, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "نوع درمان :";
            // 
            // DoctorsGrid
            // 
            this.DoctorsGrid.AllowUserToAddRows = false;
            this.DoctorsGrid.AllowUserToDeleteRows = false;
            this.DoctorsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DoctorsGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DoctorsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DoctorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FoodTypeIdd,
            this.Name});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoctorsGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.DoctorsGrid.Location = new System.Drawing.Point(12, 99);
            this.DoctorsGrid.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.DoctorsGrid.Name = "DoctorsGrid";
            this.DoctorsGrid.ReadOnly = true;
            this.DoctorsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DoctorsGrid.RowTemplate.Height = 24;
            this.DoctorsGrid.Size = new System.Drawing.Size(557, 217);
            this.DoctorsGrid.TabIndex = 34;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "کد پزشک";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // FoodTypeIdd
            // 
            this.FoodTypeIdd.DataPropertyName = "Name";
            this.FoodTypeIdd.HeaderText = "نام";
            this.FoodTypeIdd.Name = "FoodTypeIdd";
            this.FoodTypeIdd.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Family";
            this.Name.HeaderText = "نام خانوادگی";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 36);
            this.button1.TabIndex = 39;
            this.button1.Text = "یافتن اولین نوبت خالی";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FirstTime
            // 
            this.FirstTime.AutoSize = true;
            this.FirstTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FirstTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstTime.Font = new System.Drawing.Font("B Yekan", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FirstTime.Location = new System.Drawing.Point(598, 248);
            this.FirstTime.Name = "FirstTime";
            this.FirstTime.Size = new System.Drawing.Size(2, 28);
            this.FirstTime.TabIndex = 40;
            // 
            // IsPaidCheck
            // 
            this.IsPaidCheck.AutoSize = true;
            this.IsPaidCheck.Location = new System.Drawing.Point(416, 29);
            this.IsPaidCheck.Name = "IsPaidCheck";
            this.IsPaidCheck.Size = new System.Drawing.Size(105, 27);
            this.IsPaidCheck.TabIndex = 42;
            this.IsPaidCheck.Text = "پرداخت شده";
            this.IsPaidCheck.UseVisualStyleBackColor = true;
            this.IsPaidCheck.CheckedChanged += new System.EventHandler(this.IsPaidCheck_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 43;
            this.label4.Text = "مبلغ قابل پرداخت :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PriceLbl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.IsPaidCheck);
            this.groupBox2.Location = new System.Drawing.Point(357, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 109);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "پرداخت";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(139, 30);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PriceLbl.Size = new System.Drawing.Size(0, 23);
            this.PriceLbl.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(806, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "روز مورد نظر :";
            // 
            // WeekDaysCombo
            // 
            this.WeekDaysCombo.FormattingEnabled = true;
            this.WeekDaysCombo.Location = new System.Drawing.Point(575, 136);
            this.WeekDaysCombo.Name = "WeekDaysCombo";
            this.WeekDaysCombo.Size = new System.Drawing.Size(230, 31);
            this.WeekDaysCombo.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(820, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 49;
            this.label6.Text = "نوبت شما :";
            // 
            // AddTurnBtn
            // 
            this.AddTurnBtn.BackgroundImage = global::ClinicProject.Properties.Resources.confirmation;
            this.AddTurnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddTurnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTurnBtn.Enabled = false;
            this.AddTurnBtn.Location = new System.Drawing.Point(12, 364);
            this.AddTurnBtn.Name = "AddTurnBtn";
            this.AddTurnBtn.Size = new System.Drawing.Size(70, 70);
            this.AddTurnBtn.TabIndex = 50;
            this.AddTurnBtn.TabStop = false;
            this.AddTurnBtn.Click += new System.EventHandler(this.AddTurnBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::ClinicProject.Properties.Resources.cercle_close_delete_dismiss_remove_icon_1320196712448219692_64;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Location = new System.Drawing.Point(103, 364);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(70, 70);
            this.ExitBtn.TabIndex = 51;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ReserveTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AddTurnBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WeekDaysCombo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FirstTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DoctorsGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TurnTypeCombo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            //this.Name = "ReserveTurn";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ثبت نوبت";
            this.Load += new System.EventHandler(this.ReserveTurn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddTurnBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CodeMelliLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TurnTypeCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DoctorsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodTypeIdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label FirstTime;
        private System.Windows.Forms.CheckBox IsPaidCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox WeekDaysCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox AddTurnBtn;
        private System.Windows.Forms.PictureBox ExitBtn;
    }
}