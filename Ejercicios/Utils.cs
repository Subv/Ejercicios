using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Ejercicios
{
    public class Utils
    {
        public static unsafe bool AreClose(double value1, double value2)
        {
            if (value1 == value2)
                return true;

            double num2 = (((value1) + (value2)) + 10.0) * 2.2204460492503131E-16;
            double num = value1 - value2;
            return ((-num2 < num) && (num2 > num));
        }

        public static unsafe int FloatToInt32Bits(float f)
        {
            return *((int*)&f);
        }

        public static bool AlmostEqual2sComplement(float a, float b, int maxDeltaBits)
        {
            int aInt = FloatToInt32Bits(a);
            if (aInt < 0)
                aInt = Int32.MinValue - aInt;

            int bInt = FloatToInt32Bits(b);
            if (bInt < 0)
                bInt = Int32.MinValue - bInt;

            int intDiff = Math.Abs(aInt - bInt);
            return intDiff <= (1 << maxDeltaBits);
        }
    }
}
