using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Numerics;

namespace Ejercicios.Project_Euler
{
    class Euler25
    {
        public void Fibonacci(int x)
        {
            int n = 1;
            BigInteger a = 0;
            BigInteger b = 1;
            for (BigInteger i = a; i <= x; ++i)
            {
                BigInteger j = b + a;
                ++n;
                if (j.ToString().Length == 1000)
                {
                    Console.WriteLine("Number: {0} with index {1}", j, n);
                    return;
                }
                a = b;
                b = j;
            }
        }

        public void Run()
        {
            Fibonacci(Int32.MaxValue);
        }
    }
}
