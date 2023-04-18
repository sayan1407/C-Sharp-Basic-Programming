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
            List<Student> students = new List<Student>();
            List<Stream> streams = new List<Stream>()
            {
                new Stream(){ ID = 1, Name = "CSE"},
                new Stream(){ ID = 2, Name = "IT"},
                new Stream(){ ID = 3, Name = "EE"}
            };
            students.Add(new Student()
            {
                ID = 1,
                City = "Kolkata",
                Stream_Id = 1,
                Marks = 100
            });
            students.Add(new Student()
            {
                ID = 2,
                City = "Kolkata",
                Stream_Id =2,
                Marks = 65
            });
            students.Add(new Student()
            {
                ID = 3,
                City = "Mumbai",
                Stream_Id = 1,
                Marks = 80
            });
            students.Add(new Student()
            {
                ID = 4,
                City = "Dehli",
                Stream_Id = 3,
                Marks = 92
            });
            students.Add(new Student()
            {
                ID = 5,
                City = "Mumbai",
                Stream_Id = 2,
                Marks = 71
            });
            //var studentGroupByCity = students.GroupBy(s => s.City);
            //foreach(var group in studentGroupByCity)
            //{
            //    Console.Write("City : "+group.Key+" ");
            //    Console.Write("Total Students : "+group.Count()+ " ");
            //    Console.Write("Student IDs : ");
            //    foreach(var student in group)
            //        Console.Write(student.ID+" ");
            //    Console.WriteLine();
            //}
            var studentGroupByStream = streams.GroupJoin(students, a => a.ID, b => b.Stream_Id, (stream, student) => new
            {
                StreamName = stream.Name,
                Students_Count = student.Count()

            });
            //foreach(var group in studentGroupByStream)
            //{
            //    Console.Write(group.StreamName+ " ");
            //    foreach(var s in group.Students)
            //    {
            //        Console.Write(s.ID + " ");
            //    }
            //    Console.WriteLine();
            //}
            LINQPractice.NthHighestMarks(students, 4);
            Console.WriteLine(LINQPractice.ConvetListToString(new List<string>() { "Sayan", "Riya", "Prabir" }));
            LINQPractice.CountFileByExtension(@"C:\Users\Sayan\Desktop");
        }
    }

}
