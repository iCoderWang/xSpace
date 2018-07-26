namespace EsofaUI
{
    partial class DbDataQueryFrm
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
            this.tlStrip_DbQueryFrm = new System.Windows.Forms.ToolStrip();
            this.tlStrip_DbQueryAll = new System.Windows.Forms.ToolStripButton();
            this.tlStrip_DbQueryBy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tlStripBtn_Close = new System.Windows.Forms.ToolStripButton();
            this.tlStripBtn_DbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tlStripBtn_MultiDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tlStripBtn_SingleDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlStripBtn_BlankRowAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlStripBtn_BlankRowDel = new System.Windows.Forms.ToolStripButton();
            this.dgv_DbQuery = new System.Windows.Forms.DataGridView();
            this.tlStrip_ChkBox = new System.Windows.Forms.CheckBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tlStripBtn_DataModify = new System.Windows.Forms.ToolStripButton();
            this.tlStrip_DbQueryFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DbQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // tlStrip_DbQueryFrm
            // 
            this.tlStrip_DbQueryFrm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlStrip_DbQueryFrm.GripMargin = new System.Windows.Forms.Padding(1);
            this.tlStrip_DbQueryFrm.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tlStrip_DbQueryFrm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStrip_DbQueryAll,
            this.toolStripSeparator5,
            this.tlStrip_DbQueryBy,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.tlStripBtn_Close,
            this.tlStripBtn_DbUpdate,
            this.tlStripBtn_MultiDel,
            this.toolStripSeparator4,
            this.tlStripBtn_SingleDel,
            this.toolStripSeparator1,
            this.tlStripBtn_BlankRowAdd,
            this.toolStripSeparator3,
            this.tlStripBtn_BlankRowDel,
            this.tlStripBtn_DataModify});
            this.tlStrip_DbQueryFrm.Location = new System.Drawing.Point(0, 0);
            this.tlStrip_DbQueryFrm.Name = "tlStrip_DbQueryFrm";
            this.tlStrip_DbQueryFrm.Size = new System.Drawing.Size(750, 34);
            this.tlStrip_DbQueryFrm.TabIndex = 0;
            this.tlStrip_DbQueryFrm.Text = "数据查询";
            // 
            // tlStrip_DbQueryAll
            // 
            this.tlStrip_DbQueryAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStrip_DbQueryAll.Image = global::EsofaUI.Properties.Resources.qAll1;
            this.tlStrip_DbQueryAll.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tlStrip_DbQueryAll.Margin = new System.Windows.Forms.Padding(2, 3, 1, 3);
            this.tlStrip_DbQueryAll.Name = "tlStrip_DbQueryAll";
            this.tlStrip_DbQueryAll.Size = new System.Drawing.Size(28, 28);
            this.tlStrip_DbQueryAll.Tag = "";
            this.tlStrip_DbQueryAll.Text = "全部查询";
            this.tlStrip_DbQueryAll.Click += new System.EventHandler(this.tlStrip_DbQueryAll_Click);
            // 
            // tlStrip_DbQueryBy
            // 
            this.tlStrip_DbQueryBy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStrip_DbQueryBy.Image = global::EsofaUI.Properties.Resources.qBy;
            this.tlStrip_DbQueryBy.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tlStrip_DbQueryBy.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.tlStrip_DbQueryBy.Name = "tlStrip_DbQueryBy";
            this.tlStrip_DbQueryBy.Size = new System.Drawing.Size(28, 28);
            this.tlStrip_DbQueryBy.Tag = "";
            this.tlStrip_DbQueryBy.Text = "条件查询";
            this.tlStrip_DbQueryBy.Click += new System.EventHandler(this.tlStrip_DbQueryBy_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 31);
            // 
            // tlStripBtn_Close
            // 
            this.tlStripBtn_Close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tlStripBtn_Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStripBtn_Close.Image = global::EsofaUI.Properties.Resources.Close;
            this.tlStripBtn_Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStripBtn_Close.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.tlStripBtn_Close.Name = "tlStripBtn_Close";
            this.tlStripBtn_Close.Size = new System.Drawing.Size(28, 28);
            this.tlStripBtn_Close.Text = "关闭页面";
            this.tlStripBtn_Close.Click += new System.EventHandler(this.tlStripBtn_Close_Click);
            // 
            // tlStripBtn_DbUpdate
            // 
            this.tlStripBtn_DbUpdate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tlStripBtn_DbUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStripBtn_DbUpdate.Enabled = false;
            this.tlStripBtn_DbUpdate.Image = global::EsofaUI.Properties.Resources.add;
            this.tlStripBtn_DbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStripBtn_DbUpdate.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.tlStripBtn_DbUpdate.Name = "tlStripBtn_DbUpdate";
            this.tlStripBtn_DbUpdate.Size = new System.Drawing.Size(28, 29);
            this.tlStripBtn_DbUpdate.Text = "更新数据库";
            this.tlStripBtn_DbUpdate.Click += new System.EventHandler(this.tlStripBtn_DbUpdate_Click);
            // 
            // tlStripBtn_MultiDel
            // 
            this.tlStripBtn_MultiDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStripBtn_MultiDel.Enabled = false;
            this.tlStripBtn_MultiDel.Image = global::EsofaUI.Properties.Resources.mlDel;
            this.tlStripBtn_MultiDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStripBtn_MultiDel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.tlStripBtn_MultiDel.Name = "tlStripBtn_MultiDel";
            this.tlStripBtn_MultiDel.Size = new System.Drawing.Size(28, 28);
            this.tlStripBtn_MultiDel.Text = "批量删除";
            this.tlStripBtn_MultiDel.Click += new System.EventHandler(this.tlStripBtn_MultiDel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 34);
            // 
            // tlStripBtn_SingleDel
            // 
            this.tlStripBtn_SingleDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStripBtn_SingleDel.Enabled = false;
            this.tlStripBtn_SingleDel.Image = global::EsofaUI.Properties.Resources.del;
            this.tlStripBtn_SingleDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStripBtn_SingleDel.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.tlStripBtn_SingleDel.Name = "tlStripBtn_SingleDel";
            this.tlStripBtn_SingleDel.Size = new System.Drawing.Size(28, 28);
            this.tlStripBtn_SingleDel.Text = "单条删除";
            this.tlStripBtn_SingleDel.Click += new System.EventHandler(this.tlStripBtn_SingleDel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // tlStripBtn_BlankRowAdd
            // 
            this.tlStripBtn_BlankRowAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStripBtn_BlankRowAdd.Enabled = false;
            this.tlStripBtn_BlankRowAdd.Image = global::EsofaUI.Properties.Resources.plus;
            this.tlStripBtn_BlankRowAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStripBtn_BlankRowAdd.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.tlStripBtn_BlankRowAdd.Name = "tlStripBtn_BlankRowAdd";
            this.tlStripBtn_BlankRowAdd.Size = new System.Drawing.Size(28, 28);
            this.tlStripBtn_BlankRowAdd.Text = "添加空行";
            this.tlStripBtn_BlankRowAdd.Click += new System.EventHandler(this.tlStripBtn_BlankRowAdd_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // tlStripBtn_BlankRowDel
            // 
            this.tlStripBtn_BlankRowDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStripBtn_BlankRowDel.Enabled = false;
            this.tlStripBtn_BlankRowDel.Image = global::EsofaUI.Properties.Resources.minus2;
            this.tlStripBtn_BlankRowDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStripBtn_BlankRowDel.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.tlStripBtn_BlankRowDel.Name = "tlStripBtn_BlankRowDel";
            this.tlStripBtn_BlankRowDel.Size = new System.Drawing.Size(28, 28);
            this.tlStripBtn_BlankRowDel.Text = "删除空行";
            this.tlStripBtn_BlankRowDel.Click += new System.EventHandler(this.tlStripBtn_BlankRowDel_Click);
            // 
            // dgv_DbQuery
            // 
            this.dgv_DbQuery.AllowUserToAddRows = false;
            this.dgv_DbQuery.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_DbQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DbQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_DbQuery.Location = new System.Drawing.Point(0, 34);
            this.dgv_DbQuery.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.dgv_DbQuery.Name = "dgv_DbQuery";
            this.dgv_DbQuery.ReadOnly = true;
            this.dgv_DbQuery.Size = new System.Drawing.Size(750, 416);
            this.dgv_DbQuery.TabIndex = 1;
            //this.dgv_DbQuery.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DbQuery_CellValueChanged);
            // 
            // tlStrip_ChkBox
            // 
            this.tlStrip_ChkBox.AutoSize = true;
            this.tlStrip_ChkBox.Enabled = false;
            this.tlStrip_ChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlStrip_ChkBox.Location = new System.Drawing.Point(233, 7);
            this.tlStrip_ChkBox.Name = "tlStrip_ChkBox";
            this.tlStrip_ChkBox.Size = new System.Drawing.Size(74, 19);
            this.tlStrip_ChkBox.TabIndex = 2;
            this.tlStrip_ChkBox.Text = "编辑模式";
            this.tlStrip_ChkBox.UseVisualStyleBackColor = true;
            this.tlStrip_ChkBox.CheckedChanged += new System.EventHandler(this.tlStrip_ChkBox_CheckedChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 34);
            // 
            // tlStripBtn_DataModify
            // 
            this.tlStripBtn_DataModify.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tlStripBtn_DataModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStripBtn_DataModify.Enabled = false;
            this.tlStripBtn_DataModify.Image = global::EsofaUI.Properties.Resources.mod;
            this.tlStripBtn_DataModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStripBtn_DataModify.Name = "tlStripBtn_DataModify";
            this.tlStripBtn_DataModify.Size = new System.Drawing.Size(28, 31);
            this.tlStripBtn_DataModify.Text = "记录插入";
            // 
            // DbDataQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.tlStrip_ChkBox);
            this.Controls.Add(this.dgv_DbQuery);
            this.Controls.Add(this.tlStrip_DbQueryFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DbDataQueryFrm";
            this.Text = "数据库查询";
            this.tlStrip_DbQueryFrm.ResumeLayout(false);
            this.tlStrip_DbQueryFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DbQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlStrip_DbQueryFrm;
        public System.Windows.Forms.DataGridView dgv_DbQuery;
        private System.Windows.Forms.ToolStripButton tlStripBtn_Close;
        public System.Windows.Forms.ToolStripButton tlStripBtn_DbUpdate;
        public System.Windows.Forms.ToolStripButton tlStripBtn_MultiDel;
        public System.Windows.Forms.ToolStripButton tlStripBtn_SingleDel;
        public System.Windows.Forms.ToolStripButton tlStripBtn_BlankRowAdd;
        public System.Windows.Forms.ToolStripButton tlStripBtn_BlankRowDel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.CheckBox tlStrip_ChkBox;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripButton tlStripBtn_DataModify;
        public System.Windows.Forms.ToolStripButton tlStrip_DbQueryAll;
        public System.Windows.Forms.ToolStripButton tlStrip_DbQueryBy;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}