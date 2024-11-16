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
    public class DiemViService : IDiemViService
    {
        private readonly IDiemViRepository _diemViRepository;
        public DiemViService(IDiemViRepository diemViRepository)
        {
            _diemViRepository = diemViRepository;
        }
        public bool AddDiemVi(DiemVi diemVi)
        {
            return _diemViRepository.AddDiemVi(diemVi);
        }

        public bool DeleteDiemVi(int id)
        {
            return _diemViRepository.DeleteDiemVi(id);
        }

        public bool DeleteDiemVi(DiemVi diemvi)
        {
            return _diemViRepository.DeleteDiemVi(diemvi);
        }

        public Task<List<DiemVi>> GetAllDiemVi()
        {
            return _diemViRepository.GetAllDiemVi();
        }

        public Task<DiemVi> GetDiemViById(int id)
        {
            return _diemViRepository.GetDiemViById(id);
        }

        public bool UpdateDiemVi(DiemVi diemVi)
        {
            return _diemViRepository.UpdateDiemVi(diemVi);
        }
    }
}
