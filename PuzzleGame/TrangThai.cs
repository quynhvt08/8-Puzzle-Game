using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleGame
{
    internal class TrangThai
    {
        public int[,] trangthai;
        public int f, g, h, x, y;
        public TrangThai father;
        public int heuristic;
        public bool useLinearConflict;

        public TrangThai()
        {
            f = g = h = 0;
            father = null;
            heuristic = 0;
            useLinearConflict = false;
        }
        public void LinearConflict(TrangThai finish)
        {
            int n = trangthai.GetLength(0);
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int value = trangthai[i, j];
                    if (value != 0 && value != finish.trangthai[i, j])
                    {
                        for (int a = i; a < n; a++)
                        {
                            for (int b = (a == i) ? j + 1 : 0; b < n; b++)
                            {
                                int otherValue = trangthai[a, b];
                                if (otherValue != 0 && otherValue != finish.trangthai[a, b])
                                {
                                    if (value > otherValue && j > b)
                                    {
                                        count++;
                                    }
                                    if (value < otherValue && j < b)
                                    {
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            h = ManhattanDistance(finish) + 2 * count;
        }
        public int ManhattanDistance(TrangThai finish)
        {
            int n = trangthai.GetLength(0);
            int distance = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int value = trangthai[i, j];
                    if (value != 0)
                    {
                        int a = (value) / n;
                        int b = (value) % n;
                        distance += Math.Abs(i - a) + Math.Abs(j - b);
                    }
                }
            }
            return distance;
        }
        public void Tinh_h(TrangThai trangthai_dich)
        {
            // Tính giá trị h theo phương pháp Linear Conflict và Manhattan Distance
            LinearConflict(trangthai_dich);
        }

    }


}
