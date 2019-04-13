namespace UPVApp
{
    partial class AddressForm
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
            this.AddressCancel = new System.Windows.Forms.Button();
            this.AddressOK = new System.Windows.Forms.Button();
            this.stateCombo = new System.Windows.Forms.ComboBox();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addressBox2 = new System.Windows.Forms.TextBox();
            this.addressBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // AddressCancel
            // 
            this.AddressCancel.CausesValidation = false;
            this.AddressCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddressCancel.Location = new System.Drawing.Point(98, 177);
            this.AddressCancel.Name = "AddressCancel";
            this.AddressCancel.Size = new System.Drawing.Size(75, 23);
            this.AddressCancel.TabIndex = 27;
            this.AddressCancel.Text = "Cancel";
            this.AddressCancel.UseVisualStyleBackColor = true;
            this.AddressCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddressOK
            // 
            this.AddressOK.Location = new System.Drawing.Point(17, 177);
            this.AddressOK.Name = "AddressOK";
            this.AddressOK.Size = new System.Drawing.Size(75, 23);
            this.AddressOK.TabIndex = 26;
            this.AddressOK.Text = "OK";
            this.AddressOK.UseVisualStyleBackColor = true;
            this.AddressOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // stateCombo
            // 
            this.stateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateCombo.FormattingEnabled = true;
            this.stateCombo.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.stateCombo.Location = new System.Drawing.Point(59, 115);
            this.stateCombo.Name = "stateCombo";
            this.stateCombo.Size = new System.Drawing.Size(100, 21);
            this.stateCombo.TabIndex = 24;
            this.stateCombo.Validating += new System.ComponentModel.CancelEventHandler(this.State_Validating);
            this.stateCombo.Validated += new System.EventHandler(this.State_Validated);
            // 
            // zipBox
            // 
            this.zipBox.Location = new System.Drawing.Point(59, 141);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(100, 20);
            this.zipBox.TabIndex = 25;
            this.zipBox.Validating += new System.ComponentModel.CancelEventHandler(this.Zip_Validating);
            this.zipBox.Validated += new System.EventHandler(this.Zip_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Zip:";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(59, 89);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 20);
            this.cityBox.TabIndex = 22;
            this.cityBox.Validating += new System.ComponentModel.CancelEventHandler(this.CityBox_Validating);
            this.cityBox.Validated += new System.EventHandler(this.CityBox_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "State:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "City:";
            // 
            // addressBox2
            // 
            this.addressBox2.Location = new System.Drawing.Point(59, 63);
            this.addressBox2.Name = "addressBox2";
            this.addressBox2.Size = new System.Drawing.Size(100, 20);
            this.addressBox2.TabIndex = 19;
            // 
            // addressBox1
            // 
            this.addressBox1.Location = new System.Drawing.Point(59, 37);
            this.addressBox1.Name = "addressBox1";
            this.addressBox1.Size = new System.Drawing.Size(100, 20);
            this.addressBox1.TabIndex = 18;
            this.addressBox1.Validating += new System.ComponentModel.CancelEventHandler(this.AddressBox_Validating);
            this.addressBox1.Validated += new System.EventHandler(this.AddressBox_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Address:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(59, 11);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 16;
            this.nameBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameBox_Validating);
            this.nameBox.Validated += new System.EventHandler(this.NameBox_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name:";
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
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 211);
            this.Controls.Add(this.AddressCancel);
            this.Controls.Add(this.AddressOK);
            this.Controls.Add(this.stateCombo);
            this.Controls.Add(this.zipBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressBox2);
            this.Controls.Add(this.addressBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddressCancel;
        private System.Windows.Forms.Button AddressOK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ComboBox stateCombo;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox addressBox2;
        private System.Windows.Forms.TextBox addressBox1;
        private System.Windows.Forms.TextBox nameBox;
    }
}