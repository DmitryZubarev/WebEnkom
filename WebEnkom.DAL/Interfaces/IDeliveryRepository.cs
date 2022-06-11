﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebEnkom.Domain.Entity;

namespace WebEnkom.DAL.Interfaces
{
    public interface IDeliveryRepository : IBaseRepository<Delivery>
    {
        Delivery GetByArea(string name);
    }
}
