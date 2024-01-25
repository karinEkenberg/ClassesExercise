using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    internal class DemoForDrawing
    {
        public void MainMeny()
        {
            while (true)
            {
                DrawObject drawObject = new DrawObject();
                ClassLine classLine = new ClassLine();
                Circle circle = new Circle();
                Square square = new Square();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Welcome to the drawing program!");
                Console.WriteLine("[1] - Draw a line.");
                Console.WriteLine("[2] - Draw a circle.");
                Console.WriteLine("[3] - Draw a square.");
                Console.WriteLine("[4] - Exit.");

                Int32.TryParse(Console.ReadLine(), out int input);

                if (input == 1)
                {
                    classLine.Draw();
                }
                else if (input == 2)
                {
                    circle.Draw();
                }
                else if(input == 3)
                {
                    square.Draw();
                }
                else if (input == 4)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Shutting down.");
                    Thread.Sleep(1000);
                    Console.ResetColor();
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Wrong input.");
                    Thread.Sleep(1000);
                    Console.ResetColor();
                    continue;
                }
            }
        }
    }
}
