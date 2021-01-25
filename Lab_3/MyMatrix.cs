using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class MyMatrix
    {
        private double[,] matrix;



        public MyMatrix(MyMatrix mtx)
        {
            matrix = (double[,])mtx.matrix.Clone();
        }
        public MyMatrix(double[,] mtx)
        {
            matrix = (double[,])mtx.Clone();
        }
        public MyMatrix(double[][] mtx)
        {
            matrix = new double[mtx.Length, mtx[0].Length];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = mtx[i][j];
                }
            }
        }
        public MyMatrix(string[] rows)
        {
            FillFromRows(rows);
        }
        public MyMatrix(string mtx)
        {
            string[] rows = mtx.Trim().Split('\n');
            FillFromRows(rows);
        }
        private void FillFromRows(string[] rows)
        {
            double[] m = Array.ConvertAll(rows[0].Trim().Split(), double.Parse);
            matrix = new double[rows.Length, m.Length];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                m = Array.ConvertAll(rows[i].Trim().Split(), double.Parse);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = m[j];
                }
            }
        }



        public static MyMatrix operator +(MyMatrix mtx_1, MyMatrix mtx_2)
        {
            double[,] result = new double[mtx_1.Height, mtx_1.Width];
            for (int i = 0; i < mtx_1.Height; i++)
            {
                for (int j = 0; j < mtx_1.Width; j++)
                {
                    result[i, j] = mtx_1.matrix[i, j] + mtx_2.matrix[i, j];
                }
            }
            return new MyMatrix(result);
        }
        public static MyMatrix operator *(MyMatrix mtx_1, MyMatrix mtx_2)
        {
            double[,] result = new double[mtx_1.Height, mtx_2.Width];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    for (int k = 0; k < mtx_1.Width; k++)
                    {
                        result[i, j] += mtx_1.matrix[i, k] * mtx_2.matrix[k, j];
                    }
                }
            }
            return new MyMatrix(result);
        }



        public int Height
        {
            get
            {
                return matrix.GetLength(0);
            }
        }
        public int Width
        {
            get
            {
                return matrix.GetLength(1);
            }
        }



        public int GetHeight()
        {
            return matrix.GetLength(0);
        }
        public int GetWidth()
        {
            return matrix.GetLength(1);
        }



        public double this[int i, int j]
        {
            get
            {
                return matrix[i, j];
            }
            set
            {
                matrix[i, j] = value;
            }
        }



        public double GetElement(int i, int j)
        {
            return matrix[i, j];
        }
        public void SetElement(int i, int j, double value)
        {
            matrix[i, j] = value;
        }



        override public String ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    result.Append(matrix[i, j]);
                    result.Append("\t");
                }
                result.Append("\n");
            }
            return result.ToString();
        }



        private double[,] GetTransponedArray()
        {
            double[,] transponed = new double[Width, Height];
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    transponed[j, i] = matrix[i, j];
                }
            }
            return transponed;
        }
        public MyMatrix GetTransponedCopy()
        {
            return new MyMatrix(GetTransponedArray());
        }
        public void TransponeMe()
        {
            matrix = GetTransponedArray();
        }
    }
}
