using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisTest
{
    public class NewShape
    {

        public static int mapSize = 4;
        public static int cellSize = 85;
        public static int offset = 130;
        public int activeCell = 8;
        public int[,] currentState = new int[mapSize, mapSize];
        public bool isTheFirstClick = true;
        public Button[,] cells = new Button[mapSize, mapSize];

        public void UnBlockAllButton(Label label)
        {
            isTheFirstClick = true;
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    currentState[i, j] = 0;
                    cells[i, j].Enabled = true;
                    cells[i, j].BackColor = Color.White;
                    activeCell = 8;
                    label.Text = $"{activeCell}";
                }
            }
        }
        public void BlockAllButton()
        {
            isTheFirstClick = false;
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (currentState[i, j] == 0)
                    {
                        cells[i, j].Enabled = false;
                        cells[i, j].BackColor = Color.Gray;
                    }
                    else if (activeCell == 0)
                        cells[i, j].Enabled = false;
                }
            }
        }
        public void UnBlockButton(int i, int j)
        {
            for (int k = i - 1; k <= i + 1; k++)
            {
                for (int l = j - 1; l <= j + 1; l++)
                {
                    if (!IsInsideMap(k, l))
                        continue;
                    else if (k == i && l == j)
                        continue;
                    else if (currentState[k, l] == 1)
                        continue;
                    else if (IsInsideMap(k + 1, l) && currentState[k + 1, l] == 1
                        || IsInsideMap(k - 1, l) && currentState[k - 1, l] == 1
                        || IsInsideMap(k, l + 1) && currentState[k, l + 1] == 1
                        || IsInsideMap(k, l - 1) && currentState[k, l - 1] == 1)
                        continue;
                    else
                    {
                        cells[k, l].Enabled = false;
                        cells[k, l].BackColor = Color.Gray;
                    }
                }
            }

        }
        public void BlockButton(int i, int j)
        {
            for (int k = i - 1; k <= i + 1; k++)
            {
                for (int l = j - 1; l <= j + 1; l++)
                {
                    if (!IsInsideMap(k, l))
                        continue;
                    if (k == i && l == j)
                        continue;
                    if (currentState[k, l] == 1)
                        continue;
                    if (k == i + 1 && l == j
                        || k == i - 1 && l == j
                        || k == i && l == j + 1
                        || k == i && l == j - 1)
                    {
                        currentState[k, l] = 0;
                        cells[k, l].Enabled = true;
                        cells[k, l].BackColor = Color.White;
                    }
                    else
                    {
                        if (IsInsideMap(k + 1, l) && currentState[k + 1, l] == 1
                            || IsInsideMap(k - 1, l) && currentState[k - 1, l] == 1
                            || IsInsideMap(k, l + 1) && currentState[k, l + 1] == 1
                            || IsInsideMap(k, l - 1) && currentState[k, l - 1] == 1)
                            continue;
                        else
                        {
                            cells[k, l].Enabled = false;
                            cells[k, l].BackColor = Color.Gray;
                        }
                    }
                }
            }
        }
        private bool IsInsideMap(int i, int j)
        {
            if (i < 0 || i >= mapSize || j < 0 || j >= mapSize)
            {
                return false;
            }
            return true;
        }

        public void RandomColor()
        {
            Random random = new Random();
            int newColor = random.Next(1, 5);

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (currentState[i, j] == 1)
                       currentState[i, j] = newColor;
                }
            }

        }

    }
}
