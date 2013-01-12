using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Ejercicios.Project_Euler
{
    class Euler5
    {
        private static List<uint> GetDivisors(uint number)
        {
            List<uint> l = new List<uint>();
            for(uint i=2;i<=number && number != 1;i++)
            {
                while (number % i == 0)
                {
                    number = number / i;
                    l.Add(i);
                }
            }
            return l;
        }


        public void Run()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            uint res = 1;
            List<uint> mults = new List<uint>();
            for (uint i = 2; i < 20; i++)
            {
                if(res % i != 0)
                {
                    List<uint> divs = GetDivisors(i);
                    foreach (uint mult in mults)
                        divs.Remove(mult);
                    foreach(uint div in divs)
                    {
                        res *= div;
                        mults.Add(div);
                        Console.WriteLine(div);
                    }
                }
                
            }
            Console.WriteLine("Result " + res);
            sw.Stop();
            Console.WriteLine("Elapsed: {0}",sw.Elapsed);
            /*for(int x = 1;x < int.MaxValue-1; ++x)
            {
                bool correct = false;
                for (int i = 0; i <= 20; ++i)
                {
                    if (x % i == 0)
                    {
                        correct = true;
                    }
                    else
                    {
                        correct = false;
                        break;
                    }
                }
                if (correct)
                {
                    Console.WriteLine("The number is {0}", x);
                    sw.Stop();
                    Console.WriteLine("Time elapsed: {0}",sw.Elapsed);
                    break;
                }*/
            }
        }
    }

