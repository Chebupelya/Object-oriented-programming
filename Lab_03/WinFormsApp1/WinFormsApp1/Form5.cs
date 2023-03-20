using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        List<Computer> computers;
        List<Computer> search = new List<Computer>();
        public Form5(List<Computer> list)
        {
            InitializeComponent();
            computers = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search.Clear();
            int count = 1;
            Regex regex = new Regex(@"\b\w*(amd|intel)\w*\b", RegexOptions.IgnoreCase);
            try
            {
                if (textBox1.Text.ToLower() == "amd" || textBox1.Text.ToLower() == "intel")
                {
                    textBox2.Text = "";
                    search = computers.Where(p => ((p.processor.producer).ToLower()).Contains(textBox1.Text.ToLower())).ToList();
                    if (search.Count > 0)
                    {
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
                    else
                    {
                        MessageBox.Show("Совпадений не найдено.");
                    }
                }
                else
                {
                    textBox2.Text = "";
                    MatchCollection matches = regex.Matches(textBox1.Text);
                    if (matches.Count > 0)
                    {
                        if (matches[0].Value.Contains("amd"))
                        {

                            var query = from p in computers
                                        where p.processor.producer.ToLower() == "amd"
                                        select p;

                            search = query.ToList();
                        }
                        if (matches[0].Value.Contains("intel"))
                        {
                            var query = from p in computers
                                        where p.processor.producer.ToLower() == "intel"
                                        select p;

                            search = query.ToList();
                        }
                        if (matches[0].Value.Contains("intel") && matches[0].Value.Contains("amd"))
                        {
                            var query = from p in computers
                                        where p.processor.producer.ToLower() == "intel" || p.processor.producer.ToLower() == "amd"
                                        select p;

                            search = query.ToList();
                        }
                        //search = computers.Where(p => ((p.processor.producer).ToLower()).Contains("amd")).ToList();
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
                }
            }
            catch
            {
                MessageBox.Show("Совпадений не найдено.");
            }
        }
    }
}
