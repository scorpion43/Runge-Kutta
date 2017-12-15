using Runge_Kutta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runge_Kutta.Services
{
    class PointsManipulationService
    {
        public float[,] prepare3DForPerceptron(int startPoint, int amount, ResultOfTrainingSPL resultSPL, ref float[,] points)
        {
            float[,] realOutput = new float[amount, 3];

            float[] xRealOutput = getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.xResult, ref points);
            float[] yRealOutput = getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.yResult, ref points);
            float[] zRealOutput = getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.zResult, ref points);

            copyColumn1DArrayTo2DArray(ref xRealOutput, ref realOutput, 0);
            copyColumn1DArrayTo2DArray(ref yRealOutput, ref realOutput, 1);
            copyColumn1DArrayTo2DArray(ref zRealOutput, ref realOutput, 2);

            return realOutput;
        }

        public float[,] prepareRungeKuttaFor3D(int startPoint, int amount,ref float[,] points)
        {
            float[,] desiredOutput = new float[amount, 3];

            float[] xDesiredOutput = getDesiredOutputForCorrectionGraph(ref points, 0, startPoint, amount);
            float[] yDesiredOutput = getDesiredOutputForCorrectionGraph(ref points, 1, startPoint, amount);
            float[] zDesiredOutput = getDesiredOutputForCorrectionGraph(ref points, 2, startPoint, amount);

            copyColumn1DArrayTo2DArray(ref xDesiredOutput, ref desiredOutput, 0);
            copyColumn1DArrayTo2DArray(ref yDesiredOutput, ref desiredOutput, 1);
            copyColumn1DArrayTo2DArray(ref zDesiredOutput, ref desiredOutput, 2);

            return desiredOutput;
        }

        public float[] getDesiredOutputForCorrectionGraph(ref float[,] source, int columnNr, int start, int amount)
        {
            float[] destination = new float[amount];


            for (int i = start, index = 0; index < amount; i++, index++)
            {
                destination[index] = source[i, columnNr];
            }

            return destination;
        }

        public float[] getRealOtputForCorrectionGraph(int start,
            int amount, ResultForOneNeuron dataToCount,ref float[,] points) 
        {
            float[] destination = new float[amount];

            for (int i = start - 1, index = 0; i < (start + amount - 1); i++, index++)
            {

                destination[index] = points[i, 0] * dataToCount.w1 +
                    points[i, 1] * dataToCount.w2 +
                    points[i, 2] * dataToCount.w3 -
                    dataToCount.t;
            }

            return destination;
        }

        public void copyColumn1DArrayTo2DArray(ref float[] source, ref float[,] dest, int columnNr)
        {

            for (int i = 0; i < source.Length; i++)
            {
                dest[i, columnNr] = source[i];
            }

        }

    }
}
