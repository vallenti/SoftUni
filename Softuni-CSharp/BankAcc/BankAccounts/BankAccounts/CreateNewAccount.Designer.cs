namespace BankAccountsNamespace
{
    partial class CreateNewAccount
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
            this.NewAccGroupBox = new System.Windows.Forms.GroupBox();
            this.PeriodTB = new System.Windows.Forms.TextBox();
            this.Interest = new System.Windows.Forms.Label();
            this.InterestTB = new System.Windows.Forms.TextBox();
            this.InterestLabel = new System.Windows.Forms.Label();
            this.BalanceTB = new System.Windows.Forms.TextBox();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.ClientGroupBox = new System.Windows.Forms.GroupBox();
            this.ExistingClientComboBox = new System.Windows.Forms.ComboBox();
            this.ExistingClientRadioBtn = new System.Windows.Forms.RadioButton();
            this.NewClientRadioBtn = new System.Windows.Forms.RadioButton();
            this.TypeOfAccGroupBox = new System.Windows.Forms.GroupBox();
            this.DepositRadioBtn = new System.Windows.Forms.RadioButton();
            this.LoanRadioBtn = new System.Windows.Forms.RadioButton();
            this.MortgageRadioBtn = new System.Windows.Forms.RadioButton();
            this.NewClientGroupBox = new System.Windows.Forms.GroupBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.eikTB = new System.Windows.Forms.TextBox();
            this.companyNameTB = new System.Windows.Forms.TextBox();
            this.EIKLabel = new System.Windows.Forms.Label();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.egnTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.SexLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.EGNLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.TypeOfClientGroupBox = new System.Windows.Forms.GroupBox();
            this.NewCompanyRadioBtn = new System.Windows.Forms.RadioButton();
            this.NewIndividualRadioBtn = new System.Windows.Forms.RadioButton();
            this.CreateNewBtn = new System.Windows.Forms.Button();
            this.ClearAllBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.notANumberError = new System.Windows.Forms.ErrorProvider(this.components);
            this.NewAccGroupBox.SuspendLayout();
            this.ClientGroupBox.SuspendLayout();
            this.TypeOfAccGroupBox.SuspendLayout();
            this.NewClientGroupBox.SuspendLayout();
            this.TypeOfClientGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notANumberError)).BeginInit();
            this.SuspendLayout();
            // 
            // NewAccGroupBox
            // 
            this.NewAccGroupBox.Controls.Add(this.PeriodTB);
            this.NewAccGroupBox.Controls.Add(this.Interest);
            this.NewAccGroupBox.Controls.Add(this.InterestTB);
            this.NewAccGroupBox.Controls.Add(this.InterestLabel);
            this.NewAccGroupBox.Controls.Add(this.BalanceTB);
            this.NewAccGroupBox.Controls.Add(this.BalanceLabel);
            this.NewAccGroupBox.Controls.Add(this.ClientGroupBox);
            this.NewAccGroupBox.Controls.Add(this.TypeOfAccGroupBox);
            this.NewAccGroupBox.Location = new System.Drawing.Point(12, 12);
            this.NewAccGroupBox.Name = "NewAccGroupBox";
            this.NewAccGroupBox.Size = new System.Drawing.Size(270, 236);
            this.NewAccGroupBox.TabIndex = 2;
            this.NewAccGroupBox.TabStop = false;
            this.NewAccGroupBox.Text = "Нова сметка";
            // 
            // PeriodTB
            // 
            this.PeriodTB.Location = new System.Drawing.Point(60, 200);
            this.PeriodTB.MaxLength = 2;
            this.PeriodTB.Name = "PeriodTB";
            this.PeriodTB.Size = new System.Drawing.Size(100, 20);
            this.PeriodTB.TabIndex = 8;
            // 
            // Interest
            // 
            this.Interest.AutoSize = true;
            this.Interest.Location = new System.Drawing.Point(9, 203);
            this.Interest.Name = "Interest";
            this.Interest.Size = new System.Drawing.Size(48, 13);
            this.Interest.TabIndex = 6;
            this.Interest.Text = "Период:";
            // 
            // InterestTB
            // 
            this.InterestTB.Location = new System.Drawing.Point(60, 174);
            this.InterestTB.MaxLength = 5;
            this.InterestTB.Name = "InterestTB";
            this.InterestTB.Size = new System.Drawing.Size(100, 20);
            this.InterestTB.TabIndex = 5;
            // 
            // InterestLabel
            // 
            this.InterestLabel.AutoSize = true;
            this.InterestLabel.Location = new System.Drawing.Point(13, 180);
            this.InterestLabel.Name = "InterestLabel";
            this.InterestLabel.Size = new System.Drawing.Size(41, 13);
            this.InterestLabel.TabIndex = 4;
            this.InterestLabel.Text = "Лихва:";
            // 
            // BalanceTB
            // 
            this.BalanceTB.Location = new System.Drawing.Point(60, 148);
            this.BalanceTB.MaxLength = 10;
            this.BalanceTB.Name = "BalanceTB";
            this.BalanceTB.Size = new System.Drawing.Size(100, 20);
            this.BalanceTB.TabIndex = 3;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(15, 154);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(39, 13);
            this.BalanceLabel.TabIndex = 2;
            this.BalanceLabel.Text = "Сума: ";
            // 
            // ClientGroupBox
            // 
            this.ClientGroupBox.Controls.Add(this.ExistingClientComboBox);
            this.ClientGroupBox.Controls.Add(this.ExistingClientRadioBtn);
            this.ClientGroupBox.Controls.Add(this.NewClientRadioBtn);
            this.ClientGroupBox.Location = new System.Drawing.Point(6, 77);
            this.ClientGroupBox.Name = "ClientGroupBox";
            this.ClientGroupBox.Size = new System.Drawing.Size(258, 64);
            this.ClientGroupBox.TabIndex = 1;
            this.ClientGroupBox.TabStop = false;
            this.ClientGroupBox.Text = "Клиент";
            // 
            // ExistingClientComboBox
            // 
            this.ExistingClientComboBox.Enabled = false;
            this.ExistingClientComboBox.FormattingEnabled = true;
            this.ExistingClientComboBox.Location = new System.Drawing.Point(110, 37);
            this.ExistingClientComboBox.Name = "ExistingClientComboBox";
            this.ExistingClientComboBox.Size = new System.Drawing.Size(121, 21);
            this.ExistingClientComboBox.TabIndex = 7;
            // 
            // ExistingClientRadioBtn
            // 
            this.ExistingClientRadioBtn.AutoSize = true;
            this.ExistingClientRadioBtn.Location = new System.Drawing.Point(6, 40);
            this.ExistingClientRadioBtn.Name = "ExistingClientRadioBtn";
            this.ExistingClientRadioBtn.Size = new System.Drawing.Size(97, 17);
            this.ExistingClientRadioBtn.TabIndex = 6;
            this.ExistingClientRadioBtn.TabStop = true;
            this.ExistingClientRadioBtn.Text = "Съществуващ";
            this.ExistingClientRadioBtn.UseVisualStyleBackColor = true;
            this.ExistingClientRadioBtn.CheckedChanged += new System.EventHandler(this.ExistingClientRadioBtn_CheckedChanged);
            // 
            // NewClientRadioBtn
            // 
            this.NewClientRadioBtn.AutoSize = true;
            this.NewClientRadioBtn.Location = new System.Drawing.Point(6, 17);
            this.NewClientRadioBtn.Name = "NewClientRadioBtn";
            this.NewClientRadioBtn.Size = new System.Drawing.Size(45, 17);
            this.NewClientRadioBtn.TabIndex = 5;
            this.NewClientRadioBtn.TabStop = true;
            this.NewClientRadioBtn.Text = "Нов";
            this.NewClientRadioBtn.UseVisualStyleBackColor = true;
            this.NewClientRadioBtn.CheckedChanged += new System.EventHandler(this.NewClientRadioBtn_CheckedChanged);
            // 
            // TypeOfAccGroupBox
            // 
            this.TypeOfAccGroupBox.Controls.Add(this.DepositRadioBtn);
            this.TypeOfAccGroupBox.Controls.Add(this.LoanRadioBtn);
            this.TypeOfAccGroupBox.Controls.Add(this.MortgageRadioBtn);
            this.TypeOfAccGroupBox.Location = new System.Drawing.Point(6, 19);
            this.TypeOfAccGroupBox.Name = "TypeOfAccGroupBox";
            this.TypeOfAccGroupBox.Size = new System.Drawing.Size(258, 52);
            this.TypeOfAccGroupBox.TabIndex = 0;
            this.TypeOfAccGroupBox.TabStop = false;
            this.TypeOfAccGroupBox.Text = "Тип на сметката";
            // 
            // DepositRadioBtn
            // 
            this.DepositRadioBtn.AutoSize = true;
            this.DepositRadioBtn.Location = new System.Drawing.Point(6, 29);
            this.DepositRadioBtn.Name = "DepositRadioBtn";
            this.DepositRadioBtn.Size = new System.Drawing.Size(69, 17);
            this.DepositRadioBtn.TabIndex = 1;
            this.DepositRadioBtn.TabStop = true;
            this.DepositRadioBtn.Text = "Депозит";
            this.DepositRadioBtn.UseVisualStyleBackColor = true;
            // 
            // LoanRadioBtn
            // 
            this.LoanRadioBtn.AutoSize = true;
            this.LoanRadioBtn.Location = new System.Drawing.Point(81, 29);
            this.LoanRadioBtn.Name = "LoanRadioBtn";
            this.LoanRadioBtn.Size = new System.Drawing.Size(52, 17);
            this.LoanRadioBtn.TabIndex = 2;
            this.LoanRadioBtn.TabStop = true;
            this.LoanRadioBtn.Text = "Заем";
            this.LoanRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MortgageRadioBtn
            // 
            this.MortgageRadioBtn.AutoSize = true;
            this.MortgageRadioBtn.Location = new System.Drawing.Point(139, 29);
            this.MortgageRadioBtn.Name = "MortgageRadioBtn";
            this.MortgageRadioBtn.Size = new System.Drawing.Size(111, 17);
            this.MortgageRadioBtn.TabIndex = 3;
            this.MortgageRadioBtn.TabStop = true;
            this.MortgageRadioBtn.Text = "Ипотечен кредит";
            this.MortgageRadioBtn.UseVisualStyleBackColor = true;
            // 
            // NewClientGroupBox
            // 
            this.NewClientGroupBox.Controls.Add(this.sexComboBox);
            this.NewClientGroupBox.Controls.Add(this.eikTB);
            this.NewClientGroupBox.Controls.Add(this.companyNameTB);
            this.NewClientGroupBox.Controls.Add(this.EIKLabel);
            this.NewClientGroupBox.Controls.Add(this.companyNameLabel);
            this.NewClientGroupBox.Controls.Add(this.ageTB);
            this.NewClientGroupBox.Controls.Add(this.egnTB);
            this.NewClientGroupBox.Controls.Add(this.lastNameTB);
            this.NewClientGroupBox.Controls.Add(this.firstNameTB);
            this.NewClientGroupBox.Controls.Add(this.SexLabel);
            this.NewClientGroupBox.Controls.Add(this.AgeLabel);
            this.NewClientGroupBox.Controls.Add(this.EGNLabel);
            this.NewClientGroupBox.Controls.Add(this.lastNameLabel);
            this.NewClientGroupBox.Controls.Add(this.firstNameLabel);
            this.NewClientGroupBox.Controls.Add(this.TypeOfClientGroupBox);
            this.NewClientGroupBox.Location = new System.Drawing.Point(293, 12);
            this.NewClientGroupBox.Name = "NewClientGroupBox";
            this.NewClientGroupBox.Size = new System.Drawing.Size(341, 206);
            this.NewClientGroupBox.TabIndex = 3;
            this.NewClientGroupBox.TabStop = false;
            this.NewClientGroupBox.Text = "Нов клиент";
            // 
            // sexComboBox
            // 
            this.sexComboBox.Enabled = false;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Location = new System.Drawing.Point(72, 177);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(100, 21);
            this.sexComboBox.TabIndex = 15;
            // 
            // eikTB
            // 
            this.eikTB.Enabled = false;
            this.eikTB.Location = new System.Drawing.Point(229, 101);
            this.eikTB.MaxLength = 10;
            this.eikTB.Name = "eikTB";
            this.eikTB.Size = new System.Drawing.Size(100, 20);
            this.eikTB.TabIndex = 14;
            this.eikTB.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // companyNameTB
            // 
            this.companyNameTB.Enabled = false;
            this.companyNameTB.Location = new System.Drawing.Point(229, 75);
            this.companyNameTB.MaxLength = 30;
            this.companyNameTB.Name = "companyNameTB";
            this.companyNameTB.Size = new System.Drawing.Size(100, 20);
            this.companyNameTB.TabIndex = 13;
            // 
            // EIKLabel
            // 
            this.EIKLabel.AutoSize = true;
            this.EIKLabel.Enabled = false;
            this.EIKLabel.Location = new System.Drawing.Point(191, 104);
            this.EIKLabel.Name = "EIKLabel";
            this.EIKLabel.Size = new System.Drawing.Size(32, 13);
            this.EIKLabel.TabIndex = 12;
            this.EIKLabel.Text = "ЕИК:";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Enabled = false;
            this.companyNameLabel.Location = new System.Drawing.Point(191, 78);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(32, 13);
            this.companyNameLabel.TabIndex = 11;
            this.companyNameLabel.Text = "Име:";
            // 
            // ageTB
            // 
            this.ageTB.Enabled = false;
            this.ageTB.Location = new System.Drawing.Point(72, 151);
            this.ageTB.MaxLength = 2;
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(32, 20);
            this.ageTB.TabIndex = 9;
            // 
            // egnTB
            // 
            this.egnTB.Enabled = false;
            this.egnTB.Location = new System.Drawing.Point(72, 125);
            this.egnTB.MaxLength = 10;
            this.egnTB.Name = "egnTB";
            this.egnTB.Size = new System.Drawing.Size(100, 20);
            this.egnTB.TabIndex = 8;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Enabled = false;
            this.lastNameTB.Location = new System.Drawing.Point(72, 101);
            this.lastNameTB.MaxLength = 30;
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(100, 20);
            this.lastNameTB.TabIndex = 7;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Enabled = false;
            this.firstNameTB.Location = new System.Drawing.Point(72, 75);
            this.firstNameTB.MaxLength = 30;
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(100, 20);
            this.firstNameTB.TabIndex = 6;
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Enabled = false;
            this.SexLabel.Location = new System.Drawing.Point(33, 180);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(33, 13);
            this.SexLabel.TabIndex = 5;
            this.SexLabel.Text = "Пол: ";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Enabled = false;
            this.AgeLabel.Location = new System.Drawing.Point(16, 154);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(50, 13);
            this.AgeLabel.TabIndex = 4;
            this.AgeLabel.Text = "Възраст";
            // 
            // EGNLabel
            // 
            this.EGNLabel.AutoSize = true;
            this.EGNLabel.Enabled = false;
            this.EGNLabel.Location = new System.Drawing.Point(32, 128);
            this.EGNLabel.Name = "EGNLabel";
            this.EGNLabel.Size = new System.Drawing.Size(34, 13);
            this.EGNLabel.TabIndex = 3;
            this.EGNLabel.Text = "ЕГН: ";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Enabled = false;
            this.lastNameLabel.Location = new System.Drawing.Point(11, 104);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Фамилия:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Enabled = false;
            this.firstNameLabel.Location = new System.Drawing.Point(34, 78);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(32, 13);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "Име:";
            // 
            // TypeOfClientGroupBox
            // 
            this.TypeOfClientGroupBox.Controls.Add(this.NewCompanyRadioBtn);
            this.TypeOfClientGroupBox.Controls.Add(this.NewIndividualRadioBtn);
            this.TypeOfClientGroupBox.Location = new System.Drawing.Point(7, 20);
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
            this.NewCompanyRadioBtn.CheckedChanged += new System.EventHandler(this.NewCompanyRadioBtn_CheckedChanged);
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
            // CreateNewBtn
            // 
            this.CreateNewBtn.Location = new System.Drawing.Point(31, 263);
            this.CreateNewBtn.Name = "CreateNewBtn";
            this.CreateNewBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateNewBtn.TabIndex = 4;
            this.CreateNewBtn.Text = "Създай";
            this.CreateNewBtn.UseVisualStyleBackColor = true;
            this.CreateNewBtn.Click += new System.EventHandler(this.CreateNewBtn_Click);
            // 
            // ClearAllBtn
            // 
            this.ClearAllBtn.Location = new System.Drawing.Point(112, 263);
            this.ClearAllBtn.Name = "ClearAllBtn";
            this.ClearAllBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearAllBtn.TabIndex = 5;
            this.ClearAllBtn.Text = "Изчисти";
            this.ClearAllBtn.UseVisualStyleBackColor = true;
            this.ClearAllBtn.Click += new System.EventHandler(this.ClearAllBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Отказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notANumberError
            // 
            this.notANumberError.ContainerControl = this;
            // 
            // CreateNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 299);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClearAllBtn);
            this.Controls.Add(this.CreateNewBtn);
            this.Controls.Add(this.NewClientGroupBox);
            this.Controls.Add(this.NewAccGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateNewAccount";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Създаване на нова сметка";
            this.NewAccGroupBox.ResumeLayout(false);
            this.NewAccGroupBox.PerformLayout();
            this.ClientGroupBox.ResumeLayout(false);
            this.ClientGroupBox.PerformLayout();
            this.TypeOfAccGroupBox.ResumeLayout(false);
            this.TypeOfAccGroupBox.PerformLayout();
            this.NewClientGroupBox.ResumeLayout(false);
            this.NewClientGroupBox.PerformLayout();
            this.TypeOfClientGroupBox.ResumeLayout(false);
            this.TypeOfClientGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notANumberError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NewAccGroupBox;
        private System.Windows.Forms.TextBox PeriodTB;
        private System.Windows.Forms.Label Interest;
        private System.Windows.Forms.TextBox InterestTB;
        private System.Windows.Forms.Label InterestLabel;
        private System.Windows.Forms.TextBox BalanceTB;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.GroupBox ClientGroupBox;
        private System.Windows.Forms.ComboBox ExistingClientComboBox;
        private System.Windows.Forms.RadioButton ExistingClientRadioBtn;
        private System.Windows.Forms.RadioButton NewClientRadioBtn;
        private System.Windows.Forms.GroupBox TypeOfAccGroupBox;
        private System.Windows.Forms.RadioButton DepositRadioBtn;
        private System.Windows.Forms.RadioButton LoanRadioBtn;
        private System.Windows.Forms.RadioButton MortgageRadioBtn;
        private System.Windows.Forms.GroupBox NewClientGroupBox;
        private System.Windows.Forms.TextBox eikTB;
        private System.Windows.Forms.TextBox companyNameTB;
        private System.Windows.Forms.Label EIKLabel;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.TextBox egnTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label EGNLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.GroupBox TypeOfClientGroupBox;
        private System.Windows.Forms.RadioButton NewCompanyRadioBtn;
        private System.Windows.Forms.RadioButton NewIndividualRadioBtn;
        private System.Windows.Forms.Button CreateNewBtn;
        private System.Windows.Forms.Button ClearAllBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.ErrorProvider notANumberError;

    }
}