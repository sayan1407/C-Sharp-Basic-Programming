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
            // HackerRankSolution.SimpleTextEditor();
            //int n = HackerRankSolution.squares(16, 25);
            int fine = HackerRankSolution.libraryFineManual(5, 3, 2019, 6, 3, 2018);
            Console.WriteLine(fine);
            
        }
    }

}
