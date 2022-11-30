using System;
using System.Linq;
//4.4 დაწერეთ პროგრამა რომელიც დააბრუნებს მასივში x-დან y შუალედში ელემენტებს.
class LinqExercise2
{
    static void Main()
    {
        int[] array = {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 ,15, 16, 17, 18, 19
            };

        Console.Write("\nLINQ : *We must find the numbers in the list with range from 1 till 14* ");
        Console.Write(" \n The numbers in the array  are : \n");
        Console.Write(" 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,14,15, 16, 17, 18, 19 \n");
        var nQuery =
        from VrNum in array
        where VrNum > 1
        where VrNum < 14
        select VrNum;
        Console.Write("\nThe numbers within the range from 1 till 14 are : \n");
        foreach (var VrNum in nQuery)
        {
            Console.Write("{0}  ", VrNum);
        }
        Console.Write("\n\n");
    }
}