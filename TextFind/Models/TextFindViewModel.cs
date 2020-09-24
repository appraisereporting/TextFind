using System.Collections.Generic;

namespace TextFind.Models
{
    public class TextFindViewModel
    {
        public string Text { get; set; }
        public string SubText { get; set; }
        public IEnumerable<int> Results { get; set; } = new List<int>();
    }
}