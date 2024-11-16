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
    public class SinhVienService : ISinhVienService
    {
        private readonly ISinhVienRepository _sinhVienRepository;
        public SinhVienService(ISinhVienRepository sinhVienRepository)
        {
            _sinhVienRepository = sinhVienRepository;
        }
        public bool AddSinhVien(SinhVien sinhVien)
        {
            return _sinhVienRepository.AddSinhVien(sinhVien);
        }

        public bool DeleteSinhVien(int id)
        {
            return _sinhVienRepository.DeleteSinhVien(id);
        }

        public bool DeleteSinhVien(SinhVien sinhVien)
        {
            return _sinhVienRepository.DeleteSinhVien(sinhVien);
        }

        public Task<List<SinhVien>> GetAllSinhVien()
        {
            return _sinhVienRepository.GetAllSinhVien();
        }

        public Task<SinhVien> GetSinhVienById(int id)
        {
            return _sinhVienRepository.GetSinhVienById(id);
        }

        public bool UpdateSinhVien(SinhVien sinhVien)
        {
            return _sinhVienRepository.UpdateSinhVien(sinhVien);
        }
    }
}
