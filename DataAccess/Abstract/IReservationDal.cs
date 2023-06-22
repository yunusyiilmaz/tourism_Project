using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IReservationDal:IGenericDal<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitAprroval(int id);
        List<Reservation> GetListWithReservationByWaitAccepted(int id);
        List<Reservation> GetListWithReservationByWaitPrevious(int id);
        List<Reservation> GetListWithReservation(int id);
        void Approve(int id);
        void Denied(int id);
    }
}
