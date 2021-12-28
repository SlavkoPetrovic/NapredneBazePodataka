
namespace HotelManager.Forms.Hoteli
{
    partial class PrikazSobaForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listViewListaSoba = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.comboBoxOdabirTipaSobe = new System.Windows.Forms.ComboBox();
            this.buttonRezervisiSobu = new System.Windows.Forms.Button();
            this.buttonOslobodiSobu = new System.Windows.Forms.Button();
            this.buttonProslediPosao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewListaSoba
            // 
            this.listViewListaSoba.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.ID});
            this.listViewListaSoba.FullRowSelect = true;
            this.listViewListaSoba.GridLines = true;
            this.listViewListaSoba.HideSelection = false;
            this.listViewListaSoba.Location = new System.Drawing.Point(22, 64);
            this.listViewListaSoba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewListaSoba.Name = "listViewListaSoba";
            this.listViewListaSoba.Size = new System.Drawing.Size(516, 236);
            this.listViewListaSoba.TabIndex = 1;
            this.listViewListaSoba.UseCompatibleStateImageBehavior = false;
            this.listViewListaSoba.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sprat";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Broj sobe";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Broj kreveta";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cena po nocenju";
            this.columnHeader4.Width = 150;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // comboBoxOdabirTipaSobe
            // 
            this.comboBoxOdabirTipaSobe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOdabirTipaSobe.FormattingEnabled = true;
            this.comboBoxOdabirTipaSobe.Items.AddRange(new object[] {
            "Sve",
            "Slobodne",
            "Zauzete"});
            this.comboBoxOdabirTipaSobe.Location = new System.Drawing.Point(41, 22);
            this.comboBoxOdabirTipaSobe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxOdabirTipaSobe.Name = "comboBoxOdabirTipaSobe";
            this.comboBoxOdabirTipaSobe.Size = new System.Drawing.Size(133, 23);
            this.comboBoxOdabirTipaSobe.TabIndex = 2;
            this.comboBoxOdabirTipaSobe.SelectedIndexChanged += new System.EventHandler(this.comboBoxOdabirTipaSobe_SelectedIndexChanged);
            // 
            // buttonRezervisiSobu
            // 
            this.buttonRezervisiSobu.Location = new System.Drawing.Point(542, 64);
            this.buttonRezervisiSobu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRezervisiSobu.Name = "buttonRezervisiSobu";
            this.buttonRezervisiSobu.Size = new System.Drawing.Size(134, 22);
            this.buttonRezervisiSobu.TabIndex = 3;
            this.buttonRezervisiSobu.Text = "Rezervisi  Sobu";
            this.buttonRezervisiSobu.UseVisualStyleBackColor = true;
            this.buttonRezervisiSobu.Click += new System.EventHandler(this.buttonRezervisiSobu_Click);
            // 
            // buttonOslobodiSobu
            // 
            this.buttonOslobodiSobu.Location = new System.Drawing.Point(542, 110);
            this.buttonOslobodiSobu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOslobodiSobu.Name = "buttonOslobodiSobu";
            this.buttonOslobodiSobu.Size = new System.Drawing.Size(134, 22);
            this.buttonOslobodiSobu.TabIndex = 4;
            this.buttonOslobodiSobu.Text = "Prikazi rezervaciju";
            this.buttonOslobodiSobu.UseVisualStyleBackColor = true;
            this.buttonOslobodiSobu.Click += new System.EventHandler(this.buttonOslobodiSobu_Click);
            // 
            // buttonProslediPosao
            // 
            this.buttonProslediPosao.Location = new System.Drawing.Point(542, 157);
            this.buttonProslediPosao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonProslediPosao.Name = "buttonProslediPosao";
            this.buttonProslediPosao.Size = new System.Drawing.Size(134, 22);
            this.buttonProslediPosao.TabIndex = 5;
            this.buttonProslediPosao.Text = "Prosledi Posao";
            this.buttonProslediPosao.UseVisualStyleBackColor = true;
            this.buttonProslediPosao.Click += new System.EventHandler(this.buttonProslediPosao_Click);
            // 
            // PrikazSobaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.buttonProslediPosao);
            this.Controls.Add(this.buttonOslobodiSobu);
            this.Controls.Add(this.buttonRezervisiSobu);
            this.Controls.Add(this.comboBoxOdabirTipaSobe);
            this.Controls.Add(this.listViewListaSoba);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PrikazSobaForm";
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.PrikazSoba_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView listViewListaSoba;
        private System.Windows.Forms.ComboBox comboBoxOdabirTipaSobe;
        private System.Windows.Forms.Button buttonRezervisiSobu;
        private System.Windows.Forms.Button buttonOslobodiSobu;
        private System.Windows.Forms.Button buttonProslediPosao;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader ID;
    }
}