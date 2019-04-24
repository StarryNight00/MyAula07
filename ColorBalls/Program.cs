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
            ball1.Throw();
            ball2.Throw();
            ball3.Pop();
            ball3.Throw();  //to verify if Pop is working correctly
            ball4.Throw();
            ball5.Throw();

            ball1.Throw();
            ball2.Throw();
            ball4.Pop();
            ball5.Throw();

            ball1.Pop();
            ball2.Throw();
            ball5.Throw();
            ball5.Throw();

            ball2.Throw();
            ball5.Pop();

            ball2.Throw();
            ball2.Pop();

            //Final verification
            Console.WriteLine("Vezes que cada bola foi atirada.");
            Console.WriteLine("Para bola 1:");
            Console.WriteLine(ball1.GetTimesThrown());
            Console.WriteLine();
            Console.WriteLine("Para bola 2:");
            Console.WriteLine(ball2.GetTimesThrown());
            Console.WriteLine();
            Console.WriteLine("Para bola 3:");
            Console.WriteLine(ball3.GetTimesThrown());
            Console.WriteLine();
            Console.WriteLine("Para bola 4:");
            Console.WriteLine(ball4.GetTimesThrown());
            Console.WriteLine();
            Console.WriteLine("Para bola 5:");
            Console.WriteLine(ball5.GetTimesThrown());


        }
    }
}
