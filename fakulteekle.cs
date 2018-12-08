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
    public partial class fakulteekle : Form
    {
        public string kaynak = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\ASUS\documents\visual studio 2013\Projects\OgrenciBilgi\OgrenciBilgi\Universite.mdf';Integrated Security=True";
        public fakulteekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("LÜTFEN FAKÜLTE ADI GİRİNİZ");
            }
            else
            {
                SqlConnection baglantı = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\ASUS\documents\visual studio 2013\Projects\OgrenciBilgi\OgrenciBilgi\Universite.mdf';Integrated Security=True");
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into Fakulteler(FakulteAdı) values(@fak_adi)", baglantı);
                komut.Parameters.AddWithValue("fak_adi", textBox1.Text.ToUpper());
                komut.ExecuteNonQuery();
                MessageBox.Show("Fakülte Başarıyle Eklendi");
                baglantı.Close();
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void fakulteekle_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void fakulteekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
