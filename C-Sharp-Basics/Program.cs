using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first binary number : ");
            long num1 = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter second binary number : ");
            long num2 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Sum of twwo binary number is : " + BasicProgram.sumOfBinaryNums(num1, num2));


        }
    }

}
