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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addToLab = new System.Windows.Forms.Button();
            this.Lab_Compand = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "IT лаборатория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 60);
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
            this.computer_type.Location = new System.Drawing.Point(24, 88);
            this.computer_type.Name = "computer_type";
            this.computer_type.Size = new System.Drawing.Size(161, 79);
            this.computer_type.TabIndex = 2;
            // 
            // processor
            // 
            this.processor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.processor.Location = new System.Drawing.Point(263, 88);
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
            this.videocard.Location = new System.Drawing.Point(530, 88);
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
            this.RAM_Type.Location = new System.Drawing.Point(24, 289);
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
            this.listBox1.Location = new System.Drawing.Point(24, 317);
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
            this.label5.Location = new System.Drawing.Point(263, 289);
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
            this.listBox2.Location = new System.Drawing.Point(263, 317);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(161, 64);
            this.listBox2.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(530, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Дата приобретения";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(530, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 27);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RAM_Memory);
            this.groupBox1.Controls.Add(this.MB_RAM);
            this.groupBox1.Controls.Add(this.GB_RAM);
            this.groupBox1.Location = new System.Drawing.Point(24, 181);
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
            this.groupBox2.Location = new System.Drawing.Point(263, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 99);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Размер ЖД";
            // 
            // addToLab
            // 
            this.addToLab.Location = new System.Drawing.Point(485, 316);
            this.addToLab.Name = "addToLab";
            this.addToLab.Size = new System.Drawing.Size(133, 65);
            this.addToLab.TabIndex = 21;
            this.addToLab.Text = "Добавить в лабораторию";
            this.addToLab.UseVisualStyleBackColor = true;
            this.addToLab.Click += new System.EventHandler(this.addToLab_Click);
            // 
            // Lab_Compand
            // 
            this.Lab_Compand.Location = new System.Drawing.Point(643, 316);
            this.Lab_Compand.Name = "Lab_Compand";
            this.Lab_Compand.Size = new System.Drawing.Size(133, 65);
            this.Lab_Compand.TabIndex = 22;
            this.Lab_Compand.Text = "Состав лаборатории";
            this.Lab_Compand.UseVisualStyleBackColor = true;
            this.Lab_Compand.Click += new System.EventHandler(this.Lab_Compand_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(764, 39);
            this.button3.TabIndex = 23;
            this.button3.Text = "Рассчитать стоимость лаборатории";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button addToLab;
        private Button Lab_Compand;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
    }
}