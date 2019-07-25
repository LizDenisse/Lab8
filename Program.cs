using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    class Program
    {
        //Task: Write a program that will recognize invalid inputs when the user requests
        //information about students in a class.

        static void Main(string[] args)
        {
            List<string> lastName = LastNames();
            List<string> hometown = Hometown();
            List<string> food = Food();
            List<string> name = Names();

            string s;
            int sNum;
      

            bool repeatProgram = true;

            try
            {
                while (repeatProgram)

            {
   
                    s = RequestStudentNumber();
                    sNum = int.Parse(s);
            

                if (sNum <= name.Count - 1 && sNum >= 1)
                    {
                        Console.WriteLine("Student {0} is {1} {2} What would you like to know about {1}?", sNum, name[sNum], lastName[sNum]);

                        bool moreStudentInfo = true;
                        while (moreStudentInfo)
                        {
                            Console.WriteLine("Enter or “Hometown” or “favorite food", sNum, name[sNum], lastName[sNum]);
                            string thing = Console.ReadLine();
                            string moreInfo = thing.ToLower();

                            if (moreInfo == "hometown")
                            {
                                Console.WriteLine("{0} is from {1}. ", name[sNum], hometown[sNum]);

                            }

                            else if (moreInfo == "food" || moreInfo == "favorite food")
                            {
                                Console.WriteLine("{0}'s Favorite Food is {1} ", name[sNum], food[sNum]);

                            }
                            else
                            {
                                Console.WriteLine(" Invalid Entry");
                                moreInfo = Console.ReadLine();
                            }
                            Console.WriteLine("Do you want to know more about {0} ?  ", name[sNum]);
                            string again = Console.ReadLine();
                            while (again != "n" && again != "N" && again != "y" && again != "Y")
                            {
                                Console.WriteLine("Invalid Entry, try Y or N");
                                again = Console.ReadLine();
                            }
                            if (again == "N" || again == "n")
                            {
                                moreStudentInfo = false;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry");
                    }
                    Console.WriteLine(" Do you want to search another student");
                    string repeat = Console.ReadLine();
                    while (repeat != "n" && repeat != "N" && repeat != "y" && repeat != "Y")
                    {
                        Console.WriteLine("Invalid Entry. it myst be N/Y");
                        repeat = Console.ReadLine();
                    }

                    if (repeat == "n" || repeat == "N")
                    {
                        Console.WriteLine("Good Bye");
                        repeatProgram = false;
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());

            }
        }

        public static string RequestStudentNumber()
        {

           List<string> name = Names();
            Console.WriteLine(" Which student would you like to learn more about? (enter anumber 1 - {0}):", name.Count - 2);
            try
            {
                string s = Console.ReadLine();
               
                return s;
            }
            catch (FormatException)
            {
                return "Entry is not an intiger";
            }
        }
        public static List<string> Names()
        {
            List<string> studenName = new List<string>();
            studenName.Add("Invalid");
            studenName.Add("Dakota");
            studenName.Add("Joshua");
            studenName.Add("Tommy");
            studenName.Add("James");
            studenName.Add("Maricela");
            studenName.Add("KimVy");
            studenName.Add("Sam");
            studenName.Add("Cody");
            studenName.Add(" Manik");
            studenName.Add("Moise");
            studenName.Add("Liz");
            studenName.Add("Jason");
            studenName.Add("Robert");
            return studenName;
        }
        public static List<string> LastNames()
        {
            List<string> studentLastNames = new List<string>();

            studentLastNames.Add("Invalid");
            studentLastNames.Add("Slabbekorn");
            studentLastNames.Add("Bultsma");
            studentLastNames.Add("Waalkes");
            studentLastNames.Add("Dockery");
            studentLastNames.Add("Rivera");
            studentLastNames.Add("Nguyen");
            studentLastNames.Add("Thomson");
            studentLastNames.Add("Shanley");
            studentLastNames.Add("Nath");
            studentLastNames.Add("Ingabire");
            studentLastNames.Add("Hitches");
            studentLastNames.Add("Speet");
            studentLastNames.Add("Freihaut");

            return studentLastNames;
        }

        public static List<string> Hometown()
        {
            List<string> studentHome = new List<string>();

            studentHome.Add("Invalid");
            studentHome.Add("Kent City");
            studentHome.Add("Grand Rapids");
            studentHome.Add("Releigh NC");
            studentHome.Add("Grand Rapids");
            studentHome.Add("Morelia Mexico");
            studentHome.Add("Grand Rapdis");
            studentHome.Add("Grand Rapids");
            studentHome.Add("Lawton, MI");
            studentHome.Add("Cox'sBazar Bangladesh");
            studentHome.Add("Grand Rapids");
            studentHome.Add("Planet Earth");
            studentHome.Add("Holland");
            studentHome.Add("Detroit");

            return studentHome;
        }

        public static List<string> Food()
        {
            List<string> studentFood = new List<string>();

            studentFood.Add("Invalid");
            studentFood.Add("Pho");
            studentFood.Add("Cheese Tortellini");
            studentFood.Add("Chicken Cirry");
            studentFood.Add("Cheeseburchers/Frenchfries");
            studentFood.Add("Tacos");
            studentFood.Add("Suchi");
            studentFood.Add("Tacos");
            studentFood.Add("Potato Soup");
            studentFood.Add("Spicy Beef Curry");
            studentFood.Add("Lasagna");
            studentFood.Add("Smoked Salmon");
            studentFood.Add("Burgers");
            studentFood.Add("Burgers");

            return studentFood;
        }
    }

}
