namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            VC_Series.Enabled = false;
            VC_Series.DropDownStyle = ComboBoxStyle.DropDownList;
            VC_Model.Enabled = false;
            VC_Model.DropDownStyle = ComboBoxStyle.DropDownList;
            VC_Frequency.Enabled = false;
            VC_Frequency.DropDownStyle = ComboBoxStyle.DropDownList;
            label8.Text = VC_Memory.Value.ToString() + " GB";
        }

        private void VC_Producer_SelectedIndexChanged(object sender, EventArgs e)
        {
            VC_Series.Enabled = true;
            if (VC_Producer.SelectedIndex == 0)
            {
                VC_Series.Text = null;
                VC_Series.SelectedIndex = -1;
                VC_Series.Items.Clear();
                VC_Series.Items.AddRange(new object[]
                {
                    "2000",
                    "3000",
                    "4000"
                });
            }
            if (VC_Producer.SelectedIndex == 1)
            {
                VC_Series.Text = null;
                VC_Series.SelectedIndex = -1;
                VC_Series.Items.Clear();
                VC_Series.Items.AddRange(new object[]
                {
                    "5000",
                    "6000",
                    "7000"
                });
            }
            if (VC_Series.SelectedIndex == -1)
            {
                VC_Model.Enabled = false;
            }
        }
        private void VC_Series_SelectedIndexChanged(object sender, EventArgs e)
        {
            VC_Model.Enabled = true;
            VC_Model.Text = null;
            VC_Model.Items.Clear();
            if (VC_Producer.SelectedIndex == 0)
            {
                if (VC_Series.SelectedIndex == 0)
                {
                    VC_Model.Items.AddRange(new object[]
                    {
                    "RTX2060",
                    "RTX2070",
                    "RTX2080"
                    });
                }
                if (VC_Series.SelectedIndex == 1)
                {
                    VC_Model.Items.AddRange(new object[]
                    {
                    "RTX3070",
                    "RTX3080",
                    "RTX3090"
                    });
                }
                if (VC_Series.SelectedIndex == 2)
                {
                    VC_Model.Items.AddRange(new object[]
                    {
                    "RTX4070",
                    "RTX4080",
                    "RTX4090"
                    });
                }
            }
            if (VC_Producer.SelectedIndex == 1)
            {
                if (VC_Series.SelectedIndex == 0)
                {
                    VC_Model.Items.AddRange(new object[]
                    {
                    "RX5300",
                    "RX5500",
                    "RX5700"
                    });
                }
                if (VC_Series.SelectedIndex == 1)
                {
                    VC_Model.Items.AddRange(new object[]
                    {
                    "RX6800XT",
                    "RX6900XT",
                    "RX6950XT"
                    });
                }
                if (VC_Series.SelectedIndex == 2)
                {
                    VC_Model.Items.AddRange(new object[]
                    {
                    "RX7800XT",
                    "RX7900XT",
                    "RX7900XTX"
                    });
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            while (VC_Memory.Value % 2 != 0)
            {
                VC_Memory.Value++;
            }
            label8.Text = VC_Memory.Value.ToString() + " GB";
        }

        public Videocard vc;
        private void VC_Submit_Click(object sender, EventArgs e)
        {
            if (VC_Producer.Text == "" || VC_Series.Text == "" || VC_Model.Text == "" || VC_Frequency.Text == "" || VC_DirectX11_Support.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                try
                {
                    vc = new Videocard(
                        VC_Producer.Text,
                        Convert.ToInt32(VC_Series.Text),
                        VC_Model.Text,
                        VC_Frequency.Text,
                        VC_DirectX11_Support.Text,
                        VC_Memory.Value
                    );
                    Hide();
                }
                catch
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
        }
        public Videocard GetVideocard()
        {
            return vc;
        }

        public string PrintVCInfo()
        {
            return "\n[ВИДЕОКАРТА]" +
                "\nПроизводитель: " + VC_Producer.Text +
                "\nСерия: " + VC_Series.Text +
                "\nМодель: " + VC_Model.Text +
                "\nЧастота:" + VC_Frequency.Text +
                "\nПоддержка DirectX11: " + VC_DirectX11_Support.Text +
                "\nПамять: " + VC_Memory.Value + " GB";
        }

        private void VC_Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            VC_Frequency.Enabled = true;
            VC_Frequency.Items.Clear();
            VC_Frequency.Text = null;
            VC_Frequency.SelectedIndex = -1;
            if (VC_Producer.SelectedIndex == 0)
            {
                if (VC_Series.SelectedIndex == 0)
                {
                    if (VC_Model.SelectedIndex == 0)
                    {
                        VC_Frequency.Items.AddRange(new object[]
                        {
                            "1365MHz",
                            "1410MHz",
                            "1470MHz"
                        });
                    }
                    if (VC_Model.SelectedIndex == 1)
                    {
                        VC_Frequency.Items.AddRange(new object[]
                        {
                            "1410MHz",
                            "1605MHz"
                        });
                    }
                    if (VC_Model.SelectedIndex == 2)
                    {
                        VC_Frequency.Items.AddRange(new object[]
                        {
                            "1515MHz",
                            "1350MHz"
                        });
                    }
                }
                if (VC_Series.SelectedIndex == 1)
                {
                    if (VC_Model.SelectedIndex == 0)
                    {
                        VC_Frequency.Items.AddRange(new object[]
                        {
                            "1500MHz",
                            "1575MHz",
                        });
                    }
                    if (VC_Model.SelectedIndex == 1)
                    {
                        VC_Frequency.Items.AddRange(new object[]
                        {
                            "1365MHz",
                            "1440MHz"
                        });
                    }
                    if (VC_Model.SelectedIndex == 2)
                    {
                        VC_Frequency.Items.AddRange(new object[]
                        {
                            "1395MHz",
                            "1560MHz"
                        });
                    }
                }
                if (VC_Series.SelectedIndex == 2)
                {
                    if (VC_Model.SelectedIndex == 0)
                    {
                        VC_Frequency.Items.AddRange(new object[]
                        {
                            "2310MHz"
                        });
                    }
                    if (VC_Model.SelectedIndex == 1)
                    {
                        VC_Frequency.Items.AddRange(new object[]
                        {
                            "2205MHz"
                        });
                    }
                    if (VC_Model.SelectedIndex == 2)
                    {
                        VC_Frequency.Items.AddRange(new object[]
                        {
                            "2235MHz"
                        });
                    }
                }
            }
            if (VC_Producer.SelectedIndex == 1)
            {
                if (VC_Series.SelectedIndex == 0)
                {
                    if (VC_Model.SelectedIndex == 0)
                    {
                        VC_Frequency.Items.AddRange(new object[]
                        {
                            "1365MHz",
                            "1410MHz",
                            "1470MHz"
                        });
                    }
                    if (VC_Model.SelectedIndex == 1)
                    {
                        VC_Frequency.Items.AddRange(new object[]
                        {
                            "1410MHz",
                            "1605MHz"
                        });
                    }
                    if (VC_Model.SelectedIndex == 2)
                    {
                        VC_Frequency.Items.AddRange(new object[]
                        {
                            "1515MHz",
                            "1350MHz"
                        });
                    }
                }
                if (VC_Series.SelectedIndex == 1)
                {
                    if (VC_Model.SelectedIndex == 0)
                    {
                        VC_Frequency.Items.AddRange(new object[]
                        {
                            "1500MHz",
                            "1575MHz",
                        });
                    }
                    if (VC_Model.SelectedIndex == 1)
                    {
                        VC_Frequency.Items.AddRange(new object[]
                        {
                            "1365MHz",
                            "1440MHz"
                        });
                    }
                    if (VC_Model.SelectedIndex == 2)
                    {
                        VC_Frequency.Items.AddRange(new object[]
                        {
                            "1395MHz",
                            "1560MHz"
                        });
                    }
                }
                if (VC_Series.SelectedIndex == 2)
                {
                    if (VC_Model.SelectedIndex == 0)
                    {
                        VC_Frequency.Items.AddRange(new object[]
                        {
                            "2310MHz"
                        });
                    }
                    if (VC_Model.SelectedIndex == 1)
                    {
                        VC_Frequency.Items.AddRange(new object[]
                        {
                            "2205MHz"
                        });
                    }
                    if (VC_Model.SelectedIndex == 2)
                    {
                        VC_Frequency.Items.AddRange(new object[]
                        {
                            "2235MHz"
                        });
                    }
                }
            }
            if (VC_Model.SelectedIndex == -1)
            {
                VC_Frequency.Enabled = false;
            }
        }
    }
}
