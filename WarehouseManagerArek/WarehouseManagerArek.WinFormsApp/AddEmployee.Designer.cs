namespace WarehouseManagerArek.WinFormsApp
{
    partial class AddEmployee
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
            this.labelAddEmplFirstName = new System.Windows.Forms.Label();
            this.textBoxAddEmplFirstName = new System.Windows.Forms.TextBox();
            this.labelAddEmplLastName = new System.Windows.Forms.Label();
            this.labelAddEmplPhoneMobile = new System.Windows.Forms.Label();
            this.labelAddEmplPhoneOffice = new System.Windows.Forms.Label();
            this.labelAddEmplMail = new System.Windows.Forms.Label();
            this.textBoxAddEmplLastName = new System.Windows.Forms.TextBox();
            this.textBoxAddEmplMobilePhone = new System.Windows.Forms.TextBox();
            this.textBoxAddEmplMail = new System.Windows.Forms.TextBox();
            this.textBoxAddEmplPosition = new System.Windows.Forms.TextBox();
            this.textBoxAddEmplSalary = new System.Windows.Forms.TextBox();
            this.textBoxAddEmplOfficePhone = new System.Windows.Forms.TextBox();
            this.labelAddEmplPosition = new System.Windows.Forms.Label();
            this.labelAddEmplSalary = new System.Windows.Forms.Label();
            this.labelAddEmplEmploymentDate = new System.Windows.Forms.Label();
            this.buttonAddNewEmployee = new System.Windows.Forms.Button();
            this.dateTimePickerAddEmplEmploymentDate = new System.Windows.Forms.DateTimePicker();
            this.labelMobilePhone = new System.Windows.Forms.Label();
            this.labelOfficePhone = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAddEmplFirstName
            // 
            this.labelAddEmplFirstName.AutoSize = true;
            this.labelAddEmplFirstName.Location = new System.Drawing.Point(81, 24);
            this.labelAddEmplFirstName.Name = "labelAddEmplFirstName";
            this.labelAddEmplFirstName.Size = new System.Drawing.Size(26, 13);
            this.labelAddEmplFirstName.TabIndex = 0;
            this.labelAddEmplFirstName.Text = "Imię";
            // 
            // textBoxAddEmplFirstName
            // 
            this.textBoxAddEmplFirstName.Location = new System.Drawing.Point(173, 24);
            this.textBoxAddEmplFirstName.Name = "textBoxAddEmplFirstName";
            this.textBoxAddEmplFirstName.Size = new System.Drawing.Size(142, 20);
            this.textBoxAddEmplFirstName.TabIndex = 1;
            this.textBoxAddEmplFirstName.TextChanged += new System.EventHandler(this.textBoxAddEmplFirstName_TextChanged);
            // 
            // labelAddEmplLastName
            // 
            this.labelAddEmplLastName.AutoSize = true;
            this.labelAddEmplLastName.Location = new System.Drawing.Point(81, 59);
            this.labelAddEmplLastName.Name = "labelAddEmplLastName";
            this.labelAddEmplLastName.Size = new System.Drawing.Size(53, 13);
            this.labelAddEmplLastName.TabIndex = 2;
            this.labelAddEmplLastName.Text = "Nazwisko";
            // 
            // labelAddEmplPhoneMobile
            // 
            this.labelAddEmplPhoneMobile.AutoSize = true;
            this.labelAddEmplPhoneMobile.Location = new System.Drawing.Point(81, 94);
            this.labelAddEmplPhoneMobile.Name = "labelAddEmplPhoneMobile";
            this.labelAddEmplPhoneMobile.Size = new System.Drawing.Size(83, 13);
            this.labelAddEmplPhoneMobile.TabIndex = 3;
            this.labelAddEmplPhoneMobile.Text = "Numer prywatny";
            // 
            // labelAddEmplPhoneOffice
            // 
            this.labelAddEmplPhoneOffice.AutoSize = true;
            this.labelAddEmplPhoneOffice.Location = new System.Drawing.Point(81, 129);
            this.labelAddEmplPhoneOffice.Name = "labelAddEmplPhoneOffice";
            this.labelAddEmplPhoneOffice.Size = new System.Drawing.Size(86, 13);
            this.labelAddEmplPhoneOffice.TabIndex = 4;
            this.labelAddEmplPhoneOffice.Text = "Numer służbowy";
            // 
            // labelAddEmplMail
            // 
            this.labelAddEmplMail.AutoSize = true;
            this.labelAddEmplMail.Location = new System.Drawing.Point(81, 162);
            this.labelAddEmplMail.Name = "labelAddEmplMail";
            this.labelAddEmplMail.Size = new System.Drawing.Size(26, 13);
            this.labelAddEmplMail.TabIndex = 5;
            this.labelAddEmplMail.Text = "Mail";
            // 
            // textBoxAddEmplLastName
            // 
            this.textBoxAddEmplLastName.Location = new System.Drawing.Point(173, 59);
            this.textBoxAddEmplLastName.Name = "textBoxAddEmplLastName";
            this.textBoxAddEmplLastName.Size = new System.Drawing.Size(142, 20);
            this.textBoxAddEmplLastName.TabIndex = 2;
            this.textBoxAddEmplLastName.TextChanged += new System.EventHandler(this.textBoxAddEmplLastName_TextChanged);
            // 
            // textBoxAddEmplMobilePhone
            // 
            this.textBoxAddEmplMobilePhone.Location = new System.Drawing.Point(173, 94);
            this.textBoxAddEmplMobilePhone.Name = "textBoxAddEmplMobilePhone";
            this.textBoxAddEmplMobilePhone.Size = new System.Drawing.Size(142, 20);
            this.textBoxAddEmplMobilePhone.TabIndex = 3;
            this.textBoxAddEmplMobilePhone.TextChanged += new System.EventHandler(this.textBoxAddEmplMobilePhone_TextChanged);
            // 
            // textBoxAddEmplMail
            // 
            this.textBoxAddEmplMail.Location = new System.Drawing.Point(173, 162);
            this.textBoxAddEmplMail.Name = "textBoxAddEmplMail";
            this.textBoxAddEmplMail.Size = new System.Drawing.Size(142, 20);
            this.textBoxAddEmplMail.TabIndex = 5;
            this.textBoxAddEmplMail.TextChanged += new System.EventHandler(this.textBoxAddEmplMail_TextChanged);
            // 
            // textBoxAddEmplPosition
            // 
            this.textBoxAddEmplPosition.Location = new System.Drawing.Point(173, 194);
            this.textBoxAddEmplPosition.Name = "textBoxAddEmplPosition";
            this.textBoxAddEmplPosition.Size = new System.Drawing.Size(142, 20);
            this.textBoxAddEmplPosition.TabIndex = 6;
            this.textBoxAddEmplPosition.TextChanged += new System.EventHandler(this.textBoxAddEmplPosition_TextChanged);
            // 
            // textBoxAddEmplSalary
            // 
            this.textBoxAddEmplSalary.Location = new System.Drawing.Point(173, 227);
            this.textBoxAddEmplSalary.Name = "textBoxAddEmplSalary";
            this.textBoxAddEmplSalary.Size = new System.Drawing.Size(142, 20);
            this.textBoxAddEmplSalary.TabIndex = 7;
            this.textBoxAddEmplSalary.TextChanged += new System.EventHandler(this.textBoxAddEmplSalary_TextChanged);
            // 
            // textBoxAddEmplOfficePhone
            // 
            this.textBoxAddEmplOfficePhone.Location = new System.Drawing.Point(173, 129);
            this.textBoxAddEmplOfficePhone.Name = "textBoxAddEmplOfficePhone";
            this.textBoxAddEmplOfficePhone.Size = new System.Drawing.Size(142, 20);
            this.textBoxAddEmplOfficePhone.TabIndex = 4;
            this.textBoxAddEmplOfficePhone.TextChanged += new System.EventHandler(this.textBoxAddEmplOfficePhone_TextChanged);
            // 
            // labelAddEmplPosition
            // 
            this.labelAddEmplPosition.AutoSize = true;
            this.labelAddEmplPosition.Location = new System.Drawing.Point(81, 194);
            this.labelAddEmplPosition.Name = "labelAddEmplPosition";
            this.labelAddEmplPosition.Size = new System.Drawing.Size(62, 13);
            this.labelAddEmplPosition.TabIndex = 12;
            this.labelAddEmplPosition.Text = "Stanowisko";
            // 
            // labelAddEmplSalary
            // 
            this.labelAddEmplSalary.AutoSize = true;
            this.labelAddEmplSalary.Location = new System.Drawing.Point(81, 227);
            this.labelAddEmplSalary.Name = "labelAddEmplSalary";
            this.labelAddEmplSalary.Size = new System.Drawing.Size(39, 13);
            this.labelAddEmplSalary.TabIndex = 13;
            this.labelAddEmplSalary.Text = "Pensja";
            // 
            // labelAddEmplEmploymentDate
            // 
            this.labelAddEmplEmploymentDate.AutoSize = true;
            this.labelAddEmplEmploymentDate.Location = new System.Drawing.Point(81, 261);
            this.labelAddEmplEmploymentDate.Name = "labelAddEmplEmploymentDate";
            this.labelAddEmplEmploymentDate.Size = new System.Drawing.Size(90, 13);
            this.labelAddEmplEmploymentDate.TabIndex = 14;
            this.labelAddEmplEmploymentDate.Text = "Data zatrudnienia";
            // 
            // buttonAddNewEmployee
            // 
            this.buttonAddNewEmployee.Location = new System.Drawing.Point(350, 309);
            this.buttonAddNewEmployee.Name = "buttonAddNewEmployee";
            this.buttonAddNewEmployee.Size = new System.Drawing.Size(101, 45);
            this.buttonAddNewEmployee.TabIndex = 9;
            this.buttonAddNewEmployee.Text = "DODAJ";
            this.buttonAddNewEmployee.UseVisualStyleBackColor = true;
            this.buttonAddNewEmployee.Click += new System.EventHandler(this.buttonAddNewEmployee_Click);
            // 
            // dateTimePickerAddEmplEmploymentDate
            // 
            this.dateTimePickerAddEmplEmploymentDate.Location = new System.Drawing.Point(173, 261);
            this.dateTimePickerAddEmplEmploymentDate.Name = "dateTimePickerAddEmplEmploymentDate";
            this.dateTimePickerAddEmplEmploymentDate.Size = new System.Drawing.Size(142, 20);
            this.dateTimePickerAddEmplEmploymentDate.TabIndex = 15;
            this.dateTimePickerAddEmplEmploymentDate.Value = new System.DateTime(2016, 3, 4, 13, 20, 0, 0);
            this.dateTimePickerAddEmplEmploymentDate.ValueChanged += new System.EventHandler(this.dateTimePickerAddEmplEmploymentDate_ValueChanged);
            // 
            // labelMobilePhone
            // 
            this.labelMobilePhone.AutoSize = true;
            this.labelMobilePhone.Location = new System.Drawing.Point(322, 100);
            this.labelMobilePhone.Name = "labelMobilePhone";
            this.labelMobilePhone.Size = new System.Drawing.Size(121, 13);
            this.labelMobilePhone.TabIndex = 16;
            this.labelMobilePhone.Text = "Podaj wartość liczbową!";
            this.labelMobilePhone.Visible = false;
            // 
            // labelOfficePhone
            // 
            this.labelOfficePhone.AutoSize = true;
            this.labelOfficePhone.Location = new System.Drawing.Point(321, 136);
            this.labelOfficePhone.Name = "labelOfficePhone";
            this.labelOfficePhone.Size = new System.Drawing.Size(121, 13);
            this.labelOfficePhone.TabIndex = 17;
            this.labelOfficePhone.Text = "Podaj wartość liczbową!";
            this.labelOfficePhone.Visible = false;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(321, 234);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(121, 13);
            this.labelSalary.TabIndex = 18;
            this.labelSalary.Text = "Podaj wartość liczbową!";
            this.labelSalary.Visible = false;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(501, 366);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelOfficePhone);
            this.Controls.Add(this.labelMobilePhone);
            this.Controls.Add(this.dateTimePickerAddEmplEmploymentDate);
            this.Controls.Add(this.buttonAddNewEmployee);
            this.Controls.Add(this.labelAddEmplEmploymentDate);
            this.Controls.Add(this.labelAddEmplSalary);
            this.Controls.Add(this.labelAddEmplPosition);
            this.Controls.Add(this.textBoxAddEmplOfficePhone);
            this.Controls.Add(this.textBoxAddEmplSalary);
            this.Controls.Add(this.textBoxAddEmplPosition);
            this.Controls.Add(this.textBoxAddEmplMail);
            this.Controls.Add(this.textBoxAddEmplMobilePhone);
            this.Controls.Add(this.textBoxAddEmplLastName);
            this.Controls.Add(this.labelAddEmplMail);
            this.Controls.Add(this.labelAddEmplPhoneOffice);
            this.Controls.Add(this.labelAddEmplPhoneMobile);
            this.Controls.Add(this.labelAddEmplLastName);
            this.Controls.Add(this.textBoxAddEmplFirstName);
            this.Controls.Add(this.labelAddEmplFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj nowego pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddEmplFirstName;
        private System.Windows.Forms.TextBox textBoxAddEmplFirstName;
        private System.Windows.Forms.Label labelAddEmplLastName;
        private System.Windows.Forms.Label labelAddEmplPhoneMobile;
        private System.Windows.Forms.Label labelAddEmplPhoneOffice;
        private System.Windows.Forms.Label labelAddEmplMail;
        private System.Windows.Forms.TextBox textBoxAddEmplLastName;
        private System.Windows.Forms.TextBox textBoxAddEmplMobilePhone;
        private System.Windows.Forms.TextBox textBoxAddEmplMail;
        private System.Windows.Forms.TextBox textBoxAddEmplPosition;
        private System.Windows.Forms.TextBox textBoxAddEmplSalary;
        private System.Windows.Forms.TextBox textBoxAddEmplOfficePhone;
        private System.Windows.Forms.Label labelAddEmplPosition;
        private System.Windows.Forms.Label labelAddEmplSalary;
        private System.Windows.Forms.Label labelAddEmplEmploymentDate;
        private System.Windows.Forms.Button buttonAddNewEmployee;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddEmplEmploymentDate;
        private System.Windows.Forms.Label labelMobilePhone;
        private System.Windows.Forms.Label labelOfficePhone;
        private System.Windows.Forms.Label labelSalary;
    }
}