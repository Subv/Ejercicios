using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios
{
    class Reinas
    {
        int[,] tablero = new int[8, 8];
        int _intento = 1;

        public bool CheckDiagonal(int _i, int _j)
        {
            for (int i = 0; i <= 7 - _i; ++i)
                for (int j = 0; j <= 7 - _j; ++j)
                    if (tablero[Math.Abs(_i - i), Math.Abs(_j - j)] != 0 && tablero[Math.Abs(_i - i), Math.Abs(_j - j)] <= _intento)
                        return false;
                    else if (tablero[_i + i, _j + j] != 0 && tablero[_i + i, _j + j] <= _intento)
                        return false;

            return true;
        }

        public bool CheckRow(int _i, int _j)
        {
            for (int i = 0; i < 8; ++i)
                if (tablero[_j, i] != 0 && tablero[_j, i] <= _intento)
                    return false;

            for (int j = 0; j < 8; ++j)
                if (tablero[j, _i] != 0 && tablero[j, _i] <= _intento)
                    return false;

            return true;
        }

        public void Clear()
        {
            for (int i = 0; i <= 7; ++i)
                for (int j = 0; j <= 7; ++j)
                    tablero[i, j] = 0;
        }

        public void Run()
        {
            int num = 0;
            int stuck = 0;
            int[] res = new int[8];
            bool resuelto = false;
            while (!resuelto)
            {
                for (int i = 0; i < 8; ++i)
                {
                    for (int j = 0; j < 8; ++j)
                    {
                        if (CheckRow(i, j) && CheckDiagonal(i, j))
                        {
                            tablero[i, j] = _intento;
                            ++num;
                            stuck = 0;
                        }
                        else
                            ++stuck;

                        if (num >= 8)
                            resuelto = true;

                        if (stuck >= 16)
                        {
                            //Clear();
                            i = 0;
                            j = 0;
                            num = 0;
                            ++_intento;
                            stuck = 0;
                        }
                    }
                }
            }
        }
    }
}
