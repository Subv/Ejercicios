using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Ejercicios.Project_Euler
{
    class Euler43
    {
        public int Fact(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; ++i)
                result *= i;
            return result;
        }

        public List<string> PermuteString(String beginningString, String endingString)
        {
            List<string> result = new List<string>();
            if (endingString.Length <= 1)
                result.Add(beginningString + endingString);
            else
            {
                for (int i = 0; i < endingString.Length; i++)
                {
                    String newString = endingString.Substring(0, i) + endingString.Substring(i + 1);
                    result.AddRange(PermuteString(beginningString + endingString.ElementAt(i), newString));
                }
            }
            
            return result;
        }

        IEnumerable<string> GetCombinations(string s, int length)
        {
            if (length > s.Length || length == 0)
                return new[] { String.Empty };

            if (length == 1)
                return s.Select(c => new string(new[] { c }));

            return from c in s
                   from combination in GetCombinations(
                       s.Remove(s.IndexOf(c), 1),
                       length - 1
                       )
                    select c + combination;
        }

        public void Run()
        {
            string original = "0123456789"; // Lets first combine this.
            List<string> Perms = GetCombinations(original, 10).ToList();

            int[] Primes = { 1, 2, 3, 5, 7, 11, 13, 17};
            BigInteger result = 0;
            for (int i = 0; i < Perms.Count; ++i)
            {
                bool add = true;
                for (int j = 1; j <= 7; ++j)
                {
                    int m = int.Parse(String.Format("{0}{1}{2}", Perms[i][j], Perms[i][j + 1], Perms[i][j + 2]));
                    if ((m % Primes[j]) != 0)
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                    result += BigInteger.Parse(Perms[i]);
            }
            Console.WriteLine("Result: {0}", result);
        }
    }
}
