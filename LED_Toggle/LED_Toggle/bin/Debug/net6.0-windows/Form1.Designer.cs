namespace LED_Toggle
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
            High = new Button();
            button2 = new Button();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox3 = new ComboBox();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            writeParameters = new Button();
            label4 = new Label();
            CBBaudRate = new ComboBox();
            SuspendLayout();
            // 
            // High
            // 
            High.Location = new Point(21, 301);
            High.Margin = new Padding(4, 5, 4, 5);
            High.Name = "High";
            High.Size = new Size(171, 57);
            High.TabIndex = 1;
            High.Text = "Set Pin     HIGH";
            High.UseVisualStyleBackColor = true;
            High.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(21, 371);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(171, 54);
            button2.TabIndex = 2;
            button2.Text = "Set Pin     LOW";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D10", "D11", "D12", "D13", "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7" });
            comboBox2.Location = new Point(231, 327);
            comboBox2.Margin = new Padding(4, 5, 4, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(184, 31);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 299);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 4;
            label1.Text = "Choose Pin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 436);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 6;
            label2.Text = "COM PORT";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(231, 463);
            comboBox3.Margin = new Padding(4, 5, 4, 5);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(184, 31);
            comboBox3.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(21, 60);
            richTextBox1.Margin = new Padding(4, 5, 4, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(395, 213);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 26);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 8;
            label3.Text = "Sent Data";
            // 
            // writeParameters
            // 
            writeParameters.Location = new Point(21, 437);
            writeParameters.Margin = new Padding(4, 5, 4, 5);
            writeParameters.Name = "writeParameters";
            writeParameters.Size = new Size(171, 57);
            writeParameters.TabIndex = 9;
            writeParameters.Text = "Write Parameters";
            writeParameters.UseVisualStyleBackColor = true;
            writeParameters.Click += WriteParameters_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 367);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 11;
            label4.Text = "Baud rate";
            // 
            // CBBaudRate
            // 
            CBBaudRate.FormattingEnabled = true;
            CBBaudRate.Items.AddRange(new object[] { "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "57600", "115200", "230400", "250000", "500000", "1000000" });
            CBBaudRate.Location = new Point(231, 394);
            CBBaudRate.Margin = new Padding(4, 5, 4, 5);
            CBBaudRate.Name = "CBBaudRate";
            CBBaudRate.Size = new Size(184, 31);
            CBBaudRate.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 512);
            Controls.Add(label4);
            Controls.Add(CBBaudRate);
            Controls.Add(writeParameters);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(comboBox3);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(button2);
            Controls.Add(High);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button High;
        private Button button2;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private ComboBox comboBox3;
        private RichTextBox richTextBox1;
        private Label label3;
        private Button writeParameters;
        private Label label4;
        private ComboBox CBBaudRate;
    }
}