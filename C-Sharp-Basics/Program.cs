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
            GenericList<int> genericList = new GenericList<int>();
            genericList.Add(10);
            genericList.Add(20);
            genericList.Add(30);
            genericList.PrintList();
            var newGenericList = new GenericList<string>();
            newGenericList.Add("Sayan");
            newGenericList.Add("Riya");
            newGenericList.PrintList();
            
        }
    }

}
