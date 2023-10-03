using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Objects
{
    public class Vector2
    {
        public float x { get; set; }
        public float y { get; set; }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2()
        {
            this.x = 0;
            this.y = 0;
        }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2((a.x + b.x), (a.y + b.y));
        }

    }
}
