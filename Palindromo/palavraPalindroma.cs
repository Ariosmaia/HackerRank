using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    class palavraPalindroma
    {
        private string[] _palavra;

       
        public bool PalavrasPolindroma(string palava)
        {
            char[] letras = palava.ToCharArray();
            Array.Reverse(letras);

            string palavraReversa = new string(letras);

            if (palava.ToLower() == palavraReversa.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
