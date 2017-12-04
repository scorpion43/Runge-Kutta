using Runge_Kutta.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runge_Kutta.Services
{
    class PerceptronService
    {

        public ResultOfTrainingSPL findWeightsAndThreshold(ref float[,] trainDataSet,
             int epochs, float errorMax, int amountOfPoints)
        {
            float w1, w2, w3, t1;
            float w4, w5, w6, t2;
            float w7, w8, w9, t3;

            float errorS = 0.0f;
            float sumError = 0.0f;
            float errorPrev = 0.0f;


            Random rnd = new Random();
            w1 = (float) rnd.NextDouble();
            w2 = (float) rnd.NextDouble();
            w3 = (float) rnd.NextDouble();
            t1 = (float) rnd.NextDouble();

            w4 = (float) rnd.NextDouble();
            w5 = (float) rnd.NextDouble();
            w6 = (float) rnd.NextDouble();
            t2 = (float) rnd.NextDouble();

            w7 = (float) rnd.NextDouble();
            w8 = (float) rnd.NextDouble();
            w9 = (float) rnd.NextDouble();
            t3 = (float) rnd.NextDouble();

            Debug.WriteLine("Wagi dla x: {0}, {1}, {2}", w1, w2, w3);

            for (int e = 0; e < epochs; e++)
            {
                float x;
                float y;
                float z;

                float desireValueX, newValueX;
                float desireValueY, newValueY;
                float desireValueZ, newValueZ;

                for (int i = 0; i < amountOfPoints; i += 1)
                {
                    desireValueX = trainDataSet[i + 1, 0];
                    desireValueY = trainDataSet[i + 1, 1];
                    desireValueZ = trainDataSet[i + 1, 2];

                    x = trainDataSet[i, 0];
                    y = trainDataSet[i, 1];
                    z = trainDataSet[i, 2];

                    float learningRate = (float) (1.00 / (1.00 + Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)));

                    newValueX = x * w1 + y * w2 + z * w3 - t1;
                    newValueY = x * w4 + y * w5 + z * w6 - t2;
                    newValueZ = x * w7 + y * w8 + z * w9 - t3;

                    w1 = w1 - learningRate * x * (newValueX - desireValueX);
                    w2 = w2 - learningRate * y * (newValueX - desireValueX);
                    w3 = w3 - learningRate * z * (newValueX - desireValueX);
                    t1 = t1 + learningRate * (newValueX - desireValueX);

                    w4 = w4 - learningRate * x * (newValueY - desireValueY);
                    w5 = w5 - learningRate * y * (newValueY - desireValueY);
                    w6 = w6 - learningRate * z * (newValueY - desireValueY);
                    t2 = t2 + learningRate * (newValueY - desireValueY);

                    w7 = w7 - learningRate * x * (newValueZ  - desireValueZ);
                    w8 = w8 - learningRate * y * (newValueZ - desireValueZ);
                    w9 = w9 - learningRate * z * (newValueZ - desireValueZ);
                    t3 = t3 + learningRate * (newValueZ - desireValueZ);

                    errorS = (float)(Math.Pow(newValueX - desireValueX, 2) +
                        Math.Pow(newValueY - desireValueY, 2) +
                        Math.Pow(newValueZ - desireValueZ, 2));

                    sumError += errorS;

                    
                }

                Debug.WriteLine("Wagi dla x: {0}, {1}, {2}", w1, w2, w3);
                Debug.WriteLine("Różnica między błędami: " + (errorPrev - errorS) + "dla epoki: " + e);
                errorPrev = errorS;

                Debug.WriteLine("");
                
                

            }

            Debug.WriteLine(sumError / 2);

            ResultForOneNeuron result1
                = new ResultForOneNeuron(w1, w2, w3, t1);

            ResultForOneNeuron result2
                = new ResultForOneNeuron(w4, w5, w6, t2);

            ResultForOneNeuron result3
                = new ResultForOneNeuron(w7, w8, w9, t3);

            ResultOfTrainingSPL resultAll = new ResultOfTrainingSPL(result1, result2, result3);

            return resultAll;
        }


    }
}
