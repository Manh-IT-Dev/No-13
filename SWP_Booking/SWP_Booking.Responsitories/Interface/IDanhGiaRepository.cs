using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWP_Booking.Repositories.Entities;

namespace SWP_Booking.Repositories.Interface
{
    public interface IDanhGiaRepository
    {
        Task<List<DanhGia>> GetAllDanhGia();
        Task<DanhGia> GetDanhGiaById(int id);
        Boolean AddDanhGia(DanhGia danhgia);
        Boolean DeleteDanhGia(int id);
        Boolean DeleteDanhGia(DanhGia danhGia);
        Boolean UpdateDanhGia(DanhGia danhGia);
    }
}
