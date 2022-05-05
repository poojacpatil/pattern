using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class homework1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of star");
            int row =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of star");
            int col=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
