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
            string path = @"C:\Users\Sayan\Desktop\Sample.txt";
            int count = FileHelper.GetWordCount(path);
            Console.WriteLine("No of words in the file : {0}", count);
            string word = FileHelper.WordWithMaxLength(path);
            Console.WriteLine("Word with maximum length in the file : {0}", word);
        }
    }
}
