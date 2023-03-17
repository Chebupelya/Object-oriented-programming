using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4(List<Computer> list)
        {
            int counter = 0;
            InitializeComponent();
            foreach (var i in list)
            {
                textBox1.Text +=
                    "\t\t" + ++counter +
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
