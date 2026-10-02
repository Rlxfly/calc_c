using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Penambahan(int a, int b)
        {
            return a + b;
        }

        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validasi input tidak boleh kosong
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Nilai A dan Nilai B harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi operasi harus dipilih
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Silakan pilih operasi terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var a = int.Parse(textBox1.Text);
            var b = int.Parse(textBox2.Text);
            int hasil = 0;

            switch (comboBox1.SelectedIndex)
            {
                case 0: // Penambahan
                    hasil = Penambahan(a, b);
                    break;
                case 1: // Pengurangan
                    hasil = Pengurangan(a, b);
                    break;
                case 2: // Perkalian
                    hasil = Perkalian(a, b);
                    break;
                case 3: // Pembagian
                    if (b == 0)
                    {
                        MessageBox.Show("Pembagian dengan nol tidak diperbolehkan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    hasil = Pembagian(a, b);
                    break;
            }

            //listBox1.Items.Add(hasil.ToString());
            // listBox1.Text = hasil.ToString();

            listBox1.Items.Clear();
            listBox1.Items.Add(hasil.ToString());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
