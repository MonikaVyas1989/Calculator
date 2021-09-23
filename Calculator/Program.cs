using System;

namespace Calculator
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
                Console.WriteLine("Please enter number from Menu which math operation do you want..");
                int p = Convert.ToInt32(Console.ReadLine());
                switch (p)
                {
                    case 1:

                        Addition();
                        break;
                    case 2:
                        Subtraction();
                        break;
                    case 3:
                        Multiplication();
                        break;
                    case 4:
                        Division();
                        break;
                    case 5:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("It is an invalid number please choose number from Menu");
                        break;


                }


            }
        }
            static void Addition()
            {
                int i, j;
                Console.WriteLine("Enter First value:");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second value:");
                j = Convert.ToInt32(Console.ReadLine());

                int add = i + j;
                Console.WriteLine("Addition::" + add);

                
            }

            static void Subtraction()
            {
                int a, b;
                Console.WriteLine("Enter First value:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second value:");
                b = Convert.ToInt32(Console.ReadLine());

                int sub = a - b;
                Console.WriteLine("Substraction::" + sub);


            }
            static void Multiplication()
            {
                int r, k;
                Console.WriteLine("Enter First value:");
                r = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second value:");
                k = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Multiplication::" + r*k);


            }
            static void Division()
            {
                int c, d;
                Console.WriteLine("Enter First value:");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second value:");
                d = Convert.ToInt32(Console.ReadLine());

                if (d == 0)
                {
                    Console.WriteLine("Value cannot be devide by 0....");

                    Console.WriteLine("Enter First value:");
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second value:");
                    d = Convert.ToInt32(Console.ReadLine());

                   
                    Console.WriteLine("Division::" + c/d);


                }
                else
                {
                   
                    Console.WriteLine("Division::" + c/d);
                }

            }

            

        
    }
}