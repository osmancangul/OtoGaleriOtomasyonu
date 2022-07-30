using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace otomasyon
{
    public partial class musteri : Form
    {
        int? id = null;
        public musteri(int? Id = null)
        {
            InitializeComponent();
            if (Id != null)
            {
                this.id = Id;
            }

        }
        DataTable tablo = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
            dataGridView1.DataSource = tablo;
        }

        private void musteri_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("ID", typeof(int));
            tablo.Columns.Add("Ad", typeof(string));
            tablo.Columns.Add("Soyad", typeof(string));
            tablo.Columns.Add("T.C.", typeof(Int32));
            tablo.Columns.Add("Telefon", typeof(Int32));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kategori frm = new kategori();
            frm.Show();
            this.Hide();
        }
    }
}
