using System;

namespace Cirok__test1
{
    class program
    {

        static void Main(string[] args)
        {
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PowerOfTwo(Convert.ToInt32(Console.ReadLine())));
        }

        static int PowerOfTwo(int n)
        {
            int result = n * n;
            return result;

        }

    }
}

    
      
