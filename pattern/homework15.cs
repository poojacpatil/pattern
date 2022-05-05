using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class homework15
    {
        static void Main(string[] args)
        {
            int row =7;
            
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    if(j==1 || j==15 || j==j+2)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            
                    
            }
        }
    }
}
