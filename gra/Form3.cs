using System;
using System.Windows.Forms;

namespace gra
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Wypełnianie ComboBoxami
        private void Form3_Load(object sender, EventArgs e)
        {
            // Wypełniamy ComboBox1 (x) wartościami od 3 do 10
            for (int i = 3; i <= 10; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }

            // Wypełniamy ComboBox2 (y) wartościami od 3 do 10
            for (int i = 3; i <= 10; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }

            // Opcjonalnie: Ustawiamy domyślną wartość dla ComboBoxów
            comboBox1.SelectedIndex = 0;  // Ustawiamy domyślnie 3 dla ComboBox1
            comboBox2.SelectedIndex = 0;  // Ustawiamy domyślnie 3 dla ComboBox2
        }

        private void btnStart_Click(object sender, EventArgs e)
        { // 1) Odczytujemy rozmiar planszy z ComboBox‑ów
            int x = comboBox1.SelectedItem != null
                    ? int.Parse(comboBox1.SelectedItem.ToString())
                    : 5;   // domyślnie 5
            int y = comboBox2.SelectedItem != null
                    ? int.Parse(comboBox2.SelectedItem.ToString())
                    : 5;

            // 2) Odczytujemy liczby zwierząt
            int dydelfs = int.Parse(comboBox3.SelectedItem.ToString());
            int szops = int.Parse(comboBox5.SelectedItem.ToString());
            int krokodyle = int.Parse(comboBox4.SelectedItem.ToString());

            // 3) Tworzymy Form2 z przekazanymi wartościami
            Form2 form2 = new Form2(x, y, dydelfs, szops, krokodyle);
            form2.Show();
            this.Hide();  // ukrywamy Form3
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
