namespace ClinicProject
{
    partial class StaffPannel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CancelTurnBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddTurnBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeFilterBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.CodeMelliTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FamilyTxt = new System.Windows.Forms.TextBox();
            this.TurnDatePic = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PatientsGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodTypeIdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnsGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CancelTurnBtn,
            this.toolStripSeparator1,
            this.AddTurnBtn,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1275, 91);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CancelTurnBtn
            // 
            this.CancelTurnBtn.Image = global::ClinicProject.Properties.Resources.icons8_plus_64;
            this.CancelTurnBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CancelTurnBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelTurnBtn.Name = "CancelTurnBtn";
            this.CancelTurnBtn.Size = new System.Drawing.Size(99, 88);
            this.CancelTurnBtn.Text = "افزودن پرونده";
            this.CancelTurnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelTurnBtn.Click += new System.EventHandler(this.CancelTurnBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 91);
            // 
            // AddTurnBtn
            // 
            this.AddTurnBtn.Image = global::ClinicProject.Properties.Resources.icons8_plus_64;
            this.AddTurnBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddTurnBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTurnBtn.Name = "AddTurnBtn";
            this.AddTurnBtn.Size = new System.Drawing.Size(73, 88);
            this.AddTurnBtn.Text = "ثبت نوبت";
            this.AddTurnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddTurnBtn.Click += new System.EventHandler(this.AddTurnBtn_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::ClinicProject.Properties.Resources.cercle_close_delete_dismiss_remove_icon_1320196712448219692_64;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(71, 88);
            this.toolStripButton2.Text = "لغو نوبت";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removeFilterBtn);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.CodeMelliTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.FamilyTxt);
            this.groupBox1.Controls.Add(this.TurnDatePic);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NameTxt);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1251, 102);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جعبه فیلتر";
            // 
            // removeFilterBtn
            // 
            this.removeFilterBtn.Location = new System.Drawing.Point(75, 56);
            this.removeFilterBtn.Name = "removeFilterBtn";
            this.removeFilterBtn.Size = new System.Drawing.Size(115, 30);
            this.removeFilterBtn.TabIndex = 14;
            this.removeFilterBtn.Text = "حذف فیلترتاریخ";
            this.removeFilterBtn.UseVisualStyleBackColor = true;
            this.removeFilterBtn.Click += new System.EventHandler(this.removeFilterBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(196, 56);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(115, 30);
            this.SearchBtn.TabIndex = 13;
            this.SearchBtn.Text = "جست و جو";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CodeMelliTxt
            // 
            this.CodeMelliTxt.Location = new System.Drawing.Point(668, 56);
            this.CodeMelliTxt.Name = "CodeMelliTxt";
            this.CodeMelliTxt.Size = new System.Drawing.Size(120, 30);
            this.CodeMelliTxt.TabIndex = 12;
            this.CodeMelliTxt.TextChanged += new System.EventHandler(this.CodeMelliTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(794, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "کدملی :";
            // 
            // FamilyTxt
            // 
            this.FamilyTxt.Location = new System.Drawing.Point(857, 56);
            this.FamilyTxt.Name = "FamilyTxt";
            this.FamilyTxt.Size = new System.Drawing.Size(107, 30);
            this.FamilyTxt.TabIndex = 10;
            this.FamilyTxt.TextChanged += new System.EventHandler(this.FamilyTxt_TextChanged);
            // 
            // TurnDatePic
            // 
            this.TurnDatePic.Location = new System.Drawing.Point(333, 56);
            this.TurnDatePic.Name = "TurnDatePic";
            this.TurnDatePic.Size = new System.Drawing.Size(236, 30);
            this.TurnDatePic.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1194, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "بیمار :";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(1059, 56);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(103, 30);
            this.NameTxt.TabIndex = 2;
            this.NameTxt.TextChanged += new System.EventHandler(this.NameTxt_TextChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(970, 59);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(83, 23);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "نام خانوادگی :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1168, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام بیمار :";
            // 
            // PatientsGrid
            // 
            this.PatientsGrid.AllowUserToAddRows = false;
            this.PatientsGrid.AllowUserToDeleteRows = false;
            this.PatientsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientsGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.PatientsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FoodTypeIdd,
            this.Name,
            this.Price});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientsGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.PatientsGrid.Location = new System.Drawing.Point(739, 214);
            this.PatientsGrid.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.PatientsGrid.Name = "PatientsGrid";
            this.PatientsGrid.ReadOnly = true;
            this.PatientsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PatientsGrid.RowTemplate.Height = 24;
            this.PatientsGrid.Size = new System.Drawing.Size(524, 433);
            this.PatientsGrid.TabIndex = 29;
            this.PatientsGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PatientsGrid_CellMouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "کد بیمار";
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
            // Price
            // 
            this.Price.DataPropertyName = "CodeMelli";
            this.Price.HeaderText = "کدملی";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // TurnsGrid
            // 
            this.TurnsGrid.AllowUserToAddRows = false;
            this.TurnsGrid.AllowUserToDeleteRows = false;
            this.TurnsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TurnsGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.TurnsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TurnsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TurnsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.IsPaid,
            this.TurnPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TurnsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.TurnsGrid.Location = new System.Drawing.Point(12, 214);
            this.TurnsGrid.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TurnsGrid.Name = "TurnsGrid";
            this.TurnsGrid.ReadOnly = true;
            this.TurnsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TurnsGrid.RowTemplate.Height = 24;
            this.TurnsGrid.Size = new System.Drawing.Size(721, 433);
            this.TurnsGrid.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "شماره نوبت";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "تاریخ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DoctorName";
            this.dataGridViewTextBoxColumn3.HeaderText = "پزشک";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn4.HeaderText = "نوع درمان";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // IsPaid
            // 
            this.IsPaid.DataPropertyName = "IsPaid";
            this.IsPaid.HeaderText = "پرداخت شده";
            this.IsPaid.Name = "IsPaid";
            this.IsPaid.ReadOnly = true;
            // 
            // TurnPrice
            // 
            this.TurnPrice.DataPropertyName = "TurnPrice";
            this.TurnPrice.HeaderText = "هزینه";
            this.TurnPrice.Name = "TurnPrice";
            this.TurnPrice.ReadOnly = true;
            // 
            // StaffPannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 647);
            this.Controls.Add(this.TurnsGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PatientsGrid);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
           // this.Name = "StaffPannel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پنل منشی";
            this.Load += new System.EventHandler(this.StaffPannel_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddTurnBtn;
        private System.Windows.Forms.ToolStripButton CancelTurnBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker TurnDatePic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView PatientsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodTypeIdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridView TurnsGrid;
        private System.Windows.Forms.TextBox CodeMelliTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FamilyTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnPrice;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button removeFilterBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}