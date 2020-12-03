using System;
using System.Collections.Generic;
using System.Text;

namespace MidTermAssignement_TheoBernier
{
    class Student
    {
        string firstName;
        string lastName;
        string fullName;

        Adress Adress;
        string fullAdress;

        string studentNumber;
        int age;
        Single[] scores;
        Single averageScore;

        string info;

        public Student(Person person,Adress adress,string studentNumber,int age,Single[] scores)
        {
            this.firstName = person.FirstName;
            this.lastName = person.LastName;
            this.fullName = person.FullName();

            this.Adress = adress;
            this.fullAdress = adress.FullAdress();

            this.studentNumber = studentNumber;
            this.age = age;
            this.scores = scores;
            this.averageScore = Average(scores);
        }

        public override string ToString()
        {
            string info = "";
            info = info + ($"Student {this.fullName} score is {this.averageScore.ToString()}");
            info = info + ($"\nStudent {this.fullName} is living in {this.Adress.City}");
            info = info + ($"\nStudent {this.fullName} is living in {this.Adress.Country}");
            info = info + ($"Student {this.fullName} adress is {this.fullAdress}");
            info = info + ($"Student {this.fullName} age is {this.age}");
            info = info + ($"Student {this.fullName} student number is {this.studentNumber}");
            return info;
        }

        public Single Average(float[] arrFloat)
        {
            if (arrFloat.Length > 0)
            {
                Single Total = 0;
                Single count = 0;
                foreach (var single in arrFloat)
                {
                    Total += single;
                    count += 1;
                }
                return Total / count;
            }
            else
            {
                Single res = 0;
                return res;
            }
        }


    }
}
