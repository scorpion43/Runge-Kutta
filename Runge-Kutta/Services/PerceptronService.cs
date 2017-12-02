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
        private float errorMax = 0.00001f;
        private int epochs;
        private int amountOfPoints;

        public ResultOfTrainingSPL findWeightsAndThreshold(ref float[,] trainDataSet,
             int epochs, float errorMax, int amountOfPoints)
        {
            this.errorMax = errorMax;
            this.epochs = epochs;
            this.amountOfPoints = amountOfPoints;

            ResultForOneNeuron xResult =
                findForOneNeuron(ref trainDataSet, 0);
            ResultForOneNeuron yResult =
                findForOneNeuron(ref trainDataSet, 1);
            ResultForOneNeuron zResult =
                findForOneNeuron(ref trainDataSet, 2);

            ResultOfTrainingSPL resultGroup =
                new ResultOfTrainingSPL(xResult, yResult, zResult); 

            return resultGroup;
        }

        public ResultForOneNeuron findForOneNeuron(ref float[,] trainDataSet, int index)
        {
            float w1, w2, w3, t;

            Random rnd = new Random();
            w1 = (float)rnd.NextDouble();
            w2 = (float)rnd.NextDouble();
            w3 = (float)rnd.NextDouble();
            t = (float)rnd.NextDouble();

            float newValue = 0.0f;
            float desireValue = 0.0f;

            for (int e = 0; e < epochs; e++)
            {
                float x;
                float y;
                float z;

                

                for (int i = 0; i < amountOfPoints; i += 1)
                {
                    desireValue = trainDataSet[i + 1, index];

                    x = trainDataSet[i, 0];
                    y = trainDataSet[i, 1];
                    z = trainDataSet[i, 2];

                    float learningRate = (float) (1.00 / (1.00 + Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)));

                    newValue = x * w1 + y * w2 + z * w3 - t;

                    while (Math.Abs(newValue - desireValue) > errorMax)
                    {

                        w1 = w1 - learningRate * x * (newValue - desireValue);
                        w2 = w2 - learningRate * y * (newValue - desireValue);
                        w3 = w3 - learningRate * z * (newValue - desireValue);
                        t = t + learningRate * (newValue - desireValue);

                        newValue = x * w1 + y * w2 + z * w3 - t;

                    }

                }
                
                Debug.WriteLine("\n");
                Debug.WriteLine("Epoch ended: {0} for index {1}", e, index);
                Debug.WriteLine("w1: {0}, w2: {1}, w3: {2}, t: {3}", w1, w2, w3, t);

            }

            ResultForOneNeuron result
                = new ResultForOneNeuron(w1, w2, w3, t);


            return result;
        }


    }
}
