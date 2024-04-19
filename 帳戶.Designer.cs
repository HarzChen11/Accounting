namespace WindowsFormsApp1.記帳
{
    partial class 帳戶
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startDataPicker = new System.Windows.Forms.DateTimePicker();
            this.endDataPicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuBar1 = new WindowsFormsApp1.記帳.MenuBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "起 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "迄 :";
            // 
            // startDataPicker
            // 
            this.startDataPicker.Location = new System.Drawing.Point(75, 25);
            this.startDataPicker.Name = "startDataPicker";
            this.startDataPicker.Size = new System.Drawing.Size(200, 22);
            this.startDataPicker.TabIndex = 17;
            // 
            // endDataPicker
            // 
            this.endDataPicker.Location = new System.Drawing.Point(75, 57);
            this.endDataPicker.Name = "endDataPicker";
            this.endDataPicker.Size = new System.Drawing.Size(200, 22);
            this.endDataPicker.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "查詢";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(75, 110);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(242, 380);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // menuBar1
            // 
            this.menuBar1.Location = new System.Drawing.Point(-1, 496);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(410, 108);
            this.menuBar1.TabIndex = 14;
            // 
            // 帳戶
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 607);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.endDataPicker);
            this.Controls.Add(this.startDataPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuBar1);
            this.Name = "帳戶";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帳戶";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuBar menuBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDataPicker;
        private System.Windows.Forms.DateTimePicker endDataPicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}