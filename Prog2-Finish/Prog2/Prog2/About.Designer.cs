namespace UPVApp
{
    partial class About
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AboutOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(179, 81);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Program 2\r\nCIS 200-01\r\nFall 2018\r\nDue: 10/24/2018\r\nBy: D7184";
            // 
            // AboutOK
            // 
            this.AboutOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AboutOK.Location = new System.Drawing.Point(66, 99);
            this.AboutOK.Name = "AboutOK";
            this.AboutOK.Size = new System.Drawing.Size(75, 23);
            this.AboutOK.TabIndex = 3;
            this.AboutOK.Text = "OK";
            this.AboutOK.UseVisualStyleBackColor = true;
            this.AboutOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 131);
            this.Controls.Add(this.AboutOK);
            this.Controls.Add(this.textBox1);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AboutOK;
    }
}