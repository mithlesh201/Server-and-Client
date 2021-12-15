using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIIPL.Sockets;
using System.Collections;

namespace Client_and_Server
{
    public partial class Form1 : Form
    {
        #region Client
        private SocketClient client = null;

        public SocketClient Client
        {
            get
            {
                if (client == null)
                {
                    client = new SocketClient(SocketClientLocationEnum.ClientSide);
                    
                }
                
                return client;
            }
            set { client = value; }
        }

        
        #endregion
        
        public Form1()
        {
            InitializeComponent();
            fldConnecteas.SelectedIndex = 0;
        }
        bool IsRunning = false;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (fldConnecteas.SelectedIndex == 0)
            {
                if (IsRunning) //(Client.IsRunning)
                {
                    Client.StopClient();
                    IsRunning = false;
                    btnConnect.Text = "Connect";
                }
                else
                {
                    Client.RemoteHostIP = fldIBTGIP.Text;
                    Client.RemoteHostPort = (int)fldIBTGPort.Value;
                    Client.StartClient();
                    IsRunning = true;
                    btnConnect.Text = "Disconnect";
                }
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnISOSend_Click(object sender, EventArgs e)
        {
            try
            {
                string rawMsg = fldISOMessage.Text;
                if (rawMsg == null || rawMsg.Length == 0)
                    return;
               
                try
                {
                   
                }
                catch { }
                if (fldConnecteas.SelectedIndex == 0)
                    Client.Send(Form1.ASCIIToByteArray(rawMsg));
               
            }
            catch (Exception ex)
            {
               
            }
        }
        public static byte[] ASCIIToByteArray(string str)
        {
            char[] chars = str.ToCharArray();
            byte[] result = new byte[chars.Length];
            for (int i = 0; i < chars.Length; i++)
                result[i] = (byte)chars[i];
            return result;
        }
    }
}
