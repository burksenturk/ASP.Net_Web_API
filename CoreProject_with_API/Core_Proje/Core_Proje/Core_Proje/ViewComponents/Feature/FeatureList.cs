using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Feature
{
    public class FeatureList : ViewComponent // Eğer bir projede View Component ile parçalama yapıyorsak, o sayfaya ait bir Companent classı olmalı ve Companent inherit edilmelidir.
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        // Backend işlemlerini gerçekleştirmek için (Listeleme) FeatureManager classını çağırdık.(Newleme)
        public IViewComponentResult Invoke() // Invoke view componente gitmeyi sağlayan metotdur. - Shared  içinde Default.cshtml açılır.
        {
            var values = featureManager.TGetList();
            return View(values); // FeatureManager içindeki GetList metodunu kullanıyoruz ve gelen değeri component çağırılan yere gönderiyoruz.
        }
    }
}
