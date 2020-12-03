using System;

namespace MidTermAssignement_TheoBernier
{
    class Program
    {
        static void Main(string[] args)
        {
            //A demo of the classes, using the constructors.

            Console.WriteLine("Enter the student's first Name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lname = Console.ReadLine();
            Person stdPerson = new Person(fname, lname);

            Console.WriteLine("Enter the student's country");
            string country = Console.ReadLine();
            Console.WriteLine("Enter the student's city");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the student's street");
            string street = Console.ReadLine();
            Adress stdAdress = new Adress(street, city, country);

            Console.WriteLine("Enter the student's studentNumber");
            string studentnumber = Console.ReadLine();
            Console.WriteLine("Enter the student's age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the student's scores separated by commas");
            string stringScores = Console.ReadLine();
            float[] scores = Array.ConvertAll(stringScores.Split(','), float.Parse);
            Student std = new Student(stdPerson, stdAdress, studentnumber, age, scores);

            Console.WriteLine(std.ToString());



        }
    }
}
