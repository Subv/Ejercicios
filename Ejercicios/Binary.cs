using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios
{
    class Binary
    {
        // Binary to Decimal and Back Converter
        // Converter to convert a decimal number to binary or a binary number to its decimal equivalent.
        // Current State: Complete
        public void Run()
        {
            Console.WriteLine("Running {0}",GetType().Name);
            int n;
            if (!int.TryParse(Console.ReadLine(), out n))
                return;
            int x = 0; // n % 2;
            int y = n;
            for (int i = 1; i <= n; ++i)
            {
                /*Console.WriteLine("[DEBUG] x = {0}",x);
                Console.WriteLine("[DEBUG] y = {0}", y);
                Console.WriteLine("[DEBUG] i = {0}", i);*/
                y = y / 2;
                Console.Write("{0}",y == n/2? "" : y.ToString());
                x = y % 2;
            }
            GC.Collect();
        }
    }
}
