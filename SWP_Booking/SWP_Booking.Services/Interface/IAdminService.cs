using SWP_Booking.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Services.Interface
{
    public interface IAdminService
    {
        Task<List<Admin>> GetAllAdmin();
        Task<Admin> GetAdminById(int id);
        Boolean AddAdmin(Admin admin);
        Boolean DeleteAdmin(int id);
        Boolean DeleteAdmin(Admin admin);
        Boolean UpdateAdmin(Admin admin);

    }
}
