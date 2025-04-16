using System;
using System.Drawing;
using System.Windows.Forms;

namespace gra
{
    public partial class Form2 : Form
    {
        private int gridX;
        private int gridY;

        private int dydelfs;
        private int szops;
        private int krokodyle;
        private Button[,] buttons;
        private TableLayoutPanel gridView;
        public Form2(int x, int y)
        {
            InitializeComponent();
            
            CreateGridView();
        }
        public Form2(int dydelfs, int szops, int krokodyle)
        {
            InitializeComponent();

            this.dydelfs = dydelfs;
            this.szops = szops;
            this.krokodyle = krokodyle;
            //reateGridView();
            // Dodajemy TableLayoutPanel do formularza
            this.Controls.Add(gridView);

            // Rozmieszczamy zwierzęta
            PlaceAnimals();
        }
        private void PlaceAnimals()
        {
            // Lista wszystkich pozycji (komórek w gridzie)
            var positions = Enumerable.Range(0, 25).OrderBy(x => Guid.NewGuid()).ToList();

            // Umieszczanie Dydelfów
            for (int i = 0; i < dydelfs; i++)
            {
                int pos = positions[i];
                int row = pos / 5;  // Wyliczamy wiersz
                int col = pos % 5;  // Wyliczamy kolumnę
                buttons[row, col].Text = "Dydelf";
                buttons[row, col].BackColor = Color.Green;
            }

            // Umieszczanie Szopów
            for (int i = 0; i < szops; i++)
            {
                int pos = positions[dydelfs + i];
                int row = pos / 5;
                int col = pos % 5;
                buttons[row, col].Text = "Szop";
                buttons[row, col].BackColor = Color.Brown;
            }

            // Umieszczanie Krokodyli
            for (int i = 0; i < krokodyle; i++)
            {
                int pos = positions[dydelfs + szops + i];
                int row = pos / 5;
                int col = pos % 5;
                buttons[row, col].Text = "Krokodyl";
                buttons[row, col].BackColor = Color.DarkGreen;
            }
        }
        private void CreateGridView()
        {
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

                    // Dodajemy przycisk do gridView w odpowiednią komórkę
                    gridView.Controls.Add(btn, j, i);
                }
            }

            // Dodajemy gridView do Form2
            this.Controls.Add(gridView);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show($"Kliknięto przycisk w pozycji {btn.Tag}");
           //utton btn = sender as Button;

            // Jeśli jest puste pole
            if (btn.Text == "")
            {
                btn.Text = "Puste pole";
                btn.BackColor = Color.White;
            }
            // Jeśli kliknięto na zwierzę
            else
            {
                MessageBox.Show($"Znalazłeś {btn.Text}!");
            }
       
        }
    }
}
