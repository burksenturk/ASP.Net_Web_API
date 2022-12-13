using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyim Ekleme"; //viewbag ile gönderdiğimiz değer sayfaya aktarılır. istenilen yerde kullanılır.
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Ekleme";

            var values = experienceManager.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Deneyim Paneli";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Paneli";
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            ViewBag.v1 = "Deneyim Paneli";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Paneli";

            ExperienceValidator validations = new ExperienceValidator();
            ValidationResult results = validations.Validate(experience);

            if (results.IsValid)
            {
                experienceManager.TAdd(experience);
                return RedirectToAction("Index"); //ekledikten tekrar listelenmesini istediğimiz için redirect yaptık.
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError
                        (item.PropertyName, item.ErrorMessage);
                }
            }


            return View();
        }

        public IActionResult DeleteExperience(int id)
        {

            var values = experienceManager.TGetByID(id);
            experienceManager.TDelete(values);
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.v1 = "Deneyim Güncelle";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Güncelle";

            var values = experienceManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            ViewBag.v1 = "Deneyim Güncelle"; 
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Güncelle";

            ExperienceValidator validations = new ExperienceValidator();
            ValidationResult results = validations.Validate(experience);

            if (results.IsValid)
            {
                experienceManager.TUpdate(experience);
                return RedirectToAction("index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError
                        (item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

    }
}