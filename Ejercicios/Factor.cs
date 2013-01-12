using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios
{
    class Factor
    {
        // Prime Factorization
        // Have the user enter a number and find all Prime Factors (if there are any) and display them.
        // Current State: Complete
        public void Run()
        {
            Console.WriteLine("Running {0}",GetType().Name);
            ulong n;
            ulong a = 0;
            if (!ulong.TryParse(Console.ReadLine(), out n))
                return;
            for (ulong i = 1; i <= Math.Sqrt(n); ++i)
            {
                if (!(n % i == 0))
                    continue;
                int factors = 0;
                for (ulong m = 1; m <= Math.Sqrt(i); ++m)
                {
                    if (i % m == 0)
                        ++factors;
                }
                if (factors >= 2)
                    continue;
                if (i > a)
                    a = i;
                //Console.WriteLine(i);
                GC.Collect();
            }
            Console.WriteLine(a);
        }
    }
}
