using SWP_Booking.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Repositories.Interface
{
    public interface IThongBaoRepository
    {
        Task<List<ThongBao>> GetAllThongBao();
        Task<ThongBao> GetThongBaoById(int id);
        Boolean AddThongBao(ThongBao thongBao);
        Boolean DeleteThongBao(int id);
        Boolean DeleteThongBao(ThongBao thongBao);
        Boolean UpdateThongBao(ThongBao thongBao);

        Task<List<ThongBao>> GetThongBaoByIdSinhVien(int idSinhVien);
    }
}
