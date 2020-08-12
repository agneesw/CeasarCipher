using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsInlämning2
{
    class Lagring : ICipher
    {
        public List<Cipher> Ciphers { get; private set; }

        public Lagring()
        {
            Ciphers = new List<Cipher>();
        }

        /// <summary>
        /// Metoden tar emot en string och dekrypterar den.
        /// </summary>
        /// <param name="input">tar emot en string input</param>
        /// <returns>returnerar den nya </returns>
        public string Decrypt(string input)
        {
            for (int i = 0; i < Ciphers.Count; i++)
            {
               input = Ciphers[i].Decrypt(input);
               
            }
            return input;
        }

       /// <summary>
       /// Metoden lägger till ett chiffer i listan
       /// </summary>
       /// <param name="c"></param>
       /// 
        public void Add(Cipher c)
        {
            Ciphers.Add(c);
        }

        /// <summary>
        /// Metoden tar bort ett chiffer i listan
        /// </summary>
        /// <param name="r"></param>

        public void Remove(Cipher r)
        {
            Ciphers.Remove(r);
        }

        /// <summary>
        /// Metoden tar emot en string och enkrypterar den.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public string Encrypt(string input)
        {
            for (int i = 0; i < Ciphers.Count; i++)
            {
                input = Ciphers[i].Encrypt(input);
            }
            return input;
        }

    }
}
