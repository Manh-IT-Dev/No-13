using System;
using System.Collections.Generic;

namespace SWP_Booking.Repositories.Entities;

public partial class SinhVien
{
    public int IdSinhVien { get; set; }

    public string Ten { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public int? DiemVi { get; set; }

    public string? LichSuGap { get; set; }

    public virtual ICollection<DanhGia> DanhGias { get; set; } = new List<DanhGia>();

    public virtual ICollection<DiemVi> DiemVis { get; set; } = new List<DiemVi>();

    public virtual ICollection<LichGap> LichGaps { get; set; } = new List<LichGap>();

    public virtual ICollection<NhomDuAn> NhomDuAns { get; set; } = new List<NhomDuAn>();

    public virtual ICollection<ThongBao> ThongBaos { get; set; } = new List<ThongBao>();
}
