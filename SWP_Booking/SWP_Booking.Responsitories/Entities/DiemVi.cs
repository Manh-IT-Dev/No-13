using SWP_Booking.Repositories.Entities;
using System;
using System.Collections.Generic;

namespace SWP_Booking.Repositories.Entities;

public partial class DiemVi
{
    public int IdDiemVi { get; set; }

    public int? IdSinhVien { get; set; }

    public int? SoDiem { get; set; }

    public DateTime? NgayCapNhat { get; set; }

    public virtual SinhVien? IdSinhVienNavigation { get; set; }
}
