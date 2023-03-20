using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Processor proc;
        public Form3()
        {
            InitializeComponent();
        }

        private void CPU_Submit_Click(object sender, EventArgs e)
        {
            if (CPU_Producer.Text == "" || CPU_Series.Text == "" || CPU_Model.Text == "" || CPU_Frequency.Text == "" || CPU_Max_Frequency.Text == "" || maskedTextBox1.Text == "" || CPU_Architecture.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                try
                {
                    proc = new Processor(
                        CPU_Producer.Text,
                        Convert.ToInt32(CPU_Series.Text),
                        CPU_Model.Text,
                        Convert.ToInt32(CPU_Frequency.Text),
                        Convert.ToInt32(CPU_Max_Frequency.Text),
                        Convert.ToInt32(maskedTextBox1.Text),
                        CPU_Architecture.Text
                    );
                    var results = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(proc, new ValidationContext(proc), results, true))
                    {
                        foreach (var error in results)
                        {
                            MessageBox.Show(error.ErrorMessage);
                        }

                        return;
                    }
                    Hide();
                }
                catch
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
        }
        public Processor GetProcessor()
        {
            return proc;
        }
        public string PrintCPUInfo()
        {
            return "[Процессор]" +
                "\nПроизводитель: " + CPU_Producer.Text +
                "\nСерия: " + CPU_Series.Text +
                "\nМодель: " + CPU_Model.Text +
                "\nЧастота: " + CPU_Frequency.Text +
                "\nМакс. частота: " + CPU_Frequency.Text +
                "\nКол-во ядер: " + maskedTextBox1.Text +
                "\nРазрядность процессора: " + CPU_Architecture.Text;
        }
    }
}
