using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo2
{
    class PalavraPalindroma
    {

        public string Palavra { get; set; }

        public bool VericaPalavra(string palavra)
        {

            char[] letras = palavra.ToCharArray();
            Array.Reverse(letras);

            string palavraReversa = new string(letras);

            if (palavra.ToLower() == palavraReversa.ToLower())
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
