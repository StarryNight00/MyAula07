using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBalls
{
    internal class Ball
    {
        private static int ballCount;

        private float radius;
        private Color color;
        private int thrownCount;


        //Constructor
        static Ball()
        {
            ballCount = 0;
        }

        public Ball(float radius, Color color)
        {
            this.radius = radius;

            this.color = color;

            thrownCount = 0;

            ballCount++;
        }

        //'Sets' Group
        public void SetRadius(float radius)
        {
            if (radius > 0)
                this.radius = radius;
        }

        //'Gets' Group
        public int GetTimesThrown() => thrownCount;


        //Methods
        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius > 0)
            {
                thrownCount++;
            }
        }




    }
}
