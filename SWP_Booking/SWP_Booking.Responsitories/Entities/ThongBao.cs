using System;
using System.Collections.Generic;

namespace SWP_Booking.Repositories.Entities;

public partial class ThongBao
{
    public int IdThongBao { get; set; }

    public int? IdSinhVien { get; set; }

    public string? NoiDung { get; set; }

    public DateTime? NgayGui { get; set; }

    public string TrangThai { get; set; } = null!;

    public virtual SinhVien? IdSinhVienNavigation { get; set; }
}
