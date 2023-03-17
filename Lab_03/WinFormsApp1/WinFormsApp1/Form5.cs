using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        List<Computer> computers, search;
        public Form5(List<Computer> list)
        {
            InitializeComponent();
            computers = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            search = computers.Where(p => ((p.processor.producer).ToLower()).Contains(textBox1.Text.ToLower())).ToList();
            foreach(var i in search)
            {
                textBox2.Text +=
                    "\r\n============================" +
                    "\r\nТип компьютера: " + i.computer_type +
                    "\r\nРазмер озу: " + i.ram_memory +
                    "\r\nТип озу: " + i.ram_type +
                    "\r\nРазмер жд: " + i.hd_memory +
                    "\r\nТип жд: " + i.hd_type +
                    "\r\n[Процессор]" +
                    "\r\nПроизводитель: " + i.processor.producer +
                    "\r\nСерия: " + i.processor.series +
                    "\r\nМодель: " + i.processor.model +
                    "\r\nЧастота: " + i.processor.frequency +
                    "\r\nМакс. частота: " + i.processor.max_frequency +
                    "\r\nКол-во ядер: " + i.processor.cores_amount +
                    "\r\nРазрядность процессора: " + i.processor.cpu_architecture +
                    "\r\n[Видеокарта]" +
                    "\r\nПроизводитель: " + i.videocard.producer +
                    "\r\nСерия: " + i.videocard.series +
                    "\r\nМодель: " + i.videocard.model +
                    "\r\nЧастота: " + i.videocard.frequency +
                    "\r\nПоддержка directx11: " + i.videocard.support_directx11 +
                    "\r\nПамять: " + i.videocard.vc_memory + " GB" +
                    "\r\nДата приобретения: " + i.purchase_date +
                    "\r\nСтоимость: " + i.cost_comp + "$\r\n" +
                    "============================\r\n";
            }
        }
    }
}
