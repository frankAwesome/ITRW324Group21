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

namespace SkypeDemo
{

    public partial class Client : Form
    {
        int panelWidth;
        bool Hidden;

        // Client socket
        private Socket clientSocket;

        // Client name
        private string name;

        // Server End Point
        private EndPoint epServer;

        // Data stream
        private byte[] dataStream = new byte[1024];

        // Display message delegate
        private delegate void DisplayMessageDelegate(string message);
        private DisplayMessageDelegate displayMessageDelegate = null;

        bool bFormLoaded = false;



        public Client()
        {
            InitializeComponent();
            panelWidth = PanelSlide.Width;
            Hidden = false;

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

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                PanelSlide.Width = PanelSlide.Width + 20;
                rtxtConversation.Width = rtxtConversation.Width - 20;
                txtMessage.Width = txtMessage.Width - 20;
                btnSend.Left += -20;

                if (PanelSlide.Width >= panelWidth)
                {
                    timer2.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                PanelSlide.Width = PanelSlide.Width - 20;
                rtxtConversation.Width = rtxtConversation.Width + 20;
                txtMessage.Width = txtMessage.Width + 20;
                btnSend.Left += 20;

                if (PanelSlide.Width <= 0)
                {
                    timer2.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                this.name = txtName.Text.Trim();

                // Initialise a packet object to store the data to be sent
                Packet sendData = new Packet();
                sendData.ChatName = this.name;
                sendData.ChatMessage = null;
                sendData.ChatDataIdentifier = DataIdentifier.LogIn;

                // Initialise socket
                this.clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                // Initialise server IP
                IPAddress serverIP = IPAddress.Parse(txtServerIP.Text.Trim());

                // Initialise the IPEndPoint for the server and use port 30000
                IPEndPoint server = new IPEndPoint(serverIP, 30000);

                // Initialise the EndPoint for the server
                epServer = (EndPoint)server;

                // Get packet as byte array
                byte[] data = sendData.GetDataStream();

                // Send data to server
                clientSocket.BeginSendTo(data, 0, data.Length, SocketFlags.None, epServer, new AsyncCallback(this.SendData), null);

                // Initialise data stream
                this.dataStream = new byte[1024];

                // Begin listening for broadcasts
                clientSocket.BeginReceiveFrom(this.dataStream, 0, this.dataStream.Length, SocketFlags.None, ref epServer, new AsyncCallback(this.ReceiveData), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialise a packet object to store the data to be sent
                Packet sendData = new Packet();
                sendData.ChatName = this.name;
                sendData.ChatMessage = txtMessage.Text.Trim();
                sendData.ChatDataIdentifier = DataIdentifier.Message;

                // Get packet as byte array
                byte[] byteData = sendData.GetDataStream();

                // Send packet to the server
                clientSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, epServer, new AsyncCallback(this.SendData), null);

                txtMessage.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Send Error: " + ex.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.displayMessageDelegate = new DisplayMessageDelegate(this.DisplayMessage);
            getIPAddresses();
            // Get host name
            txtName.Text = Dns.GetHostName().ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.clientSocket != null)
                {
                    // Initialise a packet object to store the data to be sent
                    Packet sendData = new Packet();
                    sendData.ChatDataIdentifier = DataIdentifier.LogOut;
                    sendData.ChatName = this.name;
                    sendData.ChatMessage = null;

                    // Get packet as byte array
                    byte[] byteData = sendData.GetDataStream();

                    // Send packet to the server
                    this.clientSocket.SendTo(byteData, 0, byteData.Length, SocketFlags.None, epServer);

                    // Close the socket
                    this.clientSocket.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Closing Error: " + ex.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Send And Receive

        private void SendData(IAsyncResult ar)
        {
            try
            {
                clientSocket.EndSend(ar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Send Data: " + ex.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReceiveData(IAsyncResult ar)
        {
            try
            {
                // Receive all data
                this.clientSocket.EndReceive(ar);

                // Initialise a packet object to store the received data
                Packet receivedData = new Packet(this.dataStream);

                // Update display through a delegate
                if (receivedData.ChatMessage != null)
                    this.Invoke(this.displayMessageDelegate, new object[] { receivedData.ChatMessage });

                // Reset data stream
                this.dataStream = new byte[1024];

                // Continue listening for broadcasts
                clientSocket.BeginReceiveFrom(this.dataStream, 0, this.dataStream.Length, SocketFlags.None, ref epServer, new AsyncCallback(this.ReceiveData), null);
            }
            catch (ObjectDisposedException)
            { }
            catch (Exception ex)
            {
                MessageBox.Show("Receive Data: " + ex.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Other Methods

        private void DisplayMessage(string messge)
        {
            rtxtConversation.Text += messge + Environment.NewLine;
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm5 = new Form2();
            if (bFormLoaded == false)
            {
                frm5.Show();
                bFormLoaded = true;
            }


                frm5.BringToFront();

            this.Hide();
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

        public void getIPAddresses()
        {
            // Get host name
            String strHostName = Dns.GetHostName();

            // Find host by name
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

            // Enumerate IP addresses
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                rTxtIP.AppendText(ipaddress.ToString());
                txtServerIP.Text = ipaddress.ToString();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
