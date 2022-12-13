using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAboutDal : IGenericDal<About>
    {
        //void Insert(About p); // p yi about için referans olarak kullanılır.
        //void Update(About p);
        //void Delete(About p);

        //List<About> GetList();

    }
}
