using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;

namespace Core_Proje.ViewComponents.Message
{
    public class SendMessage : ViewComponent
    {
        MessageManager MessageManager = new MessageManager(new EfMessageDal());
        //public IViewComponentResult Invoke()
        //{
        //    var values = MessageManager.TGetList();
        //    return View(values);
        //}

        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
