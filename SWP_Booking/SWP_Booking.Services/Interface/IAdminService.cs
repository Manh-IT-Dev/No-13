﻿using SWP_Booking.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Services.Interface
{
    public interface IAdminService
    {
        Task<List<Repositories.Entities.Admin>> Admins();
    }
}
