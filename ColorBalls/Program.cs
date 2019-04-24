using System;

namespace ColorBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            Color red, green, blue;
            Color marineBlue, lightMarineBlue, lightOrange, vividYellow;

            //colors
            red = new Color(255, 0, 0);
            green = new Color(0, 255, 0);
            blue = new Color(0, 0, 255);

            marineBlue = new Color(0, 94, 99);
            lightMarineBlue = new Color(0, 94, 99, 100);
            lightOrange = new Color(238, 118, 36, 80);
            vividYellow = new Color(244, 196, 0, 200);

            //balls
            Ball ball1 = new Ball(4.0f, green);
            Ball ball2 = new Ball(2.5f, lightOrange);
            Ball ball3 = new Ball(5.67f, marineBlue);
            Ball ball4 = new Ball(7.43f, vividYellow);
            Ball ball5 = new Ball(23.456f, red);

            //methods
            
        }
    }
}
