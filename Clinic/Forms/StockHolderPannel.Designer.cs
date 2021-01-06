namespace ClinicProject
{
    partial class StockHolderPannel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StockHolderGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.EditPercentBtn = new System.Windows.Forms.ToolStripButton();
            this.ConfirmBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodTypeIdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StockHolderGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StockHolderGrid
            // 
            this.StockHolderGrid.AllowUserToAddRows = false;
            this.StockHolderGrid.AllowUserToDeleteRows = false;
            this.StockHolderGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockHolderGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.StockHolderGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StockHolderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockHolderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FoodTypeIdd,
            this.Name,
            this.Price,
            this.Percent});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockHolderGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.StockHolderGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StockHolderGrid.Location = new System.Drawing.Point(0, 97);
            this.StockHolderGrid.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.StockHolderGrid.Name = "StockHolderGrid";
            this.StockHolderGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StockHolderGrid.RowTemplate.Height = 24;
            this.StockHolderGrid.Size = new System.Drawing.Size(900, 550);
            this.StockHolderGrid.TabIndex = 31;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditPercentBtn,
            this.ConfirmBtn,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(900, 91);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // EditPercentBtn
            // 
            this.EditPercentBtn.Image = global::ClinicProject.Properties.Resources.icons8_plus_64;
            this.EditPercentBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditPercentBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditPercentBtn.Name = "EditPercentBtn";
            this.EditPercentBtn.Size = new System.Drawing.Size(99, 88);
            this.EditPercentBtn.Text = "ویرایش درصد";
            this.EditPercentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditPercentBtn.ToolTipText = "toolstripe";
            this.EditPercentBtn.Click += new System.EventHandler(this.EditPercentBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Image = global::ClinicProject.Properties.Resources.icons8_plus_64;
            this.ConfirmBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ConfirmBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(88, 88);
            this.ConfirmBtn.Text = "ثبت تغییرات";
            this.ConfirmBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ConfirmBtn.ToolTipText = "toolstripe";
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 91);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "کد سهامدار";
            this.Id.Name = "Id";
            // 
            // FoodTypeIdd
            // 
            this.FoodTypeIdd.DataPropertyName = "Name";
            this.FoodTypeIdd.HeaderText = "نام";
            this.FoodTypeIdd.Name = "FoodTypeIdd";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Family";
            this.Name.HeaderText = "نام خانوادگی";
            this.Name.Name = "Name";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "CodeMelli";
            this.Price.HeaderText = "کدملی";
            this.Price.Name = "Price";
            // 
            // Percent
            // 
            this.Percent.DataPropertyName = "StockPercent";
            this.Percent.HeaderText = "درصد مالکیت";
            this.Percent.Name = "Percent";
            // 
            // StockHolderPannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 647);
            this.Controls.Add(this.StockHolderGrid);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
          //  this.Name = "StockHolderPannel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدیریت سهامداران";
            this.Load += new System.EventHandler(this.StockHolderPannel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockHolderGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StockHolderGrid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ConfirmBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton EditPercentBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodTypeIdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
    }
}