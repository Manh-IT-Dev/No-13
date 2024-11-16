using SWP_Booking.Repositories.Entities;
using SWP_Booking.Repositories.Interface;
using SWP_Booking.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Services
{
    public class MentorService : IMentorService
    {
        private readonly IMentorRepository _mentorRepository;
        public MentorService(IMentorRepository mentorRepository)
        {
            _mentorRepository = mentorRepository;
        }
        public bool AddMentor(Mentor mentor)
        {
            return _mentorRepository.AddMentor(mentor);
        }

        public bool DeleteMentor(int id)
        {
            return _mentorRepository.DeleteMentor(id);
        }

        public bool DeleteMentor(Mentor mentor)
        {
            return _mentorRepository.DeleteMentor(mentor);
        }

        public Task<List<Mentor>> GetAllMentor()
        {
            return _mentorRepository.GetAllMentor();
        }

        public Task<Mentor> GetMentorById(int id)
        {
            return _mentorRepository.GetMentorById(id);
        }

        public bool UpdateMentor(Mentor mentor)
        {
            return _mentorRepository.UpdateMentor(mentor);
        }
    }
}
