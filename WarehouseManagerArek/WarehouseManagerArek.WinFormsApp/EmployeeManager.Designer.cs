namespace WarehouseManagerArek.WinFormsApp
{
    partial class EmployeeManager
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
            this.dataGridViewEmployeeName = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.labelPhoneMobile = new System.Windows.Forms.Label();
            this.textBoxPhoneMobile = new System.Windows.Forms.TextBox();
            this.labelPhoneOffice = new System.Windows.Forms.Label();
            this.textBoxPhoneOffice = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.labelEmploymentDate = new System.Windows.Forms.Label();
            this.textBoxEmploymentDate = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployeeName
            // 
            this.dataGridViewEmployeeName.AccessibleName = "";
            this.dataGridViewEmployeeName.AllowUserToDeleteRows = false;
            this.dataGridViewEmployeeName.AutoGenerateColumns = false;
            this.dataGridViewEmployeeName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName});
            this.dataGridViewEmployeeName.DataSource = this.employeeBindingSource;
            this.dataGridViewEmployeeName.Location = new System.Drawing.Point(12, 29);
            this.dataGridViewEmployeeName.Name = "dataGridViewEmployeeName";
            this.dataGridViewEmployeeName.ReadOnly = true;
            this.dataGridViewEmployeeName.Size = new System.Drawing.Size(295, 294);
            this.dataGridViewEmployeeName.TabIndex = 0;
            this.dataGridViewEmployeeName.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployeeName_CellContentClick);
            this.dataGridViewEmployeeName.SelectionChanged += new System.EventHandler(this.dataGridViewEmployeeName_SelectionChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(WarehouseManagerArek.Models.Employee);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(70, 377);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(117, 40);
            this.buttonAddEmployee.TabIndex = 1;
            this.buttonAddEmployee.Text = "Dodaj pracownika";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.Enabled = false;
            this.buttonEditEmployee.Location = new System.Drawing.Point(229, 377);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(117, 40);
            this.buttonEditEmployee.TabIndex = 2;
            this.buttonEditEmployee.Text = "Edytuj pracownika";
            this.buttonEditEmployee.UseVisualStyleBackColor = true;
            this.buttonEditEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Enabled = false;
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(394, 377);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(117, 40);
            this.buttonDeleteEmployee.TabIndex = 3;
            this.buttonDeleteEmployee.Text = "Usuń pracownika z bazy";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            // 
            // labelPhoneMobile
            // 
            this.labelPhoneMobile.AutoSize = true;
            this.labelPhoneMobile.Location = new System.Drawing.Point(328, 13);
            this.labelPhoneMobile.Name = "labelPhoneMobile";
            this.labelPhoneMobile.Size = new System.Drawing.Size(83, 13);
            this.labelPhoneMobile.TabIndex = 4;
            this.labelPhoneMobile.Text = "Numer prywatny";
            // 
            // textBoxPhoneMobile
            // 
            this.textBoxPhoneMobile.Location = new System.Drawing.Point(331, 29);
            this.textBoxPhoneMobile.Name = "textBoxPhoneMobile";
            this.textBoxPhoneMobile.ReadOnly = true;
            this.textBoxPhoneMobile.Size = new System.Drawing.Size(192, 20);
            this.textBoxPhoneMobile.TabIndex = 5;
            // 
            // labelPhoneOffice
            // 
            this.labelPhoneOffice.AutoSize = true;
            this.labelPhoneOffice.Location = new System.Drawing.Point(328, 52);
            this.labelPhoneOffice.Name = "labelPhoneOffice";
            this.labelPhoneOffice.Size = new System.Drawing.Size(86, 13);
            this.labelPhoneOffice.TabIndex = 6;
            this.labelPhoneOffice.Text = "Numer służbowy";
            // 
            // textBoxPhoneOffice
            // 
            this.textBoxPhoneOffice.Location = new System.Drawing.Point(331, 68);
            this.textBoxPhoneOffice.Name = "textBoxPhoneOffice";
            this.textBoxPhoneOffice.ReadOnly = true;
            this.textBoxPhoneOffice.Size = new System.Drawing.Size(192, 20);
            this.textBoxPhoneOffice.TabIndex = 7;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(328, 91);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 8;
            this.labelMail.Text = "Mail";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(331, 107);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.ReadOnly = true;
            this.textBoxMail.Size = new System.Drawing.Size(192, 20);
            this.textBoxMail.TabIndex = 9;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(328, 130);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(62, 13);
            this.labelPosition.TabIndex = 10;
            this.labelPosition.Text = "Stanowisko";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(331, 146);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.ReadOnly = true;
            this.textBoxPosition.Size = new System.Drawing.Size(192, 20);
            this.textBoxPosition.TabIndex = 11;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(328, 169);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(39, 13);
            this.labelSalary.TabIndex = 12;
            this.labelSalary.Text = "Pensja";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(331, 185);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.ReadOnly = true;
            this.textBoxSalary.Size = new System.Drawing.Size(192, 20);
            this.textBoxSalary.TabIndex = 13;
            // 
            // labelEmploymentDate
            // 
            this.labelEmploymentDate.AutoSize = true;
            this.labelEmploymentDate.Location = new System.Drawing.Point(328, 208);
            this.labelEmploymentDate.Name = "labelEmploymentDate";
            this.labelEmploymentDate.Size = new System.Drawing.Size(90, 13);
            this.labelEmploymentDate.TabIndex = 14;
            this.labelEmploymentDate.Text = "Data zatrudnienia";
            // 
            // textBoxEmploymentDate
            // 
            this.textBoxEmploymentDate.Location = new System.Drawing.Point(331, 224);
            this.textBoxEmploymentDate.Name = "textBoxEmploymentDate";
            this.textBoxEmploymentDate.ReadOnly = true;
            this.textBoxEmploymentDate.Size = new System.Drawing.Size(192, 20);
            this.textBoxEmploymentDate.TabIndex = 15;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(328, 247);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(34, 13);
            this.labelAddress.TabIndex = 16;
            this.labelAddress.Text = "Adres";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 264);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(192, 59);
            this.textBox1.TabIndex = 17;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Imie";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Nazwisko";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // EmployeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 443);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxEmploymentDate);
            this.Controls.Add(this.labelEmploymentDate);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textBoxPhoneOffice);
            this.Controls.Add(this.labelPhoneOffice);
            this.Controls.Add(this.textBoxPhoneMobile);
            this.Controls.Add(this.labelPhoneMobile);
            this.Controls.Add(this.buttonDeleteEmployee);
            this.Controls.Add(this.buttonEditEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.dataGridViewEmployeeName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeManager";
            this.Load += new System.EventHandler(this.EmployeeManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployeeName;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonEditEmployee;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Label labelPhoneMobile;
        private System.Windows.Forms.TextBox textBoxPhoneMobile;
        private System.Windows.Forms.Label labelPhoneOffice;
        private System.Windows.Forms.TextBox textBoxPhoneOffice;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label labelEmploymentDate;
        private System.Windows.Forms.TextBox textBoxEmploymentDate;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
    }
}