using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
   public interface IContactUsDal : IGenericDal<ContactUs>
    {
        List<ContactUs> TGetListCountactByTrue();
        List<ContactUs> TGetListCountactByFalse();
        void ContactUsStatusChangeToFalse(int id);
    }
}
