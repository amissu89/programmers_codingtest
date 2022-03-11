using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NumAndWord
{
    class Solution
    {
        public int solution(string s)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"zero",    0 },
                {"one",     1 },
                {"two",     2 },
                {"three",   3 },
                {"four",    4 },
                {"five",    5 },
                {"six",     6 },
                {"seven",   7 },
                {"eight",   8 },
                {"nine",    9 },
            };
            string pattern = "[a-zA-Z]+";
            foreach (Match match in Regex.Matches(s, pattern))
            {
                Console.WriteLine("{0} duplicates {1} at position {2}", match.Value, match.Groups[0].Value, match.Index);
                foreach(KeyValuePair<string, int> item  in dict)
                {
                    string str = match.Value;
                    if(item.Key == str)
                    {

                    }
                }

            }
            int answer = 0;
            return answer;
        }
    }
}
