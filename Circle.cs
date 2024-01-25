using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ClassesExercise
{
    internal class Circle : DrawObject
    {
        public override void Draw()
        {
            Console.WriteLine("I am the circle drawing object.");
            Console.WriteLine("            xxxx               ");
            Console.WriteLine("          xxx  xxx             ");
            Console.WriteLine("         xx      xx            ");
            Console.WriteLine("         xx      xx            ");
            Console.WriteLine("          xxx  xxx             ");
            Console.WriteLine("            xxxx               ");
            Console.ReadLine();
        }
    }
}
