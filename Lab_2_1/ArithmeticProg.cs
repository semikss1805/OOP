using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class ArithmeticProg
    {
        private double a;
        private double d;
        public ArithmeticProg(double a, double d)
        {
            this.a = a;
            this.d = d;
        }
        public double this [int i]
        {
            get
            {
                if (d != 0 && i > 0) return a + (i-1) * d;
                else throw new ArgumentException("Номер єлемента < 1 або рiзниця прогресiї дорiвнює нулю");
            }
        }
        public double SumOfEl()
        {
            Console.WriteLine("Введiть кількiсть єлементiв для суми");
            int i = int.Parse(Console.ReadLine());
            double sum = 0;
            if (i > 0 && d != 0)
            {
                for(int j = 0;j < i; j++)
                {
                    sum += a + j * d;
                }
                return sum;
            }
            else throw new ArgumentException("Кiлькість єлементів < 1 або рiзниця прогресiї дорiвнює нулю");
        }
        public void InputProg(ArithmeticProg m)
        {
            Console.WriteLine("Введiть перший член прогресiї");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть рiзницю прогресiї");
            double d = int.Parse(Console.ReadLine());
            m.a = a;
            m.d = d;
        }
    }
}
