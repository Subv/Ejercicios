using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Ejercicios.Project_Euler
{
    class Euler55
    {
        static int Iters = 0;
        bool ProducesPalindrome(BigInteger i)
        {
            ++Iters;
            if (Iters >= 50)
                return false;

            string orig = i.ToString();
            string reverse = new string(orig.Reverse().ToArray());
            string res = (i + BigInteger.Parse(reverse)).ToString();
            var resRev = new string(res.Reverse().ToArray());
            if (resRev == res)
                return true;

            return ProducesPalindrome(BigInteger.Parse(res));
        }

        public void Run()
        {
            int number = 0;
            for (BigInteger i = 10; i <= 10000; ++i)
            {
                if (!ProducesPalindrome(i))
                    ++number;
                Iters = 0;
            }
            Console.WriteLine("Result: {0}", number);
        }
    }
}
