using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Repositories.Interface
{
    public interface IDanhGiaRepository
    {
        Task<List<Entities.DanhGia>> GetDanhGiasAsync();
        Task<Entities.DanhGia> GetDanhGiaByIdAsync(int id);
        Task<Entities.DanhGia> AddDanhGiaAsync(Entities.DanhGia danhGia);
        Task<Entities.DanhGia> UpdateDanhGiaAsync(Entities.DanhGia danhGia);
        Task DeleteDanhGiaAsync(int id);
        Task<List<Entities.DanhGia>> GetDanhGiasBySinhVienAsync(int idSinhVien);
        Task<List<Entities.DanhGia>> GetDanhGiasByMentorAsync(int idMentor);
        //Task<double> GetAverageRatingBySinhVienAsync(int idSinhVien);


    }
}
