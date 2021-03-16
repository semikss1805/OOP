using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        private int x;
        private int y;
        public Point(int x_, int y_)
        {
            x = x_;
            y = y_;
        }
        
        public virtual void Show()
        {
            Console.WriteLine("x:{0}    y:{1}", x, y);
        }

        public int x_
        {
            get
            {
                return x;
            }
        }
        public int y_
        {
            get
            {
                return y;
            }
        }
    }
}
