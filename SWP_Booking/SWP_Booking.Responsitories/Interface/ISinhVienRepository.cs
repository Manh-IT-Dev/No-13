using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Repositories.Interface
{
    public interface ISinhVienRepository
    {
        Task<List<Entities.SinhVien>> GetSinhViensAsync();
        Task<Entities.SinhVien> GetSinhVienByIdAsync(int id);
        Task<Entities.SinhVien> AddSinhVienAsync(Entities.SinhVien sinhVien);
        Task<Entities.SinhVien> UpdateSinhVienAsync(Entities.SinhVien sinhVien);
        Task DeleteSinhVienAsync(int id);

    }
}
