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
    public partial class Form1 : Form
    {
        public string kaynak = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\ASUS\documents\visual studio 2013\Projects\OgrenciBilgi\OgrenciBilgi\Universite.mdf';Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        //    SqlConnection baglantı = new SqlConnection(kaynak);
        //    baglantı.Open();
        //    SqlCommand komut = new SqlCommand("select * from Fakulteler", baglantı);
        //    SqlDataReader dr = komut.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        comboBox1.Items.Add(dr[0]+" "+dr["FakulteAdı"]);
        //    }
        //    baglantı.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ogrenciekle frm = new ogrenciekle();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void öĞRENCİSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrencisil ogrsil = new ogrencisil();
            ogrsil.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void fAKÜLTEEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fakulteekle frm = new fakulteekle();
            frm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void öĞRENCİLİSTESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrencilistesi frm = new ogrencilistesi();
            frm.Show();
            this.Hide();
        }

        private void öĞRENCİDÜZENLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrenciduzenle frm = new ogrenciduzenle();
            frm.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bÖLÜMEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bolumekle frm = new bolumekle();
            frm.Show();
            this.Hide();
        }
    }
}
