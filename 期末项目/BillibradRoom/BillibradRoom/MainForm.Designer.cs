namespace BillibradRoom
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.imageListDisk = new System.Windows.Forms.ImageList(this.components);
            this.lvDisks = new System.Windows.Forms.ListView();
            this.panelDisk = new System.Windows.Forms.Panel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panelDisk.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(739, 65);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 62);
            this.toolStripButton1.Text = "商品管理";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 62);
            this.toolStripButton2.Text = "会员管理";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 62);
            this.toolStripButton3.Text = "开台记账";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(60, 62);
            this.toolStripButton4.Text = "关台结账";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // imageListDisk
            // 
            this.imageListDisk.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDisk.ImageStream")));
            this.imageListDisk.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDisk.Images.SetKeyName(0, "1.jpg");
            this.imageListDisk.Images.SetKeyName(1, "2.jpg");
            // 
            // lvDisks
            // 
            this.lvDisks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvDisks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDisks.HideSelection = false;
            this.lvDisks.LargeImageList = this.imageListDisk;
            this.lvDisks.Location = new System.Drawing.Point(0, 0);
            this.lvDisks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvDisks.Name = "lvDisks";
            this.lvDisks.Size = new System.Drawing.Size(735, 454);
            this.lvDisks.TabIndex = 10;
            this.lvDisks.UseCompatibleStateImageBehavior = false;
            this.lvDisks.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.lvDisks_ItemMouseHover);
            this.lvDisks.DoubleClick += new System.EventHandler(this.lvDisks_DoubleClick);
            // 
            // panelDisk
            // 
            this.panelDisk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDisk.Controls.Add(this.lvDisks);
            this.panelDisk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDisk.Location = new System.Drawing.Point(0, 67);
            this.panelDisk.Name = "panelDisk";
            this.panelDisk.Size = new System.Drawing.Size(739, 458);
            this.panelDisk.TabIndex = 0;
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(60, 62);
            this.toolStripButton5.Text = "添加球桌";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 525);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelDisk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = " 台球管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelDisk.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ImageList imageListDisk;
        private System.Windows.Forms.ListView lvDisks;
        private System.Windows.Forms.Panel panelDisk;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}