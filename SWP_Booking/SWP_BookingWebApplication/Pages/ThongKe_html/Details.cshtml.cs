using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.ThongKe_html
{
    public class DetailsModel : PageModel
    {
        private readonly IThongKeService _thongKeService;

        public DetailsModel(IThongKeService thongKeService)
        {
            _thongKeService = thongKeService;
        }

        public ThongKe ThongKe { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thongke = await _thongKeService.GetThongKeById((int)id);

            if (thongke is not null)
            {
                ThongKe = thongke;

                return Page();
            }

            return NotFound();
        }
    }
}
