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
    }

}
