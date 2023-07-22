using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppTask_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a=int.Parse(Console.ReadLine());
            if(a%2==0 )
            {
                Console.WriteLine("Entered Number is Even");
            }
            else
            {
                Console.WriteLine("Entered number is Odd");
            }
        }
    }
}
