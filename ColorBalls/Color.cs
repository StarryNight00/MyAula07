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


        private static int colorCount;

        //Construtor
        static Color()
        {
            colorCount = 0;
        }


        /// <summary>
        /// All parameter Color constructor. Receives 4 values.
        /// All RGB color values are positive, usually in between 0 and 255.
        /// </summary>
        /// <param name="red"> uInt value for red.</param>
        /// <param name="green"> uInt value for green.</param>
        /// <param name="blue"> uInt value for blue.</param>
        /// <param name="alpha">uInt value for alpha, or transparency.</param>
        public Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;

            colorCount++;
        }

        /// <summary>
        /// Three parameter Color constructor. Receives 3 values. Alpha is set to opaque.
        /// All RGB color values are positive, usually in between 0 and 255.
        /// </summary>
        /// <param name="red"> uInt value for red.</param>
        /// <param name="green"> uInt value for green.</param>
        /// <param name="blue"> uInt value for blue.</param>
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;

            colorCount++;
        }

        //Greyscale method
        public int ColorGrayscale(int red, int blue, int green)
        {
            int totalValue = red + blue + green;
            int grayscale = totalValue / 3;

            return grayscale;
        }

        //'Sets' Group
        public void SetRed(int red)
        {
            //Verificar se o valor red dado em argumento não é nulo
            //e não tem valor negativo ou acima de 255
            if (red >= 0 && red <= 255)
                this.red = red;
        }

        public void SetGreen(int green)
        {
            if (green >= 0 && green <= 255)
                this.green = green;
        }

        public void SetBlue(int blue)
        {
            if (blue >= 0 && blue <= 255)
                this.blue = blue;
        }

        public void SetAlpha(int alpha)
        {
            if (alpha >= 0 && alpha <= 255)
                this.alpha = alpha;
        }

        //'Gets' Group
        public int GetRed() => red;

        public int GetGreen() => green;

        public int GetBlue() => blue;

        public int GetAlpha() => alpha;

        public int GetColorCount() => colorCount;

    }
}
