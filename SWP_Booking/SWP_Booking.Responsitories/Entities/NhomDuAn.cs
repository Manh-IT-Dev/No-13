using SWP_Booking.Repositories.Entities;
using System;
using System.Collections.Generic;

namespace SWP_Booking.Repositories.Entities;

public partial class NhomDuAn
{
    public int IdNhom { get; set; }

    public string TenNhom { get; set; } = null!;

    public string ChuDeDuAn { get; set; } = null!;

    public int? IdSinhVien { get; set; }

    public string? TienDo { get; set; }

    public virtual SinhVien? IdSinhVienNavigation { get; set; }
}
