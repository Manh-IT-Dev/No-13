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
    public class MentorRepository : IMentorRepository
    {
        private readonly SwpBookingDbContext _dbContext;
        public MentorRepository(SwpBookingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddMentor(Mentor mentor)
        {
            try
            {
                _dbContext.Mentors.Add(mentor);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DeleteMentor(int id)
        {
            try
            {
                var mentorToDelete = _dbContext.Mentors.Find(id);
                if (mentorToDelete != null)
                {
                    _dbContext.Mentors.Remove(mentorToDelete);
                    return _dbContext.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DeleteMentor(Mentor mentor)
        {
            try
            {
                _dbContext.Mentors.Remove(mentor);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public async Task<List<Mentor>> GetAllMentor()
        {
            try
            {
                return await _dbContext.Mentors.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public async Task<Mentor> GetMentorById(int id)
        {
            return await _dbContext.Mentors.FirstOrDefaultAsync(m => m.IdMentor == id);
        }

        public bool UpdateMentor(Mentor mentor)
        {
            try
            {
                _dbContext.Entry(mentor).State = EntityState.Modified;
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }
    }
}
