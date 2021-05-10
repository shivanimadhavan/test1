using System;
using System.Collections.Generic;

namespace Assessment
{
    class Number4
    {
        public static void Main()
        {
#pragma warning disable CS8321 // Local function is declared but never used
            static void SortingUserNum4()
#pragma warning restore CS8321 // Local function is declared but never used
            {
                var NumberList = new List<int>();
                int input = Convert.ToInt32(Console.ReadLine());
                while (input != 0)
                {
                    if (input > 0)
                        NumberList.Add(input);
                    input = Convert.ToInt32(Console.ReadLine());

                }
                NumberList.Sort();
                foreach (var item in NumberList)

                {
                    Console.WriteLine(item);
                }
            }

        }

        private static void CheckUserAndPassword5()
        {
            string name, password;
            int count = 0;
            do
            {
                Console.Write("Enter the Name:");
                name = Console.ReadLine();
                Console.Write("Enter Password: ");
                password = Console.ReadLine();
                if (name != "Admin" || password != "admin")
                    count = count + 1;
                else
                    count = 1;
                Console.Write("Ivalid UserName or Password");
                Console.WriteLine("     ");
            }
            while ((name != "Admin" || password != "admin") && (count != 3));
            if (count == 3)
                Console.Write("You already tried 3 times your account is locked!!!!!!    Please Contact Admin");

            else
                Console.Write("Welcome");
        }

    }
}


       