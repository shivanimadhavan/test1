using System;
using System.Collections.Generic;
using System.Text;

namespace Assesment3
{
    class Question4
    {
        public static void Main()
        {
            Console.WriteLine("Enter the numbers");
            var numbers = new List<int>(Convert.ToInt32(Console.ReadLine()));
            int input = Convert.ToInt32(Console.ReadLine());
            while (input != 0)
            {
                if (input > 0)
                    numbers.Add(input);
                input = Convert.ToInt32(Console.ReadLine());

            }
            numbers.Sort();
            foreach (var item in numbers)

            {
                Console.WriteLine(item);
            }
        }
    }
}