using SWP_Booking.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Services.Interface
{
    public interface IDanhGiaService
    {
        Task<List<DanhGia>> GetAllDanhGia();
        Task<DanhGia> GetDanhGiaById(int id);
        Boolean AddDanhGia(DanhGia danhgia);
        Boolean DeleteDanhGia(int id);
        Boolean DeleteDanhGia(DanhGia danhGia);
        Boolean UpdateDanhGia(DanhGia danhGia);
    }
}
