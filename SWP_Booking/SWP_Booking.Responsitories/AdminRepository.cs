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
        public async Task<List<Admin>> GetAllAdmin()
        {
            try
            {
                return await _dbContext.Admins.Include(a => a.ThongKes).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }
        public async Task<Admin> GetAdminById(int id)
        {
            return await _dbContext.Admins.Include(a => a.ThongKes).FirstOrDefaultAsync(a => a.IdAdmin == id);
        }

        public bool DeleteAdmin(int id)
        {
            try
            {
                var adminToDelete = _dbContext.Admins.Find(id);
                if (adminToDelete != null)
                {
                    _dbContext.Admins.Remove(adminToDelete);
                    return _dbContext.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DeleteAdmin(Admin admin)
        {
            try
            {
                _dbContext.Admins.Remove(admin);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool UpdateAdmin(Admin admin)
        {
            try
            {
                _dbContext.Entry(admin).State = EntityState.Modified;
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        bool IAdminRepository.AddAdmin(Admin admin)
        {
            try
            {
                _dbContext.Admins.Add(admin);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }
    }
}
