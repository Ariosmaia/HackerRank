using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo2
{
    class Program
    {
        static void Main(string[] args)
        {
            PalavraPalindroma pp = new PalavraPalindroma();
            Console.WriteLine("Digite uma palavra para verificar");
            pp.Palavra = Console.ReadLine();


            if (pp.VericaPalavra(pp.Palavra))
            {
                Console.WriteLine($"{pp.Palavra} é palindroma");
            }
            else
            {
                Console.WriteLine($"{pp.Palavra} não é palindroma");
            }
            
        }
    }
}
