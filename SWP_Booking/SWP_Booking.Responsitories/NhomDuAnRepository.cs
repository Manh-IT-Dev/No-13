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
        public Task<NhomDuAn> GetNhomDuAnByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<NhomDuAn>> GetNhomDuAnsAsync()
        {
            return await _dbContext.NhomDuAns.ToListAsync();
        }
    }
}
