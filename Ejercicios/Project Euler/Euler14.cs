using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Ejercicios.Project_Euler
{
    class Euler14
    {
        public BigInteger Odd(BigInteger i)
        {
            return (3 * i) + 1;
        }

        public BigInteger Even(BigInteger i)
        {
            return i / 2;
        }

        public void Run()
        {
            BigInteger i = 0;
            BigInteger num = 0;
            for (BigInteger j = 1000000; j > 1; --j)
            {
                BigInteger newNum = 0;
                for (BigInteger w = j; w > 1; )
                {
                    if (w % 2 == 0)
                        w = Even(w);
                    else
                        w = Odd(w);
                    //Console.WriteLine("-> " + w);
                    ++newNum;
                }
                if (newNum > num)
                {
                    i = j;
                    num = newNum;
                }
            }
            Console.WriteLine("Result: " + num + " and the number is: " + i);
        }
    }
}
