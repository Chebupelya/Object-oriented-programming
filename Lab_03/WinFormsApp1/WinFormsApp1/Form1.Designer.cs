using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.computer_type = new System.Windows.Forms.ListBox();
            this.processor = new System.Windows.Forms.Button();
            this.videocard = new System.Windows.Forms.Button();
            this.MB_RAM = new System.Windows.Forms.RadioButton();
            this.GB_RAM = new System.Windows.Forms.RadioButton();
            this.RAM_Memory = new System.Windows.Forms.ComboBox();
            this.RAM_Type = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.HD_MB = new System.Windows.Forms.RadioButton();
            this.HD_GB = new System.Windows.Forms.RadioButton();
            this.HD_Memory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addToLab = new System.Windows.Forms.Button();
            this.Lab_Compand = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поПроизводителюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поМоделиПроцессораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.комбинированныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поРазмеруОЗУToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.панельИнструментовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.поПроизводителюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поМоделиПроцессораToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.комбинированныйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.поЧастотеПроцессораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поРазмеруОЗУToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(263, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "IT лаборатория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип компьютера";
            // 
            // computer_type
            // 
            this.computer_type.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.computer_type.FormattingEnabled = true;
            this.computer_type.ItemHeight = 25;
            this.computer_type.Items.AddRange(new object[] {
            "Сервер",
            "Рабочая станция",
            "Ноутбук"});
            this.computer_type.Location = new System.Drawing.Point(24, 142);
            this.computer_type.Name = "computer_type";
            this.computer_type.Size = new System.Drawing.Size(161, 79);
            this.computer_type.TabIndex = 2;
            // 
            // processor
            // 
            this.processor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.processor.Location = new System.Drawing.Point(263, 142);
            this.processor.Name = "processor";
            this.processor.Size = new System.Drawing.Size(201, 79);
            this.processor.TabIndex = 3;
            this.processor.Text = "Процессор";
            this.processor.UseVisualStyleBackColor = true;
            this.processor.Click += new System.EventHandler(this.processor_Click);
            // 
            // videocard
            // 
            this.videocard.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.videocard.Location = new System.Drawing.Point(530, 142);
            this.videocard.Name = "videocard";
            this.videocard.Size = new System.Drawing.Size(201, 79);
            this.videocard.TabIndex = 4;
            this.videocard.Text = "Видеокарта";
            this.videocard.UseVisualStyleBackColor = true;
            this.videocard.Click += new System.EventHandler(this.videocard_Click);
            // 
            // MB_RAM
            // 
            this.MB_RAM.AutoSize = true;
            this.MB_RAM.Location = new System.Drawing.Point(6, 34);
            this.MB_RAM.Name = "MB_RAM";
            this.MB_RAM.Size = new System.Drawing.Size(52, 24);
            this.MB_RAM.TabIndex = 6;
            this.MB_RAM.TabStop = true;
            this.MB_RAM.Text = "MB";
            this.MB_RAM.UseVisualStyleBackColor = true;
            this.MB_RAM.CheckedChanged += new System.EventHandler(this.MB_RAM_CheckedChanged);
            // 
            // GB_RAM
            // 
            this.GB_RAM.AutoSize = true;
            this.GB_RAM.Location = new System.Drawing.Point(64, 34);
            this.GB_RAM.Name = "GB_RAM";
            this.GB_RAM.Size = new System.Drawing.Size(49, 24);
            this.GB_RAM.TabIndex = 7;
            this.GB_RAM.TabStop = true;
            this.GB_RAM.Text = "GB";
            this.GB_RAM.UseVisualStyleBackColor = true;
            this.GB_RAM.CheckedChanged += new System.EventHandler(this.GB_RAM_CheckedChanged);
            // 
            // RAM_Memory
            // 
            this.RAM_Memory.FormattingEnabled = true;
            this.RAM_Memory.Location = new System.Drawing.Point(6, 64);
            this.RAM_Memory.Name = "RAM_Memory";
            this.RAM_Memory.Size = new System.Drawing.Size(151, 28);
            this.RAM_Memory.TabIndex = 8;
            // 
            // RAM_Type
            // 
            this.RAM_Type.AutoSize = true;
            this.RAM_Type.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RAM_Type.Location = new System.Drawing.Point(24, 343);
            this.RAM_Type.Name = "RAM_Type";
            this.RAM_Type.Size = new System.Drawing.Size(84, 25);
            this.RAM_Type.TabIndex = 9;
            this.RAM_Type.Text = "Тип ОЗУ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "SRAM",
            "DRAM",
            "SDRAM"});
            this.listBox1.Location = new System.Drawing.Point(24, 371);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(151, 64);
            this.listBox1.TabIndex = 10;
            // 
            // HD_MB
            // 
            this.HD_MB.AutoSize = true;
            this.HD_MB.Location = new System.Drawing.Point(7, 34);
            this.HD_MB.Name = "HD_MB";
            this.HD_MB.Size = new System.Drawing.Size(52, 24);
            this.HD_MB.TabIndex = 12;
            this.HD_MB.TabStop = true;
            this.HD_MB.Text = "MB";
            this.HD_MB.UseVisualStyleBackColor = true;
            this.HD_MB.CheckedChanged += new System.EventHandler(this.HD_MB_CheckedChanged);
            // 
            // HD_GB
            // 
            this.HD_GB.AutoSize = true;
            this.HD_GB.Location = new System.Drawing.Point(65, 34);
            this.HD_GB.Name = "HD_GB";
            this.HD_GB.Size = new System.Drawing.Size(49, 24);
            this.HD_GB.TabIndex = 13;
            this.HD_GB.TabStop = true;
            this.HD_GB.Text = "GB";
            this.HD_GB.UseVisualStyleBackColor = true;
            this.HD_GB.CheckedChanged += new System.EventHandler(this.HD_GB_CheckedChanged);
            // 
            // HD_Memory
            // 
            this.HD_Memory.FormattingEnabled = true;
            this.HD_Memory.Location = new System.Drawing.Point(6, 64);
            this.HD_Memory.Name = "HD_Memory";
            this.HD_Memory.Size = new System.Drawing.Size(151, 28);
            this.HD_Memory.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(263, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Тип ЖД";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "SSD",
            "HDD"});
            this.listBox2.Location = new System.Drawing.Point(263, 371);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(161, 64);
            this.listBox2.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(530, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Дата приобретения";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(530, 276);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 27);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RAM_Memory);
            this.groupBox1.Controls.Add(this.MB_RAM);
            this.groupBox1.Controls.Add(this.GB_RAM);
            this.groupBox1.Location = new System.Drawing.Point(24, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 99);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размер ОЗУ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HD_Memory);
            this.groupBox2.Controls.Add(this.HD_MB);
            this.groupBox2.Controls.Add(this.HD_GB);
            this.groupBox2.Location = new System.Drawing.Point(263, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 99);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Размер ЖД";
            // 
            // addToLab
            // 
            this.addToLab.Location = new System.Drawing.Point(485, 370);
            this.addToLab.Name = "addToLab";
            this.addToLab.Size = new System.Drawing.Size(133, 65);
            this.addToLab.TabIndex = 21;
            this.addToLab.Text = "Добавить в лабораторию";
            this.addToLab.UseVisualStyleBackColor = true;
            this.addToLab.Click += new System.EventHandler(this.addToLab_Click);
            // 
            // Lab_Compand
            // 
            this.Lab_Compand.Location = new System.Drawing.Point(643, 370);
            this.Lab_Compand.Name = "Lab_Compand";
            this.Lab_Compand.Size = new System.Drawing.Size(133, 65);
            this.Lab_Compand.TabIndex = 22;
            this.Lab_Compand.Text = "Состав лаборатории";
            this.Lab_Compand.UseVisualStyleBackColor = true;
            this.Lab_Compand.Click += new System.EventHandler(this.Lab_Compand_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 453);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(764, 39);
            this.button3.TabIndex = 23;
            this.button3.Text = "Рассчитать стоимость лаборатории";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.панельИнструментовToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поПроизводителюToolStripMenuItem,
            this.поМоделиПроцессораToolStripMenuItem,
            this.комбинированныйToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // поПроизводителюToolStripMenuItem
            // 
            this.поПроизводителюToolStripMenuItem.Name = "поПроизводителюToolStripMenuItem";
            this.поПроизводителюToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.поПроизводителюToolStripMenuItem.Text = "По производителю процессора";
            this.поПроизводителюToolStripMenuItem.Click += new System.EventHandler(this.поПроизводителюToolStripMenuItem_Click);
            // 
            // поМоделиПроцессораToolStripMenuItem
            // 
            this.поМоделиПроцессораToolStripMenuItem.Name = "поМоделиПроцессораToolStripMenuItem";
            this.поМоделиПроцессораToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.поМоделиПроцессораToolStripMenuItem.Text = "По модели процессора";
            this.поМоделиПроцессораToolStripMenuItem.Click += new System.EventHandler(this.поМоделиПроцессораToolStripMenuItem_Click);
            // 
            // комбинированныйToolStripMenuItem
            // 
            this.комбинированныйToolStripMenuItem.Name = "комбинированныйToolStripMenuItem";
            this.комбинированныйToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.комбинированныйToolStripMenuItem.Text = "Комбинированный";
            this.комбинированныйToolStripMenuItem.Click += new System.EventHandler(this.комбинированныйToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поToolStripMenuItem,
            this.поРазмеруОЗУToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поToolStripMenuItem
            // 
            this.поToolStripMenuItem.Name = "поToolStripMenuItem";
            this.поToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.поToolStripMenuItem.Text = "По частоте процессора";
            this.поToolStripMenuItem.Click += new System.EventHandler(this.поToolStripMenuItem_Click);
            // 
            // поРазмеруОЗУToolStripMenuItem
            // 
            this.поРазмеруОЗУToolStripMenuItem.Name = "поРазмеруОЗУToolStripMenuItem";
            this.поРазмеруОЗУToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.поРазмеруОЗУToolStripMenuItem.Text = "По размеру ОЗУ";
            this.поРазмеруОЗУToolStripMenuItem.Click += new System.EventHandler(this.поРазмеруОЗУToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // панельИнструментовToolStripMenuItem
            // 
            this.панельИнструментовToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.панельИнструментовToolStripMenuItem.Name = "панельИнструментовToolStripMenuItem";
            this.панельИнструментовToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.панельИнструментовToolStripMenuItem.Text = "Панель инструментов";
            this.панельИнструментовToolStripMenuItem.Visible = false;
            this.панельИнструментовToolStripMenuItem.Click += new System.EventHandler(this.панельИнструментовToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton1,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton6,
            this.toolStripButton5,
            this.toolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поПроизводителюToolStripMenuItem1,
            this.поМоделиПроцессораToolStripMenuItem1,
            this.комбинированныйToolStripMenuItem1});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(86, 24);
            this.toolStripDropDownButton2.Text = "Поиск";
            // 
            // поПроизводителюToolStripMenuItem1
            // 
            this.поПроизводителюToolStripMenuItem1.Name = "поПроизводителюToolStripMenuItem1";
            this.поПроизводителюToolStripMenuItem1.Size = new System.Drawing.Size(315, 26);
            this.поПроизводителюToolStripMenuItem1.Text = "По производителю процессора";
            this.поПроизводителюToolStripMenuItem1.Click += new System.EventHandler(this.поПроизводителюToolStripMenuItem1_Click);
            // 
            // поМоделиПроцессораToolStripMenuItem1
            // 
            this.поМоделиПроцессораToolStripMenuItem1.Name = "поМоделиПроцессораToolStripMenuItem1";
            this.поМоделиПроцессораToolStripMenuItem1.Size = new System.Drawing.Size(315, 26);
            this.поМоделиПроцессораToolStripMenuItem1.Text = "По модели процессора";
            this.поМоделиПроцессораToolStripMenuItem1.Click += new System.EventHandler(this.поМоделиПроцессораToolStripMenuItem1_Click);
            // 
            // комбинированныйToolStripMenuItem1
            // 
            this.комбинированныйToolStripMenuItem1.Name = "комбинированныйToolStripMenuItem1";
            this.комбинированныйToolStripMenuItem1.Size = new System.Drawing.Size(315, 26);
            this.комбинированныйToolStripMenuItem1.Text = "Комбинированный";
            this.комбинированныйToolStripMenuItem1.Click += new System.EventHandler(this.комбинированныйToolStripMenuItem1_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поЧастотеПроцессораToolStripMenuItem,
            this.поРазмеруОЗУToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(126, 24);
            this.toolStripDropDownButton1.Text = "Сортировка";
            // 
            // поЧастотеПроцессораToolStripMenuItem
            // 
            this.поЧастотеПроцессораToolStripMenuItem.Name = "поЧастотеПроцессораToolStripMenuItem";
            this.поЧастотеПроцессораToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.поЧастотеПроцессораToolStripMenuItem.Text = "По частоте процессора";
            this.поЧастотеПроцессораToolStripMenuItem.Click += new System.EventHandler(this.поЧастотеПроцессораToolStripMenuItem_Click);
            // 
            // поРазмеруОЗУToolStripMenuItem1
            // 
            this.поРазмеруОЗУToolStripMenuItem1.Name = "поРазмеруОЗУToolStripMenuItem1";
            this.поРазмеруОЗУToolStripMenuItem1.Size = new System.Drawing.Size(256, 26);
            this.поРазмеруОЗУToolStripMenuItem1.Text = "По размеру ОЗУ";
            this.поРазмеруОЗУToolStripMenuItem1.Click += new System.EventHandler(this.поРазмеруОЗУToolStripMenuItem1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(97, 24);
            this.toolStripButton3.Text = "Очистить";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(89, 24);
            this.toolStripButton4.Text = "Удалить";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(75, 24);
            this.toolStripButton6.Text = "Назад";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(84, 24);
            this.toolStripButton5.Text = "Вперёд";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton7.Text = "toolStripButton7";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6});
            this.statusStrip1.Location = new System.Drawing.Point(0, 513);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(130, 20);
            this.toolStripStatusLabel1.Text = "Кол-во объектов:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(155, 20);
            this.toolStripStatusLabel3.Text = "Последнее действие:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(57, 20);
            this.toolStripStatusLabel5.Text = "Время:";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(129, 20);
            this.toolStripStatusLabel6.Text = "14.03.2023 1:57:05";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Lab_Compand);
            this.Controls.Add(this.addToLab);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.RAM_Type);
            this.Controls.Add(this.videocard);
            this.Controls.Add(this.processor);
            this.Controls.Add(this.computer_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox computer_type;
        private Button processor;
        private Button videocard;
        private RadioButton MB_RAM;
        private RadioButton GB_RAM;
        private ComboBox RAM_Memory;
        private Label RAM_Type;
        private ListBox listBox1;
        private RadioButton HD_MB;
        private RadioButton HD_GB;
        private ComboBox HD_Memory;
        private Label label5;
        private ListBox listBox2;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button addToLab;
        private Button Lab_Compand;
        private Button button3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripMenuItem сортировкаToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem поToolStripMenuItem;
        private ToolStripMenuItem поРазмеруОЗУToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton7;
        private ToolStripMenuItem панельИнструментовToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.Timer timer1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem поЧастотеПроцессораToolStripMenuItem;
        private ToolStripMenuItem поРазмеруОЗУToolStripMenuItem1;
        private ToolStripMenuItem поПроизводителюToolStripMenuItem;
        private ToolStripMenuItem поМоделиПроцессораToolStripMenuItem;
        private ToolStripMenuItem комбинированныйToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem поПроизводителюToolStripMenuItem1;
        private ToolStripMenuItem поМоделиПроцессораToolStripMenuItem1;
        private ToolStripMenuItem комбинированныйToolStripMenuItem1;
    }
}