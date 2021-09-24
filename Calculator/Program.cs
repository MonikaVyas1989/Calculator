using System;

namespace Calculator_Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            Console.WriteLine("*************Calculator***************");
            Console.WriteLine("For Addition Enter number 1");
            Console.WriteLine("For Subtraction Enter number 2");
            Console.WriteLine("For Multiplication Enter number 3");
            Console.WriteLine("For Division Enter number 4");
            Console.WriteLine("For exit from console Enter number 5");
            Console.WriteLine("**************************************");



            while (running)
            {
                try
                {
                    Console.WriteLine("Enter number 1..");
                    var num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter number 2..");
                    var num2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter number from Menu which math operation do you want..");
                    var p = int.Parse(Console.ReadLine());

                    switch (p)
                    {
                        case 1:
                            Addition(num1, num2);
                            break;
                        case 2:
                            Subtraction(num1, num2);
                            break;
                        case 3:
                            Multiplication(num1, num2);
                            break;
                        case 4:
                            Division(num1, num2);
                            break;
                        case 5:
                            running = false;
                            break;

                        default:
                            Console.WriteLine("It is an invalid number please choose number from Menu");
                            break;


                    }
                    Console.Clear();


                }

                catch
                {
                    Console.WriteLine("The value you enterd is not valid");

                }

            }
        }
        static void Addition(double n1, double n2)
        {
            double sum = 0;
            sum = n1 + n2;
            Console.WriteLine("Addition::" + sum);

        }
        static void Subtraction(double n1, double n2)
        {

            double sub = n1 - n2;
            Console.WriteLine("Subtraction::" + sub);

        }
        static void Multiplication(double n1, double n2)
        {

            double mul = n1 * n2;
            Console.WriteLine("Multiplication::" + mul);

        }
        static void Division(double n1, double n2)
        {

            double div = n1 / n2;
            if (n2 == 0)
            {
                Console.WriteLine("Number can not be divided by 0");
            }
            else
            {
                Console.WriteLine("Division::" + div);
            }
        }





    }
}
