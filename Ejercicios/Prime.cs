using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios
{
    class Prime
    {
        // Next Prime Number
        // Have the program find prime numbers until the user chooses to stop the asking for the next one.
        // Current State: Complete
        public void Run()
        {
            Console.WriteLine("Running {0}", GetType().Name);
            for (int n = 1; 1 != 2; ++n)
            {
                int factors = 0;
                for (int i = 1; i <= Math.Sqrt(n); ++i)
                {
                    if (n % i == 0)
                        factors++;
                }
                if (factors >= 2)
                    continue;
                Console.WriteLine("Next Prime: {0}",n);
                if (Console.ReadLine() == "stop")
                    return;
            }
        }
    }
}
