namespace EsofaUI
{
    partial class TargetAreaParameters
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
            this.gBoxTargetArea = new System.Windows.Forms.GroupBox();
            this.rBtnProspective = new System.Windows.Forms.RadioButton();
            this.rBtnFavorable = new System.Windows.Forms.RadioButton();
            this.rBtnCore = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.geoParasLbl = new System.Windows.Forms.Label();
            this.ecoParasLbl = new System.Windows.Forms.Label();
            this.listBox_GeoPara = new System.Windows.Forms.ListBox();
            this.listBox_EcoPara = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.engParasLbl = new System.Windows.Forms.Label();
            this.listBox_EngPara = new System.Windows.Forms.ListBox();
            this.listBox_Diff_EngiPara = new System.Windows.Forms.ListBox();
            this.listBox_Diff_GeoPara = new System.Windows.Forms.ListBox();
            this.listBox_Diff_EcoPara = new System.Windows.Forms.ListBox();
            this.gBoxParameters = new System.Windows.Forms.GroupBox();
            this.gBoxTargetArea.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBoxParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxTargetArea
            // 
            this.gBoxTargetArea.Controls.Add(this.rBtnProspective);
            this.gBoxTargetArea.Controls.Add(this.rBtnFavorable);
            this.gBoxTargetArea.Controls.Add(this.rBtnCore);
            this.gBoxTargetArea.Location = new System.Drawing.Point(13, 11);
            this.gBoxTargetArea.Name = "gBoxTargetArea";
            this.gBoxTargetArea.Size = new System.Drawing.Size(604, 48);
            this.gBoxTargetArea.TabIndex = 0;
            this.gBoxTargetArea.TabStop = false;
            this.gBoxTargetArea.Text = "目标区";
            // 
            // rBtnProspective
            // 
            this.rBtnProspective.AutoSize = true;
            this.rBtnProspective.Location = new System.Drawing.Point(514, 20);
            this.rBtnProspective.Name = "rBtnProspective";
            this.rBtnProspective.Size = new System.Drawing.Size(61, 17);
            this.rBtnProspective.TabIndex = 2;
            this.rBtnProspective.TabStop = true;
            this.rBtnProspective.Text = "远景区";
            this.rBtnProspective.UseVisualStyleBackColor = true;
            this.rBtnProspective.CheckedChanged += new System.EventHandler(this.rBtnProspective_CheckedChanged);
            // 
            // rBtnFavorable
            // 
            this.rBtnFavorable.AutoSize = true;
            this.rBtnFavorable.Location = new System.Drawing.Point(291, 20);
            this.rBtnFavorable.Name = "rBtnFavorable";
            this.rBtnFavorable.Size = new System.Drawing.Size(61, 17);
            this.rBtnFavorable.TabIndex = 1;
            this.rBtnFavorable.TabStop = true;
            this.rBtnFavorable.Text = "有利区";
            this.rBtnFavorable.UseVisualStyleBackColor = true;
            this.rBtnFavorable.CheckedChanged += new System.EventHandler(this.rBtnFavorable_CheckedChanged);
            // 
            // rBtnCore
            // 
            this.rBtnCore.AutoSize = true;
            this.rBtnCore.Location = new System.Drawing.Point(80, 20);
            this.rBtnCore.Name = "rBtnCore";
            this.rBtnCore.Size = new System.Drawing.Size(61, 17);
            this.rBtnCore.TabIndex = 0;
            this.rBtnCore.TabStop = true;
            this.rBtnCore.Text = "核心区";
            this.rBtnCore.UseVisualStyleBackColor = true;
            this.rBtnCore.CheckedChanged += new System.EventHandler(this.rBtnCore_CheckedChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(635, 458);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(73, 30);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "下一步";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // geoParasLbl
            // 
            this.geoParasLbl.AutoSize = true;
            this.geoParasLbl.Location = new System.Drawing.Point(9, 83);
            this.geoParasLbl.Name = "geoParasLbl";
            this.geoParasLbl.Size = new System.Drawing.Size(19, 52);
            this.geoParasLbl.TabIndex = 0;
            this.geoParasLbl.Text = "地\r\n质\r\n条\r\n件\r\n";
            this.geoParasLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ecoParasLbl
            // 
            this.ecoParasLbl.AutoSize = true;
            this.ecoParasLbl.Location = new System.Drawing.Point(9, 363);
            this.ecoParasLbl.Name = "ecoParasLbl";
            this.ecoParasLbl.Size = new System.Drawing.Size(19, 52);
            this.ecoParasLbl.TabIndex = 2;
            this.ecoParasLbl.Text = "经\r\n济\r\n条\r\n件";
            // 
            // listBox_GeoPara
            // 
            this.listBox_GeoPara.Enabled = false;
            this.listBox_GeoPara.FormattingEnabled = true;
            this.listBox_GeoPara.Items.AddRange(new object[] {
            "页岩厚度(m)",
            "有机质含量TOC(%)",
            "干酪根类型",
            "有机质成熟度Ro(%)",
            "圈定面积(km^2)",
            "含气量(m^3/t)",
            "资源丰度",
            "孔隙度(%)",
            "构造复杂程度",
            "顶板条件",
            "底板条件"});
            this.listBox_GeoPara.Location = new System.Drawing.Point(34, 24);
            this.listBox_GeoPara.Name = "listBox_GeoPara";
            this.listBox_GeoPara.ScrollAlwaysVisible = true;
            this.listBox_GeoPara.Size = new System.Drawing.Size(130, 160);
            this.listBox_GeoPara.TabIndex = 3;
            // 
            // listBox_EcoPara
            // 
            this.listBox_EcoPara.Enabled = false;
            this.listBox_EcoPara.FormattingEnabled = true;
            this.listBox_EcoPara.Items.AddRange(new object[] {
            "市场气价",
            "市场需求",
            "交通设施",
            "管网条件",
            "地表地貌"});
            this.listBox_EcoPara.Location = new System.Drawing.Point(34, 351);
            this.listBox_EcoPara.Name = "listBox_EcoPara";
            this.listBox_EcoPara.ScrollAlwaysVisible = true;
            this.listBox_EcoPara.Size = new System.Drawing.Size(133, 82);
            this.listBox_EcoPara.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_Diff_EngiPara);
            this.groupBox1.Controls.Add(this.listBox_EngPara);
            this.groupBox1.Controls.Add(this.engParasLbl);
            this.groupBox1.Location = new System.Drawing.Point(0, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 151);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // engParasLbl
            // 
            this.engParasLbl.AutoSize = true;
            this.engParasLbl.Location = new System.Drawing.Point(9, 50);
            this.engParasLbl.Name = "engParasLbl";
            this.engParasLbl.Size = new System.Drawing.Size(19, 52);
            this.engParasLbl.TabIndex = 1;
            this.engParasLbl.Text = "工\r\n程\r\n条\r\n件";
            // 
            // listBox_EngPara
            // 
            this.listBox_EngPara.Enabled = false;
            this.listBox_EngPara.FormattingEnabled = true;
            this.listBox_EngPara.Items.AddRange(new object[] {
            "埋深(m)",
            "压力系数",
            "渗透率(mD)",
            "裂缝发育程度",
            "应力差异系数",
            "脆性矿物含量(%)",
            "水系",
            "区域勘探程度"});
            this.listBox_EngPara.Location = new System.Drawing.Point(34, 20);
            this.listBox_EngPara.Name = "listBox_EngPara";
            this.listBox_EngPara.ScrollAlwaysVisible = true;
            this.listBox_EngPara.Size = new System.Drawing.Size(133, 121);
            this.listBox_EngPara.TabIndex = 4;
            // 
            // listBox_Diff_EngiPara
            // 
            this.listBox_Diff_EngiPara.FormattingEnabled = true;
            this.listBox_Diff_EngiPara.Location = new System.Drawing.Point(221, 20);
            this.listBox_Diff_EngiPara.Name = "listBox_Diff_EngiPara";
            this.listBox_Diff_EngiPara.ScrollAlwaysVisible = true;
            this.listBox_Diff_EngiPara.Size = new System.Drawing.Size(130, 121);
            this.listBox_Diff_EngiPara.TabIndex = 5;
            // 
            // listBox_Diff_GeoPara
            // 
            this.listBox_Diff_GeoPara.FormattingEnabled = true;
            this.listBox_Diff_GeoPara.Location = new System.Drawing.Point(221, 24);
            this.listBox_Diff_GeoPara.Name = "listBox_Diff_GeoPara";
            this.listBox_Diff_GeoPara.ScrollAlwaysVisible = true;
            this.listBox_Diff_GeoPara.Size = new System.Drawing.Size(130, 160);
            this.listBox_Diff_GeoPara.TabIndex = 7;
            // 
            // listBox_Diff_EcoPara
            // 
            this.listBox_Diff_EcoPara.FormattingEnabled = true;
            this.listBox_Diff_EcoPara.Location = new System.Drawing.Point(221, 351);
            this.listBox_Diff_EcoPara.Name = "listBox_Diff_EcoPara";
            this.listBox_Diff_EcoPara.ScrollAlwaysVisible = true;
            this.listBox_Diff_EcoPara.Size = new System.Drawing.Size(130, 82);
            this.listBox_Diff_EcoPara.TabIndex = 8;
            // 
            // gBoxParameters
            // 
            this.gBoxParameters.Controls.Add(this.listBox_Diff_EcoPara);
            this.gBoxParameters.Controls.Add(this.listBox_Diff_GeoPara);
            this.gBoxParameters.Controls.Add(this.groupBox1);
            this.gBoxParameters.Controls.Add(this.listBox_EcoPara);
            this.gBoxParameters.Controls.Add(this.listBox_GeoPara);
            this.gBoxParameters.Controls.Add(this.ecoParasLbl);
            this.gBoxParameters.Controls.Add(this.geoParasLbl);
            this.gBoxParameters.Location = new System.Drawing.Point(12, 64);
            this.gBoxParameters.Name = "gBoxParameters";
            this.gBoxParameters.Size = new System.Drawing.Size(353, 439);
            this.gBoxParameters.TabIndex = 1;
            this.gBoxParameters.TabStop = false;
            this.gBoxParameters.Text = "评价参数";
            // 
            // TargetAreaParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 515);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.gBoxParameters);
            this.Controls.Add(this.gBoxTargetArea);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TargetAreaParameters";
            this.Text = "页岩气选区评价参数";
            this.Load += new System.EventHandler(this.TargetAreaParameters_Load);
            this.gBoxTargetArea.ResumeLayout(false);
            this.gBoxTargetArea.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBoxParameters.ResumeLayout(false);
            this.gBoxParameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxTargetArea;
        private System.Windows.Forms.RadioButton rBtnProspective;
        private System.Windows.Forms.RadioButton rBtnFavorable;
        private System.Windows.Forms.RadioButton rBtnCore;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label geoParasLbl;
        private System.Windows.Forms.Label ecoParasLbl;
        private System.Windows.Forms.ListBox listBox_GeoPara;
        private System.Windows.Forms.ListBox listBox_EcoPara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_Diff_EngiPara;
        private System.Windows.Forms.ListBox listBox_EngPara;
        private System.Windows.Forms.Label engParasLbl;
        private System.Windows.Forms.ListBox listBox_Diff_GeoPara;
        private System.Windows.Forms.ListBox listBox_Diff_EcoPara;
        private System.Windows.Forms.GroupBox gBoxParameters;
    }
}