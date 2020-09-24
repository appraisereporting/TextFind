using System.Collections.Generic;

namespace TextFind.Models
{
    public class TextFindViewModel
    {
        public string Text { get; set; } = "";
        public string SubText { get; set; } = "";
        public bool CaseInsentitiveSearch { get; set; } = false;
        public IReadOnlyList<int> Results { get; set; } = new List<int>();
    }
}