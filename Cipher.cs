using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsInlämning2
{
    public abstract class Cipher : ICipher
    {
        public string Name { get; set; }

        public Cipher(string name)
        {
            Name = name; 
        }

        public abstract string Encrypt(string input);
        public abstract string Decrypt(string input);

        /// <summary>
        /// Skriver över standard implementationens ToString
        /// </summary>
        /// <returns>returnerar name</returns>
        public override string ToString()
        {
            return Name;   
        }
    }

}
