using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics
{
    public class Student
    {
        public int ID { get; set; }
        public int Stream_Id { get; set; }
        public string City { get; set; }
        public int Marks { get; set; }
    }
    public class Stream
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DelegatePractice delegatePractice = new DelegatePractice();
            DelegatePractice.ArithmaticOps arithmaticOps = delegatePractice.Sum;
            Console.WriteLine(arithmaticOps(10, 5));
            arithmaticOps += delegatePractice.Subtract;
            Console.WriteLine(arithmaticOps(10, 5));
            //Action<int,int> action = delegatePractice.Sum;
            //action += delegatePractice.Subtract;
            //action(10, 5);
            Func<int, int, int> ops = delegatePractice.Subtract;
            Console.WriteLine(ops(10,5));
            ops = delegatePractice.Sum;
            Console.WriteLine(ops(10, 5));

        }
    }

}
