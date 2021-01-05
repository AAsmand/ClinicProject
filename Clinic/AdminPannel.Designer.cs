﻿namespace ClinicProject
{
    partial class AdminPannel
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
            this.ManagePatients = new System.Windows.Forms.ToolStripButton();
            this.TypeManageBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddTurnBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManagePatients,
            this.TypeManageBtn,
            this.toolStripSeparator1,
            this.AddTurnBtn,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1130, 91);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ManagePatients
            // 
            this.ManagePatients.Image = global::ClinicProject.Properties.Resources.icons8_plus_64;
            this.ManagePatients.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManagePatients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ManagePatients.Name = "ManagePatients";
            this.ManagePatients.Size = new System.Drawing.Size(107, 88);
            this.ManagePatients.Text = "مدیریت بیماران";
            this.ManagePatients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ManagePatients.Click += new System.EventHandler(this.ManagePatients_Click);
            // 
            // TypeManageBtn
            // 
            this.TypeManageBtn.Image = global::ClinicProject.Properties.Resources.cercle_close_delete_dismiss_remove_icon_1320196712448219692_64;
            this.TypeManageBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TypeManageBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TypeManageBtn.Name = "TypeManageBtn";
            this.TypeManageBtn.Size = new System.Drawing.Size(109, 88);
            this.TypeManageBtn.Text = "مدیریت خدمات";
            this.TypeManageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TypeManageBtn.Click += new System.EventHandler(this.TypeManageBtn_Click);
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
            this.AddTurnBtn.Size = new System.Drawing.Size(110, 88);
            this.AddTurnBtn.Text = "مدیریت پزشکان";
            this.AddTurnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddTurnBtn.Click += new System.EventHandler(this.AddTurnBtn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::ClinicProject.Properties.Resources.cercle_close_delete_dismiss_remove_icon_1320196712448219692_64;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(109, 88);
            this.toolStripButton1.Text = "مدیریت کارکنان";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::ClinicProject.Properties.Resources.cercle_close_delete_dismiss_remove_icon_1320196712448219692_64;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(130, 88);
            this.toolStripButton3.Text = "مدیریت سهامداران";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::ClinicProject.Properties.Resources.cercle_close_delete_dismiss_remove_icon_1320196712448219692_64;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(96, 88);
            this.toolStripButton4.Text = "مدیریت مالی";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // AdminPannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 562);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("B Yekan", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminPannel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "پنل ادمین";
            this.Load += new System.EventHandler(this.AdminPannel_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ManagePatients;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton AddTurnBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton TypeManageBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}