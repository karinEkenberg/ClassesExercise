using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    internal class Square : DrawObject
    {
        public override void Draw()
        {
            Console.WriteLine("I am the square drawing object.");
            Console.WriteLine("I am the circle drawing object.");
            Console.WriteLine("            xxxxxxx            ");
            Console.WriteLine("            x     x            ");
            Console.WriteLine("            x     x            ");
            Console.WriteLine("            x     x            ");
            Console.WriteLine("            xxxxxxx            ");
            Console.ReadLine();
        }
    }
}
