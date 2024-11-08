using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Repositories.Interface
{
    public interface IDiemViRepository
    {
        Task<List<Entities.DiemVi>> GetDiemVisAsync();
        Task<Entities.DiemVi> GetDiemViByIdAsync(int id);
        //Task<Entities.DiemVi> AddDiemVi(Entities.DiemVi diemVi);
        //Task<Entities.DiemVi> UpdateDiemVi(Entities.DiemVi diemVi);
        //Task DeleteDiemVi(int id);
        //Task<List<Entities.DiemVi>> GetDiemViSinhVienAsync(int idSinhVien);

    }
}
