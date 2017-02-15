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
        private List<string> entries;
        public Form1()
        {
            entries = new List<string>();
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //chatLabel.Text = chatField.Text;
            entries.Add(DateTime.Now.ToLocalTime() + " : " + chatField.Text + "\n");
            
            chatLabel.Text += entries.Last();
            panel1.VerticalScroll.Value = panel1.VerticalScroll.Maximum;
            /*
             * This is for creating/showing a new form:
             * Form2 h = new Form2();
             * h.Show();
             */
        }
    }
}