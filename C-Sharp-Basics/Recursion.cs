using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics
{
    class Recursion
    {
        public static void printAllSubstring(string s, int start, int end)
        {
            if (start == end)
            {
                Console.WriteLine(s.Substring(start, 1));
                return;
            }
            Console.WriteLine(s.Substring(start, end - start + 1));
            printAllSubstring(s, start, end - 1);
            printAllSubstring(s, start + 1, end);
        }
        public static bool checkPalindrome(string s,int start,int end)
        {
            if(s[start] != s[end])
            {
                return false;
            }
            else if(start >= end)
            {
                return true;
            }
            else
            {
                return checkPalindrome(s, start + 1, end - 1);
            }
        }
    }
}
