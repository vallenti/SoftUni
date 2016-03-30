namespace BankAccountsNamespace
{
    partial class AccountsList
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TypeOfAccGroupBox = new System.Windows.Forms.GroupBox();
            this.DepositRadioBtn = new System.Windows.Forms.RadioButton();
            this.LoanRadioBtn = new System.Windows.Forms.RadioButton();
            this.MortgageRadioBtn = new System.Windows.Forms.RadioButton();
            this.NewCompanyRadioBtn = new System.Windows.Forms.RadioButton();
            this.NewIndividualRadioBtn = new System.Windows.Forms.RadioButton();
            this.TypeOfClientGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.someCliendIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TypeOfAccGroupBox.SuspendLayout();
            this.TypeOfClientGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Покажи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ibanDataGridViewTextBoxColumn,
            this.someCliendIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientTypeDataGridViewTextBoxColumn,
            this.accountTypeDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.interestDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accountBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(786, 265);
            this.dataGridView1.TabIndex = 2;
            // 
            // TypeOfAccGroupBox
            // 
            this.TypeOfAccGroupBox.Controls.Add(this.DepositRadioBtn);
            this.TypeOfAccGroupBox.Controls.Add(this.LoanRadioBtn);
            this.TypeOfAccGroupBox.Controls.Add(this.MortgageRadioBtn);
            this.TypeOfAccGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TypeOfAccGroupBox.Name = "TypeOfAccGroupBox";
            this.TypeOfAccGroupBox.Size = new System.Drawing.Size(258, 52);
            this.TypeOfAccGroupBox.TabIndex = 3;
            this.TypeOfAccGroupBox.TabStop = false;
            this.TypeOfAccGroupBox.Text = "Тип на сметката";
            // 
            // DepositRadioBtn
            // 
            this.DepositRadioBtn.AutoSize = true;
            this.DepositRadioBtn.Location = new System.Drawing.Point(6, 20);
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
            this.LoanRadioBtn.Location = new System.Drawing.Point(81, 21);
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
            this.MortgageRadioBtn.Location = new System.Drawing.Point(141, 20);
            this.MortgageRadioBtn.Name = "MortgageRadioBtn";
            this.MortgageRadioBtn.Size = new System.Drawing.Size(111, 17);
            this.MortgageRadioBtn.TabIndex = 3;
            this.MortgageRadioBtn.TabStop = true;
            this.MortgageRadioBtn.Text = "Ипотечен кредит";
            this.MortgageRadioBtn.UseVisualStyleBackColor = true;
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
            // 
            // TypeOfClientGroupBox
            // 
            this.TypeOfClientGroupBox.Controls.Add(this.NewCompanyRadioBtn);
            this.TypeOfClientGroupBox.Controls.Add(this.NewIndividualRadioBtn);
            this.TypeOfClientGroupBox.Location = new System.Drawing.Point(276, 13);
            this.TypeOfClientGroupBox.Name = "TypeOfClientGroupBox";
            this.TypeOfClientGroupBox.Size = new System.Drawing.Size(193, 51);
            this.TypeOfClientGroupBox.TabIndex = 4;
            this.TypeOfClientGroupBox.TabStop = false;
            this.TypeOfClientGroupBox.Text = "Тип клиент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сума над: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 78);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ЕГН: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 104);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 20);
            this.textBox2.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Търси";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(394, 102);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 10;
            this.ClearBtn.Text = "Изчисти";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(BankAccountsNamespace.Account);
            // 
            // interestDataGridViewTextBoxColumn
            // 
            this.interestDataGridViewTextBoxColumn.DataPropertyName = "Interest";
            this.interestDataGridViewTextBoxColumn.FillWeight = 21.91202F;
            this.interestDataGridViewTextBoxColumn.HeaderText = "Лихва";
            this.interestDataGridViewTextBoxColumn.Name = "interestDataGridViewTextBoxColumn";
            this.interestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.FillWeight = 21.91202F;
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Наличност";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountTypeDataGridViewTextBoxColumn
            // 
            this.accountTypeDataGridViewTextBoxColumn.DataPropertyName = "AccountType";
            this.accountTypeDataGridViewTextBoxColumn.FillWeight = 21.91202F;
            this.accountTypeDataGridViewTextBoxColumn.HeaderText = "Вид сметка";
            this.accountTypeDataGridViewTextBoxColumn.Name = "accountTypeDataGridViewTextBoxColumn";
            this.accountTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientTypeDataGridViewTextBoxColumn
            // 
            this.clientTypeDataGridViewTextBoxColumn.DataPropertyName = "ClientType";
            this.clientTypeDataGridViewTextBoxColumn.FillWeight = 21.91202F;
            this.clientTypeDataGridViewTextBoxColumn.HeaderText = "Вид клиент";
            this.clientTypeDataGridViewTextBoxColumn.Name = "clientTypeDataGridViewTextBoxColumn";
            this.clientTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.FillWeight = 21.91202F;
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Име";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // someCliendIDDataGridViewTextBoxColumn
            // 
            this.someCliendIDDataGridViewTextBoxColumn.DataPropertyName = "SomeCliendID";
            this.someCliendIDDataGridViewTextBoxColumn.FillWeight = 21.91202F;
            this.someCliendIDDataGridViewTextBoxColumn.HeaderText = "ЕГН/ЕИК";
            this.someCliendIDDataGridViewTextBoxColumn.Name = "someCliendIDDataGridViewTextBoxColumn";
            this.someCliendIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ibanDataGridViewTextBoxColumn
            // 
            this.ibanDataGridViewTextBoxColumn.DataPropertyName = "Iban";
            this.ibanDataGridViewTextBoxColumn.FillWeight = 568.5279F;
            this.ibanDataGridViewTextBoxColumn.HeaderText = "IBAN";
            this.ibanDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.ibanDataGridViewTextBoxColumn.Name = "ibanDataGridViewTextBoxColumn";
            this.ibanDataGridViewTextBoxColumn.ReadOnly = true;
            this.ibanDataGridViewTextBoxColumn.Width = 160;
            // 
            // AccountsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 509);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeOfClientGroupBox);
            this.Controls.Add(this.TypeOfAccGroupBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "AccountsList";
            this.Text = "Списък сметки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TypeOfAccGroupBox.ResumeLayout(false);
            this.TypeOfAccGroupBox.PerformLayout();
            this.TypeOfClientGroupBox.ResumeLayout(false);
            this.TypeOfClientGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox TypeOfAccGroupBox;
        private System.Windows.Forms.RadioButton DepositRadioBtn;
        private System.Windows.Forms.RadioButton LoanRadioBtn;
        private System.Windows.Forms.RadioButton MortgageRadioBtn;
        private System.Windows.Forms.RadioButton NewCompanyRadioBtn;
        private System.Windows.Forms.RadioButton NewIndividualRadioBtn;
        private System.Windows.Forms.GroupBox TypeOfClientGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ibanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn someCliendIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountBindingSource;





    }
}