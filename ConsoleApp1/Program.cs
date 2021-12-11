using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Step1:

            Console.WriteLine("Select operator:+,-./,*");

            string z = Console.ReadLine();


            switch (z)

            {
                case "+":

                    double Result;
                    Console.Write("Type 1st numbers: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Type 2nd numbers: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Result = Plus(num1,num2);
                    Console.WriteLine(Result);

                    break;

                case "-":
                    
                    Console.Write("Type 1st numbers: ");
                    double num3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Type 2nd numbers: ");
                    double num4 = Convert.ToDouble(Console.ReadLine());
                    Result = Minus(num3, num4);
                    Console.WriteLine(Result);

                    break;

                case "*":
                    Console.Write("Type 1st numbers: ");
                    double num5 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Type 2nd numbers: ");
                    double num6 = Convert.ToDouble(Console.ReadLine());
                    Result = Mult(num5, num6);
                    Console.WriteLine(Result);


                    break;

                case "/":

                step2:

                    Console.Write("Type 1st numbers: ");
                    double num7 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Type 2nd numbers: ");

              
                    double num8 = Convert.ToDouble(Console.ReadLine());

                    if (num8 != 0)


                    {
                        Result = Div(num7, num8);
                        Console.WriteLine(Result);
                    }
                    else
                    {
                        Console.WriteLine("dont use 0");
                        goto step2;
                    }
                   


                    break;
                default:
                    Console.WriteLine("try again");
                    goto Step1;
            }


        }

        static double Plus(double a, double b)
        {


            double result = a + b;

            return result;






        }
        static double Minus(double c, double d)
        {

            double result = c - d;

            return result;


        }
        static double Mult(double e, double f)
        {


            double result = f * e;

            return result;

        }
        static double Div(double g, double h)
        {


          double result = g / h;

   
          
    
          return result;
            

        }
    }
}


