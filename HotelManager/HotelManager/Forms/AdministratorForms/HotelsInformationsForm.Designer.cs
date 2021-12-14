
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
            this.hotelListView.FullRowSelect = true;
            this.hotelListView.GridLines = true;
            this.hotelListView.HideSelection = false;
            this.hotelListView.Location = new System.Drawing.Point(54, 43);
            this.hotelListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hotelListView.Name = "hotelListView";
            this.hotelListView.Size = new System.Drawing.Size(331, 254);
            this.hotelListView.TabIndex = 0;
            this.hotelListView.UseCompatibleStateImageBehavior = false;
            this.hotelListView.View = System.Windows.Forms.View.Details;
            this.hotelListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.hotelListView_ColumnWidthChanging);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naziv";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lokacija";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adresa";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "BrojRadnika";
            // 
            // ShowHotelBtn
            // 
            this.ShowHotelBtn.Location = new System.Drawing.Point(443, 143);
            this.ShowHotelBtn.Name = "ShowHotelBtn";
            this.ShowHotelBtn.Size = new System.Drawing.Size(141, 47);
            this.ShowHotelBtn.TabIndex = 1;
            this.ShowHotelBtn.Text = "Detaljniji prikaz hotela";
            this.ShowHotelBtn.UseVisualStyleBackColor = true;
            this.ShowHotelBtn.Click += new System.EventHandler(this.ShowHotelBtn_Click);
            // 
            // DeleteHotelBtn
            // 
            this.DeleteHotelBtn.Location = new System.Drawing.Point(452, 214);
            this.DeleteHotelBtn.Name = "DeleteHotelBtn";
            this.DeleteHotelBtn.Size = new System.Drawing.Size(113, 40);
            this.DeleteHotelBtn.TabIndex = 2;
            this.DeleteHotelBtn.Text = "Obrisi hotel";
            this.DeleteHotelBtn.UseVisualStyleBackColor = true;
            this.DeleteHotelBtn.Click += new System.EventHandler(this.DeleteHotelBtn_Click);
            // 
            // AddNewHotelBtn
            // 
            this.AddNewHotelBtn.Location = new System.Drawing.Point(452, 71);
            this.AddNewHotelBtn.Name = "AddNewHotelBtn";
            this.AddNewHotelBtn.Size = new System.Drawing.Size(113, 42);
            this.AddNewHotelBtn.TabIndex = 3;
            this.AddNewHotelBtn.Text = "Dodaj novi hotel";
            this.AddNewHotelBtn.UseVisualStyleBackColor = true;
            this.AddNewHotelBtn.Click += new System.EventHandler(this.AddNewHotelBtn_Click);
            // 
            // HotelsInformationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.AddNewHotelBtn);
            this.Controls.Add(this.DeleteHotelBtn);
            this.Controls.Add(this.ShowHotelBtn);
            this.Controls.Add(this.hotelListView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HotelsInformationsForm";
            this.Text = "HotelsInformations";
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