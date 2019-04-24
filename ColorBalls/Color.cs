using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBalls
{
    internal class Color
    {
        private uint red;
        private uint green;
        private uint blue;
        private uint alpha;


        private static int paletteCount;

        //Construtor
        static Color()
        {
            paletteCount = 0;
        }


        /// <summary>
        /// All parameter Color constructor. Receives 4 values.
        /// All RGB color values are positive, usually in between 0 and 255.
        /// </summary>
        /// <param name="red"> uInt value for red.</param>
        /// <param name="green"> uInt value for green.</param>
        /// <param name="blue"> uInt value for blue.</param>
        /// <param name="alpha">uInt value for alpha, or transparency.</param>
        public Color(uint red, uint green, uint blue, uint alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;

            paletteCount++;
        }

        /// <summary>
        /// Three parameter Color constructor. Receives 3 values. Alpha is set to opaque.
        /// All RGB color values are positive, usually in between 0 and 255.
        /// </summary>
        /// <param name="red"> uInt value for red.</param>
        /// <param name="green"> uInt value for green.</param>
        /// <param name="blue"> uInt value for blue.</param>
        public Color(uint red, uint green, uint blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;

            paletteCount++;
        }


        //'Sets' Group
        public void SetRed(int red)
        {
            //Verificar se o valor red dado em argumento não é nulo
            //e não tem valor negativo ou acima de 255
            if (red >= 0 && red <= 255)
                this.red = (uint)red;
        }

        public void SetGreen(int green)
        {
            if (green >= 0 && green <= 255)
                this.green = (uint)green;
        }

        public void SetBlue(int blue)
        {
            if (blue >= 0 && blue <= 255)
                this.blue = (uint)blue;
        }

        public void SetAlpha(int alpha)
        {
            if (alpha >= 0 && alpha <= 255)
                this.alpha = (uint)alpha;
        }

        //'Gets' Group
        public uint GetRed() => red;

        public uint GetGreen() => green;

        public uint GetBlue() => blue;

        public uint GetAlpha() => alpha;

    }
}
