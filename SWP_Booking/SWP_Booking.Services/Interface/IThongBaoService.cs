using SWP_Booking.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Services.Interface
{
    public interface IThongBaoService
    {
        Task<List<ThongBao>> GetAllThongBao();
        Task<ThongBao> GetThongBaoById(int id);
        Boolean AddThongBao(ThongBao thongBao);
        Boolean DeleteThongBao(int id);
        Boolean DeleteThongBao(ThongBao thongBao);
        Boolean UpdateThongBao(ThongBao thongBao);
    }
}
