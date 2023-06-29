namespace Lesson12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Univercity univercity = new Univercity();
            univercity.location = "Yerevan, Armenia";
            univercity.name = "EPH";
            univercity.studentCount = 5241;
            univercity.PrintUnivercity();

            Faculty faculty = new Faculty();
            faculty.location = univercity.location;
            faculty.name= univercity.name;
            faculty.studentCount= univercity.studentCount;
            faculty.facultyMemberCount = 1500;
            faculty.memberShipYear = 4;
            faculty.paymentAccount = 1521365461;
            faculty.PrintFaculty();

            Pulpit pulpit = new Pulpit();
            pulpit.location = univercity.location;
            pulpit.name = univercity.name;
            pulpit.member = "member";
            pulpit.studentCount = univercity.studentCount;
            pulpit.facultyMemberCount = faculty.facultyMemberCount;
            pulpit.memberShipYear = 5;
            pulpit.paymentAccount = 456248500;
            pulpit.lecturer = "Martirosyan";
            pulpit.subject = "Announsement";
            pulpit.PrintPulpit();

            Milk milk = new Milk();
            milk.milkPowder = 10;
            milk.liter = 120;


            Cheese cheese = new Cheese();
            cheese.liter = milk.liter;
            cheese.milkPowder = milk.milkPowder;
            cheese.type = Convert.ToString(Type.Blue);
            milk.PrintMilk();
            int vz = cheese.PrintCheese(ref milk.liter);
            Console.WriteLine(vz+ " kg chees we will have in "+ cheese.liter + " of milk.");

        }
    }
}