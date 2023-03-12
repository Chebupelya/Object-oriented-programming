namespace WinFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VC_Producer = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.VC_Series = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VC_Model = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VC_Frequency = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VC_Memory = new System.Windows.Forms.TrackBar();
            this.VC_DirectX11_Support = new System.Windows.Forms.DomainUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.VC_Submit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.VC_Memory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Видеокарта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Производитель";
            // 
            // VC_Producer
            // 
            this.VC_Producer.FormattingEnabled = true;
            this.VC_Producer.ItemHeight = 20;
            this.VC_Producer.Items.AddRange(new object[] {
            "NVIDIA",
            "AMD"});
            this.VC_Producer.Location = new System.Drawing.Point(30, 102);
            this.VC_Producer.Name = "VC_Producer";
            this.VC_Producer.Size = new System.Drawing.Size(147, 44);
            this.VC_Producer.TabIndex = 4;
            this.VC_Producer.SelectedIndexChanged += new System.EventHandler(this.VC_Producer_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(224, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Серия";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // VC_Series
            // 
            this.VC_Series.FormattingEnabled = true;
            this.VC_Series.Location = new System.Drawing.Point(224, 102);
            this.VC_Series.Name = "VC_Series";
            this.VC_Series.Size = new System.Drawing.Size(151, 28);
            this.VC_Series.TabIndex = 6;
            this.VC_Series.SelectedIndexChanged += new System.EventHandler(this.VC_Series_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(420, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Модель";
            // 
            // VC_Model
            // 
            this.VC_Model.FormattingEnabled = true;
            this.VC_Model.Location = new System.Drawing.Point(420, 102);
            this.VC_Model.Name = "VC_Model";
            this.VC_Model.Size = new System.Drawing.Size(151, 28);
            this.VC_Model.TabIndex = 8;
            this.VC_Model.SelectedIndexChanged += new System.EventHandler(this.VC_Model_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(224, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Частота";
            // 
            // VC_Frequency
            // 
            this.VC_Frequency.FormattingEnabled = true;
            this.VC_Frequency.Location = new System.Drawing.Point(224, 178);
            this.VC_Frequency.Name = "VC_Frequency";
            this.VC_Frequency.Size = new System.Drawing.Size(151, 28);
            this.VC_Frequency.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(420, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Поддержка DirectX11";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(30, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Объём памяти";
            // 
            // VC_Memory
            // 
            this.VC_Memory.LargeChange = 4;
            this.VC_Memory.Location = new System.Drawing.Point(30, 275);
            this.VC_Memory.Maximum = 32;
            this.VC_Memory.Minimum = 2;
            this.VC_Memory.Name = "VC_Memory";
            this.VC_Memory.Size = new System.Drawing.Size(130, 56);
            this.VC_Memory.SmallChange = 2;
            this.VC_Memory.TabIndex = 14;
            this.VC_Memory.TickFrequency = 2;
            this.VC_Memory.Value = 2;
            this.VC_Memory.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // VC_DirectX11_Support
            // 
            this.VC_DirectX11_Support.Items.Add("Имеется");
            this.VC_DirectX11_Support.Items.Add("Отсутствует");
            this.VC_DirectX11_Support.Location = new System.Drawing.Point(421, 178);
            this.VC_DirectX11_Support.Name = "VC_DirectX11_Support";
            this.VC_DirectX11_Support.Size = new System.Drawing.Size(150, 27);
            this.VC_DirectX11_Support.TabIndex = 15;
            this.VC_DirectX11_Support.Text = "Имеется";
            this.VC_DirectX11_Support.Wrap = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(182, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 27);
            this.label8.TabIndex = 16;
            this.label8.Text = "      ";
            // 
            // VC_Submit
            // 
            this.VC_Submit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VC_Submit.Location = new System.Drawing.Point(420, 260);
            this.VC_Submit.Name = "VC_Submit";
            this.VC_Submit.Size = new System.Drawing.Size(169, 58);
            this.VC_Submit.TabIndex = 17;
            this.VC_Submit.Text = "Подтвердить";
            this.VC_Submit.UseVisualStyleBackColor = true;
            this.VC_Submit.Click += new System.EventHandler(this.VC_Submit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 347);
            this.Controls.Add(this.VC_Submit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.VC_DirectX11_Support);
            this.Controls.Add(this.VC_Memory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VC_Frequency);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.VC_Model);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VC_Series);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VC_Producer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.VC_Memory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox VC_Producer;
        private Label label3;
        private OpenFileDialog openFileDialog1;
        private ComboBox VC_Series;
        private Label label4;
        private ComboBox VC_Model;
        private Label label5;
        private ComboBox VC_Frequency;
        private Label label6;
        private Label label7;
        private TrackBar VC_Memory;
        private DomainUpDown VC_DirectX11_Support;
        private Label label8;
        private Button VC_Submit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}