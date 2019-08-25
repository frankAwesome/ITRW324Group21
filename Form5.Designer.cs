namespace SkypeDemo
{
    partial class frmVideoChat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVideoChat));
            this.pnlBig = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnLogo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnSetttings = new System.Windows.Forms.Button();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtListenPortno = new System.Windows.Forms.TextBox();
            this.txtListenIP = new System.Windows.Forms.TextBox();
            this.buttonDisconnectListen = new System.Windows.Forms.Button();
            this.buttonStartListen = new System.Windows.Forms.Button();
            this.axVideoChatReceiver = new AxVideoChatReceiverLib.AxVideoChatReceiver();
            this.checkBoxSendVideo = new System.Windows.Forms.CheckBox();
            this.checkBoxSendAudio = new System.Windows.Forms.CheckBox();
            this.txtVideoBitrate = new System.Windows.Forms.TextBox();
            this.txtFrameRate = new System.Windows.Forms.TextBox();
            this.comboBoxAudioQuality = new System.Windows.Forms.ComboBox();
            this.comboBoxAudioComplex = new System.Windows.Forms.ComboBox();
            this.comboBoxVideoFormat = new System.Windows.Forms.ComboBox();
            this.comboBoxAudioDevice = new System.Windows.Forms.ComboBox();
            this.comboBoxVideoDevice = new System.Windows.Forms.ComboBox();
            this.axVideoChatSender = new AxVideoChatSenderLib.AxVideoChatSender();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelSlide = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPortno = new System.Windows.Forms.TextBox();
            this.txtStreamToIP = new System.Windows.Forms.TextBox();
            this.pnlBig.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatSender)).BeginInit();
            this.PanelSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBig
            // 
            this.pnlBig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlBig.Controls.Add(this.lblHeading);
            this.pnlBig.Controls.Add(this.btnLogo);
            this.pnlBig.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBig.Location = new System.Drawing.Point(0, 0);
            this.pnlBig.Name = "pnlBig";
            this.pnlBig.Size = new System.Drawing.Size(764, 34);
            this.pnlBig.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(39, 8);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(168, 20);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "The Office Messenger";
            // 
            // btnLogo
            // 
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.Location = new System.Drawing.Point(0, 0);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(33, 31);
            this.btnLogo.TabIndex = 1;
            this.btnLogo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnManual);
            this.panel2.Controls.Add(this.btnSetttings);
            this.panel2.Controls.Add(this.btnShowHide);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 475);
            this.panel2.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(0, 190);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 36);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(0, 155);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 36);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(0, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 36);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(0, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 36);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(0, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 36);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnManual
            // 
            this.btnManual.FlatAppearance.BorderSize = 0;
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManual.Image = ((System.Drawing.Image)(resources.GetObject("btnManual.Image")));
            this.btnManual.Location = new System.Drawing.Point(0, 390);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(37, 36);
            this.btnManual.TabIndex = 1;
            this.btnManual.UseVisualStyleBackColor = true;
            // 
            // btnSetttings
            // 
            this.btnSetttings.FlatAppearance.BorderSize = 0;
            this.btnSetttings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetttings.Image = ((System.Drawing.Image)(resources.GetObject("btnSetttings.Image")));
            this.btnSetttings.Location = new System.Drawing.Point(0, 436);
            this.btnSetttings.Name = "btnSetttings";
            this.btnSetttings.Size = new System.Drawing.Size(37, 36);
            this.btnSetttings.TabIndex = 1;
            this.btnSetttings.UseVisualStyleBackColor = true;
            // 
            // btnShowHide
            // 
            this.btnShowHide.FlatAppearance.BorderSize = 0;
            this.btnShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHide.Image = ((System.Drawing.Image)(resources.GetObject("btnShowHide.Image")));
            this.btnShowHide.Location = new System.Drawing.Point(0, 0);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(37, 36);
            this.btnShowHide.TabIndex = 1;
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtListenPortno);
            this.pnlMain.Controls.Add(this.txtListenIP);
            this.pnlMain.Controls.Add(this.buttonDisconnectListen);
            this.pnlMain.Controls.Add(this.buttonStartListen);
            this.pnlMain.Controls.Add(this.axVideoChatReceiver);
            this.pnlMain.Controls.Add(this.checkBoxSendVideo);
            this.pnlMain.Controls.Add(this.checkBoxSendAudio);
            this.pnlMain.Controls.Add(this.txtVideoBitrate);
            this.pnlMain.Controls.Add(this.txtFrameRate);
            this.pnlMain.Controls.Add(this.comboBoxAudioQuality);
            this.pnlMain.Controls.Add(this.comboBoxAudioComplex);
            this.pnlMain.Controls.Add(this.comboBoxVideoFormat);
            this.pnlMain.Controls.Add(this.comboBoxAudioDevice);
            this.pnlMain.Controls.Add(this.comboBoxVideoDevice);
            this.pnlMain.Controls.Add(this.axVideoChatSender);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(282, 34);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(482, 475);
            this.pnlMain.TabIndex = 3;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your IP here:";
            // 
            // txtListenPortno
            // 
            this.txtListenPortno.Location = new System.Drawing.Point(164, 357);
            this.txtListenPortno.Name = "txtListenPortno";
            this.txtListenPortno.Size = new System.Drawing.Size(136, 27);
            this.txtListenPortno.TabIndex = 14;
            this.txtListenPortno.Text = "100";
            // 
            // txtListenIP
            // 
            this.txtListenIP.Location = new System.Drawing.Point(164, 310);
            this.txtListenIP.Name = "txtListenIP";
            this.txtListenIP.Size = new System.Drawing.Size(136, 27);
            this.txtListenIP.TabIndex = 13;
            this.txtListenIP.Text = "192.168.8.102";
            // 
            // buttonDisconnectListen
            // 
            this.buttonDisconnectListen.ForeColor = System.Drawing.Color.Black;
            this.buttonDisconnectListen.Location = new System.Drawing.Point(288, 390);
            this.buttonDisconnectListen.Name = "buttonDisconnectListen";
            this.buttonDisconnectListen.Size = new System.Drawing.Size(108, 38);
            this.buttonDisconnectListen.TabIndex = 12;
            this.buttonDisconnectListen.Text = "Disconnect";
            this.buttonDisconnectListen.UseVisualStyleBackColor = true;
            this.buttonDisconnectListen.Click += new System.EventHandler(this.buttonDisconnectListen_Click);
            // 
            // buttonStartListen
            // 
            this.buttonStartListen.ForeColor = System.Drawing.Color.Black;
            this.buttonStartListen.Location = new System.Drawing.Point(164, 390);
            this.buttonStartListen.Name = "buttonStartListen";
            this.buttonStartListen.Size = new System.Drawing.Size(108, 38);
            this.buttonStartListen.TabIndex = 11;
            this.buttonStartListen.Text = "Start Listening";
            this.buttonStartListen.UseVisualStyleBackColor = true;
            this.buttonStartListen.Click += new System.EventHandler(this.buttonStartListen_Click);
            // 
            // axVideoChatReceiver
            // 
            this.axVideoChatReceiver.Enabled = true;
            this.axVideoChatReceiver.Location = new System.Drawing.Point(142, 6);
            this.axVideoChatReceiver.Name = "axVideoChatReceiver";
            this.axVideoChatReceiver.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatReceiver.OcxState")));
            this.axVideoChatReceiver.Size = new System.Drawing.Size(328, 279);
            this.axVideoChatReceiver.TabIndex = 10;
            // 
            // checkBoxSendVideo
            // 
            this.checkBoxSendVideo.AutoSize = true;
            this.checkBoxSendVideo.Checked = true;
            this.checkBoxSendVideo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSendVideo.Location = new System.Drawing.Point(6, 398);
            this.checkBoxSendVideo.Name = "checkBoxSendVideo";
            this.checkBoxSendVideo.Size = new System.Drawing.Size(117, 25);
            this.checkBoxSendVideo.TabIndex = 9;
            this.checkBoxSendVideo.Text = "Send Video";
            this.checkBoxSendVideo.UseVisualStyleBackColor = true;
            // 
            // checkBoxSendAudio
            // 
            this.checkBoxSendAudio.AutoSize = true;
            this.checkBoxSendAudio.Checked = true;
            this.checkBoxSendAudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSendAudio.Location = new System.Drawing.Point(6, 367);
            this.checkBoxSendAudio.Name = "checkBoxSendAudio";
            this.checkBoxSendAudio.Size = new System.Drawing.Size(119, 25);
            this.checkBoxSendAudio.TabIndex = 8;
            this.checkBoxSendAudio.Text = "Send Audio";
            this.checkBoxSendAudio.UseVisualStyleBackColor = true;
            // 
            // txtVideoBitrate
            // 
            this.txtVideoBitrate.Location = new System.Drawing.Point(6, 334);
            this.txtVideoBitrate.Name = "txtVideoBitrate";
            this.txtVideoBitrate.Size = new System.Drawing.Size(117, 27);
            this.txtVideoBitrate.TabIndex = 7;
            this.txtVideoBitrate.Text = "128000";
            // 
            // txtFrameRate
            // 
            this.txtFrameRate.Location = new System.Drawing.Point(6, 301);
            this.txtFrameRate.Name = "txtFrameRate";
            this.txtFrameRate.Size = new System.Drawing.Size(117, 27);
            this.txtFrameRate.TabIndex = 6;
            this.txtFrameRate.Text = "25";
            // 
            // comboBoxAudioQuality
            // 
            this.comboBoxAudioQuality.FormattingEnabled = true;
            this.comboBoxAudioQuality.Location = new System.Drawing.Point(6, 266);
            this.comboBoxAudioQuality.Name = "comboBoxAudioQuality";
            this.comboBoxAudioQuality.Size = new System.Drawing.Size(117, 29);
            this.comboBoxAudioQuality.TabIndex = 5;
            // 
            // comboBoxAudioComplex
            // 
            this.comboBoxAudioComplex.FormattingEnabled = true;
            this.comboBoxAudioComplex.Location = new System.Drawing.Point(6, 231);
            this.comboBoxAudioComplex.Name = "comboBoxAudioComplex";
            this.comboBoxAudioComplex.Size = new System.Drawing.Size(117, 29);
            this.comboBoxAudioComplex.TabIndex = 4;
            // 
            // comboBoxVideoFormat
            // 
            this.comboBoxVideoFormat.FormattingEnabled = true;
            this.comboBoxVideoFormat.Location = new System.Drawing.Point(6, 196);
            this.comboBoxVideoFormat.Name = "comboBoxVideoFormat";
            this.comboBoxVideoFormat.Size = new System.Drawing.Size(117, 29);
            this.comboBoxVideoFormat.TabIndex = 3;
            // 
            // comboBoxAudioDevice
            // 
            this.comboBoxAudioDevice.FormattingEnabled = true;
            this.comboBoxAudioDevice.Location = new System.Drawing.Point(6, 161);
            this.comboBoxAudioDevice.Name = "comboBoxAudioDevice";
            this.comboBoxAudioDevice.Size = new System.Drawing.Size(117, 29);
            this.comboBoxAudioDevice.TabIndex = 2;
            // 
            // comboBoxVideoDevice
            // 
            this.comboBoxVideoDevice.FormattingEnabled = true;
            this.comboBoxVideoDevice.Location = new System.Drawing.Point(6, 126);
            this.comboBoxVideoDevice.Name = "comboBoxVideoDevice";
            this.comboBoxVideoDevice.Size = new System.Drawing.Size(117, 29);
            this.comboBoxVideoDevice.TabIndex = 1;
            // 
            // axVideoChatSender
            // 
            this.axVideoChatSender.Enabled = true;
            this.axVideoChatSender.Location = new System.Drawing.Point(6, 6);
            this.axVideoChatSender.Name = "axVideoChatSender";
            this.axVideoChatSender.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatSender.OcxState")));
            this.axVideoChatSender.Size = new System.Drawing.Size(117, 114);
            this.axVideoChatSender.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PanelSlide
            // 
            this.PanelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PanelSlide.Controls.Add(this.pictureBox1);
            this.PanelSlide.Controls.Add(this.label5);
            this.PanelSlide.Controls.Add(this.label4);
            this.PanelSlide.Controls.Add(this.label3);
            this.PanelSlide.Controls.Add(this.button1);
            this.PanelSlide.Controls.Add(this.btnConnect);
            this.PanelSlide.Controls.Add(this.txtPortno);
            this.PanelSlide.Controls.Add(this.txtStreamToIP);
            this.PanelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSlide.Location = new System.Drawing.Point(43, 34);
            this.PanelSlide.Name = "PanelSlide";
            this.PanelSlide.Size = new System.Drawing.Size(239, 475);
            this.PanelSlide.TabIndex = 2;
            this.PanelSlide.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSlide_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 36);
            this.label5.TabIndex = 18;
            this.label5.Text = "Video Chat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Who\'s the chat with IP:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(25, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Disconnect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(25, 228);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(119, 30);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPortno
            // 
            this.txtPortno.Location = new System.Drawing.Point(25, 167);
            this.txtPortno.Name = "txtPortno";
            this.txtPortno.Size = new System.Drawing.Size(119, 27);
            this.txtPortno.TabIndex = 4;
            this.txtPortno.Text = "100";
            // 
            // txtStreamToIP
            // 
            this.txtStreamToIP.Location = new System.Drawing.Point(25, 111);
            this.txtStreamToIP.Name = "txtStreamToIP";
            this.txtStreamToIP.Size = new System.Drawing.Size(119, 27);
            this.txtStreamToIP.TabIndex = 4;
            this.txtStreamToIP.Text = "192.168.8.101";
            // 
            // frmVideoChat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(764, 509);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.PanelSlide);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBig);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVideoChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBig.ResumeLayout(false);
            this.pnlBig.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatSender)).EndInit();
            this.PanelSlide.ResumeLayout(false);
            this.PanelSlide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBig;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnSetttings;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel PanelSlide;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.TextBox txtPortno;
        private System.Windows.Forms.TextBox txtStreamToIP;
        private System.Windows.Forms.Button btnConnect;
        private AxVideoChatSenderLib.AxVideoChatSender axVideoChatSender;
        private System.Windows.Forms.ComboBox comboBoxVideoDevice;
        private System.Windows.Forms.ComboBox comboBoxAudioDevice;
        private System.Windows.Forms.ComboBox comboBoxVideoFormat;
        private System.Windows.Forms.ComboBox comboBoxAudioQuality;
        private System.Windows.Forms.ComboBox comboBoxAudioComplex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtVideoBitrate;
        private System.Windows.Forms.TextBox txtFrameRate;
        private System.Windows.Forms.CheckBox checkBoxSendAudio;
        private System.Windows.Forms.CheckBox checkBoxSendVideo;
        private AxVideoChatReceiverLib.AxVideoChatReceiver axVideoChatReceiver;
        private System.Windows.Forms.Button buttonDisconnectListen;
        private System.Windows.Forms.Button buttonStartListen;
        private System.Windows.Forms.TextBox txtListenPortno;
        private System.Windows.Forms.TextBox txtListenIP;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

