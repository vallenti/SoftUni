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
            this.components = new System.ComponentModel.Container();
            this.stringTextbox = new System.Windows.Forms.TextBox();
            this.capitalLettersCheckbox = new System.Windows.Forms.CheckBox();
            this.smallLettersCheckbox = new System.Windows.Forms.CheckBox();
            this.digitsCheckbox = new System.Windows.Forms.CheckBox();
            this.specialCharsCheckBox = new System.Windows.Forms.CheckBox();
            this.stringContainLabel = new System.Windows.Forms.Label();
            this.capitalLettersNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.smallLettersNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.digitsNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.specialCharsNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.genPassButton = new System.Windows.Forms.Button();
            this.maxLengthTextbox = new System.Windows.Forms.TextBox();
            this.maxLengthLabel = new System.Windows.Forms.Label();
            this.minCapitalTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.starCapitalLabel = new System.Windows.Forms.Label();
            this.minSmallTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.starSmallLabel = new System.Windows.Forms.Label();
            this.minDigitsTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.starDigitsLabel = new System.Windows.Forms.Label();
            this.minSpecialTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.starSpecLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.capitalLettersNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallLettersNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitsNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialCharsNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // stringTextbox
            // 
            this.stringTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.stringTextbox.Location = new System.Drawing.Point(32, 194);
            this.stringTextbox.Name = "stringTextbox";
            this.stringTextbox.ReadOnly = true;
            this.stringTextbox.Size = new System.Drawing.Size(176, 20);
            this.stringTextbox.TabIndex = 0;
            this.stringTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stringTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // stringContainLabel
            // 
            this.stringContainLabel.AutoSize = true;
            this.stringContainLabel.Location = new System.Drawing.Point(9, 23);
            this.stringContainLabel.Name = "stringContainLabel";
            this.stringContainLabel.Size = new System.Drawing.Size(109, 13);
            this.stringContainLabel.TabIndex = 5;
            this.stringContainLabel.Text = "String should contain:";
            // 
            // capitalLettersNumUpDown
            // 
            this.capitalLettersNumUpDown.Enabled = false;
            this.capitalLettersNumUpDown.Location = new System.Drawing.Point(167, 48);
            this.capitalLettersNumUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.capitalLettersNumUpDown.Name = "capitalLettersNumUpDown";
            this.capitalLettersNumUpDown.Size = new System.Drawing.Size(38, 20);
            this.capitalLettersNumUpDown.TabIndex = 6;
            this.minCapitalTooltip.SetToolTip(this.capitalLettersNumUpDown, "Minimum number of capital letters");
            this.capitalLettersNumUpDown.ValueChanged += new System.EventHandler(this.capitalLettersNumUpDown_ValueChanged);
            // 
            // smallLettersNumUpDown
            // 
            this.smallLettersNumUpDown.Enabled = false;
            this.smallLettersNumUpDown.Location = new System.Drawing.Point(167, 74);
            this.smallLettersNumUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.smallLettersNumUpDown.Name = "smallLettersNumUpDown";
            this.smallLettersNumUpDown.Size = new System.Drawing.Size(38, 20);
            this.smallLettersNumUpDown.TabIndex = 7;
            this.minSmallTooltip.SetToolTip(this.smallLettersNumUpDown, "Minimum number of small letters");
            // 
            // digitsNumUpDown
            // 
            this.digitsNumUpDown.Enabled = false;
            this.digitsNumUpDown.Location = new System.Drawing.Point(167, 98);
            this.digitsNumUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.digitsNumUpDown.Name = "digitsNumUpDown";
            this.digitsNumUpDown.Size = new System.Drawing.Size(38, 20);
            this.digitsNumUpDown.TabIndex = 8;
            this.minDigitsTooltip.SetToolTip(this.digitsNumUpDown, "Minimum number of digits");
            // 
            // specialCharsNumUpDown
            // 
            this.specialCharsNumUpDown.Enabled = false;
            this.specialCharsNumUpDown.Location = new System.Drawing.Point(167, 122);
            this.specialCharsNumUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.specialCharsNumUpDown.Name = "specialCharsNumUpDown";
            this.specialCharsNumUpDown.Size = new System.Drawing.Size(38, 20);
            this.specialCharsNumUpDown.TabIndex = 9;
            this.minSpecialTooltip.SetToolTip(this.specialCharsNumUpDown, "Minimum number of special characters");
            // 
            // genPassButton
            // 
            this.genPassButton.Enabled = false;
            this.genPassButton.Location = new System.Drawing.Point(64, 220);
            this.genPassButton.Name = "genPassButton";
            this.genPassButton.Size = new System.Drawing.Size(125, 23);
            this.genPassButton.TabIndex = 10;
            this.genPassButton.Text = "Generate string";
            this.genPassButton.UseVisualStyleBackColor = true;
            this.genPassButton.Click += new System.EventHandler(this.genPassButton_Click);
            // 
            // maxLengthTextbox
            // 
            this.maxLengthTextbox.Location = new System.Drawing.Point(114, 151);
            this.maxLengthTextbox.MaxLength = 2;
            this.maxLengthTextbox.Name = "maxLengthTextbox";
            this.maxLengthTextbox.Size = new System.Drawing.Size(32, 20);
            this.maxLengthTextbox.TabIndex = 11;
            // 
            // maxLengthLabel
            // 
            this.maxLengthLabel.AutoSize = true;
            this.maxLengthLabel.Location = new System.Drawing.Point(9, 154);
            this.maxLengthLabel.Name = "maxLengthLabel";
            this.maxLengthLabel.Size = new System.Drawing.Size(90, 13);
            this.maxLengthLabel.TabIndex = 12;
            this.maxLengthLabel.Text = "Max string length:";
            // 
            // starCapitalLabel
            // 
            this.starCapitalLabel.AutoSize = true;
            this.starCapitalLabel.ForeColor = System.Drawing.Color.Red;
            this.starCapitalLabel.Location = new System.Drawing.Point(211, 50);
            this.starCapitalLabel.Name = "starCapitalLabel";
            this.starCapitalLabel.Size = new System.Drawing.Size(11, 13);
            this.starCapitalLabel.TabIndex = 17;
            this.starCapitalLabel.Text = "*";
            this.minCapitalTooltip.SetToolTip(this.starCapitalLabel, "Minimum capital letters");
            // 
            // starSmallLabel
            // 
            this.starSmallLabel.AutoSize = true;
            this.starSmallLabel.ForeColor = System.Drawing.Color.Red;
            this.starSmallLabel.Location = new System.Drawing.Point(211, 74);
            this.starSmallLabel.Name = "starSmallLabel";
            this.starSmallLabel.Size = new System.Drawing.Size(11, 13);
            this.starSmallLabel.TabIndex = 18;
            this.starSmallLabel.Text = "*";
            this.minSmallTooltip.SetToolTip(this.starSmallLabel, "Minimum small letters");
            // 
            // starDigitsLabel
            // 
            this.starDigitsLabel.AutoSize = true;
            this.starDigitsLabel.ForeColor = System.Drawing.Color.Red;
            this.starDigitsLabel.Location = new System.Drawing.Point(211, 97);
            this.starDigitsLabel.Name = "starDigitsLabel";
            this.starDigitsLabel.Size = new System.Drawing.Size(11, 13);
            this.starDigitsLabel.TabIndex = 19;
            this.starDigitsLabel.Text = "*";
            this.minDigitsTooltip.SetToolTip(this.starDigitsLabel, "Minimum digits");
            // 
            // starSpecLabel
            // 
            this.starSpecLabel.AutoSize = true;
            this.starSpecLabel.ForeColor = System.Drawing.Color.Red;
            this.starSpecLabel.Location = new System.Drawing.Point(211, 121);
            this.starSpecLabel.Name = "starSpecLabel";
            this.starSpecLabel.Size = new System.Drawing.Size(11, 13);
            this.starSpecLabel.TabIndex = 20;
            this.starSpecLabel.Text = "*";
            this.minSpecialTooltip.SetToolTip(this.starSpecLabel, "Minimum special  characters");
            // 
            // PasswordGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 261);
            this.Controls.Add(this.starSpecLabel);
            this.Controls.Add(this.starDigitsLabel);
            this.Controls.Add(this.starSmallLabel);
            this.Controls.Add(this.starCapitalLabel);
            this.Controls.Add(this.maxLengthLabel);
            this.Controls.Add(this.maxLengthTextbox);
            this.Controls.Add(this.genPassButton);
            this.Controls.Add(this.specialCharsNumUpDown);
            this.Controls.Add(this.digitsNumUpDown);
            this.Controls.Add(this.smallLettersNumUpDown);
            this.Controls.Add(this.capitalLettersNumUpDown);
            this.Controls.Add(this.stringContainLabel);
            this.Controls.Add(this.specialCharsCheckBox);
            this.Controls.Add(this.digitsCheckbox);
            this.Controls.Add(this.smallLettersCheckbox);
            this.Controls.Add(this.capitalLettersCheckbox);
            this.Controls.Add(this.stringTextbox);
            this.Name = "PasswordGeneratorForm";
            this.Text = "String generator";
            ((System.ComponentModel.ISupportInitialize)(this.capitalLettersNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallLettersNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitsNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialCharsNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stringTextbox;
        private System.Windows.Forms.CheckBox capitalLettersCheckbox;
        private System.Windows.Forms.CheckBox smallLettersCheckbox;
        private System.Windows.Forms.CheckBox digitsCheckbox;
        private System.Windows.Forms.CheckBox specialCharsCheckBox;
        private System.Windows.Forms.Label stringContainLabel;
        private System.Windows.Forms.NumericUpDown capitalLettersNumUpDown;
        private System.Windows.Forms.NumericUpDown smallLettersNumUpDown;
        private System.Windows.Forms.NumericUpDown digitsNumUpDown;
        private System.Windows.Forms.NumericUpDown specialCharsNumUpDown;
        private System.Windows.Forms.Button genPassButton;
        private System.Windows.Forms.TextBox maxLengthTextbox;
        private System.Windows.Forms.Label maxLengthLabel;
        private System.Windows.Forms.ToolTip minCapitalTooltip;
        private System.Windows.Forms.ToolTip minSmallTooltip;
        private System.Windows.Forms.ToolTip minDigitsTooltip;
        private System.Windows.Forms.ToolTip minSpecialTooltip;
        private System.Windows.Forms.Label starCapitalLabel;
        private System.Windows.Forms.Label starSmallLabel;
        private System.Windows.Forms.Label starDigitsLabel;
        private System.Windows.Forms.Label starSpecLabel;
    }
}

