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
            PrintPattern printPattern = new PrintPattern();
            Console.WriteLine("Enter the no. of lines : ");
            int noOfLines = Convert.ToInt32(Console.ReadLine());
            printPattern.Pyramid(noOfLines);
            printPattern.ReversePyramid(noOfLines);
        }
    }

}
