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

        public ResultOfTrainingSPL findWeightsAndThreshold(float learningRate, ref float[,] trainDataSet)
        {
            ResultForOneNeuron xResult =
                findForOneNeuron(learningRate, ref trainDataSet, 0);
            ResultForOneNeuron yResult =
                findForOneNeuron(learningRate, ref trainDataSet, 1);
            ResultForOneNeuron zResult =
                findForOneNeuron(learningRate, ref trainDataSet, 2);

            ResultOfTrainingSPL resultGroup =
                new ResultOfTrainingSPL(xResult, yResult, zResult); 

            return resultGroup;
        }

        public ResultForOneNeuron findForOneNeuron(float learningRate, ref float[,] trainDataSet, int index)
        {
            float w1, w2, w3, t;

            Random rnd = new Random();
            w1 = (float) rnd.NextDouble();
            w2 = (float)rnd.NextDouble();
            w3 = (float)rnd.NextDouble();
            t = (float)rnd.NextDouble();

            float newValue = 0.0f;
            float desireValue = 0.0f;

            for (int i = 0; i < 99; i++)
            {
                desireValue = trainDataSet[i + 1, index];

                float x = trainDataSet[i, 0];
                float y = trainDataSet[i, 1];
                float z = trainDataSet[i, 2];

                int count = 0;

                do
                {
                    newValue = x * w1 + y * w2 + z * w3 - t;
                    if (newValue != desireValue)
                    {
                        w1 = w1 - learningRate * x * (newValue - desireValue);
                        w2 = w2 - learningRate * y * (newValue - desireValue);
                        w3 = w3 - learningRate * z * (newValue - desireValue);
                        t = t + learningRate * (newValue - desireValue);
                    }
                    count++;    
                }
                while (newValue != desireValue && count != 1000);

                Debug.WriteLine("\n");
                Debug.WriteLine("Circuit {0}", i);
                Debug.WriteLine("w1: {0}, w2: {1}, w3: {2}, t: {3}", w1, w2, w3, t);
            }

            ResultForOneNeuron result 
                = new ResultForOneNeuron(w1, w2, w3, t);
            

            return result;
        }


    }
}
