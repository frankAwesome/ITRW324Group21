using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

using ChatApplication;


using file_transfer;
using System.IO;

namespace SkypeDemo
{
    public partial class Form2 : Form
    {
        int panelWidth;
        bool Hidden;
        bool bFormLoaded = false;

        private Listener listener;
        private TransferClient transferClient;
        private string outputFolder;
        private Timer tmrOverallProg;

        private bool serverRunning;

        public Form2()
        {
            InitializeComponent();
            panelWidth = PanelSlide.Width;
            Hidden = false;

            listener = new Listener();
            listener.Accepted += listener_Accepted;

            tmrOverallProg = new Timer();
            tmrOverallProg.Interval = 1000;
            tmrOverallProg.Tick += tmrOverallProg_Tick;

            outputFolder = "Transfers";
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }

            btnConnect.Click += new EventHandler(btnConnect_Click);
            btnStartServer.Click += new EventHandler(btnStartServer_Click);
            btnStopServer.Click += new EventHandler(btnStopServer_Click);
            btnSendFile.Click += new EventHandler(btnSendFile_Click);
            btnPauseTransfer.Click += new EventHandler(btnPauseTransfer_Click);
            btnStopTransfer.Click += new EventHandler(btnStopTransfer_Click);
            btnOpenDir.Click += new EventHandler(btnOpenDir_Click);
            btnClearComplete.Click += new EventHandler(btnClearComplete_Click);

            btnStopServer.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client frm5 = new Client();
            if (bFormLoaded == false)
            {
                frm5.Show();
                bFormLoaded = true;
            }
                frm5.BringToFront();

            this.Hide();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                PanelSlide.Width = PanelSlide.Width + 10;


                if (PanelSlide.Width >= panelWidth)
                {
                    timer3.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                PanelSlide.Width = PanelSlide.Width - 10;


                if (PanelSlide.Width <= 0)
                {
                    timer3.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }



        

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pnlBig_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmVideoChat frm5 = new frmVideoChat();
            if (bFormLoaded == false)
            {
                frm5.Show();
                bFormLoaded = true;
            }

                frm5.BringToFront();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frm5 = new Form3();
            if (bFormLoaded == false)
            {
                frm5.Show();
                bFormLoaded = true;
            }


            frm5.BringToFront();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 frm5 = new Form4();
            if (bFormLoaded == false)
            {
                frm5.Show();
                bFormLoaded = true;
            }


            frm5.BringToFront();

            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            deregiserEvents();
            base.OnFormClosing(e);
        }

         private void tmrOverallProg_Tick(object sender, EventArgs e)
    {

        if (transferClient == null)
            return;

        progressOverall.Value = transferClient.GetOverallProgress();

    }

    private void listener_Accepted(object sender, SocketAcceptedEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new SocketAcceptedHandler(listener_Accepted), sender, e);
            return;
        }
        listener.Stop();
        transferClient = new TransferClient(e.Accepted);
        transferClient.OutputFolder = outputFolder;
        registerEvents();
        transferClient.Run();
        tmrOverallProg.Start();
        setConnectionStatus(transferClient.EndPoint.Address.ToString());
    }

    private void btnConnect_Click(object sender, EventArgs e)
    {
        if (transferClient == null)
        {
            transferClient = new TransferClient();
            transferClient.Connect(txtCntHost.Text.Trim(),int.Parse(txtCntPort.Text.Trim()),connectCallback);
            Enabled = false;
        }
        else
        {
            transferClient.Close();
            transferClient = null;
        }
    }

    private void connectCallback(object sender, string error)
    {
        if (InvokeRequired)
        {
            Invoke(new ConnectCallBack(connectCallback), sender, error);
            return;
        }
        Enabled = true;

        if (error != null)
        {
            transferClient.Close();
            transferClient = null;
            MessageBox.Show(error, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        registerEvents();
        transferClient.OutputFolder = outputFolder;
        transferClient.Run();
        setConnectionStatus(transferClient.EndPoint.Address.ToString());
        tmrOverallProg.Start();
        btnConnect.Text = "Disconnect";
    }

    private void registerEvents()
    {
        transferClient.Complete += transferClient_Complete;
        transferClient.Disconnected += transferClient_Disconnected;
        transferClient.ProgressChanged += transferClient_ProgressChanged;
        transferClient.Queued += transferClient_Queued;
        transferClient.Stoped += transferClient_Stoped;
    }

    private void transferClient_Stoped(object sender, TransferQueue queue)
    {
        if (InvokeRequired)
        {
            Invoke(new TransferEventHandler(transferClient_Stoped), sender, queue);
            return;
        }
        lstTransfers.Items[queue.ID.ToString()].Remove();
    }

    private void transferClient_Queued(object sender, TransferQueue queue)
    {
        if (InvokeRequired)
        {
            Invoke(new TransferEventHandler(transferClient_Queued), sender, queue);

            return;
        }
        ListViewItem i = new ListViewItem();
        i.Text = queue.ID.ToString();
        i.SubItems.Add(queue.FileName);
        i.SubItems.Add(queue.Type == QueueType.Download ? "Download" : "Upload");
        i.SubItems.Add("0%");
        i.Tag = queue;
        i.Name = queue.ID.ToString();
        lstTransfers.Items.Add(i);
        i.EnsureVisible();

        if (queue.Type == QueueType.Download)
        {
            transferClient.startTransfer(queue);
        }
    }

    private void transferClient_ProgressChanged(object sender, TransferQueue queue)
    {
        if (InvokeRequired)
        {
            Invoke(new TransferEventHandler(transferClient_ProgressChanged), sender, queue);
            return;
        }

        lstTransfers.Items[queue.ID.ToString()].SubItems[3].Text = queue.Progress + "%";

    }

    private void transferClient_Disconnected(object sender, EventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new EventHandler(transferClient_Disconnected), sender, e);
            return;
        }
        deregiserEvents();

        foreach(ListViewItem item in lstTransfers.Items)
        {
            TransferQueue queue = (TransferQueue)item.Tag;
            queue.Close();
        }
        lstTransfers.Items.Clear();
        progressOverall.Value = 0;
        //transferClient.Close();
        transferClient = null;

        setConnectionStatus("-");

        if (serverRunning)
        {
            listener.Start(int.Parse(txtServerPort.Text.Trim()));
            setConnectionStatus("Waiting...");
        }
        else
        {
            btnConnect.Text = "Connect";
        }
    }

    private void transferClient_Complete(object sender, TransferQueue queue)
    {
        System.Media.SystemSounds.Asterisk.Play();
    }

    private void deregiserEvents()
    {
        if (transferClient == null)
            return;
        transferClient.Complete -= transferClient_Complete;
        transferClient.Disconnected -= transferClient_Disconnected;
        transferClient.ProgressChanged -= transferClient_ProgressChanged;
        transferClient.Queued -= transferClient_Queued;
        transferClient.Stoped -= transferClient_Stoped;
    }

    private void setConnectionStatus(string connectedTo)
    {
        lblConnected.Text = "Connection: " + connectedTo;
    }

    private void btnStartServer_Click(object sender, EventArgs e)
    {
        if (serverRunning)
            return;
        serverRunning = true;
        try {

            listener.Start(int.Parse(txtServerPort.Text.Trim()));
            setConnectionStatus("Waiting...");
            btnStartServer.Enabled = false;
            btnStopServer.Enabled = true;
        }
        catch
        {
            MessageBox.Show("Unable to listen on port " + txtServerPort.Text,"Port Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }
    }

    private void btnStopServer_Click(object sender, EventArgs e)
    {
        if (!serverRunning)
            return;
        if (transferClient != null)
            transferClient.Close();
        listener.Stop();
        tmrOverallProg.Stop();
        setConnectionStatus("-");
        serverRunning = false;
        btnStartServer.Enabled = true;
        btnStopServer.Enabled = false;
    }

    private void btnClearComplete_Click(object sender, EventArgs e)
    {
		foreach(ListViewItem i in lstTransfers.Items)
        {
            TransferQueue queue = (TransferQueue)i.Tag;

            if(queue.Progress==100 || !queue.Running)
            {
                i.Remove();
            }
        }
    }

    private void btnOpenDir_Click(object sender, EventArgs e)
    {
		using(FolderBrowserDialog fb = new FolderBrowserDialog())
        {
            if (fb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                outputFolder = fb.SelectedPath;
                
                if(transferClient != null)
                {
                    transferClient.OutputFolder = outputFolder;
                }

                txtSaveDir.Text = outputFolder;
            }
        }
    }

    private void btnSendFile_Click(object sender, EventArgs e)
    {
        if (transferClient == null)
            return;
        using(OpenFileDialog o = new OpenFileDialog())
        {
            o.Filter = "All Files(*.*)|*.*";
            o.Multiselect = true;

            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach(string file in o.FileNames)
                {
                    transferClient.QueueTransfer(file);
                }
            }
        }
    } //Open and send file using queue

    private void btnPauseTransfer_Click(object sender, EventArgs e)
    {

        if (transferClient == null)
            return;

        foreach (ListViewItem i in lstTransfers.SelectedItems)
        {
            TransferQueue queue = (TransferQueue)i.Tag;
            queue.Client.pauseTransfer(queue);
        }
    } //Pause sending

    private void btnStopTransfer_Click(object sender, EventArgs e)
    {

        if (transferClient == null)
            return;

        foreach (ListViewItem i in lstTransfers.SelectedItems)
        {
            TransferQueue queue = (TransferQueue)i.Tag;
            queue.Client.stopTransfer(queue);
            i.Remove();
        }
        progressOverall.Value = 0;
    } //Stop Sending
    }
}
