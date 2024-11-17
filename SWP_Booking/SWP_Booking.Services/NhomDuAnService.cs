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
    public class NhomDuAnService : INhomDuAnService
    {

        private readonly INhomDuAnRepository _nhomDuAnRepository;
        public NhomDuAnService(INhomDuAnRepository nhomDuAnRepository)
        {
            _nhomDuAnRepository = nhomDuAnRepository;
        }
        public bool AddNhomDuAn(NhomDuAn nhom)
        {
            return _nhomDuAnRepository.AddNhomDuAn(nhom);
        }

        public bool DeleteNhomDuAn(int id)
        {
            return _nhomDuAnRepository.DeleteNhomDuAn(id);
        }

        public bool DeleteNhomDuAn(NhomDuAn nhom)
        {
            return _nhomDuAnRepository.DeleteNhomDuAn(nhom);
        }

        public Task<List<NhomDuAn>> GetAllNhomDuAn()
        {
            return _nhomDuAnRepository.GetAllNhomDuAn();
        }

        public Task<NhomDuAn> GetNhomDuAnById(int id)
        {
            return _nhomDuAnRepository.GetNhomDuAnById(id);
        }

        public bool UpdateNhomDuAn(NhomDuAn nhom)
        {
            return _nhomDuAnRepository.UpdateNhomDuAn(nhom);
        }
    }
}
