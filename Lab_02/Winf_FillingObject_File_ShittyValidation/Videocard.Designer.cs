namespace Winf_FillingObject_File_ShittyValidation
{
    partial class StoreKeeperLogIn
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StoreKeeper = new System.Windows.Forms.Label();
            this.fullNameStoreKeeper = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.experienceStoreKeeper = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toShop = new System.Windows.Forms.Button();
            this.houseStoreKeeper = new System.Windows.Forms.MaskedTextBox();
            this.streetStoreKeeper = new System.Windows.Forms.MaskedTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.experienceStoreKeeper)).BeginInit();
            this.SuspendLayout();
            // 
            // StoreKeeper
            // 
            this.StoreKeeper.AutoSize = true;
            this.StoreKeeper.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StoreKeeper.Location = new System.Drawing.Point(186, 9);
            this.StoreKeeper.Name = "StoreKeeper";
            this.StoreKeeper.Size = new System.Drawing.Size(198, 38);
            this.StoreKeeper.TabIndex = 0;
            this.StoreKeeper.Text = "Видеокарта";
            this.StoreKeeper.Click += new System.EventHandler(this.StoreKeeper_Click);
            // 
            // fullNameStoreKeeper
            // 
            this.fullNameStoreKeeper.Location = new System.Drawing.Point(196, 80);
            this.fullNameStoreKeeper.Name = "fullNameStoreKeeper";
            this.fullNameStoreKeeper.Size = new System.Drawing.Size(161, 22);
            this.fullNameStoreKeeper.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Производитель";
            // 
            // experienceStoreKeeper
            // 
            this.experienceStoreKeeper.Location = new System.Drawing.Point(25, 132);
            this.experienceStoreKeeper.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.experienceStoreKeeper.Name = "experienceStoreKeeper";
            this.experienceStoreKeeper.Size = new System.Drawing.Size(120, 22);
            this.experienceStoreKeeper.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Серия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Модель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Частота";
            // 
            // toShop
            // 
            this.toShop.Location = new System.Drawing.Point(228, 361);
            this.toShop.Name = "toShop";
            this.toShop.Size = new System.Drawing.Size(100, 46);
            this.toShop.TabIndex = 9;
            this.toShop.Text = "Вход";
            this.toShop.UseVisualStyleBackColor = true;
            this.toShop.Click += new System.EventHandler(this.toShop_Click);
            // 
            // houseStoreKeeper
            // 
            this.houseStoreKeeper.Location = new System.Drawing.Point(423, 131);
            this.houseStoreKeeper.Name = "houseStoreKeeper";
            this.houseStoreKeeper.Size = new System.Drawing.Size(100, 22);
            this.houseStoreKeeper.TabIndex = 10;
            // 
            // streetStoreKeeper
            // 
            this.streetStoreKeeper.Location = new System.Drawing.Point(220, 131);
            this.streetStoreKeeper.Name = "streetStoreKeeper";
            this.streetStoreKeeper.Size = new System.Drawing.Size(122, 22);
            this.streetStoreKeeper.TabIndex = 11;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(423, 164);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 20);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "MHz";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(423, 190);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 20);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "GHz";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Поддержка DirectX11";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Имеется",
            "Не имеется"});
            this.comboBox1.Location = new System.Drawing.Point(71, 259);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Объем памяти";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(351, 261);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(127, 22);
            this.maskedTextBox1.TabIndex = 17;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(351, 289);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 20);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "MB";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(352, 315);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 20);
            this.radioButton4.TabIndex = 19;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "GB";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // StoreKeeperLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(564, 424);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.streetStoreKeeper);
            this.Controls.Add(this.houseStoreKeeper);
            this.Controls.Add(this.toShop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.experienceStoreKeeper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullNameStoreKeeper);
            this.Controls.Add(this.StoreKeeper);
            this.Name = "StoreKeeperLogIn";
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.experienceStoreKeeper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StoreKeeper;
        private System.Windows.Forms.MaskedTextBox fullNameStoreKeeper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown experienceStoreKeeper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button toShop;
        private System.Windows.Forms.MaskedTextBox houseStoreKeeper;
        private System.Windows.Forms.MaskedTextBox streetStoreKeeper;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

