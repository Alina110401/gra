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
                        Tag = "Empty",         // domyślnie puste
                        BackColor = Color.Gray,      // **szary kafelek**
                        Text = ""               // bez tekstu
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
            for (int k = 0; k < numDydelfs; k++)
            {
                int pos = positions[k];
                int r = pos / gridCols, c = pos % gridCols;
                buttons[r, c].Tag = "Dydelf";
            }

            // Szopy
            for (int k = 0; k < numSzops; k++)
            {
                int pos = positions[numDydelfs + k];
                int r = pos / gridCols, c = pos % gridCols;
                buttons[r, c].Tag = "Szop";
            }
            // Krokodyle
            for (int k = 0; k < numKrokodyle; k++)
            {
                int pos = positions[numDydelfs + numSzops + k];
                int r = pos / gridCols, c = pos % gridCols;
                buttons[r, c].Tag = "Krokodyl";
            }
        }

        
          private void Button_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var content = (string)btn.Tag;

            // Wyłączamy wielokrotne klikanie
            btn.Click -= Button_Click;

            switch (content)
            {
                case "Empty":
                    btn.BackColor = Color.White;
                    btn.Text = "";  // lub np. "·"
                    break;

                case "Dydelf":
                    btn.BackColor = Color.Green;
                    btn.Text = "🐬";  // albo "Dydelf"
                    MessageBox.Show("Znalazłeś Dydelfa!");
                    break;

                case "Szop":
                    btn.BackColor = Color.Brown;
                    btn.Text = "🦝";  // albo "Szop"
                    MessageBox.Show("Znalazłeś Szopa!");
                    break;

                case "Krokodyl":
                    btn.BackColor = Color.DarkGreen;
                    btn.Text = "🐊";  // albo "Krokodyl"
                    MessageBox.Show("Uwaga! Krokodyl!");
                    break;
            }
        }
    } }
