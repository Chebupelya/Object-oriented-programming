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
            toolStripStatusLabel4.Text = "������ �����";

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
                MessageBox.Show("��������� ������ � ����������!");
                return;
            }
            try
            {
                comp.processor = form3.GetProcessor();
            }
            catch
            {
                MessageBox.Show("��������� ������ � ����������!");
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
                MessageBox.Show("��������� ��� ����!");
                return;
            }

            try
            {

                GetSetBufferComputers.Add(comp);
                toolStripStatusLabel2.Text = GetSetBufferComputers.Count().ToString();
            }
            catch
            {
                MessageBox.Show("�� ������� �������� ���������!");
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
            MessageBox.Show("���������: " + cost + "$");
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����� ������ ���������\nv 2.0.1");
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataContractSerializer xmlFormatter = new DataContractSerializer(typeof(List<Computer>));
            using (FileStream fs = new FileStream("Order.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter.WriteObject(fs, OrderedComputers);
            }
            MessageBox.Show("���������.");
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
            ������������������ToolStripMenuItem.Visible = !toolStrip1.Visible;

            toolStripStatusLabel4.Text = "�������� ��";
        }

        private void ������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            toolStrip1.Visible = !toolStrip1.Visible;
            ������������������ToolStripMenuItem.Visible = !toolStrip1.Visible;
            toolStripStatusLabel4.Text = "�������� ��";
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
                    "\r\n��� ����������: " + GetSetBufferComputers.ElementAt(counter_of_comp).computer_type +
                    "\r\n������ ���: " + GetSetBufferComputers.ElementAt(counter_of_comp).ram_memory +
                    "\r\n��� ���: " + GetSetBufferComputers.ElementAt(counter_of_comp).ram_type +
                    "\r\n������ ��: " + GetSetBufferComputers.ElementAt(counter_of_comp).hd_memory +
                    "\r\n��� ��: " + GetSetBufferComputers.ElementAt(counter_of_comp).hd_type +
                    "\r\n[���������]" +
                    "\r\n�������������: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.producer +
                    "\r\n�����: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.series +
                    "\r\n������: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.model +
                    "\r\n�������: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.frequency +
                    "\r\n����. �������: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.max_frequency +
                    "\r\n���-�� ����: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.cores_amount +
                    "\r\n����������� ����������: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.cpu_architecture +
                    "\r\n[����������]" +
                    "\r\n�������������: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.producer +
                    "\r\n�����: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.series +
                    "\r\n������: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.model +
                    "\r\n�������: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.frequency +
                    "\r\n��������� directx11: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.support_directx11 +
                    "\r\n������: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.vc_memory + " GB" +
                    "\r\n���� ������������: " + GetSetBufferComputers.ElementAt(counter_of_comp).purchase_date +
                    "\r\n���������: " + GetSetBufferComputers.ElementAt(counter_of_comp).cost_comp + "$\r\n" +
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
                    "\r\n��� ����������: " + GetSetBufferComputers.ElementAt(counter_of_comp).computer_type +
                    "\r\n������ ���: " + GetSetBufferComputers.ElementAt(counter_of_comp).ram_memory +
                    "\r\n��� ���: " + GetSetBufferComputers.ElementAt(counter_of_comp).ram_type +
                    "\r\n������ ��: " + GetSetBufferComputers.ElementAt(counter_of_comp).hd_memory +
                    "\r\n��� ��: " + GetSetBufferComputers.ElementAt(counter_of_comp).hd_type +
                    "\r\n[���������]" +
                    "\r\n�������������: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.producer +
                    "\r\n�����: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.series +
                    "\r\n������: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.model +
                    "\r\n�������: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.frequency +
                    "\r\n����. �������: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.max_frequency +
                    "\r\n���-�� ����: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.cores_amount +
                    "\r\n����������� ����������: " + GetSetBufferComputers.ElementAt(counter_of_comp).processor.cpu_architecture +
                    "\r\n[����������]" +
                    "\r\n�������������: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.producer +
                    "\r\n�����: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.series +
                    "\r\n������: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.model +
                    "\r\n�������: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.frequency +
                    "\r\n��������� directx11: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.support_directx11 +
                    "\r\n������: " + GetSetBufferComputers.ElementAt(counter_of_comp).videocard.vc_memory + " GB" +
                    "\r\n���� ������������: " + GetSetBufferComputers.ElementAt(counter_of_comp).purchase_date +
                    "\r\n���������: " + GetSetBufferComputers.ElementAt(counter_of_comp).cost_comp + "$\r\n" +
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
        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = ����������ToolStripMenuItem.Text + " " + ��ToolStripMenuItem.Text;
            OrderedComputers = GetSetBufferComputers.OrderBy(p => p.processor.frequency).ToList();
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = ����������ToolStripMenuItem.Text + " " + ������������ToolStripMenuItem.Text;
            OrderedComputers = GetSetBufferComputers.OrderByDescending(p => p.ram_memory).ToList();
        }
        private void �������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = ����������ToolStripMenuItem.Text + " " + ��ToolStripMenuItem.Text;
            OrderedComputers = GetSetBufferComputers.OrderBy(p => p.processor.frequency).ToList();
        }
        private void ������������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = ����������ToolStripMenuItem.Text + " " + ������������ToolStripMenuItem.Text;
            OrderedComputers = GetSetBufferComputers.OrderByDescending(p => p.ram_memory).ToList();
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = �����ToolStripMenuItem.Text + " " + ���������������ToolStripMenuItem.Text;
            form5 = new Form5(GetSetBufferComputers);
            form5.Show();
        }

        private void ������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = �����ToolStripMenuItem.Text + " " + ������������������ToolStripMenuItem.Text;
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = �����ToolStripMenuItem.Text + " " + ���������������ToolStripMenuItem.Text;
        }

        private void ���������������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = �����ToolStripMenuItem.Text + " " + ���������������ToolStripMenuItem.Text;
        }

        private void ������������������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = �����ToolStripMenuItem.Text + " " + ������������������ToolStripMenuItem.Text;
        }

        private void ���������������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = �����ToolStripMenuItem.Text + " " + ���������������ToolStripMenuItem.Text;
        }
    }
}