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
            this.tlStripBtn_Edit = new System.Windows.Forms.ToolStripButton();
            this.tlStripBtn_Close = new System.Windows.Forms.ToolStripButton();
            this.tlStripBtn_DbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tlStripBtn_MultiDel = new System.Windows.Forms.ToolStripButton();
            this.tlStripBtn_SingleDel = new System.Windows.Forms.ToolStripButton();
            this.tlStripBtn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.tlStripBtn_BlankRowAdd = new System.Windows.Forms.ToolStripButton();
            this.tlStripBtn_BlankRowDel = new System.Windows.Forms.ToolStripButton();
            this.dgv_DbQuery = new System.Windows.Forms.DataGridView();
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
            this.tlStrip_DbQueryBy,
            this.tlStripBtn_Edit,
            this.tlStripBtn_Close,
            this.tlStripBtn_DbUpdate,
            this.tlStripBtn_MultiDel,
            this.tlStripBtn_SingleDel,
            this.tlStripBtn_Refresh,
            this.tlStripBtn_BlankRowAdd,
            this.tlStripBtn_BlankRowDel});
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
            // tlStripBtn_Edit
            // 
            this.tlStripBtn_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStripBtn_Edit.Enabled = false;
            this.tlStripBtn_Edit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tlStripBtn_Edit.Image = global::EsofaUI.Properties.Resources.mod1;
            this.tlStripBtn_Edit.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tlStripBtn_Edit.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.tlStripBtn_Edit.Name = "tlStripBtn_Edit";
            this.tlStripBtn_Edit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlStripBtn_Edit.Size = new System.Drawing.Size(28, 28);
            this.tlStripBtn_Edit.Tag = "";
            this.tlStripBtn_Edit.Text = "编辑模式";
            this.tlStripBtn_Edit.Visible = false;
            this.tlStripBtn_Edit.Click += new System.EventHandler(this.tlStripBtn_Edit_Click);
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
            this.tlStripBtn_DbUpdate.Visible = false;
            // 
            // tlStripBtn_MultiDel
            // 
            this.tlStripBtn_MultiDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStripBtn_MultiDel.Enabled = false;
            this.tlStripBtn_MultiDel.Image = global::EsofaUI.Properties.Resources.mlDel;
            this.tlStripBtn_MultiDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStripBtn_MultiDel.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.tlStripBtn_MultiDel.Name = "tlStripBtn_MultiDel";
            this.tlStripBtn_MultiDel.Size = new System.Drawing.Size(28, 28);
            this.tlStripBtn_MultiDel.Text = "批量删除";
            this.tlStripBtn_MultiDel.Visible = false;
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
            this.tlStripBtn_SingleDel.Visible = false;
            // 
            // tlStripBtn_Refresh
            // 
            this.tlStripBtn_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStripBtn_Refresh.Enabled = false;
            this.tlStripBtn_Refresh.Image = global::EsofaUI.Properties.Resources._ref;
            this.tlStripBtn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStripBtn_Refresh.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.tlStripBtn_Refresh.Name = "tlStripBtn_Refresh";
            this.tlStripBtn_Refresh.Size = new System.Drawing.Size(28, 28);
            this.tlStripBtn_Refresh.Text = "数据刷新";
            this.tlStripBtn_Refresh.Visible = false;
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
            this.tlStripBtn_BlankRowAdd.Visible = false;
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
            this.tlStripBtn_BlankRowDel.Visible = false;
            // 
            // dgv_DbQuery
            // 
            this.dgv_DbQuery.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_DbQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DbQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_DbQuery.Location = new System.Drawing.Point(0, 34);
            this.dgv_DbQuery.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.dgv_DbQuery.Name = "dgv_DbQuery";
            this.dgv_DbQuery.ReadOnly = true;
            this.dgv_DbQuery.Size = new System.Drawing.Size(750, 416);
            this.dgv_DbQuery.TabIndex = 1;
            // 
            // DbDataQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
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
        private System.Windows.Forms.ToolStripButton tlStrip_DbQueryAll;
        private System.Windows.Forms.ToolStripButton tlStrip_DbQueryBy;
        public System.Windows.Forms.DataGridView dgv_DbQuery;
        public System.Windows.Forms.ToolStripButton tlStripBtn_Edit;
        private System.Windows.Forms.ToolStripButton tlStripBtn_Close;
        public System.Windows.Forms.ToolStripButton tlStripBtn_DbUpdate;
        public System.Windows.Forms.ToolStripButton tlStripBtn_MultiDel;
        public System.Windows.Forms.ToolStripButton tlStripBtn_SingleDel;
        public System.Windows.Forms.ToolStripButton tlStripBtn_Refresh;
        public System.Windows.Forms.ToolStripButton tlStripBtn_BlankRowAdd;
        public System.Windows.Forms.ToolStripButton tlStripBtn_BlankRowDel;
    }
}