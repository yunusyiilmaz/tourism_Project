using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        public void ContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetListCountactByFalse()
        {
            using (var context = new Context())
            {
                return context.ContactUses.Where(x => x.MessageStatus == false).ToList();
            };
        }

        public List<ContactUs> TGetListCountactByTrue()
        {
            using (var context = new Context())
            {
                return context.ContactUses.Where(x => x.MessageStatus == true).ToList();
            };
        }
    }
}
