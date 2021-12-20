
namespace HotelManager.Forms.Gosti
{
    partial class GostInformacije
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.personPictureBox = new System.Windows.Forms.PictureBox();
            this.changeReservation = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.checkInDate = new System.Windows.Forms.DateTimePicker();
            this.choosePictureBtn = new System.Windows.Forms.Button();
            this.PicturePathTextBox = new System.Windows.Forms.TextBox();
            this.DocumentIDTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.docTypeCmbBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 535);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 31);
            this.button2.TabIndex = 38;
            this.button2.Text = "ObrisiRezervaciju";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 535);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 31);
            this.button1.TabIndex = 37;
            this.button1.Text = "POKAZI RACUN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // personPictureBox
            // 
            this.personPictureBox.Location = new System.Drawing.Point(445, 89);
            this.personPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.personPictureBox.Name = "personPictureBox";
            this.personPictureBox.Size = new System.Drawing.Size(419, 236);
            this.personPictureBox.TabIndex = 36;
            this.personPictureBox.TabStop = false;
            // 
            // changeReservation
            // 
            this.changeReservation.Location = new System.Drawing.Point(165, 535);
            this.changeReservation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeReservation.Name = "changeReservation";
            this.changeReservation.Size = new System.Drawing.Size(86, 31);
            this.changeReservation.TabIndex = 35;
            this.changeReservation.Text = "Izmeni ";
            this.changeReservation.UseVisualStyleBackColor = true;
            this.changeReservation.Click += new System.EventHandler(this.changeReservation_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Check Out:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Check In: ";
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.Location = new System.Drawing.Point(165, 461);
            this.CheckOutDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.Size = new System.Drawing.Size(260, 27);
            this.CheckOutDate.TabIndex = 32;
            // 
            // checkInDate
            // 
            this.checkInDate.Location = new System.Drawing.Point(165, 398);
            this.checkInDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkInDate.Name = "checkInDate";
            this.checkInDate.Size = new System.Drawing.Size(260, 27);
            this.checkInDate.TabIndex = 31;
            // 
            // choosePictureBtn
            // 
            this.choosePictureBtn.Location = new System.Drawing.Point(734, 333);
            this.choosePictureBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.choosePictureBtn.Name = "choosePictureBtn";
            this.choosePictureBtn.Size = new System.Drawing.Size(130, 31);
            this.choosePictureBtn.TabIndex = 30;
            this.choosePictureBtn.Text = "Izaberi sliku";
            this.choosePictureBtn.UseVisualStyleBackColor = true;
            this.choosePictureBtn.Click += new System.EventHandler(this.choosePictureBtn_Click);
            // 
            // PicturePathTextBox
            // 
            this.PicturePathTextBox.Location = new System.Drawing.Point(165, 335);
            this.PicturePathTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PicturePathTextBox.Name = "PicturePathTextBox";
            this.PicturePathTextBox.Size = new System.Drawing.Size(531, 27);
            this.PicturePathTextBox.TabIndex = 29;
            // 
            // DocumentIDTextBox
            // 
            this.DocumentIDTextBox.Location = new System.Drawing.Point(165, 273);
            this.DocumentIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DocumentIDTextBox.Name = "DocumentIDTextBox";
            this.DocumentIDTextBox.Size = new System.Drawing.Size(151, 27);
            this.DocumentIDTextBox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Dodaj sliku";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Broj dokumenta";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(165, 151);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(151, 27);
            this.SurnameTextBox.TabIndex = 25;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(165, 89);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(151, 27);
            this.NameTextBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tip dokumenta";
            // 
            // docTypeCmbBox
            // 
            this.docTypeCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.docTypeCmbBox.FormattingEnabled = true;
            this.docTypeCmbBox.Items.AddRange(new object[] {
            "Licna karta",
            "Pasos"});
            this.docTypeCmbBox.Location = new System.Drawing.Point(165, 209);
            this.docTypeCmbBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.docTypeCmbBox.Name = "docTypeCmbBox";
            this.docTypeCmbBox.Size = new System.Drawing.Size(151, 28);
            this.docTypeCmbBox.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(635, 535);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 30);
            this.button3.TabIndex = 39;
            this.button3.Text = "Troskovi sobe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GostInformacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personPictureBox);
            this.Controls.Add(this.changeReservation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CheckOutDate);
            this.Controls.Add(this.checkInDate);
            this.Controls.Add(this.choosePictureBtn);
            this.Controls.Add(this.PicturePathTextBox);
            this.Controls.Add(this.DocumentIDTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.docTypeCmbBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GostInformacije";
            this.Text = "GostInformacije";
            this.Load += new System.EventHandler(this.GostInformacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox personPictureBox;
        private System.Windows.Forms.Button changeReservation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker CheckOutDate;
        private System.Windows.Forms.DateTimePicker checkInDate;
        private System.Windows.Forms.Button choosePictureBtn;
        private System.Windows.Forms.TextBox PicturePathTextBox;
        private System.Windows.Forms.TextBox DocumentIDTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox docTypeCmbBox;
        private System.Windows.Forms.Button button3;
    }
}