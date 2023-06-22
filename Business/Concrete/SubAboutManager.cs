using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAbout;

        public SubAboutManager(ISubAboutDal subAbout)
        {
            _subAbout = subAbout;
        }

        public void TAdd(SubAbout t)
        {
            _subAbout.Insert(t);
        }

        public void TDelete(SubAbout t)
        {
           _subAbout.Delete(t);
        }

        public SubAbout TGetByID(int id)
        {
           return _subAbout.GetByID(id);
        }

        public List<SubAbout> TGetList()
        {
            return _subAbout.GetList();
        }

        public void TUpdate(SubAbout t)
        {
            _subAbout.Update(t);
        }
    }
}
