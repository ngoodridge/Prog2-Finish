namespace UPVApp
{
    partial class LetterForm
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
            this.components = new System.ComponentModel.Container();
            this.OAddressLabel = new System.Windows.Forms.Label();
            this.originCombo = new System.Windows.Forms.ComboBox();
            this.destCombo = new System.Windows.Forms.ComboBox();
            this.DAddressLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.costBox = new System.Windows.Forms.TextBox();
            this.LetterOK = new System.Windows.Forms.Button();
            this.LetterCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // OAddressLabel
            // 
            this.OAddressLabel.AutoSize = true;
            this.OAddressLabel.Location = new System.Drawing.Point(35, 9);
            this.OAddressLabel.Name = "OAddressLabel";
            this.OAddressLabel.Size = new System.Drawing.Size(78, 13);
            this.OAddressLabel.TabIndex = 0;
            this.OAddressLabel.Text = "Origin Address:";
            // 
            // originCombo
            // 
            this.originCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originCombo.FormattingEnabled = true;
            this.originCombo.Location = new System.Drawing.Point(119, 6);
            this.originCombo.Name = "originCombo";
            this.originCombo.Size = new System.Drawing.Size(121, 21);
            this.originCombo.TabIndex = 1;
            this.originCombo.Validating += new System.ComponentModel.CancelEventHandler(this.Origin_Validating);
            this.originCombo.Validated += new System.EventHandler(this.Origin_Validated);
            // 
            // destCombo
            // 
            this.destCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destCombo.FormattingEnabled = true;
            this.destCombo.Location = new System.Drawing.Point(119, 33);
            this.destCombo.Name = "destCombo";
            this.destCombo.Size = new System.Drawing.Size(121, 21);
            this.destCombo.TabIndex = 3;
            this.destCombo.Validating += new System.ComponentModel.CancelEventHandler(this.Dest_Validating);
            this.destCombo.Validated += new System.EventHandler(this.Dest_Validated);
            // 
            // DAddressLabel
            // 
            this.DAddressLabel.AutoSize = true;
            this.DAddressLabel.Location = new System.Drawing.Point(12, 36);
            this.DAddressLabel.Name = "DAddressLabel";
            this.DAddressLabel.Size = new System.Drawing.Size(101, 13);
            this.DAddressLabel.TabIndex = 2;
            this.DAddressLabel.Text = "Destination Address";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(54, 63);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(59, 13);
            this.CostLabel.TabIndex = 4;
            this.CostLabel.Text = "Fixed Cost:";
            // 
            // costBox
            // 
            this.costBox.Location = new System.Drawing.Point(119, 60);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(121, 20);
            this.costBox.TabIndex = 5;
            this.costBox.Validating += new System.ComponentModel.CancelEventHandler(this.Cost_Validating);
            this.costBox.Validated += new System.EventHandler(this.Cost_Validated);
            // 
            // LetterOK
            // 
            this.LetterOK.Location = new System.Drawing.Point(12, 93);
            this.LetterOK.Name = "LetterOK";
            this.LetterOK.Size = new System.Drawing.Size(75, 23);
            this.LetterOK.TabIndex = 6;
            this.LetterOK.Text = "OK";
            this.LetterOK.UseVisualStyleBackColor = true;
            this.LetterOK.Click += new System.EventHandler(this.LetterOK_Click);
            // 
            // LetterCancel
            // 
            this.LetterCancel.CausesValidation = false;
            this.LetterCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LetterCancel.Location = new System.Drawing.Point(180, 93);
            this.LetterCancel.Name = "LetterCancel";
            this.LetterCancel.Size = new System.Drawing.Size(75, 23);
            this.LetterCancel.TabIndex = 7;
            this.LetterCancel.Text = "Cancel";
            this.LetterCancel.UseVisualStyleBackColor = true;
            this.LetterCancel.Click += new System.EventHandler(this.LetterCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 128);
            this.Controls.Add(this.LetterCancel);
            this.Controls.Add(this.LetterOK);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.destCombo);
            this.Controls.Add(this.DAddressLabel);
            this.Controls.Add(this.originCombo);
            this.Controls.Add(this.OAddressLabel);
            this.Name = "LetterForm";
            this.Text = "LetterForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OAddressLabel;
        private System.Windows.Forms.ComboBox originCombo;
        private System.Windows.Forms.ComboBox destCombo;
        private System.Windows.Forms.Label DAddressLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.Button LetterOK;
        private System.Windows.Forms.Button LetterCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}