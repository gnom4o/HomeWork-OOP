using System;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            string str = Console.ReadLine();

             try
             {
                 int number = int.Parse(str);
                 if (number < 0)
                 {
                     throw new FormatException("Number should be greater than 0");
                 }
                 
                 Console.WriteLine(Math.Sqrt(number));
             }
             catch (FormatException)
             {

                 Console.WriteLine("Invalid Number");
             }
             catch(OverflowException)
             {
                 Console.WriteLine("Invalid Number");
             }
            finally
             {
                 Console.WriteLine("GoodBye");
             }
        }
    }
}
