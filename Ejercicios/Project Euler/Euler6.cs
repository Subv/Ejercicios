using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace Ejercicios.Project_Euler
{
    class Euler6
    {
        public void Run()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int squares = 0;
            int sums = 0;
            int sum2 = 0;
            for (int i = 1; i <= 100; ++i)
            {
                squares += (int)Math.Pow(i, 2);
                sum2 += i;
            }
            sums = (int)Math.Pow(sum2, 2);
            sw.Stop();
            Console.WriteLine("The number is {0}",sums-squares);
            Console.WriteLine("Time Elapsed: {0}", sw.Elapsed);
        }
    }
}
