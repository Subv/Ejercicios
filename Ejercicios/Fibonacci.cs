using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios
{
    class Fibonacci
    {
        public void DoFibonacci(int x)
        {
            int a = 0;
            int b = 1;
            for(int i = a; i <= x; ++i)
            {
                Console.Write("{0} ",a);
                int j = b + a;
                a = b;
                b = j;
            }
        }
        // Fibonacci Sequence
        // Enter a number and have the program generate the Fibonacci sequence to that number or to the Nth number.
        // Current State: Complete
        public void Run()
        {
            Console.WriteLine("Running {0}",GetType().Name);
            int x;
            if (!int.TryParse(Console.ReadLine(), out x))
                return;
            DoFibonacci(x);
            GC.Collect();
        }
    }
}
