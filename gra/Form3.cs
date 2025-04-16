using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gra
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Akceptuj_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show($"Kliknięto przycisk w pozycji {btn.Tag}");
            Form2 form2 = new Form2();
            form2.Show();
        }
        // Kod w Form3

        // Kod w Form3 (po kliknięciu przycisku "Start")
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Pobieramy wartości wybrane w ComboBox
            int x = int.Parse(comboBox1.SelectedItem.ToString());
            int y = int.Parse(comboBox2.SelectedItem.ToString());

            // Tworzymy nową instancję Form2 i przekazujemy wartości x i y
            Form2 form2 = new Form2(x, y);
            form2.Show();
            this.Hide();
        }

        // Kod w Form2

        private int gridX;
        private int gridY;

        // Kod w Form3 (w konstruktorze lub metodzie Form_Load)
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

        private void CreateGridView()
        {
            // Ustawiamy liczbę wierszy i kolumn w GridView (lub TableLayoutPanel)
            gridX = int.Parse(comboBox1.SelectedItem.ToString());
            gridY = int.Parse(comboBox2.SelectedItem.ToString());

            // Tworzymy instancję TableLayoutPanel jako gridView
            TableLayoutPanel gridView = new TableLayoutPanel
            {
                RowCount = gridX,
                ColumnCount = gridY,
                Dock = DockStyle.Fill,
                AutoSize = true
            };
            // Dynamicznie tworzymy przyciski (lub inne kontrolki)
            for (int i = 0; i < gridX; i++)
            {
                for (int j = 0; j < gridY; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(50, 50);  // Ustawiamy rozmiar przycisku
                    btn.Tag = $"{i}-{j}";  // Tag z identyfikatorem pozycji

                    // Możesz dodać event kliknięcia, jeśli chcesz
                    btn.Click += Button_Click;

                    // Populate ComboBoxes
                    for (int i = 3; i <= 10; i++)
                    {
                        comboBox1.Items.Add(i.ToString());
                        comboBox2.Items.Add(i.ToString());
                    }

                    comboBox1.SelectedIndex = 0;
                    comboBox2.SelectedIndex = 0;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show($"Kliknięto przycisk w pozycji {btn.Tag}");
        }


    }
}
