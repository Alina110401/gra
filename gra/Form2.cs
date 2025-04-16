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

    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        // Kod w Form2

        private int gridX;
        private int gridY;


        // Kod w Form2

        // Zmienna do przechowywania rozmiaru planszy


        // Kod w Form2

    
        private void CreateGridView()
        {
            // Ustawiamy liczbę wierszy i kolumn w GridView (lub TableLayoutPanel)
            gridView.RowCount = gridX;
            gridView.ColumnCount = gridY;

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

                    // Dodajemy przycisk do GridView w odpowiednią komórkę
                    gridView.Controls.Add(btn);
                }
            }
        }
        public Form2(int x, int y)
        {
            InitializeComponent();
            this.gridX = x;
            this.gridY = y;

            // Tworzymy planszę na podstawie x i y
            CreateGridView();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show($"Kliknięto przycisk w pozycji {btn.Tag}");
        }


        private void CreateGridView()
        {
            // Sprawdzamy, czy gridView jest dostępny
            if (gridView == null)
            {
                MessageBox.Show("GridView jest null.");
                return;
            }

            // Ustawiamy liczbę wierszy i kolumn na podstawie wartości x i y
            gridView.RowCount = gridX;
            gridView.ColumnCount = gridY;

            // Dynamiczne tworzenie przycisków (lub innych kontrolek)
            for (int i = 0; i < gridX; i++)
            {
                for (int j = 0; j < gridY; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(50, 50);  // Ustawiamy rozmiar przycisku
                    btn.Tag = $"{i}-{j}";  // Tag z identyfikatorem pozycji

                    // Możesz dodać tutaj event kliknięcia, jeśli chcesz
                    btn.Click += Button_Click;

                    // Dodajemy przycisk do GridView w odpowiednią komórkę
                    DataGridViewCell cell = gridView[j, i];
                    if (cell != null)
                    {
                        cell.Value = btn;
                    }
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show($"Kliknięto przycisk w pozycji {btn.Tag}");
        }

    

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
