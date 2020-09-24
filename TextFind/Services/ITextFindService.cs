using System.Collections.Generic;

namespace TextFind.Services
{
    public interface ITextFindService
    {
        IEnumerable<int> FindSubString(string text, string subText);
    }
}
