namespace ClinicProject
{
    partial class ManageFinancial
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PaySalaries = new System.Windows.Forms.ToolStripButton();
            this.AddTurnBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalPriceTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalCostTxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalSalaryTxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalIncomeTxt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.YearNUD = new System.Windows.Forms.NumericUpDown();
            this.monthNUD = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.removeFilterBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PaySalaries,
            this.AddTurnBtn,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(664, 91);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // PaySalaries
            // 
            this.PaySalaries.Image = global::ClinicProject.Properties.Resources.payment_day;
            this.PaySalaries.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PaySalaries.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaySalaries.Name = "PaySalaries";
            this.PaySalaries.Size = new System.Drawing.Size(128, 88);
            this.PaySalaries.Text = "پرداخت دستمزد ها";
            this.PaySalaries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PaySalaries.Click += new System.EventHandler(this.PaySalaries_Click);
            // 
            // AddTurnBtn
            // 
            this.AddTurnBtn.Image = global::ClinicProject.Properties.Resources.stock_market;
            this.AddTurnBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddTurnBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTurnBtn.Name = "AddTurnBtn";
            this.AddTurnBtn.Size = new System.Drawing.Size(139, 88);
            this.AddTurnBtn.Text = "پرداخت سود سالیانه";
            this.AddTurnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddTurnBtn.Click += new System.EventHandler(this.AddTurnBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 91);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "جمع درآمد این ماه :";
            // 
            // TotalPriceTxt
            // 
            this.TotalPriceTxt.AutoSize = true;
            this.TotalPriceTxt.Location = new System.Drawing.Point(315, 38);
            this.TotalPriceTxt.Name = "TotalPriceTxt";
            this.TotalPriceTxt.Size = new System.Drawing.Size(0, 23);
            this.TotalPriceTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "جمع هزینه های این ماه :";
            // 
            // TotalCostTxt
            // 
            this.TotalCostTxt.AutoSize = true;
            this.TotalCostTxt.Location = new System.Drawing.Point(315, 61);
            this.TotalCostTxt.Name = "TotalCostTxt";
            this.TotalCostTxt.Size = new System.Drawing.Size(0, 23);
            this.TotalCostTxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "مجموع دستمزد کارکنان و پزشکان :";
            // 
            // TotalSalaryTxt
            // 
            this.TotalSalaryTxt.AutoSize = true;
            this.TotalSalaryTxt.Location = new System.Drawing.Point(315, 116);
            this.TotalSalaryTxt.Name = "TotalSalaryTxt";
            this.TotalSalaryTxt.Size = new System.Drawing.Size(0, 23);
            this.TotalSalaryTxt.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "سود خالص کلینیک :";
            // 
            // TotalIncomeTxt
            // 
            this.TotalIncomeTxt.AutoSize = true;
            this.TotalIncomeTxt.Location = new System.Drawing.Point(315, 160);
            this.TotalIncomeTxt.Name = "TotalIncomeTxt";
            this.TotalIncomeTxt.Size = new System.Drawing.Size(0, 23);
            this.TotalIncomeTxt.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TotalPriceTxt);
            this.groupBox1.Controls.Add(this.TotalIncomeTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TotalSalaryTxt);
            this.groupBox1.Controls.Add(this.TotalCostTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 205);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارشات مالی";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.YearNUD);
            this.groupBox2.Controls.Add(this.monthNUD);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.removeFilterBtn);
            this.groupBox2.Controls.Add(this.SearchBtn);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(638, 102);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جعبه فیلتر";
            // 
            // YearNUD
            // 
            this.YearNUD.Location = new System.Drawing.Point(350, 56);
            this.YearNUD.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.YearNUD.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.YearNUD.Name = "YearNUD";
            this.YearNUD.Size = new System.Drawing.Size(82, 30);
            this.YearNUD.TabIndex = 18;
            this.YearNUD.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // monthNUD
            // 
            this.monthNUD.Location = new System.Drawing.Point(495, 56);
            this.monthNUD.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthNUD.Name = "monthNUD";
            this.monthNUD.Size = new System.Drawing.Size(70, 30);
            this.monthNUD.TabIndex = 17;
            this.monthNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(438, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "سال :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(571, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "ماه :";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(588, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "تاریخ :";
            // 
            // ManageFinancial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageFinancial";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت مالی";
            this.Load += new System.EventHandler(this.ManageFinancial_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton PaySalaries;
        private System.Windows.Forms.ToolStripButton AddTurnBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalPriceTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalCostTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TotalSalaryTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalIncomeTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown YearNUD;
        private System.Windows.Forms.NumericUpDown monthNUD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button removeFilterBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label10;
    }
}