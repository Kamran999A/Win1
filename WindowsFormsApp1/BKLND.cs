using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BKLND : Form
    {
        public bool count { get; set; }

        public BKLND()
        {
            InitializeComponent();
        }

        public void BKLND_Load(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

        }
        public void BakuT() {

            circularClock.Text = GetDateTime("Azerbaijan Standard Time").ToString("hh:mm:ss");
            circularClock.SubscriptText = DateTime.Now.ToString("tt");

        }
        public void LondonT() {

            circularClock.Text = GetDateTime("Greenwich Standard Time").ToString("hh:mm:ss");
            circularClock.SubscriptText = DateTime.Now.ToString("tt");

        }

        public void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!count)
            {
                circularClock.Invoke((MethodInvoker)delegate
                {
                    LondonT();
                });
            }
            else
            {
                circularClock.Invoke((MethodInvoker)delegate
                {
                    BakuT();
                });
            }
            
        }
        private DateTime GetDateTime(string id)
        {
            var info = TimeZoneInfo.FindSystemTimeZoneById(id);
            DateTimeOffset localServerTime = DateTimeOffset.Now;
            DateTimeOffset localTime = TimeZoneInfo.ConvertTime(localServerTime, info);
            
            return localTime.DateTime;
        }


        public void Bakubtn_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.baku;
            count = true;
        }

        private void Londonbtn_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.london;
            count = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.Show();
        }
    }
}
