namespace gra
{
    public partial class Form1 : Form
    {
        public ComboBox comboBox1 { get; set; } = new ComboBox();
        public ComboBox comboBox2 { get; set; } = new ComboBox();
        private int krokodyle = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            int x = 5;
            int y = 5;

            if (comboBox1 != null && comboBox1.SelectedItem != null)
            {
                x = int.Parse(comboBox1.SelectedItem.ToString());
            }

            if (comboBox2 != null && comboBox2.SelectedItem != null)
            {
                y = int.Parse(comboBox2.SelectedItem.ToString());
            }

            Form2 form2 = new Form2(x, y, krokodyle);
            form2.Show();
            this.Hide();
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
        /*
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
        */