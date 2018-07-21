namespace EsofaUI
{
    partial class RawDataEditorFrm
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
            this.dgv_DataEditor = new System.Windows.Forms.DataGridView();
            this.btn_RecordData = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DataEditor
            // 
            this.dgv_DataEditor.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_DataEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DataEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_DataEditor.Location = new System.Drawing.Point(0, 0);
            this.dgv_DataEditor.Name = "dgv_DataEditor";
            this.dgv_DataEditor.Size = new System.Drawing.Size(800, 391);
            this.dgv_DataEditor.TabIndex = 0;
            // 
            // btn_RecordData
            // 
            this.btn_RecordData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RecordData.Location = new System.Drawing.Point(570, 406);
            this.btn_RecordData.Name = "btn_RecordData";
            this.btn_RecordData.Size = new System.Drawing.Size(65, 30);
            this.btn_RecordData.TabIndex = 1;
            this.btn_RecordData.Text = "添加";
            this.btn_RecordData.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Location = new System.Drawing.Point(662, 406);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(65, 30);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "退出";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // RawDataEditorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_RecordData);
            this.Controls.Add(this.dgv_DataEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RawDataEditorFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DataEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_DataEditor;
        public System.Windows.Forms.Button btn_RecordData;
        public System.Windows.Forms.Button btn_Close;
    }
}