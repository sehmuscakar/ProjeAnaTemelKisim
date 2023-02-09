using Microsoft.AspNetCore.Mvc;
using Repository.Entities;
using Services.Interfaces;
using Services.Services;
using TechTalk.SpecFlow.Analytics.UserId;

namespace Proje3.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class NotlarController : Controller
    {
        INotlarService _inotlarService;

        public NotlarController(INotlarService inotlarService)
        {
            _inotlarService = inotlarService;
        }

        public IActionResult ListNotlar()
        {
            var model = _inotlarService.GetList().Data;
            return View(model);
        }

        [HttpGet]
        public IActionResult EditNotlar(int id)
        {
            var values = _inotlarService.GetById(id).Data;
            return View(values);

        }

        [HttpPost]
        public IActionResult EditNotlar(Notlar notlar)
        {
            if (notlar.Id == 0)
            {
              //  ViewBag.Durum = "Ekle";
                _inotlarService.Add(notlar);
            }
            else
            {
              //  ViewBag.Durum = "Güncelle";
                _inotlarService.Update(notlar);
            }

            return RedirectToAction("listNotlar");
        }

        public IActionResult DeleteNotlar(Notlar notlar)
        {
            _inotlarService.Remove(notlar);
            return RedirectToAction("listNotlar");
                
        }

      
    }
}
