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
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("目标1");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("目标2");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("目标3");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("目标4");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("目标5");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("区块1", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("目标1");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("目标2");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("目标3");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("区块2", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("目标1");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("目标2");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("区块3", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("盆地1", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode37,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("区块1");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("区块2");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("区块3");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("区块4");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("盆地2", new System.Windows.Forms.TreeNode[] {
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45});
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("区块1");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("区块2");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("区块3");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("盆地3", new System.Windows.Forms.TreeNode[] {
            treeNode47,
            treeNode48,
            treeNode49});
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("区块1");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("区块2");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("盆地4", new System.Windows.Forms.TreeNode[] {
            treeNode51,
            treeNode52});
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("盆地", new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode46,
            treeNode50,
            treeNode53});
            this.splitCtnerGraFrm = new System.Windows.Forms.SplitContainer();
            this.treeViewGrad = new System.Windows.Forms.TreeView();
            this.splitContDataZone = new System.Windows.Forms.SplitContainer();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlGrading = new System.Windows.Forms.TabControl();
            this.tabPageBasin = new System.Windows.Forms.TabPage();
            this.tabPageBlock = new System.Windows.Forms.TabPage();
            this.tabPageTarget = new System.Windows.Forms.TabPage();
            this.dgvBasin = new System.Windows.Forms.DataGridView();
            this.dgvBlock = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitCtnerGraFrm)).BeginInit();
            this.splitCtnerGraFrm.Panel1.SuspendLayout();
            this.splitCtnerGraFrm.Panel2.SuspendLayout();
            this.splitCtnerGraFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContDataZone)).BeginInit();
            this.splitContDataZone.Panel1.SuspendLayout();
            this.splitContDataZone.Panel2.SuspendLayout();
            this.splitContDataZone.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlGrading.SuspendLayout();
            this.tabPageBasin.SuspendLayout();
            this.tabPageBlock.SuspendLayout();
            this.tabPageTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            treeNode28.Name = "para_Tgt";
            treeNode28.Text = "目标1";
            treeNode29.Name = "para_Tgt";
            treeNode29.Text = "目标2";
            treeNode30.Name = "para_Tgt";
            treeNode30.Text = "目标3";
            treeNode31.Name = "para_Tgt";
            treeNode31.Text = "目标4";
            treeNode32.Name = "para_Tgt";
            treeNode32.Text = "目标5";
            treeNode33.Name = "para_Blk";
            treeNode33.Text = "区块1";
            treeNode34.Name = "para_Tgt";
            treeNode34.Text = "目标1";
            treeNode35.Name = "para_Tgt";
            treeNode35.Text = "目标2";
            treeNode36.Name = "para_Tgt";
            treeNode36.Text = "目标3";
            treeNode37.Name = "para_Blk";
            treeNode37.Text = "区块2";
            treeNode38.Name = "para_Tgt";
            treeNode38.Text = "目标1";
            treeNode39.Name = "para_Tgt";
            treeNode39.Text = "目标2";
            treeNode40.Name = "para_Blk";
            treeNode40.Text = "区块3";
            treeNode41.Name = "para_Bsn";
            treeNode41.Text = "盆地1";
            treeNode42.Name = "para_Blk";
            treeNode42.Text = "区块1";
            treeNode43.Name = "para_Blk";
            treeNode43.Text = "区块2";
            treeNode44.Name = "para_Blk";
            treeNode44.Text = "区块3";
            treeNode45.Name = "para_Blk";
            treeNode45.Text = "区块4";
            treeNode46.Name = "para_Bsn";
            treeNode46.Text = "盆地2";
            treeNode47.Name = "para_Blk";
            treeNode47.Text = "区块1";
            treeNode48.Name = "para_Blk";
            treeNode48.Text = "区块2";
            treeNode49.Name = "para_Blk";
            treeNode49.Text = "区块3";
            treeNode50.Name = "para_Bsn";
            treeNode50.Text = "盆地3";
            treeNode51.Name = "para_Blk";
            treeNode51.Text = "区块1";
            treeNode52.Name = "para_Blk";
            treeNode52.Text = "区块2";
            treeNode53.Name = "para_Bsn";
            treeNode53.Text = "盆地4";
            treeNode54.Name = "para_Bsn";
            treeNode54.Text = "盆地";
            this.treeViewGrad.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode54});
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
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1012, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            // tabPageTarget
            // 
            this.tabPageTarget.Controls.Add(this.dataGridView1);
            this.tabPageTarget.Location = new System.Drawing.Point(4, 22);
            this.tabPageTarget.Name = "tabPageTarget";
            this.tabPageTarget.Size = new System.Drawing.Size(1151, 553);
            this.tabPageTarget.TabIndex = 2;
            this.tabPageTarget.Text = "目标区";
            this.tabPageTarget.UseVisualStyleBackColor = true;
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
            // dgvBlock
            // 
            this.dgvBlock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBlock.Location = new System.Drawing.Point(3, 3);
            this.dgvBlock.Name = "dgvBlock";
            this.dgvBlock.Size = new System.Drawing.Size(1145, 547);
            this.dgvBlock.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1151, 553);
            this.dataGridView1.TabIndex = 0;
            // 
            // GradingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 642);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1178, 555);
            this.Name = "GradingFrm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "区域分级";
            //this.Load += new System.EventHandler(this.GradingFrm_Load);
            this.splitCtnerGraFrm.Panel1.ResumeLayout(false);
            this.splitCtnerGraFrm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCtnerGraFrm)).EndInit();
            this.splitCtnerGraFrm.ResumeLayout(false);
            this.splitContDataZone.Panel1.ResumeLayout(false);
            this.splitContDataZone.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContDataZone)).EndInit();
            this.splitContDataZone.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControlGrading.ResumeLayout(false);
            this.tabPageBasin.ResumeLayout(false);
            this.tabPageBlock.ResumeLayout(false);
            this.tabPageTarget.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitCtnerGraFrm;
        private System.Windows.Forms.TreeView treeViewGrad;
        private System.Windows.Forms.SplitContainer splitContDataZone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlGrading;
        private System.Windows.Forms.TabPage tabPageBasin;
        private System.Windows.Forms.TabPage tabPageBlock;
        private System.Windows.Forms.TabPage tabPageTarget;
        private System.Windows.Forms.DataGridView dgvBasin;
        private System.Windows.Forms.DataGridView dgvBlock;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}