namespace WarehouseManagerPiotrek.WinFormsApp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseNewDataSet = new WarehouseManagerPiotrek.WinFormsApp.DatabaseNewDataSet();
            this.employeeTableAdapter = new WarehouseManagerPiotrek.WinFormsApp.DatabaseNewDataSetTableAdapters.EmployeeTableAdapter();
            this.txtBoxMobilePhone = new System.Windows.Forms.TextBox();
            this.txtBoxOfficePhone = new System.Windows.Forms.TextBox();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.txtBoxPosition = new System.Windows.Forms.TextBox();
            this.lblMobilePhone = new System.Windows.Forms.Label();
            this.lblOfficePhone = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.buttAddEmp = new System.Windows.Forms.Button();
            this.butEditEmp = new System.Windows.Forms.Button();
            this.buttDeleteEmp = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblSallary = new System.Windows.Forms.Label();
            this.txtBoxSallary = new System.Windows.Forms.TextBox();
            this.lblEmploymentDate = new System.Windows.Forms.Label();
            this.txtBoxEmploymentDate = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseNewDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.databaseNewDataSet;
            // 
            // databaseNewDataSet
            // 
            this.databaseNewDataSet.DataSetName = "DatabaseNewDataSet";
            this.databaseNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // txtBoxMobilePhone
            // 
            this.txtBoxMobilePhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "PhoneMobile", true));
            this.txtBoxMobilePhone.Location = new System.Drawing.Point(292, 43);
            this.txtBoxMobilePhone.Name = "txtBoxMobilePhone";
            this.txtBoxMobilePhone.Size = new System.Drawing.Size(182, 20);
            this.txtBoxMobilePhone.TabIndex = 1;
            // 
            // txtBoxOfficePhone
            // 
            this.txtBoxOfficePhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "OfficeMobile", true));
            this.txtBoxOfficePhone.Location = new System.Drawing.Point(292, 92);
            this.txtBoxOfficePhone.Name = "txtBoxOfficePhone";
            this.txtBoxOfficePhone.Size = new System.Drawing.Size(182, 20);
            this.txtBoxOfficePhone.TabIndex = 2;
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Mail", true));
            this.txtBoxMail.Location = new System.Drawing.Point(292, 141);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(182, 20);
            this.txtBoxMail.TabIndex = 3;
            // 
            // txtBoxPosition
            // 
            this.txtBoxPosition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Position", true));
            this.txtBoxPosition.Location = new System.Drawing.Point(292, 190);
            this.txtBoxPosition.Name = "txtBoxPosition";
            this.txtBoxPosition.Size = new System.Drawing.Size(182, 20);
            this.txtBoxPosition.TabIndex = 4;
            // 
            // lblMobilePhone
            // 
            this.lblMobilePhone.AutoSize = true;
            this.lblMobilePhone.Location = new System.Drawing.Point(289, 27);
            this.lblMobilePhone.Name = "lblMobilePhone";
            this.lblMobilePhone.Size = new System.Drawing.Size(83, 13);
            this.lblMobilePhone.TabIndex = 5;
            this.lblMobilePhone.Text = "Numer prywatny";
            // 
            // lblOfficePhone
            // 
            this.lblOfficePhone.AutoSize = true;
            this.lblOfficePhone.Location = new System.Drawing.Point(289, 76);
            this.lblOfficePhone.Name = "lblOfficePhone";
            this.lblOfficePhone.Size = new System.Drawing.Size(86, 13);
            this.lblOfficePhone.TabIndex = 6;
            this.lblOfficePhone.Text = "Numer służbowy";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(289, 125);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Mail";
            // 
            // buttAddEmp
            // 
            this.buttAddEmp.Location = new System.Drawing.Point(52, 416);
            this.buttAddEmp.Name = "buttAddEmp";
            this.buttAddEmp.Size = new System.Drawing.Size(104, 33);
            this.buttAddEmp.TabIndex = 8;
            this.buttAddEmp.Text = "Dodaj pracownika";
            this.buttAddEmp.UseVisualStyleBackColor = true;
            this.buttAddEmp.Click += new System.EventHandler(this.buttAddEmp_Click);
            // 
            // butEditEmp
            // 
            this.butEditEmp.Enabled = false;
            this.butEditEmp.Location = new System.Drawing.Point(214, 416);
            this.butEditEmp.Name = "butEditEmp";
            this.butEditEmp.Size = new System.Drawing.Size(104, 33);
            this.butEditEmp.TabIndex = 9;
            this.butEditEmp.Text = "Edytuj pracownika";
            this.butEditEmp.UseVisualStyleBackColor = true;
            // 
            // buttDeleteEmp
            // 
            this.buttDeleteEmp.Enabled = false;
            this.buttDeleteEmp.Location = new System.Drawing.Point(379, 416);
            this.buttDeleteEmp.Name = "buttDeleteEmp";
            this.buttDeleteEmp.Size = new System.Drawing.Size(104, 33);
            this.buttDeleteEmp.TabIndex = 10;
            this.buttDeleteEmp.Text = "Usuń pracownika";
            this.buttDeleteEmp.UseVisualStyleBackColor = true;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(289, 174);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(62, 13);
            this.lblPosition.TabIndex = 11;
            this.lblPosition.Text = "Stanowisko";
            // 
            // lblSallary
            // 
            this.lblSallary.AutoSize = true;
            this.lblSallary.Location = new System.Drawing.Point(289, 224);
            this.lblSallary.Name = "lblSallary";
            this.lblSallary.Size = new System.Drawing.Size(39, 13);
            this.lblSallary.TabIndex = 13;
            this.lblSallary.Text = "Pensja";
            // 
            // txtBoxSallary
            // 
            this.txtBoxSallary.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Sallary", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.txtBoxSallary.Location = new System.Drawing.Point(292, 240);
            this.txtBoxSallary.Name = "txtBoxSallary";
            this.txtBoxSallary.Size = new System.Drawing.Size(182, 20);
            this.txtBoxSallary.TabIndex = 12;
            // 
            // lblEmploymentDate
            // 
            this.lblEmploymentDate.AutoSize = true;
            this.lblEmploymentDate.Location = new System.Drawing.Point(289, 276);
            this.lblEmploymentDate.Name = "lblEmploymentDate";
            this.lblEmploymentDate.Size = new System.Drawing.Size(90, 13);
            this.lblEmploymentDate.TabIndex = 15;
            this.lblEmploymentDate.Text = "Data zatrudnienia";
            // 
            // txtBoxEmploymentDate
            // 
            this.txtBoxEmploymentDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmploymentDate", true));
            this.txtBoxEmploymentDate.Location = new System.Drawing.Point(292, 292);
            this.txtBoxEmploymentDate.Name = "txtBoxEmploymentDate";
            this.txtBoxEmploymentDate.Size = new System.Drawing.Size(182, 20);
            this.txtBoxEmploymentDate.TabIndex = 14;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(289, 324);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(34, 13);
            this.lblAddress.TabIndex = 17;
            this.lblAddress.Text = "Adres";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(292, 340);
            this.txtBoxAddress.Multiline = true;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(182, 54);
            this.txtBoxAddress.TabIndex = 16;
            // 
            // EmployeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 461);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.lblEmploymentDate);
            this.Controls.Add(this.txtBoxEmploymentDate);
            this.Controls.Add(this.lblSallary);
            this.Controls.Add(this.txtBoxSallary);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.buttDeleteEmp);
            this.Controls.Add(this.butEditEmp);
            this.Controls.Add(this.buttAddEmp);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblOfficePhone);
            this.Controls.Add(this.lblMobilePhone);
            this.Controls.Add(this.txtBoxPosition);
            this.Controls.Add(this.txtBoxMail);
            this.Controls.Add(this.txtBoxOfficePhone);
            this.Controls.Add(this.txtBoxMobilePhone);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmployeeManager";
            this.Text = "Pracownicy";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseNewDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseNewDataSet databaseNewDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DatabaseNewDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtBoxMobilePhone;
        private System.Windows.Forms.TextBox txtBoxOfficePhone;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.TextBox txtBoxPosition;
        private System.Windows.Forms.Label lblMobilePhone;
        private System.Windows.Forms.Label lblOfficePhone;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button buttAddEmp;
        private System.Windows.Forms.Button butEditEmp;
        private System.Windows.Forms.Button buttDeleteEmp;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblSallary;
        private System.Windows.Forms.TextBox txtBoxSallary;
        private System.Windows.Forms.Label lblEmploymentDate;
        private System.Windows.Forms.TextBox txtBoxEmploymentDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtBoxAddress;
    }
}

