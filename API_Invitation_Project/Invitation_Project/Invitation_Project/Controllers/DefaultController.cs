using Invitation_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Invitation_Project.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult InvitationForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InvitationForm(InvitationModel model)  //sanal veri tabanı oluşturduk, kullanıcı formu doldurunca bilgi buraya gelecek
        {
            if (ModelState.IsValid)
            {
                VirtualDatabase.Add(model);
                return View("Thanks", model); //eklendikten sonra teşekkürler viewine gider
            }
            return View(model);
        }

        [ChildActionOnly]
        //Katılanlar sayfada isim olarak gösterilecek, çağrıldığı her yerde katılanlar listesinin eklendiği bir partial view oluşturuyoruz
        public ActionResult Katilanlar()
        {
            return PartialView(VirtualDatabase.List.Where(i => i.KatilmaDurumu == true)); //sadece katılma durumu true olanlar gösterilecek
        }
    }
}