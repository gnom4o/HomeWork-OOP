using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
class EnterNumbers
{
    static void Main()
    {
        int start = 1;
        int end = 20;
        int counter = 0;
        List<int> newList = new List<int>();
        while (counter<10)
        {
            try
            {
                int num = ReadNumber(start, end);
                if(counter!= 0 && num<=newList[counter-1])
                {
                    throw new ArgumentOutOfRangeException("Number is bigger than previous");
                }
                newList.Add(num);
                counter++;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number.Please enter again:");
                
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid Number.Please enter again:");
            }
            catch
            {
                Console.WriteLine("Invalid Number.Please enter again:");
            }
        }
        foreach (var item in newList)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();
    }
    public static int ReadNumber(int start,int end)
    {
                    
            string str = Console.ReadLine();
            int number = int.Parse(str);
            if(number<start || number>end)
            {
                throw new ArgumentOutOfRangeException("Invalid Number");
            }
            return number;
          
    }
}
}
