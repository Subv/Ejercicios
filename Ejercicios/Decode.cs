using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios
{
    class Decode
    {
        public void Run()
        {
            string Encrypted = "1tsaxqcuveba11e1s1a1dst";
            string Message = "";
            char[] msg = new char[Encrypted.Length];

            // par
            if ((Encrypted.Length % 2) == 0)
            {
                msg[0] = Encrypted[Encrypted.Length - 1];
                msg[1] = Encrypted[0];
                for (int i = 2; i < Encrypted.Length; i += 2)
                    msg[i] = Encrypted[i];
            }
            else // impar
            {
                msg[0] = Encrypted[(Encrypted.Length - 1) / 2];
                msg[1] = Encrypted[Encrypted.Length - 1];
                int i = 2;
                for (int w = 2; w < Encrypted.Length; ++w, ++i)
                    if ((w % 2) != 0)
                        msg[i] = Encrypted[w];
                msg[i-1] = Encrypted[0];
            }

            Message = new string(msg);
            Message = Message.Replace("\0", String.Empty);
            Console.WriteLine("Unencrypted message: {0}", Message.ToUpper());
        }
    }
}
