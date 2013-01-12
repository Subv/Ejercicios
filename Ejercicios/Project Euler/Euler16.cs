using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Ejercicios.Project_Euler
{
    class Euler16
    {
        public void Run()
        {
            Console.WriteLine("{0}", Math.Pow(2, 1000));
            string x = BigInteger.Pow(2, 1000).ToString();
            BigInteger sum = 0;
            foreach (char s in x.ToCharArray())
            {
                BigInteger w = BigInteger.Parse(s.ToString());
                sum += w;
            }
            Console.WriteLine("The sum is: {0}",sum);
        }
    }
}
