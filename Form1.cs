using Microsoft.Win32;
using System.IO.Ports;
using System.Text;

namespace SerialPortAssistant
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();

        bool isOpen = false;
        bool isRShow = true;

        List<byte> receiveBuffer = new List<byte>();
        List<byte> sendBuffer = new List<byte>();

        int receiveCount = 0;
        int sendCount = 0;

        Queue<byte> bufferQueue = new Queue<byte>();

        bool isHeaderReceived = false;

        int frameLength = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBaudRate.Items.Add(4800);
            cmbBaudRate.Items.Add(9600);
            cmbBaudRate.Items.Add(115200);
            cmbBaudRate.Items.Add(200000);
            cmbParityBit.Items.Add("No parity");
            cmbParityBit.Items.Add("Odd parity");
            cmbParityBit.Items.Add("Even parity");
            cmbParityBit.Items.Add("Mark parity");
            cmbParityBit.Items.Add("Space parity");
            cmbDataBit.Items.Add(5);
            cmbDataBit.Items.Add(6);
            cmbDataBit.Items.Add(7);
            cmbDataBit.Items.Add(8);
            cmbStopBit.Items.Add(1);
            cmbStopBit.Items.Add(1.5);
            cmbStopBit.Items.Add(2);

            cmbBaudRate.SelectedIndex = 1;
            cmbParityBit.SelectedIndex = 0;
            cmbDataBit.SelectedIndex = 3;
            cmbStopBit.SelectedIndex = 0;

            SerialProtLoad();
            cmbPort.SelectedIndex = 0;
            //Set up a multicast delegation.
            serialPort.DataReceived += serialPort_DataReceived;

            EncodingInfo[] encodingInfo = Encoding.GetEncodings();
            cmbEncode.Text = encodingInfo[0].Name;
            foreach (EncodingInfo info in encodingInfo)
            {
                cmbEncode.Items.Add(info.Name);
            }
        }

        void SerialProtLoad()
        {
            //Get the serial port.
            RegistryKey? keyCom = Registry.LocalMachine.OpenSubKey(@"Hardware\DeviceMap\SerialComm");
            if (keyCom != null)
            {
                string[] coms = keyCom.GetValueNames();
                cmbPort.Items.Clear();
                //Get the value of serial port.
                foreach (string c in coms)
                {
                    string? portName = keyCom.GetValue(c) as string;
                    if (portName != null)
                        cmbPort.Items.Add(portName);
                }
            }
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                //Open the port.
                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = cmbPort.Text;
                    serialPort.BaudRate = int.Parse(cmbBaudRate.Text);
                    serialPort.DataBits = int.Parse(cmbDataBit.Text);
                    switch (cmbParityBit.SelectedIndex)
                    {
                        case 0:
                            serialPort.Parity = Parity.None;
                            break;
                        case 1:
                            serialPort.Parity = Parity.Odd;
                            break;
                        case 2:
                            serialPort.Parity = Parity.Even;
                            break;
                        case 3:
                            serialPort.Parity = Parity.Mark;
                            break;
                        case 4:
                            serialPort.Parity = Parity.Space;
                            break;
                        default:
                            serialPort.Parity = Parity.None;
                            break;
                    }
                    switch (cmbStopBit.SelectedIndex)
                    {
                        case 0:
                            serialPort.StopBits = StopBits.One;
                            break;
                        case 1:
                            serialPort.StopBits = StopBits.OnePointFive;
                            break;
                        case 2:
                            serialPort.StopBits = StopBits.Two;
                            break;
                        default:
                            serialPort.StopBits = StopBits.One;
                            break;
                    }
                    serialPort.Open();
                    isOpen = true;
                    btnOpenPort.Text = "Close the serial port";
                    lblStatus.Text = $"{serialPort.PortName} opened successfully";
                }
                else
                {
                    serialPort.Close();
                    isOpen = false;
                    btnOpenPort.Text = "Open the serial port";
                    lblStatus.Text = $"{serialPort.PortName} closed successfully";
                }
                if (isOpen)
                {
                    cmbPort.Enabled = false;
                    cmbBaudRate.Enabled = false;
                    cmbParityBit.Enabled = false;
                    cmbDataBit.Enabled = false;
                    cmbStopBit.Enabled = false;
                }
                else
                {
                    cmbPort.Enabled = true;
                    cmbBaudRate.Enabled = true;
                    cmbParityBit.Enabled = true;
                    cmbDataBit.Enabled = true;
                    cmbStopBit.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"{serialPort.PortName} error!";
                MessageBox.Show(ex.ToString() + "\nPort:" + serialPort.PortName.ToString());
            }
        }
        void SendData()
        {
            serialPort.Write(sendBuffer.ToArray(), 0, sendBuffer.Count);
            sendCount += sendBuffer.Count;
            lblSendCount.Text = sendCount.ToString();
        }


        private void btnSendManually_Click(object sender, EventArgs e)
        {
            if (rtxtSendBox.Text != "" && serialPort.IsOpen)
            {
                SendData();
            }
            else
            {
                MessageBox.Show("The sending data is empty!");
            }
        }

        void serialPort_DataReceived(object sender, EventArgs e)
        {
            if (!isRShow)
            {
                serialPort.DiscardInBuffer();
                return;
            }
            //Read the data.
            byte[] dataTemp = new byte[serialPort.BytesToRead];
            serialPort.Read(dataTemp, 0, dataTemp.Length);
            //Store in the buffer.
            receiveBuffer.AddRange(dataTemp);
            //Receive count.
            receiveCount += dataTemp.Length;
            Invoke(() =>
            {
                lblReceiveCount.Text = receiveCount.ToString();
                if (ckbDFR.Checked)
                {
                    //Parse the data.
                    foreach (byte data in dataTemp)
                    {
                        //Enqueue.
                        bufferQueue.Enqueue(data);
                    }
                    //Parse to get the frame header.
                    if (!isHeaderReceived)
                    {
                        foreach (byte b in bufferQueue.ToArray())
                        {
                            if (b != 0x7f)
                            {
                                //Dequeue.
                                bufferQueue.Dequeue();
                            }
                            else
                            {
                                isHeaderReceived = true;
                                break;
                            }
                        }
                    }
                    if (isHeaderReceived)
                    {
                        if (bufferQueue.Count >= 2)
                        {
                            frameLength = bufferQueue.ToArray()[1];
                            if (bufferQueue.Count >= 1 + 1 + frameLength + 2)
                            {
                                byte[] frameBuffer = new byte[1 + 1 + frameLength + 2];
                                Array.Copy(bufferQueue.ToArray(), 0, frameBuffer, 0, frameBuffer.Length);
                                if (FrameProcessing(frameBuffer))
                                {
                                    txtData.Text = Transform.ToHexString(frameBuffer);
                                    txtData1.Text = string.Format("{0:X2}", frameBuffer[2]);
                                    txtData2.Text = string.Format("{0:X2}", frameBuffer[3]);
                                    txtData3.Text = string.Format("{0:X2}", frameBuffer[4]);
                                    txtData4.Text = string.Format("{0:X2}", frameBuffer[5]);
                                }
                                else
                                {
                                    MessageBox.Show("Invalid data!");
                                }
                                for (int i = 0; i < 1 + 1 + frameLength + 2; i++)
                                {
                                    bufferQueue.Dequeue();
                                }
                                isHeaderReceived = false;
                            }
                        }
                    }
                }
                //Whether to choose hexadecimal or not.
                if (!ckbReceiveHex.Checked)
                {
                    string str = Encoding.GetEncoding(cmbEncode.Text).GetString(dataTemp);
                    str = str.Replace("\0", "\\0");

                    rtxtReceiveBox.AppendText(str);
                }
                else
                {
                    rtxtReceiveBox.AppendText(Transform.ToHexString(dataTemp, " "));
                }
            });
            //string dataReceived = serialPort.ReadExisting();
            //rtxtReceiveBox.AppendText(dataReceived);
        }

        bool FrameProcessing(byte[] frameBuffer)
        {
            bool flag = false;
            byte[] temp = new byte[frameBuffer.Length - 2];
            Array.Copy(frameBuffer, 0, temp, 0, temp.Length);
            byte[] crc = DataCheck.DataCrc16_Ccitt(temp, DataCheck.BigOrLittle.BigEndian);
            if (crc[0] == frameBuffer[frameBuffer.Length - 2] && crc[1] == frameBuffer[frameBuffer.Length - 1])
            {
                flag = true;
            }
            return flag;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (isRShow)
            {
                isRShow = false;
                btnPause.Text = "Continue";
            }
            else
            {
                isRShow = true;
                btnPause.Text = "Pause";
            }
        }

        private void ckbReceiveHex_CheckedChanged(object sender, EventArgs e)
        {
            if (rtxtReceiveBox.Text == "")
                return;
            if (ckbReceiveHex.Checked)
                rtxtReceiveBox.Text = Transform.ToHexString(receiveBuffer.ToArray(), " ");
            else
                rtxtReceiveBox.Text = Encoding.GetEncoding(cmbEncode.Text).GetString(receiveBuffer.ToArray()).Replace("\0", "\\0");
        }

        private void btnManuallyEmpty_Click(object sender, EventArgs e)
        {
            receiveBuffer.Clear();
            rtxtReceiveBox.Text = "";
            lblReceiveCount.Text = "0";
        }

        private void ckbAutoEmpty_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAutoEmpty.Checked)
                timer1.Start();
            else
                timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rtxtReceiveBox.Text.Length >= 4096)
            {
                receiveBuffer.Clear();
                rtxtReceiveBox.Text = "";
                lblReceiveCount.Text = "0";
            }
        }

        private void rtxtSendBox_Leave(object sender, EventArgs e)
        {
            if (ckbSendHex.Checked)
            {
                if (DataEncoding.IsHexString(rtxtSendBox.Text.Replace(" ", "")))
                {
                    sendBuffer.Clear();
                    sendBuffer.AddRange(Transform.ToBytes(rtxtSendBox.Text.Replace(" ", "")));
                }
                else
                {
                    MessageBox.Show("Please enter hexadecimal!");
                    ckbSendHex.Checked = false;
                }
            }
            else
            {
                sendBuffer.Clear();
                sendBuffer.AddRange(Encoding.GetEncoding(cmbEncode.Text).GetBytes(rtxtSendBox.Text));
            }
        }

        private void ckbSendHex_CheckedChanged(object sender, EventArgs e)
        {
            if (rtxtSendBox.Text == "") return;
            if (ckbSendHex.Checked)
            {
                rtxtSendBox.Text = Transform.ToHexString(sendBuffer.ToArray(), " ");
            }
            else
            {
                rtxtSendBox.Text = Encoding.GetEncoding(cmbEncode.Text).GetString(sendBuffer.ToArray()).Replace("\0", "\\0");
            }
        }

        private void btnEmptySend_Click(object sender, EventArgs e)
        {
            sendBuffer.Clear();
            rtxtSendBox.Text = "";
            sendCount = 0;
            lblSendCount.Text = "0";
        }

        private void ckbAutoSend_CheckedChanged(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen && ckbAutoSend.Checked)
            {
                ckbAutoSend.Checked = false;
                MessageBox.Show("The serial port is not opened");
                return;
            }
            if (serialPort.IsOpen && ckbAutoSend.Checked)
            {
                txtSendTimer.Enabled = false;
                btnSendManually.Enabled = false;
                int i = int.Parse(txtSendTimer.Text);
                if (i < 10 || i > 60 * 1000)
                {
                    i = 1000;
                    txtSendTimer.Text = "1000";
                    MessageBox.Show("The range is too small or too large");
                }
                timer2.Interval = i;
                timer2.Start();
            }
            else
            {
                btnSendManually.Enabled = true;
                txtSendTimer.Enabled = true;
                timer2.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (rtxtSendBox.Text != "" && serialPort.IsOpen)
            {
                SendData();
            }
            else
            {
                lblStatus.Text = "The sending data is empty!";
            }
        }

        private void lblEmptyCount_Click(object sender, EventArgs e)
        {
            sendBuffer.Clear();
            sendCount = 0;
            lblSendCount.Text = "0";
            rtxtSendBox.Text = "";

            receiveBuffer.Clear();
            receiveCount = 0;
            lblReceiveCount.Text = "0";
            rtxtReceiveBox.Text = "";
        }

        private void ckbRTS_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRTS.Checked)
            {
                serialPort.RtsEnable = true;
            }
            else
            {
                serialPort.RtsEnable = false;
            }
        }

        private void ckbDTR_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDTR.Checked)
            {
                serialPort.DtrEnable = true;
            }
            else
            {
                serialPort.DtrEnable = false;
            }
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtReceivePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if (txtReceivePath.Text == "")
            {
                return;
            }

            saveFileDialog1.InitialDirectory = txtReceivePath.Text + "\\";
            saveFileDialog1.Title = "Select the name of the file to be saved";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, rtxtReceiveBox.Text);
                MessageBox.Show("successfully");
            }
        }

        string context = "";

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select the name of the open file";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSendPath.Text = openFileDialog1.FileName;
                context = File.ReadAllText(openFileDialog1.FileName);
                rtxtSendBox.Text = context;
            }
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            if (context == "" || !serialPort.IsOpen)
            {
                MessageBox.Show("The data is empty or The serial port is not opened");
                return;
            }
            try
            {
                byte[] data = Encoding.GetEncoding(cmbEncode.Text).GetBytes(context);
                sendCount += data.Length;
                lblSendCount.Text = sendCount.ToString();
                int pagenum = data.Length / 4096;
                int remaind = data.Length % 4096;
                for (int i = 0; i < pagenum; i++)
                {
                    serialPort.Write(data, (i * 4096), 4096);
                    Thread.Sleep(100);
                }
                if (remaind > 0)
                {
                    serialPort.Write(data, (pagenum * 4096), remaind);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send\n" + ex.Message);
            }
        }
    }
}
