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
// check dis out bro: http://csharp.net-informations.com/communications/csharp-socket-programming.htm
namespace TroutChat
{
    public partial class Form1 : Form
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        private List<string> entries;
        private string address;

        public Form1(string addr)
        {
            address = addr;
            entries = new List<string>();
            clientSocket.Connect(address, 8888);
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //chatLabel.Text = chatField.Text;
            /*
            entries.Add(DateTime.Now.ToLocalTime() + " : " + chatField.Text + "\n");
            
            chatLabel.Text += entries.Last();
            panel1.VerticalScroll.Value = panel1.VerticalScroll.Maximum;
            /*
             * This is for creating/showing a new form:
             * Form2 h = new Form2();
             * h.Show();
             */
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(chatField.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            byte[] inStream = new byte[10025];
            serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
            string returndata = System.Text.Encoding.ASCII.GetString(inStream);
            msg(returndata);
            chatField.Text = "";
            chatField.Focus();
        }

        public void msg(string mesg)
        {
            chatLabel.Text = chatLabel.Text + Environment.NewLine + " >> " + mesg;
        }
    }
}