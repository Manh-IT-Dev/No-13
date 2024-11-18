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
                _dbContext.DanhGia.Add(danhgia);
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
                var danhGiaToDelete = _dbContext.DanhGia.Find(id);
                if (danhGiaToDelete != null)
                {
                    _dbContext.DanhGia.Remove(danhGiaToDelete);
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
                _dbContext.DanhGia.Remove(danhGia);
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
                return await _dbContext.DanhGia
                    .Include(d => d.EmailSinhVien)
                    .Include(d => d.EmailSinhVien)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public async Task<DanhGia> GetDanhGiaById(int id)
        {
            return await _dbContext.DanhGia
                .Include(d => d.EmailSinhVien)
                .Include(d => d.EmailSinhVien)
                .FirstOrDefaultAsync(d => d.IdDanhGia == id);
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
