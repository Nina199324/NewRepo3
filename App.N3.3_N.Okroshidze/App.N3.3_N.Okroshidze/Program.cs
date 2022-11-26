using System;
using System.Text;
using System.Threading.Tasks;

//3.3 Შემოდის გამოსახულება სტრინგის სახით. დაწერეთ პროგრამა რომელიც ამ გამოსახულების შედეგს გამოთვლის (არითმეტიკული ოპერაციები ჩავთვალოთ რომ გვაქვს მხოლოდ + - * ) მაგ: “((1 + 2) * (3 + 4)) * (5 * (8 + 9))”

namespace calculator_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int res;
                Console.Write("Enter 1st number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter 2nd number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter symbol(+,-,*):");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Answer is:" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Answer is:" + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Answer is:" + res);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.ReadLine();
                Console.Write("Gsurt Gagrdzeleba? (y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }
    }

}