
namespace HotelManager.Forms.AdministratorForms
{
    partial class AddRoomForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RoomNumberTxtBox = new System.Windows.Forms.TextBox();
            this.FloorNumberTxtBox = new System.Windows.Forms.TextBox();
            this.NumOfBedsTxtBox = new System.Windows.Forms.TextBox();
            this.PricePerNightTxtBox = new System.Windows.Forms.TextBox();
            this.AddRoomBtn = new System.Windows.Forms.Button();
            this.HotelComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj sobe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sprat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj kreveta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cena po noćenju";
            // 
            // RoomNumberTxtBox
            // 
            this.RoomNumberTxtBox.Location = new System.Drawing.Point(142, 31);
            this.RoomNumberTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoomNumberTxtBox.Name = "RoomNumberTxtBox";
            this.RoomNumberTxtBox.Size = new System.Drawing.Size(133, 23);
            this.RoomNumberTxtBox.TabIndex = 4;
            // 
            // FloorNumberTxtBox
            // 
            this.FloorNumberTxtBox.Location = new System.Drawing.Point(142, 71);
            this.FloorNumberTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FloorNumberTxtBox.Name = "FloorNumberTxtBox";
            this.FloorNumberTxtBox.Size = new System.Drawing.Size(133, 23);
            this.FloorNumberTxtBox.TabIndex = 5;
            // 
            // NumOfBedsTxtBox
            // 
            this.NumOfBedsTxtBox.Location = new System.Drawing.Point(142, 111);
            this.NumOfBedsTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumOfBedsTxtBox.Name = "NumOfBedsTxtBox";
            this.NumOfBedsTxtBox.Size = new System.Drawing.Size(133, 23);
            this.NumOfBedsTxtBox.TabIndex = 6;
            // 
            // PricePerNightTxtBox
            // 
            this.PricePerNightTxtBox.Location = new System.Drawing.Point(142, 151);
            this.PricePerNightTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PricePerNightTxtBox.Name = "PricePerNightTxtBox";
            this.PricePerNightTxtBox.Size = new System.Drawing.Size(133, 23);
            this.PricePerNightTxtBox.TabIndex = 7;
            // 
            // AddRoomBtn
            // 
            this.AddRoomBtn.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddRoomBtn.Location = new System.Drawing.Point(99, 248);
            this.AddRoomBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRoomBtn.Name = "AddRoomBtn";
            this.AddRoomBtn.Size = new System.Drawing.Size(85, 26);
            this.AddRoomBtn.TabIndex = 8;
            this.AddRoomBtn.Text = "Dodaj sobu";
            this.AddRoomBtn.UseVisualStyleBackColor = true;
            this.AddRoomBtn.Click += new System.EventHandler(this.AddRoomBtn_Click);
            // 
            // HotelComboBox
            // 
            this.HotelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HotelComboBox.FormattingEnabled = true;
            this.HotelComboBox.Location = new System.Drawing.Point(142, 189);
            this.HotelComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HotelComboBox.Name = "HotelComboBox";
            this.HotelComboBox.Size = new System.Drawing.Size(133, 23);
            this.HotelComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hotel";
            // 
            // AddRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(298, 302);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HotelComboBox);
            this.Controls.Add(this.AddRoomBtn);
            this.Controls.Add(this.PricePerNightTxtBox);
            this.Controls.Add(this.NumOfBedsTxtBox);
            this.Controls.Add(this.FloorNumberTxtBox);
            this.Controls.Add(this.RoomNumberTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddRoomForm";
            this.Text = "Dodaj sobu";
            this.Load += new System.EventHandler(this.AddRoomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RoomNumberTxtBox;
        private System.Windows.Forms.TextBox FloorNumberTxtBox;
        private System.Windows.Forms.TextBox NumOfBedsTxtBox;
        private System.Windows.Forms.TextBox PricePerNightTxtBox;
        private System.Windows.Forms.Button AddRoomBtn;
        private System.Windows.Forms.ComboBox HotelComboBox;
        private System.Windows.Forms.Label label5;
    }
}