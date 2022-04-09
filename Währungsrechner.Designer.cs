
namespace Währunsrechner
{
    partial class Währungsrechner
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
            this.KnopfLoeschen = new System.Windows.Forms.Button();
            this.KnopfUmrechnen = new System.Windows.Forms.Button();
            this.KomboboxWaehrung = new System.Windows.Forms.ComboBox();
            this.lblUmrechnen = new System.Windows.Forms.Label();
            this.TextboxWaehrung = new System.Windows.Forms.TextBox();
            this.Startfenster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KnopfLoeschen
            // 
            this.KnopfLoeschen.Location = new System.Drawing.Point(374, 368);
            this.KnopfLoeschen.Name = "KnopfLoeschen";
            this.KnopfLoeschen.Size = new System.Drawing.Size(109, 48);
            this.KnopfLoeschen.TabIndex = 0;
            this.KnopfLoeschen.Text = "Löschen";
            this.KnopfLoeschen.UseVisualStyleBackColor = true;
            this.KnopfLoeschen.Click += new System.EventHandler(this.button1_Click);
            // 
            // KnopfUmrechnen
            // 
            this.KnopfUmrechnen.AccessibleDescription = "Rechnet um";
            this.KnopfUmrechnen.AccessibleName = "btnUmrechen";
            this.KnopfUmrechnen.Location = new System.Drawing.Point(636, 368);
            this.KnopfUmrechnen.Name = "KnopfUmrechnen";
            this.KnopfUmrechnen.Size = new System.Drawing.Size(99, 48);
            this.KnopfUmrechnen.TabIndex = 1;
            this.KnopfUmrechnen.Text = "Umrechnen";
            this.KnopfUmrechnen.UseVisualStyleBackColor = true;
            this.KnopfUmrechnen.Click += new System.EventHandler(this.KnopfUmrechnen_Click);
            // 
            // KomboboxWaehrung
            // 
            this.KomboboxWaehrung.CausesValidation = false;
            this.KomboboxWaehrung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KomboboxWaehrung.FormattingEnabled = true;
            this.KomboboxWaehrung.Location = new System.Drawing.Point(438, 178);
            this.KomboboxWaehrung.Name = "KomboboxWaehrung";
            this.KomboboxWaehrung.Size = new System.Drawing.Size(223, 23);
            this.KomboboxWaehrung.TabIndex = 2;
            //this.KomboboxWaehrung.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblUmrechnen
            // 
            this.lblUmrechnen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblUmrechnen.Location = new System.Drawing.Point(438, 278);
            this.lblUmrechnen.MaximumSize = new System.Drawing.Size(234, 42);
            this.lblUmrechnen.Name = "lblUmrechnen";
            this.lblUmrechnen.Size = new System.Drawing.Size(223, 42);
            this.lblUmrechnen.TabIndex = 3;
            //this.lblUmrechnen.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextboxWaehrung
            // 
            this.TextboxWaehrung.Location = new System.Drawing.Point(438, 207);
            this.TextboxWaehrung.Multiline = true;
            this.TextboxWaehrung.Name = "TextboxWaehrung";
            this.TextboxWaehrung.Size = new System.Drawing.Size(223, 52);
            this.TextboxWaehrung.TabIndex = 4;
            //this.TextboxWaehrung.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Startfenster
            // 
            this.Startfenster.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Startfenster.Location = new System.Drawing.Point(296, 138);
            this.Startfenster.Name = "Startfenster";
            this.Startfenster.Size = new System.Drawing.Size(528, 360);
            this.Startfenster.TabIndex = 5;
            this.Startfenster.Text = "Währungsrechner";
            this.Startfenster.UseVisualStyleBackColor = true;
            this.Startfenster.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 600);
            this.Controls.Add(this.Startfenster);
            this.Controls.Add(this.TextboxWaehrung);
            this.Controls.Add(this.lblUmrechnen);
            this.Controls.Add(this.KomboboxWaehrung);
            this.Controls.Add(this.KnopfUmrechnen);
            this.Controls.Add(this.KnopfLoeschen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KnopfLoeschen;
        private System.Windows.Forms.Button KnopfUmrechnen;
        private System.Windows.Forms.ComboBox KomboboxWaehrung;
        private System.Windows.Forms.TextBox TextboxWaehrung;
        private System.Windows.Forms.Button Startfenster;
        internal System.Windows.Forms.Label lblUmrechnen;
    }
}

