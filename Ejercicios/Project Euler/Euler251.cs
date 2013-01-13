using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Ejercicios.Project_Euler
{
    class Euler251
    {
        // Note: Too Slow
        public void Run()
        {
            int count = 0;
            for (int a = 0; a <= 1000; ++a)
            {
                for (int b = 0; a + b <= 1000; ++b)
                {
                    for (int c = 0; a + b + c <= 1000; ++c)
                    {
                        double res1 = Math.Pow(a + (b * Math.Sqrt(c)), 1.0 / 3.0);
                        double r2_ = a - (b * Math.Sqrt(c));
                        double res2 = 0;
                        if (r2_ < 0)
                            res2 = -Math.Pow(-r2_, 1.0 / 3.0);
                        else
                            res2 = Math.Pow(r2_, 1.0 / 3.0);

                        double res = res1 + res2;
                        if (Utils.AreClose(res, 1.0d))
                            count++;
                    }
                }
            }
            Console.WriteLine("Result: {0}", count);
        }
    }
}
