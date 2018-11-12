using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace LissajousFigure
{
    public partial class Form1 : Form
    {
        private Double A, B, a, b, f;
        private const Double t = 0.05;
        private PointF[] FigurePoints;
        private Double[] Steps;
        private Int32 maxindex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //draws figure and writes last settings in text file
        private void DrawFigure(object sender, EventArgs e)
        {
            if (timer1.Enabled) timer1.Enabled = false;
            else
            {
                bool q1, q2, q3, q4, q5;
                q1 = Double.TryParse(textBoxA.Text, out A);
                q2 = Double.TryParse(textBoxB.Text, out B);
                q3 = Double.TryParse(textBox_a.Text, out a);
                q4 = Double.TryParse(textBox_b.Text, out b);
                q5 = Double.TryParse(textBox_f.Text, out f);

                if ((q1 | q2 | q3 | q4 | q5) != false)
                {
                    CreatePoint(A, B, a, b, f, t);

                    string settings = A + "," + B + "," + a + "," + b + "," + f;
                    string usr = Environment.UserName;

                    try
                    {
                        File.WriteAllText(@"C:\Users\" + usr + @"\Documents\Lissajous.txt", settings);
                    }
                    catch (Exception exc)
                    {
                        string messadge = "An error occured while writing the information";
                        string caption = "";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(messadge, caption, buttons);
                    }

                    maxindex = 0;
                    timer1.Enabled = true;
                }
                else
                {
                    string msdg = "An error occured. Are your parameters right?";
                    string cptn = "";
                    MessageBoxButtons bttn = MessageBoxButtons.OK;
                    MessageBox.Show(msdg, cptn, bttn);
                }
            }
        }

        //for loading settings from file
        private void LoadFromFile(object sender, EventArgs e)
        {
            string message = "File with settings must contain 5 digit values separated by commas.";
            string caption = "Loading of the settings";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.OK)
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Filter = "Text files|*.txt";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string temp = File.ReadAllText(dialog.FileName);
                        try
                        {
                            string[] temp1 = temp.Split(',');
                            textBoxA.Text = temp1[0];
                            textBoxB.Text = temp1[1];
                            textBox_a.Text = temp1[2];
                            textBox_b.Text = temp1[3];
                            textBox_f.Text = temp1[4];
                        }
                        catch(Exception exc)
                        {
                            string msdg = "An error occured. Is your file with settings right?";
                            string cptn = "";
                            MessageBoxButtons bttn = MessageBoxButtons.OK;
                            MessageBox.Show(msdg, cptn, bttn);
                        }
                    }
                }
            }
        }

        //calculates X and Y value by the formula
        private float CalcX(double A, double a, double f, double t)
        {
            return (float)(A * Math.Sin(a * t + f));
        }

        private float CalcY(double B, double b, double t)
        {
            return (float)(B * Math.Sin(b * t));
        }

        //filling arrays with points' and steps' values
        private void CreatePoint(double A, double B, double a, double b, double f, double t)
        {
            double stop_t = b * 2 * Math.PI;

            List<PointF> point_list = new List<PointF>();
            List<double> steps_list = new List<double>();

            point_list.Add(new PointF(CalcX(A, a, f, 0), CalcY(B, b, 0)));
            steps_list.Add(0);
            for (double t1 = t; t1 <= stop_t; t1 += t)
            {
                point_list.Add(new PointF(CalcX(A, a, f, t1), CalcY(B, b, t1)));
                steps_list.Add(t1);
            }
            point_list.Add(new PointF(CalcX(A, a, f, 0), CalcY(B, b, 0)));
            steps_list.Add(0);

            FigurePoints = point_list.ToArray();
            Steps = steps_list.ToArray();
        }

        //drawing the figure
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(pictureBox1.BackColor);
            if (FigurePoints == null) return;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            double scale = Math.Min(
                pictureBox1.ClientSize.Width * 0.45f,
                pictureBox1.ClientSize.Height * 0.45f);

            e.Graphics.ScaleTransform(
                (float)(scale / (A + f)),
                (float)(scale / (B + f)));

            e.Graphics.TranslateTransform(
                pictureBox1.ClientSize.Width / 2,
                pictureBox1.ClientSize.Height / 2,
                MatrixOrder.Append);

            using (Pen pen = new Pen(Color.Fuchsia, 0))
            {
                for (int i = 0; i < maxindex; i++)
                    e.Graphics.DrawLine(pen, FigurePoints[i], FigurePoints[i + 1]);
            }
        }

        //timer for drawing
        private void timer1_Tick(object sender, EventArgs e)
        {
            maxindex++;
            if (maxindex >= FigurePoints.Length - 1)
                timer1.Enabled = false;
            pictureBox1.Refresh();
        }
    }
}
