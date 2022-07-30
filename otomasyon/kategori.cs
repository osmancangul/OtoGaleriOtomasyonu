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
    public partial class kategori : Form
    {
        public kategori()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKaydet form3 = new frmKaydet();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteri form3 = new musteri();
            form3.Show();
            this.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            giris frm = new giris();
            frm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmKaydet frm = new frmKaydet();
            frm.Show();
            this.Hide();
        }
    }
}
