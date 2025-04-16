using System;
using System.Drawing;
using System.Windows.Forms;

namespace gra
{
    public partial class Form2 : Form
    {
        private int gridX;
        private int gridY;

        public Form2(int x, int y)
        {
            InitializeComponent();
            this.gridX = x;
            this.gridY = y;
            CreateGridView();
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
        }
    }
}
