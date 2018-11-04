namespace EsofaUI
{
    partial class ResultSortedByTopsisFrm
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
            this.ToolStripMenuItem_NaturalBreaks = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Classify = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_GenerateReport = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_SortedByTopsis = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SortedByTopsis)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File,
            this.ToolStripMenuItem_NaturalBreaks,
            this.ToolStripMenuItem_Report});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 2, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1304, 42);
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
            this.ToolStripMenuItem_SaveAs.Click += new System.EventHandler(this.ToolStripMenuItem_SaveAs_Click);
            // 
            // ToolStripMenuItem_SaveAsbyWeight
            // 
            this.ToolStripMenuItem_SaveAsbyWeight.Name = "ToolStripMenuItem_SaveAsbyWeight";
            this.ToolStripMenuItem_SaveAsbyWeight.Size = new System.Drawing.Size(332, 38);
            this.ToolStripMenuItem_SaveAsbyWeight.Text = "另存为“权重”表格";
            this.ToolStripMenuItem_SaveAsbyWeight.Visible = false;
            this.ToolStripMenuItem_SaveAsbyWeight.Click += new System.EventHandler(this.ToolStripMenuItem_SaveAsbyWeight_Click);
            // 
            // ToolStripMenuItem_SaveAsbyScores
            // 
            this.ToolStripMenuItem_SaveAsbyScores.Name = "ToolStripMenuItem_SaveAsbyScores";
            this.ToolStripMenuItem_SaveAsbyScores.Size = new System.Drawing.Size(332, 38);
            this.ToolStripMenuItem_SaveAsbyScores.Text = "另存为“总分值”表格";
            this.ToolStripMenuItem_SaveAsbyScores.Visible = false;
            this.ToolStripMenuItem_SaveAsbyScores.Click += new System.EventHandler(this.ToolStripMenuItem_SaveAsbyScores_Click);
            // 
            // ToolStripMenuItem_Close
            // 
            this.ToolStripMenuItem_Close.Name = "ToolStripMenuItem_Close";
            this.ToolStripMenuItem_Close.Size = new System.Drawing.Size(332, 38);
            this.ToolStripMenuItem_Close.Text = "关闭";
            this.ToolStripMenuItem_Close.Click += new System.EventHandler(this.ToolStripMenuItem_Close_Click);
            // 
            // ToolStripMenuItem_NaturalBreaks
            // 
            this.ToolStripMenuItem_NaturalBreaks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Classify});
            this.ToolStripMenuItem_NaturalBreaks.Name = "ToolStripMenuItem_NaturalBreaks";
            this.ToolStripMenuItem_NaturalBreaks.Size = new System.Drawing.Size(152, 38);
            this.ToolStripMenuItem_NaturalBreaks.Text = "自然分类法";
            // 
            // ToolStripMenuItem_Classify
            // 
            this.ToolStripMenuItem_Classify.Name = "ToolStripMenuItem_Classify";
            this.ToolStripMenuItem_Classify.Size = new System.Drawing.Size(164, 38);
            this.ToolStripMenuItem_Classify.Text = "分类";
            this.ToolStripMenuItem_Classify.Click += new System.EventHandler(this.ToolStripMenuItem_Classify_Click);
            // 
            // ToolStripMenuItem_Report
            // 
            this.ToolStripMenuItem_Report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_GenerateReport});
            this.ToolStripMenuItem_Report.Name = "ToolStripMenuItem_Report";
            this.ToolStripMenuItem_Report.Size = new System.Drawing.Size(84, 38);
            this.ToolStripMenuItem_Report.Text = "报告 ";
            // 
            // ToolStripMenuItem_GenerateReport
            // 
            this.ToolStripMenuItem_GenerateReport.Name = "ToolStripMenuItem_GenerateReport";
            this.ToolStripMenuItem_GenerateReport.Size = new System.Drawing.Size(214, 38);
            this.ToolStripMenuItem_GenerateReport.Text = "生成报告";
            this.ToolStripMenuItem_GenerateReport.Click += new System.EventHandler(this.ToolStripMenuItem_GenerateReport_Click);
            // 
            // dgv_SortedByTopsis
            // 
            this.dgv_SortedByTopsis.AllowUserToAddRows = false;
            this.dgv_SortedByTopsis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_SortedByTopsis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_SortedByTopsis.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SortedByTopsis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SortedByTopsis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SortedByTopsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SortedByTopsis.Location = new System.Drawing.Point(0, 42);
            this.dgv_SortedByTopsis.Name = "dgv_SortedByTopsis";
            this.dgv_SortedByTopsis.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_SortedByTopsis.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_SortedByTopsis.RowTemplate.Height = 33;
            this.dgv_SortedByTopsis.Size = new System.Drawing.Size(1304, 558);
            this.dgv_SortedByTopsis.TabIndex = 1;
            // 
            // ResultSortedByTopsisFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 600);
            this.Controls.Add(this.dgv_SortedByTopsis);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ResultSortedByTopsisFrm";
            this.Text = "TOPSIS方法排序结果";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultSortedByTopsisFrm_FormClosing);
            this.Load += new System.EventHandler(this.ResultSortedByTopsisFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SortedByTopsis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Close;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_NaturalBreaks;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Classify;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Report;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_GenerateReport;
        public System.Windows.Forms.DataGridView dgv_SortedByTopsis;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SaveAsbyWeight;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SaveAsbyScores;
    }
}