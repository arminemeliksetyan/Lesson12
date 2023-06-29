using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson12
{
    internal class Cheese:Milk
    {
        public float kilogram;
        public string type;
        public int count = 0;


        public Cheese() { }
        public Cheese(float kilogram, float liter, string type, float milkPowder) :base(kilogram, liter)
        {
            this.kilogram = milkPowder;
            this.type = type;
        }
        public int PrintCheese(ref float liter)
        {
            if (liter > 0)
            {
                liter -= 5;
                count++;
                PrintCheese(ref liter);
            }
            return count;
            
        }
    }
}
