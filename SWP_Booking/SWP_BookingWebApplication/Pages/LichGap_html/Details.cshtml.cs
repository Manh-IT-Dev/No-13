using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.LichGap_html
{
    public class DetailsModel : PageModel
    {
        private readonly ILichGapService _lichGapService;

        public DetailsModel(ILichGapService lichGapService)
        {
            _lichGapService = lichGapService;
        }

        public LichGap LichGap { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lichgap = await _lichGapService.GetLichGapById((int)id);

            if (lichgap is not null)
            {
                LichGap = lichgap;

                return Page();
            }

            return NotFound();
        }
    }
}
