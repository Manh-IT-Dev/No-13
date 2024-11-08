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
        public Task<Mentor> AddMentorAsync(Mentor mentor)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMentorAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Mentor> GetMentorByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Mentor>> GetMentorsAsync()
        {
            return await _dbContext.Mentors.ToListAsync();
        }

        public Task<Mentor> UpdateMentorAsync(Mentor mentor)
        {
            throw new NotImplementedException();
        }
    }
}
