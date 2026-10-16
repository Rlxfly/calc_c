using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLatihanTiga3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var nama = txtNama.Text;
            var pend = cmbPendidikan.Text;
            var job = lstPekerjaan.Text;

            txtPesan1.Text = string.Format("Hy {0}", nama);
            txtPesan2.Text = string.Format("Pendidikan kmu {0}?", pend);
            txtPesan3.Text = string.Format("Loh ada {0}", job); 
        }

        private void txtPesan1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
