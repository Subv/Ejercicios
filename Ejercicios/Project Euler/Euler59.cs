using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ejercicios.Project_Euler
{
    class Euler59
    {
        public void Run()
        {
            using (FileStream f = File.Open("euler59_cipher.txt", FileMode.Open))
            {
                int[] data = (new StreamReader(f)).ReadToEnd().Split(',').Select(str => int.Parse(str)).ToArray();
                byte[] x = Encoding.ASCII.GetBytes("the");
                byte[] key = new byte[3] { 0, 0, 0 };
                Dictionary<string, int> frequencyKeys = new Dictionary<string, int>();

                for (int i = 0; i < data.Length; i += 3)
                {
                    for (byte k = 97; k <= 122; ++k)
                    {
                        if ((data[i] ^ k) == x[0]) // Match t
                        {
                            key[0] = k;
                            for (byte w = 97; w <= 122; ++w)
                            {
                                if ((data[i + 1] ^ w) == x[1]) // Match h
                                {
                                    key[1] = w;
                                    for (byte m = 97; m <= 122; ++m)
                                    {
                                        if ((data[i + 2] ^ m) == x[2]) // Match e
                                        {
                                            key[2] = m;
                                            string str = Encoding.ASCII.GetString(key);
                                            int frq = 0;
                                            if (frequencyKeys.TryGetValue(str, out frq))
                                                frequencyKeys[str] = frq + 1;
                                            else
                                                frequencyKeys.Add(str, 1);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                string realKey = "";
                int max = 0;
                foreach (var kp in frequencyKeys)
                {
                    if (kp.Value > max)
                    {
                        max = kp.Value;
                        realKey = kp.Key;
                    }
                }
                Console.WriteLine("Key: {0}", realKey);

                var newData = new byte[data.Length];
                byte[] keybytes = Encoding.ASCII.GetBytes(realKey);
                for (int i = 0; i < data.Length; ++i)
                    newData[i] = Convert.ToByte(Convert.ToByte(data[i]) ^ keybytes[i % keybytes.Length]);

                Console.WriteLine("Data: {0}", Encoding.ASCII.GetString(newData));
                Console.WriteLine("Sum of ASCII Chars: {0}", newData.Sum(d => d));
            }
        }
    }
}
