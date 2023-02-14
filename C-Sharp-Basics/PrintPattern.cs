using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics
{
    class PrintPattern
    {
        public void Pyramid(int n)
        {
            int noOfSpaces = n - 1;
            int noOfStars = 1;
            for (int line = 0; line < n; line++)
            {
                for (int i = 0; i < noOfSpaces; i++)
                {
                    Console.Write(" ");
                }
                noOfSpaces--;
                for (int i = 0; i < noOfStars; i++)
                {
                    Console.Write("*");
                }
                noOfStars += 2;
                Console.WriteLine();
            }
        }
        public void ReversePyramid(int n)
        {
            int noOfSpaces = 0;
            int noOfStars = 2*n - 1;
            for (int line = 0; line < n; line++)
            {
                for (int i = 0; i < noOfSpaces; i++)
                {
                    Console.Write(" ");
                }
                noOfSpaces++;
                for (int i = 0; i < noOfStars; i++)
                {
                    Console.Write("*");
                }
                noOfStars -= 2;
                Console.WriteLine();
            }

        }
    }
}
