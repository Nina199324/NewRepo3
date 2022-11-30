using System;
using System.Linq;
using System.Collections.Generic;

class Class3
{  //4.1  Დაწერეთ პროგრამა რომელიც მასივში დაითვლის თითოეული ელემენტი რამდენჯერ გვხვდება.

    static void Main(string[] args)
    //    {
    //        int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 4 };
    //        Console.Write("\nLINQ : Display the number and frequency of number from given array : \n");
    //        Console.Write("---------------------------------------------------------------------\n");
    //        Console.Write("The numbers in the array  are : \n");
    //        Console.Write(" 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 4\n");

    //        var n = from x in arr1
    //                group x by x into z
    //                select z;
    //        Console.WriteLine("\nThe number and the Frequency are : \n");
    //        foreach (var arrNo in n)
    //        {
    //            Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
    //        }
    //        Console.WriteLine("\n");
    //    }
    //}

    //4.2 Დაწერეთ პროგრამა რომელიც დაითვლის სტრინგში თითოეული სიმბოლო რამდენჯერ გვხვდება.

    {
        static void Main(string[] args)
        {
            string str;

            Console.Write("\nLINQ : Display the characters and frequency of character from giving string : ");
            Console.Write("\n----------------------------------------------------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            Console.Write("\n");

            var FreQ = from x in str
                       group x by x into y
                       select y;
            Console.Write("The frequency of the characters are :\n");
            foreach (var ArrEle in FreQ)
            {
                Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times");
            }
        }
    }
}