using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TextFind.Models;

namespace TextFind.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(TextFindViewModel model)
        {
            if ((model.Text != null) && (model.SubText != null))
            {
                int start = 0;
                int end = model.Text.Length;
                int find = 0;

                while ((start <= end) && (find > -1))
                {
                    find = model.Text.IndexOf(model.SubText, start);
                    if (find != -1)
                    {
                        model.Results.Add(find);

                        //start position moved one character left - repeated characters in subText are valid eg looking for xx in xxx gives two
                        start = find + 1;
                    }
                }
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
