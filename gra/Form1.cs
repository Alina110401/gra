namespace gra
{
    public partial class Form1 : Form
    {
        public ComboBox comboBox1 { get; set; } = new ComboBox();
        public ComboBox comboBox2 { get; set; } = new ComboBox();
        public ComboBox comboBox3 { get; set; } = new ComboBox(); // Dodano brakuj¹cy ComboBox
        public ComboBox comboBox4 { get; set; } = new ComboBox(); // Dodano brakuj¹cy ComboBox
        public ComboBox comboBox5 { get; set; } = new ComboBox(); // Dodano brakuj¹cy ComboBox
        private int krokodyle = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            // Sprawdzamy, czy u¿ytkownik wybra³ wartoœci w ComboBox (x i y)
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                // Wyœwietlamy komunikat o b³êdzie
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
            Form2 form2 = new Form2(dydelfs, szops, krokodyle);  // Przekazujemy dane o zwierzêtach
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
       