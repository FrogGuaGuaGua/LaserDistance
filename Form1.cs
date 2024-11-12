using System.IO.Ports;
namespace LaserDistance
{
    public partial class Form1 : Form
    {
        SerialPort? port;
        float[] zero = new float[6];
        float[] dist = new float[6];
        float[] diff = new float[6];

        float sum = 0.0f, average = 0.0f, variance = 0.0f, varianceSum = 0.0f;

        bool isZeroSet = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            COM_comboBox.Items.Add("COM1");
            COM_comboBox.Items.Add("COM2");
            COM_comboBox.Items.Add("COM3");
            COM_comboBox.Items.Add("COM4");
            COM_comboBox.Items.Add("COM5");
            COM_comboBox.Items.Add("COM6");
            COM_comboBox.Items.Add("COM7");
            COM_comboBox.Items.Add("COM8");
            COM_comboBox.SelectedIndex = 3;

            baudRate_comboBox.Items.Add("9600");
            baudRate_comboBox.Items.Add("14400");
            baudRate_comboBox.Items.Add("19200");
            baudRate_comboBox.Items.Add("38400");
            baudRate_comboBox.Items.Add("57600");
            baudRate_comboBox.Items.Add("115200");
            baudRate_comboBox.Items.Add("230400");
            baudRate_comboBox.SelectedIndex = 5;

            qualityJudge_textBox.Text = "方差与品质：\r\n    0~0.2: 好\r\n 0.2~0.5: 中等\r\n      >0.5: 差";

            timer1.Interval = 500;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void openPortButton_Click(object sender, EventArgs e)
        {
            if (COM_comboBox.SelectedItem != null && baudRate_comboBox.SelectedItem != null)
            {
                string selectedPort = COM_comboBox.SelectedItem.ToString();
                int selectedBaudRate = int.Parse(baudRate_comboBox.SelectedItem.ToString());

                port = new SerialPort(selectedPort, selectedBaudRate);
                try
                {
                    port.Open();
                    toolStripStatusLabel1.Text = selectedPort + "已成功打开";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    toolStripStatusLabel1.Text = selectedPort + "打开失败";
                }
                //finally
                //{

                //}
            }
            else
            {
                toolStripStatusLabel1.Text = "请选择COM号和波特率";
            }
        }

        private void timer1_Tick(object? sender, EventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                for (byte i = 0; i < 6; i = (byte)(i + 1))
                {
                    dist[i] = SendAndReceive(i, port);
                }

                current_textBox1.Text = dist[0].ToString("F3");
                current_textBox2.Text = dist[1].ToString("F3");
                current_textBox3.Text = dist[2].ToString("F3");
                current_textBox4.Text = dist[3].ToString("F3");
                current_textBox5.Text = dist[4].ToString("F3");
                current_textBox6.Text = dist[5].ToString("F3");

                if (isZeroSet == false)
                {
                    toolStripStatusLabel1.Text = "尚未设置零点，无法计算方差";
                    return;
                }

                sum = 0.0f;
                varianceSum = 0.0f;
                for (int i = 0; i < 6; i = i + 1)
                {
                    diff[i] = dist[i] - zero[i];
                    sum = sum + diff[i];
                    varianceSum = varianceSum + diff[i] * diff[i];
                }
                diff_textBox1.Text = diff[0].ToString("F3");
                diff_textBox2.Text = diff[1].ToString("F3");
                diff_textBox3.Text = diff[2].ToString("F3");
                diff_textBox4.Text = diff[3].ToString("F3");
                diff_textBox5.Text = diff[4].ToString("F3");
                diff_textBox6.Text = diff[5].ToString("F3");

                average = sum / 6.0f;
                variance = varianceSum / 6.0f;
                if (variance < 0.2)
                {
                    variance_textBox.BackColor = Color.Green;
                }
                else if (variance < 0.5)
                {
                    variance_textBox.BackColor = Color.Yellow;
                }
                else
                {
                    variance_textBox.BackColor = Color.Red;
                }
                average_textBox.Text = average.ToString("F3");
                variance_textBox.Text = variance.ToString("F3");

            }
            else
            {
                toolStripStatusLabel1.Text = "COM口尚未打开";
            }
        }

        static float SendAndReceive(byte address, SerialPort port)
        {
            // 发送数据
            byte[] sendData = { address, 0x04, 0x00, 0x00, 0x00, 0x02 };
            byte[] crc = CalculateCRC(sendData);
            byte[] sendDataWithCRC = new byte[sendData.Length + crc.Length];
            Array.Copy(sendData, sendDataWithCRC, sendData.Length);
            Array.Copy(crc, 0, sendDataWithCRC, sendData.Length, crc.Length);
            port.Write(sendDataWithCRC, 0, sendDataWithCRC.Length);

            // 增加延时
            Thread.Sleep(50); // 延时

            // 接收数据
            byte[] receivedData = new byte[9];
            port.Read(receivedData, 0, receivedData.Length);

            // 验证接收到的数据的CRC校验码
            byte[] Calculated_CRC = CalculateCRC(receivedData, 0, receivedData.Length - 2);
            byte[] receivedCRCBytes = { receivedData[7], receivedData[8] };
            bool crcMatch = (Calculated_CRC[0] == receivedCRCBytes[0] && Calculated_CRC[1] == receivedCRCBytes[1]);
            for (byte i = 0; i < 3; i++)
            {
                if (crcMatch == false)
                {
                    port.Write(sendDataWithCRC, 0, sendDataWithCRC.Length);
                    port.Read(receivedData, 0, receivedData.Length);
                    Calculated_CRC = CalculateCRC(receivedData, 0, receivedData.Length - 2);
                    receivedCRCBytes = [receivedData[7], receivedData[8]];
                    crcMatch = (Calculated_CRC[0] == receivedCRCBytes[0] && Calculated_CRC[1] == receivedCRCBytes[1]);
                }
                else
                {
                    break;
                }
            }
            uint distance;
            if (BitConverter.IsLittleEndian)
            {
                byte[] tempArray = [receivedData[6], receivedData[5], receivedData[4], receivedData[3]];
                distance = BitConverter.ToUInt32(tempArray, 0);
            }
            else
            {
                distance = BitConverter.ToUInt32(receivedData, 3);
            }
            float distance_mm = distance / 1000.0f;
            if (distance_mm < 24.0f || distance_mm > 36.0f)
            {
                distance_mm = 0.0f;
            }

            // 输出结果
            Console.Write("  发送的数据：");
            Console.WriteLine(BitConverter.ToString(sendDataWithCRC));
            Console.Write("接收到的数据：");
            Console.WriteLine(BitConverter.ToString(receivedData));
            Console.WriteLine("距离：{0}mm", distance_mm);

            return distance_mm;
        }
        // 计算CRC校验码
        static byte[] CalculateCRC(byte[] data, int offset = 0, int length = -1)
        {
            if (length == -1)
                length = data.Length - offset;

            ushort crc = 0xFFFF;
            for (int i = offset; i < offset + length; i++)
            {
                crc ^= data[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x0001) == 0x0001)
                    {
                        crc >>= 1;
                        crc ^= 0xA001;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }
            return [(byte)(crc & 0xFF), (byte)(crc >> 8)];
        }

        private void setZero_button_Click(object sender, EventArgs e)
        {
            if (port != null)
            {
                if (port.IsOpen)
                {
                    for (byte i = 0; i < 6; i = (byte)(i + 1))
                    {
                        zero[i] = SendAndReceive(i, port);
                    }

                    zero_textBox1.Text = zero[0].ToString("F3");
                    zero_textBox2.Text = zero[1].ToString("F3");
                    zero_textBox3.Text = zero[2].ToString("F3");
                    zero_textBox4.Text = zero[3].ToString("F3");
                    zero_textBox5.Text = zero[4].ToString("F3");
                    zero_textBox6.Text = zero[5].ToString("F3");

                    isZeroSet = true;
                    toolStripStatusLabel1.Text = "已成功设置零点";
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "COM口尚未打开，无法设置零点";
            }
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            Form_help helpForm = new Form_help();
            helpForm.Show();
        }
    }
}

