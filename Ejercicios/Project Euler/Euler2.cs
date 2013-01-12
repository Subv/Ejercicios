using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.Project_Euler
{
    class Euler2
    {
        public bool IsEven(ulong n)
        {
            return (n % 2) == 0;
        }

        public void DoFibonacci()
        {
            ulong a = 0;
            ulong b = 1;
            ulong sum = 0;
            for (ulong i = a; ; ++i)
            {
                //Console.Write("{0} ", a);
                if (a >= 4000000)
                    break;
                ulong j = b + a;
                a = b;
                b = j;
                if(IsEven(a))
                    sum += a;
            }
            Console.WriteLine("Result: {0} and {1}",sum,a);
        }

        public void Run()
        {
            DoFibonacci();
            GC.Collect();
        }
    }
}
