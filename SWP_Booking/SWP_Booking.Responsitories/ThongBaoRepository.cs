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

        public bool AddThongBao(ThongBao thongBao)
        {
            try
            {
                _dbContext.ThongBaos.Add(thongBao);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DeleteThongBao(int id)
        {

            try
            {
                var thongBaoToDelete = _dbContext.ThongBaos.Find(id);
                if (thongBaoToDelete != null)
                {
                    _dbContext.ThongBaos.Remove(thongBaoToDelete);
                    return _dbContext.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DeleteThongBao(ThongBao thongBao)
        {
            try
            {
                _dbContext.ThongBaos.Remove(thongBao);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public async Task<List<ThongBao>> GetAllThongBao()
        {
            try
            {
                return await _dbContext.ThongBaos.Include(t => t.IdSinhVienNavigation).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public async Task<ThongBao> GetThongBaoById(int id)
        {
            return await _dbContext.ThongBaos.Include(t => t.IdSinhVienNavigation).FirstOrDefaultAsync(t => t.IdThongBao == id);
        }

        public async Task<List<ThongBao>> GetThongBaoByIdSinhVien(int idSinhVien)
        {
            return await _dbContext.ThongBaos.Where(t => t.IdSinhVien == idSinhVien).ToListAsync();
        }

        public bool UpdateThongBao(ThongBao thongBao)
        {
            try
            {
                _dbContext.Entry(thongBao).State = EntityState.Modified;
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

    }
}
