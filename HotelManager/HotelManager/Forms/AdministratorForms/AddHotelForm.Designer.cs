
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
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime hotela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresa";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(132, 46);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(125, 27);
            this.nameTxtBox.TabIndex = 3;
            // 
            // LocationTxtBox
            // 
            this.LocationTxtBox.Location = new System.Drawing.Point(132, 96);
            this.LocationTxtBox.Name = "LocationTxtBox";
            this.LocationTxtBox.Size = new System.Drawing.Size(125, 27);
            this.LocationTxtBox.TabIndex = 4;
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(132, 157);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(125, 27);
            this.addressTxtBox.TabIndex = 5;
            // 
            // AddHotelBtn
            // 
            this.AddHotelBtn.Location = new System.Drawing.Point(106, 326);
            this.AddHotelBtn.Name = "AddHotelBtn";
            this.AddHotelBtn.Size = new System.Drawing.Size(94, 34);
            this.AddHotelBtn.TabIndex = 6;
            this.AddHotelBtn.Text = "Dodaj Hotel";
            this.AddHotelBtn.UseVisualStyleBackColor = true;
            this.AddHotelBtn.Click += new System.EventHandler(this.AddHotelBtn_Click);
            // 
            // AddHotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 403);
            this.Controls.Add(this.AddHotelBtn);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.LocationTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddHotelForm";
            this.Text = "AddHotelForm";
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