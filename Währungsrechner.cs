using System;
using System.Windows.Forms;

namespace Währunsrechner
{
    public partial class Währungsrechner : Form
    {
        // Euro als Basiswährung
        // Stand 5.10.2021

        double Euro = 1;
        double US_Dollar = 1.16;

        double Britischer_Pfund = 0.85;
        double Argentinischer_Peso = 114.78;
        double Bitcoin = 0.000024;
        double Yen = 129.30;
        double Rubel = 83.93;


        
        public Währungsrechner()
        {
            InitializeComponent();     
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            KnopfLoeschen.Visible = true;
            TextboxWaehrung.Clear();
            lblUmrechnen.Text = "";

        }    
   
        private void button3_Click_1(object sender, EventArgs e)
        {
            Startfenster.Visible = false;
        }

      
        private void KnopfUmrechnen_Click(object sender, EventArgs e)
        {
            Double Euro = Double.Parse(TextboxWaehrung.Text);
            if (KomboboxWaehrung.Text == "€ → $ (US-Dollar)")
            {
                lblUmrechnen.Text = System.Convert.ToString(("€ in $:  " + Euro * US_Dollar));
            }
            
            if (KomboboxWaehrung.Text == "€ → £ (Pound Sterling)")
            {
                lblUmrechnen.Text = System.Convert.ToString(("€ in £  " + Euro * Britischer_Pfund));
            }

            if (KomboboxWaehrung.Text == "€ → ₱ (Argentinischer Peso)")
            {
                lblUmrechnen.Text = System.Convert.ToString(("€ in ₱  " + Euro * Argentinischer_Peso));
            }

            if (KomboboxWaehrung.Text == "€ → ₿ (Bitcoin)")
            {
                lblUmrechnen.Text = System.Convert.ToString(("€ in ₿  " + Euro * Bitcoin));
            }

            if (KomboboxWaehrung.Text == "€ → ￥(Japanischer Yen)")
            {
                lblUmrechnen.Text = System.Convert.ToString(("€ in ￥  " + Euro * Yen));
            }

            if (KomboboxWaehrung.Text == "€ → ₽ (Rubel)")
            {
                lblUmrechnen.Text = System.Convert.ToString(("€ in ₽  " + Euro * Rubel));
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            KomboboxWaehrung.Text = "Wähle eine Währung aus...";
           
            KomboboxWaehrung.Items.Add("€ → $ (US-Dollar)");
            KomboboxWaehrung.Items.Add("€ → £ (Pound Sterling)");
            KomboboxWaehrung.Items.Add("€ → ₱ (Argentinischer Peso)");
            KomboboxWaehrung.Items.Add("€ → ₿ (Bitcoin)");
            KomboboxWaehrung.Items.Add("€ → ￥(Japanischer Yen)");
            KomboboxWaehrung.Items.Add("€ → ₽ (Rubel)");
        }
    }
}
