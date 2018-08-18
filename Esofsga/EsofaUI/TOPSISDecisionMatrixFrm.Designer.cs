namespace EsofaUI
{
    partial class TOPSISDecisionMatrixFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.矩阵运算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.矩阵规范化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_DecisionMatrix = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DecisionMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.矩阵运算ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1576, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 矩阵运算ToolStripMenuItem
            // 
            this.矩阵运算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.矩阵规范化ToolStripMenuItem});
            this.矩阵运算ToolStripMenuItem.Name = "矩阵运算ToolStripMenuItem";
            this.矩阵运算ToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.矩阵运算ToolStripMenuItem.Text = "矩阵运算";
            // 
            // 矩阵规范化ToolStripMenuItem
            // 
            this.矩阵规范化ToolStripMenuItem.Name = "矩阵规范化ToolStripMenuItem";
            this.矩阵规范化ToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.矩阵规范化ToolStripMenuItem.Text = "矩阵规范化";
            // 
            // dgv_DecisionMatrix
            // 
            this.dgv_DecisionMatrix.AllowUserToAddRows = false;
            this.dgv_DecisionMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_DecisionMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DecisionMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DecisionMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DecisionMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DecisionMatrix.Location = new System.Drawing.Point(0, 40);
            this.dgv_DecisionMatrix.Name = "dgv_DecisionMatrix";
            this.dgv_DecisionMatrix.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_DecisionMatrix.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DecisionMatrix.RowTemplate.Height = 33;
            this.dgv_DecisionMatrix.Size = new System.Drawing.Size(1576, 816);
            this.dgv_DecisionMatrix.TabIndex = 1;
            // 
            // TOPSISDecisionMatrixFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1576, 856);
            this.Controls.Add(this.dgv_DecisionMatrix);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TOPSISDecisionMatrixFrm";
            this.Text = "TOPSI决策矩阵";
            this.Load += new System.EventHandler(this.TOPSISDecisionMatrixFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DecisionMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 矩阵运算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 矩阵规范化ToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgv_DecisionMatrix;
    }
}