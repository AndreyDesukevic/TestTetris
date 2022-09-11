using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisTest
{
    public partial class AddNewShape : Form
    {
        private NewShape newShape;
        public AddNewShape()
        {
            InitializeComponent();
            newShape = new NewShape();
            Init();
        }
        private void Init()
        {
            newShape.currentState = InitMap();
            InitCells();
        }
        private void InitCells()
        {
            for (int i = 0; i < NewShape.mapSize; i++)
            {
                for (int j = 0; j < NewShape.mapSize; j++)
                {
                    this.AactiveCell.Text = $"{newShape.activeCell}";
                    Button button = new Button();
                    button.Size = new Size(NewShape.cellSize, NewShape.cellSize);
                    button.BackColor = Color.White;
                    button.Location = new Point(j * NewShape.cellSize + NewShape.offset,
                        (i * NewShape.cellSize) + NewShape.offset);
                    button.Click += new EventHandler(OnCellClick);
                    this.Controls.Add(button);
                    newShape.cells[i, j] = button;
                }
            }
        }
        private int[,] InitMap()
        {
            int[,] arr = new int[NewShape.mapSize, NewShape.mapSize];
            for (int i = 0; i < NewShape.mapSize; i++)
            {
                for (int j = 0; j < NewShape.mapSize; j++)
                {
                    arr[i, j] = 0;
                }
            }
            return arr;
        }
        private void OnCellClick(object sender, EventArgs e)
        {
            var pressedButton = sender as Button;
            var i = (pressedButton.Location.Y - NewShape.offset) / NewShape.cellSize;
            var j = (pressedButton.Location.X - NewShape.offset) / NewShape.cellSize;

            if (newShape.currentState[i, j] == 0)
            {
                newShape.currentState[i, j] = 1;
                newShape.cells[i, j].BackColor = Color.Black;
                if (newShape.isTheFirstClick)
                    newShape.BlockAllButton();
                newShape.BlockButton(i, j);
                newShape.activeCell--;
                this.AactiveCell.Text = $"{newShape.activeCell}";
                if (newShape.activeCell == 0)
                    newShape.BlockAllButton();
            }
            else
            {
                newShape.currentState[i, j] = 0;
                newShape.cells[i, j].BackColor = Color.White;
                newShape.UnBlockButton(i, j);
                newShape.activeCell++;
                this.AactiveCell.Text = $"{newShape.activeCell}";
                if (newShape.activeCell == 8)
                    newShape.UnBlockAllButton(this.AactiveCell);
            }
        }
        private void Reset_Click(object sender, EventArgs e) => newShape.UnBlockAllButton(this.AactiveCell);
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Enter enter = new Enter();
            enter.Show();
        }
        private void AddNewShape_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        private void Add_Click(object sender, EventArgs e)
        {
            if (newShape.activeCell <= 7)
            {
                var listNewShape = Shape.AllShape;
                newShape.RandomColor();
                listNewShape.Add(newShape.currentState);
                MessageBox.Show("Новая фигура создана!");
                this.Hide();
                AddNewShape addNewShape = new AddNewShape();
                addNewShape.Show();
            }
            else
            {
                MessageBox.Show("Распределите хотя бы один блок!");
            }
        }
    }

}

