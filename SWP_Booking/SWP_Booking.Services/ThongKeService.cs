using SWP_Booking.Repositories.Entities;
using SWP_Booking.Repositories.Interface;
using SWP_Booking.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Services
{
    public class ThongKeService : IThongKeService
    {

        private readonly IThongKeRepository _thongKeRepository;
        public ThongKeService(IThongKeRepository thongKeRepository)
        {
            _thongKeRepository = thongKeRepository;
        }
        public bool AddThongKe(ThongKe thongKe)
        {
            return _thongKeRepository.AddThongKe(thongKe);
        }

        public bool DeleteThongKe(int id)
        {
            return _thongKeRepository.DeleteThongKe(id);
        }

        public bool DeleteThongKe(ThongKe thongKe)
        {
            return _thongKeRepository.DeleteThongKe(thongKe);
        }

        public Task<List<ThongKe>> GetAllThongKe()
        {
            return _thongKeRepository.GetAllThongKe();
        }

        public Task<ThongKe> GetThongKeById(int id)
        {
            return _thongKeRepository.GetThongKeById(id);
        }

        public bool UpdateThongKe(ThongKe thongKe)
        {
            return _thongKeRepository.UpdateThongKe(thongKe);
        }
    }
}
