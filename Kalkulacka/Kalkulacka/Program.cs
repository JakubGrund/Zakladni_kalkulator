using System;

namespace Kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            //number one
            Console.WriteLine("Write first number and press enter:");
            double number1;

            //while number 1
            while(!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Write first number and press enter:");
            }

            //number two
            Console.WriteLine("Write second number and press enter:");
            double number2;

            //while number two
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Write first number and press enter:");
            }

            //operation
            Console.WriteLine("Choose operation end press enter:");
            Console.WriteLine("\t +");
            Console.WriteLine("\t -");
            Console.WriteLine("\t *");
            Console.WriteLine("\t /");

            string operation = Console.ReadLine();
         
            Console.Write("Result is:");
            switch (operation)
            {
                case "+":
                    Console.WriteLine(number1 + number2);
                    break;
                case "-":
                    Console.WriteLine(number1 - number2);
                    break;
                case "*":
                    Console.WriteLine(number1 * number2);
                    break;
                case "/":
                    while(number2 == 0) //nejde deleni nulou
                    {
                        Console.WriteLine(" Can not divide by 0 " +
                          " write second number again and press enter ");
                        while (!double.TryParse(Console.ReadLine(), out number2))
                        {
                            Console.WriteLine(" Write second number " +
                                " and press enter: ");
                        }
                    }
                    Console.WriteLine(number1 / number2);
                    break;
                    
            }
        }
    }
}
