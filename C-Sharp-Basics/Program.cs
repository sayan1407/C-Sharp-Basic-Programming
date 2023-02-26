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
            //DateTimeHelper dt = new DateTimeHelper(DateTime.Now);
            //Console.WriteLine(dt.Add(10).ToString("MMM dd yyyy"));
            //dt.Compare(new DateTime(2023,03,12));
            //Console.WriteLine(dt.CheckLeapYear(2200));
            //Console.WriteLine(dt.DifferenceInYear(new DateTime(2003, 12, 14)));
            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            //IEnumerable<int> reversearr = arr.Reverse();
            //foreach (int n in reversearr)
            //    Console.Write(n + " ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(BasicProgram.SubtractTwoNumByRecursion(a, b));
            //Console.WriteLine(BasicProgram.MultiplyTwoNumByRecursion(a, b));
            //Console.WriteLine(BasicProgram.DivideTwoNumByRecursion(a, b));
            //Console.WriteLine(new TimeSpan(new DateTime(1,1,1).Ticks).TotalDays/365.25);
        }
    }

}
