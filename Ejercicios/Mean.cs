using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios
{
    // Make a program that calculates the sum, mean, minimum, and maximum of a series of numbers.
    // http://www.eit.ihk-edu.dk/subjects/cpp/mean.html
    // Current State: Complete
    class Mean
    {
        List<int> numbers = new List<int>();
        public void DoResults()
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;
            foreach(int i in numbers)
            {
                if (i > max)
                    max = i;
                if (i < min)
                    min = i;
                sum += i;
            }
            Console.WriteLine("The max is {0}, the min is {1}, the total is {2}",max,min,sum);
        }
        public void Run()
        {
            Console.WriteLine("Running {0}", this.GetType().Name);
            Console.WriteLine("Type \"continue\" to finish the writting, 0 to exit");
            for(int i = 0; 1 != 2; ++i)
            {
                string ns = Console.ReadLine();
                if (ns == "continue")
                {
                    DoResults();
                    return;
                }
                Int32 n = 0;
                if (!Int32.TryParse(ns, out n))
                    return;
                if(n == 0)
                    return;
                numbers.Add(n);
                GC.Collect();
            }
        }
    }
}
