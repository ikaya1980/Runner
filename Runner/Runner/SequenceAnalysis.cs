using System;
using System.Collections.Generic;
using System.Globalization;

namespace Runner
{
    public class SequenceAnalysis
    {
        public string GetSequenceAnalysis(string input, IFormatProvider formatProvider)
        {
            List<char> upperCaseList = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (char.IsUpper(ch))
                    upperCaseList.Add(ch);

            }

            upperCaseList.Sort(delegate (char char1, char chae2)
            {
                return String.Compare(char1.ToString(), chae2.ToString(), false, formatProvider as CultureInfo);
            });

            return new string(upperCaseList.ToArray());
        }
    }
}
