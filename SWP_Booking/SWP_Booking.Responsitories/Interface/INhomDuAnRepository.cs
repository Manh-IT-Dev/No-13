using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Repositories.Interface
{
    public interface INhomDuAnRepository
    {
        Task<List<Entities.NhomDuAn>> GetNhomDuAnsAsync();
        //Task<Entities.NhomDuAn> GetNhomDuAnByIdAsync(int id);
        //Task<Entities.NhomDuAn> AddNhomDuAn(Entities.NhomDuAn nhomDuAn);
        //Task<Entities.NhomDuAn> UpdateNhomDuAn(Entities.NhomDuAn nhomDuAn);
        //Task DeleteNhomDuAn(int id);

    }
}
