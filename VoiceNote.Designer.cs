namespace WindowsFormsApp9
{
    partial class VoiceNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoiceNote));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Label15 = new System.Windows.Forms.Label();
            this.cbomp3freq = new System.Windows.Forms.ComboBox();
            this.cbomp3channel = new System.Windows.Forms.ComboBox();
            this.cbomp3bitrate = new System.Windows.Forms.ComboBox();
            this.optMP3 = new System.Windows.Forms.RadioButton();
            this.cbobitpersample = new System.Windows.Forms.ComboBox();
            this.cbofreq = new System.Windows.Forms.ComboBox();
            this.cboChannel = new System.Windows.Forms.ComboBox();
            this.optwave = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.TrackBar2 = new System.Windows.Forms.TrackBar();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboinputpin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboaudiodevice = new System.Windows.Forms.ComboBox();
            this.axAudioCapture1 = new AxAUDIOCAPTURELib.AxAudioCapture();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.UpDownRight = new System.Windows.Forms.NumericUpDown();
            this.TrackBar1 = new System.Windows.Forms.TrackBar();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.chkusepitch = new System.Windows.Forms.CheckBox();
            this.btnwaverightcolor = new System.Windows.Forms.Button();
            this.btnwaveleftcolor = new System.Windows.Forms.Button();
            this.btnwavebgcolor = new System.Windows.Forms.Button();
            this.chkrightdown = new System.Windows.Forms.CheckBox();
            this.chkleftdown = new System.Windows.Forms.CheckBox();
            this.UpDownLeft = new System.Windows.Forms.NumericUpDown();
            this.UpDownDivisor = new System.Windows.Forms.NumericUpDown();
            this.txtcaption = new System.Windows.Forms.TextBox();
            this.cboplaybackdevice = new System.Windows.Forms.ComboBox();
            this.txtwidth = new System.Windows.Forms.TextBox();
            this.txttop = new System.Windows.Forms.TextBox();
            this.txtleft = new System.Windows.Forms.TextBox();
            this.chkshowwaveform = new System.Windows.Forms.CheckBox();
            this.chkcapturespeaker = new System.Windows.Forms.CheckBox();
            this.chkshowpopup = new System.Windows.Forms.CheckBox();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAudioCapture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDivisor)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.bunifuiOSSwitch1);
            this.panel2.Location = new System.Drawing.Point(-33, -7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 91);
            this.panel2.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(220, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 36);
            this.button5.TabIndex = 32;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, -28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(204, 160);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(214, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 36);
            this.label5.TabIndex = 18;
            this.label5.Text = "VoiceNOTE";
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(737, 13);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(35, 20);
            this.bunifuiOSSwitch1.TabIndex = 7;
            this.bunifuiOSSwitch1.Value = true;
            this.bunifuiOSSwitch1.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch1_OnValueChange);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-7, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 440);
            this.panel1.TabIndex = 19;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(82, 141);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 71);
            this.button7.TabIndex = 14;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(22, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Stop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Record";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(82, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 71);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Label15.Location = new System.Drawing.Point(371, 356);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(56, 26);
            this.Label15.TabIndex = 37;
            this.Label15.Text = "bps";
            // 
            // cbomp3freq
            // 
            this.cbomp3freq.BackColor = System.Drawing.SystemColors.Window;
            this.cbomp3freq.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbomp3freq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomp3freq.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomp3freq.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbomp3freq.Location = new System.Drawing.Point(461, 321);
            this.cbomp3freq.Name = "cbomp3freq";
            this.cbomp3freq.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbomp3freq.Size = new System.Drawing.Size(89, 22);
            this.cbomp3freq.TabIndex = 34;
            // 
            // cbomp3channel
            // 
            this.cbomp3channel.BackColor = System.Drawing.SystemColors.Window;
            this.cbomp3channel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbomp3channel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomp3channel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomp3channel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbomp3channel.Location = new System.Drawing.Point(285, 321);
            this.cbomp3channel.Name = "cbomp3channel";
            this.cbomp3channel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbomp3channel.Size = new System.Drawing.Size(81, 22);
            this.cbomp3channel.TabIndex = 32;
            // 
            // cbomp3bitrate
            // 
            this.cbomp3bitrate.BackColor = System.Drawing.SystemColors.Window;
            this.cbomp3bitrate.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbomp3bitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomp3bitrate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomp3bitrate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbomp3bitrate.Location = new System.Drawing.Point(285, 356);
            this.cbomp3bitrate.Name = "cbomp3bitrate";
            this.cbomp3bitrate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbomp3bitrate.Size = new System.Drawing.Size(80, 22);
            this.cbomp3bitrate.TabIndex = 23;
            // 
            // optMP3
            // 
            this.optMP3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.optMP3.Cursor = System.Windows.Forms.Cursors.Default;
            this.optMP3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMP3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optMP3.Location = new System.Drawing.Point(197, 295);
            this.optMP3.Name = "optMP3";
            this.optMP3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optMP3.Size = new System.Drawing.Size(64, 18);
            this.optMP3.TabIndex = 18;
            this.optMP3.TabStop = true;
            this.optMP3.Text = "MP3";
            this.optMP3.UseVisualStyleBackColor = false;
            // 
            // cbobitpersample
            // 
            this.cbobitpersample.BackColor = System.Drawing.SystemColors.Window;
            this.cbobitpersample.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbobitpersample.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobitpersample.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobitpersample.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbobitpersample.Location = new System.Drawing.Point(340, 231);
            this.cbobitpersample.Name = "cbobitpersample";
            this.cbobitpersample.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbobitpersample.Size = new System.Drawing.Size(81, 22);
            this.cbobitpersample.TabIndex = 26;
            // 
            // cbofreq
            // 
            this.cbofreq.BackColor = System.Drawing.SystemColors.Window;
            this.cbofreq.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbofreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbofreq.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbofreq.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbofreq.Location = new System.Drawing.Point(341, 269);
            this.cbofreq.Name = "cbofreq";
            this.cbofreq.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbofreq.Size = new System.Drawing.Size(121, 22);
            this.cbofreq.TabIndex = 13;
            // 
            // cboChannel
            // 
            this.cboChannel.BackColor = System.Drawing.SystemColors.Window;
            this.cboChannel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChannel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChannel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboChannel.Location = new System.Drawing.Point(341, 199);
            this.cboChannel.Name = "cboChannel";
            this.cboChannel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboChannel.Size = new System.Drawing.Size(81, 22);
            this.cboChannel.TabIndex = 9;
            // 
            // optwave
            // 
            this.optwave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.optwave.Checked = true;
            this.optwave.Cursor = System.Windows.Forms.Cursors.Default;
            this.optwave.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optwave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optwave.Location = new System.Drawing.Point(197, 199);
            this.optwave.Name = "optwave";
            this.optwave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optwave.Size = new System.Drawing.Size(64, 18);
            this.optwave.TabIndex = 7;
            this.optwave.TabStop = true;
            this.optwave.Text = "Wave";
            this.optwave.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(389, 321);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(64, 18);
            this.label11.TabIndex = 36;
            this.label11.Text = "Sample Per";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(557, 321);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(64, 18);
            this.label12.TabIndex = 35;
            this.label12.Text = "khz";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Cursor = System.Windows.Forms.Cursors.Default;
            this.label16.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(205, 321);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(64, 18);
            this.label16.TabIndex = 33;
            this.label16.Text = "Channel";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.label17.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(189, 356);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label17.Size = new System.Drawing.Size(64, 18);
            this.label17.TabIndex = 22;
            this.label17.Text = "Audio Bitrate";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(469, 269);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label18.Size = new System.Drawing.Size(25, 18);
            this.label18.TabIndex = 19;
            this.label18.Text = "khz";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Cursor = System.Windows.Forms.Cursors.Default;
            this.label20.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(261, 269);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(64, 18);
            this.label20.TabIndex = 12;
            this.label20.Text = "Sample Per";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.label21.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(261, 234);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label21.Size = new System.Drawing.Size(64, 18);
            this.label21.TabIndex = 10;
            this.label21.Text = "Bit Per Sample";
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label23.Cursor = System.Windows.Forms.Cursors.Default;
            this.label23.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(261, 199);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label23.Size = new System.Drawing.Size(64, 18);
            this.label23.TabIndex = 8;
            this.label23.Text = "Channel";
            // 
            // TrackBar2
            // 
            this.TrackBar2.Location = new System.Drawing.Point(234, 406);
            this.TrackBar2.Name = "TrackBar2";
            this.TrackBar2.Size = new System.Drawing.Size(216, 45);
            this.TrackBar2.TabIndex = 41;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label14.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label14.Location = new System.Drawing.Point(194, 406);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label14.Size = new System.Drawing.Size(64, 18);
            this.Label14.TabIndex = 40;
            this.Label14.Text = "Min";
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label13.Location = new System.Drawing.Point(458, 406);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label13.Size = new System.Drawing.Size(64, 18);
            this.Label13.TabIndex = 39;
            this.Label13.Text = "Max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(194, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Input Pin:";
            // 
            // cboinputpin
            // 
            this.cboinputpin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboinputpin.FormattingEnabled = true;
            this.cboinputpin.Location = new System.Drawing.Point(197, 170);
            this.cboinputpin.Name = "cboinputpin";
            this.cboinputpin.Size = new System.Drawing.Size(147, 21);
            this.cboinputpin.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(194, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Input Device:";
            // 
            // cboaudiodevice
            // 
            this.cboaudiodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaudiodevice.FormattingEnabled = true;
            this.cboaudiodevice.Location = new System.Drawing.Point(197, 121);
            this.cboaudiodevice.Name = "cboaudiodevice";
            this.cboaudiodevice.Size = new System.Drawing.Size(147, 21);
            this.cboaudiodevice.TabIndex = 47;
            // 
            // axAudioCapture1
            // 
            this.axAudioCapture1.Enabled = true;
            this.axAudioCapture1.Location = new System.Drawing.Point(450, 97);
            this.axAudioCapture1.Name = "axAudioCapture1";
            this.axAudioCapture1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAudioCapture1.OcxState")));
            this.axAudioCapture1.Size = new System.Drawing.Size(226, 94);
            this.axAudioCapture1.TabIndex = 51;
            // 
            // UpDownRight
            // 
            this.UpDownRight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDownRight.Location = new System.Drawing.Point(1283, 515);
            this.UpDownRight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.UpDownRight.Name = "UpDownRight";
            this.UpDownRight.Size = new System.Drawing.Size(75, 20);
            this.UpDownRight.TabIndex = 72;
            this.UpDownRight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // TrackBar1
            // 
            this.TrackBar1.Location = new System.Drawing.Point(1198, 592);
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Size = new System.Drawing.Size(232, 45);
            this.TrackBar1.TabIndex = 71;
            // 
            // txtfilename
            // 
            this.txtfilename.AcceptsReturn = true;
            this.txtfilename.BackColor = System.Drawing.SystemColors.Window;
            this.txtfilename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfilename.Enabled = false;
            this.txtfilename.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfilename.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtfilename.Location = new System.Drawing.Point(1275, 460);
            this.txtfilename.MaxLength = 0;
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtfilename.Size = new System.Drawing.Size(361, 20);
            this.txtfilename.TabIndex = 70;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.Control;
            this.label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(1203, 460);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label22.Size = new System.Drawing.Size(57, 18);
            this.label22.TabIndex = 69;
            this.label22.Text = "Save to";
            // 
            // chkusepitch
            // 
            this.chkusepitch.BackColor = System.Drawing.SystemColors.Control;
            this.chkusepitch.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkusepitch.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkusepitch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkusepitch.Location = new System.Drawing.Point(1198, 441);
            this.chkusepitch.Name = "chkusepitch";
            this.chkusepitch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkusepitch.Size = new System.Drawing.Size(73, 18);
            this.chkusepitch.TabIndex = 68;
            this.chkusepitch.Text = "Use Pitch";
            this.chkusepitch.UseVisualStyleBackColor = false;
            // 
            // btnwaverightcolor
            // 
            this.btnwaverightcolor.Location = new System.Drawing.Point(1467, 557);
            this.btnwaverightcolor.Name = "btnwaverightcolor";
            this.btnwaverightcolor.Size = new System.Drawing.Size(125, 29);
            this.btnwaverightcolor.TabIndex = 67;
            this.btnwaverightcolor.Text = "Right Channel Color";
            this.btnwaverightcolor.UseVisualStyleBackColor = true;
            // 
            // btnwaveleftcolor
            // 
            this.btnwaveleftcolor.Location = new System.Drawing.Point(1333, 557);
            this.btnwaveleftcolor.Name = "btnwaveleftcolor";
            this.btnwaveleftcolor.Size = new System.Drawing.Size(125, 29);
            this.btnwaveleftcolor.TabIndex = 66;
            this.btnwaveleftcolor.Text = "Left Channel Color";
            this.btnwaveleftcolor.UseVisualStyleBackColor = true;
            // 
            // btnwavebgcolor
            // 
            this.btnwavebgcolor.Location = new System.Drawing.Point(1198, 557);
            this.btnwavebgcolor.Name = "btnwavebgcolor";
            this.btnwavebgcolor.Size = new System.Drawing.Size(125, 29);
            this.btnwavebgcolor.TabIndex = 65;
            this.btnwavebgcolor.Text = "Wave Form Bg Color";
            this.btnwavebgcolor.UseVisualStyleBackColor = true;
            // 
            // chkrightdown
            // 
            this.chkrightdown.AutoSize = true;
            this.chkrightdown.Checked = true;
            this.chkrightdown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkrightdown.Location = new System.Drawing.Point(1424, 515);
            this.chkrightdown.Name = "chkrightdown";
            this.chkrightdown.Size = new System.Drawing.Size(99, 17);
            this.chkrightdown.TabIndex = 64;
            this.chkrightdown.Text = "Down Direction";
            this.chkrightdown.UseVisualStyleBackColor = true;
            // 
            // chkleftdown
            // 
            this.chkleftdown.AutoSize = true;
            this.chkleftdown.Location = new System.Drawing.Point(1424, 482);
            this.chkleftdown.Name = "chkleftdown";
            this.chkleftdown.Size = new System.Drawing.Size(99, 17);
            this.chkleftdown.TabIndex = 63;
            this.chkleftdown.Text = "Down Direction";
            this.chkleftdown.UseVisualStyleBackColor = true;
            // 
            // UpDownLeft
            // 
            this.UpDownLeft.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDownLeft.Location = new System.Drawing.Point(1198, 515);
            this.UpDownLeft.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.UpDownLeft.Name = "UpDownLeft";
            this.UpDownLeft.Size = new System.Drawing.Size(75, 20);
            this.UpDownLeft.TabIndex = 62;
            this.UpDownLeft.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // UpDownDivisor
            // 
            this.UpDownDivisor.Location = new System.Drawing.Point(1198, 479);
            this.UpDownDivisor.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.UpDownDivisor.Name = "UpDownDivisor";
            this.UpDownDivisor.Size = new System.Drawing.Size(75, 20);
            this.UpDownDivisor.TabIndex = 61;
            this.UpDownDivisor.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // txtcaption
            // 
            this.txtcaption.Location = new System.Drawing.Point(1198, 415);
            this.txtcaption.Name = "txtcaption";
            this.txtcaption.Size = new System.Drawing.Size(103, 20);
            this.txtcaption.TabIndex = 60;
            // 
            // cboplaybackdevice
            // 
            this.cboplaybackdevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboplaybackdevice.Enabled = false;
            this.cboplaybackdevice.FormattingEnabled = true;
            this.cboplaybackdevice.Location = new System.Drawing.Point(1333, 365);
            this.cboplaybackdevice.Name = "cboplaybackdevice";
            this.cboplaybackdevice.Size = new System.Drawing.Size(259, 21);
            this.cboplaybackdevice.TabIndex = 54;
            // 
            // txtwidth
            // 
            this.txtwidth.Location = new System.Drawing.Point(1307, 328);
            this.txtwidth.Name = "txtwidth";
            this.txtwidth.Size = new System.Drawing.Size(51, 20);
            this.txtwidth.TabIndex = 57;
            this.txtwidth.Text = "291";
            // 
            // txttop
            // 
            this.txttop.Location = new System.Drawing.Point(1250, 328);
            this.txttop.Name = "txttop";
            this.txttop.Size = new System.Drawing.Size(51, 20);
            this.txttop.TabIndex = 56;
            this.txttop.Text = "6";
            // 
            // txtleft
            // 
            this.txtleft.Location = new System.Drawing.Point(1195, 328);
            this.txtleft.Name = "txtleft";
            this.txtleft.Size = new System.Drawing.Size(51, 20);
            this.txtleft.TabIndex = 55;
            this.txtleft.Text = "177";
            // 
            // chkshowwaveform
            // 
            this.chkshowwaveform.AutoSize = true;
            this.chkshowwaveform.Checked = true;
            this.chkshowwaveform.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkshowwaveform.Location = new System.Drawing.Point(1208, 279);
            this.chkshowwaveform.Name = "chkshowwaveform";
            this.chkshowwaveform.Size = new System.Drawing.Size(111, 17);
            this.chkshowwaveform.TabIndex = 52;
            this.chkshowwaveform.Text = "Show Wave Form";
            this.chkshowwaveform.UseVisualStyleBackColor = true;
            // 
            // chkcapturespeaker
            // 
            this.chkcapturespeaker.AutoSize = true;
            this.chkcapturespeaker.Location = new System.Drawing.Point(1208, 302);
            this.chkcapturespeaker.Name = "chkcapturespeaker";
            this.chkcapturespeaker.Size = new System.Drawing.Size(404, 17);
            this.chkcapturespeaker.TabIndex = 53;
            this.chkcapturespeaker.Text = "Capture from Playback Device (Windows 10, Windows 8, Vista Windows 7 only)";
            this.chkcapturespeaker.UseVisualStyleBackColor = true;
            // 
            // chkshowpopup
            // 
            this.chkshowpopup.AutoSize = true;
            this.chkshowpopup.Location = new System.Drawing.Point(1195, 392);
            this.chkshowpopup.Name = "chkshowpopup";
            this.chkshowpopup.Size = new System.Drawing.Size(87, 17);
            this.chkshowpopup.TabIndex = 59;
            this.chkshowpopup.Text = "Show Popup";
            this.chkshowpopup.UseVisualStyleBackColor = true;
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(1364, 328);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(51, 20);
            this.txtheight.TabIndex = 58;
            this.txtheight.Text = "140";
            // 
            // VoiceNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(751, 456);
            this.Controls.Add(this.UpDownRight);
            this.Controls.Add(this.TrackBar1);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.chkusepitch);
            this.Controls.Add(this.btnwaverightcolor);
            this.Controls.Add(this.btnwaveleftcolor);
            this.Controls.Add(this.btnwavebgcolor);
            this.Controls.Add(this.chkrightdown);
            this.Controls.Add(this.chkleftdown);
            this.Controls.Add(this.UpDownLeft);
            this.Controls.Add(this.UpDownDivisor);
            this.Controls.Add(this.txtcaption);
            this.Controls.Add(this.cboplaybackdevice);
            this.Controls.Add(this.txtwidth);
            this.Controls.Add(this.txttop);
            this.Controls.Add(this.txtleft);
            this.Controls.Add(this.chkshowwaveform);
            this.Controls.Add(this.chkcapturespeaker);
            this.Controls.Add(this.chkshowpopup);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.axAudioCapture1);
            this.Controls.Add(this.TrackBar2);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.cbomp3freq);
            this.Controls.Add(this.cbomp3channel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbomp3bitrate);
            this.Controls.Add(this.cboinputpin);
            this.Controls.Add(this.optMP3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbobitpersample);
            this.Controls.Add(this.cboaudiodevice);
            this.Controls.Add(this.cbofreq);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboChannel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.optwave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VoiceNote";
            this.Text = "VoiceNote";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VoiceNote_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAudioCapture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDivisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Label Label15;
        public System.Windows.Forms.ComboBox cbomp3freq;
        public System.Windows.Forms.ComboBox cbomp3channel;
        public System.Windows.Forms.ComboBox cbomp3bitrate;
        public System.Windows.Forms.RadioButton optMP3;
        public System.Windows.Forms.ComboBox cbobitpersample;
        public System.Windows.Forms.ComboBox cbofreq;
        public System.Windows.Forms.ComboBox cboChannel;
        public System.Windows.Forms.RadioButton optwave;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label label23;
        internal System.Windows.Forms.TrackBar TrackBar2;
        public System.Windows.Forms.Label Label14;
        public System.Windows.Forms.Label Label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboinputpin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboaudiodevice;
        private AxAUDIOCAPTURELib.AxAudioCapture axAudioCapture1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown UpDownRight;
        internal System.Windows.Forms.TrackBar TrackBar1;
        public System.Windows.Forms.TextBox txtfilename;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.CheckBox chkusepitch;
        private System.Windows.Forms.Button btnwaverightcolor;
        private System.Windows.Forms.Button btnwaveleftcolor;
        private System.Windows.Forms.Button btnwavebgcolor;
        private System.Windows.Forms.CheckBox chkrightdown;
        private System.Windows.Forms.CheckBox chkleftdown;
        private System.Windows.Forms.NumericUpDown UpDownLeft;
        private System.Windows.Forms.NumericUpDown UpDownDivisor;
        private System.Windows.Forms.TextBox txtcaption;
        private System.Windows.Forms.ComboBox cboplaybackdevice;
        private System.Windows.Forms.TextBox txtwidth;
        private System.Windows.Forms.TextBox txttop;
        private System.Windows.Forms.TextBox txtleft;
        private System.Windows.Forms.CheckBox chkshowwaveform;
        private System.Windows.Forms.CheckBox chkcapturespeaker;
        private System.Windows.Forms.CheckBox chkshowpopup;
        private System.Windows.Forms.TextBox txtheight;
    }
}