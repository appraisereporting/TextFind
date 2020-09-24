using System.Collections.Generic;

namespace TextFind.Services
{
    public class TextFindService : ITextFindService
    {
        public IEnumerable<int> FindSubString(string text, string subText)
        {
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