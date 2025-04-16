namespace gra
{
    public partial class Form1 : Form
    {// Zmienna comboBox1 zadeklarowana w Form3
        public ComboBox comboBox1;
        public ComboBox comboBox2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {

            // Pobieramy wartoœci wybrane w ComboBox
            int x = int.Parse(comboBox1.SelectedItem.ToString());
            int y = int.Parse(comboBox2.SelectedItem.ToString());

            // Przekazujemy wartoœci x i y do Form2
            Form2 form2 = new Form2(x, y);
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
