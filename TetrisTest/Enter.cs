using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetrisTest.Controllers;

namespace TetrisTest
{
    public partial class Enter : Form
    {
        public int heightMap;
        public int widthMap;
        const int minHeightMap = 20;
        const int maxHeightMap = 50;
        const int minWidthMap = 15;
        const int maxWidthMap = 40;
        public Enter()
        {
            InitializeComponent();
            heightField.Text = $"от {minHeightMap} до {maxHeightMap}";
            widthField.Text = $"от {minWidthMap} до {maxWidthMap}";
            heightField.ForeColor = Color.Gray;
            widthField.ForeColor = Color.Gray;
        }

     

        private void buttonStart_Click(object sender, EventArgs e)
        {
            bool result = int.TryParse(heightField.Text, out var height) && int.TryParse(widthField.Text, out var width);
            if (result == true)
            {
                int _heightMap = int.Parse(heightField.Text);
                int _widthMap = int.Parse(widthField.Text);
                if (_heightMap >= minHeightMap && _heightMap <= maxHeightMap)
                {
                    if (_widthMap >= minWidthMap && _widthMap <= maxWidthMap)
                    {
                        MapController.heightMap = _heightMap;
                        MapController.widthMap = _widthMap;
                        MapController.map=new int [_heightMap, _widthMap];
                        this.Hide();
                        Game game = new Game();
                        game.Show();
                    }

                    else MessageBox.Show($"Ширина может быть от {minWidthMap} до {maxWidthMap}! Попробуйте еще раз!");
                }
                else MessageBox.Show($"Высота может быть от {minHeightMap} до {maxHeightMap}! Попробуйте еще раз!");
            }
            else MessageBox.Show($"Вы не ввели данные!Попробуйте еще раз!");
        }

        private void AddNewShape_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewShape addNewShape = new AddNewShape();
            addNewShape.Show();
        }

        private void heightField_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void widthField_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void heightField_Enter(object sender, EventArgs e)
        {
            if (heightField.Text == $"от {minHeightMap} до {maxHeightMap}")
            {
                heightField.Text = "";
                heightField.ForeColor = Color.Black;
            }
        }

        private void heightField_Leave(object sender, EventArgs e)
        {
            if (heightField.Text == "")
            {
                heightField.Text = $"от {minHeightMap} до {maxHeightMap}";
                heightField.ForeColor = Color.Gray;
            }
        }

        private void widthField_Enter(object sender, EventArgs e)
        {
            if (widthField.Text == $"от {minWidthMap} до {maxWidthMap}")
            {
                widthField.Text = "";
                widthField.ForeColor = Color.Black;
            }
        }

        private void widthField_Leave(object sender, EventArgs e)
        {
            if (widthField.Text == "")
            {
                widthField.Text = $"от {minWidthMap} до {maxWidthMap}";
                widthField.ForeColor = Color.Gray;
            }
        }
    }

}
