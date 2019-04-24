using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBalls
{
    internal class Ball
    {
        private static int ballCount;

        private int size;
        private int radius;
        private int color = new Color;
        private int thrownCount;
        private int pi = (int)Math.PI;


        //Constructor
        static Ball()
        {
            ballCount = 0;
        }

        public Ball(int radius, int color)
        {
            size = pi * (radius * radius);

            this.color = color;

            thrownCount = 0;

            ballCount++;
        }

        //'Sets' Group
        public void SetRadius(int radius)
        {
            if (radius > 0)
                this.radius = radius;
        }

        //'Gets' Group
        public int GetTimesThrown() => thrownCount;


        //Mathods
        public void Pop()
        {
            size = 0;
        }

        public void Throw()
        {
            if (size > 0)
            {
                thrownCount++;
            }
        }




    }
}
