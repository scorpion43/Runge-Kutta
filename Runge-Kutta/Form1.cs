using ILNumerics;
using Runge_Kutta.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
            MessageBox.Show("Wygenerowano punkty.");

            Debug.WriteLine("Długość Tablicy POINTS = " + points.Length);

            /*for (int i = 0; i < 1500; i++)
            {
                Debug.WriteLine("i = " + i + ", x = " + points[i, 0] + ", y = " + points[i, 1] + ", z = " + points[i, 2]);
            }*/

            AddValuesToListBoxes();
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

        private void AddValuesToListBoxes()
        {
            Debug.WriteLine("Sprawdzenie wyświetalania");

            ListBoxForX.Items.Clear();
            ListBoxForY.Items.Clear();
            ListBoxForZ.Items.Clear();

            for (int i = 0; i < 1500; i++)
            {
                if (points[0, 0] == float.NaN && points[0, 1] == float.NaN && points[0, 2] == float.NaN)
                {
                    break;
                }

                Debug.WriteLine("x = " + points[i, 0] + ", y = " + points[i, 1] + ", z = " + points[i, 2]);

                ListBoxForX.Items.Add(i + ". " + points[i, 0].ToString("0.0000"));
                ListBoxForY.Items.Add(i + ". " + points[i, 1].ToString("0.0000"));
                ListBoxForZ.Items.Add(i + ". " + points[i, 2].ToString("0.0000"));
            }
        }

        private void ListBoxForX_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ListBoxForX.SelectedIndex;

            ListBoxForY.SelectedIndex = index;
            ListBoxForZ.SelectedIndex = index;
        }

        private void ListBoxForY_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ListBoxForY.SelectedIndex;

            ListBoxForX.SelectedIndex = index;
            ListBoxForZ.SelectedIndex = index;
        }

        private void ListBoxForZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ListBoxForZ.SelectedIndex;

            ListBoxForX.SelectedIndex = index;
            ListBoxForY.SelectedIndex = index;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ZTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
