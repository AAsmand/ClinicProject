namespace ClinicProject
{
    partial class ManageStaffTypes
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddBtn = new System.Windows.Forms.ToolStripButton();
            this.RemoveBtn = new System.Windows.Forms.ToolStripButton();
            this.StaffTypeGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateSalary = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffTypeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBtn,
            this.RemoveBtn,
            this.UpdateSalary});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(773, 91);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddBtn
            // 
            this.AddBtn.Image = global::ClinicProject.Properties.Resources.health_service;
            this.AddBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(68, 88);
            this.AddBtn.Text = "افزودن";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Image = global::ClinicProject.Properties.Resources.fired_1_;
            this.RemoveBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RemoveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(68, 88);
            this.RemoveBtn.Text = "حذف ";
            this.RemoveBtn.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.RemoveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // StaffTypeGrid
            // 
            this.StaffTypeGrid.AllowUserToAddRows = false;
            this.StaffTypeGrid.AllowUserToDeleteRows = false;
            this.StaffTypeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffTypeGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.StaffTypeGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffTypeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffTypeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Cost});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StaffTypeGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.StaffTypeGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StaffTypeGrid.Location = new System.Drawing.Point(0, 108);
            this.StaffTypeGrid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.StaffTypeGrid.Name = "StaffTypeGrid";
            this.StaffTypeGrid.ReadOnly = true;
            this.StaffTypeGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffTypeGrid.RowTemplate.Height = 24;
            this.StaffTypeGrid.Size = new System.Drawing.Size(773, 442);
            this.StaffTypeGrid.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "شماره نوع";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "نام";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Salary";
            this.Cost.HeaderText = "دستمزد";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // UpdateSalary
            // 
            this.UpdateSalary.Image = global::ClinicProject.Properties.Resources.payment_day;
            this.UpdateSalary.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UpdateSalary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateSalary.Name = "UpdateSalary";
            this.UpdateSalary.Size = new System.Drawing.Size(95, 88);
            this.UpdateSalary.Text = "تغییر دستمزد";
            this.UpdateSalary.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.UpdateSalary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UpdateSalary.Click += new System.EventHandler(this.UpdateSalary_Click);
            // 
            // ManageStaffTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 550);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.StaffTypeGrid);
            this.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
          //  this.Name = "ManageStaffTypes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت خدمات کارکنان";
            this.Load += new System.EventHandler(this.ManageTypeService_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffTypeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddBtn;
        private System.Windows.Forms.ToolStripButton RemoveBtn;
        private System.Windows.Forms.DataGridView StaffTypeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.ToolStripButton UpdateSalary;
    }
}