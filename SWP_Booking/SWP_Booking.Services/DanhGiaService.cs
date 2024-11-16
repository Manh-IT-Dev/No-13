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
    public class DanhGiaService : IDanhGiaService
    {
        private readonly IDanhGiaRepository _danhGiaRepository;
        public DanhGiaService(IDanhGiaRepository danhGiaRepository)
        {
            _danhGiaRepository = danhGiaRepository;
        }
        public bool AddDanhGia(DanhGia danhgia)
        {
            return _danhGiaRepository.AddDanhGia(danhgia);
        }

        public bool DeleteDanhGia(int id)
        {
            return _danhGiaRepository.DeleteDanhGia(id);
        }

        public bool DeleteDanhGia(DanhGia danhGia)
        {
            return _danhGiaRepository.DeleteDanhGia(danhGia);
        }

        public Task<List<DanhGia>> GetAllDanhGia()
        {
            return _danhGiaRepository.GetAllDanhGia();
        }

        public Task<DanhGia> GetDanhGiaById(int id)
        {
            return _danhGiaRepository.GetDanhGiaById(id);
        }

        public bool UpdateDanhGia(DanhGia danhGia)
        {
            return _danhGiaRepository.UpdateDanhGia(danhGia);
        }
    }
}
