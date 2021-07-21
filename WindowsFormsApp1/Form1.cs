using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        BKLND bl = new BKLND();
        MGame m1 = new MGame();
        private int myVar;

        public int count
        {
            get { return myVar; }
            set { myVar = 0; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void welcome_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BakuLondon_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            bl.Show();
        }
        private void HoverGame_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            m1.Show();
        }
    }
}
