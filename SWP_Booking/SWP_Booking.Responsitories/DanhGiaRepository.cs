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
        public Task<DanhGia> AddDanhGiaAsync(DanhGia danhGia)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDanhGiaAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DanhGia> GetDanhGiaByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DanhGia>> GetDanhGiasAsync()
        {
            return await _dbContext.DanhGias.ToListAsync();
        }

        public Task<List<DanhGia>> GetDanhGiasByMentorAsync(int idMentor)
        {
            throw new NotImplementedException();
        }

        public Task<List<DanhGia>> GetDanhGiasBySinhVienAsync(int idSinhVien)
        {
            throw new NotImplementedException();
        }

        public Task<DanhGia> UpdateDanhGiaAsync(DanhGia danhGia)
        {
            throw new NotImplementedException();
        }
    }
}
