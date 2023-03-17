using System.Diagnostics.Metrics;
using System.Runtime.Serialization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Computer comp;
        public Processor proc;
        public Videocard vc;
        Form2 form2;
        Form3 form3;
        Form4 form4;
        Form5 form5;
        public int cost = 0;
        Random rand = new Random();


        public Form1()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += new EventHandler(timer1_Tick);
            InitializeComponent();
            comp = new Computer();
            RAM_Memory.Enabled = false;
            RAM_Memory.DropDownStyle = ComboBoxStyle.DropDownList;
            HD_Memory.Enabled = false;
            HD_Memory.DropDownStyle = ComboBoxStyle.DropDownList;

            DataContractSerializer xmlFormatter = new DataContractSerializer(typeof(List<Computer>));
            using (FileStream fs = new FileStream("IT-Laboratory.xml", FileMode.Open))
            {
                GetSetBufferComputers = (List<Computer>)xmlFormatter.ReadObject(fs);
            }
            toolStripStatusLabel2.Text = Convert.ToString(GetSetBufferComputers.Count());
            toolStripStatusLabel4.Text = "Запуск формы";

            if (counter_of_comp == 0)
            {
                toolStripButton6.Enabled = false;
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
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

        public List<Computer> Vpered = new List<Computer>();
        public List<Computer> Nazad = new List<Computer>();
        private void addToLab_Click(object sender, EventArgs e)
        {
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
                toolStripStatusLabel2.Text = GetSetBufferComputers.Count().ToString();
            }
            catch
            {
                MessageBox.Show("Не удается добавить компьютер!");
                return;
            }

            //List<Computer> GetSetBufferComputers2;
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

            if (GetSetBufferComputers.Count() > 0)
            {
                toolStripButton5.Enabled = true;
            }
        }

        private void Lab_Compand_Click(object sender, EventArgs e)
        {
            DataContractSerializer xmlFormatter = new DataContractSerializer(typeof(List<Computer>));
            using (FileStream fs = new FileStream("IT-Laboratory.xml", FileMode.Open))
            {
                GetSetBufferComputers = (List<Computer>)xmlFormatter.ReadObject(fs);
            }
            toolStripStatusLabel2.Text = Convert.ToString(GetSetBufferComputers.Count());
            form4 = new Form4(GetSetBufferComputers);
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var i in GetSetBufferComputers)
            {
                cost += i.cost_comp;
            }
            MessageBox.Show("Стоимость: " + cost + "$");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ильин Никита Сергеевич\nv 2.0.1");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataContractSerializer xmlFormatter = new DataContractSerializer(typeof(List<Computer>));
            using (FileStream fs = new FileStream("Order.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter.WriteObject(fs, OrderedComputers);
            }
            MessageBox.Show("Сохранено.");
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
            панельИнструментовToolStripMenuItem.Visible = !toolStrip1.Visible;

            toolStripStatusLabel4.Text = "Сокрытие ПУ";
        }

        private void панельИнструментовToolStripMenuItem_Click(object sender, EventArgs e)
        {

            toolStrip1.Visible = !toolStrip1.Visible;
            панельИнструментовToolStripMenuItem.Visible = !toolStrip1.Visible;
            toolStripStatusLabel4.Text = "Показать ПУ";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            comp.computer_type = null;
            comp.ram_memory = null;
            comp.hd_memory = null;
            comp.ram_type = null;
            comp.hd_type = null;
            comp.videocard = null;
            comp.processor = null;

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

            toolStripStatusLabel4.Text = toolStripButton3.Text;
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = toolStripDropDownButton1.Text;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = toolStripButton4.Text;
            GetSetBufferComputers.RemoveAt(GetSetBufferComputers.Count() - 1);
            DataContractSerializer xmlFormatter = new DataContractSerializer(typeof(List<Computer>));
            using (FileStream fs = new FileStream("IT-Laboratory.xml", FileMode.Open))
            {
                fs.SetLength(0);
            }
            using (FileStream fs = new FileStream("IT-Laboratory.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter.WriteObject(fs, GetSetBufferComputers);
            }
            toolStripStatusLabel2.Text = GetSetBufferComputers.Count().ToString();
            if(GetSetBufferComputers.Count() == 1)
            {
                toolStripButton6.Enabled = false;
                toolStripButton5.Enabled = false;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = toolStripButton6.Text;
            if (counter_of_comp != 0)
            {
                counter_of_comp--;
            }
            MessageBox.Show(
                "\t\t" + (counter_of_comp + 1) +
                    "\r\n============================" +
                    "\r\nТип компьютера: " + GetSetBufferComputers.ElementAt(counter_of_comp).computer_type +
                    "\r\nРазмер озу: " + GetSetBufferComputers.ElementAt(counter_of_comp).ram_memory +
                    "\r\nТип озу: " + GetSetBufferComputers.ElementAt(counter_of_comp).ram_type +
                    "\r\nРазмер жд: " + GetSetBufferComputers.ElementAt(counter_of_comp).hd_memory +
                    "\r\nТип жд: " + GetSetBufferComputers.ElementAt(counter_of_comp).hd_type +
                    "\r\n[Процессор]" +
                    "\r\nПроизводитель: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.producer +
                    "\r\nСерия: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.series +
                    "\r\nМодель: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.model +
                    "\r\nЧастота: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.frequency +
                    "\r\nМакс. частота: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.max_frequency +
                    "\r\nКол-во ядер: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.cores_amount +
                    "\r\nРазрядность процессора: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.cpu_architecture +
                    "\r\n[Видеокарта]" +
                    "\r\nПроизводитель: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.producer +
                    "\r\nСерия: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.series +
                    "\r\nМодель: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.model +
                    "\r\nЧастота: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.frequency +
                    "\r\nПоддержка directx11: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.support_directx11 +
                    "\r\nПамять: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.vc_memory + " GB" +
                    "\r\nДата приобретения: " + GetSetBufferComputers.ElementAt(counter_of_comp).purchase_date +
                    "\r\nСтоимость: " + GetSetBufferComputers.ElementAt(counter_of_comp).cost_comp + "$\r\n" +
                    "============================\r\n"
                );
            if (counter_of_comp != GetSetBufferComputers.Count())
            {
                toolStripButton5.Enabled = true;
            }
            if (counter_of_comp == 0)
            {
                toolStripButton6.Enabled = false;
            }
        }
        int counter_of_comp = 0;
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = toolStripButton5.Text;
            if (counter_of_comp < GetSetBufferComputers.Count() - 1)
            {
                counter_of_comp++;
            }
            MessageBox.Show(
                "\t\t" + (counter_of_comp+1) +
                    "\r\n============================" +
                    "\r\nТип компьютера: " + GetSetBufferComputers.ElementAt(counter_of_comp).computer_type +
                    "\r\nРазмер озу: " + GetSetBufferComputers.ElementAt(counter_of_comp).ram_memory +
                    "\r\nТип озу: " + GetSetBufferComputers.ElementAt(counter_of_comp).ram_type +
                    "\r\nРазмер жд: " + GetSetBufferComputers.ElementAt(counter_of_comp).hd_memory +
                    "\r\nТип жд: " + GetSetBufferComputers.ElementAt(counter_of_comp).hd_type +
                    "\r\n[Процессор]" +
                    "\r\nПроизводитель: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.producer +
                    "\r\nСерия: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.series +
                    "\r\nМодель: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.model +
                    "\r\nЧастота: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.frequency +
                    "\r\nМакс. частота: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.max_frequency +
                    "\r\nКол-во ядер: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.cores_amount +
                    "\r\nРазрядность процессора: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.cpu_architecture +
                    "\r\n[Видеокарта]" +
                    "\r\nПроизводитель: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.producer +
                    "\r\nСерия: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.series +
                    "\r\nМодель: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.model +
                    "\r\nЧастота: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.frequency +
                    "\r\nПоддержка directx11: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.support_directx11 +
                    "\r\nПамять: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.vc_memory + " GB" +
                    "\r\nДата приобретения: " + GetSetBufferComputers.ElementAt(counter_of_comp).purchase_date +
                    "\r\nСтоимость: " + GetSetBufferComputers.ElementAt(counter_of_comp).cost_comp + "$\r\n" +
                    "============================\r\n"
                );
            if (counter_of_comp == GetSetBufferComputers.Count() - 1)
            {
                toolStripButton5.Enabled = false;
            }
            if (counter_of_comp > 0)
            {
                toolStripButton6.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel6.Text = DateTime.Now.ToString();
        }

        List<Computer> OrderedComputers;
        private void поToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = сортировкаToolStripMenuItem.Text + " " + поToolStripMenuItem.Text;
            OrderedComputers = GetSetBufferComputers.OrderBy(p => p.processor.frequency).ToList();
        }

        private void поРазмеруОЗУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = сортировкаToolStripMenuItem.Text + " " + поРазмеруОЗУToolStripMenuItem.Text;
            OrderedComputers = GetSetBufferComputers.OrderByDescending(p => p.ram_memory).ToList();
        }
        private void поЧастотеПроцессораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = сортировкаToolStripMenuItem.Text + " " + поToolStripMenuItem.Text;
            OrderedComputers = GetSetBufferComputers.OrderBy(p => p.processor.frequency).ToList();
        }
        private void поРазмеруОЗУToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = сортировкаToolStripMenuItem.Text + " " + поРазмеруОЗУToolStripMenuItem.Text;
            OrderedComputers = GetSetBufferComputers.OrderByDescending(p => p.ram_memory).ToList();
        }

        private void поПроизводителюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = поискToolStripMenuItem.Text + " " + поПроизводителюToolStripMenuItem.Text;
            form5 = new Form5(GetSetBufferComputers);
            form5.Show();
        }

        private void поМоделиПроцессораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = поискToolStripMenuItem.Text + " " + поМоделиПроцессораToolStripMenuItem.Text;
        }

        private void комбинированныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = поискToolStripMenuItem.Text + " " + комбинированныйToolStripMenuItem.Text;
        }

        private void поПроизводителюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = поискToolStripMenuItem.Text + " " + поПроизводителюToolStripMenuItem.Text;
        }

        private void поМоделиПроцессораToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = поискToolStripMenuItem.Text + " " + поМоделиПроцессораToolStripMenuItem.Text;
        }

        private void комбинированныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = поискToolStripMenuItem.Text + " " + комбинированныйToolStripMenuItem.Text;
        }
    }
}