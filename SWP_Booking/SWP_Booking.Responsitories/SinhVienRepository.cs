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
    public class SinhVienRepository : ISinhVienRepository
    {
        private readonly SwpBookingDbContext _dbContext;

        public SinhVienRepository(SwpBookingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<SinhVien>> GetAllSinhVien()
        {
            try
            {
                return await _dbContext.SinhViens
                    .Include(s => s.DanhGia)
                    .Include(s => s.DiemVis)
                    .Include(s => s.NhomDuAns)
                    .Include(s => s.LichGaps)
                    .Include(s => s.ThongBaos)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the sinhvien list.", ex);
            }
        }

        public async Task<SinhVien> GetSinhVienById(int id)
        {
            return await _dbContext.SinhViens
                   .Include(s => s.DanhGia)
                   .Include(s => s.DiemVis)
                   .Include(s => s.NhomDuAns)
                   .Include(s => s.LichGaps)
                    .Include(s => s.ThongBaos)
                    .FirstOrDefaultAsync(s => s.IdSinhVien == id);
        }

        bool ISinhVienRepository.AddSinhVien(SinhVien sinhVien)
        {
            try
            {
                _dbContext.SinhViens.Add(sinhVien);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        bool ISinhVienRepository.DeleteSinhVien(int id)
        {
            try
            {
                var sinhVienToDelete = _dbContext.SinhViens.Find(id);
                if (sinhVienToDelete != null)
                {
                    _dbContext.SinhViens.Remove(sinhVienToDelete);
                    return _dbContext.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DeleteSinhVien(SinhVien sinhVien)
        {
            try
            {
                _dbContext.SinhViens.Remove(sinhVien);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        bool ISinhVienRepository.UpdateSinhVien(SinhVien sinhVien)
        {
            try
            {
                _dbContext.Entry(sinhVien).State = EntityState.Modified;
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }


    }
}
