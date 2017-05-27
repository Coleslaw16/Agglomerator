using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheAgglomerator
{
    class droplets
    {
        protected float x;
        protected float y;
        protected float vx;
        protected float vy;
        protected float size;
        protected Color color;
        protected float mass;
        protected bool hit = false;

        public droplets(float x, float y, float vx, float vy, float size, int red, int blue, int green, float mass)
        {
            this.x = x;
            this.y = y;
            this.vx = vx;
            this.vy = vy;
            this.size = size;
            this.color = Color.FromArgb(red, green, blue);
            hit = false;
            this.mass = (float) mass;
        }

        public float X
        {
            get
            {
                return x;
            }
        }

        public float Y
        {
            get
            {
                return y;
            }
        }

        public float VX
        {
            get
            {
                return vx;
            }
        }

        public float VY
        {
            get
            {
                return vy;
            }
        }

        public float Size
        {
            get
            {
                return size;
            }
        }

        public Color Color
        {
            get
            {
                return color;
            }
        }

        public bool Hit
        {
            get
            {
                return hit;
            }
            set
            {
                hit = value;
            }
        }

        public float Mass
        {
            get
            {
                return mass;
            }
            set
            {
                mass = value;
            }
        }

        public void wrap(float w, float h)
        {
            float center = .5F * size;
            if((x + center) < 0)
            {
                x = w - (center);
            }
            else if((x + center) > w )
            {
                x = 0 + (center);
            }
            if ((y + center) < 0)
            {
                y = h - (center);
            }
            else if ((y + center) > h)
            {
                y = 0 + (center);
            }
        }

        public void move()
        {
            x += vx;
            y += vy;
        }
    }

}
