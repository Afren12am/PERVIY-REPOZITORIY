using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int Width;
            int Height;
            Console.ForegroundColor = ConsoleColor.Green;
            Width = Console.WindowWidth;
            Height = Console.WindowHeight;
            string text = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ/-+=/][.,";
            while (true)
            {

                for (int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(rand.Next(0, Width), rand.Next(0, Height));
                    Console.WriteLine(text[rand.Next(0, 45)]);

                }
                for (int i = 0; i < 20; i++)
                {
                    Console.SetCursorPosition(rand.Next(0, Width), rand.Next(0, Height));
                    Console.Write(" ");

                }


            }


        }
    }
}
