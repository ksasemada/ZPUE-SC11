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
using EasyModbus;
using System.Management;
using System.IO;

namespace modbus
{
    public partial class com_reload : Form
    {
        byte connect_on = 0;
        ModbusClient modbusClient;
        string ver="v1.01";
        string key_file = "";
        public com_reload()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Настройка SC11 "+ver;
            log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Старт программы для настройки SC11." + Environment.NewLine, Color.Black);
            log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Внимание! Программа неофициальная. Все действия на свой страх и риск!!!" + Environment.NewLine, Color.Red);
            log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Внимание! При изменении скорости программа может зависнуть. Решается путем перезагрузки устройства SC11." + Environment.NewLine, Color.Red);
            log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Порядок действий: Подключаемся, меняем адрес, затем меняем скорость." + Environment.NewLine, Color.Black);
            list_com();
            speed_com_cb.SelectedIndex = 0;
            id_com_cb.SelectedIndex = 0;
            string sum = "";
            int key = 0;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
            foreach (ManagementObject hdd in searcher.Get())
            {
                //Console.WriteLine("-------");
                string serial = hdd["SerialNumber"].ToString().Replace(" ", ""); ;
                //Console.WriteLine(serial);

                sum = sum + serial[0];
                sum = sum + serial[1];
                sum = sum + serial[serial.Length - 2];
                sum = sum + serial[serial.Length - 1];
                //Console.WriteLine(sum);
                key = ((serial[1] + 17) * 22) * serial[serial.Length - 1] + serial[1] * serial[0] + serial[1] * serial[serial.Length - 2] + serial[1] * 3 + serial[serial.Length - 2] - 4 + serial[serial.Length - 1] * 5 + (serial[serial.Length - 2] + 3) * 7 + (serial[0] - 3) * 2 + (serial[1] + 14) * 8 + (serial[serial.Length - 1] + serial[serial.Length - 2]) * 11;
                //Console.WriteLine("key=" + key);
                goto l1;
            }
            l1:
            Console.WriteLine("end1");
            StreamReader sw;
            try
            {
                sw = File.OpenText("key.txt");
                key_file = sw.ReadLine();
                sw.Close();
                if (key_file == key.ToString()) goto l2;
            }
            catch (Exception ex)
            {
                string result = Microsoft.VisualBasic.Interaction.InputBox("Введите ключ для программы. Код "+ sum);
                if (result== key.ToString())
                {
                    File.WriteAllText("key.txt", key.ToString());
                    goto l2;
                }
                MessageBox.Show("Введен неправильный ключ", "Ошибка");
                Environment.Exit(0);
            }
            string result2 = Microsoft.VisualBasic.Interaction.InputBox("Введите ключ для программы. Код " + sum);
            if (result2 == key.ToString())
            {
                File.WriteAllText("key.txt", key.ToString());
                goto l2;
            }
            MessageBox.Show("Введен неправильный ключ", "Ошибка");
            Environment.Exit(0);
            l2:
            Console.WriteLine("end2");
            //System.IO.DriveInfo dInfo = new System.IO.DriveInfo("C");  //You must put the drive letter here.
            //log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " "+dInfo.VolumeLabel + Environment.NewLine, Color.Black);



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
                MessageBox.Show("Нет COM портов!", "Ошибка");
                Environment.Exit(0);
            }
        }

        private void start_connection()
        {
            if (connect_on == 0)
            {
                log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Подключаемся..." + Environment.NewLine, Color.Black);
                //Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " connect " + list_com_cb.SelectedItem.ToString());
                modbusClient = new ModbusClient(list_com_cb.SelectedItem.ToString());
                //modbusClient = new ModbusClient("COM4");
                modbusClient.UnitIdentifier = Convert.ToByte(id_com_cb.SelectedItem.ToString()); //Not necessary since default slaveID = 1;
                modbusClient.Baudrate = Convert.ToInt32(speed_com_cb.SelectedItem.ToString());   // Not necessary since default baudrate = 9600
                modbusClient.Parity = System.IO.Ports.Parity.None;
                modbusClient.StopBits = System.IO.Ports.StopBits.One;
                modbusClient.ConnectionTimeout = 500;
                try
                {
                    modbusClient.Connect();
                    connect_on = 1;
                    connect_button.Text = "Отключится";
                    //refreash.Enabled = true;
                    try
                    {
                        Console.WriteLine("Value of Input Reg. #10: " + modbusClient.ReadHoldingRegisters(520, 1)[0].ToString());
                        log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Подключились. Получен ответ от SC11." + Environment.NewLine, Color.Black);
                        save_speed_com_cb.Visible = true;
                        save_speed_com_label.Visible = true;
                        save_id_com_cb.Visible = true;
                        save_id_com_label.Visible = true;
                        save_button.Visible = true;
                        save_speed_com_cb.SelectedIndex = speed_com_cb.SelectedIndex;
                        save_id_com_cb.SelectedIndex = id_com_cb.SelectedIndex;
                        list_com_cb.Enabled = false;
                        speed_com_cb.Enabled = false;
                        id_com_cb.Enabled = false;

                        //02  10  00  00  00  06  0C  00  28  FF D7  01  02  00  01  00  01  FE FD
                        //02  16  00  00  00  06  12  00  40 255 215 01  02  00  01  00  01 254 253

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);

                            log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Ошибка: Устройство не отвечает" + Environment.NewLine, Color.Red);
                            modbusClient.Disconnect();
                            connect_button.Text = "Подключиться";
                            connect_on = 0;




                    }

                }
                catch (Exception ex)
                {
                    log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Ошибка: " + ex.Message + Environment.NewLine, Color.Red);
                    Console.WriteLine("Error: " + ex.Message);
                    //MessageBox.Show(ex.Message, "Ошибка");
                }
            }
            else
            {
                modbusClient.Disconnect();
                connect_button.Text = "Подключиться";
                connect_on = 0;
                list_com_cb.Enabled = true;
                speed_com_cb.Enabled = true;
                id_com_cb.Enabled = true;
                save_speed_com_cb.Visible = false;
                save_speed_com_label.Visible = false;
                save_id_com_cb.Visible = false;
                save_id_com_label.Visible = false;
                save_button.Visible = false;
                log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Отключились." + Environment.NewLine, Color.Black);
            }

            //modbusClient.WriteMultipleRegisters(0, new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            //

        }


        private void connect_button_Click(object sender, EventArgs e)
        {
            start_connection();
        }

        private void refreash_Tick(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Value of Input Reg. #10: " + modbusClient.ReadHoldingRegisters(520, 1)[0].ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if ((save_speed_com_cb.SelectedIndex == speed_com_cb.SelectedIndex)&& (save_id_com_cb.SelectedIndex == id_com_cb.SelectedIndex))
            {
                log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Внимание! настройки для записи не отличаются от настроек в устройстве." + Environment.NewLine, Color.Black);
            }
            if ((save_speed_com_cb.SelectedIndex == speed_com_cb.SelectedIndex) && (save_id_com_cb.SelectedIndex != id_com_cb.SelectedIndex))
            {
                log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Меняем адрес устройства..." + Environment.NewLine, Color.Black);
                try
                {
                    modbusClient.WriteMultipleRegisters(0, new int[6] { 40, 65495, 258, 1, Convert.ToByte(save_id_com_cb.SelectedItem.ToString()), 65277 });
                    id_com_cb.SelectedIndex = Convert.ToByte(save_id_com_cb.SelectedItem.ToString()) - 1;
                    start_connection();
                    start_connection();
                }
                catch (Exception ex)
                {
                    log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Ошибка: " + ex.Message + Environment.NewLine, Color.Red);
                    Console.WriteLine("Error: " + ex.Message);
                }
                
            }
            if ((save_speed_com_cb.SelectedIndex != speed_com_cb.SelectedIndex) && (save_id_com_cb.SelectedIndex == id_com_cb.SelectedIndex))
            {
                log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Меняем скорость устройства..." + Environment.NewLine, Color.Black);
                //MessageBox.Show("После изменения скорости программа пожет зависнуть. Необходимо отключить/включить SC11!!!", "Внимание!");
                try
                {
                    int speed = 0;
                    if (save_speed_com_cb.SelectedItem.ToString() == "9600") speed = 0;
                    if (save_speed_com_cb.SelectedItem.ToString() == "19200") speed = 1;
                    if (save_speed_com_cb.SelectedItem.ToString() == "38400") speed = 2;
                    if (save_speed_com_cb.SelectedItem.ToString() == "57600") speed = 3;
                    if (save_speed_com_cb.SelectedItem.ToString() == "115200") speed = 4;
                    modbusClient.WriteMultipleRegisters(0, new int[8] {41, 65494, 260, 1 , speed, 0, 0, 65275 });
                    speed_com_cb.SelectedIndex = save_speed_com_cb.SelectedIndex;
                    start_connection();
                    //start_connection();
                    //log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Внимание! После изменения скорости необходимо отключить/включить SC11!!!" + Environment.NewLine, Color.Black);

                    //02  10  00  00  00  06  0C         00  28  FF D7  01  02  00  01  00  01  FE FD
                    //02  16  00  00  00  06  12         00  40 255 215 01  02  00  01  00  01 254 253

                    //01  10  00  00  00  08  10         0029  FFD6  0104 0001 0000 0000 0000 FEFB
                    //                                   41   65494  260   1  speed   0     0  65275 


                }
                catch (Exception ex)
                {
                    log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Ошибка: " + ex.Message + Environment.NewLine, Color.Red);
                    Console.WriteLine("Error: " + ex.Message);
                }
                
            }
            if ((save_id_com_cb.SelectedIndex != id_com_cb.SelectedIndex) && (save_id_com_cb.SelectedIndex != id_com_cb.SelectedIndex))
            {
                log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Внимание! Две операции за один раз не поддерживаются. Меняем скорость или адрес." + Environment.NewLine, Color.Black);
            }
            try
            {
                //modbusClient.WriteMultipleRegisters(0, new int[6] { 40, 65495, 258, 1, 2, 65277 });//, 0 , 1, 254, 253 });
            }
            catch (Exception ex)
            {
                log_txt_richTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.") + " Ошибка: " + ex.Message + Environment.NewLine, Color.Red);
                Console.WriteLine("Error: " + ex.Message);
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
