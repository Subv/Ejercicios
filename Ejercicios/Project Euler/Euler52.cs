using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Ejercicios.Project_Euler
{
    class Euler52
    {
        public void Run()
        {
            BigInteger result = 0;
            for (BigInteger i = 1; ; ++i)
            {
                List<BigInteger> nums = new List<BigInteger>();
                nums.Add(i);
                nums.Add(i * 2);
                nums.Add(i * 3);
                nums.Add(i * 4);
                nums.Add(i * 5);
                nums.Add(i * 6);
                string last = "";
                bool found = true;
                foreach (var n in nums)
                {
                    List<char> s = n.ToString().ToList();
                    s.Sort();
                    String res = new String(s.ToArray());
                    if (last == "")
                        last = res;

                    if (res != last)
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    result = i;
                    break;
                }
            }
            Console.WriteLine("Result: {0}", result.ToString());
        }
    }
}
