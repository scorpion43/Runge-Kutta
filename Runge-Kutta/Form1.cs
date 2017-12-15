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
        private ValidationRangesService vRService = new ValidationRangesService();
        private ResultOfTrainingSPL resultSPL;
        private PointsManipulationService pointsManipulationService = new PointsManipulationService();

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

            vResult = vRService.checkRangesForFieldsToTest(amountOfPoints);

            if (!vResult.Success)
            {
                MessageBox.Show(vResult.ValidationError);
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

            int startPoint = Int32.Parse(StartPointTB.Text);
            int amount = Int32.Parse(AmountOfPointsToShowTB.Text);

            vResult = validateBeforeDisplayRepresentation(startPoint, amount);

            if (vResult.Success)
            {
                showProperGraph();
            }
            else
            {
                MessageBox.Show(vResult.ValidationError);
            }
            
        }

        private ValidationResult validateBeforeDisplayRepresentation(int startPoint, int amount)
        {
            ValidationResult vResult = new ValidationResult();

            if (RungeKuttaRB.Checked)
            {
                vResult = vRService.checkRangesForRungeKuttaRepresentation(startPoint, amount);
            }
            else if (PerceptronRB.Checked)
            {
                vResult = vRService.checkRangesForPerceptronRepresentation(startPoint, amount);
            }
            else if (BothRB.Checked)
            {
                vResult = vRService.checkRangesForPerceptronRepresentation(startPoint, amount);
            }

            return vResult;
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

            if (XRadioButton.Checked)
            {
                title = "Runge Kutta for X";
                Plotting_Form2.POINTS_2D = 
                    pointsManipulationService.getDesiredOutputForCorrectionGraph(ref points, 0, startPoint, amount);
            }
            else if (YRadioButton.Checked)
            {
                title = "Runge Kutta for Y";
                Plotting_Form2.POINTS_2D = 
                    pointsManipulationService.getDesiredOutputForCorrectionGraph(ref points, 1, startPoint, amount);
            }
            else if (ZRadioButton.Checked)
            {
                title = "Runge Kutta for Z";
                Plotting_Form2.POINTS_2D = 
                   pointsManipulationService.getDesiredOutputForCorrectionGraph(ref points, 2, startPoint, amount);
            }
            else if (TB3D.Checked)
            {
                title = "Runge Kutta in 3D";
                Debug.WriteLine("Length of points: " + points.Length);
                Plotting_Form2.POINTS_2D = 
                    pointsManipulationService.prepareRungeKuttaFor3D(startPoint, amount, ref points);
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

            if (XRadioButton.Checked)
            {
                title = "Perceptron Graph for X";
                Plotting_Form2.POINTS_2D = 
                    pointsManipulationService.getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.xResult, ref points);
            }
            else if (YRadioButton.Checked)
            {
                title = "Perceptron Graph for Y";
                Plotting_Form2.POINTS_2D = 
                    pointsManipulationService.getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.yResult, ref points);
            }
            else if (ZRadioButton.Checked)
            {
                title = "Perceptron Graph for Z";
                Plotting_Form2.POINTS_2D = 
                    pointsManipulationService.getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.zResult, ref points);
            }
            else if (TB3D.Checked)
            {
                title = "Perceptron in 3D";
                Plotting_Form2.POINTS_2D = 
                    pointsManipulationService.prepare3DForPerceptron(startPoint, amount, resultSPL, ref points);
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

            if (XRadioButton.Checked) {
                title = "Correction Graph for X";
                CorrectionGraph.realOutput = 
                    pointsManipulationService.getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.xResult, ref points);
                CorrectionGraph.desiredOutput = 
                    pointsManipulationService.getDesiredOutputForCorrectionGraph(ref points, 0, startPoint, amount);
            }
            else if (YRadioButton.Checked)
            {
                title = "Correction Graph for Y";
                CorrectionGraph.realOutput =
                    pointsManipulationService.getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.yResult, ref points);
                CorrectionGraph.desiredOutput = 
                    pointsManipulationService.getDesiredOutputForCorrectionGraph(ref points, 1, startPoint, amount);
            }
            else if (ZRadioButton.Checked)
            {
                title = "Correction Graph for Z";
                CorrectionGraph.realOutput =
                    pointsManipulationService.getRealOtputForCorrectionGraph(startPoint, amount, resultSPL.zResult, ref points);
                CorrectionGraph.desiredOutput =
                    pointsManipulationService.getDesiredOutputForCorrectionGraph(ref points, 2, startPoint, amount);
            }
            else if (TB3D.Checked)
            {
                title = "Correction Graph for 3D";
                CorrectionGraph.desiredOutput =
                    pointsManipulationService.prepareRungeKuttaFor3D(startPoint, amount, ref points);

                float[,] realOutput =
                    pointsManipulationService.prepare3DForPerceptron(startPoint, amount, resultSPL, ref points);
                CorrectionGraph.realOutput = realOutput;
            }

            CorrectionGraph cGraph = new CorrectionGraph();
            cGraph.Text = title;
            cGraph.Show();
        }
       
    }
}
