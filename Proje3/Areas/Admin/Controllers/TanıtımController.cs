using Microsoft.AspNetCore.Mvc;
using Repository.Entities;
using Services.Interfaces;

namespace Proje3.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]")]
	public class TanıtımController : Controller
	{
		ITanıtımService _itanıtımService;

        public TanıtımController(ITanıtımService itanıtımService)
        {
            _itanıtımService = itanıtımService;
        }

        public IActionResult ListTanıtım()
		{
			var model = _itanıtımService.GetList().Data;
			return View(model);
		}
		[HttpGet]
		public IActionResult AddTanıtım()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddTanıtım(Tanıtım tanıtım)
		{
			_itanıtımService.Add(tanıtım);
			return RedirectToAction("ListTanıtım");
		}

        [HttpGet]
        public IActionResult EditTanıtım(int id)
        {
			var values = _itanıtımService.GetById(id).Data;
            return View(values);
        }
        [HttpPost]
        public IActionResult EditTanıtım(Tanıtım tanıtım)
        {
            _itanıtımService.Update(tanıtım);
            return RedirectToAction("ListTanıtım");
        }

        public IActionResult DeleteTanıtım(Tanıtım tanıtım)
        {
            _itanıtımService.Remove(tanıtım);
            return RedirectToAction("ListTanıtım");
        }
    }
}
