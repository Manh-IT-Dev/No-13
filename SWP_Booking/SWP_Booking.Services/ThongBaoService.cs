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
    public class ThongBaoService : IThongBaoService
    {
        private readonly IThongBaoRepository _thongBaoRepository;
        public ThongBaoService(IThongBaoRepository thongBaoRepository)
        {
            _thongBaoRepository = thongBaoRepository;
        }
        public bool AddThongBao(ThongBao thongBao)
        {
            return _thongBaoRepository.AddThongBao(thongBao);
        }

        public bool DeleteThongBao(int id)
        {
            return _thongBaoRepository.DeleteThongBao(id);
        }

        public bool DeleteThongBao(ThongBao thongBao)
        {
            return _thongBaoRepository.DeleteThongBao(thongBao);
        }

        public Task<List<ThongBao>> GetAllThongBao()
        {
            return _thongBaoRepository.GetAllThongBao();
        }

        public Task<ThongBao> GetThongBaoById(int id)
        {
            return _thongBaoRepository.GetThongBaoById(id);
        }

        public bool UpdateThongBao(ThongBao thongBao)
        {
            return _thongBaoRepository.UpdateThongBao(thongBao);
        }
    }
}
