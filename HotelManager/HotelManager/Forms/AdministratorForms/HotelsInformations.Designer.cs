
namespace HotelManager.Forms.AdministratorForms
{
    partial class HotelsInformations
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
            this.SuspendLayout();
            // 
            // hotelListView
            // 
            this.hotelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.hotelListView.GridLines = true;
            this.hotelListView.HideSelection = false;
            this.hotelListView.Location = new System.Drawing.Point(66, 65);
            this.hotelListView.Name = "hotelListView";
            this.hotelListView.Size = new System.Drawing.Size(427, 338);
            this.hotelListView.TabIndex = 0;
            this.hotelListView.UseCompatibleStateImageBehavior = false;
            this.hotelListView.View = System.Windows.Forms.View.Details;
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
            // HotelsInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hotelListView);
            this.Name = "HotelsInformations";
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
    }
}