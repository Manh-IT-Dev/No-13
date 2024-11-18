using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.ThongBao_html
{
    public class IndexModel : PageModel
    {
        private readonly IThongBaoService _thongBaoService;

        public IndexModel(IThongBaoService thongBaoService)
        {
            _thongBaoService = thongBaoService;
        }

        public IList<ThongBao> ThongBao { get; set; } = default!;

        public async Task OnGetAsync(int id)
        {
            ThongBao = await _thongBaoService.GetThongBaoByIdSinhVien(id);
        }
    }
}
