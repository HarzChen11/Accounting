namespace WindowsFormsApp1.記帳
{
    partial class MenuBar
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 83);
            this.button5.TabIndex = 0;
            this.button5.Text = "記一筆";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ChangeForm);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(113, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 83);
            this.button6.TabIndex = 1;
            this.button6.Text = "記帳本";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ChangeForm);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(215, 20);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 83);
            this.button7.TabIndex = 2;
            this.button7.Text = "帳戶";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ChangeForm);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(315, 20);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 83);
            this.button8.TabIndex = 3;
            this.button8.Text = "圖表分析";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ChangeForm);
            // 
            // MenuBar
            // 
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Name = "MenuBar";
            this.Size = new System.Drawing.Size(422, 111);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button8;
    }
}
