using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interfaces;

namespace WindowsFormsApp1.Scripts
{
    internal class FpsCounter : IScript
    {
        private long lastTime = DateTime.Now.Ticks;
        private long thisTime = DateTime.Now.Ticks;
        private long deltaTime = 0;
        private int fps = 0;
        private int averageCounter = 0;
        private int fpsTotal = 0;

        public int averageFps = 0;

        public void Update()
        {
            thisTime = DateTime.Now.Ticks;
            deltaTime = thisTime - lastTime;
            lastTime = thisTime;

            fps = (int)(10000000.0 / deltaTime);

            averageCounter++;
            fpsTotal += fps;
            if (averageCounter >= 10)
            {
                averageFps = fpsTotal / averageCounter;
            }
        }

        public void Start()
        {

        }
    }
}
