using System.Collections.Generic;

namespace TextFind.Models
{
    public class TextFindViewModel
    {
        public string Text { get; set; }
        public string SubText { get; set; }
        public List<int> Results { get; set; }
    }
}