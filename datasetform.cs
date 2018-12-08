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
    public partial class datasetform : Form
    {
        public datasetform()
        {
            InitializeComponent();
        }

        private void datasetform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universite.Fakulteler' table. You can move, or remove it, as needed.
            this.fakultelerTableAdapter.Fill(this.universite.Fakulteler);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
