namespace ClinicProject
{
    partial class ManageStaffs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CodeMelliTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FamilyTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StaffsGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodTypeIdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ManageTypeBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddBtn = new System.Windows.Forms.ToolStripButton();
            this.RemoveBtn = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffsGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.CodeMelliTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.FamilyTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NameTxt);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1178, 109);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جعبه فیلتر";
            // 
            // CodeMelliTxt
            // 
            this.CodeMelliTxt.Location = new System.Drawing.Point(602, 65);
            this.CodeMelliTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CodeMelliTxt.Name = "CodeMelliTxt";
            this.CodeMelliTxt.Size = new System.Drawing.Size(120, 30);
            this.CodeMelliTxt.TabIndex = 3;
            this.CodeMelliTxt.TextChanged += new System.EventHandler(this.CodeMelliTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(728, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "کدملی :";
            // 
            // FamilyTxt
            // 
            this.FamilyTxt.Location = new System.Drawing.Point(791, 65);
            this.FamilyTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FamilyTxt.Name = "FamilyTxt";
            this.FamilyTxt.Size = new System.Drawing.Size(107, 30);
            this.FamilyTxt.TabIndex = 2;
            this.FamilyTxt.TextChanged += new System.EventHandler(this.FamilyTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1110, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "کارمند :";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(993, 65);
            this.NameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(103, 30);
            this.NameTxt.TabIndex = 1;
            this.NameTxt.TextChanged += new System.EventHandler(this.NameTxt_TextChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(904, 69);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(83, 23);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "نام خانوادگی :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1102, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام کارمند :";
            // 
            // StaffsGrid
            // 
            this.StaffsGrid.AllowUserToAddRows = false;
            this.StaffsGrid.AllowUserToDeleteRows = false;
            this.StaffsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffsGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.StaffsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FoodTypeIdd,
            this.Name,
            this.StaffType});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StaffsGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.StaffsGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StaffsGrid.Location = new System.Drawing.Point(0, 221);
            this.StaffsGrid.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.StaffsGrid.Name = "StaffsGrid";
            this.StaffsGrid.ReadOnly = true;
            this.StaffsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffsGrid.RowTemplate.Height = 24;
            this.StaffsGrid.Size = new System.Drawing.Size(1202, 426);
            this.StaffsGrid.TabIndex = 37;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "کد کارمند";
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
            // StaffType
            // 
            this.StaffType.DataPropertyName = "StaffType";
            this.StaffType.HeaderText = "نوع استخدام";
            this.StaffType.Name = "StaffType";
            this.StaffType.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageTypeBtn,
            this.toolStripSeparator1,
            this.AddBtn,
            this.RemoveBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1202, 91);
            this.toolStrip1.TabIndex = 36;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // ManageTypeBtn
            // 
            this.ManageTypeBtn.Image = global::ClinicProject.Properties.Resources.team;
            this.ManageTypeBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManageTypeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ManageTypeBtn.Name = "ManageTypeBtn";
            this.ManageTypeBtn.Size = new System.Drawing.Size(157, 88);
            this.ManageTypeBtn.Text = "مدیریت خدمات کارکنان";
            this.ManageTypeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ManageTypeBtn.Click += new System.EventHandler(this.ManageTypeBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 91);
            // 
            // AddBtn
            // 
            this.AddBtn.Image = global::ClinicProject.Properties.Resources.customer_service;
            this.AddBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(99, 88);
            this.AddBtn.Text = "افزودن کارمند";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Image = global::ClinicProject.Properties.Resources.rejected;
            this.RemoveBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RemoveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(88, 88);
            this.RemoveBtn.Text = "حذف کارمند";
            this.RemoveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // ManageStaffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 647);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StaffsGrid);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
           // this.Name = "ManageStaffs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت کارکنان";
            this.Load += new System.EventHandler(this.ManageStaffs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffsGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CodeMelliTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FamilyTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView StaffsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodTypeIdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffType;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RemoveBtn;
        private System.Windows.Forms.ToolStripButton ManageTypeBtn;
    }
}