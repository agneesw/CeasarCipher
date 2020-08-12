using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsInlämning2
{
    interface ICipher
    {
        string Encrypt(string input);

        string Decrypt(string input);
    }
}
