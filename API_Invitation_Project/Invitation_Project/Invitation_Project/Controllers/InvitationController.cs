using Invitation_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Invitation_Project.Controllers
{
    public class InvitationController : ApiController
    {
        [HttpGet]
        public IEnumerable<InvitationModel>GetKatilanlar()
        {
            return (VirtualDatabase.List.Where(i => i.KatilmaDurumu == true));
        }        
        public IEnumerable<InvitationModel> GetKatilmayanlar()
        {
            return (VirtualDatabase.List.Where(i => i.KatilmaDurumu == false));
        }
        [HttpPost] 
        public void PostEkle(InvitationModel model)
        {
            if(ModelState.IsValid)
            {
                VirtualDatabase.Add(model);  //Post metoduyla gelen data eğer tam ise VirtualDatabase e eklenir
            }
        }
    }
}
