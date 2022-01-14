
namespace HotelManager.Forms.AdministratorForms
{
    partial class ModifyRoomForm
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
            this.numOfBedsTxtBox = new System.Windows.Forms.TextBox();
            this.PricePerNightTxtBox = new System.Windows.Forms.TextBox();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj kreveta";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cena";
            // 
            // numOfBedsTxtBox
            // 
            this.numOfBedsTxtBox.Location = new System.Drawing.Point(133, 27);
            this.numOfBedsTxtBox.Name = "numOfBedsTxtBox";
            this.numOfBedsTxtBox.Size = new System.Drawing.Size(100, 23);
            this.numOfBedsTxtBox.TabIndex = 2;
            // 
            // PricePerNightTxtBox
            // 
            this.PricePerNightTxtBox.Location = new System.Drawing.Point(133, 86);
            this.PricePerNightTxtBox.Name = "PricePerNightTxtBox";
            this.PricePerNightTxtBox.Size = new System.Drawing.Size(100, 23);
            this.PricePerNightTxtBox.TabIndex = 3;
            // 
            // modifyBtn
            // 
            this.modifyBtn.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modifyBtn.Location = new System.Drawing.Point(93, 142);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(78, 27);
            this.modifyBtn.TabIndex = 4;
            this.modifyBtn.Text = "Izmeni";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // ModifyRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(263, 189);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.PricePerNightTxtBox);
            this.Controls.Add(this.numOfBedsTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "ModifyRoomForm";
            this.Text = "Izmeni sobu";
            this.Load += new System.EventHandler(this.ModifyRoomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numOfBedsTxtBox;
        private System.Windows.Forms.TextBox PricePerNightTxtBox;
        private System.Windows.Forms.Button modifyBtn;
    }
}