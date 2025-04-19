using System;
using System.Drawing;
using System.Windows.Forms;

namespace gra
{
    public partial class Form2 : Form
    {


        private int gridCols, gridRows;
        private int numDydelfs, numSzops, numKrokodyle;
        private Button[,] buttons;
        private TableLayoutPanel gridView;

        // Konstruktor przyjmujący wszystkie 5 parametrów

        public Form2(int x, int y, int dydelfs, int szops, int krokodyle)
        {
            //InitializeComponent();

            // 1) Zapamiętaj parametry
            gridCols = x;
            gridRows = y;
            numDydelfs = dydelfs;
            numSzops = szops;
            numKrokodyle = krokodyle;

            // 2) Zbuduj planszę i rozmieść zwierzęta
            CreateGridView();
            PlaceAnimals();
        }

        private void CreateGridView()
        {
            gridView = new TableLayoutPanel
            {
                RowCount = gridRows,
                ColumnCount = gridCols,
                Dock = DockStyle.Fill,
                AutoSize = true
            };

            buttons = new Button[gridRows, gridCols];

            for (int i = 0; i < gridRows; i++)
                for (int j = 0; j < gridCols; j++)
                {
                    var btn = new Button
                    {
                        Size = new Size(50, 50),
                        Tag = $"{i}-{j}",
                        BackColor = Color.Gray
                    };
                    btn.Click += Button_Click;
                    buttons[i, j] = btn;
                    gridView.Controls.Add(btn, j, i);
                }

            this.Controls.Add(gridView);
        }

        private void PlaceAnimals()
        {
            var positions = Enumerable
              .Range(0, gridRows * gridCols)
              .OrderBy(_ => Guid.NewGuid())
              .ToList();

            // Dydelfy
            for (int i = 0; i < numDydelfs; i++)
            {
                int pos = positions[i];
                int r = pos / gridCols, c = pos % gridCols;
                buttons[r, c].Text = "Dydelf";
                buttons[r, c].BackColor = Color.Green;
            }

            // Szopy
            for (int i = 0; i < numSzops; i++)
            {
                int pos = positions[numDydelfs + i];
                int r = pos / gridCols, c = pos % gridCols;
                buttons[r, c].Text = "Szop";
                buttons[r, c].BackColor = Color.Brown;
            }

            // Krokodyle
            for (int i = 0; i < numKrokodyle; i++)
            {
                int pos = positions[numDydelfs + numSzops + i];
                int r = pos / gridCols, c = pos % gridCols;
                buttons[r, c].Text = "Krokodyl";
                buttons[r, c].BackColor = Color.DarkGreen;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (string.IsNullOrEmpty(btn.Text))
            {
                btn.Text = "Puste pole";
                btn.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show($"Znalazłeś {btn.Text}!");
            }
        }

    }
}
