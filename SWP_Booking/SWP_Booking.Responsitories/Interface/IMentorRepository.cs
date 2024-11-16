using SWP_Booking.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Repositories.Interface
{
    public interface IMentorRepository
    {
        Task<List<Mentor>> GetAllMentor();
        Task<Mentor> GetMentorById(int id);
        Boolean AddMentor(Mentor mentor);
        Boolean DeleteMentor(int id);
        Boolean DeleteMentor(Mentor mentor);
        Boolean UpdateMentor(Mentor mentor);
    }
}
