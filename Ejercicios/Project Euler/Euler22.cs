
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ejercicios.Project_Euler
{
    class Euler22
    {
        List<string> unordered = new List<string>();
        Dictionary<uint /* position */, string /* name */> Names = new Dictionary<uint, string>();

        public void Run()
        {
            ulong sum = 0;
            FileStream stream = File.OpenRead("names.txt");
            String str = new StreamReader(stream).ReadToEnd();
            String[] names = str.Split('"');
            foreach (var s in names)
                if (s != "," && s != "")
                    unordered.Add(s);
            unordered.Sort();
            for (ulong i = 0; i < (ulong)unordered.Count; ++i)
            {
                string s = unordered[(int)i];
                ulong value = 0;
                foreach (var c in s.ToCharArray())
                    value += Convert.ToUInt32(c) - 64;
                sum += (i+1) * value;
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}
