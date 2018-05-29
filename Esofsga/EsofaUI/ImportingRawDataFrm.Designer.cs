namespace EsofaUI
{
    partial class ImportingRawDataFrm
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
            this.btnBrowser = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtSourceDataPath = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rdoBtnBasin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoBtnBlock = new System.Windows.Forms.RadioButton();
            this.rdoBtnTarget = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(712, 30);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(65, 25);
            this.btnBrowser.TabIndex = 0;
            this.btnBrowser.Text = "浏览";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(23, 37);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(43, 13);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "文件：";
            // 
            // txtSourceDataPath
            // 
            this.txtSourceDataPath.Location = new System.Drawing.Point(64, 33);
            this.txtSourceDataPath.Name = "txtSourceDataPath";
            this.txtSourceDataPath.Size = new System.Drawing.Size(619, 20);
            this.txtSourceDataPath.TabIndex = 2;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(618, 93);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(65, 25);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "预览";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(712, 93);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 25);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdoBtnBasin
            // 
            this.rdoBtnBasin.AutoSize = true;
            this.rdoBtnBasin.Checked = true;
            this.rdoBtnBasin.Location = new System.Drawing.Point(67, 70);
            this.rdoBtnBasin.Name = "rdoBtnBasin";
            this.rdoBtnBasin.Size = new System.Drawing.Size(61, 17);
            this.rdoBtnBasin.TabIndex = 5;
            this.rdoBtnBasin.TabStop = true;
            this.rdoBtnBasin.Text = "远景区";
            this.rdoBtnBasin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "区域：";
            // 
            // rdoBtnBlock
            // 
            this.rdoBtnBlock.AutoSize = true;
            this.rdoBtnBlock.Location = new System.Drawing.Point(146, 70);
            this.rdoBtnBlock.Name = "rdoBtnBlock";
            this.rdoBtnBlock.Size = new System.Drawing.Size(61, 17);
            this.rdoBtnBlock.TabIndex = 7;
            this.rdoBtnBlock.Text = "有利区";
            this.rdoBtnBlock.UseVisualStyleBackColor = true;
            // 
            // rdoBtnTarget
            // 
            this.rdoBtnTarget.AutoSize = true;
            this.rdoBtnTarget.Location = new System.Drawing.Point(231, 70);
            this.rdoBtnTarget.Name = "rdoBtnTarget";
            this.rdoBtnTarget.Size = new System.Drawing.Size(61, 17);
            this.rdoBtnTarget.TabIndex = 8;
            this.rdoBtnTarget.Text = "核心区";
            this.rdoBtnTarget.UseVisualStyleBackColor = true;
            // 
            // ImportingRawDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 140);
            this.Controls.Add(this.rdoBtnTarget);
            this.Controls.Add(this.rdoBtnBlock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoBtnBasin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.txtSourceDataPath);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnBrowser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportingRawDataFrm";
            this.Text = "导入原始数据";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtSourceDataPath;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton rdoBtnBasin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoBtnBlock;
        private System.Windows.Forms.RadioButton rdoBtnTarget;
    }
}