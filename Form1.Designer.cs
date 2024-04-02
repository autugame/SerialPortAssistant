namespace SerialPortAssistant
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
            components = new System.ComponentModel.Container();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            groupBox7 = new GroupBox();
            cmbEncode = new ComboBox();
            label17 = new Label();
            groupBox6 = new GroupBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            ckbDFR = new CheckBox();
            txtData = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtData4 = new TextBox();
            txtData2 = new TextBox();
            txtData3 = new TextBox();
            txtData1 = new TextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblStatus = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            lblSendCount = new ToolStripStatusLabel();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            lblReceiveCount = new ToolStripStatusLabel();
            lblEmptyCount = new ToolStripStatusLabel();
            groupBox5 = new GroupBox();
            rtxtSendBox = new RichTextBox();
            groupBox4 = new GroupBox();
            rtxtReceiveBox = new RichTextBox();
            groupBox3 = new GroupBox();
            txtSendTimer = new TextBox();
            label8 = new Label();
            txtSendPath = new TextBox();
            btnOpenFile = new Button();
            btnEmptySend = new Button();
            ckbAutoSend = new CheckBox();
            btnSendFile = new Button();
            btnSendManually = new Button();
            ckbSendHex = new CheckBox();
            groupBox2 = new GroupBox();
            btnSelectPath = new Button();
            txtReceivePath = new TextBox();
            btnPause = new Button();
            btnSaveData = new Button();
            ckbReceiveHex = new CheckBox();
            btnManuallyEmpty = new Button();
            ckbAutoEmpty = new CheckBox();
            groupBox1 = new GroupBox();
            btnOpenPort = new Button();
            ckbDTR = new CheckBox();
            ckbRTS = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cmbStopBit = new ComboBox();
            cmbDataBit = new ComboBox();
            cmbParityBit = new ComboBox();
            cmbBaudRate = new ComboBox();
            cmbPort = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            folderBrowserDialog1 = new FolderBrowserDialog();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            tabPage1.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(871, 639);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox7);
            tabPage1.Controls.Add(groupBox6);
            tabPage1.Controls.Add(statusStrip1);
            tabPage1.Controls.Add(groupBox5);
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(871, 639);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Serial port";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cmbEncode);
            groupBox7.Controls.Add(label17);
            groupBox7.Location = new Point(681, 428);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(184, 175);
            groupBox7.TabIndex = 13;
            groupBox7.TabStop = false;
            groupBox7.Text = "Encoding settings";
            // 
            // cmbEncode
            // 
            cmbEncode.FormattingEnabled = true;
            cmbEncode.Location = new Point(56, 19);
            cmbEncode.Name = "cmbEncode";
            cmbEncode.Size = new Size(121, 23);
            cmbEncode.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 23);
            label17.Name = "label17";
            label17.Size = new Size(46, 15);
            label17.TabIndex = 0;
            label17.Text = "Encode";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label16);
            groupBox6.Controls.Add(label15);
            groupBox6.Controls.Add(label14);
            groupBox6.Controls.Add(ckbDFR);
            groupBox6.Controls.Add(txtData);
            groupBox6.Controls.Add(label13);
            groupBox6.Controls.Add(label12);
            groupBox6.Controls.Add(label11);
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(label9);
            groupBox6.Controls.Add(txtData4);
            groupBox6.Controls.Add(txtData2);
            groupBox6.Controls.Add(txtData3);
            groupBox6.Controls.Add(txtData1);
            groupBox6.Location = new Point(681, 6);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(184, 416);
            groupBox6.TabIndex = 12;
            groupBox6.TabStop = false;
            groupBox6.Text = "Instruction parsing";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 329);
            label16.Name = "label16";
            label16.Size = new Size(154, 15);
            label16.TabIndex = 13;
            label16.Text = "Example: 7f0431323334DE10\r\n";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(36, 305);
            label15.Name = "label15";
            label15.Size = new Size(127, 15);
            label15.TabIndex = 12;
            label15.Text = "7F+Length+Data+CRC";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 289);
            label14.Name = "label14";
            label14.Size = new Size(48, 15);
            label14.TabIndex = 11;
            label14.Text = "Format:";
            // 
            // ckbDFR
            // 
            ckbDFR.AutoSize = true;
            ckbDFR.Location = new Point(6, 267);
            ckbDFR.Name = "ckbDFR";
            ckbDFR.Size = new Size(179, 19);
            ckbDFR.TabIndex = 10;
            ckbDFR.Text = "Enables data frame reception";
            ckbDFR.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            txtData.Location = new Point(6, 196);
            txtData.Multiline = true;
            txtData.Name = "txtData";
            txtData.Size = new Size(171, 65);
            txtData.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 178);
            label13.Name = "label13";
            label13.Size = new Size(70, 15);
            label13.TabIndex = 8;
            label13.Text = "Data frames";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 139);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 7;
            label12.Text = "Data 4";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 100);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 6;
            label11.Text = "Data 3";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 61);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 5;
            label10.Text = "Data 2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 25);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 4;
            label9.Text = "Data 1";
            // 
            // txtData4
            // 
            txtData4.Location = new Point(78, 136);
            txtData4.Name = "txtData4";
            txtData4.Size = new Size(100, 23);
            txtData4.TabIndex = 3;
            // 
            // txtData2
            // 
            txtData2.Location = new Point(78, 58);
            txtData2.Name = "txtData2";
            txtData2.Size = new Size(100, 23);
            txtData2.TabIndex = 2;
            // 
            // txtData3
            // 
            txtData3.Location = new Point(77, 97);
            txtData3.Name = "txtData3";
            txtData3.Size = new Size(100, 23);
            txtData3.TabIndex = 1;
            // 
            // txtData1
            // 
            txtData1.Location = new Point(77, 22);
            txtData1.Name = "txtData1";
            txtData1.Size = new Size(100, 23);
            txtData1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblStatus, toolStripStatusLabel3, lblSendCount, toolStripStatusLabel5, lblReceiveCount, lblEmptyCount });
            statusStrip1.Location = new Point(3, 614);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(865, 22);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(41, 17);
            toolStripStatusLabel1.Text = "status:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = false;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(200, 17);
            lblStatus.Text = "Ready!";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(70, 17);
            toolStripStatusLabel3.Text = "Send count:";
            // 
            // lblSendCount
            // 
            lblSendCount.AutoSize = false;
            lblSendCount.Name = "lblSendCount";
            lblSendCount.Size = new Size(50, 17);
            lblSendCount.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(84, 17);
            toolStripStatusLabel5.Text = "Receive count:";
            // 
            // lblReceiveCount
            // 
            lblReceiveCount.AutoSize = false;
            lblReceiveCount.Name = "lblReceiveCount";
            lblReceiveCount.Size = new Size(50, 17);
            lblReceiveCount.Text = "0";
            // 
            // lblEmptyCount
            // 
            lblEmptyCount.Name = "lblEmptyCount";
            lblEmptyCount.Size = new Size(95, 17);
            lblEmptyCount.Text = "Empty the count";
            lblEmptyCount.Click += lblEmptyCount_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(rtxtSendBox);
            groupBox5.Location = new Point(255, 428);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(420, 175);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Send area";
            // 
            // rtxtSendBox
            // 
            rtxtSendBox.Dock = DockStyle.Fill;
            rtxtSendBox.Location = new Point(3, 19);
            rtxtSendBox.Name = "rtxtSendBox";
            rtxtSendBox.Size = new Size(414, 153);
            rtxtSendBox.TabIndex = 6;
            rtxtSendBox.Text = "";
            rtxtSendBox.Leave += rtxtSendBox_Leave;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rtxtReceiveBox);
            groupBox4.Location = new Point(255, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(420, 416);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Receive area";
            // 
            // rtxtReceiveBox
            // 
            rtxtReceiveBox.Dock = DockStyle.Fill;
            rtxtReceiveBox.Location = new Point(3, 19);
            rtxtReceiveBox.Name = "rtxtReceiveBox";
            rtxtReceiveBox.Size = new Size(414, 394);
            rtxtReceiveBox.TabIndex = 3;
            rtxtReceiveBox.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSendTimer);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtSendPath);
            groupBox3.Controls.Add(btnOpenFile);
            groupBox3.Controls.Add(btnEmptySend);
            groupBox3.Controls.Add(ckbAutoSend);
            groupBox3.Controls.Add(btnSendFile);
            groupBox3.Controls.Add(btnSendManually);
            groupBox3.Controls.Add(ckbSendHex);
            groupBox3.Location = new Point(8, 428);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(241, 175);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Send configuration";
            // 
            // txtSendTimer
            // 
            txtSendTimer.Location = new Point(150, 146);
            txtSendTimer.Name = "txtSendTimer";
            txtSendTimer.Size = new Size(85, 23);
            txtSendTimer.TabIndex = 24;
            txtSendTimer.Text = "1000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 149);
            label8.Name = "label8";
            label8.Size = new Size(138, 15);
            label8.TabIndex = 14;
            label8.Text = "Auto Sending Cycle (ms)";
            // 
            // txtSendPath
            // 
            txtSendPath.Location = new Point(6, 115);
            txtSendPath.Name = "txtSendPath";
            txtSendPath.Size = new Size(226, 23);
            txtSendPath.TabIndex = 18;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(6, 86);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(107, 23);
            btnOpenFile.TabIndex = 23;
            btnOpenFile.Text = "Open the file";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnEmptySend
            // 
            btnEmptySend.Location = new Point(125, 54);
            btnEmptySend.Name = "btnEmptySend";
            btnEmptySend.Size = new Size(107, 23);
            btnEmptySend.TabIndex = 20;
            btnEmptySend.Text = "Empty the send";
            btnEmptySend.UseVisualStyleBackColor = true;
            btnEmptySend.Click += btnEmptySend_Click;
            // 
            // ckbAutoSend
            // 
            ckbAutoSend.AutoSize = true;
            ckbAutoSend.Location = new Point(6, 22);
            ckbAutoSend.Name = "ckbAutoSend";
            ckbAutoSend.Size = new Size(81, 19);
            ckbAutoSend.TabIndex = 21;
            ckbAutoSend.Text = "Auto Send";
            ckbAutoSend.UseVisualStyleBackColor = true;
            ckbAutoSend.CheckedChanged += ckbAutoSend_CheckedChanged;
            // 
            // btnSendFile
            // 
            btnSendFile.Location = new Point(125, 86);
            btnSendFile.Name = "btnSendFile";
            btnSendFile.Size = new Size(107, 23);
            btnSendFile.TabIndex = 18;
            btnSendFile.Text = "Send the file";
            btnSendFile.UseVisualStyleBackColor = true;
            btnSendFile.Click += btnSendFile_Click;
            // 
            // btnSendManually
            // 
            btnSendManually.Location = new Point(125, 22);
            btnSendManually.Name = "btnSendManually";
            btnSendManually.Size = new Size(107, 23);
            btnSendManually.TabIndex = 19;
            btnSendManually.Text = "Send  manually";
            btnSendManually.UseVisualStyleBackColor = true;
            btnSendManually.Click += btnSendManually_Click;
            // 
            // ckbSendHex
            // 
            ckbSendHex.AutoSize = true;
            ckbSendHex.Location = new Point(6, 57);
            ckbSendHex.Name = "ckbSendHex";
            ckbSendHex.Size = new Size(95, 19);
            ckbSendHex.TabIndex = 22;
            ckbSendHex.Text = "Hexadecimal";
            ckbSendHex.UseVisualStyleBackColor = true;
            ckbSendHex.CheckedChanged += ckbSendHex_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSelectPath);
            groupBox2.Controls.Add(txtReceivePath);
            groupBox2.Controls.Add(btnPause);
            groupBox2.Controls.Add(btnSaveData);
            groupBox2.Controls.Add(ckbReceiveHex);
            groupBox2.Controls.Add(btnManuallyEmpty);
            groupBox2.Controls.Add(ckbAutoEmpty);
            groupBox2.Location = new Point(8, 273);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(241, 149);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Receive configuration";
            // 
            // btnSelectPath
            // 
            btnSelectPath.Location = new Point(6, 86);
            btnSelectPath.Name = "btnSelectPath";
            btnSelectPath.Size = new Size(107, 23);
            btnSelectPath.TabIndex = 17;
            btnSelectPath.Text = "Select a path";
            btnSelectPath.UseVisualStyleBackColor = true;
            btnSelectPath.Click += btnSelectPath_Click;
            // 
            // txtReceivePath
            // 
            txtReceivePath.Location = new Point(6, 115);
            txtReceivePath.Name = "txtReceivePath";
            txtReceivePath.Size = new Size(226, 23);
            txtReceivePath.TabIndex = 16;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(125, 54);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(107, 23);
            btnPause.TabIndex = 8;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnSaveData
            // 
            btnSaveData.Location = new Point(125, 86);
            btnSaveData.Name = "btnSaveData";
            btnSaveData.Size = new Size(107, 23);
            btnSaveData.TabIndex = 5;
            btnSaveData.Text = "Save the data";
            btnSaveData.UseVisualStyleBackColor = true;
            btnSaveData.Click += btnSaveData_Click;
            // 
            // ckbReceiveHex
            // 
            ckbReceiveHex.AutoSize = true;
            ckbReceiveHex.Location = new Point(6, 57);
            ckbReceiveHex.Name = "ckbReceiveHex";
            ckbReceiveHex.Size = new Size(95, 19);
            ckbReceiveHex.TabIndex = 15;
            ckbReceiveHex.Text = "Hexadecimal";
            ckbReceiveHex.UseVisualStyleBackColor = true;
            ckbReceiveHex.CheckedChanged += ckbReceiveHex_CheckedChanged;
            // 
            // btnManuallyEmpty
            // 
            btnManuallyEmpty.Location = new Point(125, 22);
            btnManuallyEmpty.Name = "btnManuallyEmpty";
            btnManuallyEmpty.Size = new Size(107, 23);
            btnManuallyEmpty.TabIndex = 6;
            btnManuallyEmpty.Text = "Manually empty";
            btnManuallyEmpty.UseVisualStyleBackColor = true;
            btnManuallyEmpty.Click += btnManuallyEmpty_Click;
            // 
            // ckbAutoEmpty
            // 
            ckbAutoEmpty.AutoSize = true;
            ckbAutoEmpty.Location = new Point(6, 22);
            ckbAutoEmpty.Name = "ckbAutoEmpty";
            ckbAutoEmpty.Size = new Size(89, 19);
            ckbAutoEmpty.TabIndex = 14;
            ckbAutoEmpty.Text = "Auto empty";
            ckbAutoEmpty.UseVisualStyleBackColor = true;
            ckbAutoEmpty.CheckedChanged += ckbAutoEmpty_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOpenPort);
            groupBox1.Controls.Add(ckbDTR);
            groupBox1.Controls.Add(ckbRTS);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbStopBit);
            groupBox1.Controls.Add(cmbDataBit);
            groupBox1.Controls.Add(cmbParityBit);
            groupBox1.Controls.Add(cmbBaudRate);
            groupBox1.Controls.Add(cmbPort);
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 261);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Serial port configuration";
            // 
            // btnOpenPort
            // 
            btnOpenPort.Location = new Point(114, 204);
            btnOpenPort.Name = "btnOpenPort";
            btnOpenPort.Size = new Size(121, 44);
            btnOpenPort.TabIndex = 13;
            btnOpenPort.Text = "Open the serial port";
            btnOpenPort.UseVisualStyleBackColor = true;
            btnOpenPort.Click += btnOpenPort_Click;
            // 
            // ckbDTR
            // 
            ckbDTR.AutoSize = true;
            ckbDTR.Location = new Point(6, 229);
            ckbDTR.Name = "ckbDTR";
            ckbDTR.Size = new Size(46, 19);
            ckbDTR.TabIndex = 12;
            ckbDTR.Text = "DTR";
            ckbDTR.UseVisualStyleBackColor = true;
            ckbDTR.CheckedChanged += ckbDTR_CheckedChanged;
            // 
            // ckbRTS
            // 
            ckbRTS.AutoSize = true;
            ckbRTS.Location = new Point(6, 204);
            ckbRTS.Name = "ckbRTS";
            ckbRTS.Size = new Size(44, 19);
            ckbRTS.TabIndex = 11;
            ckbRTS.Text = "RTS";
            ckbRTS.UseVisualStyleBackColor = true;
            ckbRTS.CheckedChanged += ckbRTS_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 178);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 10;
            label7.Text = "Stop bits";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 139);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 9;
            label6.Text = "Data bits";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 100);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 8;
            label5.Text = "parity bits";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 61);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 7;
            label4.Text = "baud rates";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 22);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 6;
            label3.Text = "Ports";
            // 
            // cmbStopBit
            // 
            cmbStopBit.FormattingEnabled = true;
            cmbStopBit.Location = new Point(114, 175);
            cmbStopBit.Name = "cmbStopBit";
            cmbStopBit.Size = new Size(121, 23);
            cmbStopBit.TabIndex = 5;
            // 
            // cmbDataBit
            // 
            cmbDataBit.FormattingEnabled = true;
            cmbDataBit.Location = new Point(114, 136);
            cmbDataBit.Name = "cmbDataBit";
            cmbDataBit.Size = new Size(121, 23);
            cmbDataBit.TabIndex = 4;
            // 
            // cmbParityBit
            // 
            cmbParityBit.FormattingEnabled = true;
            cmbParityBit.Location = new Point(114, 97);
            cmbParityBit.Name = "cmbParityBit";
            cmbParityBit.Size = new Size(121, 23);
            cmbParityBit.TabIndex = 3;
            // 
            // cmbBaudRate
            // 
            cmbBaudRate.FormattingEnabled = true;
            cmbBaudRate.Location = new Point(114, 58);
            cmbBaudRate.Name = "cmbBaudRate";
            cmbBaudRate.Size = new Size(121, 23);
            cmbBaudRate.TabIndex = 2;
            // 
            // cmbPort
            // 
            cmbPort.FormattingEnabled = true;
            cmbPort.Location = new Point(114, 22);
            cmbPort.Name = "cmbPort";
            cmbPort.Size = new Size(121, 23);
            cmbPort.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 311);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Send box";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 122);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 5;
            label2.Text = "Receive box";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(879, 667);
            tabControl1.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 667);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "SerialPortTool";
            Load += Form1_Load;
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TabPage tabPage1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel lblSendCount;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel lblReceiveCount;
        private ToolStripStatusLabel lblEmptyCount;
        private GroupBox groupBox5;
        private RichTextBox rtxtSendBox;
        private GroupBox groupBox4;
        private RichTextBox rtxtReceiveBox;
        private GroupBox groupBox3;
        private TextBox txtSendTimer;
        private Label label8;
        private TextBox txtSendPath;
        private Button btnOpenFile;
        private Button btnEmptySend;
        private CheckBox ckbAutoSend;
        private Button btnSendFile;
        private Button btnSendManually;
        private CheckBox ckbSendHex;
        private GroupBox groupBox2;
        private Button btnSelectPath;
        private TextBox txtReceivePath;
        private Button btnPause;
        private Button btnSaveData;
        private CheckBox ckbReceiveHex;
        private Button btnManuallyEmpty;
        private CheckBox ckbAutoEmpty;
        private GroupBox groupBox1;
        private Button btnOpenPort;
        private CheckBox ckbDTR;
        private CheckBox ckbRTS;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cmbStopBit;
        private ComboBox cmbDataBit;
        private ComboBox cmbParityBit;
        private ComboBox cmbBaudRate;
        private ComboBox cmbPort;
        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox6;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtData4;
        private TextBox txtData2;
        private TextBox txtData3;
        private TextBox txtData1;
        private CheckBox ckbDFR;
        private TextBox txtData;
        private Label label13;
        private Label label15;
        private Label label14;
        private Label label16;
        private System.Windows.Forms.Timer timer2;
        private FolderBrowserDialog folderBrowserDialog1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox7;
        private ComboBox cmbEncode;
        private Label label17;
    }
}
