using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics
{
    public class DelegatePractice
    {
        public delegate int ArithmaticOps(int num1, int num2);
        public int Sum(int a,int b)
        {
            return a+b; 
        }
        public int Subtract(int a,int b)
        {
            return a - b;
        }
        

    }
}
