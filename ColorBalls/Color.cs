using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBalls
{
    internal class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;


        private static int paletteCount;

        //Construtor
        static Color()
        {
            paletteCount = 0;
        }

        public Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;

            paletteCount++;
        }

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;

            paletteCount++;
        }

    }
}
