using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]  //Kullanıcı Login olmadan bu sayfa açılmaz o yüzden bu kodu yazıyoruz
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
