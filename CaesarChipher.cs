using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsInlämning2
{
    class CaesarChipher : Cipher
    {
        public int Nyckel { get; set; }

        public CaesarChipher(string name, int nyckel) : base(name)
        {
            Nyckel = nyckel;
        }

        /// <summary>
        /// Metoden tar emot en string och returnerar en sträng som flyttar bakåt (i mitt fall 3) bokstäver.
        /// </summary>
        /// <param name="input">input är den strängen som ska avkrypteras</param>
        /// <returns>returnerar den avkrypterade strängen</returns>

        public override string Decrypt(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output += GetCipherChar(input[i], 26 - Nyckel);
            }
            return output;
        }
        /// <summary>
        /// Metoden tar emot en string och returnerar en sträng som flyttar framåt (i mitt fall 3) bokstäver.
        /// </summary>
        /// <param name="input">Input är den strängen som ska krypteras</param>
        /// <returns>Returnerar den krypterade strängen</returns>

        public override string Encrypt(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output += GetCipherChar(input[i], Nyckel);
            }
            return output;
        }

        /// <summary>
        /// Här är koden som ni gav oss.
        /// </summary>
       
        private char GetCipherChar(char c, int steps)
        {
            List<char> specialCharacters = new List<char>() { 'å', 'ä', 'ö' };

            if (!char.IsLetter(c) ||
                specialCharacters.Contains(char.ToLower(c)))
                return c;

            char d = char.IsUpper(c) ? 'A' : 'a';
            return (char)((((c + steps) - d) % 26) + d);
        }

    }
}
