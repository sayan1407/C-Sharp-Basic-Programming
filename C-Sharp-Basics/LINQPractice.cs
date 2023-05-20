using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C_Sharp_Basics
{
    
    public class LINQPractice
    {
        // Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query
        public static List<int> GetPositiveNumsFromList(List<int> Numbers)
        {
            List<int> listOfPositiveNums = Numbers.Where(n => n > 0).ToList();
            return listOfPositiveNums;
        }
        //Write a program in C# Sharp to find the number of an array and the square of each number
        public static List<int> GetSquareOfNums(List<int> Numbers)
        {
            List<int> listOfSquares =  new List<int>();
            Numbers.ForEach(n => listOfSquares.Add(n*n));
            return listOfSquares;
        }
        //Write a program in C# Sharp to display the number and frequency of number from giving array
        public static int CountFrequencyOfNumber(List<int> Numbers,int n)
        {
            
            int count = Numbers.Count(num => num == n);
            return count;
        }
        public static int CountFrequencyOfChar(string s, char c)
        {
            int count = s.Count(ch => ch == c);
            return count;
        }
        public static string ConvetListToString(List<string> list)
        {
          return string.Join(",", list);
        }
        public static void NthHighestMarks(List<Student> students,int n)
        {
            if (n > students.Count)
                throw new IndexOutOfRangeException("Not many students are present");
            students = students.OrderByDescending(s => s.Marks).ToList();
          
            List<int> studentIds = students.Where(s => s.Marks == students[n - 1].Marks).Select(s => s.ID).ToList();
            foreach(int id in studentIds)
                 Console.WriteLine(id);

        }
        public static void CountFileByExtension(string path)
        {
            
          string[] Files =   Directory.GetFiles(path);
            var FilesGroupByExt = Files.GroupBy(f => f.Substring(f.IndexOf('.')));
            foreach(var fileGroup in FilesGroupByExt)
            {
                Console.WriteLine("Extension : " + fileGroup.Key);
                Console.WriteLine("File Name: ");
                foreach(var file in fileGroup)
                {
                    Console.WriteLine(Path.GetFileName(file));
                }
                Console.WriteLine("Total Count: "+fileGroup.Count());

            }

        }
        public void Joins()
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
                Stream_Id = 2,
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
