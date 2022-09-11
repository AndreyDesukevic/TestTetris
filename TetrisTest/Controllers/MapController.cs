using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisTest.Controllers
{
    public static class MapController
    {
        public static Shape currentShape;
        public static int heightMap;
        public static int widthMap;
        public static int size;
        public static int[,] map;
        public static int Interval;
        private static int offset=150;

        public static void ClearMap()
        {
            for (int i = 0; i < heightMap; i++)
            {
                for (int j = 0; j < widthMap; j++)
                {
                    map[i, j] = 0;
                }
            }
        }

        public static void DrawMap(Graphics e)
        {
            for (int i = 0; i < heightMap; i++)
            {
                for (int j = 0; j < widthMap; j++)
                {
                    if (map[i, j] == 1)
                    {
                        e.FillRectangle(Brushes.Red, new Rectangle(offset + j * size + 1, offset + i * size + 1, size - 1, size - 1));
                    }
                    if (map[i, j] == 2)
                    {
                        e.FillRectangle(Brushes.Yellow, new Rectangle(offset + j * size + 1, offset + i * size + 1, size - 1, size - 1));
                    }
                    if (map[i, j] == 3)
                    {
                        e.FillRectangle(Brushes.Green, new Rectangle(offset + j * size + 1, offset + i * size + 1, size - 1, size - 1));
                    }
                    if (map[i, j] == 4)
                    {
                        e.FillRectangle(Brushes.Blue, new Rectangle(offset + j * size + 1, offset + i * size + 1, size - 1, size - 1));
                    }
                    if (map[i, j] == 5)
                    {
                        e.FillRectangle(Brushes.Purple, new Rectangle(offset + j * size + 1, offset + i * size + 1, size - 1, size - 1));
                    }
                }
            }
        }

        public static void DrawGrid(Graphics g)
        {
            for (int i = 0; i <= heightMap; i++)
            {
                g.DrawLine(Pens.Black, new Point(offset, offset + i * size), new Point(offset + widthMap * size, offset + i * size));
            }
            for (int i = 0; i <= widthMap; i++)
            {
                g.DrawLine(Pens.Black, new Point(offset + i * size, offset), new Point(offset + i * size, offset + heightMap * size));
            }
        }

        public static void SliceMap()
        {
            int count = 0;
            for (int i = 0; i < heightMap; i++)
            {
                count = 0;
                for (int j = 0; j < widthMap; j++)
                {
                    if (map[i, j] != 0)
                        count++;
                }
                if (count == widthMap)
                {
                    for (int k = i; k >= 1; k--)
                    {
                        for (int o = 0; o < widthMap; o++)
                        {
                            map[k, o] = map[k - 1, o];
                        }
                    }
                }
            }
        }

        public static bool IsIntersects()
        {
            for (int i = currentShape.y; i < currentShape.y + currentShape.sizeMatrix; i++)
            {
                for (int j = currentShape.x; j < currentShape.x + currentShape.sizeMatrix; j++)
                {
                    if (j >= 0 && j <= widthMap - 1)
                    {
                        if (map[i, j] != 0 && currentShape.matrix[i - currentShape.y, j - currentShape.x] == 0)
                            return true;
                    }
                }
            }
            return false;
        }

        public static void Merge()
        {
            for (int i = currentShape.y; i < currentShape.y + currentShape.sizeMatrix; i++)
            {
                for (int j = currentShape.x; j < currentShape.x + currentShape.sizeMatrix; j++)
                {
                    if (currentShape.matrix[i - currentShape.y, j - currentShape.x] != 0)
                        map[i, j] = currentShape.matrix[i - currentShape.y, j - currentShape.x];
                }
            }
        }

        public static bool Collide()
        {
            for (int i = currentShape.y + currentShape.sizeMatrix - 1; i >= currentShape.y; i--)
            {
                for (int j = currentShape.x; j < currentShape.x + currentShape.sizeMatrix; j++)
                {
                    if (currentShape.matrix[i - currentShape.y, j - currentShape.x] != 0)
                    {
                        if (i + 1 == heightMap)
                            return true;
                        if (map[i + 1, j] != 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public static bool CollideHor(int dir)
        {
            for (int i = currentShape.y; i < currentShape.y + currentShape.sizeMatrix; i++)
            {
                for (int j = currentShape.x; j < currentShape.x + currentShape.sizeMatrix; j++)
                {
                    if (currentShape.matrix[i - currentShape.y, j - currentShape.x] != 0)
                    {
                        if (j + 1 * dir > widthMap - 1 || j + 1 * dir < 0)
                            return true;

                        if (map[i, j + 1 * dir] != 0)
                        {
                            if (j - currentShape.x + 1 * dir >= currentShape.sizeMatrix || j - currentShape.x + 1 * dir < 0)
                            {
                                return true;
                            }
                            if (currentShape.matrix[i - currentShape.y, j - currentShape.x + 1 * dir] == 0)
                                return true;
                        }
                    }
                }
            }
            return false;
        }

        public static void ResetArea()
        {
            for (int i = currentShape.y; i < currentShape.y + currentShape.sizeMatrix; i++)
            {
                for (int j = currentShape.x; j < currentShape.x + currentShape.sizeMatrix; j++)
                {
                    if (i >= 0 && j >= 0 && i < heightMap && j < widthMap)
                    {
                        if (currentShape.matrix[i - currentShape.y, j - currentShape.x] != 0)
                        {
                            map[i, j] = 0;
                        }
                    }
                }
            }
        }

    }
}
