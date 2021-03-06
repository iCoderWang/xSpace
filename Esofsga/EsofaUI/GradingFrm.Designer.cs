﻿namespace EsofaUI
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("盆地/区域");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitCtnerGraFrm = new System.Windows.Forms.SplitContainer();
            this.treeViewGrad = new System.Windows.Forms.TreeView();
            this.splitContDataZone = new System.Windows.Forms.SplitContainer();
            this.tabControlGrading = new System.Windows.Forms.TabControl();
            this.tabPageTarget = new System.Windows.Forms.TabPage();
            this.dgvView_Target = new System.Windows.Forms.DataGridView();
            this.tabPageBlock = new System.Windows.Forms.TabPage();
            this.dgvView_Block = new System.Windows.Forms.DataGridView();
            this.tabPageBasin = new System.Windows.Forms.TabPage();
            this.dgvView_Basin = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.gBox_Commands = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitCtnerGraFrm)).BeginInit();
            this.splitCtnerGraFrm.Panel1.SuspendLayout();
            this.splitCtnerGraFrm.Panel2.SuspendLayout();
            this.splitCtnerGraFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContDataZone)).BeginInit();
            this.splitContDataZone.Panel1.SuspendLayout();
            this.splitContDataZone.Panel2.SuspendLayout();
            this.splitContDataZone.SuspendLayout();
            this.tabControlGrading.SuspendLayout();
            this.tabPageTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView_Target)).BeginInit();
            this.tabPageBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView_Block)).BeginInit();
            this.tabPageBasin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView_Basin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gBox_Commands.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitCtnerGraFrm
            // 
            this.splitCtnerGraFrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitCtnerGraFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCtnerGraFrm.Location = new System.Drawing.Point(2, 2);
            this.splitCtnerGraFrm.Margin = new System.Windows.Forms.Padding(6);
            this.splitCtnerGraFrm.Name = "splitCtnerGraFrm";
            // 
            // splitCtnerGraFrm.Panel1
            // 
            this.splitCtnerGraFrm.Panel1.Controls.Add(this.treeViewGrad);
            this.splitCtnerGraFrm.Panel1MinSize = 30;
            // 
            // splitCtnerGraFrm.Panel2
            // 
            this.splitCtnerGraFrm.Panel2.Controls.Add(this.splitContDataZone);
            this.splitCtnerGraFrm.Panel2.Padding = new System.Windows.Forms.Padding(2);
            this.splitCtnerGraFrm.Panel2MinSize = 80;
            this.splitCtnerGraFrm.Size = new System.Drawing.Size(1172, 671);
            this.splitCtnerGraFrm.SplitterDistance = 159;
            this.splitCtnerGraFrm.SplitterWidth = 3;
            this.splitCtnerGraFrm.TabIndex = 2;
            // 
            // treeViewGrad
            // 
            this.treeViewGrad.CheckBoxes = true;
            this.treeViewGrad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewGrad.Location = new System.Drawing.Point(0, 0);
            this.treeViewGrad.Margin = new System.Windows.Forms.Padding(6);
            this.treeViewGrad.Name = "treeViewGrad";
            treeNode3.Name = "para_Bsn";
            treeNode3.Text = "盆地/区域";
            this.treeViewGrad.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeViewGrad.Size = new System.Drawing.Size(157, 669);
            this.treeViewGrad.TabIndex = 0;
            this.treeViewGrad.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewGrad_AfterCheck);
            // 
            // splitContDataZone
            // 
            this.splitContDataZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContDataZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContDataZone.IsSplitterFixed = true;
            this.splitContDataZone.Location = new System.Drawing.Point(2, 2);
            this.splitContDataZone.Margin = new System.Windows.Forms.Padding(6);
            this.splitContDataZone.Name = "splitContDataZone";
            this.splitContDataZone.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContDataZone.Panel1
            // 
            this.splitContDataZone.Panel1.Controls.Add(this.tabControlGrading);
            // 
            // splitContDataZone.Panel2
            // 
            this.splitContDataZone.Panel2.Controls.Add(this.groupBox1);
            this.splitContDataZone.Panel2.Controls.Add(this.gBox_Commands);
            this.splitContDataZone.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContDataZone.Size = new System.Drawing.Size(1006, 667);
            this.splitContDataZone.SplitterDistance = 576;
            this.splitContDataZone.TabIndex = 3;
            // 
            // tabControlGrading
            // 
            this.tabControlGrading.Controls.Add(this.tabPageTarget);
            this.tabControlGrading.Controls.Add(this.tabPageBlock);
            this.tabControlGrading.Controls.Add(this.tabPageBasin);
            this.tabControlGrading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlGrading.Location = new System.Drawing.Point(0, 0);
            this.tabControlGrading.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlGrading.Multiline = true;
            this.tabControlGrading.Name = "tabControlGrading";
            this.tabControlGrading.SelectedIndex = 0;
            this.tabControlGrading.Size = new System.Drawing.Size(1004, 574);
            this.tabControlGrading.TabIndex = 0;
            // 
            // tabPageTarget
            // 
            this.tabPageTarget.Controls.Add(this.dgvView_Target);
            this.tabPageTarget.Location = new System.Drawing.Point(8, 39);
            this.tabPageTarget.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageTarget.Name = "tabPageTarget";
            this.tabPageTarget.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageTarget.Size = new System.Drawing.Size(988, 527);
            this.tabPageTarget.TabIndex = 2;
            this.tabPageTarget.Text = "核心区";
            this.tabPageTarget.UseVisualStyleBackColor = true;
            // 
            // dgvView_Target
            // 
            this.dgvView_Target.AllowUserToAddRows = false;
            this.dgvView_Target.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvView_Target.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvView_Target.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvView_Target.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvView_Target.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView_Target.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvView_Target.Location = new System.Drawing.Point(2, 2);
            this.dgvView_Target.Margin = new System.Windows.Forms.Padding(2);
            this.dgvView_Target.Name = "dgvView_Target";
            this.dgvView_Target.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvView_Target.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvView_Target.Size = new System.Drawing.Size(984, 523);
            this.dgvView_Target.TabIndex = 0;
            // 
            // tabPageBlock
            // 
            this.tabPageBlock.Controls.Add(this.dgvView_Block);
            this.tabPageBlock.Location = new System.Drawing.Point(8, 39);
            this.tabPageBlock.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageBlock.Name = "tabPageBlock";
            this.tabPageBlock.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageBlock.Size = new System.Drawing.Size(988, 527);
            this.tabPageBlock.TabIndex = 1;
            this.tabPageBlock.Text = "有利区";
            this.tabPageBlock.UseVisualStyleBackColor = true;
            // 
            // dgvView_Block
            // 
            this.dgvView_Block.AllowUserToAddRows = false;
            this.dgvView_Block.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvView_Block.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvView_Block.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvView_Block.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvView_Block.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView_Block.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvView_Block.Location = new System.Drawing.Point(2, 2);
            this.dgvView_Block.Margin = new System.Windows.Forms.Padding(2);
            this.dgvView_Block.Name = "dgvView_Block";
            this.dgvView_Block.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvView_Block.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvView_Block.Size = new System.Drawing.Size(984, 523);
            this.dgvView_Block.TabIndex = 0;
            // 
            // tabPageBasin
            // 
            this.tabPageBasin.Controls.Add(this.dgvView_Basin);
            this.tabPageBasin.Location = new System.Drawing.Point(8, 39);
            this.tabPageBasin.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageBasin.Name = "tabPageBasin";
            this.tabPageBasin.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageBasin.Size = new System.Drawing.Size(988, 527);
            this.tabPageBasin.TabIndex = 0;
            this.tabPageBasin.Text = "远景区";
            this.tabPageBasin.UseVisualStyleBackColor = true;
            // 
            // dgvView_Basin
            // 
            this.dgvView_Basin.AllowUserToAddRows = false;
            this.dgvView_Basin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvView_Basin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvView_Basin.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvView_Basin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvView_Basin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView_Basin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvView_Basin.Location = new System.Drawing.Point(2, 2);
            this.dgvView_Basin.Margin = new System.Windows.Forms.Padding(2);
            this.dgvView_Basin.Name = "dgvView_Basin";
            this.dgvView_Basin.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvView_Basin.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvView_Basin.Size = new System.Drawing.Size(984, 523);
            this.dgvView_Basin.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(684, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(24, 0, 24, 8);
            this.groupBox1.Size = new System.Drawing.Size(160, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnNext.AutoSize = true;
            this.btnNext.Location = new System.Drawing.Point(26, 24);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(110, 35);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "下一步";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gBox_Commands
            // 
            this.gBox_Commands.Controls.Add(this.btnCancel);
            this.gBox_Commands.Dock = System.Windows.Forms.DockStyle.Right;
            this.gBox_Commands.Location = new System.Drawing.Point(844, 0);
            this.gBox_Commands.Margin = new System.Windows.Forms.Padding(0);
            this.gBox_Commands.Name = "gBox_Commands";
            this.gBox_Commands.Padding = new System.Windows.Forms.Padding(24, 0, 24, 8);
            this.gBox_Commands.Size = new System.Drawing.Size(160, 85);
            this.gBox_Commands.TabIndex = 0;
            this.gBox_Commands.TabStop = false;
            this.gBox_Commands.Paint += new System.Windows.Forms.PaintEventHandler(this.gBox_Commands_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancel.Location = new System.Drawing.Point(22, 24);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GradingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1176, 675);
            this.Controls.Add(this.splitCtnerGraFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(400, 301);
            this.Name = "GradingFrm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "区域分级";
            this.Load += new System.EventHandler(this.GradingFrm_Load);
            this.splitCtnerGraFrm.Panel1.ResumeLayout(false);
            this.splitCtnerGraFrm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCtnerGraFrm)).EndInit();
            this.splitCtnerGraFrm.ResumeLayout(false);
            this.splitContDataZone.Panel1.ResumeLayout(false);
            this.splitContDataZone.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContDataZone)).EndInit();
            this.splitContDataZone.ResumeLayout(false);
            this.tabControlGrading.ResumeLayout(false);
            this.tabPageTarget.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView_Target)).EndInit();
            this.tabPageBlock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView_Block)).EndInit();
            this.tabPageBasin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView_Basin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBox_Commands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitCtnerGraFrm;
        private System.Windows.Forms.TreeView treeViewGrad;
        private System.Windows.Forms.SplitContainer splitContDataZone;
        public System.Windows.Forms.DataGridView dgvView_Target;
        public System.Windows.Forms.DataGridView dgvView_Block;
        public System.Windows.Forms.DataGridView dgvView_Basin;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gBox_Commands;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TabControl tabControlGrading;
        public System.Windows.Forms.TabPage tabPageTarget;
        public System.Windows.Forms.TabPage tabPageBlock;
        public System.Windows.Forms.TabPage tabPageBasin;
    }
}