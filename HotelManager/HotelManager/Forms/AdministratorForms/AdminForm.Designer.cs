
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
            this.showHotelsbtn = new System.Windows.Forms.Button();
            this.showWorkersbtn = new System.Windows.Forms.Button();
            this.showroomsbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showHotelsbtn
            // 
            this.showHotelsbtn.Location = new System.Drawing.Point(198, 65);
            this.showHotelsbtn.Name = "showHotelsbtn";
            this.showHotelsbtn.Size = new System.Drawing.Size(156, 23);
            this.showHotelsbtn.TabIndex = 0;
            this.showHotelsbtn.Text = "Prikazi sve hotele";
            this.showHotelsbtn.UseVisualStyleBackColor = true;
            this.showHotelsbtn.Click += new System.EventHandler(this.showHotelsbtn_Click);
            // 
            // showWorkersbtn
            // 
            this.showWorkersbtn.Location = new System.Drawing.Point(197, 114);
            this.showWorkersbtn.Name = "showWorkersbtn";
            this.showWorkersbtn.Size = new System.Drawing.Size(156, 23);
            this.showWorkersbtn.TabIndex = 1;
            this.showWorkersbtn.Text = "Prikazi sve radnike";
            this.showWorkersbtn.UseVisualStyleBackColor = true;
            this.showWorkersbtn.Click += new System.EventHandler(this.showWorkersbtn_Click);
            // 
            // showroomsbtn
            // 
            this.showroomsbtn.Location = new System.Drawing.Point(197, 170);
            this.showroomsbtn.Name = "showroomsbtn";
            this.showroomsbtn.Size = new System.Drawing.Size(156, 23);
            this.showroomsbtn.TabIndex = 2;
            this.showroomsbtn.Text = "Prikazi sve sobe";
            this.showroomsbtn.UseVisualStyleBackColor = true;
            this.showroomsbtn.Click += new System.EventHandler(this.showroomsbtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.showroomsbtn);
            this.Controls.Add(this.showWorkersbtn);
            this.Controls.Add(this.showHotelsbtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showHotelsbtn;
        private System.Windows.Forms.Button showWorkersbtn;
        private System.Windows.Forms.Button showroomsbtn;
    }
}