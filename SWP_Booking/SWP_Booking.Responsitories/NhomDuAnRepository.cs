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
    public class NhomDuAnRepository : INhomDuAnRepository
    {
        private readonly SwpBookingDbContext _dbContext;
        public NhomDuAnRepository(SwpBookingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddNhomDuAn(NhomDuAn nhom)
        {
            try
            {
                _dbContext.NhomDuAns.Add(nhom);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DeleteNhomDuAn(int id)
        {
            try
            {
                var nhomToDelete = _dbContext.NhomDuAns.Find(id);
                if (nhomToDelete != null)
                {
                    _dbContext.NhomDuAns.Remove(nhomToDelete);
                    return _dbContext.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DeleteNhomDuAn(NhomDuAn nhom)
        {
            try
            {
                _dbContext.NhomDuAns.Remove(nhom);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public async Task<List<NhomDuAn>> GetAllNhomDuAn()
        {
            try
            {
                return await _dbContext.NhomDuAns.Include(n => n.IdSinhVienNavigation).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public async Task<NhomDuAn> GetNhomDuAnById(int id)
        {
            return await _dbContext.NhomDuAns.Include(n => n.IdSinhVienNavigation).FirstOrDefaultAsync(n => n.IdNhom == id);
        }

        public bool UpdateNhomDuAn(NhomDuAn nhom)
        {
            try
            {
                _dbContext.Entry(nhom).State = EntityState.Modified;
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }
    }
}
