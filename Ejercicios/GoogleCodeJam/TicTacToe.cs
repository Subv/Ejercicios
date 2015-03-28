using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ejercicios.GoogleCodeJam
{
    class TicTacToe
    {
        public void Run()
        {
            FileStream f = new FileStream("input.txt", FileMode.Open);
            FileStream f2 = new FileStream("output.txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(f2);
            StreamReader reader = new StreamReader(f);
            int n = int.Parse(reader.ReadLine());
            for (int i = 1; i <= n; ++i)
            {
                string res = "";
                bool won = false;
                char[,] matrix = new char[4, 4];
                int dots = 0;
                for (int j = 0; j < 4; ++j)
                {
                    string line = reader.ReadLine();
                    if (line.Replace("T", "X") == "XXXX")
                    {
                        res = "Case #{0}: X won";
                        won = true;
                        continue;
                    }
                    if (line.Replace("T", "O") == "OOOO")
                    {
                        res = "Case #{0}: O won";
                        won = true;
                        continue;
                    }
                    if (won)
                        continue;

                    for (int w = 0; w < 4; ++w)
                    {
                        matrix[j, w] = line[w];
                        if (line[w].ToString() == ".")
                            ++dots;
                    }
                }
                for (var j = 0; j < 4; ++j)
                {
                    string val2 = "";
                    for (var w = 0; w < 4; ++w)
                        val2 += matrix[w, j];
                    if (val2.Replace("T", "X") == "XXXX")
                    {
                        res = "Case #{0}: X won";
                        won = true;
                        break;
                    }
                    if (val2.Replace("T", "O") == "OOOO")
                    {
                        res = "Case #{0}: O won";
                        won = true;
                        break;
                    }
                }
                string val = "";
                for (var j = 0; j < 4; ++j)
                    val += matrix[j, j];
                if (val.Replace("T", "X") == "XXXX")
                {
                    res = "Case #{0}: X won";
                    won = true;
                }
                else if (val.Replace("T", "O") == "OOOO")
                {
                    res = "Case #{0}: O won";
                    won = true;
                }
                if (!won)
                {
                    val = "";
                    var s = 0;
                    for (var j = 3; j >= 0; --j)
                    {
                        val += matrix[j, s];
                        ++s;
                    }
                    if (val.Replace("T", "X") == "XXXX")
                    {
                        res = "Case #{0}: X won";
                        won = true;
                    }
                    else if (val.Replace("T", "O") == "OOOO")
                    {
                        res = "Case #{0}: O won";
                        won = true;
                    }
                }
                if (!won)
                {
                    if (dots > 0)
                        res = "Case #{0}: Game has not completed";
                    else
                        res = "Case #{0}: Draw";
                }
                reader.ReadLine();
                writer.WriteLine(String.Format(res, i));
                writer.Flush();
                Console.WriteLine(res, i);
            }
            f.Close();
            f2.Close();
        }
    }
}
