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
        public Task<ThongKe> GetThongKeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ThongKe>> GetThongKesAsync()
        {
            return await _dbContext.ThongKes.ToListAsync();
        }
    }
}
