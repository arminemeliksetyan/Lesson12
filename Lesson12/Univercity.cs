using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    internal class Univercity
    {
        public string location;
        public string member;
        public string name;
        public int studentCount;

        public Univercity() { }
        public Univercity(string location, string member, string name, int studentCount)
        {
            this.location = location;
            this.member = member;
            this.name = name;
            this.studentCount = studentCount;
        }

        public void PrintUnivercity() 
        {
            Console.WriteLine("PrintUnivercity Location - " + location + " Name - "+ name +" StudentCount - "+ studentCount);
        }

    }
}
