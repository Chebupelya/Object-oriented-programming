namespace WinFormsApp1
{
    partial class Form3
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
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CPU_Submit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CPU_Producer = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CPU_Series = new System.Windows.Forms.MaskedTextBox();
            this.CPU_Model = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CPU_Frequency = new System.Windows.Forms.MaskedTextBox();
            this.CPU_Max_Frequency = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.CPU_Architecture = new System.Windows.Forms.DomainUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CPU_Submit
            // 
            this.CPU_Submit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CPU_Submit.Location = new System.Drawing.Point(405, 270);
            this.CPU_Submit.Name = "CPU_Submit";
            this.CPU_Submit.Size = new System.Drawing.Size(169, 58);
            this.CPU_Submit.TabIndex = 32;
            this.CPU_Submit.Text = "Подтвердить";
            this.CPU_Submit.UseVisualStyleBackColor = true;
            this.CPU_Submit.Click += new System.EventHandler(this.CPU_Submit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(405, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Кол-во ядер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Частота(МГц)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(405, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Модель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(209, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Серия";
            // 
            // CPU_Producer
            // 
            this.CPU_Producer.FormattingEnabled = true;
            this.CPU_Producer.ItemHeight = 20;
            this.CPU_Producer.Items.AddRange(new object[] {
            "INTEL",
            "AMD"});
            this.CPU_Producer.Location = new System.Drawing.Point(15, 103);
            this.CPU_Producer.Name = "CPU_Producer";
            this.CPU_Producer.Size = new System.Drawing.Size(147, 44);
            this.CPU_Producer.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Производитель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "Процессор";
            // 
            // CPU_Series
            // 
            this.CPU_Series.HidePromptOnLeave = true;
            this.CPU_Series.Location = new System.Drawing.Point(209, 103);
            this.CPU_Series.Mask = "00";
            this.CPU_Series.Name = "CPU_Series";
            this.CPU_Series.Size = new System.Drawing.Size(125, 27);
            this.CPU_Series.TabIndex = 33;
            // 
            // CPU_Model
            // 
            this.CPU_Model.HidePromptOnLeave = true;
            this.CPU_Model.Location = new System.Drawing.Point(405, 103);
            this.CPU_Model.Mask = "A0000???";
            this.CPU_Model.Name = "CPU_Model";
            this.CPU_Model.Size = new System.Drawing.Size(125, 27);
            this.CPU_Model.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(209, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 23);
            this.label9.TabIndex = 35;
            this.label9.Text = "Макс. частота(МГц)";
            // 
            // CPU_Frequency
            // 
            this.CPU_Frequency.HidePromptOnLeave = true;
            this.CPU_Frequency.Location = new System.Drawing.Point(15, 202);
            this.CPU_Frequency.Mask = "0000";
            this.CPU_Frequency.Name = "CPU_Frequency";
            this.CPU_Frequency.Size = new System.Drawing.Size(125, 27);
            this.CPU_Frequency.TabIndex = 37;
            // 
            // CPU_Max_Frequency
            // 
            this.CPU_Max_Frequency.HidePromptOnLeave = true;
            this.CPU_Max_Frequency.Location = new System.Drawing.Point(209, 202);
            this.CPU_Max_Frequency.Mask = "0000";
            this.CPU_Max_Frequency.Name = "CPU_Max_Frequency";
            this.CPU_Max_Frequency.Size = new System.Drawing.Size(125, 27);
            this.CPU_Max_Frequency.TabIndex = 38;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.HidePromptOnLeave = true;
            this.maskedTextBox1.Location = new System.Drawing.Point(404, 202);
            this.maskedTextBox1.Mask = "00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(125, 27);
            this.maskedTextBox1.TabIndex = 39;
            // 
            // CPU_Architecture
            // 
            this.CPU_Architecture.Items.Add("x32");
            this.CPU_Architecture.Items.Add("x64");
            this.CPU_Architecture.Location = new System.Drawing.Point(16, 304);
            this.CPU_Architecture.Name = "CPU_Architecture";
            this.CPU_Architecture.Size = new System.Drawing.Size(150, 27);
            this.CPU_Architecture.TabIndex = 41;
            this.CPU_Architecture.Text = "x64";
            this.CPU_Architecture.Wrap = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(15, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "Разрядность процессора";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 357);
            this.Controls.Add(this.CPU_Architecture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.CPU_Max_Frequency);
            this.Controls.Add(this.CPU_Frequency);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CPU_Model);
            this.Controls.Add(this.CPU_Series);
            this.Controls.Add(this.CPU_Submit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CPU_Producer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CPU_Submit;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ListBox CPU_Producer;
        private Label label2;
        private Label label1;
        private MaskedTextBox CPU_Series;
        private MaskedTextBox CPU_Model;
        private Label label9;
        private MaskedTextBox CPU_Frequency;
        private MaskedTextBox CPU_Max_Frequency;
        private MaskedTextBox maskedTextBox1;
        private DomainUpDown CPU_Architecture;
        private Label label7;
    }
}