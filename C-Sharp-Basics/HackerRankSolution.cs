using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics
{
    public class HackerRankSolution
    {
        public static void SimpleTextEditor()
        {
            int numOfOps = Convert.ToInt32(Console.ReadLine());
            string str = string.Empty;
            Stack<string> stack = new Stack<string>();
            LinkedList<int> linkedList = new LinkedList<int>();
            for (int i =0; i < numOfOps;i++)
            {
                string temp = Console.ReadLine();
                int operationType;
                string inputParameter = string.Empty;
                string[] inputs = temp.Split(' ');
                operationType = Convert.ToInt32(inputs[0]);
                if(operationType != 4)
                    inputParameter = inputs[1];

              
                switch (operationType)
                {
                    case 1:
                        stack.Push(str);
                        str = string.Concat(str, inputParameter);
                        break;
                    case 2:
                        stack.Push(str);
                        str = str.Remove(str.Length - Convert.ToInt32(inputParameter));
                        break;
                    case 3:
                        Console.WriteLine(str[Convert.ToInt32(inputParameter) - 1]);
                        break;
                    case 4:
                        str = stack.Pop();
                        break;


                }
                

            }
        }
        //Watson likes to challenge Sherlock's math ability. 
        //He will provide a starting and ending value that describe a range of integers, inclusive of the endpoints. 
        //Sherlock must determine the number of square integers within that range.
        public static int squares(int a,int b)
        {
            int count = 0;
            //Optimal Solution
            int lowerRange = (int)Math.Pow(a, 0.5);
            int upperRange = (int)Math.Pow(b, 0.5);
            count = upperRange - lowerRange;
            if (lowerRange * lowerRange == a)
                count++;
            //Brute-Force Solution
            //for(int i = a;i <= b;i++)
            //{
            //    double squareRoot = Math.Pow(i, 0.5);
            //    int integerValueOfSquareRoot = (int)squareRoot;
            //    if (squareRoot == (double)integerValueOfSquareRoot)
            //        count++;
            //}
            return count;
        }
        public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            DateTime returnDate = new DateTime(y1, m1, d1);
            DateTime dueDate = new DateTime(y2, m2, d2);
            int totalDueDays = (int) (returnDate - dueDate).TotalDays;
            if (totalDueDays <= 0)
                return 0;
            else if (totalDueDays < 30)
                return totalDueDays * 15;
            else if (totalDueDays > 30 && totalDueDays < 365)
                return ((int)totalDueDays / 30) * 500;
            else
                return 10000;

        }
        public static int libraryFineManual(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            if(y1 > y2)
            {
                return 10000;

            }
            else
            {
                if(m2 == m1)
                {
                    if (d1 <= d2)
                        return 0;
                    else
                        return (d1 - d2) * 15;
                }
                else
                {
                        return (m1 - m2) * 500;
                }

            }
            
        }
        //https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem?isFullScreen=true
        public static int beautifulDays(int i, int j, int k)
        {

            int count = 0;
            for(int idx = i; idx <= j;idx++)
            {
                if (Math.Abs(idx - BasicProgram.ReverseNum(idx)) % k == 0)
                    count++;
            }
            return count;
        }
        

    }
}
