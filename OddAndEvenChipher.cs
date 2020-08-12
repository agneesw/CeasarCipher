using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsInlämning2
{
    class OddAndEvenChipher : Cipher
    {
        public OddAndEvenChipher(string name) : base(name)
        {

        }

        /// <summary>
        /// Metoden tar emot en string och returnerar och flyttar om bokstäverna så att de kommer tillbaks till ursprungsläget
        /// </summary>
        /// <param name="input">Strängen att avkryptera</param>
        /// <returns>returnerar den avkrypterade strängen</returns>
        public override string Decrypt(string input)
        {
            string udda = input.Substring(0, input.Length / 2);
            string jämn = input.Substring(udda.Length);
            string temp = "";

            for (int i = 0; i < udda.Length; i++)
            {
                temp += jämn[i];
                temp += udda[i];
            }

            if (jämn.Length > udda.Length)
            {
                temp = temp + jämn[jämn.Length - 1];
            }

            return temp;

        }

        /// <summary>
        /// Metoden tar emot en string och returnerar och flyttar om bokstäverna så att de på udda positioner slås ihop med jämna bokstäverna
        /// </summary>
        /// <param name="input">strängen som ska krypteras</param>
        /// <returns>returnerar den krypterade strängen</returns>

        public override string Encrypt(string input)
        {
            string output = "";
            string jämn = "";
            for (int i = 0; i < input.Length; i ++)
            {
                if(i % 2 == 0)
                {
                    jämn += input[i]; 
                }
                else
                {
                    output += input[i];
                 }
            }
            return output + jämn;
        }
    }
}
