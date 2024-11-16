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
    public class DanhGiaRepository : IDanhGiaRepository
    {
        private readonly SwpBookingDbContext _dbContext;
        public DanhGiaRepository(SwpBookingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddDanhGia(DanhGia danhgia)
        {
            try
            {
                _dbContext.DanhGias.Add(danhgia);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DeleteDanhGia(int id)
        {
            try
            {
                var danhGiaToDelete = _dbContext.DanhGias.Find(id);
                if (danhGiaToDelete != null)
                {
                    _dbContext.DanhGias.Remove(danhGiaToDelete);
                    return _dbContext.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DeleteDanhGia(DanhGia danhGia)
        {
            try
            {
                _dbContext.DanhGias.Remove(danhGia);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public async Task<List<DanhGia>> GetAllDanhGia()
        {
            try
            {
                return await _dbContext.DanhGias.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public async Task<DanhGia> GetDanhGiaById(int id)
        {
            return await _dbContext.DanhGias.FirstOrDefaultAsync(d => d.IdDanhGia == id);
        }

        public bool UpdateDanhGia(DanhGia danhGia)
        {
            try
            {
                _dbContext.Entry(danhGia).State = EntityState.Modified;
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }
    }
}
