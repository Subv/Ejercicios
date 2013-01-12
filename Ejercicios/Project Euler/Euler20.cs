using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Ejercicios.Project_Euler
{
    class Euler20
    {
        public void Run()
        {
            BigInteger res1 = 1;
            for (BigInteger a = 100; a > 1; --a)
                res1 *= a;
            BigInteger sum = 0;
            foreach (char s in res1.ToString().ToCharArray())
            {
                BigInteger w = BigInteger.Parse(s.ToString());
                sum += w;
            }
            Console.WriteLine("Result: " + sum);
        }
    }
}
