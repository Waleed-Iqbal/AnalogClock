using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class AnalogClock : Form
    {
        Timer timer = new Timer();

        int WIDTH = 300; // TODO: take input from a control later
        int HEIGHT = 300; //TODO: take input from a control later

        int hourHandLength = 80; // hour hand's length
        int minHandLength = 110; // minute hand's length
        int secHandLength = 140; // second hand's length

        Bitmap bmp;
        Graphics g;

        public AnalogClock()
        {
            InitializeComponent();
        }

        private void FormAnalogClock_Load(object sender, EventArgs e)
        {
            // creating bitmap
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);

            // setting center
            ClockCenter.x = WIDTH / 2;
            ClockCenter.y = HEIGHT / 2;

            // background color
            this.BackColor = Color.White; // TODO: make this color customizable as well

            // timer (the original clock)
            timer.Interval = 1000; // in milliseconds
            timer.Tick += new EventHandler(this.timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            g = Graphics.FromImage(bmp);

            // getting current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            Coordinates handCoordinates = new Coordinates();

            g.Clear(Color.Transparent);

            g.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, WIDTH, HEIGHT);

            g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
            g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));
            g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));
            g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));

            handCoordinates = GetMinutesAndSecondsCoordinates(ss, secHandLength);
            g.DrawLine(new Pen(Brushes.Red, 1f), new Point(ClockCenter.x, ClockCenter.y),
                new Point(handCoordinates.x, handCoordinates.y));

            handCoordinates = GetMinutesAndSecondsCoordinates(mm, minHandLength);
            g.DrawLine(new Pen(Brushes.Black, 2f), new Point(ClockCenter.x, ClockCenter.y),
                new Point(handCoordinates.x, handCoordinates.y));

            handCoordinates = GetHoursHandCoordinates(hh % 12, mm, hourHandLength);
            g.DrawLine(new Pen(Brushes.Gray, 3f), new Point(ClockCenter.x, ClockCenter.y),
                new Point(handCoordinates.x, handCoordinates.y));


            pbAnalogClock.Image = bmp;

            this.Text = "Time: " + hh + ":" + mm + ":" + ss;

            g.Dispose();            
        }

        private Coordinates GetMinutesAndSecondsCoordinates(int val, int hlen)
        {
            Coordinates msCoordinates = new Coordinates();
            val *= 6;
            
            AdjustCoordinates(msCoordinates, val, hlen);
            
            return msCoordinates;
        }

       
        private Coordinates GetHoursHandCoordinates(int hval, int mval, int hlen)
        {
            Coordinates msCoordinates = new Coordinates();

            // each hour makes 30 degrees and each minute makes 0.5 degrees
            int val = (int)((hval * 30) + (mval * 0.5));

            AdjustCoordinates(msCoordinates, val, hlen);

            return msCoordinates;
        }

        private void AdjustCoordinates(Coordinates msCoordinates, int val, int hlen)
        {
            if (val >= 0 && val <= 180)
            {
                msCoordinates.x = ClockCenter.x + (int)(hlen * Math.Sin(Math.PI * val / 180));
                msCoordinates.y = ClockCenter.y - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                msCoordinates.x = ClockCenter.x - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                msCoordinates.y = ClockCenter.y - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
        }
    }
}
