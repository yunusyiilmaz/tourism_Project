using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public List<ContactUs> GetListCountactByFalse()
        {
            return _contactUsDal.TGetListCountactByFalse();
        }

        public List<ContactUs> GetListCountactByTrue()
        {
            return _contactUsDal.TGetListCountactByTrue();
        }

        public void TAdd(ContactUs t)
        {
            _contactUsDal.Insert(t);
        }

        public void TContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactUs t)
        {
            _contactUsDal.Delete(t);
        }

        public ContactUs TGetByID(int id)
        {
           return _contactUsDal.GetByID(id);
        }

        public List<ContactUs> TGetList()
        {
            return _contactUsDal.GetList();
        }

        public void TUpdate(ContactUs t)
        {
            _contactUsDal.Update(t);
        }
    }
}
