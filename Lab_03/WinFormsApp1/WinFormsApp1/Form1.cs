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
            }
            catch
            {
                MessageBox.Show("�� ������� �������� ���������!");
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
                        "��� ����������: " + i.computer_type +
                        "\n������ ���: " + i.ram_memory +
                        "\n��� ���: " + i.ram_type +
                        "\n������ ��: " + i.hd_memory +
                        "\n��� ��: " + i.hd_type +
                        "\n[���������]" +
                        "\n�������������: " + i.processor.producer +
                        "\n�����: " + i.processor.series +
                        "\n������: " + i.processor.model +
                        "\n�������:" + i.processor.frequency +
                        "\n����. �������: " + i.processor.max_frequency +
                        "\n���-�� ����: " + i.processor.cores_amount +
                        "\n����������� ����������: " + i.processor.cpu_architecture +
                        "\n[����������]" +
                        "\n�������������: " + i.videocard.producer +
                        "\n�����: " + i.videocard.series +
                        "\n������: " + i.videocard.model +
                        "\n�������:" + i.videocard.frequency +
                        "\n��������� DirectX11: " + i.videocard.support_directx11 +
                        "\n������: " + i.videocard.vc_memory + " GB" +
                        "\n���� ������������: " + i.purchase_date +
                        "\n���������: " + i.cost_comp + "$"
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
            MessageBox.Show("���������: " + cost + "$");
        }
    }
}