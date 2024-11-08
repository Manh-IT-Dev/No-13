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
    public class ThongBaoRepository : IThongBaoRepository
    {
        private readonly SwpBookingDbContext _dbContext;
        public ThongBaoRepository(SwpBookingDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<ThongBao>> GetThongBaosAsync()
        {
            return await _dbContext.ThongBaos.ToListAsync();
        }
    }
}
