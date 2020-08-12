using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsInlämning2
{
    class Rövarspråket : Cipher
    {
        public Rövarspråket(string name) : base(name)
        {
            
        }

      /// <summary>
      /// Denna metod tar emot en sträng på rövarspråket och översätter den till människospråk
      /// </summary>
      /// <param name="input">tar emot en sträng som ska avkrypteras</param>
      /// <returns>returnerar den avkrypterade strängen</returns>
        

        public override string Decrypt(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != 'a' && input[i] != 'e' && input[i] != 'i' && input[i] != 'o' && input[i] != 'u' && input[i] != 'y' && input[i] != 'å' && input[i] != 'ä' && input[i] != 'ö')
                {
                    input = input.Remove(i + 1, 2);
                }
            }
            return input;
        }

        /// <summary>
        /// Denna metod tar emot en sträng och översätter den till rövarspråket
        /// </summary>
        /// <param name="input">input är stringen som ska krypteras.</param>
        /// <returns>returnerar den krypterade strängen</returns>

        public override string Encrypt(string input)
        {
           
            string krypterad = "";
            string språk = "o";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] ==  'o' || input[i] == 'u' || input[i] == 'y' || input[i] == 'å' || input[i] ==  'ä' || input[i] == 'ö')
                {
                    krypterad += input[i];
                }
                if (input[i] != 'a' && input[i] != 'e' && input[i] != 'i' && input[i] != 'o' && input[i] != 'u' && input[i] != 'y' && input[i] != 'å' && input[i] != 'ä' && input[i] != 'ö')
                {
                    krypterad += input[i] + språk + input[i];
                }
            }
            return krypterad;


        }
    }
}
