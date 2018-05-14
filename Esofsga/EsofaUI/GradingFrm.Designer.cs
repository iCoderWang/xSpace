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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("目标1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("目标2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("目标3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("目标4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("目标5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("区块1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("目标1");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("目标2");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("目标3");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("区块2", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("目标1");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("目标2");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("区块3", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("盆地1", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode10,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("区块1");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("区块2");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("区块3");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("区块4");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("盆地2", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("区块1");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("区块2");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("区块3");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("盆地3", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("区块1");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("区块2");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("盆地4", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("盆地", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode19,
            treeNode23,
            treeNode26});
            this.splitCtnerGraFrm = new System.Windows.Forms.SplitContainer();
            this.splitContDataZone = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeViewGrad = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitCtnerGraFrm)).BeginInit();
            this.splitCtnerGraFrm.Panel1.SuspendLayout();
            this.splitCtnerGraFrm.Panel2.SuspendLayout();
            this.splitCtnerGraFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContDataZone)).BeginInit();
            this.splitContDataZone.Panel1.SuspendLayout();
            this.splitContDataZone.Panel2.SuspendLayout();
            this.splitContDataZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.splitCtnerGraFrm.Size = new System.Drawing.Size(1178, 555);
            this.splitCtnerGraFrm.SplitterDistance = 186;
            this.splitCtnerGraFrm.TabIndex = 1;
            // 
            // splitContDataZone
            // 
            this.splitContDataZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContDataZone.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContDataZone.IsSplitterFixed = true;
            this.splitContDataZone.Location = new System.Drawing.Point(2, 2);
            this.splitContDataZone.Name = "splitContDataZone";
            this.splitContDataZone.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContDataZone.Panel1
            // 
            this.splitContDataZone.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContDataZone.Panel2
            // 
            this.splitContDataZone.Panel2.Controls.Add(this.button2);
            this.splitContDataZone.Panel2.Controls.Add(this.button1);
            this.splitContDataZone.Size = new System.Drawing.Size(982, 549);
            this.splitContDataZone.SplitterDistance = 498;
            this.splitContDataZone.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(721, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(835, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(982, 498);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.splitCtnerGraFrm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 555);
            this.panel1.TabIndex = 0;
            // 
            // treeViewGrad
            // 
            this.treeViewGrad.CheckBoxes = true;
            this.treeViewGrad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewGrad.Location = new System.Drawing.Point(0, 0);
            this.treeViewGrad.Name = "treeViewGrad";
            treeNode1.Name = "para_Tgt";
            treeNode1.Text = "目标1";
            treeNode2.Name = "para_Tgt";
            treeNode2.Text = "目标2";
            treeNode3.Name = "para_Tgt";
            treeNode3.Text = "目标3";
            treeNode4.Name = "para_Tgt";
            treeNode4.Text = "目标4";
            treeNode5.Name = "para_Tgt";
            treeNode5.Text = "目标5";
            treeNode6.Name = "para_Blk";
            treeNode6.Text = "区块1";
            treeNode7.Name = "para_Tgt";
            treeNode7.Text = "目标1";
            treeNode8.Name = "para_Tgt";
            treeNode8.Text = "目标2";
            treeNode9.Name = "para_Tgt";
            treeNode9.Text = "目标3";
            treeNode10.Name = "para_Blk";
            treeNode10.Text = "区块2";
            treeNode11.Name = "para_Tgt";
            treeNode11.Text = "目标1";
            treeNode12.Name = "para_Tgt";
            treeNode12.Text = "目标2";
            treeNode13.Name = "para_Blk";
            treeNode13.Text = "区块3";
            treeNode14.Name = "para_Bsn";
            treeNode14.Text = "盆地1";
            treeNode15.Name = "para_Blk";
            treeNode15.Text = "区块1";
            treeNode16.Name = "para_Blk";
            treeNode16.Text = "区块2";
            treeNode17.Name = "para_Blk";
            treeNode17.Text = "区块3";
            treeNode18.Name = "para_Blk";
            treeNode18.Text = "区块4";
            treeNode19.Name = "para_Bsn";
            treeNode19.Text = "盆地2";
            treeNode20.Name = "para_Blk";
            treeNode20.Text = "区块1";
            treeNode21.Name = "para_Blk";
            treeNode21.Text = "区块2";
            treeNode22.Name = "para_Blk";
            treeNode22.Text = "区块3";
            treeNode23.Name = "para_Bsn";
            treeNode23.Text = "盆地3";
            treeNode24.Name = "para_Blk";
            treeNode24.Text = "区块1";
            treeNode25.Name = "para_Blk";
            treeNode25.Text = "区块2";
            treeNode26.Name = "para_Bsn";
            treeNode26.Text = "盆地4";
            treeNode27.Name = "para_Bsn";
            treeNode27.Text = "盆地";
            this.treeViewGrad.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode27});
            this.treeViewGrad.Size = new System.Drawing.Size(184, 553);
            this.treeViewGrad.TabIndex = 0;
            this.treeViewGrad.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewGrad_AfterSelect);
            // 
            // GradingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitCtnerGraFrm;
        private System.Windows.Forms.TreeView treeViewGrad;
        private System.Windows.Forms.SplitContainer splitContDataZone;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}