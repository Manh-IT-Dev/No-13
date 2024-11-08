using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Repositories.Interface;

namespace SWP_Booking.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly SwpBookingDbContext _dbContext;

        public AdminRepository(SwpBookingDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Admin> AddAdminAsync(Admin admin)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAdminAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Admin> GetAdminByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Admin>> GetAdminsAsync()
        {
            return await _dbContext.Admins.ToListAsync();
        }

        public Task<Admin> UpdateAdminAsync(Admin admin)
        {
            throw new NotImplementedException();
        }
    }
}
