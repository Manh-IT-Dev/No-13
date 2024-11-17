using SWP_Booking.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Services.Interface
{
    public interface INhomDuAnService
    {
        Task<List<NhomDuAn>> GetAllNhomDuAn();
        Task<NhomDuAn> GetNhomDuAnById(int id);
        Boolean AddNhomDuAn(NhomDuAn nhom);
        Boolean DeleteNhomDuAn(int id);
        Boolean DeleteNhomDuAn(NhomDuAn nhom);
        Boolean UpdateNhomDuAn(NhomDuAn nhom);
    }
}
