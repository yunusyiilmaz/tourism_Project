﻿using Entity;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDestinationService:IGenericService<Destination>
    {
        public Destination TGetDestinationWithGuide(int id);
        public List<Destination> TGetLast4Destinations();
    }
}
