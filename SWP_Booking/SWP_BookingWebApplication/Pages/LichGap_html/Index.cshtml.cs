using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.LichGap_html
{
    public class IndexModel : PageModel
    {
        private readonly ILichGapService _lichGapService;

        public IndexModel(ILichGapService lichGapService)
        {
            _lichGapService = lichGapService;
        }

        public IList<LichGap> LichGap { get; set; } = default!;

        public async Task OnGetAsync()
        {
            LichGap = await _lichGapService.GetAllLichGap();
        }
    }
}
