using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Numerics;

namespace Ejercicios.Project_Euler
{
    // Status: _NOT_ finished, insufficient memory to loop 50 times.
    class Euler220
    {
        Euler220Form _Form;
        Euler220()
        {
            // _Form = new Euler220Form();
            // _Form.Show();
        }

        public void Run()
        {
            string D50 = "Fa";
            // n => a
            // x => b
            int i = 0;
            while (i < 10)
            {
                D50 = D50.Replace("a", "nRxFR");
                D50 = D50.Replace("b", "LFnLx");
                D50 = D50.Replace("n", "a");
                D50 = D50.Replace("x", "b");
                ++i;
            }
            Point Current = new Point(0, 0);
            int Angle = 90;
            BigInteger steps = 0;
            int Pos = 0;
            D50 = D50.Replace("a", String.Empty).Replace("b", String.Empty);
            BigInteger max = BigInteger.Pow(10, 12);
            // Trim to 10^12
            for (int d = 0; d < D50.Length; ++d)
            {
                if (D50[d] == 'F')
                    ++steps;
                if (steps >= max)
                {
                    Pos = d;
                    break;
                }
            }
            D50 = D50.Substring(0, Pos + 1);

            foreach (var c in D50)
            {
                if (c == 'F')
                {
                    Point old = Current;
                    if (Angle == 0 || Angle == 360)
                        ++Current.X;
                    else if (Angle == 90)
                        ++Current.Y;
                    else if (Angle == 180)
                        --Current.X;
                    else if (Angle == 270)
                        --Current.Y;
                    ++steps;
                }
                else if (c == 'R')
                {
                    if (Angle == 0 || Angle == 360)
                        Angle = 270;
                    else
                        Angle -= 90;
                }
                else if (c == 'L')
                {
                    if (Angle == 270)
                        Angle = 0;
                    else
                        Angle += 90;
                }
            }
            //graphics.Dispose();
            //pen.Dispose();
            Console.WriteLine("Final position: {0},{1}", Current.X, Current.Y);
        }
    }
}
