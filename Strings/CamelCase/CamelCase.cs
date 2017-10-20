using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelCase
{
    class CamelCase
    {
        static int CountWords(string s)
        {
            char[] charArr = s.ToCharArray();
            int wordCount = 0;
            if (s.Length > 0)
            {
                wordCount++;
            }
            foreach (char c in charArr)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    wordCount++;
                }
            }
            return wordCount;
        }
        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            do
            {
                Console.WriteLine(CountWords(s));
            }
            while ((s = Console.ReadLine()) != "");
        }
    }
}
