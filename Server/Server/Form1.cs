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
using System.Threading;


namespace Client_and_Server
{
    public partial class Form1 : Form
    {
        
        #region Server
        private SocketServer bancsServer = null;
        public SocketServer BancsServer
        {
            get
            {
                if (bancsServer == null)
                {
                    bancsServer = new SocketServer();
                    bancsServer.Connected += new SocketClientEventHandler(AcquirerServer_Connected);
                    bancsServer.Disconnected += new SocketClientEventHandler(AcquirerServer_Disconnected);
                    bancsServer.DataReceived += new SocketClientDataReceivedEventHandler(AcquirerServer_DataReceived);
                   
                }

               
                return bancsServer;
            }
            private set { bancsServer = value; }
        }

      
        void AcquirerServer_Connected(object sender, SocketClientEventArgs e)
        {
            
            al.Add(e.ID.ToString());
            OnUpdateAcquirerClientList();
        }
        void AcquirerServer_Disconnected(object sender, SocketClientEventArgs e)
        {
           
            al.RemoveRange(0, al.Count);
            OnUpdateAcquirerClientList();
        }
        void AcquirerServer_DataReceived(object sender, SocketClientDataReceivedEventArgs e)
        {
            ProcessData(e.Message, Convert.ToString(e.ID));
        }
       

        public event EventHandler UpdateAcquirerClientList = null;
        private void OnUpdateAcquirerClientList()
        {

            
        }
        ArrayList al = new ArrayList();
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
                if (BancsServer.IsListening)
                    BancsServer.StopListening();
                else
                {
                    BancsServer.HostIP = fldIBTGIP.ToString();
                    BancsServer.HostPort = Convert.ToInt32(fldIBTGPort.Text.ToString());
                    BancsServer.StartListening();
                }
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        public static byte[] ASCIIToByteArray(string str)
        {
            char[] chars = str.ToCharArray();
            byte[] result = new byte[chars.Length];
            for (int i = 0; i < chars.Length; i++)
                result[i] = (byte)chars[i];
            return result;
        }
        public static string ByteArrayToASCII(byte[] byteArray)
        {
            StringBuilder sb = new StringBuilder();
            if (byteArray != null)
                for (int i = 0; i < byteArray.Length; i++)
                    sb.Append((char)byteArray[i]);
            return sb.ToString();
        }
        Thread t1;
        private void ProcessData(byte[] rawMsg, string ChannelID)
        {
           

            try
            {
                string s = Form1.ByteArrayToASCII(rawMsg);
                Thread newthread = new Thread(() => { this.BeginInvoke((Action)delegate () { textBox1.Text = s; }); });
                newthread.Start();
                

                byte[] raw = Form1.ASCIIToByteArray(s);

                string Value = "bye";
                 
                byte[] data = Encoding.ASCII.GetBytes(Value);

                if (al.Contains(ChannelID))
                {
                    BancsServer.Send(ChannelID, data);
                    
                }
                else
                {
                    
                }


            }
            catch (Exception ex)
            {  }
        }
    }
}
