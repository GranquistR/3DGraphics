using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Objects;

namespace WindowsFormsApp1.Rendering
{
    internal class Rendering2D
    {
        public void Render(Graphics g, Player player)
        {
            g.FillEllipse(Brushes.Red, player.position.x, player.position.y, 50, 50);
        }
    }
}
