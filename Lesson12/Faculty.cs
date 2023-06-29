using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    internal class Faculty : Univercity
    {
        public int memberShipYear;
        public int paymentAccount;
        public int facultyMemberCount;

        public Faculty() { }
        public Faculty(string location, string member, string name, int studentCount,int memberShipYear, int paymentAccount, int facultyMemberCount)
            :base(location, member, name, studentCount)
        {
            this.memberShipYear = memberShipYear;
            this.paymentAccount = paymentAccount;
            this.facultyMemberCount = facultyMemberCount;

        }
        
        public void PrintFaculty()
        {
            Console.WriteLine("PrintFaculty " + memberShipYear + " "+ paymentAccount+ " "+ facultyMemberCount+ " "+ location+ " "+ name);
        }

    }
}
