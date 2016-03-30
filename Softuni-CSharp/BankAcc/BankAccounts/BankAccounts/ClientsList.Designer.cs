namespace BankAccountsNamespace
{
    partial class ClientsList
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
            this.TypeOfClientGroupBox = new System.Windows.Forms.GroupBox();
            this.NewCompanyRadioBtn = new System.Windows.Forms.RadioButton();
            this.NewIndividualRadioBtn = new System.Windows.Forms.RadioButton();
            this.listOfClientsDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.listofComapniesDGV = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depositAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TypeOfClientGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfClientsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listofComapniesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositAccountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeOfClientGroupBox
            // 
            this.TypeOfClientGroupBox.Controls.Add(this.NewCompanyRadioBtn);
            this.TypeOfClientGroupBox.Controls.Add(this.NewIndividualRadioBtn);
            this.TypeOfClientGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TypeOfClientGroupBox.Name = "TypeOfClientGroupBox";
            this.TypeOfClientGroupBox.Size = new System.Drawing.Size(193, 51);
            this.TypeOfClientGroupBox.TabIndex = 1;
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
            // 
            // listOfClientsDGV
            // 
            this.listOfClientsDGV.AutoGenerateColumns = false;
            this.listOfClientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfClientsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.egnDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn});
            this.listOfClientsDGV.DataSource = this.individualBindingSource;
            this.listOfClientsDGV.Location = new System.Drawing.Point(12, 69);
            this.listOfClientsDGV.Name = "listOfClientsDGV";
            this.listOfClientsDGV.RowHeadersVisible = false;
            this.listOfClientsDGV.Size = new System.Drawing.Size(520, 250);
            this.listOfClientsDGV.TabIndex = 2;
            this.listOfClientsDGV.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Покажи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listofComapniesDGV
            // 
            this.listofComapniesDGV.AutoGenerateColumns = false;
            this.listofComapniesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listofComapniesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.eikDataGridViewTextBoxColumn});
            this.listofComapniesDGV.DataSource = this.companyBindingSource;
            this.listofComapniesDGV.Location = new System.Drawing.Point(12, 69);
            this.listofComapniesDGV.Name = "listofComapniesDGV";
            this.listofComapniesDGV.RowHeadersVisible = false;
            this.listofComapniesDGV.Size = new System.Drawing.Size(221, 250);
            this.listofComapniesDGV.TabIndex = 4;
            this.listofComapniesDGV.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Име";
            this.nameDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // eikDataGridViewTextBoxColumn
            // 
            this.eikDataGridViewTextBoxColumn.DataPropertyName = "Eik";
            this.eikDataGridViewTextBoxColumn.HeaderText = "ЕИК";
            this.eikDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.eikDataGridViewTextBoxColumn.Name = "eikDataGridViewTextBoxColumn";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(BankAccountsNamespace.Company);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Име";
            this.firstNameDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastNameDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // egnDataGridViewTextBoxColumn
            // 
            this.egnDataGridViewTextBoxColumn.DataPropertyName = "Egn";
            this.egnDataGridViewTextBoxColumn.HeaderText = "ЕГН";
            this.egnDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.egnDataGridViewTextBoxColumn.Name = "egnDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Възраст";
            this.ageDataGridViewTextBoxColumn.MaxInputLength = 3;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // individualBindingSource
            // 
            this.individualBindingSource.DataSource = typeof(BankAccountsNamespace.Individual);
            // 
            // depositAccountBindingSource
            // 
            this.depositAccountBindingSource.DataSource = typeof(BankAccountsNamespace.DepositAccount);
            // 
            // ClientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 333);
            this.Controls.Add(this.listofComapniesDGV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listOfClientsDGV);
            this.Controls.Add(this.TypeOfClientGroupBox);
            this.Name = "ClientsList";
            this.Text = "Списък на клиентите";
            this.TypeOfClientGroupBox.ResumeLayout(false);
            this.TypeOfClientGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfClientsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listofComapniesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositAccountBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource depositAccountBindingSource;
        private System.Windows.Forms.GroupBox TypeOfClientGroupBox;
        private System.Windows.Forms.RadioButton NewCompanyRadioBtn;
        private System.Windows.Forms.RadioButton NewIndividualRadioBtn;
        private System.Windows.Forms.DataGridView listOfClientsDGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource individualBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView listofComapniesDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eikDataGridViewTextBoxColumn;
    }
}