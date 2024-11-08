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
    public class LichGapRepository : ILichGapRepository
    {
        private readonly SwpBookingDbContext _dbContext;
        public LichGapRepository(SwpBookingDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<LichGap> GetLichGapByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<LichGap>> GetLichGapsAsync()
        {
            return await _dbContext.LichGaps.ToListAsync();
        }
    }
}
