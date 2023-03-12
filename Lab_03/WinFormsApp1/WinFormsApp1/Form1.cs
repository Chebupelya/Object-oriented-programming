using System.Runtime.Serialization;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Computer comp;
        public Processor proc;
        public Videocard vc;
        Form2 form2;
        Form3 form3;
        public int cost = 0;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            comp = new Computer();
            RAM_Memory.Enabled = false;
            RAM_Memory.DropDownStyle = ComboBoxStyle.DropDownList;
            HD_Memory.Enabled = false;
            HD_Memory.DropDownStyle = ComboBoxStyle.DropDownList;
            //Lab_Compand.Enabled = false;
        }

        private void MB_RAM_CheckedChanged(object sender, EventArgs e)
        {
            RAM_Memory.Enabled = true;
            RAM_Memory.Text = "";
            RAM_Memory.Items.Clear();
            RAM_Memory.Items.AddRange(new object[] {
            "256",
            "512"
            });
        }

        private void GB_RAM_CheckedChanged(object sender, EventArgs e)
        {
            RAM_Memory.Enabled = true;
            RAM_Memory.Text = "";
            RAM_Memory.Items.Clear();
            RAM_Memory.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16"
            });
        }

        private void HD_MB_CheckedChanged(object sender, EventArgs e)
        {
            HD_Memory.Enabled = true;
            HD_Memory.Text = "";
            HD_Memory.Items.Clear();
            HD_Memory.Items.AddRange(new object[] {
            "512"
            });
        }

        private void HD_GB_CheckedChanged(object sender, EventArgs e)
        {
            HD_Memory.Enabled = true;
            HD_Memory.Text = "";
            HD_Memory.Items.Clear();
            HD_Memory.Items.AddRange(new object[] {
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024"
            });
        }

        private void videocard_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
        }

        private void processor_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            form3.Show();
        }

        public List<Computer> GetSetBufferComputers = new List<Computer>();
        private void addToLab_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(form3.PrintCPUInfo() + form2.PrintVCInfo());
            try
            {
                comp.videocard = form2.GetVideocard();
            }
            catch
            {
                MessageBox.Show("Заполните данные о видеокарте!");
                return;
            }
            try
            {
                comp.processor = form3.GetProcessor();
            }
            catch
            {
                MessageBox.Show("Заполните данные о процессоре!");
                return;
            }
            try
            {
                if (computer_type.Text == "" || RAM_Memory.Text == "" || HD_Memory.Text == "" || listBox1.Text == "" || listBox2.Text == "")
                {
                    throw new Exception();
                }
                else
                {
                    comp.computer_type = computer_type.Text;
                    if (MB_RAM.Checked)
                    {
                        comp.ram_memory = RAM_Memory.Text + " MB";
                    }
                    else if (GB_RAM.Checked)
                    {
                        comp.ram_memory = RAM_Memory.Text + " GB";
                    }
                    else
                    {
                        throw new Exception();
                    }
                    if (HD_MB.Checked)
                    {
                        comp.hd_memory = HD_Memory.Text + " MB";
                    }
                    else if (HD_GB.Checked)
                    {
                        comp.hd_memory = HD_Memory.Text + " GB";
                    }
                    else
                    {
                        throw new Exception();
                    }
                    comp.ram_type = listBox1.Text;
                    comp.hd_type = listBox2.Text;
                    comp.purchase_date = dateTimePicker1.Value;
                    comp.cost_comp = rand.Next(800, 2000);
                }
            }
            catch
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            try
            {
                GetSetBufferComputers.Add(comp);
            }
            catch
            {
                MessageBox.Show("Не удается добавить компьютер!");
                return;
            }

            List<Computer> GetSetBufferComputers2;
            DataContractSerializer xmlFormatter = new DataContractSerializer(typeof(List<Computer>));
            using (FileStream fs = new FileStream("IT-Laboratory.xml", FileMode.OpenOrCreate))
            {
                //if (fs.Length > 0)
                //{
                //    GetSetBufferComputers2 = (List<Computer>)xmlFormatter.ReadObject(fs);
                //    xmlFormatter.WriteObject(fs, GetSetBufferComputers2);
                //    //fs.SetLength(0);
                //}
                xmlFormatter.WriteObject(fs, GetSetBufferComputers);
            }
            comp.computer_type = null;
            comp.ram_memory = null;
            comp.hd_memory = null;
            comp.ram_type = null;
            comp.hd_type = null;

            computer_type.SelectedIndex = -1;
            RAM_Memory.Text = "";
            MB_RAM.Checked = false;
            GB_RAM.Checked = false;
            HD_Memory.Text = "";
            HD_MB.Checked = false;
            HD_GB.Checked = false;
            listBox1.SelectedIndex = -1;
            listBox2.SelectedIndex = -1;
            videocard = null;
            processor = null;
        }

        private void Lab_Compand_Click(object sender, EventArgs e)
        {
            DataContractSerializer xmlFormatter = new DataContractSerializer(typeof(List<Computer>));
            using (FileStream fs = new FileStream("IT-Laboratory.xml", FileMode.Open))
            {
                GetSetBufferComputers = (List<Computer>)xmlFormatter.ReadObject(fs);
                foreach (var i in GetSetBufferComputers)
                {
                    MessageBox.Show(
                        "Тип компьютера: " + i.computer_type +
                        "\nРазмер ОЗУ: " + i.ram_memory +
                        "\nТип ОЗУ: " + i.ram_type +
                        "\nРазмер ЖД: " + i.hd_memory +
                        "\nТип ЖД: " + i.hd_type +
                        "\n[Процессор]" +
                        "\nПроизводитель: " + i.processor.producer +
                        "\nСерия: " + i.processor.series +
                        "\nМодель: " + i.processor.model +
                        "\nЧастота:" + i.processor.frequency +
                        "\nМакс. частота: " + i.processor.max_frequency +
                        "\nКол-во ядер: " + i.processor.cores_amount +
                        "\nРазрядность процессора: " + i.processor.cpu_architecture +
                        "\n[ВИДЕОКАРТА]" +
                        "\nПроизводитель: " + i.videocard.producer +
                        "\nСерия: " + i.videocard.series +
                        "\nМодель: " + i.videocard.model +
                        "\nЧастота:" + i.videocard.frequency +
                        "\nПоддержка DirectX11: " + i.videocard.support_directx11 +
                        "\nПамять: " + i.videocard.vc_memory + " GB" +
                        "\nДата приобретения: " + i.purchase_date +
                        "\nСтоимость: " + i.cost_comp + "$"
                        );
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var i in GetSetBufferComputers)
            {
                cost += i.cost_comp;
            }
            MessageBox.Show("Стоимость: " + cost + "$");
        }
    }
}