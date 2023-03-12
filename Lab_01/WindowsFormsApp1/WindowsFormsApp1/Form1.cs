using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Text = "";
            label11.ForeColor = Color.Black;
            if (radioButton2.Checked)
            {
                double imt;
                double rost;
                if (numericUpDown1.Value < 30)
                {
                    rost = (int)(numericUpDown3.Value) / 100.0;
                    imt = (double)(numericUpDown2.Value) / (rost * rost) - (double)(numericUpDown1.Value) / 100.0;
                    if (imt < 20)
                    {
                        label9.ForeColor = Color.Green;
                        label9.Text = Math.Round(imt, 1) + "(Недостаток веса)";
                    }
                    else if (imt > 30)
                    {
                        label9.ForeColor = Color.Red;
                        label9.Text = Math.Round(imt, 1) + "(Ожирение)";
                    }
                    else
                    {
                        label9.ForeColor = Color.Yellow;
                        label9.Text = Math.Round(imt, 1) + "(Норма)";
                    }
                }
                else
                {
                    rost = (int)(numericUpDown3.Value) / 100.0;
                    imt = (double)(numericUpDown2.Value) / (rost * rost) + (double)(numericUpDown1.Value) / 100.0;
                    if (imt < 20)
                    {
                        label9.ForeColor = Color.Green;
                        label9.Text = Math.Round(imt, 1) + "(Недостаток веса)";
                    }
                    else if (imt > 30)
                    {
                        label9.ForeColor = Color.Red;
                        label9.Text = Math.Round(imt, 1) + "(Ожирение)";
                    }
                    else
                    {
                        label9.ForeColor = Color.Yellow;
                        label9.Text = Math.Round(imt, 1) + "(Норма)";
                    }
                }
            }
            if (radioButton1.Checked)
            {
                double imt;
                double rost;
                if (numericUpDown1.Value < 30)
                {
                    rost = (int)(numericUpDown3.Value) / 100.0;
                    imt = (double)(numericUpDown2.Value) / (rost * rost) - (double)(numericUpDown1.Value) / 100.0;
                    if (imt < 22)
                    {
                        label9.ForeColor = Color.Green;
                        label9.Text = Math.Round(imt, 1) + "(Недостаток веса)";
                    }
                    else if (imt > 27)
                    {
                        label9.ForeColor = Color.Red;
                        label9.Text = Math.Round(imt, 1) + "(Ожирение)";
                    }
                    else
                    {
                        label9.ForeColor = Color.Yellow;
                        label9.Text = Math.Round(imt, 1) + "(Норма)";
                    }
                }
                else
                {
                    rost = (int)(numericUpDown3.Value) / 100.0;
                    imt = (double)(numericUpDown2.Value) / (rost * rost) + (double)(numericUpDown1.Value) / 100.0;
                    if (imt < 22)
                    {
                        label9.ForeColor = Color.Green;
                        label9.Text = Math.Round(imt, 1) + "(Недостаток веса)";
                    }
                    else if (imt > 27)
                    {
                        label9.ForeColor = Color.Red;
                        label9.Text = Math.Round(imt, 1) + "(Ожирение)";
                    }
                    else
                    {
                        label9.ForeColor = Color.Yellow;
                        label9.Text = Math.Round(imt, 1) + "(Норма)";
                    }
                }

            }
            try
            {
                if (!radioButton1.Checked && !radioButton2.Checked)
                {
                    throw new Exception();
                }
            }
            catch
            {
                label11.ForeColor = Color.Red;
                label11.Text = "Выберите пол!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = "";
            label10.ForeColor = Color.Black;
            try
            {
                if (comboBox1.SelectedIndex == -1)
                {
                    throw new Exception();
                }
            }
            catch
            {
                label10.ForeColor = Color.Red;
                label10.Text = "Выберите цель!";
            }
            double kkal = (int)(numericUpDown2.Value) * (int)(numericUpDown3.Value) * 0.1;
            if (comboBox1.SelectedIndex == 0)
            {
                label10.Text = Math.Round(kkal, 0) + " ккал";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                kkal = kkal*((double)(numericUpDown4.Value)) / 50 - (((double)(numericUpDown5.Value)) * 10);
                label10.Text = Math.Round(kkal, 0) + " ккал";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                kkal = 50 / ((double)(numericUpDown4.Value)) * kkal + (double)(numericUpDown5.Value)*100;
                label10.Text = Math.Round(kkal, 0) + "ккал";
            }
        }
    }
}
