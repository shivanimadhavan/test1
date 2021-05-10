//using System;

//class Program2
//{


//    public static void Main(string[] args)
//    {


//        int a, b, i, j, flag;

//        Console.WriteLine("Enter the small number ");
//        a = int.Parse(Console.ReadLine());

//        Console.WriteLine("\nEnterthe large number ");

//        b = int.Parse(Console.ReadLine());

//        Console.WriteLine("\nPrime numbers between " +
//                          "{0} and {1} are: ", a, b);

//        for (i = a; i <= b; i++)
//        {

//            if (i == 1 || i == 0)
//                continue;

//            flag = 1;

//            for (j = 2; j <= i / 2; ++j)
//            {
//                if (i % j == 0)
//                {
//                    flag = 0;
//                    break;
//                }
//            }

//            if (flag == 1)
//                Console.WriteLine(i);
//        }
//    }
//}