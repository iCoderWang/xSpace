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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("远景区");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("有利区");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("核心区");
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitCtnerGraFrm = new System.Windows.Forms.SplitContainer();
            this.splitCtnerBasin = new System.Windows.Forms.SplitContainer();
            this.treeViewBasins = new System.Windows.Forms.TreeView();
            this.splitContBlock = new System.Windows.Forms.SplitContainer();
            this.treeViewBlocks = new System.Windows.Forms.TreeView();
            this.treeViewTargets = new System.Windows.Forms.TreeView();
            this.splitContDataZone = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCtnerGraFrm)).BeginInit();
            this.splitCtnerGraFrm.Panel1.SuspendLayout();
            this.splitCtnerGraFrm.Panel2.SuspendLayout();
            this.splitCtnerGraFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCtnerBasin)).BeginInit();
            this.splitCtnerBasin.Panel1.SuspendLayout();
            this.splitCtnerBasin.Panel2.SuspendLayout();
            this.splitCtnerBasin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContBlock)).BeginInit();
            this.splitContBlock.Panel1.SuspendLayout();
            this.splitContBlock.Panel2.SuspendLayout();
            this.splitContBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContDataZone)).BeginInit();
            this.splitContDataZone.Panel1.SuspendLayout();
            this.splitContDataZone.Panel2.SuspendLayout();
            this.splitContDataZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitCtnerGraFrm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(1178, 555);
            this.panel1.TabIndex = 0;
            // 
            // splitCtnerGraFrm
            // 
            this.splitCtnerGraFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitCtnerGraFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCtnerGraFrm.Location = new System.Drawing.Point(4, 4);
            this.splitCtnerGraFrm.Name = "splitCtnerGraFrm";
            // 
            // splitCtnerGraFrm.Panel1
            // 
            this.splitCtnerGraFrm.Panel1.Controls.Add(this.splitCtnerBasin);
            this.splitCtnerGraFrm.Panel1MinSize = 160;
            // 
            // splitCtnerGraFrm.Panel2
            // 
            this.splitCtnerGraFrm.Panel2.Controls.Add(this.splitContDataZone);
            this.splitCtnerGraFrm.Panel2.Padding = new System.Windows.Forms.Padding(2);
            this.splitCtnerGraFrm.Panel2MinSize = 900;
            this.splitCtnerGraFrm.Size = new System.Drawing.Size(1170, 547);
            this.splitCtnerGraFrm.SplitterDistance = 185;
            this.splitCtnerGraFrm.TabIndex = 1;
            // 
            // splitCtnerBasin
            // 
            this.splitCtnerBasin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCtnerBasin.Location = new System.Drawing.Point(0, 0);
            this.splitCtnerBasin.Name = "splitCtnerBasin";
            this.splitCtnerBasin.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitCtnerBasin.Panel1
            // 
            this.splitCtnerBasin.Panel1.AutoScroll = true;
            this.splitCtnerBasin.Panel1.Controls.Add(this.treeViewBasins);
            // 
            // splitCtnerBasin.Panel2
            // 
            this.splitCtnerBasin.Panel2.Controls.Add(this.splitContBlock);
            this.splitCtnerBasin.Size = new System.Drawing.Size(183, 545);
            this.splitCtnerBasin.SplitterDistance = 209;
            this.splitCtnerBasin.TabIndex = 0;
            // 
            // treeViewBasins
            // 
            this.treeViewBasins.CheckBoxes = true;
            this.treeViewBasins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewBasins.Location = new System.Drawing.Point(0, 0);
            this.treeViewBasins.Name = "treeViewBasins";
            treeNode1.Name = "para_Basins";
            treeNode1.Text = "远景区";
            treeNode1.ToolTipText = "盆地";
            this.treeViewBasins.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeViewBasins.Size = new System.Drawing.Size(183, 209);
            this.treeViewBasins.TabIndex = 0;
            // 
            // splitContBlock
            // 
            this.splitContBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContBlock.Location = new System.Drawing.Point(0, 0);
            this.splitContBlock.Name = "splitContBlock";
            this.splitContBlock.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContBlock.Panel1
            // 
            this.splitContBlock.Panel1.AutoScroll = true;
            this.splitContBlock.Panel1.Controls.Add(this.treeViewBlocks);
            // 
            // splitContBlock.Panel2
            // 
            this.splitContBlock.Panel2.AutoScroll = true;
            this.splitContBlock.Panel2.Controls.Add(this.treeViewTargets);
            this.splitContBlock.Size = new System.Drawing.Size(183, 332);
            this.splitContBlock.SplitterDistance = 152;
            this.splitContBlock.TabIndex = 0;
            // 
            // treeViewBlocks
            // 
            this.treeViewBlocks.CheckBoxes = true;
            this.treeViewBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewBlocks.Location = new System.Drawing.Point(0, 0);
            this.treeViewBlocks.Name = "treeViewBlocks";
            treeNode2.Name = "para_Blocks";
            treeNode2.Text = "有利区";
            treeNode2.ToolTipText = "区块";
            this.treeViewBlocks.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeViewBlocks.Size = new System.Drawing.Size(183, 152);
            this.treeViewBlocks.TabIndex = 0;
            // 
            // treeViewTargets
            // 
            this.treeViewTargets.CheckBoxes = true;
            this.treeViewTargets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewTargets.Location = new System.Drawing.Point(0, 0);
            this.treeViewTargets.Name = "treeViewTargets";
            treeNode3.Name = "para_Targets";
            treeNode3.Text = "核心区";
            treeNode3.ToolTipText = "目标";
            this.treeViewTargets.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeViewTargets.Size = new System.Drawing.Size(183, 176);
            this.treeViewTargets.TabIndex = 0;
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
            this.splitContDataZone.Size = new System.Drawing.Size(975, 541);
            this.splitContDataZone.SplitterDistance = 490;
            this.splitContDataZone.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(975, 490);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(828, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(714, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.panel1.ResumeLayout(false);
            this.splitCtnerGraFrm.Panel1.ResumeLayout(false);
            this.splitCtnerGraFrm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCtnerGraFrm)).EndInit();
            this.splitCtnerGraFrm.ResumeLayout(false);
            this.splitCtnerBasin.Panel1.ResumeLayout(false);
            this.splitCtnerBasin.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCtnerBasin)).EndInit();
            this.splitCtnerBasin.ResumeLayout(false);
            this.splitContBlock.Panel1.ResumeLayout(false);
            this.splitContBlock.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContBlock)).EndInit();
            this.splitContBlock.ResumeLayout(false);
            this.splitContDataZone.Panel1.ResumeLayout(false);
            this.splitContDataZone.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContDataZone)).EndInit();
            this.splitContDataZone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitCtnerGraFrm;
        private System.Windows.Forms.SplitContainer splitCtnerBasin;
        private System.Windows.Forms.TreeView treeViewBasins;
        private System.Windows.Forms.SplitContainer splitContBlock;
        private System.Windows.Forms.TreeView treeViewBlocks;
        private System.Windows.Forms.TreeView treeViewTargets;
        private System.Windows.Forms.SplitContainer splitContDataZone;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}