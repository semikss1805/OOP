using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProg m = new ArithmeticProg(0,0);
            m.InputProg(m);
            Console.WriteLine("{0} - сума заданих членiв прогресiї", m.SumOfEl());
            Console.WriteLine("Введiть номер елемента в прогресiї");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} - заданий член прогресiї", m[i]);
            Console.ReadKey();
        }
    }
}
