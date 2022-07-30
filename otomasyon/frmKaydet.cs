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
    public partial class frmKaydet : Form
    {
        int? id=null;
        public frmKaydet(int? Id=null)
        {
            InitializeComponent();
            if (Id != null)
            {
                this.id = Id;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                string sql = "Insert into Arabalar(Plaka,Marka,Model,Renk,Yıl) Values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text + "')";
                if (CRUD.ESG(sql))
                {
                    MessageBox.Show("Ekleme işlemi başarı ile gerçekleşti");
                }
                


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kategori frm = new kategori();
            frm.Show();
            this.Hide();
        }
    }
}
