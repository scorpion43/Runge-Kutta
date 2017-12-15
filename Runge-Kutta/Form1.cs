using ILNumerics;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runge_Kutta
{
   
    public partial class Form1 : Form
    {

        public float[,] points = new float[1500, 3];

        private RungeKuttaService rungeKuttaService = new RungeKuttaService();
        private PerceptronService pService = new PerceptronService();
        private ValidationService validationService = new ValidationService();
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

        //runge kutta generation
        private void button1_Click(object sender, EventArgs e)
        {
            ValidationResult vResult = validationService.checkAllFieldValuesToGeneratePoints(
                 XTextBox.Text, YTextBox.Text, ZTextBox.Text, HTextBox.Text);

            if (!vResult.Success)
            {
                MessageBox.Show(vResult.ValidationError);
                return;
            }


            h = float.Parse(HTextBox.Text);
            x0 = float.Parse(XTextBox.Text);
            y0 = float.Parse(YTextBox.Text);
            z0 = float.Parse(ZTextBox.Text);

            points = rungeKuttaService.GeneratePointsByRungeKutta4k(x0, y0, z0, h);
            MessageBox.Show("Generating points complete.");
        }


        private void TrainButton_Click(object sender, EventArgs e)
        {

            ValidationResult vResult = new ValidationResult();
            vResult = validationService.checkFieldsToTrain(AmountOfPointsTB.Text, ErrorMaxTB.Text);

            if (!vResult.Success)
            {
                MessageBox.Show(vResult.ValidationError);
                return;
            }

            float errorMax = float.Parse(ErrorMaxTB.Text);
            int amountOfPoints = Int32.Parse(AmountOfPointsTB.Text);

            if (amountOfPoints < 1 || amountOfPoints >= 1500)
            {
                MessageBox.Show("Amount of points value is uncorrect");
                return;
            }

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

        private void RepresentationGraphButton_Click(object sender, EventArgs e)
        {
            ValidationResult vResult = new ValidationResult();
            vResult = validationService.checkFieldsToRepresent(AmountOfPointsToShowTB.Text, StartPointTB.Text);

            if (!vResult.Success)
            {
                MessageBox.Show(vResult.ValidationError);
                return;
            }

            showProperGraph();
        }

        private void showProperGraph()
        {
            if (RungeKuttaRB.Checked)
            {
                showRungeKuttaGraph();
            }
            else if (PerceptronRB.Checked)
            {
                showPerceptronGraph();
            }
            else if (BothRB.Checked)
            {
                showProperCorrectionGraph();
            }
        }

        private void showRungeKuttaGraph()
        {
            int startPoint = Int32.Parse(StartPointTB.Text);
            int amount = Int32.Parse(AmountOfPointsToShowTB.Text);
            String title = "";

            if (startPoint < 0) {
                MessageBox.Show("Start point for Runge Kutta Representation should start from 0 or greater value");
                return;
            }

            if (startPoint + amount > 1500)
            {
                MessageBox.Show("Out of renge. Change the start point or amount.");
                return;
            }

            if (XRadioButton.Checked)
            {
                title = "Runge Kutta for X";
                Plotting_Form2.POINTS_2D = getDesiredOutputForCorrectionGraph(ref points, 0, startPoint, amount);
            }
            else if (YRadioButton.Checked)
            {
                title = "Runge Kutta for Y";
                Plotting_Form2.POINTS_2D = getDesiredOutputForCorrectionGraph(ref points, 1, startPoint, amount);
            }
            else if (ZRadioButton.Checked)
            {
                title = "Runge Kutta for Z";
                Plotting_Form2.POINTS_2D = getDesiredOutputForCorrectionGraph(ref points, 2, startPoint, amount);
            }
            else if (TB3D.Checked)
            {
                title = "Runge Kutta in 3D";
                Debug.WriteLine("Length of points: " + points.Length);
                Plotting_Form2.POINTS_2D = prepareRungeKuttaFor3D(startPoint, amount);
            }

            Plotting_Form2 plotingForm = new Plotting_Form2();
            plotingForm.Text = title;
            plotingForm.Show();
        }

        private void showPerceptronGraph()
        {

            int startPoint = Int32.Parse(StartPointTB.Text);
            int amount = Int32.Parse(AmountOfPointsToShowTB.Text);
            String title = "";

            if (startPoint < 1)
            {
                MessageBox.Show("Start point for Perceptron Representation should start from 1 or greater value");
                return;
            }

            if (startPoint + amount > 1500)
            {
                MessageBox.Show("Out of renge. Change the start point or amount.");
                return;
            }

            if (XRadioButton.Checked)
            {
                title = "Perceptron Graph for X";
                Plotting_Form2.POINTS_2D = getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.xResult);
            }
            else if (YRadioButton.Checked)
            {
                title = "Perceptron Graph for Y";
                Plotting_Form2.POINTS_2D = getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.yResult);
            }
            else if (ZRadioButton.Checked)
            {
                title = "Perceptron Graph for Z";
                Plotting_Form2.POINTS_2D = getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.zResult);
            }
            else if (TB3D.Checked)
            {
                title = "Perceptron in 3D";
                Plotting_Form2.POINTS_2D = prepare3DForPerceptron(startPoint, amount);
            }

            Plotting_Form2 plotingForm = new Plotting_Form2();
            plotingForm.Text = title;
            plotingForm.Show();

        }

        private void showProperCorrectionGraph()
        {
            int startPoint = Int32.Parse(StartPointTB.Text);
            int amount = Int32.Parse(AmountOfPointsToShowTB.Text);
            String title = "";

            if (startPoint < 1)
            {
                MessageBox.Show("Start point for Correction Representation should start from 1 or greater value");
                return;
            }

            if (startPoint + amount > 1500)
            {
                MessageBox.Show("Out of renge. Change the start point or amount.");
                return;
            }

            if (XRadioButton.Checked) {
                title = "Correction Graph for X";
                CorrectionGraph.realOutput = getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.xResult);
                CorrectionGraph.desiredOutput = getDesiredOutputForCorrectionGraph(ref points, 0, startPoint, amount);
            }
            else if (YRadioButton.Checked)
            {
                title = "Correction Graph for Y";
                CorrectionGraph.realOutput = getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.yResult);
                CorrectionGraph.desiredOutput = getDesiredOutputForCorrectionGraph(ref points, 1, startPoint, amount);
            }
            else if (ZRadioButton.Checked)
            {
                title = "Correction Graph for Z";
                CorrectionGraph.realOutput = getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.zResult);
                CorrectionGraph.desiredOutput = getDesiredOutputForCorrectionGraph(ref points, 2, startPoint, amount);
            }
            else if (TB3D.Checked)
            {
                title = "Correction Graph for 3D";
                CorrectionGraph.desiredOutput = prepareRungeKuttaFor3D(startPoint, amount);

                float[,] realOutput = prepare3DForPerceptron(startPoint, amount);
                CorrectionGraph.realOutput = realOutput;
            }

            CorrectionGraph cGraph = new CorrectionGraph();
            cGraph.Text = title;
            cGraph.Show();
        }
         
        private float[,] prepare3DForPerceptron( int startPoint, int amount )
        {
            float[,] realOutput = new float[amount, 3];

            float[] xRealOutput = getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.xResult);
            float[] yRealOutput = getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.yResult);
            float[] zRealOutput = getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.zResult);

            copyColumn1DArrayTo2DArray(ref xRealOutput, ref realOutput,  0);
            copyColumn1DArrayTo2DArray(ref yRealOutput, ref realOutput,  1);
            copyColumn1DArrayTo2DArray(ref zRealOutput, ref realOutput,  2);

            return realOutput;
        }

        private float[,] prepareRungeKuttaFor3D(int startPoint, int amount)
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
       
        private float[] getDesiredOutputForCorrectionGraph(ref float[,] source, int columnNr, int start, int amount)
        {
            float[] destination = new float[amount];


            for (int i = start, index = 0; index < amount; i++, index++)
            {
                destination[index] = source[i, columnNr];
            }

            return destination;
        }

        private float[] getRealOtputForCorrectionGraph(int start,
            int amount, ResultForOneNeuron dataToCount)
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

        private void copyColumn1DArrayTo2DArray(ref float[] source, ref float[,] dest, int columnNr)
        {

            for (int i = 0; i < source.Length; i++)
            {
                dest[i, columnNr] = source[i];
            }

        }

        
    }
}
