using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    internal class Milk
    {
        public float milkPowder;
        public float liter;

        public Milk() { }
        public Milk(float milkPowder, float liter)
        {
            this.milkPowder = milkPowder;
            this.liter = liter;
        }   

        public void PrintMilk()
        {
            Console.WriteLine("Print milk " + milkPowder + " " + liter);
        }
    }
}
