using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Yetenek Paneli";  //ViewBag ile gönderdiğimiz değer sayfaya aktarılır, istenilen yerde kullanılır.
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Paneli";

            var values = skillManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.v1 = "Yetenek Ekleme";  //ViewBag ile gönderdiğimiz değer sayfaya aktarılır, istenilen yerde kullanılır.
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Ekleme";

            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            ViewBag.v1 = "Yetenek Paneli";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Paneli";

            SkillValidator validations = new SkillValidator();
            ValidationResult results = validations.Validate(skill);

            if (results.IsValid)
            {
                skillManager.TAdd(skill);
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
        public IActionResult DeleteSkill(int id)
        {
            var values = skillManager.TGetByID(id);
            skillManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            ViewBag.v1 = "Yetenek Güncelleme";  //ViewBag ile gönderdiğimiz değer sayfaya aktarılır, istenilen yerde kullanılır.
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Güncelleme";
            var values = skillManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            ViewBag.v1 = "Yetenek Güncelle";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Güncelle";

            SkillValidator validations = new SkillValidator();
            ValidationResult results = validations.Validate(skill);

            if (results.IsValid)
            {
                skillManager.TUpdate(skill);
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
