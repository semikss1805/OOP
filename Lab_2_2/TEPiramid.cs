using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2
{
    public class TEPiramid : TETriangle    
    {
        public double h
        {
            get;
            set;
        }
        public TEPiramid(double a, double h) : base(a)
        {
            this.h = h;
        }
    }
}
