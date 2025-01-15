using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool deger = true;
        int deger_sayi = 0; //sıra değişimi için
        private void button_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (deger)
            {
                btn.Text = "X";
                btn.BackColor = Color.Green;
            }
            else
            {
                btn.Text = "O";
                btn.BackColor = Color.Yellow;
            }
            deger = !deger;
            btn.Enabled = false;
            deger_sayi++;
            kazanan(); // Kazanan kontrolünün denetimi için
        }
        private void sonuclar()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }
        private void kazanan()
        {
            bool kazananvarmi = false;
            //satırları kontrol etme
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                kazananvarmi = true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                kazananvarmi = true;
            if ((C1.Text == button8.Text) && (button8.Text == button9.Text) && (!C1.Enabled))
                kazananvarmi = true;
            //sütunları kontrol etme
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                kazananvarmi = true;
            if ((A2.Text == B2.Text) && (B2.Text == button8.Text) && (!A2.Enabled))
                kazananvarmi = true;
            if ((A3.Text == B3.Text) && (B3.Text == button9.Text) && (!A3.Enabled))
                kazananvarmi = true;
            //çaprazları kontrol etme
            else if ((A1.Text == B2.Text) && (B2.Text == button9.Text) && (!A1.Enabled))
                kazananvarmi = true;
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                kazananvarmi = true;
            if (kazananvarmi)
            {
                sonuclar();
                string kimkazandi = "";
                if (deger)
                    kimkazandi = "O";
                else
                    kimkazandi = "X";
                MessageBox.Show(kimkazandi + " Kazandı", "Oyun Bitti");
            }
            else
            {
                if (deger_sayi == 9)
                    MessageBox.Show(" Berabere", "Oyun Bitti");
            }
        }      
    }
}



