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
            this.grpBox_Cmds = new System.Windows.Forms.GroupBox();
            this.grpBox_ConditionalQuery = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_ValidateMySqlSyntax = new System.Windows.Forms.Button();
            this.listBox_Values = new System.Windows.Forms.ListBox();
            this.grpBox_Cmds.SuspendLayout();
            this.grpBox_ConditionalQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBox_Paras
            // 
            this.cmbBox_Paras.FormattingEnabled = true;
            this.cmbBox_Paras.IntegralHeight = false;
            this.cmbBox_Paras.Location = new System.Drawing.Point(8, 26);
            this.cmbBox_Paras.Name = "cmbBox_Paras";
            this.cmbBox_Paras.Size = new System.Drawing.Size(170, 21);
            this.cmbBox_Paras.TabIndex = 0;
            this.cmbBox_Paras.SelectedValueChanged += new System.EventHandler(this.cmbBox_Paras_SelectedValueChanged);
            // 
            // btn_EqualSign
            // 
            this.btn_EqualSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EqualSign.Location = new System.Drawing.Point(15, 20);
            this.btn_EqualSign.Name = "btn_EqualSign";
            this.btn_EqualSign.Size = new System.Drawing.Size(50, 25);
            this.btn_EqualSign.TabIndex = 2;
            this.btn_EqualSign.Text = "=";
            this.btn_EqualSign.UseVisualStyleBackColor = true;
            this.btn_EqualSign.Click += new System.EventHandler(this.btn_EqualSign_Click);
            // 
            // btn_NotEqualSign
            // 
            this.btn_NotEqualSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NotEqualSign.Location = new System.Drawing.Point(15, 60);
            this.btn_NotEqualSign.Name = "btn_NotEqualSign";
            this.btn_NotEqualSign.Size = new System.Drawing.Size(50, 25);
            this.btn_NotEqualSign.TabIndex = 3;
            this.btn_NotEqualSign.Text = "<>";
            this.btn_NotEqualSign.UseVisualStyleBackColor = true;
            this.btn_NotEqualSign.Click += new System.EventHandler(this.btn_NotEqualSign_Click);
            // 
            // btn_SmallerSign
            // 
            this.btn_SmallerSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SmallerSign.Location = new System.Drawing.Point(15, 140);
            this.btn_SmallerSign.Name = "btn_SmallerSign";
            this.btn_SmallerSign.Size = new System.Drawing.Size(50, 25);
            this.btn_SmallerSign.TabIndex = 5;
            this.btn_SmallerSign.Text = "<";
            this.btn_SmallerSign.UseVisualStyleBackColor = true;
            this.btn_SmallerSign.Click += new System.EventHandler(this.btn_SmallerSign_Click);
            // 
            // btn_GreaterSign
            // 
            this.btn_GreaterSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GreaterSign.Location = new System.Drawing.Point(15, 100);
            this.btn_GreaterSign.Name = "btn_GreaterSign";
            this.btn_GreaterSign.Size = new System.Drawing.Size(50, 25);
            this.btn_GreaterSign.TabIndex = 4;
            this.btn_GreaterSign.Text = ">";
            this.btn_GreaterSign.UseVisualStyleBackColor = true;
            this.btn_GreaterSign.Click += new System.EventHandler(this.btn_GreaterSign_Click);
            // 
            // btn_BetweenKeyWord
            // 
            this.btn_BetweenKeyWord.Location = new System.Drawing.Point(85, 101);
            this.btn_BetweenKeyWord.Name = "btn_BetweenKeyWord";
            this.btn_BetweenKeyWord.Size = new System.Drawing.Size(69, 25);
            this.btn_BetweenKeyWord.TabIndex = 9;
            this.btn_BetweenKeyWord.Text = "BETWEEN";
            this.btn_BetweenKeyWord.UseVisualStyleBackColor = true;
            this.btn_BetweenKeyWord.Click += new System.EventHandler(this.btn_BetweenKeyWord_Click);
            // 
            // btn_AndKeyWord
            // 
            this.btn_AndKeyWord.Location = new System.Drawing.Point(85, 140);
            this.btn_AndKeyWord.Name = "btn_AndKeyWord";
            this.btn_AndKeyWord.Size = new System.Drawing.Size(69, 25);
            this.btn_AndKeyWord.TabIndex = 8;
            this.btn_AndKeyWord.Text = "AND";
            this.btn_AndKeyWord.UseVisualStyleBackColor = true;
            this.btn_AndKeyWord.Click += new System.EventHandler(this.btn_AndKeyWord_Click);
            // 
            // btn_INKeyWord
            // 
            this.btn_INKeyWord.Location = new System.Drawing.Point(85, 60);
            this.btn_INKeyWord.Name = "btn_INKeyWord";
            this.btn_INKeyWord.Size = new System.Drawing.Size(69, 25);
            this.btn_INKeyWord.TabIndex = 7;
            this.btn_INKeyWord.Text = "IN";
            this.btn_INKeyWord.UseVisualStyleBackColor = true;
            this.btn_INKeyWord.Click += new System.EventHandler(this.btn_INKeyWord_Click);
            // 
            // btn_NotKeyWord
            // 
            this.btn_NotKeyWord.Location = new System.Drawing.Point(85, 20);
            this.btn_NotKeyWord.Name = "btn_NotKeyWord";
            this.btn_NotKeyWord.Size = new System.Drawing.Size(69, 25);
            this.btn_NotKeyWord.TabIndex = 6;
            this.btn_NotKeyWord.Text = "NOT";
            this.btn_NotKeyWord.UseVisualStyleBackColor = true;
            this.btn_NotKeyWord.Click += new System.EventHandler(this.btn_NotKeyWord_Click);
            // 
            // txtBox_QuerySql
            // 
            this.txtBox_QuerySql.Location = new System.Drawing.Point(8, 318);
            this.txtBox_QuerySql.Multiline = true;
            this.txtBox_QuerySql.Name = "txtBox_QuerySql";
            this.txtBox_QuerySql.Size = new System.Drawing.Size(387, 78);
            this.txtBox_QuerySql.TabIndex = 10;
            this.txtBox_QuerySql.TextChanged += new System.EventHandler(this.txtBox_QuerySql_TextChanged);
            // 
            // btn_QueryCmd
            // 
            this.btn_QueryCmd.Location = new System.Drawing.Point(253, 458);
            this.btn_QueryCmd.Name = "btn_QueryCmd";
            this.btn_QueryCmd.Size = new System.Drawing.Size(60, 25);
            this.btn_QueryCmd.TabIndex = 11;
            this.btn_QueryCmd.Text = "查询";
            this.btn_QueryCmd.UseVisualStyleBackColor = true;
            this.btn_QueryCmd.Click += new System.EventHandler(this.btn_QueryCmd_Click);
            // 
            // btn_ExitCmd
            // 
            this.btn_ExitCmd.Location = new System.Drawing.Point(328, 458);
            this.btn_ExitCmd.Name = "btn_ExitCmd";
            this.btn_ExitCmd.Size = new System.Drawing.Size(60, 25);
            this.btn_ExitCmd.TabIndex = 12;
            this.btn_ExitCmd.Text = "退出";
            this.btn_ExitCmd.UseVisualStyleBackColor = true;
            this.btn_ExitCmd.Click += new System.EventHandler(this.btn_ExitCmd_Click);
            // 
            // grpBox_Cmds
            // 
            this.grpBox_Cmds.Controls.Add(this.btn_NotKeyWord);
            this.grpBox_Cmds.Controls.Add(this.btn_EqualSign);
            this.grpBox_Cmds.Controls.Add(this.btn_NotEqualSign);
            this.grpBox_Cmds.Controls.Add(this.btn_GreaterSign);
            this.grpBox_Cmds.Controls.Add(this.btn_BetweenKeyWord);
            this.grpBox_Cmds.Controls.Add(this.btn_SmallerSign);
            this.grpBox_Cmds.Controls.Add(this.btn_AndKeyWord);
            this.grpBox_Cmds.Controls.Add(this.btn_INKeyWord);
            this.grpBox_Cmds.Location = new System.Drawing.Point(8, 127);
            this.grpBox_Cmds.Name = "grpBox_Cmds";
            this.grpBox_Cmds.Size = new System.Drawing.Size(170, 176);
            this.grpBox_Cmds.TabIndex = 13;
            this.grpBox_Cmds.TabStop = false;
            this.grpBox_Cmds.Text = "命令组";
            // 
            // grpBox_ConditionalQuery
            // 
            this.grpBox_ConditionalQuery.Controls.Add(this.btn_Clear);
            this.grpBox_ConditionalQuery.Controls.Add(this.btn_ValidateMySqlSyntax);
            this.grpBox_ConditionalQuery.Controls.Add(this.listBox_Values);
            this.grpBox_ConditionalQuery.Controls.Add(this.cmbBox_Paras);
            this.grpBox_ConditionalQuery.Controls.Add(this.grpBox_Cmds);
            this.grpBox_ConditionalQuery.Controls.Add(this.txtBox_QuerySql);
            this.grpBox_ConditionalQuery.Location = new System.Drawing.Point(4, 5);
            this.grpBox_ConditionalQuery.Name = "grpBox_ConditionalQuery";
            this.grpBox_ConditionalQuery.Size = new System.Drawing.Size(405, 442);
            this.grpBox_ConditionalQuery.TabIndex = 14;
            this.grpBox_ConditionalQuery.TabStop = false;
            this.grpBox_ConditionalQuery.Text = "查询框";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(71, 407);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(50, 22);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "清除";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_ValidateMySqlSyntax
            // 
            this.btn_ValidateMySqlSyntax.Location = new System.Drawing.Point(8, 407);
            this.btn_ValidateMySqlSyntax.Name = "btn_ValidateMySqlSyntax";
            this.btn_ValidateMySqlSyntax.Size = new System.Drawing.Size(50, 22);
            this.btn_ValidateMySqlSyntax.TabIndex = 15;
            this.btn_ValidateMySqlSyntax.Text = "校验";
            this.btn_ValidateMySqlSyntax.UseVisualStyleBackColor = true;
            this.btn_ValidateMySqlSyntax.Click += new System.EventHandler(this.btn_ValidateMySqlSyntax_Click);
            // 
            // listBox_Values
            // 
            this.listBox_Values.FormattingEnabled = true;
            this.listBox_Values.Location = new System.Drawing.Point(195, 26);
            this.listBox_Values.Name = "listBox_Values";
            this.listBox_Values.ScrollAlwaysVisible = true;
            this.listBox_Values.Size = new System.Drawing.Size(200, 277);
            this.listBox_Values.TabIndex = 14;
            this.listBox_Values.TabStop = false;
            this.listBox_Values.UseTabStops = false;
            this.listBox_Values.DoubleClick += new System.EventHandler(this.listBox_Values_DoubleClick);
            // 
            // ConditionalQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 491);
            this.Controls.Add(this.grpBox_ConditionalQuery);
            this.Controls.Add(this.btn_ExitCmd);
            this.Controls.Add(this.btn_QueryCmd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConditionalQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "条件查询";
            this.Load += new System.EventHandler(this.ConditionalQueryFrm_Load);
            this.grpBox_Cmds.ResumeLayout(false);
            this.grpBox_ConditionalQuery.ResumeLayout(false);
            this.grpBox_ConditionalQuery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBox_Paras;
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
        private System.Windows.Forms.GroupBox grpBox_Cmds;
        private System.Windows.Forms.GroupBox grpBox_ConditionalQuery;
        private System.Windows.Forms.ListBox listBox_Values;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_ValidateMySqlSyntax;
    }
}