
namespace HotelManager.Forms
{
    partial class AddHotelForm
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
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.LocationTxtBox = new System.Windows.Forms.TextBox();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.AddHotelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime hotela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresa";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(116, 34);
            this.nameTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(110, 23);
            this.nameTxtBox.TabIndex = 3;
            // 
            // LocationTxtBox
            // 
            this.LocationTxtBox.Location = new System.Drawing.Point(116, 76);
            this.LocationTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocationTxtBox.Name = "LocationTxtBox";
            this.LocationTxtBox.Size = new System.Drawing.Size(110, 23);
            this.LocationTxtBox.TabIndex = 4;
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(116, 118);
            this.addressTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(110, 23);
            this.addressTxtBox.TabIndex = 5;
            // 
            // AddHotelBtn
            // 
            this.AddHotelBtn.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddHotelBtn.Location = new System.Drawing.Point(84, 184);
            this.AddHotelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddHotelBtn.Name = "AddHotelBtn";
            this.AddHotelBtn.Size = new System.Drawing.Size(91, 30);
            this.AddHotelBtn.TabIndex = 6;
            this.AddHotelBtn.Text = "Dodaj hotel";
            this.AddHotelBtn.UseVisualStyleBackColor = true;
            this.AddHotelBtn.Click += new System.EventHandler(this.AddHotelBtn_Click);
            // 
            // AddHotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(260, 244);
            this.Controls.Add(this.AddHotelBtn);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.LocationTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddHotelForm";
            this.Text = "Dodaj hotel";
            this.Load += new System.EventHandler(this.AddHotelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox LocationTxtBox;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.Button AddHotelBtn;
    }
}