
namespace HotelManager.Forms.AdministratorForms
{
    partial class HotelsInformationsForm
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
            this.hotelListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.ShowHotelBtn = new System.Windows.Forms.Button();
            this.DeleteHotelBtn = new System.Windows.Forms.Button();
            this.AddNewHotelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hotelListView
            // 
            this.hotelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.hotelListView.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hotelListView.FullRowSelect = true;
            this.hotelListView.GridLines = true;
            this.hotelListView.HideSelection = false;
            this.hotelListView.Location = new System.Drawing.Point(12, 43);
            this.hotelListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hotelListView.Name = "hotelListView";
            this.hotelListView.Size = new System.Drawing.Size(405, 254);
            this.hotelListView.TabIndex = 0;
            this.hotelListView.UseCompatibleStateImageBehavior = false;
            this.hotelListView.View = System.Windows.Forms.View.Details;
            this.hotelListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.hotelListView_ColumnWidthChanging);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naziv";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lokacija";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adresa";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "BrojRadnika";
            this.columnHeader4.Width = 100;
            // 
            // ShowHotelBtn
            // 
            this.ShowHotelBtn.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowHotelBtn.Location = new System.Drawing.Point(475, 132);
            this.ShowHotelBtn.Name = "ShowHotelBtn";
            this.ShowHotelBtn.Size = new System.Drawing.Size(125, 30);
            this.ShowHotelBtn.TabIndex = 1;
            this.ShowHotelBtn.Text = "Detaljniji prikaz hotela";
            this.ShowHotelBtn.UseVisualStyleBackColor = true;
            this.ShowHotelBtn.Click += new System.EventHandler(this.ShowHotelBtn_Click);
            // 
            // DeleteHotelBtn
            // 
            this.DeleteHotelBtn.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteHotelBtn.Location = new System.Drawing.Point(475, 208);
            this.DeleteHotelBtn.Name = "DeleteHotelBtn";
            this.DeleteHotelBtn.Size = new System.Drawing.Size(125, 30);
            this.DeleteHotelBtn.TabIndex = 2;
            this.DeleteHotelBtn.Text = "Obriši hotel";
            this.DeleteHotelBtn.UseVisualStyleBackColor = true;
            this.DeleteHotelBtn.Click += new System.EventHandler(this.DeleteHotelBtn_Click);
            // 
            // AddNewHotelBtn
            // 
            this.AddNewHotelBtn.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewHotelBtn.Location = new System.Drawing.Point(475, 75);
            this.AddNewHotelBtn.Name = "AddNewHotelBtn";
            this.AddNewHotelBtn.Size = new System.Drawing.Size(125, 29);
            this.AddNewHotelBtn.TabIndex = 3;
            this.AddNewHotelBtn.Text = "Dodaj novi hotel";
            this.AddNewHotelBtn.UseVisualStyleBackColor = true;
            this.AddNewHotelBtn.Click += new System.EventHandler(this.AddNewHotelBtn_Click);
            // 
            // HotelsInformationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(628, 328);
            this.Controls.Add(this.AddNewHotelBtn);
            this.Controls.Add(this.DeleteHotelBtn);
            this.Controls.Add(this.ShowHotelBtn);
            this.Controls.Add(this.hotelListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "HotelsInformationsForm";
            this.Text = "Informacije hotela";
            this.Load += new System.EventHandler(this.HotelsInformations_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView hotelListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button ShowHotelBtn;
        private System.Windows.Forms.Button DeleteHotelBtn;
        private System.Windows.Forms.Button AddNewHotelBtn;
    }
}