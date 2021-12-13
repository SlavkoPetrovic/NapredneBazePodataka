
namespace HotelManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tempAddbtn = new System.Windows.Forms.Button();
            this.tempShowbtn = new System.Windows.Forms.Button();
            this.relationshipBtn = new System.Windows.Forms.Button();
            this.hotelAddBtn = new System.Windows.Forms.Button();
            this.showHotelBtn = new System.Windows.Forms.Button();
            this.testsdbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tempAddbtn
            // 
            this.tempAddbtn.Location = new System.Drawing.Point(25, 51);
            this.tempAddbtn.Name = "tempAddbtn";
            this.tempAddbtn.Size = new System.Drawing.Size(75, 23);
            this.tempAddbtn.TabIndex = 0;
            this.tempAddbtn.Text = "Add";
            this.tempAddbtn.UseVisualStyleBackColor = true;
            this.tempAddbtn.Click += new System.EventHandler(this.tempAddbtn_Click);
            // 
            // tempShowbtn
            // 
            this.tempShowbtn.Location = new System.Drawing.Point(25, 12);
            this.tempShowbtn.Name = "tempShowbtn";
            this.tempShowbtn.Size = new System.Drawing.Size(75, 23);
            this.tempShowbtn.TabIndex = 1;
            this.tempShowbtn.Text = "Show";
            this.tempShowbtn.UseVisualStyleBackColor = true;
            this.tempShowbtn.Click += new System.EventHandler(this.tempShowbtn_Click);
            // 
            // relationshipBtn
            // 
            this.relationshipBtn.Location = new System.Drawing.Point(25, 95);
            this.relationshipBtn.Name = "relationshipBtn";
            this.relationshipBtn.Size = new System.Drawing.Size(100, 23);
            this.relationshipBtn.TabIndex = 2;
            this.relationshipBtn.Text = "Relationship Add";
            this.relationshipBtn.UseVisualStyleBackColor = true;
            this.relationshipBtn.Click += new System.EventHandler(this.relationshipBtn_Click);
            // 
            // hotelAddBtn
            // 
            this.hotelAddBtn.Location = new System.Drawing.Point(287, 51);
            this.hotelAddBtn.Name = "hotelAddBtn";
            this.hotelAddBtn.Size = new System.Drawing.Size(75, 23);
            this.hotelAddBtn.TabIndex = 3;
            this.hotelAddBtn.Text = "AddHotel";
            this.hotelAddBtn.UseVisualStyleBackColor = true;
            this.hotelAddBtn.Click += new System.EventHandler(this.hotelAddBtn_Click);
            // 
            // showHotelBtn
            // 
            this.showHotelBtn.Location = new System.Drawing.Point(287, 12);
            this.showHotelBtn.Name = "showHotelBtn";
            this.showHotelBtn.Size = new System.Drawing.Size(75, 23);
            this.showHotelBtn.TabIndex = 4;
            this.showHotelBtn.Text = "ShowHotel";
            this.showHotelBtn.UseVisualStyleBackColor = true;
            this.showHotelBtn.Click += new System.EventHandler(this.showHotel_Click);
            // 
            // testsdbtn
            // 
            this.testsdbtn.Location = new System.Drawing.Point(225, 95);
            this.testsdbtn.Name = "testsdbtn";
            this.testsdbtn.Size = new System.Drawing.Size(251, 23);
            this.testsdbtn.TabIndex = 5;
            this.testsdbtn.Text = "ShowAdministrators of hotels";
            this.testsdbtn.UseVisualStyleBackColor = true;
            this.testsdbtn.Click += new System.EventHandler(this.testsdbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Relationship delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(532, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testsdbtn);
            this.Controls.Add(this.showHotelBtn);
            this.Controls.Add(this.hotelAddBtn);
            this.Controls.Add(this.relationshipBtn);
            this.Controls.Add(this.tempShowbtn);
            this.Controls.Add(this.tempAddbtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tempAddbtn;
        private System.Windows.Forms.Button tempShowbtn;
        private System.Windows.Forms.Button relationshipBtn;
        private System.Windows.Forms.Button hotelAddBtn;
        private System.Windows.Forms.Button showHotelBtn;
        private System.Windows.Forms.Button testsdbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

