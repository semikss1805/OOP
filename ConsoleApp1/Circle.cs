using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle : Point
    {
        protected int radius;
        public Circle(int radius,int x,int y) : base(x, y)
        {
            this.radius = radius;
        }
        public override void Show()
        {
            Console.WriteLine("radius:{0} square:{1}",radius,Square(radius));
        }
        private double Square(int rad)
        {
            double result;
            result = Math.PI * Math.Pow(radius, 2);
            return result;
        }
    }
}
