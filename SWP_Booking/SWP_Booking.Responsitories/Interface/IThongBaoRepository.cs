using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Booking.Repositories.Interface
{
    public interface IThongBaoRepository
    {
        Task<List<Entities.ThongBao>> GetThongBaosAsync();

        //Task<Entities.ThongBao> GetThongBaoByIdAsync(int id);
        //Task<Entities.ThongBao> AddThongBaoAsync(Entities.ThongBao thongBao);
        //Task<Entities.ThongBao> UpdateThongBaoAsync(Entities.ThongBao thongBao);
        //Task DeleteThongBaoAsync(int id);
        //Task<List<Entities.ThongBao>> GetThongBaoByNhomSinhVienAsync(int idNhomSinhVien);
        //Task<List<Entities.ThongBao>> GetThongBaoBySinhVienAsync(int idSinhVien);
        //Task<List<Entities.ThongBao>> GetThongBaoByMentorAsync(int idMentor);


    }
}
