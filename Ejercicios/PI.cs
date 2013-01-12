using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios
{
    class PI
    {
        // Find PI to the Nth Digit
        // Enter a number and have the program generate PI up to that many decimal places. Keep a limit to how far the program will go.
        // Current State: Complete
        public void Run()
        {
            Console.WriteLine("Running {0}",GetType().Name);
            int x = int.Parse(Console.ReadLine());
            if (x <= 0 || x > 15)
                return;
            Console.WriteLine("Generating PI... 3,{0}",Math.PI.ToString().Substring(2,x));
        }
    }
}
