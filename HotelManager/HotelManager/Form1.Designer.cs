
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
            this.SuspendLayout();
            // 
            // tempAddbtn
            // 
            this.tempAddbtn.Location = new System.Drawing.Point(487, 78);
            this.tempAddbtn.Name = "tempAddbtn";
            this.tempAddbtn.Size = new System.Drawing.Size(75, 23);
            this.tempAddbtn.TabIndex = 0;
            this.tempAddbtn.Text = "Add";
            this.tempAddbtn.UseVisualStyleBackColor = true;
            this.tempAddbtn.Click += new System.EventHandler(this.tempAddbtn_Click);
            // 
            // tempShowbtn
            // 
            this.tempShowbtn.Location = new System.Drawing.Point(146, 78);
            this.tempShowbtn.Name = "tempShowbtn";
            this.tempShowbtn.Size = new System.Drawing.Size(75, 23);
            this.tempShowbtn.TabIndex = 1;
            this.tempShowbtn.Text = "Show";
            this.tempShowbtn.UseVisualStyleBackColor = true;
            this.tempShowbtn.Click += new System.EventHandler(this.tempShowbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
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
    }
}

