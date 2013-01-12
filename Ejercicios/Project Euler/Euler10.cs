using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.Project_Euler
{
    class Euler10
    {
        public void Run()
        {
            ulong sum = 0;
            for (ulong n = 1; n < 2000000; ++n)
            {
                if (n % 2 == 0 && n != 2)
                    continue;
                int factors = 0;
                for (ulong i = 1; i <= Math.Sqrt(n); ++i)
                {
                    if (n % i == 0)
                        factors++;

                    if (factors >= 2)
                        break;
                }
                if (factors >= 2)
                    continue;
                sum += n;
            }
            Console.WriteLine("Number is: {0}",sum);
        }
    }
}
