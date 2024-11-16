using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWP_Booking.Repositories.Entities;

namespace SWP_Booking.Services.Interface
{
    public interface ISinhVienService
    {
        Task<List<SinhVien>> GetAllSinhVien();
        Task<SinhVien> GetSinhVienById(int id);
        Boolean AddSinhVien(SinhVien sinhVien);
        Boolean DeleteSinhVien(int id);
        Boolean DeleteSinhVien(SinhVien sinhVien);
        Boolean UpdateSinhVien(SinhVien sinhVien);
    }
}
