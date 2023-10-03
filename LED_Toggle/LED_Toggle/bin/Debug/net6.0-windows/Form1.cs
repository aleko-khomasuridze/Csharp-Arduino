/*
 * LED Toggle Application for Arduino
 * 
 * This application allows users to control an LED connected to an Arduino board
 * by toggling its state (HIGH or LOW) using a graphical user interface. The application
 * communicates with the Arduino through a serial port. Users can select the Arduino port,
 * set the pin number, and specify the baud rate for communication.
 * 
 * The UI provides buttons to set the selected pin HIGH or LOW, and it displays messages
 * in a richTextBox indicating the actions performed.
 * 
 * Developed by Aleko Khomasuridze
 * Date: 10/03/2023
 */

using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace LED_Toggle
{
    public partial class Form1 : Form
    {
        // Create a SerialPort object to handle communication with Arduino
        SerialPort serialPort = new SerialPort();

        // Form constructor
        public Form1()
        {
            InitializeComponent();

            // Populate the ComboBox for available ports
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox3.Items.Add(s);
            }

            // Set default port and baud rate
            serialPort.PortName = "COM7"; // Set the default port
            serialPort.BaudRate = 9600;   // Set the default baud rate
        }

        // Event handler for button1 (setting pin high)
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if port or pin is not selected
            if (comboBox3.Text == string.Empty || comboBox2.Text == string.Empty)
            {
                richTextBox1.AppendText($"{DateTime.Now.ToString("HH:mm:ss")} -> Error While sending\n");
            }
            else
            {
                // Display a message and set the pin high
                richTextBox1.AppendText($"{DateTime.Now.ToString("HH:mm:ss")} -> SETTING PIN {comboBox2.Text} of Arduino HIGH\n");
                serialPort.Write("1");
            }

            // for autoscrolling the rich text feild when printing messages
            richTextBox1.ScrollToCaret();
        }

        // Event handler for button2 (setting pin low)
        private void button2_Click(object sender, EventArgs e)
        {
            // Check if port or pin is not selected
            if (comboBox3.Text == string.Empty || comboBox2.Text == string.Empty)
            {
                richTextBox1.AppendText($"{DateTime.Now.ToString("HH:mm:ss")} -> Error While sending\n");
            }
            else
            {
                // Display a message and set the pin low
                richTextBox1.AppendText($"{DateTime.Now.ToString("HH:mm:ss")} -> SETTING PIN {comboBox2.Text} of Arduino LOW\n");
                serialPort.Write("0");
            }

            // for autoscrolling the rich text feild when printing messages
            richTextBox1.ScrollToCaret();
        }

        // Event handler for comboBox2 selection change (updating UI labels)
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            High.Text = $"PIN {comboBox2.Text} HIGH";
            button2.Text = $"PIN {comboBox2.Text} LOW";
        }

        // Event handler for WriteParameters button click
        private void WriteParameters_Click(object sender, EventArgs e)
        {
            // Update the port and baud rate based on user selection
            serialPort.PortName = comboBox3.Text;

            // Parse and set the baud rate
            serialPort.BaudRate = int.Parse(CBBaudRate.Text);

            // Display a message about the parameters being written
            richTextBox1.AppendText($"{DateTime.Now.ToString("HH:mm:ss")} -> Writing PIN:[{comboBox2.Text}], PORT:[{comboBox3.Text}]\n");

            // You might want to send some data to the Arduino here if needed
            serialPort.Write(comboBox2.Text);

            // for autoscrolling the rich text feild when printing messages
            richTextBox1.ScrollToCaret();  
        }
    }
}
