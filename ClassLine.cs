using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    public class ClassLine : DrawObject
    {
        public override void Draw()
        {
            Console.WriteLine("I am the line drawing object.");
            Console.WriteLine("-----------------------------");
            Console.ReadLine();
        }
    }
}
