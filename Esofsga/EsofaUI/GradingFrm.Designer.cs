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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("盆地/区域");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.splitCtnerGraFrm.Location = new System.Drawing.Point(1, 1);
            this.splitCtnerGraFrm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.splitCtnerGraFrm.Panel2.Padding = new System.Windows.Forms.Padding(1);
            this.splitCtnerGraFrm.Panel2MinSize = 80;
            this.splitCtnerGraFrm.Size = new System.Drawing.Size(733, 420);
            this.splitCtnerGraFrm.SplitterDistance = 100;
            this.splitCtnerGraFrm.SplitterWidth = 2;
            this.splitCtnerGraFrm.TabIndex = 2;
            // 
            // treeViewGrad
            // 
            this.treeViewGrad.CheckBoxes = true;
            this.treeViewGrad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewGrad.Location = new System.Drawing.Point(0, 0);
            this.treeViewGrad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeViewGrad.Name = "treeViewGrad";
            treeNode2.Name = "para_Bsn";
            treeNode2.Text = "盆地/区域";
            this.treeViewGrad.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeViewGrad.Size = new System.Drawing.Size(98, 418);
            this.treeViewGrad.TabIndex = 0;
            this.treeViewGrad.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewGrad_AfterCheck);
            // 
            // splitContDataZone
            // 
            this.splitContDataZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContDataZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContDataZone.IsSplitterFixed = true;
            this.splitContDataZone.Location = new System.Drawing.Point(1, 1);
            this.splitContDataZone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.splitContDataZone.Size = new System.Drawing.Size(629, 418);
            this.splitContDataZone.SplitterDistance = 361;
            this.splitContDataZone.SplitterWidth = 5;
            this.splitContDataZone.TabIndex = 3;
            // 
            // tabControlGrading
            // 
            this.tabControlGrading.Controls.Add(this.tabPageTarget);
            this.tabControlGrading.Controls.Add(this.tabPageBlock);
            this.tabControlGrading.Controls.Add(this.tabPageBasin);
            this.tabControlGrading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlGrading.Location = new System.Drawing.Point(0, 0);
            this.tabControlGrading.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabControlGrading.Multiline = true;
            this.tabControlGrading.Name = "tabControlGrading";
            this.tabControlGrading.SelectedIndex = 0;
            this.tabControlGrading.Size = new System.Drawing.Size(627, 359);
            this.tabControlGrading.TabIndex = 0;
            // 
            // tabPageTarget
            // 
            this.tabPageTarget.Controls.Add(this.dgvView_Target);
            this.tabPageTarget.Location = new System.Drawing.Point(4, 25);
            this.tabPageTarget.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPageTarget.Name = "tabPageTarget";
            this.tabPageTarget.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPageTarget.Size = new System.Drawing.Size(619, 330);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvView_Target.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvView_Target.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView_Target.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvView_Target.Location = new System.Drawing.Point(1, 1);
            this.dgvView_Target.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgvView_Target.Name = "dgvView_Target";
            this.dgvView_Target.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvView_Target.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvView_Target.Size = new System.Drawing.Size(617, 328);
            this.dgvView_Target.TabIndex = 0;
            // 
            // tabPageBlock
            // 
            this.tabPageBlock.Controls.Add(this.dgvView_Block);
            this.tabPageBlock.Location = new System.Drawing.Point(4, 25);
            this.tabPageBlock.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPageBlock.Name = "tabPageBlock";
            this.tabPageBlock.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPageBlock.Size = new System.Drawing.Size(620, 332);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvView_Block.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvView_Block.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView_Block.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvView_Block.Location = new System.Drawing.Point(1, 1);
            this.dgvView_Block.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgvView_Block.Name = "dgvView_Block";
            this.dgvView_Block.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvView_Block.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvView_Block.Size = new System.Drawing.Size(618, 330);
            this.dgvView_Block.TabIndex = 0;
            // 
            // tabPageBasin
            // 
            this.tabPageBasin.Controls.Add(this.dgvView_Basin);
            this.tabPageBasin.Location = new System.Drawing.Point(4, 25);
            this.tabPageBasin.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPageBasin.Name = "tabPageBasin";
            this.tabPageBasin.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabPageBasin.Size = new System.Drawing.Size(620, 332);
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvView_Basin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvView_Basin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView_Basin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvView_Basin.Location = new System.Drawing.Point(1, 1);
            this.dgvView_Basin.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgvView_Basin.Name = "dgvView_Basin";
            this.dgvView_Basin.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvView_Basin.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvView_Basin.Size = new System.Drawing.Size(618, 330);
            this.dgvView_Basin.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(427, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 5);
            this.groupBox1.Size = new System.Drawing.Size(100, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Location = new System.Drawing.Point(16, 15);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(69, 30);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "下一步";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gBox_Commands
            // 
            this.gBox_Commands.Controls.Add(this.btnCancel);
            this.gBox_Commands.Dock = System.Windows.Forms.DockStyle.Right;
            this.gBox_Commands.Location = new System.Drawing.Point(527, 0);
            this.gBox_Commands.Margin = new System.Windows.Forms.Padding(0);
            this.gBox_Commands.Name = "gBox_Commands";
            this.gBox_Commands.Padding = new System.Windows.Forms.Padding(15, 0, 15, 5);
            this.gBox_Commands.Size = new System.Drawing.Size(100, 50);
            this.gBox_Commands.TabIndex = 0;
            this.gBox_Commands.TabStop = false;
            this.gBox_Commands.Paint += new System.Windows.Forms.PaintEventHandler(this.gBox_Commands_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(15, 15);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GradingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(735, 422);
            this.Controls.Add(this.splitCtnerGraFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(250, 188);
            this.Name = "GradingFrm";
            this.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
            this.gBox_Commands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitCtnerGraFrm;
        private System.Windows.Forms.TreeView treeViewGrad;
        private System.Windows.Forms.SplitContainer splitContDataZone;
        private System.Windows.Forms.TabControl tabControlGrading;
        private System.Windows.Forms.TabPage tabPageTarget;
        public System.Windows.Forms.DataGridView dgvView_Target;
        private System.Windows.Forms.TabPage tabPageBlock;
        public System.Windows.Forms.DataGridView dgvView_Block;
        private System.Windows.Forms.TabPage tabPageBasin;
        public System.Windows.Forms.DataGridView dgvView_Basin;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gBox_Commands;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}