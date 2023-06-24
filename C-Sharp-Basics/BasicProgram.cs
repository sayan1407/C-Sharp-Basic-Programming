using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics
{

    class BasicProgram
    {
        public static int ReverseNum(int num)
        {
            int revNum = 0;
            while(num > 0)
            {
                revNum = revNum * 10 + (num % 10);
                num = num / 10;
            }
            return revNum;
        }
        public static int sumOfDigit(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum +=  num % 10;
                num = num / 10;
            }
            return sum;
        }
        public static string sumOfBinaryNums(long num1,long num2)
        {
            StringBuilder sum = new StringBuilder();
            long firstDigit, secondDigit,carry = 0,result= 0;
            while(num1 > 0 || num2 > 0)
            {
                firstDigit = num1 > 0 ? num1%10 : 0;
                secondDigit = num2 > 0 ? num2 % 10 : 0;
                if(firstDigit == 0 && secondDigit == 0)
                {

                    result = carry;
                    carry = 0;
                }
                else if(firstDigit == 0 && secondDigit == 1)
                {
                    if(carry == 1)
                    {
                        result = 0;
                        carry = 1;
                    }
                    else
                    {
                        result = 1;
                        carry = 0;
                    }
                }
                else if (firstDigit == 1 && secondDigit == 0)
                {
                    if (carry == 1)
                    {
                        result = 0;
                        carry = 1;
                    }
                    else
                    {
                        result = 1;
                        carry = 0;
                    }
                }
                else if (firstDigit == 1 && secondDigit == 1)
                {
                    if (carry == 1)
                    {
                        result = 1;
                        carry = 1;
                    }
                    else
                    { 
                        result = 0;
                        carry = 1;
                    }
                }
                sum.Append(result.ToString());
                num1 = num1 / 10;
                num2 = num2 / 10;
            }
            if (carry == 1)
                sum.Append("1");

            StringBuilder revSum = new StringBuilder();
            for(int i = sum.Length-1; i >= 0;i--)
            {
                revSum.Append(sum[i]);
            }
            return revSum.ToString();

        }
        public static int AddTwoNumByRecursion(int a,int b)
        {
            if (b == 0)
                return a;
            
            return AddTwoNumByRecursion(a+1, b - 1);

        }
        public static int MultiplyTwoNumByRecursion(int a, int b)
        {
            if (b == 0)
                return 0;
           
            return a + MultiplyTwoNumByRecursion(a, b - 1);

        }
        public static int DivideTwoNumByRecursion(int a, int b)
        {
            if (a == 0)
                return 0;
            
            return 1 + DivideTwoNumByRecursion(a-b, b);

        }
        public static int SubtractTwoNumByRecursion(int a, int b)
        {
            if (b == 0)
                return a;

            return SubtractTwoNumByRecursion(a-1, b-1);

        }
        public static void TossNTimes(int n)
        {
            int totalHead = 0;
            int totalTail = 0;
            int result;
            Random rand = new Random();
            for (int i =0; i < n;i++)
            {
                
                result = rand.Next(2);
                if (result == 0)
                    totalHead++;
                else
                    totalTail++;
            }
            Console.WriteLine("Number of heads : "+totalHead);
            Console.WriteLine("Number of tails : " + totalTail);

        }
        public static int Toss()
        {
            Random rand = new Random();
            int result = rand.Next(2);
            return result;
        }
    }
}
