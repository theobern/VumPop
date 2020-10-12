using System;
using System.Collections.Generic;

namespace Lesson_03_Conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            task4_Greeting();
        }

        static void task1_Triangles()
        {
            float lenA;
            float lenB;
            float lenC;
            bool verif;

            Console.WriteLine("Please enter the length of side A");
            verif = float.TryParse(Console.ReadLine(), out lenA);
            if (verif == false)
            {
                Console.WriteLine("Incorrect type");
                task1_Triangles();
            }


            Console.WriteLine("Please enter the length of side B");
            verif = float.TryParse(Console.ReadLine(), out lenB);
            if (verif == false)
            {
                Console.WriteLine("Incorrect type");
                task1_Triangles();
            }

            Console.WriteLine("Please enter the length of side C");
            verif = float.TryParse(Console.ReadLine(), out lenC);
            if (verif == false)
            {
                Console.WriteLine("Incorrect type");
                task1_Triangles();
            }

            if ((lenA == lenB) && (lenB == lenC))
            {
                Console.WriteLine("All of the sides are of equal length");
            }
            else
            {

                if (lenA == lenB)
                {
                    Console.WriteLine("Only sides A and B are equals");
                }
                if (lenA == lenC)
                {
                    Console.WriteLine("Only sides A and C are equals");
                }
                if (lenB == lenC)
                {
                    Console.WriteLine("Only sides B and C are equals");
                }
            }
        }



        static void Task2_nNmbers()
        {
            List<float> numbers = new List<float>();
            float sum = 0;

            int i = 0;
            while(i<10)
            {
                float number;
                Console.WriteLine($"You entered {i} numbers beetween 10 an 20");
                if(float.TryParse(Console.ReadLine(),out number) && number<20 && number >10)
                {
                    sum = sum + number;
                    numbers.Add(number);
                    i++;
                }
                else { continue; }
            }

            foreach(var nb in numbers)
            {
                Console.WriteLine(nb);
            }
            Console.WriteLine($"The sum of the numbers is {sum}");
        }



        static void task3_sportselector()
        {
            int size;
            Console.WriteLine("Enter your size");
            bool verif = int.TryParse(Console.ReadLine(), out size);
            if(verif == true)
            {
                if ((175 <= size) && (size<= 190)) { Console.WriteLine("Basketball");}
                if (size < 175) { Console.WriteLine("Athletics"); }
                if (size > 190) { Console.WriteLine("Horse Riding"); }
            }
            else { Console.WriteLine("Please enter an integer"); task3_sportselector(); }
        }


        static void task4_Greeting()
        {
            Console.WriteLine("Do you want to use ? : \n    (1) The clock (1)\n    (2) Type the date");
            int i;
            int.TryParse(Console.ReadLine(), out i);
            
            switch(i)
            {
                case 1: GreetingClock(); break;
                case 2: GreetingHand(); break;
            }
        }

        static void GreetingClock()
        {
            DateTime time = DateTime.Now;
            int hour = time.Hour;
            string nameDay = Convert.ToString(time.DayOfWeek);

            string periodDay = "morning";
            if(hour>=12)
            {
                periodDay = "evening";
            }

            if((nameDay == "Sunday") || (nameDay == "Saturday"))
            {
                Console.WriteLine($"Good {periodDay}, it is lovely {nameDay} today. Weekend is here ! ");
            }
            else
            {
                int beforeWE = 0;
                switch(nameDay)
                {
                    case "Monday":
                        beforeWE = 5;
                        break;
                    case "Tuesday":
                        beforeWE = 4;
                        break;
                    case "Wednesday":
                        beforeWE = 3;
                        break;
                    case "Thursday":
                        beforeWE = 2;
                        break;
                    case "Friday":
                        beforeWE = 1;
                        break;

                }
                Console.WriteLine($"Good {periodDay},it is lovely {nameDay} today. Weekend is coming in {beforeWE} days");
            }

        }

        static void GreetingHand()
        {
            int num_Week;
            int num_Hour;

            List <string> nameDayList = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.WriteLine("Enter day of the week (1-7) : ");
            bool verif1 = int.TryParse(Console.ReadLine(), out num_Week);
            Console.WriteLine("Enter the hour (0-23) : ");
            bool verif2 =int.TryParse(Console.ReadLine(), out num_Hour);

            string periodDay = "morning";
            if (num_Hour >= 12)
            {
                periodDay = "evening";
            }

            string nameDay = nameDayList[num_Week - 1];

            if ((num_Week == 6) || (num_Week == 7))
            {
                Console.WriteLine($"Good {periodDay}, it is lovely {nameDay} today. Weekend is here ! ");
            }
            else
            {
                int beforeWE = 0;
                switch (nameDay)
                {
                    case "Monday":
                        beforeWE = 5;
                        break;
                    case "Tuesday":
                        beforeWE = 4;
                        break;
                    case "Wednesday":
                        beforeWE = 3;
                        break;
                    case "Thursday":
                        beforeWE = 2;
                        break;
                    case "Friday":
                        beforeWE = 1;
                        break;

                }
                Console.WriteLine($"Good {periodDay},it is lovely {nameDay} today. Weekend is coming in {beforeWE} days");
            }



        }
    }
}
