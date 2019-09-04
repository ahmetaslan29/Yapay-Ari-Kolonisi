using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Y.Arıkolonisi
{
    public static class Ackleyfunction
    {
        public static double aldeger = -5;
        public static double ustdeger = 5;

        public static double ACKLEYSFUNCTION (double x, double y)
        {
            return -20 * Math.Exp(-0.2 * Math.Sqrt(0.5*(Math.Pow(x,2)+Math.Pow(y,2)))) -Math.Exp(0.5*(Math.Cos(2*Math.PI*x)+Math.Cos(2*Math.PI*y)))+Math.E+20;
        }
    }
}
