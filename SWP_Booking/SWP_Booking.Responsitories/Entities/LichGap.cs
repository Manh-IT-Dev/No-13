using SWP_Booking.Repositories.Entities;
using System;
using System.Collections.Generic;

namespace SWP_Booking.Repositories.Entities;

public partial class LichGap
{
    public int IdLichGap { get; set; }

    public int? IdSinhVien { get; set; }

    public int? IdMentor { get; set; }

    public DateTime ThoiGian { get; set; }

    public string TrangThai { get; set; } = null!;

    public virtual Mentor? EmailMentor { get; set; }

    public virtual SinhVien? EmailSinhVien { get; set; }
}
