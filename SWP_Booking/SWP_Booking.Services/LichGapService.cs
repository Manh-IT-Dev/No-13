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
    public class LichGapService : ILichGapService
    {
        private readonly ILichGapRepository _lichGapRepository;
        public LichGapService(ILichGapRepository lichGapRepository)
        {
            _lichGapRepository = lichGapRepository;
        }
        public bool AddLichGap(LichGap lichGap)
        {
            return _lichGapRepository.AddLichGap(lichGap);
        }

        public bool DeleteLichGap(int id)
        {
            return _lichGapRepository.DeleteLichGap(id);
        }

        public bool DeleteLichGap(LichGap lichGap)
        {
            return _lichGapRepository.DeleteLichGap(lichGap);
        }

        public Task<List<LichGap>> GetAllLichGap()
        {
            return _lichGapRepository.GetAllLichGap();
        }

        public Task<LichGap> GetLichGapById(int id)
        {
            return _lichGapRepository.GetLichGapById(id);
        }

        public bool UpdateLichGap(LichGap lichGap)
        {
            return _lichGapRepository.UpdateLichGap(lichGap);
        }
    }
}
