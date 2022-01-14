
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
            this.button2.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(389, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 31);
            this.button2.TabIndex = 38;
            this.button2.Text = "Obriši rezervaciju";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(244, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 31);
            this.button1.TabIndex = 37;
            this.button1.Text = "Pokaži račun";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // personPictureBox
            // 
            this.personPictureBox.Location = new System.Drawing.Point(389, 76);
            this.personPictureBox.Name = "personPictureBox";
            this.personPictureBox.Size = new System.Drawing.Size(367, 201);
            this.personPictureBox.TabIndex = 36;
            this.personPictureBox.TabStop = false;
            // 
            // changeReservation
            // 
            this.changeReservation.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeReservation.Location = new System.Drawing.Point(153, 454);
            this.changeReservation.Name = "changeReservation";
            this.changeReservation.Size = new System.Drawing.Size(75, 31);
            this.changeReservation.TabIndex = 35;
            this.changeReservation.Text = "Izmeni ";
            this.changeReservation.UseVisualStyleBackColor = true;
            this.changeReservation.Click += new System.EventHandler(this.changeReservation_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(44, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Check Out:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(47, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Check In: ";
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.Location = new System.Drawing.Point(144, 392);
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.Size = new System.Drawing.Size(228, 27);
            this.CheckOutDate.TabIndex = 32;
            // 
            // checkInDate
            // 
            this.checkInDate.Location = new System.Drawing.Point(144, 338);
            this.checkInDate.Name = "checkInDate";
            this.checkInDate.Size = new System.Drawing.Size(228, 27);
            this.checkInDate.TabIndex = 31;
            // 
            // choosePictureBtn
            // 
            this.choosePictureBtn.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choosePictureBtn.Location = new System.Drawing.Point(642, 283);
            this.choosePictureBtn.Name = "choosePictureBtn";
            this.choosePictureBtn.Size = new System.Drawing.Size(114, 31);
            this.choosePictureBtn.TabIndex = 30;
            this.choosePictureBtn.Text = "Izaberi sliku";
            this.choosePictureBtn.UseVisualStyleBackColor = true;
            this.choosePictureBtn.Click += new System.EventHandler(this.choosePictureBtn_Click);
            // 
            // PicturePathTextBox
            // 
            this.PicturePathTextBox.Location = new System.Drawing.Point(144, 284);
            this.PicturePathTextBox.Name = "PicturePathTextBox";
            this.PicturePathTextBox.Size = new System.Drawing.Size(465, 27);
            this.PicturePathTextBox.TabIndex = 29;
            // 
            // DocumentIDTextBox
            // 
            this.DocumentIDTextBox.Location = new System.Drawing.Point(144, 232);
            this.DocumentIDTextBox.Name = "DocumentIDTextBox";
            this.DocumentIDTextBox.Size = new System.Drawing.Size(133, 27);
            this.DocumentIDTextBox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(42, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Dodaj sliku";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Broj dokumenta";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(144, 128);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(133, 27);
            this.SurnameTextBox.TabIndex = 25;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(144, 76);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(133, 27);
            this.NameTextBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
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
            this.docTypeCmbBox.Location = new System.Drawing.Point(144, 178);
            this.docTypeCmbBox.Name = "docTypeCmbBox";
            this.docTypeCmbBox.Size = new System.Drawing.Size(133, 25);
            this.docTypeCmbBox.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(535, 454);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 29);
            this.button3.TabIndex = 39;
            this.button3.Text = "Troškovi sobe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GostInformacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 504);
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
            this.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "GostInformacije";
            this.Text = "Informacije o gostima";
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