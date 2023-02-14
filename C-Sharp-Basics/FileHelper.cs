using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C_Sharp_Basics
{
    class FileHelper
    {
        public static int GetWordCount(string path)
        {
           //string text = File.ReadAllText(path);
           //string[] splitedText  = text.Split(new char[] { ' ','.'},StringSplitOptions.RemoveEmptyEntries);
           //return splitedText.Count();
           
            //Same Code Using FileInfo class
            FileInfo fi = new FileInfo(path);
            StreamReader sr = fi.OpenText();
            string s = "";
            StringBuilder sb = new StringBuilder("");
            while ((s = sr.ReadLine()) != null)
            {
                sb.Append(s);
            }
            string text = sb.ToString();
            string[] splitedText  = text.Split(new char[] { ' ','.'},StringSplitOptions.RemoveEmptyEntries);
    
            return splitedText.Count();

        }
        public static string WordWithMaxLength(string path)
        {
            string text = File.ReadAllText(path);
            string[] splitedText = text.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            string strMaxLength = "";
            int max = 0;
            foreach(string s in splitedText)
            {
                if (s.Length > max)
                {
                    max = s.Length;
                    strMaxLength = s;
                }

            }
            return strMaxLength;

        }
    }
}
