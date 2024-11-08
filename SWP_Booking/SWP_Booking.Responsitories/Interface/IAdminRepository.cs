using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Repositories.Interface
{
    public interface IAdminRepository
    {
        Task<List<Entities.Admin>> GetAdminsAsync();
        Task<Entities.Admin> GetAdminByIdAsync(int id);
        Task<Entities.Admin> AddAdminAsync(Entities.Admin admin);
        Task<Entities.Admin> UpdateAdminAsync(Entities.Admin admin);
        Task DeleteAdminAsync(int id);
    }
}
