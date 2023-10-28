using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace დავალება4
{
    internal class ChildClass: BaseClass
    {
        private double perimetri, partobi;

        public ChildClass(double side1, double side2, double side3)
        {
            side_1 = side1;
            side_2 = side2;
            side_3 = side3;
        }
        public double Perimetri()
        {

            perimetri = side_1 + side_2 + side_3;
            return perimetri;
            
        }
        public double Partobi()
        {
            partobi = 0.5 * side_1 * side_3;

            return partobi;
        }

    }
}
