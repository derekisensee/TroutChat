using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// check dis out bro: http://csharp.net-informations.com/communications/csharp-socket-programming.htm
namespace TroutChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            /*
             * This is for creating/showing a new form:
             * Form2 h = new Form2();
             * h.Show();
             */
        }
    }
}
