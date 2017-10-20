using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperReducedString
{
    class SuperReducedString
    {
        static string Super_reduced_string(string s)
        {
            if (s == "")
            {
                return "Empty String";
            }
            if (s.Length == 1)
            {
                return s;
            }
            int sameLetters = 1;
            int appendCount = 0;
            var charArray = s.ToCharArray();
            StringBuilder sb = new StringBuilder(s.Length);
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (charArray[i] == charArray[i + 1])
                {
                    sameLetters++;
                }
                else
                {
                    if (sameLetters % 2 == 1)
                    {
                        sb.Append(charArray[i]);
                        appendCount++;
                    }
                    sameLetters = 1;
                }

                if (i + 1 >= s.Length - 1)
                {
                    if (charArray[i] == charArray[i + 1] && sameLetters % 2 == 1)
                    {
                        sb.Append(charArray[i]);
                        appendCount++;
                    }
                    else if (charArray[i] != charArray[i + 1])
                    {
                        sb.Append(charArray[i + 1]);
                        appendCount++;
                    }
                }
            }
            if (sb.ToString().Length == 0)
            {
                return "Empty String";
            }
            else if (appendCount == s.Length)
            {
                return s;
            }
            return Super_reduced_string(sb.ToString());
        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            string result;
            do
            {
                result = Super_reduced_string(s);
                Console.WriteLine(result);
                Console.WriteLine("Press enter key to quit ... ");
            } while ((s = Console.ReadLine()) != "");
        }
    }
}
