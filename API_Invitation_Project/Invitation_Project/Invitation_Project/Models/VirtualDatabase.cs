using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Invitation_Project.Models
{
    public static class VirtualDatabase
    {
        private static Dictionary<string, InvitationModel> _list;  //InvitationModel e göre gelen satırı list field olarak kullanacağız

        static VirtualDatabase()
        {
            _list = new Dictionary<string, InvitationModel>();  //Her elemanı Key değeri atamak istediğimiz için Dictionary kullandık

            _list.Add("Ali", new InvitationModel
            {
                Ad = "Ali",
                Eposta = "ali@gmail.com",
                KatilmaDurumu = true

            });
            _list.Add("Abdullah", new InvitationModel
            {
                Ad = "Abdullah",
                Eposta = "abdullah@gmail.com",
                KatilmaDurumu = true

            });
            _list.Add("Batu", new InvitationModel
            {
                Ad = "Batu",
                Eposta = "batu@gmail.com",
                KatilmaDurumu = false

            });
        }
        public static void Add(InvitationModel model)
        {
            string key=model.Ad.ToLower();
            if(_list.ContainsKey(key))  //yukarıda ad alanını key olarak kullandık, aşağıda bu key alanına bakıyoruz eğer varsa eskisi ile yer değiştirir
            {
                _list[key] = model;
            }
            else  //eğer yoksa yeni bir satır oluştur
            {
                _list.Add(key, model);
            }
        }
        public static IEnumerable<InvitationModel>List
        {
            get { return _list.Values; }  //IEnumerable metodu kullanılarak çağrılan kayıt değeri gönderilecek
        }
    }
}