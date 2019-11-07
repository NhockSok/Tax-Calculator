using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000/ 400;
            timer.Tick += timer_Tick;
            timer.Start();
            this.button1.Click += button1_Click;
        }

        void button1_Click(object sender, EventArgs e)
        {
            this.timer.Stop();
        }
        void timer_Tick(object sender, EventArgs e)
        {                      
                int x = this.button1.Location.X;
                int y = this.button1.Location.Y;
                this.button1.Location = new Point(x + 10, y);           
        }
    }
}
