using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.Project_Euler
{
    class Euler7
    {
        public void Run()
        {
            int f = 0;
            for (int n = 1; ; ++n)
            {
                int factors = 0;
                for (int i = 1; i <= Math.Sqrt(n); ++i)
                {
                    if (n % i == 0)
                    {
                        factors++;
                        if (factors >= 2)
                            break;
                    }
                }
                if (factors >= 2)
                    continue;
                f++;
                if (f == 10002)
                {
                    Console.WriteLine("Number {0}",n);
                    break;
                }
            }
        }
    }
}
