using Core_Proje.Areas.Customer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Customer.Controllers
{
    //Eğer area kullanıyorsak sayfanın controller bölümünde attribute routing yapılmalı ve hangi area kullanılıyorsa belirtilmelidir
    //Ayrıca area eklerken areanın ScaffoldingReadMe sayfasında vermiş olduğu routing kodunu startup içindeki routing alanına eklemeliyiz
    [Area("Customer")]
    [Route("Customer/[Controller]/[Action]")]  //Attribute Routing yapıyoruz, Area kullandığımız için çalıştığımız sayfaların başına customer ekledik
    public class RegisterController : Controller
    {

        //UserManager classı İdentity paketiyle geldi
        private readonly UserManager<CustomerUser> _userManager;

        public RegisterController(UserManager<CustomerUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid)
            {

                CustomerUser w = new CustomerUser()
                {
                    Name = p.Name,
                    SurName = p.SurName,
                    Email = p.Mail,
                    UserName = p.UserName,
                    ImageURL = p.ImageURL
                };

                var result = await _userManager.CreateAsync(w, p.Password);  //Bu kodu yeni bir kullanıcı oluşturmak için yazdık

                if(result.Succeeded)
                {
                    return RedirectToAction("index", "login");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }
    }
}
