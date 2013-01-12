using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.Project_Euler
{
    class Euler4
    {
        string EsPalindromo(String palabra)
        {
            palabra = palabra.Replace(" ","").ToLower();
            char[] inversa =palabra.ToCharArray();
            Array.Reverse(inversa);
            string strInversa =new string(inversa);
            return strInversa;
        }

        public void Run()
        {
            ulong curVal = 0;
            ulong z=0;
            ulong y =0;
            for (int i = 100; i < 999; ++i)
            {
                for (int x = 100; x < 999; ++x)
                {
                    string tmp = (x * i).ToString();
                    if (tmp.ToLower().Equals(EsPalindromo(tmp.ToLower())) && (ulong)(x*i) > curVal)
                    {
                        curVal = (ulong)(x * i);
                        y = (ulong)i;
                        z = (ulong)x;
                    }
                }
            }
            Console.WriteLine("Value {0} with {1}*{2}", curVal,z,y);
        }
    }
}
