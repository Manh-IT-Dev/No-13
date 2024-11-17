using SWP_Booking.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Services.Interface
{
    public interface IThongKeService
    {
        Task<List<ThongKe>> GetAllThongKe();
        Task<ThongKe> GetThongKeById(int id);
        Boolean AddThongKe(ThongKe thongKe);
        Boolean DeleteThongKe(int id);
        Boolean DeleteThongKe(ThongKe thongKe);
        Boolean UpdateThongKe(ThongKe thongKe);

    }
}
