namespace gra
{
    public partial class Form1 : Form
    {
        public ComboBox comboBox1 { get; set; } = new ComboBox();
        public ComboBox comboBox2 { get; set; } = new ComboBox();
        public ComboBox comboBox3 { get; set; } = new ComboBox();
        public ComboBox comboBox4 { get; set; } = new ComboBox();
        public ComboBox comboBox5 { get; set; } = new ComboBox();

        private int krokodyle = 0;

        public Form1()
        {
            InitializeComponent();
            // Mo¿emy zainicjalizowaæ ComboBoxy z danymi
            InitializeComboBoxes();
        }

        // Inicjalizacja ComboBoxów z danymi (np. rozmiar planszy, liczba zwierz¹t)
        private void InitializeComboBoxes()
        {
            // ComboBox dla rozmiaru planszy
            for (int i = 3; i <= 10; i++)
            {
                comboBox1.Items.Add(i);  // Dla ComboBox1 - Liczba kolumn
                comboBox2.Items.Add(i);  // Dla ComboBox2 - Liczba wierszy
            }

            // ComboBoxy dla liczby zwierz¹t
            for (int i = 1; i <= 5; i++)
            {
                comboBox3.Items.Add(i);  // Dydelfy
                comboBox4.Items.Add(i);  // Krokodyle
                comboBox5.Items.Add(i);  // Szopy
            }

            // Domyœlnie ustawiamy wartoœci w ComboBoxach
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            // Sprawdzamy, czy u¿ytkownik wybra³ wartoœci w ComboBox (x i y)
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Wype³nij ustawienia!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Zatrzymujemy dalsze wykonanie metody
            }

            // Pobieramy wartoœci z ComboBox (x i y)
            int x = int.Parse(comboBox1.SelectedItem.ToString());  // Liczba kolumn
            int y = int.Parse(comboBox2.SelectedItem.ToString());  // Liczba wierszy

            // Pobieramy dane z ComboBox dla zwierz¹t
            int dydelfs = int.Parse(comboBox3.SelectedItem.ToString());  // Liczba Dydelfów
            int szops = int.Parse(comboBox5.SelectedItem.ToString());   // Liczba Szopów
            int krokodyle = int.Parse(comboBox4.SelectedItem.ToString());  // Liczba Krokodyli

            // Tworzymy instancjê Form2 i przekazujemy dane
            Form2 form2 = new Form2(x,y , dydelfs, szops, krokodyle);  // Przekazujemy dane o zwierzêtach
            form2.Show();  // Wyœwietlamy Form2
            this.Hide();  // Ukrywamy Form1 po otwarciu Form2
        }


        private void Ustawienia_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Koniec_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
