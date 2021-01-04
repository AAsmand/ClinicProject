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
            this.button2 = new System.Windows.Forms.Button();
            this.IsPaidCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.NameLbl.Location = new System.Drawing.Point(399, 26);
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
            this.DoctorsGrid.Size = new System.Drawing.Size(557, 201);
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
            this.button1.Location = new System.Drawing.Point(653, 136);
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
            this.FirstTime.Location = new System.Drawing.Point(724, 198);
            this.FirstTime.Name = "FirstTime";
            this.FirstTime.Size = new System.Drawing.Size(0, 23);
            this.FirstTime.TabIndex = 40;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(653, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 36);
            this.button2.TabIndex = 41;
            this.button2.Text = "انتخاب زمان";
            this.button2.UseVisualStyleBackColor = true;
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
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddBtn.Location = new System.Drawing.Point(28, 395);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(99, 39);
            this.AddBtn.TabIndex = 46;
            this.AddBtn.Text = "ثبت نوبت";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Firebrick;
            this.CancelBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelBtn.Location = new System.Drawing.Point(131, 395);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(99, 39);
            this.CancelBtn.TabIndex = 45;
            this.CancelBtn.Text = "انصراف";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ReserveTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FirstTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DoctorsGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TurnTypeCombo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         //   this.Name = "ReserveTurn";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ثبت نوبت";
            this.Load += new System.EventHandler(this.ReserveTurn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox IsPaidCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}