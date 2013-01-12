using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.Project_Euler
{
    class Euler9
    {
        public void Run()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            int c2 = (int)(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("c2 = {0} and log {1}",c2,Math.Ceiling(Math.Log(Math.Pow(a,2)+Math.Pow(b,2),2)));
            //Math.Pow(a, 2) + Math.Pow(b, 2) = Math.Pow(c, 2);
            //Math.Log(Math.Pow(a, 2) + Math.Pow(b, 2), 2) = c;
            int testbug = (int)Math.Ceiling(Math.Log(Math.Pow(a, 2) + Math.Pow(b, 2), 2)) - c;
            Console.WriteLine("Should be 0: {0}",testbug);
            //a + b + c = 1000; n
        }
    }
}
