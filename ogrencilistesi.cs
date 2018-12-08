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
    public partial class ogrencilistesi : Form
    {
        UniversiteEntities db = new UniversiteEntities();
        public ogrencilistesi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                var kaynak = (from x in db.Ogrencilers

                              select new { ID = x.Numara, ADI = x.Ad, SOYADI = x.Soyad, x.Telefon, BÖLÜM_ADI = x.Bolumler.BolumAdı, FAKÜLTE = x.Fakulteler.FakulteAdı }).ToList();
                dataGridView1.DataSource = kaynak;
            }
            else
            {
                int id = (int)comboBox1.SelectedValue;
                var kaynak = (from x in db.Ogrencilers
                              where x.BolumID == id
                              select new { ID = x.Numara, ADI = x.Ad, SOYADI = x.Soyad, x.Telefon, BÖLÜM_ADI = x.Bolumler.BolumAdı, FAKÜLTE = x.Fakulteler.FakulteAdı }).ToList();
                dataGridView1.DataSource = kaynak;
            }

            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ogrencilistesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universite.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.universite.Bolumler);
            // TODO: This line of code loads data into the 'universite.Ogrenciler' table. You can move, or remove it, as needed.
            this.ogrencilerTableAdapter.Fill(this.universite.Ogrenciler);


        }

        private void ogrencilistesi_Shown(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }

        private void ogrencilistesi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();


        }
    }
}
