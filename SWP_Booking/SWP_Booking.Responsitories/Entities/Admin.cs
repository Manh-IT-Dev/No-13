using System;
using System.Collections.Generic;

namespace SWP_Booking.Repositories.Entities;

public partial class Admin
{
    public int IdAdmin { get; set; }

    public string Ten { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public virtual ICollection<ThongKe> ThongKes { get; set; } = new List<ThongKe>();
}
