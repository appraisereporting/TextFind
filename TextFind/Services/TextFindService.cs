using System;
using System.Collections.Generic;

namespace TextFind.Services
{
    public class TextFindService : ITextFindService
    {
        public IReadOnlyList<int> FindSubString(string text, string subText)
        {
            //Assumptions
            if (text == null) throw new ArgumentException("text must not be null");
            if (string.IsNullOrEmpty(subText)) throw new ArgumentException("subText must not be null or empty");

            var results = new List<int>(); 
            
            int start = 0;
            int end = text.Length;
            int find = 0;

            while ((start <= end) && (find > -1))
            {
                find = text.IndexOf(subText, start);
                if (find != -1)
                {
                    results.Add(find);

                    //start position moved one character left - repeated characters in subText are valid eg looking for xx in xxx gives two
                    start = find + 1;
                }
            }

            return results;
        }
    }
}