namespace EsofaUI
{
    partial class GradingFrm
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
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("目标1");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("目标2");
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("目标3");
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("目标4");
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("目标5");
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("区块1", new System.Windows.Forms.TreeNode[] {
            treeNode109,
            treeNode110,
            treeNode111,
            treeNode112,
            treeNode113});
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("目标1");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("目标2");
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("目标3");
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("区块2", new System.Windows.Forms.TreeNode[] {
            treeNode115,
            treeNode116,
            treeNode117});
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("目标1");
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("目标2");
            System.Windows.Forms.TreeNode treeNode121 = new System.Windows.Forms.TreeNode("区块3", new System.Windows.Forms.TreeNode[] {
            treeNode119,
            treeNode120});
            System.Windows.Forms.TreeNode treeNode122 = new System.Windows.Forms.TreeNode("盆地1", new System.Windows.Forms.TreeNode[] {
            treeNode114,
            treeNode118,
            treeNode121});
            System.Windows.Forms.TreeNode treeNode123 = new System.Windows.Forms.TreeNode("区块1");
            System.Windows.Forms.TreeNode treeNode124 = new System.Windows.Forms.TreeNode("区块2");
            System.Windows.Forms.TreeNode treeNode125 = new System.Windows.Forms.TreeNode("区块3");
            System.Windows.Forms.TreeNode treeNode126 = new System.Windows.Forms.TreeNode("区块4");
            System.Windows.Forms.TreeNode treeNode127 = new System.Windows.Forms.TreeNode("盆地2", new System.Windows.Forms.TreeNode[] {
            treeNode123,
            treeNode124,
            treeNode125,
            treeNode126});
            System.Windows.Forms.TreeNode treeNode128 = new System.Windows.Forms.TreeNode("区块1");
            System.Windows.Forms.TreeNode treeNode129 = new System.Windows.Forms.TreeNode("区块2");
            System.Windows.Forms.TreeNode treeNode130 = new System.Windows.Forms.TreeNode("区块3");
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("盆地3", new System.Windows.Forms.TreeNode[] {
            treeNode128,
            treeNode129,
            treeNode130});
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("区块1");
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("区块2");
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("盆地4", new System.Windows.Forms.TreeNode[] {
            treeNode132,
            treeNode133});
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("盆地", new System.Windows.Forms.TreeNode[] {
            treeNode122,
            treeNode127,
            treeNode131,
            treeNode134});
            this.splitCtnerGraFrm = new System.Windows.Forms.SplitContainer();
            this.treeViewGrad = new System.Windows.Forms.TreeView();
            this.splitContDataZone = new System.Windows.Forms.SplitContainer();
            this.tabControlGrading = new System.Windows.Forms.TabControl();
            this.tabPageBasin = new System.Windows.Forms.TabPage();
            this.dgvBasin = new System.Windows.Forms.DataGridView();
            this.tabPageBlock = new System.Windows.Forms.TabPage();
            this.dgvBlock = new System.Windows.Forms.DataGridView();
            this.tabPageTarget = new System.Windows.Forms.TabPage();
            this.dgvTarget = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitCtnerGraFrm)).BeginInit();
            this.splitCtnerGraFrm.Panel1.SuspendLayout();
            this.splitCtnerGraFrm.Panel2.SuspendLayout();
            this.splitCtnerGraFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContDataZone)).BeginInit();
            this.splitContDataZone.Panel1.SuspendLayout();
            this.splitContDataZone.Panel2.SuspendLayout();
            this.splitContDataZone.SuspendLayout();
            this.tabControlGrading.SuspendLayout();
            this.tabPageBasin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasin)).BeginInit();
            this.tabPageBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlock)).BeginInit();
            this.tabPageTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarget)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitCtnerGraFrm
            // 
            this.splitCtnerGraFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitCtnerGraFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCtnerGraFrm.Location = new System.Drawing.Point(0, 0);
            this.splitCtnerGraFrm.Name = "splitCtnerGraFrm";
            // 
            // splitCtnerGraFrm.Panel1
            // 
            this.splitCtnerGraFrm.Panel1.Controls.Add(this.treeViewGrad);
            this.splitCtnerGraFrm.Panel1MinSize = 160;
            // 
            // splitCtnerGraFrm.Panel2
            // 
            this.splitCtnerGraFrm.Panel2.Controls.Add(this.splitContDataZone);
            this.splitCtnerGraFrm.Panel2.Padding = new System.Windows.Forms.Padding(2);
            this.splitCtnerGraFrm.Panel2MinSize = 900;
            this.splitCtnerGraFrm.Size = new System.Drawing.Size(1388, 636);
            this.splitCtnerGraFrm.SplitterDistance = 219;
            this.splitCtnerGraFrm.TabIndex = 1;
            // 
            // treeViewGrad
            // 
            this.treeViewGrad.CheckBoxes = true;
            this.treeViewGrad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewGrad.Location = new System.Drawing.Point(0, 0);
            this.treeViewGrad.Name = "treeViewGrad";
            treeNode109.Name = "para_Tgt";
            treeNode109.Text = "目标1";
            treeNode110.Name = "para_Tgt";
            treeNode110.Text = "目标2";
            treeNode111.Name = "para_Tgt";
            treeNode111.Text = "目标3";
            treeNode112.Name = "para_Tgt";
            treeNode112.Text = "目标4";
            treeNode113.Name = "para_Tgt";
            treeNode113.Text = "目标5";
            treeNode114.Name = "para_Blk";
            treeNode114.Text = "区块1";
            treeNode115.Name = "para_Tgt";
            treeNode115.Text = "目标1";
            treeNode116.Name = "para_Tgt";
            treeNode116.Text = "目标2";
            treeNode117.Name = "para_Tgt";
            treeNode117.Text = "目标3";
            treeNode118.Name = "para_Blk";
            treeNode118.Text = "区块2";
            treeNode119.Name = "para_Tgt";
            treeNode119.Text = "目标1";
            treeNode120.Name = "para_Tgt";
            treeNode120.Text = "目标2";
            treeNode121.Name = "para_Blk";
            treeNode121.Text = "区块3";
            treeNode122.Name = "para_Bsn";
            treeNode122.Text = "盆地1";
            treeNode123.Name = "para_Blk";
            treeNode123.Text = "区块1";
            treeNode124.Name = "para_Blk";
            treeNode124.Text = "区块2";
            treeNode125.Name = "para_Blk";
            treeNode125.Text = "区块3";
            treeNode126.Name = "para_Blk";
            treeNode126.Text = "区块4";
            treeNode127.Name = "para_Bsn";
            treeNode127.Text = "盆地2";
            treeNode128.Name = "para_Blk";
            treeNode128.Text = "区块1";
            treeNode129.Name = "para_Blk";
            treeNode129.Text = "区块2";
            treeNode130.Name = "para_Blk";
            treeNode130.Text = "区块3";
            treeNode131.Name = "para_Bsn";
            treeNode131.Text = "盆地3";
            treeNode132.Name = "para_Blk";
            treeNode132.Text = "区块1";
            treeNode133.Name = "para_Blk";
            treeNode133.Text = "区块2";
            treeNode134.Name = "para_Bsn";
            treeNode134.Text = "盆地4";
            treeNode135.Name = "para_Bsn";
            treeNode135.Text = "盆地";
            this.treeViewGrad.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode135});
            this.treeViewGrad.Size = new System.Drawing.Size(217, 634);
            this.treeViewGrad.TabIndex = 0;
            // 
            // splitContDataZone
            // 
            this.splitContDataZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContDataZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContDataZone.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContDataZone.IsSplitterFixed = true;
            this.splitContDataZone.Location = new System.Drawing.Point(2, 2);
            this.splitContDataZone.Name = "splitContDataZone";
            this.splitContDataZone.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContDataZone.Panel1
            // 
            this.splitContDataZone.Panel1.Controls.Add(this.tabControlGrading);
            // 
            // splitContDataZone.Panel2
            // 
            this.splitContDataZone.Panel2.Controls.Add(this.btnCancel);
            this.splitContDataZone.Panel2.Controls.Add(this.btnNext);
            this.splitContDataZone.Size = new System.Drawing.Size(1161, 632);
            this.splitContDataZone.SplitterDistance = 581;
            this.splitContDataZone.TabIndex = 3;
            // 
            // tabControlGrading
            // 
            this.tabControlGrading.Controls.Add(this.tabPageBasin);
            this.tabControlGrading.Controls.Add(this.tabPageBlock);
            this.tabControlGrading.Controls.Add(this.tabPageTarget);
            this.tabControlGrading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlGrading.Location = new System.Drawing.Point(0, 0);
            this.tabControlGrading.Multiline = true;
            this.tabControlGrading.Name = "tabControlGrading";
            this.tabControlGrading.SelectedIndex = 0;
            this.tabControlGrading.Size = new System.Drawing.Size(1159, 579);
            this.tabControlGrading.TabIndex = 0;
            // 
            // tabPageBasin
            // 
            this.tabPageBasin.Controls.Add(this.dgvBasin);
            this.tabPageBasin.Location = new System.Drawing.Point(4, 22);
            this.tabPageBasin.Name = "tabPageBasin";
            this.tabPageBasin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBasin.Size = new System.Drawing.Size(1151, 553);
            this.tabPageBasin.TabIndex = 0;
            this.tabPageBasin.Text = "远景区";
            this.tabPageBasin.UseVisualStyleBackColor = true;
            // 
            // dgvBasin
            // 
            this.dgvBasin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBasin.Location = new System.Drawing.Point(3, 3);
            this.dgvBasin.Name = "dgvBasin";
            this.dgvBasin.Size = new System.Drawing.Size(1145, 547);
            this.dgvBasin.TabIndex = 0;
            // 
            // tabPageBlock
            // 
            this.tabPageBlock.Controls.Add(this.dgvBlock);
            this.tabPageBlock.Location = new System.Drawing.Point(4, 22);
            this.tabPageBlock.Name = "tabPageBlock";
            this.tabPageBlock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBlock.Size = new System.Drawing.Size(1151, 553);
            this.tabPageBlock.TabIndex = 1;
            this.tabPageBlock.Text = "有利区";
            this.tabPageBlock.UseVisualStyleBackColor = true;
            // 
            // dgvBlock
            // 
            this.dgvBlock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBlock.Location = new System.Drawing.Point(3, 3);
            this.dgvBlock.Name = "dgvBlock";
            this.dgvBlock.Size = new System.Drawing.Size(1145, 547);
            this.dgvBlock.TabIndex = 0;
            // 
            // tabPageTarget
            // 
            this.tabPageTarget.Controls.Add(this.dgvTarget);
            this.tabPageTarget.Location = new System.Drawing.Point(4, 22);
            this.tabPageTarget.Name = "tabPageTarget";
            this.tabPageTarget.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTarget.Size = new System.Drawing.Size(1151, 553);
            this.tabPageTarget.TabIndex = 2;
            this.tabPageTarget.Text = "核心区";
            this.tabPageTarget.UseVisualStyleBackColor = true;
            // 
            // dgvTarget
            // 
            this.dgvTarget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTarget.Location = new System.Drawing.Point(3, 3);
            this.dgvTarget.Name = "dgvTarget";
            this.dgvTarget.Size = new System.Drawing.Size(1145, 547);
            this.dgvTarget.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1012, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(898, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 30);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "下一步";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.splitCtnerGraFrm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1388, 636);
            this.panel1.TabIndex = 0;
            // 
            // GradingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 642);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1178, 555);
            this.Name = "GradingFrm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "区域分级";
            this.splitCtnerGraFrm.Panel1.ResumeLayout(false);
            this.splitCtnerGraFrm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCtnerGraFrm)).EndInit();
            this.splitCtnerGraFrm.ResumeLayout(false);
            this.splitContDataZone.Panel1.ResumeLayout(false);
            this.splitContDataZone.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContDataZone)).EndInit();
            this.splitContDataZone.ResumeLayout(false);
            this.tabControlGrading.ResumeLayout(false);
            this.tabPageBasin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasin)).EndInit();
            this.tabPageBlock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlock)).EndInit();
            this.tabPageTarget.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarget)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitCtnerGraFrm;
        private System.Windows.Forms.TreeView treeViewGrad;
        private System.Windows.Forms.SplitContainer splitContDataZone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPageBasin;
        private System.Windows.Forms.TabPage tabPageBlock;
        private System.Windows.Forms.TabPage tabPageTarget;
        public System.Windows.Forms.DataGridView dgvBasin;
        private System.Windows.Forms.TabControl tabControlGrading;
        public System.Windows.Forms.DataGridView dgvBlock;
        public System.Windows.Forms.DataGridView dgvTarget;
    }
}