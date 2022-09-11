using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Numericos.Modelo
{
    internal class MetodosNumericos_Modelo
    {
            public double x0 { get; set; }    
            public double y0 { get; set; }
            public double h { get; set; }
            public double Ni { get; set; }

            //METODOS

            public double funcion_yReal(double x0)
            {

                double y = Math.Pow(((Math.Log(2 * (x0) + 1) / 4) + 2), 2);

                return y;
            }

            public double funcion_Euler(double x, double y, double h)
            {
                double f = Math.Sqrt(y) / (2 * (x) + 1);

                double y1 = y + (h * f);

                return y1;
            }

    }
}
