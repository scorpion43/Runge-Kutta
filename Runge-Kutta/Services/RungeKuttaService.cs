using ILNumerics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runge_Kutta.Services
{
    class RungeKuttaService
    {
        public float h = 0;

        public float[,] GeneratePointsByRungeKutta4k(float x0, float y0, float z0, float h)
        {
            float x = x0;
            float y = y0;
            float z = z0;
            this.h = h;

            float[,] points = new float[1500, 3];

            points[0, 0] = x;
            points[0, 1] = y;
            points[0, 2] = z;

            for (int i = 1; i < 1500; i++)
            {
                float m1 = FunctionXPrim(y);
                float k1 = FunctionYPrim(x, z);
                float l1 = FunctionZPrim(x, y, z);

                float m2 = FunctionXPrim(y + 0.5f * k1);
                float k2 = FunctionYPrim(x + 0.5f * m1, z + 0.5f * l1);
                float l2 = FunctionZPrim(x + 0.5f * m1, y + 0.5f * k1, z + 0.5f * l1);

                float m3 = FunctionXPrim(y + 0.5f * k2);
                float k3 = FunctionYPrim(x + 0.5f * m2, z + 0.5f * l2);
                float l3 = FunctionZPrim(x + 0.5f * m2, y + 0.5f * k2, z + 0.5f * l2);

                float m4 = FunctionXPrim(y + 0.5f * k3);
                float k4 = FunctionYPrim(x + 0.5f * m3, z + 0.5f * l3);
                float l4 = FunctionZPrim(x + 0.5f * m3, y + 0.5f * k3, z + 0.5f * l3);

                float nextX = GenerateNexValueOfTime(x, m1, m2, m3, m4);
                float nextY = GenerateNexValueOfTime(y, k1, k2, k3, k4);
                float nextZ = GenerateNexValueOfTime(z, l1, l2, l3, l4);

                x = nextX;
                y = nextY;
                z = nextZ;


                //Points[i, 0] = x;
                //Points[i, 1] = y;
                //Points[i, 2] = z;

                //Debug.WriteLine("i = " + i);

                if ((x >= float.PositiveInfinity || x <= float.NegativeInfinity) &&
                    (y >= float.PositiveInfinity || y <= float.NegativeInfinity) &&
                    (z >= float.PositiveInfinity || z <= float.NegativeInfinity))
                {
                    break;
                }

                points[i, 0] = x;
                points[i, 1] = y;
                points[i, 2] = z;

            }

            Debug.WriteLine("Długość tabeli z serwisu:  " + points.Length);
            
            for (int i = 0; i < 1500; i++)
            {
                Debug.WriteLine("i = " + i + ", x = " + points[i, 0] + ", y = " + points[i, 1] + ", z = " + points[i, 2]);
            }

            return points;
        }

        private float FunctionXPrim(float y)
        {
            return h * -0.2f * y;
        }

        private float FunctionYPrim(float x, float z)
        {
            return h * (x + z);
        }

        private float FunctionZPrim(float x, float y, float z)
        {
            return h * (x + y * y - z);
        }

        private float GenerateNexValueOfTime(float prevVal, float n1, float n2, float n3, float n4)
        {
            return prevVal + h / 6.0f * (n1 + 2 * n2 + 2 * n3 + n4);
        }

    }


}
