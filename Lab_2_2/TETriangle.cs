using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2
{
    public class TETriangle
    {
        private double a_;
        public double a
        {
            get { return a_; }
            set
            {
                if (value > 0) a_ = value;
                else throw new ArgumentException("Вказана некоректна величина сторони");
            }
        }

        public TETriangle (double a)
        {
            this.a = a; 
        }
        public TETriangle()
        {
            a = 1;
        }
        public double Perimeter()
        {
            return 3 * a;
        }
        public double Square()
        {
            return (Math.Pow(a, 2.0) * Math.Sqrt(3)) / 4;
        }
        public static bool Equal(TETriangle b, TETriangle c)
        {
            if (b.a == c.a) return true;
            else return false;
        }
        public static TETriangle TInput()
        {
            Console.WriteLine("Введiть сторону правильного трикутника");
            double b = double.Parse(Console.ReadLine());
            TETriangle m = new TETriangle(b);
            return m;               
        }
    }
}
