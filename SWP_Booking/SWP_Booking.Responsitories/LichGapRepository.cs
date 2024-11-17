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

        public bool AddLichGap(LichGap lichGap)
        {
            try
            {
                _dbContext.LichGaps.Add(lichGap);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DeleteLichGap(int id)
        {
            try
            {
                var lichGapToDelete = _dbContext.LichGaps.Find(id);
                if (lichGapToDelete != null)
                {
                    _dbContext.LichGaps.Remove(lichGapToDelete);
                    return _dbContext.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DeleteLichGap(LichGap lichGap)
        {
            try
            {
                _dbContext.LichGaps.Remove(lichGap);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public async Task<List<LichGap>> GetAllLichGap()
        {
            try
            {
                return await _dbContext.LichGaps
                    .Include(l => l.IdSinhVienNavigation)
                    .Include(l => l.IdMentorNavigation)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public async Task<LichGap> GetLichGapById(int id)
        {
            return await _dbContext.LichGaps
                 .Include(l => l.IdSinhVienNavigation)
                 .Include(l => l.IdMentorNavigation)
                 .FirstOrDefaultAsync(l => l.IdLichGap == id);
        }

        public bool UpdateLichGap(LichGap lichGap)
        {
            try
            {
                _dbContext.Entry(lichGap).State = EntityState.Modified;
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }
    }
}
