using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiInputDataMahasiswa
{
    public partial class Form1 : Form
    {
        private List<Mahasiswa> list = new List<Mahasiswa>();
        public Form1()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        private void ResetForm()
        {
            txtNim.Clear();
            txtNama.Clear();
            txtKelas.Clear();
            txtNilai.Text = "";
            txtNim.Focus();
        }
        private void InisialisasiListView()
        {
            lvwMahasiswa.View = View.Details;
            lvwMahasiswa.FullRowSelect = true;
            lvwMahasiswa.GridLines = true;

            lvwMahasiswa.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nim", 91, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nama", 150, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Kelas", 70, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nilai", 50, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nilai Huruf", 90, HorizontalAlignment.Center);
        }

        private void TampilData()
        {
            lvwMahasiswa.Items.Clear();

            foreach(var Mhs in list)
            {
                var no = lvwMahasiswa.Items.Count + 1;
                var item = new ListViewItem(no.ToString());

                item.SubItems.Add(Mhs.Nim);
                item.SubItems.Add(Mhs.Nama);
                item.SubItems.Add(Mhs.Kelas);
                item.SubItems.Add(Mhs.Nilai.ToString());

                lvwMahasiswa.Items.Add(item);
            }
        }

        private void TampilHuruf(int nilai)
        {
            if
        }


        private bool isInvalidNumeric(char c)
        {
            if (c == (char)Keys.Back)
                return false;

            if(c >= '0' && c <= '9')
                return false;

            return true;
        }

        private void lvwMahasiswa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void txtNilai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isInvalidNumeric(e.KeyChar);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Mahasiswa Mhs = new Mahasiswa();

            Mhs.Nim = txtNim.Text;
            Mhs.Nama = txtNama.Text;
            Mhs.Kelas = txtKelas.Text;
            Mhs.Nilai = int.Parse(txtNilai.Text);

            list.Add(Mhs);

            var msg = "Data mahasiswa berhasil disimpan";

            MessageBox.Show(msg, "Ingfo", MessageBoxButtons.OK, MessageBoxIcon.Information );

            ResetForm();
        }

        private void btnTampilkanData_Click(object sender, EventArgs e)
        {
            TampilData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwMahasiswa.SelectedItems.Count > 0)
            {
                var confrm = MessageBox.Show("Yakin hapus?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confrm == DialogResult.Yes)
                {
                    var index = lvwMahasiswa.SelectedIndices[0];
                    list.RemoveAt(index);

                    TampilData();
                }
            }
            else
            {
                MessageBox.Show("Data mahasiswa belum dipilih!", "!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
