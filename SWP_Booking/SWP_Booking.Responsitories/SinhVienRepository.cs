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
        public Task<SinhVien> AddSinhVienAsync(SinhVien sinhVien)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSinhVienAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SinhVien> GetSinhVienByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SinhVien>> GetSinhViensAsync()
        {
            return await _dbContext.SinhViens.ToListAsync();
        }

        public Task<SinhVien> UpdateSinhVienAsync(SinhVien sinhVien)
        {
            throw new NotImplementedException();
        }
    }
}
