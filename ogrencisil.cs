using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgi
{
    public partial class ogrencisil : Form
    {
        UniversiteEntities db = new UniversiteEntities();
        public string kaynak = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\ASUS\documents\visual studio 2013\Projects\OgrenciBilgi\OgrenciBilgi\Universite.mdf';Integrated Security=True";
        public ogrencisil()
        {
            InitializeComponent();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();
            //SqlConnection baglantı = new SqlConnection(kaynak);
            //baglantı.Open();
            //SqlCommand komut = new SqlCommand("select * from Bolumler", baglantı);
            //SqlDataReader dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    comboBox1.Items.Add(dr[0] + " " + dr["BolumAdı"]);
            //}
            //baglantı.Close();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==-1)
            {
                var kaynak = (from x in db.Ogrencilers
                              
                              select new { ID = x.Numara, ADI = x.Ad, SOYADI = x.Soyad, x.Telefon, BÖLÜM_ADI = x.Bolumler.BolumAdı, FAKÜLTE = x.Fakulteler.FakulteAdı }).ToList();
                dataGridView1.DataSource = kaynak;
            }
            else
            {
                int id =(int) comboBox1.SelectedValue;
                var kaynak = (from x in db.Ogrencilers
                              where x.BolumID == id
                              select new {ID=x.Numara,ADI=x.Ad,SOYADI=x.Soyad,x.Telefon,BÖLÜM_ADI=x.Bolumler.BolumAdı,FAKÜLTE=x.Fakulteler.FakulteAdı }).ToList();
                dataGridView1.DataSource = kaynak;
            }

            comboBox1.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var silecegım = (from x in db.Ogrencilers
                             where x.Numara == id
                             select x).FirstOrDefault();
            db.Ogrencilers.Remove(silecegım);
            db.SaveChanges();
            var kaynak = (from x in db.Ogrencilers

                          select new { ID = x.Numara, ADI = x.Ad, SOYADI = x.Soyad, x.Telefon, BÖLÜM_ADI = x.Bolumler.BolumAdı, FAKÜLTE = x.Fakulteler.FakulteAdı }).ToList();
            dataGridView1.DataSource = kaynak;
            comboBox1.SelectedIndex = -1;


        }

        private void ogrencisil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universite.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.universite.Bolumler);

        }

        private void ogrencisil_Shown(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }

        private void ogrencisil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
