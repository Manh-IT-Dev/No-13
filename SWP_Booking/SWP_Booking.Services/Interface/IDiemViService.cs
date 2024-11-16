using SWP_Booking.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Services.Interface
{
    public interface IDiemViService
    {
        Task<List<DiemVi>> GetAllDiemVi();
        Task<DiemVi> GetDiemViById(int id);
        Boolean AddDiemVi(DiemVi diemVi);
        Boolean DeleteDiemVi(int id);
        Boolean DeleteDiemVi(DiemVi diemvi);
        Boolean UpdateDiemVi(DiemVi diemVi);

    }
}
