using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Ejercicios.Project_Euler
{
    class Euler48
    {
        public void Run()
        {
            BigInteger result = 0;
            for (BigInteger i = 1; i <= 1000; ++i)
                result += BigInteger.Pow(i, (int)i);
            Console.WriteLine("Result: {0} and the last 10 digits: {1}", result, result.ToString().Substring(result.ToString().Length - 10, 10));
        }
    }
}
