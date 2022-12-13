using Core_Proje.Areas.Customer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Route("Customer/[Controller]/[Action]")]

    public class LoginController : Controller
    {
        //signInManager, identity ile beraber gelen login classıdır. Entity değer olarak CustomerUserdan gelen propertyleri veriyoruz bunu da _signInManager fieldine atıyoruz

        private readonly SignInManager<CustomerUser> _signInManager;

        public LoginController(SignInManager<CustomerUser> signInManager)
            //LoginController dan ctrl+. ile generate constructure yoluyla dependency injection yaptık ve signinmanager classını field
        {
            _signInManager = signInManager;
        }
        [HttpGet]



        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Index(UserLoginViewModel p)
        {
            var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, true, true);

            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }
            else
            {
                ModelState.AddModelError("", "Hatalı Kullanıcı adı ya da Şifre girdiniz");
            }

            return View();

        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
