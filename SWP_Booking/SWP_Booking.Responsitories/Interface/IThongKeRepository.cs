using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Repositories.Interface
{
    public interface IThongKeRepository
    {
        Task<List<Entities.ThongKe>> GetThongKesAsync();

        Task<Entities.ThongKe> GetThongKeByIdAsync(int id);
        //Task<Entities.ThongKe> AddThongKeAsync(Entities.ThongKe thongKe);
        //Task DeleteThongKeAsync(int id);
        //Task<Entities.ThongKe> UpdateThongKeAsync(Entities.ThongKe thongKe);

    }
}
