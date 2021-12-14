
namespace HotelManager.Forms.AdministratorForms
{
    partial class AddNewEmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.HotelComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.SurnameTxtBox = new System.Windows.Forms.TextBox();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AddNewEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel";
            // 
            // HotelComboBox
            // 
            this.HotelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HotelComboBox.FormattingEnabled = true;
            this.HotelComboBox.Location = new System.Drawing.Point(154, 254);
            this.HotelComboBox.Name = "HotelComboBox";
            this.HotelComboBox.Size = new System.Drawing.Size(151, 28);
            this.HotelComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pozicija";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sifra";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(154, 45);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(125, 27);
            this.NameTxtBox.TabIndex = 7;
            // 
            // SurnameTxtBox
            // 
            this.SurnameTxtBox.Location = new System.Drawing.Point(171, 100);
            this.SurnameTxtBox.Name = "SurnameTxtBox";
            this.SurnameTxtBox.Size = new System.Drawing.Size(125, 27);
            this.SurnameTxtBox.TabIndex = 8;
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(180, 166);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(125, 27);
            this.EmailTxtBox.TabIndex = 9;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(180, 221);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '*';
            this.PasswordTxtBox.Size = new System.Drawing.Size(125, 27);
            this.PasswordTxtBox.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Recepcionar",
            "Majstor",
            "Sobarica"});
            this.comboBox1.Location = new System.Drawing.Point(154, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // AddNewEmployee
            // 
            this.AddNewEmployee.Location = new System.Drawing.Point(117, 321);
            this.AddNewEmployee.Name = "AddNewEmployee";
            this.AddNewEmployee.Size = new System.Drawing.Size(94, 29);
            this.AddNewEmployee.TabIndex = 12;
            this.AddNewEmployee.Text = "Dodaj";
            this.AddNewEmployee.UseVisualStyleBackColor = true;
            this.AddNewEmployee.Click += new System.EventHandler(this.AddNewEmployee_Click);
            // 
            // AddNewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddNewEmployee);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.SurnameTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HotelComboBox);
            this.Controls.Add(this.label1);
            this.Name = "AddNewEmployeeForm";
            this.Text = "AddNewEmployeeForm";
            this.Load += new System.EventHandler(this.AddNewEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HotelComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox SurnameTxtBox;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AddNewEmployee;
    }
}