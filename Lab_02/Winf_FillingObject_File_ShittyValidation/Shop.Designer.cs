namespace Winf_FillingObject_File_ShittyValidation
{
    partial class Shop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                //this._storeKeeperLogIn.Dispose();
            }
            base.Dispose(disposing);
            _storeKeeperLogIn.Dispose();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.productType = new System.Windows.Forms.ListBox();
            this.receiptDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.productAmount = new System.Windows.Forms.NumericUpDown();
            this.toProducer = new System.Windows.Forms.Button();
            this.addToStore = new System.Windows.Forms.Button();
            this.showStore = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Тип компьютера";
            // 
            // productType
            // 
            this.productType.FormattingEnabled = true;
            this.productType.ItemHeight = 16;
            this.productType.Items.AddRange(new object[] {
            "Компьютер",
            "Рабочая станция",
            "Ноутбук"});
            this.productType.Location = new System.Drawing.Point(52, 163);
            this.productType.Name = "productType";
            this.productType.Size = new System.Drawing.Size(120, 52);
            this.productType.TabIndex = 11;
            // 
            // receiptDate
            // 
            this.receiptDate.Location = new System.Drawing.Point(244, 193);
            this.receiptDate.Name = "receiptDate";
            this.receiptDate.Size = new System.Drawing.Size(200, 22);
            this.receiptDate.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата приобретения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Размер ОЗУ(ГБ)";
            // 
            // productAmount
            // 
            this.productAmount.Location = new System.Drawing.Point(244, 44);
            this.productAmount.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.productAmount.Name = "productAmount";
            this.productAmount.Size = new System.Drawing.Size(120, 22);
            this.productAmount.TabIndex = 16;
            // 
            // toProducer
            // 
            this.toProducer.Location = new System.Drawing.Point(52, 20);
            this.toProducer.Name = "toProducer";
            this.toProducer.Size = new System.Drawing.Size(135, 46);
            this.toProducer.TabIndex = 20;
            this.toProducer.Text = "Процессор";
            this.toProducer.UseVisualStyleBackColor = true;
            this.toProducer.Click += new System.EventHandler(this.toProducer_Click);
            // 
            // addToStore
            // 
            this.addToStore.Location = new System.Drawing.Point(123, 278);
            this.addToStore.Name = "addToStore";
            this.addToStore.Size = new System.Drawing.Size(123, 46);
            this.addToStore.TabIndex = 21;
            this.addToStore.Text = "Добавить в лабораторию";
            this.addToStore.UseVisualStyleBackColor = true;
            this.addToStore.Click += new System.EventHandler(this.addToStore_Click);
            // 
            // showStore
            // 
            this.showStore.Location = new System.Drawing.Point(306, 278);
            this.showStore.Name = "showStore";
            this.showStore.Size = new System.Drawing.Size(123, 46);
            this.showStore.TabIndex = 22;
            this.showStore.Text = "Показать лабораторию";
            this.showStore.UseVisualStyleBackColor = true;
            this.showStore.Click += new System.EventHandler(this.showStore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Тип ОЗУ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "SRAM",
            "DRAM",
            "SDRAM"});
            this.listBox1.Location = new System.Drawing.Point(244, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(60, 52);
            this.listBox1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Размер ЖД";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(428, 43);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            18000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 27;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Тип ЖД";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            "SSD",
            "HDD"});
            this.listBox2.Location = new System.Drawing.Point(428, 98);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(66, 52);
            this.listBox2.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 46);
            this.button1.TabIndex = 30;
            this.button1.Text = "Видеокарта";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(574, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showStore);
            this.Controls.Add(this.addToStore);
            this.Controls.Add(this.toProducer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.productAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.receiptDate);
            this.Controls.Add(this.productType);
            this.Controls.Add(this.label4);
            this.Name = "Shop";
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.productAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox productType;
        private System.Windows.Forms.DateTimePicker receiptDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown productAmount;
        private System.Windows.Forms.Button toProducer;
        private System.Windows.Forms.Button addToStore;
        private System.Windows.Forms.Button showStore;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
    }
}