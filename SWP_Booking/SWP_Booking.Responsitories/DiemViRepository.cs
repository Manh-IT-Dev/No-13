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
    public class DiemViRepository : IDiemViRepository
    {
        private readonly SwpBookingDbContext _dbContext;
        public DiemViRepository(SwpBookingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddDiemVi(DiemVi diemVi)
        {
            try
            {
                _dbContext.DiemVis.Add(diemVi);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DeleteDiemVi(int id)
        {
            try
            {
                var diemViToDelete = _dbContext.DiemVis.Find(id);
                if (diemViToDelete != null)
                {
                    _dbContext.DiemVis.Remove(diemViToDelete);
                    return _dbContext.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DeleteDiemVi(DiemVi diemvi)
        {
            try
            {
                _dbContext.DiemVis.Remove(diemvi);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public async Task<List<DiemVi>> GetAllDiemVi()
        {
            try
            {
                return await _dbContext.DiemVis.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public async Task<DiemVi> GetDiemViById(int id)
        {
            return await _dbContext.DiemVis.FirstOrDefaultAsync(v => v.IdDiemVi == id);
        }

        public bool UpdateDiemVi(DiemVi diemVi)
        {
            try
            {
                _dbContext.Entry(diemVi).State = EntityState.Modified;
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }
    }
}
