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
    public class DetailsModel : PageModel
    {
        private readonly IThongBaoService _thongBaoService;

        public DetailsModel(IThongBaoService thongBaoService)
        {
            _thongBaoService = thongBaoService;
        }

        public ThongBao ThongBao { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thongbao = await _thongBaoService.GetThongBaoById((int)id);

            if (thongbao is not null)
            {
                ThongBao = thongbao;

                return Page();
            }

            return NotFound();
        }
    }
}
