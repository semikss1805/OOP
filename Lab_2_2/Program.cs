using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TETriangle m = TETriangle.TInput();
            Console.WriteLine("{0} - периметр трикутника", m.Perimeter());
            Console.WriteLine("{0} - площа трикутника", m.Square());
            TETriangle s = TETriangle.TInput();
            if (TETriangle.Equal(m, s)) Console.WriteLine("трикутники рiвнi");
            else Console.WriteLine("трикутники нерiвнi");
            Console.ReadKey();
        }
    }
}
