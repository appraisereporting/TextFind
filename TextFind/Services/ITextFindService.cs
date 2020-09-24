using System.Collections.Generic;

namespace TextFind.Services
{
    public interface ITextFindService
    {
        IReadOnlyList<int> FindSubString(string text, string subText, bool caseInsentitiveSearch);
    }
}
