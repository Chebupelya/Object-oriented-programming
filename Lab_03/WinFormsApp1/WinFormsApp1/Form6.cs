using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form6 : Form
    {
        List<Computer> computers;
        List<Computer> search = new List<Computer>();
        public Form6(List<Computer> list)
        {
            InitializeComponent();
            computers = list;
        }
        int count = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            search.Clear();
            textBox2.Text = "";
            count = 1;

            try
            {
                Regex regex = new Regex(@"^[a-zA-Z]?\d{0,5}$");
                foreach (Computer computer in computers)
                {
                    if (computer.processor.model == textBox1.Text)
                    {
                        search.Add(computer);
                    }
                    else
                    {
                        MatchCollection matchess = regex.Matches(textBox1.Text);
                        if (matchess.Count > 0)
                        {
                            if (computer.processor.model.ToLower().Contains(matchess[0].Value.ToLower()))
                            {
                                search.Add(computer);
                            }
                        }
                    }
                }
                foreach (var i in search)
                {
                    textBox2.Text +=
                        "\t\t" + count +
                        "\r\n============================" +
                        "\r\nТип компьютера: " + i.computer_type +
                        "\r\nРазмер ОЗУ: " + i.ram_memory +
                        "\r\nТип ОЗУ: " + i.ram_type +
                        "\r\nРазмер ЖД: " + i.hd_memory +
                        "\r\nТип ЖД: " + i.hd_type +
                        "\r\n[ПРОЦЕССОР]" +
                        "\r\nПроизводитель: " + i.processor.producer +
                        "\r\nСерия: " + i.processor.series +
                        "\r\nМодель: " + i.processor.model +
                        "\r\nЧастота: " + i.processor.frequency +
                        "\r\nМакс. частота: " + i.processor.max_frequency +
                        "\r\nКол-во ядер: " + i.processor.cores_amount +
                        "\r\nРазрядность процессора: " + i.processor.cpu_architecture +
                        "\r\n[ВИДЕОКАРТА]" +
                        "\r\nПроизводитель: " + i.videocard.producer +
                        "\r\nСерия: " + i.videocard.series +
                        "\r\nМодель: " + i.videocard.model +
                        "\r\nЧастота: " + i.videocard.frequency +
                        "\r\nПоддержка DirectX11: " + i.videocard.support_directx11 +
                        "\r\nПамять: " + i.videocard.vc_memory + " GB" +
                        "\r\nДата приобретения: " + i.purchase_date +
                        "\r\nСтоимость: " + i.cost_comp + "$\r\n" +
                        "============================\r\n";
                    count++;
                }
            }
            catch
            {
                MessageBox.Show("Соответствий не найдено.");
            }
        }
    }
}
