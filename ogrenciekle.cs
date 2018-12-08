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
    public partial class ogrenciekle : Form
    {
       
     
        UniversiteEntities uni = new UniversiteEntities();
        public string kaynak = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\ASUS\documents\visual studio 2013\Projects\OgrenciBilgi\OgrenciBilgi\Universite.mdf';Integrated Security=True";
        public ogrenciekle()
        {
            InitializeComponent();
        }

        private void ogrenciekle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universite.Fakulteler' table. You can move, or remove it, as needed.
            this.fakultelerTableAdapter.Fill(this.universite.Fakulteler);
            textBox1.Focus();
            comboBox1.SelectedIndex =-1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {

            }

            else
            {
                comboBox2.Items.Clear();
                SqlConnection baglantı = new SqlConnection(kaynak);
                baglantı.Open();
                int id = (int)comboBox1.SelectedValue;
                SqlCommand komut = new SqlCommand("select * from Bolumler where FakulteID=@fktid", baglantı);
                komut.Parameters.AddWithValue("fktid", id);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    comboBox2.DisplayMember = dr[1].ToString();
                    comboBox2.ValueMember = dr[0].ToString();
                   comboBox2.Items.Add(dr[0] + " " + dr["BolumAdı"]);
                }
                baglantı.Close();
                comboBox2.SelectedIndex = -1;
            }
        
            
                    
                
            
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
             if (comboBox1.Text == "")
            {
                MessageBox.Show("LÜTFEN FAKÜLTE SEÇİNİZ");
            }
            
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBox1.TextLength==10)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox2.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            { MessageBox.Show("LÜTFEN BOŞ ALANLARI DOLDURUNUZ VEYA FAKÜLTE SEÇİNİZ"); }
            else
            {
                string secili = comboBox2.SelectedItem.ToString();
                int yer = secili.IndexOf(' ');
                int id = Convert.ToInt32(secili.Substring(0, yer));
                // MessageBox.Show(id.ToString());
                Ogrenciler yeniogr = new Ogrenciler();
                yeniogr.Numara = Convert.ToInt32(textBox1.Text);
                yeniogr.Ad = textBox2.Text;
                yeniogr.Soyad = textBox3.Text;
                yeniogr.Telefon = Convert.ToDecimal(textBox4.Text);
                yeniogr.FakulteID = (int)comboBox1.SelectedValue;
                yeniogr.BolumID = id;
                uni.Ogrencilers.Add(yeniogr);
                uni.SaveChanges();
                textBox1.Clear();
                textBox2.Clear();

                textBox3.Clear();
                textBox4.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                MessageBox.Show("Kayıt Eklendi");



            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBox4.TextLength == 11)
            {
                e.Handled = true;
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();
            //SqlConnection baglantı = new SqlConnection(kaynak);
            //baglantı.Open();
            //SqlCommand komut = new SqlCommand("select * from Fakulteler", baglantı);
            //SqlDataReader dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    comboBox1.Items.Add(dr[0] + " " + dr["FakulteAdı"]);
            //}
            //baglantı.Close();
        }

        private void ogrenciekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            comboBox1.SelectedIndex = -1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
          
        }

        private void ogrenciekle_Shown(object sender, EventArgs e)
        {
           
        }
      

      
    }
}
