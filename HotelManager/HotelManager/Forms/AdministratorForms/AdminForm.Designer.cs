
namespace HotelManager.Forms.AdministratorForms
{
    partial class AdminForm
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
            this.CreateHotelBtn = new System.Windows.Forms.Button();
            this.AddNewRoomBtn = new System.Windows.Forms.Button();
            this.addNewEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateHotelBtn
            // 
            this.CreateHotelBtn.Location = new System.Drawing.Point(40, 32);
            this.CreateHotelBtn.Name = "CreateHotelBtn";
            this.CreateHotelBtn.Size = new System.Drawing.Size(155, 40);
            this.CreateHotelBtn.TabIndex = 0;
            this.CreateHotelBtn.Text = "Dodaj novi hotel";
            this.CreateHotelBtn.UseVisualStyleBackColor = true;
            this.CreateHotelBtn.Click += new System.EventHandler(this.CreateHotelBtn_Click);
            // 
            // AddNewRoomBtn
            // 
            this.AddNewRoomBtn.Location = new System.Drawing.Point(44, 105);
            this.AddNewRoomBtn.Name = "AddNewRoomBtn";
            this.AddNewRoomBtn.Size = new System.Drawing.Size(150, 41);
            this.AddNewRoomBtn.TabIndex = 1;
            this.AddNewRoomBtn.Text = "Dodaj novu sobu hotelu";
            this.AddNewRoomBtn.UseVisualStyleBackColor = true;
            // 
            // addNewEmployee
            // 
            this.addNewEmployee.Location = new System.Drawing.Point(55, 180);
            this.addNewEmployee.Name = "addNewEmployee";
            this.addNewEmployee.Size = new System.Drawing.Size(183, 37);
            this.addNewEmployee.TabIndex = 2;
            this.addNewEmployee.Text = "Dodaj novog Radnika";
            this.addNewEmployee.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addNewEmployee);
            this.Controls.Add(this.AddNewRoomBtn);
            this.Controls.Add(this.CreateHotelBtn);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateHotelBtn;
        private System.Windows.Forms.Button AddNewRoomBtn;
        private System.Windows.Forms.Button addNewEmployee;
    }
}