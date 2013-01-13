using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Ejercicios.Project_Euler
{
    class Euler202
    {
        enum Segments
        {
            AB,
            BC,
            AC
        }

        struct FloatPoint
        {
            public FloatPoint(float x, float y)
            {
                X = x;
                Y = y;
            }

            public float X, Y;

            public override string ToString()
            {
                return String.Format("FloatPoint X={0}, Y={1}", X, Y);
            }
        }

        struct Vector3
        {
            public FloatPoint A, B, C;
        }

        struct Triangle 
        {
            public Triangle(float size, float originX, float originY)
            {
                Origin = new FloatPoint(originX, originY);
                Vertices = new Vector3();
                Vertices.C = new FloatPoint(originX, originY);
                Vertices.B = new FloatPoint((size / 2) + originX, originY + Convert.ToSingle(Math.Sqrt(Convert.ToDouble((size * size) - ((size / 2) * (size / 2))))));
                Vertices.A = new FloatPoint(originX - (size / 2), originY + Convert.ToSingle(Math.Sqrt(Convert.ToDouble((size * size) - ((size / 2) * (size / 2))))));
                Height = Convert.ToSingle(Math.Sqrt(Convert.ToDouble((size * size) - ((size / 2) * (size / 2)))));
            }

            public void Traslate(Segments reference)
            {
                switch (reference)
                {
                    case Segments.AB:

                        break;
                }
            }

            public Vector3 Vertices;
            public FloatPoint Origin;
            public float Height;
        }

        struct Ray
        {
            public Ray(float m, float originX, float originY, float b)
            {
                Slope = m;
                Origin = new FloatPoint(originX, originY);
                B = b;
            }

            public float Slope;
            public float B;
            public FloatPoint Origin;

            public FloatPoint CalculatePointAt(float x)
            {
                return new FloatPoint(x, x * Slope + B);
            }
        }

        // y = mx + b
        public void Run()
        {
            Triangle tri = new Triangle(2, 0, 0);
            Console.WriteLine(tri.Vertices.B.ToString());
        }
    }
}
