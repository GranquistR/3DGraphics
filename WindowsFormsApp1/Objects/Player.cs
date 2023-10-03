using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Objects
{
    internal class Player
    {
        public Vector2 position = new Vector2();
        private float speed = 5;
        private float acceleration = 0.5f;
        private float friction = 0.4f;
        private Vector2 velocity = new Vector2();

        public Player(Vector2 position)
        {
            this.position = position;
        }

        public void Contoller(List<Keys> keysPressed)
        {
            KeyboardInput(keysPressed);

            FrictionSlowdown();

            position += velocity;

        }

        private void FrictionSlowdown()
        {
            if(velocity.x > 0)
            {
                velocity.x -= friction;
            }else if(velocity.x < 0)
            {
                velocity.x += friction;
            }

            if (velocity.y > 0)
            {
                velocity.y -= friction;
            }
            else if (velocity.y < 0)
            {
                velocity.y += friction;
            }
        }

        private void KeyboardInput(List<Keys> keysPressed)
        {
            if (keysPressed.Contains(Keys.W))
            {
                velocity.y -= acceleration;
            }
            if (keysPressed.Contains(Keys.S))
            {
                velocity.y += acceleration;
            }
            if (keysPressed.Contains(Keys.A))
            {
               velocity.x -= acceleration;
            }
            if (keysPressed.Contains(Keys.D))
            {
                velocity.x += acceleration;
            }
        }

    }
}
