using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsInlämning2
{
    class ReversalCipher : Cipher

    {
        
        public ReversalCipher(string name) : base(name)
        {

        }

        /// <summary>
        /// Metoden tar emot en string och returnerar den baklänges
        /// </summary>
        /// <param name="input">strängen att vända tillbaks</param>
        /// <returns>returnerar input baklänges</returns>

        public override string Decrypt(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output = input[i] + output;
            }
            return output;
        }

        /// <summary>
        /// Metoden tar emot en string och returnerar den baklänges
        /// </summary>
        /// <param name="input">strängen att vända baklänges</param>
        /// <returns>returnerar input baklänges</returns>
        public override string Encrypt(string input)
        {
            string output = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output = output + input[i];
            }

            return output;
        }
    }
}
