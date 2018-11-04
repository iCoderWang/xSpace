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
            this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SaveAsbyWeight = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SaveAsbyScores = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Matrix = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Sort = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_DecisionMatrix = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DecisionMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File,
            this.ToolStripMenu_Matrix});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 2, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1332, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_File
            // 
            this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_SaveAs,
            this.ToolStripMenuItem_SaveAsbyWeight,
            this.ToolStripMenuItem_SaveAsbyScores,
            this.ToolStripMenuItem_Close});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(77, 38);
            this.ToolStripMenuItem_File.Text = "文件";
            // 
            // ToolStripMenuItem_SaveAs
            // 
            this.ToolStripMenuItem_SaveAs.Name = "ToolStripMenuItem_SaveAs";
            this.ToolStripMenuItem_SaveAs.Size = new System.Drawing.Size(332, 38);
            this.ToolStripMenuItem_SaveAs.Text = "保存";
            // 
            // ToolStripMenuItem_SaveAsbyWeight
            // 
            this.ToolStripMenuItem_SaveAsbyWeight.Name = "ToolStripMenuItem_SaveAsbyWeight";
            this.ToolStripMenuItem_SaveAsbyWeight.Size = new System.Drawing.Size(332, 38);
            this.ToolStripMenuItem_SaveAsbyWeight.Text = "另存为“权重”表格";
            this.ToolStripMenuItem_SaveAsbyWeight.Visible = false;
            // 
            // ToolStripMenuItem_SaveAsbyScores
            // 
            this.ToolStripMenuItem_SaveAsbyScores.Name = "ToolStripMenuItem_SaveAsbyScores";
            this.ToolStripMenuItem_SaveAsbyScores.Size = new System.Drawing.Size(332, 38);
            this.ToolStripMenuItem_SaveAsbyScores.Text = "另存为“总分值”表格";
            this.ToolStripMenuItem_SaveAsbyScores.Visible = false;
            // 
            // ToolStripMenuItem_Close
            // 
            this.ToolStripMenuItem_Close.Name = "ToolStripMenuItem_Close";
            this.ToolStripMenuItem_Close.Size = new System.Drawing.Size(332, 38);
            this.ToolStripMenuItem_Close.Text = "关闭";
            this.ToolStripMenuItem_Close.Click += new System.EventHandler(this.ToolStripMenuItem_Close_Click);
            // 
            // ToolStripMenu_Matrix
            // 
            this.ToolStripMenu_Matrix.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Sort});
            this.ToolStripMenu_Matrix.Name = "ToolStripMenu_Matrix";
            this.ToolStripMenu_Matrix.Size = new System.Drawing.Size(127, 38);
            this.ToolStripMenu_Matrix.Text = "矩阵运算";
            // 
            // ToolStripMenuItem_Sort
            // 
            this.ToolStripMenuItem_Sort.Name = "ToolStripMenuItem_Sort";
            this.ToolStripMenuItem_Sort.Size = new System.Drawing.Size(239, 38);
            this.ToolStripMenuItem_Sort.Text = "TOPSIS排序";
            this.ToolStripMenuItem_Sort.Click += new System.EventHandler(this.ToolStripMenuItem_Sort_Click);
            // 
            // dgv_DecisionMatrix
            // 
            this.dgv_DecisionMatrix.AllowUserToAddRows = false;
            this.dgv_DecisionMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_DecisionMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_DecisionMatrix.BackgroundColor = System.Drawing.SystemColors.Window;
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
            this.dgv_DecisionMatrix.Location = new System.Drawing.Point(0, 42);
            this.dgv_DecisionMatrix.Name = "dgv_DecisionMatrix";
            this.dgv_DecisionMatrix.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_DecisionMatrix.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DecisionMatrix.RowTemplate.Height = 33;
            this.dgv_DecisionMatrix.Size = new System.Drawing.Size(1332, 524);
            this.dgv_DecisionMatrix.TabIndex = 1;
            // 
            // TOPSISDecisionMatrixFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1332, 566);
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
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Matrix;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Sort;
        public System.Windows.Forms.DataGridView dgv_DecisionMatrix;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Close;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SaveAsbyWeight;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SaveAsbyScores;
    }
}