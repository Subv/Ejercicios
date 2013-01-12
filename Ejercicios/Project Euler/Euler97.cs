using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Ejercicios.Project_Euler
{
    class Euler97
    {
        public void Run()
        {
            long mod = 10000000000;
            BigInteger prime = 28433 * BigInteger.ModPow(2, 7830457, mod) + 1;
            prime %= mod;
            string p = prime.ToString();
            Console.WriteLine("Prime: {0}\nAnd last ten digits: {1}", prime, p.Substring(p.Length - 10, 10));
        }
    }
}
