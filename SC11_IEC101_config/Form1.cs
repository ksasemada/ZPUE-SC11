using EasyModbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC11_IEC101_config
{
    public partial class Form1 : Form
    {
        byte connect_on = 0;
        ModbusClient modbusClient;
        public Form1()
        {
            InitializeComponent();
        }
        private void connect_button_Click(object sender, EventArgs e)
        {
            start_connection();
        }
        private void start_connection()
        {
            if (connect_on == 0)
            {
                log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Connecting..." + Environment.NewLine, Color.Black);
                modbusClient = new ModbusClient(list_com_cb.SelectedItem.ToString());
                //modbusClient = new ModbusClient("COM4");
                modbusClient.UnitIdentifier = 1;
                modbusClient.Baudrate = 115200;
                modbusClient.Parity = System.IO.Ports.Parity.None;
                modbusClient.StopBits = System.IO.Ports.StopBits.One;
                modbusClient.ConnectionTimeout = 500;
                try
                {
                    modbusClient.Connect();
                    connect_on = 1;
                    connect_button.Text = "Disconnect";
                    try
                    {
                        //Console.WriteLine("Value of Input Reg. #10: " + modbusClient.ReadHoldingRegisters(896, 21)[12].ToString());
                        var p = modbusClient.ReadHoldingRegisters(896, 21);
                        log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Connected. Response received from SC11." + Environment.NewLine, Color.Black);
                        save_speed_com_cb.Visible = true;
                        save_speed_com_label.Visible = true;
                        save_id_com_cb.Visible = true;
                        save_id_com_label.Visible = true;
                        save_button.Visible = true;
                        save_asdu_com_cb.Visible = true;
                        save_asdu_com_label.Visible = true;
                        save_prot_com_cb.Visible = true;
                        save_prot_com_label.Visible = true;
                        list_com_cb.Enabled = false;
                        save_prot_com_cb.SelectedIndex = p[6] - 1;
                        save_speed_com_cb.SelectedIndex = p[7];
                        save_id_com_cb.SelectedIndex = p[11] - 1;
                        save_asdu_com_cb.SelectedIndex = p[12] - 1;
                        //02  10  00  00  00  06  0C  00  28  FF D7  01  02  00  01  00  01  FE FD
                        //02  16  00  00  00  06  12  00  40 255 215 01  02  00  01  00  01 254 253
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Error: Device not responding." + Environment.NewLine, Color.Red);
                        modbusClient.Disconnect();
                        connect_button.Text = "Connect";
                        connect_on = 0;
                    }
                }
                catch (Exception ex)
                {
                    log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Error: " + ex.Message + Environment.NewLine, Color.Red);
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                modbusClient.Disconnect();
                connect_button.Text = "Connect";
                connect_on = 0;
                list_com_cb.Enabled = true;
                save_speed_com_cb.Visible = false;
                save_speed_com_label.Visible = false;
                save_id_com_cb.Visible = false;
                save_id_com_label.Visible = false;
                save_asdu_com_cb.Visible = false;
                save_asdu_com_label.Visible = false;
                save_prot_com_cb.Visible = false;
                save_prot_com_label.Visible = false;
                save_button.Visible = false;
                log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Disconnect." + Environment.NewLine, Color.Black);
            }
        }
        private void list_com()
        {
            string[] enableComPorts = SerialPort.GetPortNames();
            list_com_cb.Items.Clear();
            foreach (string port in enableComPorts)
            {
                list_com_cb.Items.Add(port);
            }
            try
            {
                list_com_cb.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No COM ports!", "Error");
                //Environment.Exit(0);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Configuring port X31 through port X41." + Environment.NewLine, Color.Black);
            log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Connection: white/blue-A, blue-B (5, 4 pin rj45 connector)" + Environment.NewLine, Color.Black);
            list_com();
        }
        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                modbusClient.WriteMultipleRegisters(0, new int[6] { 40, 65495, 258, 1, Convert.ToByte(save_id_com_cb.SelectedItem.ToString()), 65277 });
                int speed = 0;
                if (save_speed_com_cb.SelectedItem.ToString() == "1200") speed = 0;
                if (save_speed_com_cb.SelectedItem.ToString() == "2400") speed = 1;
                if (save_speed_com_cb.SelectedItem.ToString() == "4800") speed = 2;
                if (save_speed_com_cb.SelectedItem.ToString() == "9600") speed = 3;
                if (save_speed_com_cb.SelectedItem.ToString() == "19200") speed = 4;
                if (save_speed_com_cb.SelectedItem.ToString() == "38400") speed = 5;
                if (save_speed_com_cb.SelectedItem.ToString() == "57600") speed = 6;
                if (save_speed_com_cb.SelectedItem.ToString() == "115200") speed = 7;
                modbusClient.WriteMultipleRegisters(0, new int[8] { 41, 65494, 260, 1, speed, 0, 0, 65275 });
                modbusClient.WriteMultipleRegisters(0, new int[9] { 78, 65457, 261, 1, Convert.ToByte(save_asdu_com_cb.SelectedItem.ToString()), 0, 1, 0, 65274 });
                int prot = 0;
                if (save_prot_com_cb.SelectedItem.ToString() == "modbus") prot = 1;
                if (save_prot_com_cb.SelectedItem.ToString() == "iec101") prot = 2;
                modbusClient.WriteMultipleRegisters(0, new int[6] { 64, 65471, 258, 1, prot, 65277 });
                log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Configuration changed." + Environment.NewLine, Color.Black);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Error: Device not responding." + Environment.NewLine, Color.Red);
            }
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.Invoke(new Action(() => box.SelectionStart = box.TextLength));
            box.Invoke(new Action(() => box.SelectionLength = 0));
            box.Invoke(new Action(() => box.SelectionColor = color));
            box.Invoke(new Action(() => box.AppendText(text)));
            box.Invoke(new Action(() => box.SelectionColor = box.ForeColor));
        }
    }
}
