using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TextFind.Models;
using TextFind.Services;

namespace TextFind.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITextFindService _textFindService;

        public HomeController(ITextFindService textFindService) => _textFindService = textFindService;

        public IActionResult Index(TextFindViewModel model)
        {
            if (!string.IsNullOrEmpty(model.Text) && !string.IsNullOrEmpty(model.SubText))
            {
                model.Results = _textFindService.FindSubString(model.Text, model.SubText);
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
