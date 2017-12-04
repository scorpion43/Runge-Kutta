﻿using ILNumerics;
using Runge_Kutta.Models;
using Runge_Kutta.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runge_Kutta
{
   
    public partial class Form1 : Form
    {

        public float[,] points = new float[1500, 3];

        private RungeKuttaService rungeKuttaService = new RungeKuttaService();
        private PerceptronService pService = new PerceptronService();
        private ResultOfTrainingSPL resultSPL;

        private float learningRate = 0.1f;

        public float h;
        public float x0;
        public float y0;
        public float z0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            h = float.Parse(HTextBox.Text);
            x0 = float.Parse(XTextBox.Text);
            y0 = float.Parse(YTextBox.Text);
            z0 = float.Parse(ZTextBox.Text);

            points = rungeKuttaService.GeneratePointsByRungeKutta4k(x0, y0, z0, h);
            MessageBox.Show("Generating points complete.");

            Debug.WriteLine("Długość Tablicy POINTS = " + points.Length);

            /*for (int i = 0; i < 1500; i++)
            {
                Debug.WriteLine("i = " + i + ", x = " + points[i, 0] + ", y = " + points[i, 1] + ", z = " + points[i, 2]);
            }*/

        }

        private void ShowFirstGraphButton_Click(object sender, EventArgs e)
        {
            Plotting_Form1.POINTS = points;
            new Plotting_Form1().Show();
        }

        private void ShowSecondGraphButton_Click(object sender, EventArgs e)
        {
            float[] pointsFor2DGraph = ChooseArrayPoints();
            Plotting_Form2.POINTS_2D = pointsFor2DGraph;
            new Plotting_Form2().Show();
        }


        private float[] ChooseArrayPoints()
        {
            float[] pointsFor2DGraph = new float[1500];

            if (XRadioButton.Checked)
            {
                pointsFor2DGraph = copyColumn2DArrayTo1DArray(ref points, 0);
            }
            else if (YRadioButton.Checked)
            {
                pointsFor2DGraph = copyColumn2DArrayTo1DArray(ref points, 1);
            }
            else if (ZRadioButton.Checked)
            {
                pointsFor2DGraph = copyColumn2DArrayTo1DArray(ref points, 2);
            }

            return pointsFor2DGraph;
        }

        private float[] copyColumn2DArrayTo1DArray(ref float[,] source, int columnNr)
        {
            float[] destination = new float[1500];

            //Debug.WriteLine("Rozpoczynam procedurę kopiowania");

            for (int i = 0; i < 1500; i++)
            {
                ///Debug.WriteLine(i);
                destination[i] = source[i, columnNr];
            }

            return destination;
        }
   
        private void TrainButton_Click(object sender, EventArgs e)
        {
            
            float errorMax = float.Parse(ErrorMaxTB.Text);
            int amountOfPoints = Int32.Parse(AmountOfPointsTB.Text);
            resultSPL = pService.findWeightsAndThreshold(ref points, errorMax, amountOfPoints);

            Debug.WriteLine("Learning Rate: " + learningRate);

            MessageBox.Show("Training Complete.");

            XResultLabel.Text = "For(X): w11: " + resultSPL.xResult.w1 
                + ", w21: " + resultSPL.xResult.w2 + ", w31: " + resultSPL.xResult.w3
                + ",  t1: " + resultSPL.xResult.t;

            YResultLabel.Text = "For(Y): w12: " + resultSPL.yResult.w1
                + ", w22: " + resultSPL.yResult.w2 + ", w32: " + resultSPL.yResult.w3
                + ", t2: " + resultSPL.yResult.t;

            ZResultLabel.Text = "For(Z): w13: " + resultSPL.zResult.w1
                + ", w23: " + resultSPL.zResult.w2 + ", w33: " + resultSPL.zResult.w3
                + ", t3: " + resultSPL.zResult.t;
        }

        private void CorrectionGraphButton_Click(object sender, EventArgs e)
        {
            showProperCorrectionGraph();
        }

        private void showProperCorrectionGraph()
        {
            int startPoint = Int32.Parse(StartPointTB.Text);
            int amount = Int32.Parse(AmountOfPointsToShowTB.Text);

            if (XRadioButton.Checked)
            {
                CorrectionGraph.realOutput = getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.xResult);
                CorrectionGraph.desiredOutput = getDesiredOutputForCorrectionGraph(ref points, 0, startPoint, amount);

                Debug.WriteLine("Desired ouput: \n");
                foreach (float element in CorrectionGraph.desiredOutput)
                {
                    Debug.WriteLine(element);
                }

                Debug.WriteLine("Real ouput: \n");
                foreach (float element in CorrectionGraph.realOutput)
                {
                    Debug.WriteLine(element);
                }
            }
            else if (YRadioButton.Checked)
            {
                CorrectionGraph.realOutput = getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.yResult);
                CorrectionGraph.desiredOutput = getDesiredOutputForCorrectionGraph(ref points, 1, startPoint, amount);
            }
            else if (ZRadioButton.Checked)
            {
                CorrectionGraph.realOutput = getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.zResult);
                CorrectionGraph.desiredOutput = getDesiredOutputForCorrectionGraph(ref points, 2, startPoint, amount);
            }

            new CorrectionGraph().Show();
        }
       
        private float[] getDesiredOutputForCorrectionGraph(ref float[,] source, int columnNr, int start, int amount)
        {
            float[] destination = new float[amount];

            //Debug.WriteLine("Rozpoczynam procedurę kopiowania");

            for (int i = start, index = 0; i < start + amount; i++, index++)
            {
                //Debug.WriteLine(source[i, columnNr]);
                destination[index] = source[i, columnNr];
            }

            return destination;
        }

        private float[] getRealOtputForCorrectionGraph(int start,
            int amount, ResultForOneNeuron dataToCount)
        {
            float[] destination = new float[amount];

            //Debug.WriteLine("Rozpoczynam procedurę kopiowania");

            for (int i = start - 1, index = 0; i < (start + amount - 1); i++, index++)
            {
                ///Debug.WriteLine(i);

                destination[index] = points[i, 0] * dataToCount.w1 +
                    points[i, 1] * dataToCount.w2 +
                    points[i, 2] * dataToCount.w3 -
                    dataToCount.t;
            }

            return destination;
        }

        private void StartPointTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void AmountOfPointsToShowTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
