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
        {
            // Pobieramy wartości wybrane w ComboBox
            int x = int.Parse(comboBox1.SelectedItem.ToString());
            int y = int.Parse(comboBox2.SelectedItem.ToString());

            int dydelfs = int.Parse(comboBox3.SelectedItem.ToString());  // Liczba Dydelfów
            int szops = int.Parse(comboBox5.SelectedItem.ToString());   // Liczba Szopów
            int krokodyle = int.Parse(comboBox4.SelectedItem.ToString());  // Liczba Krokodyli

            // Tworzymy nową instancję Form2 i przekazujemy wartości x i y
            Form2 form2 = new Form2(dydelfs, szops, krokodyle);  // Przekazujemy dane o zwierzętach
            form2.Show();
            this.Hide(); // Ukrywamy Form3 po otwarciu Form2
        }
    }
}
