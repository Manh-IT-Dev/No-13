using SWP_Booking.Repositories.Entities;
using System;
using System.Collections.Generic;

namespace SWP_Booking.Repositories.Entities;

public partial class DanhGia
{
    public int IdDanhGia { get; set; }

    public int? IdSinhVien { get; set; }

    public int? IdMentor { get; set; }

    public int? DiemDanhGia { get; set; }

    public string? NhanXet { get; set; }

    public DateTime? NgayDanhGia { get; set; }

    public virtual Mentor? IdMentorNavigation { get; set; }

    public virtual SinhVien? IdSinhVienNavigation { get; set; }
}
