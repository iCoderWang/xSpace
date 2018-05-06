namespace EsofaUI
{
   public partial class RawDataFrm
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
            this.rawDataGridView = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.para_Blk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para_Ps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para_Dr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para_Ea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para_Strom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para_StromAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para_Toc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para_Ro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para_Sc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para_Rr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para_Gc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para_Por = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para_Scd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para_Trf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para_Fdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para_Bmc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para_Psdf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para_Pf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para_Gr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rawDataGridView
            // 
            this.rawDataGridView.AllowUserToAddRows = false;
            this.rawDataGridView.AllowUserToDeleteRows = false;
            this.rawDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.rawDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.rawDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rawDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rawDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rawDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.para_Blk,
            this.para_Ps,
            this.para_Dr,
            this.para_Ea,
            this.para_Strom,
            this.para_StromAt,
            this.para_Toc,
            this.para_Ro,
            this.para_Sc,
            this.para_Rr,
            this.para_Gc,
            this.para_Por,
            this.para_Scd,
            this.para_Trf,
            this.para_Fdd,
            this.para_Bmc,
            this.para_Psdf,
            this.para_Pf,
            this.para_Gr});
            this.rawDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.rawDataGridView.Location = new System.Drawing.Point(0, 0);
            this.rawDataGridView.Name = "rawDataGridView";
            this.rawDataGridView.ReadOnly = true;
            this.rawDataGridView.Size = new System.Drawing.Size(1000, 552);
            this.rawDataGridView.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(754, 558);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(80, 30);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(864, 558);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(80, 30);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // para_Blk
            // 
            this.para_Blk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.para_Blk.DataPropertyName = "para_Blk";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.para_Blk.DefaultCellStyle = dataGridViewCellStyle2;
            this.para_Blk.HeaderText = "区块";
            this.para_Blk.Name = "para_Blk";
            this.para_Blk.ReadOnly = true;
            this.para_Blk.Width = 56;
            // 
            // para_Ps
            // 
            this.para_Ps.DataPropertyName = "para_Ps";
            this.para_Ps.HeaderText = "主力层系";
            this.para_Ps.Name = "para_Ps";
            this.para_Ps.ReadOnly = true;
            this.para_Ps.Width = 80;
            // 
            // para_Dr
            // 
            this.para_Dr.DataPropertyName = "para_Dr";
            this.para_Dr.HeaderText = "埋深范围 (m)";
            this.para_Dr.Name = "para_Dr";
            this.para_Dr.ReadOnly = true;
            this.para_Dr.Width = 97;
            // 
            // para_Ea
            // 
            this.para_Ea.DataPropertyName = "para_Ea";
            this.para_Ea.HeaderText = "有效面积  (km2)";
            this.para_Ea.Name = "para_Ea";
            this.para_Ea.ReadOnly = true;
            this.para_Ea.Width = 112;
            // 
            // para_Strom
            // 
            this.para_Strom.DataPropertyName = "para_Strom";
            this.para_Strom.HeaderText = "富有机质页岩厚度(m)";
            this.para_Strom.Name = "para_Strom";
            this.para_Strom.ReadOnly = true;
            this.para_Strom.Width = 142;
            // 
            // para_StromAt
            // 
            this.para_StromAt.DataPropertyName = "para_StromAt";
            this.para_StromAt.HeaderText = "平均厚度(m)";
            this.para_StromAt.Name = "para_StromAt";
            this.para_StromAt.ReadOnly = true;
            this.para_StromAt.Width = 94;
            // 
            // para_Toc
            // 
            this.para_Toc.DataPropertyName = "para_Toc";
            this.para_Toc.HeaderText = "TOC(%)";
            this.para_Toc.Name = "para_Toc";
            this.para_Toc.ReadOnly = true;
            this.para_Toc.Width = 68;
            // 
            // para_Ro
            // 
            this.para_Ro.DataPropertyName = "para_Ro";
            this.para_Ro.HeaderText = "Ro(%)";
            this.para_Ro.Name = "para_Ro";
            this.para_Ro.ReadOnly = true;
            this.para_Ro.Width = 60;
            // 
            // para_Sc
            // 
            this.para_Sc.DataPropertyName = "para_Sc";
            this.para_Sc.HeaderText = "保存条件";
            this.para_Sc.Name = "para_Sc";
            this.para_Sc.ReadOnly = true;
            this.para_Sc.Width = 80;
            // 
            // para_Rr
            // 
            this.para_Rr.DataPropertyName = "para_Rr";
            this.para_Rr.HeaderText = "资源丰度(108m3/km2)";
            this.para_Rr.Name = "para_Rr";
            this.para_Rr.ReadOnly = true;
            this.para_Rr.Width = 143;
            // 
            // para_Gc
            // 
            this.para_Gc.DataPropertyName = "para_Gc";
            this.para_Gc.HeaderText = "含气量(m3/t)";
            this.para_Gc.Name = "para_Gc";
            this.para_Gc.ReadOnly = true;
            this.para_Gc.Width = 96;
            // 
            // para_Por
            // 
            this.para_Por.DataPropertyName = "para_Por";
            this.para_Por.HeaderText = "孔隙度 (%)";
            this.para_Por.Name = "para_Por";
            this.para_Por.ReadOnly = true;
            this.para_Por.Width = 85;
            // 
            // para_Scd
            // 
            this.para_Scd.DataPropertyName = "para_Scd";
            this.para_Scd.HeaderText = "构造复杂程度";
            this.para_Scd.Name = "para_Scd";
            this.para_Scd.ReadOnly = true;
            this.para_Scd.Width = 104;
            // 
            // para_Trf
            // 
            this.para_Trf.DataPropertyName = "para_Trf";
            this.para_Trf.HeaderText = "顶底板厚度 (m)";
            this.para_Trf.Name = "para_Trf";
            this.para_Trf.ReadOnly = true;
            this.para_Trf.Width = 109;
            // 
            // para_Fdd
            // 
            this.para_Fdd.DataPropertyName = "para_Fdd";
            this.para_Fdd.HeaderText = "裂缝发育程度";
            this.para_Fdd.Name = "para_Fdd";
            this.para_Fdd.ReadOnly = true;
            this.para_Fdd.Width = 104;
            // 
            // para_Bmc
            // 
            this.para_Bmc.DataPropertyName = "para_Bmc";
            this.para_Bmc.HeaderText = "脆性矿物含量";
            this.para_Bmc.Name = "para_Bmc";
            this.para_Bmc.ReadOnly = true;
            this.para_Bmc.Width = 104;
            // 
            // para_Psdf
            // 
            this.para_Psdf.DataPropertyName = "para_Psdf";
            this.para_Psdf.HeaderText = "主应力差异系数";
            this.para_Psdf.Name = "para_Psdf";
            this.para_Psdf.ReadOnly = true;
            this.para_Psdf.Width = 116;
            // 
            // para_Pf
            // 
            this.para_Pf.DataPropertyName = "para_Pf";
            this.para_Pf.HeaderText = "压力系数";
            this.para_Pf.Name = "para_Pf";
            this.para_Pf.ReadOnly = true;
            this.para_Pf.Width = 80;
            // 
            // para_Gr
            // 
            this.para_Gr.DataPropertyName = "para_Gr";
            this.para_Gr.HeaderText = "地质资源量（万亿方）";
            this.para_Gr.Name = "para_Gr";
            this.para_Gr.ReadOnly = true;
            this.para_Gr.Width = 152;
            // 
            // RawDataFrm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.rawDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "RawDataFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "原始数据表";
            ((System.ComponentModel.ISupportInitialize)(this.rawDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView rawDataGridView;
        public System.Windows.Forms.Button btnImport;
        public System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_Blk;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_Ps;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_Dr;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_Ea;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_Strom;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_StromAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_Toc;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_Ro;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_Sc;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_Rr;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_Gc;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_Por;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_Scd;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_Trf;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_Fdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_Bmc;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_Psdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_Pf;
        private System.Windows.Forms.DataGridViewTextBoxColumn para_Gr;
    }
}