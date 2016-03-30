namespace PasswordGeneratorForm
{
    partial class PasswordGeneratorForm
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
            this.pwTextbox = new System.Windows.Forms.TextBox();
            this.capitalLettersCheckbox = new System.Windows.Forms.CheckBox();
            this.smallLettersCheckbox = new System.Windows.Forms.CheckBox();
            this.digitsCheckbox = new System.Windows.Forms.CheckBox();
            this.specialCharsCheckBox = new System.Windows.Forms.CheckBox();
            this.pwContainLabel = new System.Windows.Forms.Label();
            this.capitalLettersNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.smallLettersNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.digitsNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.specialCharsNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.genPassButton = new System.Windows.Forms.Button();
            this.maxLengthTextbox = new System.Windows.Forms.TextBox();
            this.maxLengthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.capitalLettersNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallLettersNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitsNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialCharsNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pwTextbox
            // 
            this.pwTextbox.Location = new System.Drawing.Point(32, 194);
            this.pwTextbox.Name = "pwTextbox";
            this.pwTextbox.Size = new System.Drawing.Size(176, 20);
            this.pwTextbox.TabIndex = 0;
            this.pwTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pwTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // capitalLettersCheckbox
            // 
            this.capitalLettersCheckbox.AutoSize = true;
            this.capitalLettersCheckbox.Location = new System.Drawing.Point(12, 49);
            this.capitalLettersCheckbox.Name = "capitalLettersCheckbox";
            this.capitalLettersCheckbox.Size = new System.Drawing.Size(89, 17);
            this.capitalLettersCheckbox.TabIndex = 1;
            this.capitalLettersCheckbox.Text = "Capital letters";
            this.capitalLettersCheckbox.UseVisualStyleBackColor = true;
            this.capitalLettersCheckbox.CheckedChanged += new System.EventHandler(this.capitalLettersCheckbox_CheckedChanged);
            // 
            // smallLettersCheckbox
            // 
            this.smallLettersCheckbox.AutoSize = true;
            this.smallLettersCheckbox.Location = new System.Drawing.Point(12, 73);
            this.smallLettersCheckbox.Name = "smallLettersCheckbox";
            this.smallLettersCheckbox.Size = new System.Drawing.Size(82, 17);
            this.smallLettersCheckbox.TabIndex = 2;
            this.smallLettersCheckbox.Text = "Small letters";
            this.smallLettersCheckbox.UseVisualStyleBackColor = true;
            this.smallLettersCheckbox.CheckedChanged += new System.EventHandler(this.smallLettersCheckbox_CheckedChanged);
            // 
            // digitsCheckbox
            // 
            this.digitsCheckbox.AutoSize = true;
            this.digitsCheckbox.Location = new System.Drawing.Point(12, 97);
            this.digitsCheckbox.Name = "digitsCheckbox";
            this.digitsCheckbox.Size = new System.Drawing.Size(52, 17);
            this.digitsCheckbox.TabIndex = 3;
            this.digitsCheckbox.Text = "Digits";
            this.digitsCheckbox.UseVisualStyleBackColor = true;
            this.digitsCheckbox.CheckedChanged += new System.EventHandler(this.digitsCheckbox_CheckedChanged);
            // 
            // specialCharsCheckBox
            // 
            this.specialCharsCheckBox.AutoSize = true;
            this.specialCharsCheckBox.Location = new System.Drawing.Point(12, 121);
            this.specialCharsCheckBox.Name = "specialCharsCheckBox";
            this.specialCharsCheckBox.Size = new System.Drawing.Size(114, 17);
            this.specialCharsCheckBox.TabIndex = 4;
            this.specialCharsCheckBox.Text = "Special characters";
            this.specialCharsCheckBox.UseVisualStyleBackColor = true;
            this.specialCharsCheckBox.CheckedChanged += new System.EventHandler(this.specialCharsCheckBox_CheckedChanged);
            // 
            // pwContainLabel
            // 
            this.pwContainLabel.AutoSize = true;
            this.pwContainLabel.Location = new System.Drawing.Point(9, 23);
            this.pwContainLabel.Name = "pwContainLabel";
            this.pwContainLabel.Size = new System.Drawing.Size(128, 13);
            this.pwContainLabel.TabIndex = 5;
            this.pwContainLabel.Text = "Password should contain:";
            // 
            // capitalLettersNumUpDown
            // 
            this.capitalLettersNumUpDown.Location = new System.Drawing.Point(167, 48);
            this.capitalLettersNumUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.capitalLettersNumUpDown.Name = "capitalLettersNumUpDown";
            this.capitalLettersNumUpDown.Size = new System.Drawing.Size(38, 20);
            this.capitalLettersNumUpDown.TabIndex = 6;
            this.capitalLettersNumUpDown.Visible = false;
            // 
            // smallLettersNumUpDown
            // 
            this.smallLettersNumUpDown.Location = new System.Drawing.Point(167, 74);
            this.smallLettersNumUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.smallLettersNumUpDown.Name = "smallLettersNumUpDown";
            this.smallLettersNumUpDown.Size = new System.Drawing.Size(38, 20);
            this.smallLettersNumUpDown.TabIndex = 7;
            this.smallLettersNumUpDown.Visible = false;
            // 
            // digitsNumUpDown
            // 
            this.digitsNumUpDown.Location = new System.Drawing.Point(167, 98);
            this.digitsNumUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.digitsNumUpDown.Name = "digitsNumUpDown";
            this.digitsNumUpDown.Size = new System.Drawing.Size(38, 20);
            this.digitsNumUpDown.TabIndex = 8;
            this.digitsNumUpDown.Visible = false;
            // 
            // specialCharsNumUpDown
            // 
            this.specialCharsNumUpDown.Location = new System.Drawing.Point(167, 122);
            this.specialCharsNumUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.specialCharsNumUpDown.Name = "specialCharsNumUpDown";
            this.specialCharsNumUpDown.Size = new System.Drawing.Size(38, 20);
            this.specialCharsNumUpDown.TabIndex = 9;
            this.specialCharsNumUpDown.Visible = false;
            // 
            // genPassButton
            // 
            this.genPassButton.Location = new System.Drawing.Point(64, 220);
            this.genPassButton.Name = "genPassButton";
            this.genPassButton.Size = new System.Drawing.Size(125, 23);
            this.genPassButton.TabIndex = 10;
            this.genPassButton.Text = "Generate password";
            this.genPassButton.UseVisualStyleBackColor = true;
            this.genPassButton.Click += new System.EventHandler(this.genPassButton_Click);
            // 
            // maxLengthTextbox
            // 
            this.maxLengthTextbox.Location = new System.Drawing.Point(125, 151);
            this.maxLengthTextbox.Name = "maxLengthTextbox";
            this.maxLengthTextbox.Size = new System.Drawing.Size(32, 20);
            this.maxLengthTextbox.TabIndex = 11;
            // 
            // maxLengthLabel
            // 
            this.maxLengthLabel.AutoSize = true;
            this.maxLengthLabel.Location = new System.Drawing.Point(9, 154);
            this.maxLengthLabel.Name = "maxLengthLabel";
            this.maxLengthLabel.Size = new System.Drawing.Size(110, 13);
            this.maxLengthLabel.TabIndex = 12;
            this.maxLengthLabel.Text = "Max password length:";
            // 
            // PasswordGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 261);
            this.Controls.Add(this.maxLengthLabel);
            this.Controls.Add(this.maxLengthTextbox);
            this.Controls.Add(this.genPassButton);
            this.Controls.Add(this.specialCharsNumUpDown);
            this.Controls.Add(this.digitsNumUpDown);
            this.Controls.Add(this.smallLettersNumUpDown);
            this.Controls.Add(this.capitalLettersNumUpDown);
            this.Controls.Add(this.pwContainLabel);
            this.Controls.Add(this.specialCharsCheckBox);
            this.Controls.Add(this.digitsCheckbox);
            this.Controls.Add(this.smallLettersCheckbox);
            this.Controls.Add(this.capitalLettersCheckbox);
            this.Controls.Add(this.pwTextbox);
            this.Name = "PasswordGeneratorForm";
            this.Text = "Password generator";
            ((System.ComponentModel.ISupportInitialize)(this.capitalLettersNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallLettersNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitsNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialCharsNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwTextbox;
        private System.Windows.Forms.CheckBox capitalLettersCheckbox;
        private System.Windows.Forms.CheckBox smallLettersCheckbox;
        private System.Windows.Forms.CheckBox digitsCheckbox;
        private System.Windows.Forms.CheckBox specialCharsCheckBox;
        private System.Windows.Forms.Label pwContainLabel;
        private System.Windows.Forms.NumericUpDown capitalLettersNumUpDown;
        private System.Windows.Forms.NumericUpDown smallLettersNumUpDown;
        private System.Windows.Forms.NumericUpDown digitsNumUpDown;
        private System.Windows.Forms.NumericUpDown specialCharsNumUpDown;
        private System.Windows.Forms.Button genPassButton;
        private System.Windows.Forms.TextBox maxLengthTextbox;
        private System.Windows.Forms.Label maxLengthLabel;
    }
}

