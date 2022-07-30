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
    public partial class frmListele : Form
    {
        public frmListele()
        {
            InitializeComponent();
            Listele();
        }
        void Listele()
        {
            string sql = "Select * from Arabalar";
            dataGridView1.DataSource = CRUD.Listele(sql);
        }

        void listele()
        {
            string sql = "Select ID,Ad,Soyad,T.C.,Telefon from Musteriler";
            dataGridView1.DataSource = CRUD.Listele(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKaydet frm = new frmKaydet();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int seciliid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            frmKaydet frm = new frmKaydet();
            frm.textBox1.Text = dataGridView1.CurrentRow.Cells["Plaka"].Value.ToString();
            frm.textBox2.Text = dataGridView1.CurrentRow.Cells["Marka"].Value.ToString();
            frm.textBox3.Text = dataGridView1.CurrentRow.Cells["Model"].Value.ToString();
            frm.textBox4.Text = dataGridView1.CurrentRow.Cells["Renk"].Value.ToString();
            frm.textBox5.Text = dataGridView1.CurrentRow.Cells["Yıl"].Value.ToString();

            frm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir;
            satir = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[satir].Cells["Plaka"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[satir].Cells["Marka"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[satir].Cells["Model"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[satir].Cells["Renk"].Value.ToString();
            textBox5.Text = dataGridView1.Rows[satir].Cells["Yıl"].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            giris frm = new giris();
            frm.Show();
            this.Hide();
        }
    }
}
