using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Repositories
{
    public class ThongKeRepository : IThongKeRepository
    {
        private readonly SwpBookingDbContext _dbContext;
        public ThongKeRepository(SwpBookingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddThongKe(ThongKe thongKe)
        {
            try
            {
                _dbContext.ThongKes.Add(thongKe);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DeleteThongKe(int id)
        {
            try
            {
                var thongKeToDelete = _dbContext.ThongKes.Find(id);
                if (thongKeToDelete != null)
                {
                    _dbContext.ThongKes.Remove(thongKeToDelete);
                    return _dbContext.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DeleteThongKe(ThongKe thongKe)
        {
            try
            {
                _dbContext.ThongKes.Remove(thongKe);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public async Task<List<ThongKe>> GetAllThongKe()
        {
            try
            {
                return await _dbContext.ThongKes.Include(t => t.IdAdminNavigation).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public async Task<ThongKe> GetThongKeById(int id)
        {
            return await _dbContext.ThongKes.Include(t => t.IdAdminNavigation).FirstOrDefaultAsync(t => t.IdThongKe == id);
        }

        public bool UpdateThongKe(ThongKe thongKe)
        {
            try
            {
                _dbContext.Entry(thongKe).State = EntityState.Modified;
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }
    }
}
