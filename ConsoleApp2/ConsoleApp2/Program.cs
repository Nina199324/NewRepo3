using System;
using System.Text;
using System.Threading.Tasks;

namespace calculator_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int cal;
                Console.Write("Enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter symbol(+,-,*):");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        cal = num1 + num2;
                        Console.WriteLine("Addition:" + cal);
                        break;
                    case "-":
                        cal = num1 - num2;
                        Console.WriteLine("Subtraction:" + cal);
                        break;
                    case "*":
                        cal = num1 * num2;
                        Console.WriteLine("Multiplication:" + cal);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.ReadLine();
                Console.Write("Gsurt gagrdzeleba ? (y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }
    }

}
