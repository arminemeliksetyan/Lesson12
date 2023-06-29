using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    internal class Pulpit:Faculty
    {
        public string lecturer;
        public string subject;

        public Pulpit() { }
        public Pulpit(string location, string member, string name, int studentCount, int memberShipYear, int paymentAccount, int facultyMemberCount,string lecturer, string subject)
            :base(location,member ,name, studentCount, memberShipYear, paymentAccount, facultyMemberCount)
        {
            this.lecturer = lecturer;
            this.subject = subject;
        }

        public void PrintPulpit()
        {
            Console.WriteLine("PrintPulpit " + location + " , " + member + " , " + name + " , "
                + studentCount + " , " + memberShipYear + " , " + paymentAccount + " , " + facultyMemberCount);
        }
    }
}
