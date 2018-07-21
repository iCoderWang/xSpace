namespace EsofaUI
{
    partial class ConditionalQueryFrm
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
            this.cmbBox_Paras = new System.Windows.Forms.ComboBox();
            this.txtBox_Values = new System.Windows.Forms.TextBox();
            this.btn_EqualSign = new System.Windows.Forms.Button();
            this.btn_NotEqualSign = new System.Windows.Forms.Button();
            this.btn_SmallerSign = new System.Windows.Forms.Button();
            this.btn_GreaterSign = new System.Windows.Forms.Button();
            this.btn_BetweenKeyWord = new System.Windows.Forms.Button();
            this.btn_AndKeyWord = new System.Windows.Forms.Button();
            this.btn_INKeyWord = new System.Windows.Forms.Button();
            this.btn_NotKeyWord = new System.Windows.Forms.Button();
            this.txtBox_QuerySql = new System.Windows.Forms.TextBox();
            this.btn_QueryCmd = new System.Windows.Forms.Button();
            this.btn_ExitCmd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBox_Paras
            // 
            this.cmbBox_Paras.FormattingEnabled = true;
            this.cmbBox_Paras.Location = new System.Drawing.Point(12, 22);
            this.cmbBox_Paras.Name = "cmbBox_Paras";
            this.cmbBox_Paras.Size = new System.Drawing.Size(170, 21);
            this.cmbBox_Paras.TabIndex = 0;
            // 
            // txtBox_Values
            // 
            this.txtBox_Values.Location = new System.Drawing.Point(203, 23);
            this.txtBox_Values.Multiline = true;
            this.txtBox_Values.Name = "txtBox_Values";
            this.txtBox_Values.Size = new System.Drawing.Size(197, 272);
            this.txtBox_Values.TabIndex = 1;
            // 
            // btn_EqualSign
            // 
            this.btn_EqualSign.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_EqualSign.Location = new System.Drawing.Point(30, 150);
            this.btn_EqualSign.Name = "btn_EqualSign";
            this.btn_EqualSign.Size = new System.Drawing.Size(50, 25);
            this.btn_EqualSign.TabIndex = 2;
            this.btn_EqualSign.Text = "=";
            this.btn_EqualSign.UseVisualStyleBackColor = true;
            // 
            // btn_NotEqualSign
            // 
            this.btn_NotEqualSign.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NotEqualSign.Location = new System.Drawing.Point(30, 190);
            this.btn_NotEqualSign.Name = "btn_NotEqualSign";
            this.btn_NotEqualSign.Size = new System.Drawing.Size(50, 25);
            this.btn_NotEqualSign.TabIndex = 3;
            this.btn_NotEqualSign.Text = "<>";
            this.btn_NotEqualSign.UseVisualStyleBackColor = true;
            // 
            // btn_SmallerSign
            // 
            this.btn_SmallerSign.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SmallerSign.Location = new System.Drawing.Point(30, 270);
            this.btn_SmallerSign.Name = "btn_SmallerSign";
            this.btn_SmallerSign.Size = new System.Drawing.Size(50, 25);
            this.btn_SmallerSign.TabIndex = 5;
            this.btn_SmallerSign.Text = "<";
            this.btn_SmallerSign.UseVisualStyleBackColor = true;
            // 
            // btn_GreaterSign
            // 
            this.btn_GreaterSign.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GreaterSign.Location = new System.Drawing.Point(30, 230);
            this.btn_GreaterSign.Name = "btn_GreaterSign";
            this.btn_GreaterSign.Size = new System.Drawing.Size(50, 25);
            this.btn_GreaterSign.TabIndex = 4;
            this.btn_GreaterSign.Text = ">";
            this.btn_GreaterSign.UseVisualStyleBackColor = true;
            // 
            // btn_BetweenKeyWord
            // 
            this.btn_BetweenKeyWord.Location = new System.Drawing.Point(110, 270);
            this.btn_BetweenKeyWord.Name = "btn_BetweenKeyWord";
            this.btn_BetweenKeyWord.Size = new System.Drawing.Size(72, 25);
            this.btn_BetweenKeyWord.TabIndex = 9;
            this.btn_BetweenKeyWord.Text = "BETWEEN";
            this.btn_BetweenKeyWord.UseVisualStyleBackColor = true;
            // 
            // btn_AndKeyWord
            // 
            this.btn_AndKeyWord.Location = new System.Drawing.Point(110, 230);
            this.btn_AndKeyWord.Name = "btn_AndKeyWord";
            this.btn_AndKeyWord.Size = new System.Drawing.Size(50, 25);
            this.btn_AndKeyWord.TabIndex = 8;
            this.btn_AndKeyWord.Text = "AND";
            this.btn_AndKeyWord.UseVisualStyleBackColor = true;
            // 
            // btn_INKeyWord
            // 
            this.btn_INKeyWord.Location = new System.Drawing.Point(110, 190);
            this.btn_INKeyWord.Name = "btn_INKeyWord";
            this.btn_INKeyWord.Size = new System.Drawing.Size(50, 25);
            this.btn_INKeyWord.TabIndex = 7;
            this.btn_INKeyWord.Text = "IN";
            this.btn_INKeyWord.UseVisualStyleBackColor = true;
            // 
            // btn_NotKeyWord
            // 
            this.btn_NotKeyWord.Location = new System.Drawing.Point(110, 150);
            this.btn_NotKeyWord.Name = "btn_NotKeyWord";
            this.btn_NotKeyWord.Size = new System.Drawing.Size(50, 25);
            this.btn_NotKeyWord.TabIndex = 6;
            this.btn_NotKeyWord.Text = "NOT";
            this.btn_NotKeyWord.UseVisualStyleBackColor = true;
            // 
            // txtBox_QuerySql
            // 
            this.txtBox_QuerySql.Location = new System.Drawing.Point(12, 317);
            this.txtBox_QuerySql.Multiline = true;
            this.txtBox_QuerySql.Name = "txtBox_QuerySql";
            this.txtBox_QuerySql.Size = new System.Drawing.Size(387, 78);
            this.txtBox_QuerySql.TabIndex = 10;
            // 
            // btn_QueryCmd
            // 
            this.btn_QueryCmd.Location = new System.Drawing.Point(225, 417);
            this.btn_QueryCmd.Name = "btn_QueryCmd";
            this.btn_QueryCmd.Size = new System.Drawing.Size(79, 32);
            this.btn_QueryCmd.TabIndex = 11;
            this.btn_QueryCmd.Text = "查询";
            this.btn_QueryCmd.UseVisualStyleBackColor = true;
            // 
            // btn_ExitCmd
            // 
            this.btn_ExitCmd.Location = new System.Drawing.Point(320, 417);
            this.btn_ExitCmd.Name = "btn_ExitCmd";
            this.btn_ExitCmd.Size = new System.Drawing.Size(79, 32);
            this.btn_ExitCmd.TabIndex = 12;
            this.btn_ExitCmd.Text = "退出";
            this.btn_ExitCmd.UseVisualStyleBackColor = true;
            this.btn_ExitCmd.Click += new System.EventHandler(this.btn_ExitCmd_Click);
            // 
            // ConditionalQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 461);
            this.Controls.Add(this.btn_ExitCmd);
            this.Controls.Add(this.btn_QueryCmd);
            this.Controls.Add(this.txtBox_QuerySql);
            this.Controls.Add(this.btn_BetweenKeyWord);
            this.Controls.Add(this.btn_AndKeyWord);
            this.Controls.Add(this.btn_INKeyWord);
            this.Controls.Add(this.btn_NotKeyWord);
            this.Controls.Add(this.btn_SmallerSign);
            this.Controls.Add(this.btn_GreaterSign);
            this.Controls.Add(this.btn_NotEqualSign);
            this.Controls.Add(this.btn_EqualSign);
            this.Controls.Add(this.txtBox_Values);
            this.Controls.Add(this.cmbBox_Paras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConditionalQueryFrm";
            this.Text = "条件查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBox_Paras;
        private System.Windows.Forms.TextBox txtBox_Values;
        private System.Windows.Forms.Button btn_EqualSign;
        private System.Windows.Forms.Button btn_NotEqualSign;
        private System.Windows.Forms.Button btn_SmallerSign;
        private System.Windows.Forms.Button btn_GreaterSign;
        private System.Windows.Forms.Button btn_BetweenKeyWord;
        private System.Windows.Forms.Button btn_AndKeyWord;
        private System.Windows.Forms.Button btn_INKeyWord;
        private System.Windows.Forms.Button btn_NotKeyWord;
        private System.Windows.Forms.TextBox txtBox_QuerySql;
        private System.Windows.Forms.Button btn_QueryCmd;
        private System.Windows.Forms.Button btn_ExitCmd;
    }
}