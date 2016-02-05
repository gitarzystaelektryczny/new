namespace Zadanie1Piotrek.FormsApp
{
    partial class AddPersonForm
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
            this.lblDodajOsobe = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPesel = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.lblNotEmpty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDodajOsobe
            // 
            this.lblDodajOsobe.AutoSize = true;
            this.lblDodajOsobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDodajOsobe.Location = new System.Drawing.Point(32, 9);
            this.lblDodajOsobe.Name = "lblDodajOsobe";
            this.lblDodajOsobe.Size = new System.Drawing.Size(99, 20);
            this.lblDodajOsobe.TabIndex = 0;
            this.lblDodajOsobe.Text = "Dodaj osobę";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(33, 69);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(26, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Imię";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(33, 113);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(53, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Nazwisko";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(33, 154);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 13);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Wiek";
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Location = new System.Drawing.Point(33, 193);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(33, 13);
            this.lblPesel.TabIndex = 4;
            this.lblPesel.Text = "Pesel";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(36, 85);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(111, 20);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(36, 131);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(111, 20);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(36, 170);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(111, 20);
            this.txtAge.TabIndex = 7;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // txtPesel
            // 
            this.txtPesel.Location = new System.Drawing.Point(36, 209);
            this.txtPesel.MaxLength = 11;
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(111, 20);
            this.txtPesel.TabIndex = 8;
            this.txtPesel.TextChanged += new System.EventHandler(this.txtPesel_TextChanged);
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(210, 233);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(75, 23);
            this.AddPersonButton.TabIndex = 9;
            this.AddPersonButton.Text = "Dodaj";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // lblNotEmpty
            // 
            this.lblNotEmpty.AutoSize = true;
            this.lblNotEmpty.Location = new System.Drawing.Point(185, 259);
            this.lblNotEmpty.Name = "lblNotEmpty";
            this.lblNotEmpty.Size = new System.Drawing.Size(123, 13);
            this.lblNotEmpty.TabIndex = 10;
            this.lblNotEmpty.Text = "Uzupełnij wszystkie pola";
            this.lblNotEmpty.Visible = false;
            // 
            // AddPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 281);
            this.Controls.Add(this.lblNotEmpty);
            this.Controls.Add(this.AddPersonButton);
            this.Controls.Add(this.txtPesel);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblPesel);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblDodajOsobe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddPersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie nowej osoby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDodajOsobe;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPesel;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.Label lblNotEmpty;
    }
}