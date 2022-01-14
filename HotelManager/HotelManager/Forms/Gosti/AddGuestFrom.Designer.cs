
namespace HotelManager.Forms.Gosti
{
    partial class AddGuestFrom
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
            this.docTypeCmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DocumentIDTextBox = new System.Windows.Forms.TextBox();
            this.PicturePathTextBox = new System.Windows.Forms.TextBox();
            this.choosePictureBtn = new System.Windows.Forms.Button();
            this.checkInDate = new System.Windows.Forms.DateTimePicker();
            this.CheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addReservation = new System.Windows.Forms.Button();
            this.personPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // docTypeCmbBox
            // 
            this.docTypeCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.docTypeCmbBox.FormattingEnabled = true;
            this.docTypeCmbBox.Items.AddRange(new object[] {
            "Licna karta",
            "Pasos"});
            this.docTypeCmbBox.Location = new System.Drawing.Point(151, 144);
            this.docTypeCmbBox.Name = "docTypeCmbBox";
            this.docTypeCmbBox.Size = new System.Drawing.Size(133, 23);
            this.docTypeCmbBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tip dokumenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(70, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prezime";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(151, 54);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(133, 23);
            this.NameTextBox.TabIndex = 4;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(151, 100);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(133, 23);
            this.SurnameTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(35, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Broj dokumenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(49, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dodaj sliku";
            // 
            // DocumentIDTextBox
            // 
            this.DocumentIDTextBox.Location = new System.Drawing.Point(151, 192);
            this.DocumentIDTextBox.Name = "DocumentIDTextBox";
            this.DocumentIDTextBox.Size = new System.Drawing.Size(133, 23);
            this.DocumentIDTextBox.TabIndex = 8;
            // 
            // PicturePathTextBox
            // 
            this.PicturePathTextBox.Location = new System.Drawing.Point(151, 238);
            this.PicturePathTextBox.Name = "PicturePathTextBox";
            this.PicturePathTextBox.Size = new System.Drawing.Size(465, 23);
            this.PicturePathTextBox.TabIndex = 9;
            // 
            // choosePictureBtn
            // 
            this.choosePictureBtn.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choosePictureBtn.Location = new System.Drawing.Point(649, 237);
            this.choosePictureBtn.Name = "choosePictureBtn";
            this.choosePictureBtn.Size = new System.Drawing.Size(114, 26);
            this.choosePictureBtn.TabIndex = 10;
            this.choosePictureBtn.Text = "Izaberi sliku";
            this.choosePictureBtn.UseVisualStyleBackColor = true;
            this.choosePictureBtn.Click += new System.EventHandler(this.choosePictureBtn_Click);
            // 
            // checkInDate
            // 
            this.checkInDate.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkInDate.Location = new System.Drawing.Point(151, 286);
            this.checkInDate.Name = "checkInDate";
            this.checkInDate.Size = new System.Drawing.Size(232, 27);
            this.checkInDate.TabIndex = 11;
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckOutDate.Location = new System.Drawing.Point(151, 333);
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.Size = new System.Drawing.Size(232, 27);
            this.CheckOutDate.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(54, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Check In: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(51, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Check Out:";
            // 
            // addReservation
            // 
            this.addReservation.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addReservation.Location = new System.Drawing.Point(151, 376);
            this.addReservation.Name = "addReservation";
            this.addReservation.Size = new System.Drawing.Size(75, 26);
            this.addReservation.TabIndex = 15;
            this.addReservation.Text = "Dodaj rezervaciju";
            this.addReservation.UseVisualStyleBackColor = true;
            this.addReservation.Click += new System.EventHandler(this.AddReservation_Click);
            // 
            // personPictureBox
            // 
            this.personPictureBox.Location = new System.Drawing.Point(348, 54);
            this.personPictureBox.Name = "personPictureBox";
            this.personPictureBox.Size = new System.Drawing.Size(367, 177);
            this.personPictureBox.TabIndex = 17;
            this.personPictureBox.TabStop = false;
            // 
            // AddGuestFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(788, 413);
            this.Controls.Add(this.personPictureBox);
            this.Controls.Add(this.addReservation);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "AddGuestFrom";
            this.Text = "Dodaj gosta";
            this.Load += new System.EventHandler(this.AddGuestFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox docTypeCmbBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DocumentIDTextBox;
        private System.Windows.Forms.TextBox PicturePathTextBox;
        private System.Windows.Forms.Button choosePictureBtn;
        private System.Windows.Forms.DateTimePicker checkInDate;
        private System.Windows.Forms.DateTimePicker CheckOutDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addReservation;
        private System.Windows.Forms.PictureBox personPictureBox;
    }
}