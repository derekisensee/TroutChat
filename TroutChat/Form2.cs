using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TroutChat
{
    public partial class Form2 : Form
    {
        private string address;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            address = serverAddress.Text;
            Close();
        }

        public string getAddress()
        {
            return address;
        }
    }
}