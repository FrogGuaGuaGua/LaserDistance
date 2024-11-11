using System.IO.Ports;
namespace LaserDistance
{
    public partial class Form1 : Form
    {
        SerialPort? port;
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

            qualityJudge_textBox.Text = "������Ʒ�ʣ�\r\n 0~0.1: ��\r\n 0.1~0.5: �е�\r\n >0.5: ��";
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
                    toolStripStatusLabel1.Text = selectedPort + "�ѳɹ���";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    toolStripStatusLabel1.Text = selectedPort + "��ʧ��";
                }
                //finally
                //{

                //}
            }
            else
            {
                toolStripStatusLabel1.Text = "��ѡ�񴮿ںźͲ�����";
            }
        }

    }
}
