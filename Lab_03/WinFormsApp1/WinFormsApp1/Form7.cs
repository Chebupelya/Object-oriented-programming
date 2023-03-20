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
    public partial class Form7 : Form
    {
        List<Computer> computers;
        List<Computer> search = new List<Computer>();
        public Form7(List<Computer> list)
        {
            InitializeComponent();
            computers = list;
            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search.Clear();
            int count = 1;
            Regex regex = new Regex(@"\b\w*(amd|intel)\w*\b", RegexOptions.IgnoreCase);
            Regex regex2 = new Regex(@"^[a-zA-Z]?\d{0,5}$");
            try
            {
                textBox2.Text = "";

                foreach (Computer computer in computers)
                {
                    if (textBox1.Text.ToLower() == computer.processor.producer.ToLower())
                    {
                        search.Add(computer);
                        continue;
                    }
                    else
                    {
                        MatchCollection matches = regex.Matches(textBox1.Text);
                        if (matches.Count > 0)
                        {
                            if (textBox1.Text.ToLower().Contains(computer.processor.producer))
                            {
                                search.Add(computer);
                                continue;
                            }
                        }
                    }
                    
                    if (computer.processor.model == textBox3.Text)
                    {
                        search.Add(computer);
                    }
                    else
                    {
                        MatchCollection matchess = regex2.Matches(textBox3.Text);
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
