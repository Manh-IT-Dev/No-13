using SWP_Booking.Repositories.Entities;
using SWP_Booking.Repositories.Interface;
using SWP_Booking.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public Task<List<Admin>> GetAllAdmin()
        {
            return _adminRepository.GetAllAdmin();
        }

        public Task<Admin> GetAdminById(int id)
        {
            return _adminRepository.GetAdminById(id);
        }

        public bool AddAdmin(Admin admin)
        {
            return _adminRepository.AddAdmin(admin);
        }

        public bool DeleteAdmin(int id)
        {
            return _adminRepository.DeleteAdmin(id);
        }

        public bool DeleteAdmin(Admin admin)
        {
            return _adminRepository.DeleteAdmin(admin);
        }

        public bool UpdateAdmin(Admin admin)
        {
            return _adminRepository.UpdateAdmin(admin);
        }
    }
}
