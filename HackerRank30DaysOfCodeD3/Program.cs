using System;

namespace HackerRank30DaysOfCodeD3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bizden istediği şey n tekse ve 6 ila 20 arasındaysa ekrana weird yazsın. Değilse Not Weird yazsın.

            int N = Convert.ToInt32(Console.ReadLine().Trim());

            if (N % 2 == 1 || (N >= 6 && N <= 20))
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
