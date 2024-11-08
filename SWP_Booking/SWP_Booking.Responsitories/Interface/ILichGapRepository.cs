using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Repositories.Interface
{
    public interface ILichGapRepository
    {
        Task<List<Entities.LichGap>> GetLichGapsAsync();
        Task<Entities.LichGap> GetLichGapByIdAsync(int id);
        //Task<Entities.LichGap> AddLichGapAsync(Entities.LichGap lichGap);
        //Task<Entities.LichGap> UpdateLichGapAsync(Entities.LichGap lichGap);
        //Task DeleteLichGapAsync(int id);
        //Task<List<Entities.LichGap>> GetLichGapsBySinhVienAsync(int idSinhVien);
        //Task<List<Entities.LichGap>> GetLichGapsByMentorAsync(int idMentor);

    }
}
