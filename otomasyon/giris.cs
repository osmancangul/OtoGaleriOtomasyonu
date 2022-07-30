using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici_adi;
            int parola;

            kullanici_adi = textBox1.Text;
            parola = Convert.ToInt32(textBox2.Text);

            if (radioButton1.Checked == true)
            {
                if ((kullanici_adi == "musteri" && parola == 1111))
                {
                    MessageBox.Show("Hoşgeldiniz.");

                    frmListele form2 = new frmListele();
                    form2.Show();  
                    this.Hide();
                }
            }


            if (radioButton1.Checked == true)
            {
                if ((kullanici_adi != "musteri" && parola == 1111))
                {
                    MessageBox.Show("Kullanıcı Adı Hatalı");
                }
            }

            if (radioButton1.Checked == true)
            {
                if ((kullanici_adi == "musteri" && parola != 1111))
                {
                    MessageBox.Show("Parola Hatalı");
                }
            }



            if (radioButton2.Checked == true)
            {
                if ((kullanici_adi == "yonetici" && parola == 1903))
                {
                    MessageBox.Show("Hoşgeldin Osman");

                    kategori form3 = new kategori();
                    form3.Show();
                    this.Hide();
                }
            }

            if (radioButton2.Checked == true)
            {
                if ((kullanici_adi != "yonetici" && parola == 1903))
                {
                    MessageBox.Show("Kullanıcı Adı Hatalı");
                }
            }

            if (radioButton2.Checked == true)
            {
                if ((kullanici_adi == "yonetici" && parola != 1903))
                {
                    MessageBox.Show("Parola Hatalı");
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.AutoCheck = false;
            radioButton1.AutoCheck = true;

            radioButton2.AutoCheck = false;
            radioButton2.AutoCheck = true;
        }
    }
}
