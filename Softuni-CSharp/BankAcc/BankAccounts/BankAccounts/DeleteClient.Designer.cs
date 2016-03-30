namespace BankAccountsNamespace
{
    partial class DeleteClient
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
            this.TypeOfClientGroupBox = new System.Windows.Forms.GroupBox();
            this.NewCompanyRadioBtn = new System.Windows.Forms.RadioButton();
            this.NewIndividualRadioBtn = new System.Windows.Forms.RadioButton();
            this.egnLabel = new System.Windows.Forms.Label();
            this.eikLabel = new System.Windows.Forms.Label();
            this.egnCB = new System.Windows.Forms.ComboBox();
            this.eikCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TypeOfClientGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TypeOfClientGroupBox
            // 
            this.TypeOfClientGroupBox.Controls.Add(this.NewCompanyRadioBtn);
            this.TypeOfClientGroupBox.Controls.Add(this.NewIndividualRadioBtn);
            this.TypeOfClientGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TypeOfClientGroupBox.Name = "TypeOfClientGroupBox";
            this.TypeOfClientGroupBox.Size = new System.Drawing.Size(193, 51);
            this.TypeOfClientGroupBox.TabIndex = 0;
            this.TypeOfClientGroupBox.TabStop = false;
            this.TypeOfClientGroupBox.Text = "Тип клиент";
            // 
            // NewCompanyRadioBtn
            // 
            this.NewCompanyRadioBtn.AutoSize = true;
            this.NewCompanyRadioBtn.Location = new System.Drawing.Point(123, 19);
            this.NewCompanyRadioBtn.Name = "NewCompanyRadioBtn";
            this.NewCompanyRadioBtn.Size = new System.Drawing.Size(62, 17);
            this.NewCompanyRadioBtn.TabIndex = 1;
            this.NewCompanyRadioBtn.TabStop = true;
            this.NewCompanyRadioBtn.Text = "Фирма";
            this.NewCompanyRadioBtn.UseVisualStyleBackColor = true;
            // 
            // NewIndividualRadioBtn
            // 
            this.NewIndividualRadioBtn.AutoSize = true;
            this.NewIndividualRadioBtn.Location = new System.Drawing.Point(7, 20);
            this.NewIndividualRadioBtn.Name = "NewIndividualRadioBtn";
            this.NewIndividualRadioBtn.Size = new System.Drawing.Size(110, 17);
            this.NewIndividualRadioBtn.TabIndex = 0;
            this.NewIndividualRadioBtn.TabStop = true;
            this.NewIndividualRadioBtn.Text = "Физическо лице";
            this.NewIndividualRadioBtn.UseVisualStyleBackColor = true;
            this.NewIndividualRadioBtn.CheckedChanged += new System.EventHandler(this.NewIndividualRadioBtn_CheckedChanged);
            // 
            // egnLabel
            // 
            this.egnLabel.AutoSize = true;
            this.egnLabel.Location = new System.Drawing.Point(15, 82);
            this.egnLabel.Name = "egnLabel";
            this.egnLabel.Size = new System.Drawing.Size(31, 13);
            this.egnLabel.TabIndex = 1;
            this.egnLabel.Text = "ЕГН:";
            // 
            // eikLabel
            // 
            this.eikLabel.AutoSize = true;
            this.eikLabel.Location = new System.Drawing.Point(15, 110);
            this.eikLabel.Name = "eikLabel";
            this.eikLabel.Size = new System.Drawing.Size(32, 13);
            this.eikLabel.TabIndex = 3;
            this.eikLabel.Text = "ЕИК:";
            // 
            // egnCB
            // 
            this.egnCB.Enabled = false;
            this.egnCB.FormattingEnabled = true;
            this.egnCB.Location = new System.Drawing.Point(54, 79);
            this.egnCB.Name = "egnCB";
            this.egnCB.Size = new System.Drawing.Size(121, 21);
            this.egnCB.TabIndex = 4;
            // 
            // eikCB
            // 
            this.eikCB.Enabled = false;
            this.eikCB.FormattingEnabled = true;
            this.eikCB.Location = new System.Drawing.Point(55, 107);
            this.eikCB.Name = "eikCB";
            this.eikCB.Size = new System.Drawing.Size(121, 21);
            this.eikCB.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Изтрий";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отказ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 178);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eikCB);
            this.Controls.Add(this.egnCB);
            this.Controls.Add(this.eikLabel);
            this.Controls.Add(this.egnLabel);
            this.Controls.Add(this.TypeOfClientGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeleteClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изтриване на клиент";
            this.TypeOfClientGroupBox.ResumeLayout(false);
            this.TypeOfClientGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TypeOfClientGroupBox;
        private System.Windows.Forms.RadioButton NewCompanyRadioBtn;
        private System.Windows.Forms.RadioButton NewIndividualRadioBtn;
        private System.Windows.Forms.Label egnLabel;
        private System.Windows.Forms.Label eikLabel;
        private System.Windows.Forms.ComboBox egnCB;
        private System.Windows.Forms.ComboBox eikCB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}