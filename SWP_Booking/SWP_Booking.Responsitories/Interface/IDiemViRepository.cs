using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWP_Booking.Repositories.Entities;

namespace SWP_Booking.Repositories.Interface
{
    public interface IDiemViRepository
    {
        Task<List<DiemVi>> GetAllDiemVi();
        Task<DiemVi> GetDiemViById(int id);
        Boolean AddDiemVi(DiemVi diemVi);
        Boolean DeleteDiemVi(int id);
        Boolean DeleteDiemVi(DiemVi diemvi);
        Boolean UpdateDiemVi(DiemVi diemVi);

    }
}
