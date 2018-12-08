using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgi
{
    public partial class ogrenciduzenle : Form
    {
        UniversiteEntities db = new UniversiteEntities();
        public ogrenciduzenle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kaynak = (from x in db.Ogrencilers

                          select new { ID = x.Numara, ADI = x.Ad, SOYADI = x.Soyad, x.Telefon, BÖLÜM_ADI = x.Bolumler.BolumAdı, FAKÜLTE = x.Fakulteler.FakulteAdı }).ToList();
            dataGridView1.DataSource = kaynak;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id =(int) dataGridView1.SelectedRows[0].Cells[0].Value;
            Ogrenciler kaynak = (from x in db.Ogrencilers
                                 where x.Numara == id
                                 select x).FirstOrDefault();
            textBox1.Text = kaynak.Numara.ToString();
            textBox2.Text = kaynak.Ad;
            textBox3.Text = kaynak.Soyad;
            textBox4.Text = kaynak.Telefon.ToString();
           
            
            
        }

        private void ogrenciduzenle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universite1.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.universite1.Bolumler);
            // TODO: This line of code loads data into the 'universite1.Fakulteler' table. You can move, or remove it, as needed.
            this.fakultelerTableAdapter.Fill(this.universite1.Fakulteler);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            Ogrenciler duz_kay = (from x in db.Ogrencilers
                               where x.Numara == id
                               select x).FirstOrDefault();
            duz_kay.Numara = Convert.ToInt32(textBox1.Text);
            duz_kay.Ad = textBox2.Text;
            duz_kay.Soyad = textBox3.Text;
            duz_kay.Telefon = Convert.ToDecimal(textBox4.Text);
            duz_kay.FakulteID = (int)comboBox1.SelectedValue;
            duz_kay.BolumID = (int)comboBox2.SelectedValue;
           
            db.SaveChanges();
            dataGridView1.DataSource = db.Ogrencilers.ToList();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

        }

        private void ogrenciduzenle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
