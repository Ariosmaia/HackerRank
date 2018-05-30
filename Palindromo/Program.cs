using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = new string[]
            {
            "civic",
            "deified",
            "deleveled",
            "devoved",
            "dewed",
            "Hannah",
            "kayak",
            "level",
            "madam",
            "racecar",
            "radar",
            "redder",
            "refer",
            "repaper",
            "reviver",
            "rotator",
            "rotor",
            "sagas",
            "solos",
            "sexes",
            "stats",
            "tenet",
            "Dot",
            "Net",
            "Perls",
            "Is",
            "Not",
            "A",
            "Palindrome",
            };

            palavraPalindroma palindroma = new palavraPalindroma();

            foreach (var p in palavras)
            {
                if (palindroma.PalavrasPolindroma(p))
                {
                    Console.WriteLine($"{p} é Palindroma");
                }
                else
                {
                    Console.WriteLine($"{p} não é Palindroma");
                }
                

            }

        }



    }
}

