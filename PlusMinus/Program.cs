using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));

            PlusMinus(arr);
        }

        private static void PlusMinus(int [] arr)
        {
            int index = arr.Length;
            double contadorPostivo = 0;
            double contadorNegativo = 0;
            double contadorZero = 0;

            for (int i = 0; i < index; i++)
            {
                if (arr[i] > 0)
                {
                    contadorPostivo++;
                }
                else if (arr[i] < 0)
                {
                    contadorNegativo++;
                }
                else
                {
                    contadorZero++;
                }

            }

            double totalPositivo = contadorPostivo / index;
            double totalNegativo = contadorNegativo / index;
            double totalZero = contadorZero / index;

            Console.WriteLine(string.Format("{0:0.000000}", totalPositivo));
            Console.WriteLine(string.Format("{0:0.000000}", totalNegativo));
            Console.WriteLine(string.Format("{0:0.000000}", totalZero));
        }
    }
}
