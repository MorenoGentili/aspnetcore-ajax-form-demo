using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AjaxFormDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AjaxFormDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var inputModel = new TitleEditInputModel { Title = "Il mio titolo" };
            return View(inputModel);
        }

        [HttpPost]
        public IActionResult Edit(TitleEditInputModel inputModel)
        {
            return Json(new { status = "Il nuovo valore è: " + inputModel.Title });
        }

    }
}
