using SWP_Booking.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Repositories.Interface
{
    public interface ILichGapRepository
    {
        Task<List<LichGap>> GetAllLichGap();
        Task<LichGap> GetLichGapById(int id);
        Task<Boolean> AddLichGap(LichGap lichGap);
        Boolean DeleteLichGap(int id);
        Boolean DeleteLichGap(LichGap lichGap);
        Boolean UpdateLichGap(LichGap lichGap);

    }
}
