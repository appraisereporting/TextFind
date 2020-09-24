using System.Collections.Generic;

namespace TextFindLibrary
{
    public interface ITextFindService
    {
        IReadOnlyList<int> FindSubString(string text, string subText, bool caseInsentitiveSearch);
    }
}
