using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Interfaces;
using WindowsFormsApp1.Scripts;

namespace WindowsFormsApp1
{
    public partial class Game1 : Form
    {
        FpsCounter fps = new FpsCounter();
        Rectangle viewport = new Rectangle(0, 0, 1024, 576);
        
        public Game1()
        {
            var timer = new Timer();
            timer.Enabled = false;
            timer.Interval = 1;
            timer.Tick += new EventHandler(TimerCallback);
            timer.Start();

            fps.Start();
            
            InitializeComponent();
        }

        private void TimerCallback(object sender, EventArgs e)
        {
            Invalidate();

            fps.Update();

            return;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            g.DrawRectangle(Pens.Black, viewport);  
            g.DrawString(fps.averageFps.ToString(), new Font("Arial", 16), Brushes.Red, 0, 0);
           
        }
    }
}
