using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenorDistancia
{
    class CalculoDistancia
    {
        private double _x1;
        private double _x2;
        private double _y1;
        private double _y2;

        public double CalculaDistanciaPC(double x1, double x2, double y1, double y2)
        {
            _x1 = x1;
            _x2 = x2;
            _y1 = y1;
            _y2 = y2;
            double resultado = Math.Sqrt(((x2-x1)*(x2 - x1)) +((y2+y1)*(y2 + y1)));
            return resultado;
        }
    }
}
