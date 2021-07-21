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
    public partial class MGame : Form
    {
        public MGame()
        {
            InitializeComponent();
        }

        private void MGame_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (sender is Button bt)
            {
                Random random = new Random();
                int randomX = random.Next(this.Size.Width - 100);
                int randomY = random.Next(this.Size.Height - 100);
                bt.Location = new Point(randomX, randomY);

                this.Controls.Add(bt);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void MGame_MouseMove(object sender, MouseEventArgs e)
        {
            this.qai.Location = e.Location;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
             Form1 f2 = new Form1();
            f2.Show();
        }
    }
}
