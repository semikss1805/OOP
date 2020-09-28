using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] r = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse),
                dim = Dimension(r);
            int[][] h = new int[dim[0]][];
            Array.Sort(h);
        }

        static int[] Dimension (int[] r)
        {
            int m = r[0],
                max = r[0],
                length = 0;

            for (int i = 0; i < r.Length;)
            {
                if (r[i] > max) max = r[i];
                length++;
                i += r[i] + 1;
            }
            int[] dim = { length, max };
            return dim;
        }

        static void FillArr(ref int[,] h , int[] r)
        {
            int row = 0;
            int m = 0;
            for (int i = 0; i < r.Length;)
            {
                for(int j = i + 1;j <= i + r[i]; j++)
                {
                    h[row, m] = r[j];
                    m++;
                }
                i += r[i] + 1;
                row++;
                m = 0;
            }
        }
    }
}
