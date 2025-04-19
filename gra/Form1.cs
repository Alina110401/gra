namespace gra
{
    public partial class Form1 : Form
    {
        public ComboBox comboBox1 { get; set; } = new ComboBox();
        public ComboBox comboBox2 { get; set; } = new ComboBox();
        public ComboBox comboBox3 { get; set; } = new ComboBox(); // Dodano brakuj�cy ComboBox
        public ComboBox comboBox4 { get; set; } = new ComboBox(); // Dodano brakuj�cy ComboBox
        public ComboBox comboBox5 { get; set; } = new ComboBox(); // Dodano brakuj�cy ComboBox
        private int krokodyle = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            // Sprawdzamy, czy u�ytkownik wybra� warto�ci w ComboBox (x i y)
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                // Wy�wietlamy komunikat o b��dzie
                MessageBox.Show("Wype�nij ustawienia!", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Zatrzymujemy dalsze wykonanie metody
            }

            // Pobieramy warto�ci z ComboBox (x i y)
            int x = int.Parse(comboBox1.SelectedItem.ToString());  // Liczba kolumn
            int y = int.Parse(comboBox2.SelectedItem.ToString());  // Liczba wierszy

            // Pobieramy dane z ComboBox dla zwierz�t
            int dydelfs = int.Parse(comboBox3.SelectedItem.ToString());  // Liczba Dydelf�w
            int szops = int.Parse(comboBox5.SelectedItem.ToString());   // Liczba Szop�w
            int krokodyle = int.Parse(comboBox4.SelectedItem.ToString());  // Liczba Krokodyli

            // Tworzymy instancj� Form2 i przekazujemy dane
            Form2 form2 = new Form2(dydelfs, szops, krokodyle);  // Przekazujemy dane o zwierz�tach
            form2.Show();
            this.Hide();  // Ukrywamy Form3 po otwarciu Form2
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
       