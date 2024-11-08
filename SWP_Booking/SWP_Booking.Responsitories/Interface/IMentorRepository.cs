using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Repositories.Interface
{
    public interface IMentorRepository
    {
        Task<List<Entities.Mentor>> GetMentorsAsync();
        Task<Entities.Mentor> GetMentorByIdAsync(int id);
        Task<Entities.Mentor> AddMentorAsync(Entities.Mentor mentor);
        Task<Entities.Mentor> UpdateMentorAsync(Entities.Mentor mentor);
        Task DeleteMentorAsync(int id);
    }
}
