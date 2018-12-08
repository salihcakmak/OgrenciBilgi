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
  
    public partial class bolumekle : Form
    {
        public string kaynak = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\ASUS\documents\visual studio 2013\Projects\OgrenciBilgi\OgrenciBilgi\Universite.mdf';Integrated Security=True";
        public bolumekle()
        {
            InitializeComponent();
        }

        private void bolumekle_Load(object sender, EventArgs e)
        {
            SqlConnection baglantı = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\ASUS\documents\visual studio 2013\Projects\OgrenciBilgi\OgrenciBilgi\Universite.mdf';Integrated Security=True");
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from Fakulteler", baglantı);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0] + " " + dr[1]);
            }
            baglantı.Close();
            textBox1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" )
            {
                MessageBox.Show("Lütfen Bölüm Adı Giriniz");
            }
            else if (comboBox1.Text == "") { MessageBox.Show("Lütfen Fakülte Seçiniz"); }
            else
            {
                string secili = (string)comboBox1.SelectedItem;
                int yer = secili.IndexOf(" ");
                int id = Convert.ToInt32(secili.Substring(0, yer));
                // MessageBox.Show(secili+" alınnan parca "+id.ToString());
                SqlConnection baglantı = new SqlConnection(kaynak);
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into Bolumler(BolumAdı,FakulteID) values(@blmadi,@fakid)", baglantı);
                komut.Parameters.AddWithValue("blmadi", textBox1.Text.ToUpper());
                komut.Parameters.AddWithValue("fakid", id);
                komut.ExecuteNonQuery();
                MessageBox.Show("BÖLÜM BAŞARIYLA EKLENDİ");
                textBox1.Clear();
                textBox1.Focus();
                comboBox1.SelectedIndex = -1;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bolumekle_FormClosing(object sender, FormClosingEventArgs e)
        {

            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
