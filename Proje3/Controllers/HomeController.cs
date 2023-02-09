using Microsoft.AspNetCore.Mvc;
using Proje3.Models;
using Services.Interfaces;
using System.Diagnostics;

namespace Proje3.Controllers
{
	public class HomeController : Controller
	{
		ITanıtımService _İtanıtımService;
        INotlarService _inotlarService;

        public HomeController(ITanıtımService itanıtımService, INotlarService inotlarService)
        {
            _İtanıtımService = itanıtımService;
            _inotlarService = inotlarService;
        }

        public IActionResult Index()
		{
			var model = _İtanıtımService.GetList().Data;
			return View(model);
		}

        public IActionResult Notlar()
        {
            var model = _inotlarService.GetList().Data;
            return View(model);
        }


    }
}