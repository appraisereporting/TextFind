using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TextFind.Models;
using TextFind.Services;

namespace TextFind.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITextFindService _textFindService;

        public HomeController(ITextFindService textFindService)
        {
            _textFindService = textFindService;
        }

        public IActionResult Index(TextFindViewModel model)
        {
            if ((model.Text != null) && (model.SubText != null))
            {
                model.Results = _textFindService.FindSubString(model.Text, model.SubText);
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
