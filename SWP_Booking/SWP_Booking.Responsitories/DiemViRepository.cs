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
        public async Task<List<DiemVi>> GetDiemVisAsync()
        {
            return await _dbContext.DiemVis.ToListAsync();
        }

        public Task<DiemVi> GetDiemViByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
