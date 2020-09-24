using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TextFind.Models
{
    public class TextFindViewModel
    {
        [Display(Name = "Text")]
        [Required]
        public string Text { get; set; } = "";
        
        [Display(Name = "SubText")]
        [Required]
        public string SubText { get; set; } = "";
        
        [Display(Name = "Case Insensitive Search")]
        public bool CaseInsentitiveSearch { get; set; } = false;

        [Display(Name = "Search Results")]
        public IReadOnlyList<int> Results { get; set; } = new List<int>();
    }
}