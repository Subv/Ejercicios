using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.Project_Euler
{
    class Euler21
    {
        public ulong GetSumDivisors(ulong n)
        {
            ulong sum = 0;
            for (ulong i = 2; i <= (n/2)+1; ++i)
            {
                if ((n % i) == 0)
                    sum += i;
            }
            return sum + 1;
        }

        public void Run()
        {
            ulong sum = 0;
            List<ulong> added = new List<ulong>();
            for (ulong i = 1; i < 10000; ++i)
            {
                if (added.Contains(i))
                    continue;
                ulong num = GetSumDivisors(i);
                if (added.Contains(num))
                    continue;
                ulong num2 = GetSumDivisors(num);
                if (num2 == i && i != num)
                {
                    sum += num + i;
                    added.Add(i);
                    added.Add(num);
                }
            }
            Console.WriteLine("Result: {0}", sum);
        }
    }
}
