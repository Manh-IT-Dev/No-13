using System;
using System.Collections.Generic;

namespace SWP_Booking.Repositories.Entities;

public partial class ThongKe
{
    public int IdThongKe { get; set; }

    public int? IdAdmin { get; set; }

    public int? SoBuoiGap { get; set; }

    public int? SuDungDiemVi { get; set; }

    public double? DanhGiaHieuQua { get; set; }

    public virtual Admin? IdAdminNavigation { get; set; }
}
