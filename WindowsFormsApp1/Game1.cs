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
using WindowsFormsApp1.Objects;
using WindowsFormsApp1.Rendering;
using WindowsFormsApp1.Scripts;

namespace WindowsFormsApp1
{
    public partial class Game1 : Form
    {
        //fps counter script
        FpsCounter fps = new FpsCounter();
        
        //player object
        Player player = new Player(new Vector2(0,0));

        //list of keys pressed
        List<Keys> keysPressed = new List<Keys>();
        
        //rendering the game in 2d
        Rendering2D rendering2D = new Rendering2D();

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
            player.Contoller(keysPressed);

            return;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            rendering2D.Render(g, player);

            g.DrawString(String.Join(", ",keysPressed.ToArray()), new Font("Arial", 16), Brushes.Red, 0, 50);

            g.DrawString(fps.averageFps.ToString(), new Font("Arial", 16), Brushes.Red, 0, 0);
           
        }

        private void Game1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keysPressed.Contains(e.KeyCode))
            {
                keysPressed.Add(e.KeyCode);
            }
        }
       

        private void Game1_KeyUp(object sender, KeyEventArgs e)
        {
            keysPressed.Remove(e.KeyCode);
            
        }
    }
}
