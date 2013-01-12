using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios.Project_Euler
{
    class Euler1
    {
        public void Run()
        {
            int sum = 0;
            for (int i = 0; i < 1000; ++i)
            {
                if (i % 5 == 0 || i % 3 == 0)
                {
                    //Console.WriteLine("Num: {0}",i);
                    sum += i;
                }
            }
            Console.WriteLine("The sum is {0}",sum);
        }
    }
}
