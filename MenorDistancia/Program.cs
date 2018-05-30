using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenorDistancia
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoDistancia calculo = new CalculoDistancia();

            Console.WriteLine("Digite o valor ponto A de x1");
            double pontoAX1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor PONTO A de y1");
            double pontoAY1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor PONTO B de x2");
            double pontoBX2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor PONTO B de y2");
            double pontoBY2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Distancia entre ponto A e B é: " + calculo.CalculaDistanciaPC(pontoAX1, pontoBX2, pontoAY1, pontoBY2));
            
        }
    }
}
