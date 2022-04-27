using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessLab3
{
    public partial class Form1 : Form
    {
        //время нахождения в состояниях
        double S0Time = 0;
        double S1Time = 0;
        double S2Time = 0;
        double S3Time = 0;

        //процент загруженности
        double TotalLoad = 0;

        public Form1()
        {
            InitializeComponent();
        }


        void Model()
        {
            Random R = new Random();

            double L01 = Convert.ToDouble(l01.Text);
            double L02 = Convert.ToDouble(l02.Text);
            double L10 = Convert.ToDouble(l10.Text);
            double L13 = Convert.ToDouble(l13.Text);
            double L21 = Convert.ToDouble(l21.Text);
            double L30 = Convert.ToDouble(l30.Text);

            double TK = Convert.ToDouble(Tk.Text);

            double S = 0;
            double T = 0;

            double t01 = 0;
            double t02 = 0;
            double t10 = 0;
            double t13 = 0;
            double t30 = 0;
            double t21 = 0;

            double T0 = 0;
            double T1 = 0;
            double T2 = 0;
            double T3 = 0;
            


            if (L01 >= L21 || L13 >= L30 )
            {
                MessageBox.Show("Данные некорректны", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    

            do
            {
                t01 = (-1 / L01) * Math.Log(R.NextDouble());
                t02 = (-1 / L02) * Math.Log(R.NextDouble());
                t10 = (-1 / L10) * Math.Log(R.NextDouble());
                t13 = (-1 / L13) * Math.Log(R.NextDouble());
                t21 = (-1 / L21) * Math.Log(R.NextDouble());
                t30 = (-1 / L30) * Math.Log(R.NextDouble());

                if(S == 0)
                {
                    if(t01 <= t02)
                    {
                        S = 1;
                        T += t01;
                    }
                    else
                    {
                        S = 2;
                        T += t02;
                    }
                }
                else
                {
                    if(S == 1)
                    {
                        if(t10 <= t13)
                        {
                            S = 0;
                            T += t10;
                        }
                        else
                        {
                            S = 3;
                            T += t13;
                        }
                    }
                    else
                    {
                        if (S == 2)
                        {
                            S = 1;
                            T += t21;
                        }
                        else
                        {
                            S = 0;
                            T += t30;
                        }
                    }
                }

                chart1.Series[0].Points.AddXY(T, S);
                int count = chart1.Series[0].Points.Count;
                if (chart1.Series[0].Points.Count > 1)
                {
                    if(chart1.Series[0].Points[count - 2].YValues[0] == 0)
                    {
                        T0 += (chart1.Series[0].Points[count - 1].XValue - chart1.Series[0].Points[count - 2].XValue);
                    }
                    else if (chart1.Series[0].Points[count - 2].YValues[0] == 1)
                    {
                        T1 += (chart1.Series[0].Points[count - 1].XValue - chart1.Series[0].Points[count - 2].XValue);
                    }
                    else if (chart1.Series[0].Points[count - 2].YValues[0] == 2)
                    {
                        T2 += (chart1.Series[0].Points[count - 1].XValue - chart1.Series[0].Points[count - 2].XValue);
                    }
                    else if (chart1.Series[0].Points[count - 2].YValues[0] == 3)
                    {
                        T3 += (chart1.Series[0].Points[count - 1].XValue - chart1.Series[0].Points[count - 2].XValue);
                    }
                }


            } while (T <= TK);

            this.T0.Text = "S0: " + Math.Round(T0, 4).ToString();
            this.T1.Text = "S1: " + Math.Round(T1, 4).ToString();
            this.T2.Text = "S2: " + Math.Round(T2, 4).ToString();
            this.T3.Text = "S3: " + Math.Round(T3, 4).ToString();
        }


        private void Start_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            chart1.Series.Add("Диаграмма перехода");
            chart1.ChartAreas[0].AxisX.Title = "t";
            chart1.ChartAreas[0].AxisY.Title = "Состояние";
            chart1.ChartAreas[0].AxisY.Interval = 1;

            chart1.Series.Last().ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            chart1.Series.Last().BorderWidth = 1;

            Model();

        }
    }
}
