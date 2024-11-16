using System;
using System.Collections.Generic;

namespace SWP_Booking.Repositories.Entities;

public partial class Mentor
{
    public int IdMentor { get; set; }

    public string Ten { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? KiNang { get; set; }

    public string? ChuyenMon { get; set; }

    public string? LichLamViec { get; set; }

    public virtual ICollection<DanhGia> DanhGias { get; set; } = new List<DanhGia>();

    public virtual ICollection<LichGap> LichGaps { get; set; } = new List<LichGap>();
}
