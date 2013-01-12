using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.Project_Euler
{
    class Euler12
    {
        public void Run()
        {
            long number;
            for (number = 1; ; ++number)
            {
                long sum = (number * (1 + number)) / 2;
                long divisors = 0;
                long sqrt = (long)Math.Sqrt(sum);

                for (long j = 1; j < sqrt; ++j)
                    if ((sum % j) == 0)
                        divisors += 2;

                if (sqrt * sqrt == sum)
                    --divisors;

                if (divisors > 500)
                {
                    number = sum;
                    break;
                }
            }
            Console.WriteLine("Result: {0}", number);
        }
    }
}
