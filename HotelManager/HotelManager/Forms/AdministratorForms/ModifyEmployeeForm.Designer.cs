
namespace HotelManager.Forms.AdministratorForms
{
    partial class ModifyEmployeeForm
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
            this.PositionCmbBox = new System.Windows.Forms.ComboBox();
            this.HotelsCmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ModifyEmployeeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PositionCmbBox
            // 
            this.PositionCmbBox.FormattingEnabled = true;
            this.PositionCmbBox.Items.AddRange(new object[] {
            "Recepcionar",
            "Majstor",
            "Sobarica"});
            this.PositionCmbBox.Location = new System.Drawing.Point(82, 38);
            this.PositionCmbBox.Name = "PositionCmbBox";
            this.PositionCmbBox.Size = new System.Drawing.Size(121, 23);
            this.PositionCmbBox.TabIndex = 0;
            // 
            // HotelsCmbBox
            // 
            this.HotelsCmbBox.FormattingEnabled = true;
            this.HotelsCmbBox.Location = new System.Drawing.Point(82, 89);
            this.HotelsCmbBox.Name = "HotelsCmbBox";
            this.HotelsCmbBox.Size = new System.Drawing.Size(121, 23);
            this.HotelsCmbBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pozicija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hotel";
            // 
            // ModifyEmployeeBtn
            // 
            this.ModifyEmployeeBtn.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModifyEmployeeBtn.Location = new System.Drawing.Point(72, 154);
            this.ModifyEmployeeBtn.Name = "ModifyEmployeeBtn";
            this.ModifyEmployeeBtn.Size = new System.Drawing.Size(78, 28);
            this.ModifyEmployeeBtn.TabIndex = 4;
            this.ModifyEmployeeBtn.Text = "Izmeni";
            this.ModifyEmployeeBtn.UseVisualStyleBackColor = true;
            this.ModifyEmployeeBtn.Click += new System.EventHandler(this.ModifyEmployeeBtn_Click);
            // 
            // ModifyEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(232, 204);
            this.Controls.Add(this.ModifyEmployeeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HotelsCmbBox);
            this.Controls.Add(this.PositionCmbBox);
            this.Name = "ModifyEmployeeForm";
            this.Text = "Izmeni zaposlenog";
            this.Load += new System.EventHandler(this.ModifyEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PositionCmbBox;
        private System.Windows.Forms.ComboBox HotelsCmbBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ModifyEmployeeBtn;
    }
}