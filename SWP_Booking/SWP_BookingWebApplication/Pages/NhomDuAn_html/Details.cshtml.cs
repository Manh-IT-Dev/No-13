using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.NhomDuAn_html
{
    public class DetailsModel : PageModel
    {
        private readonly INhomDuAnService _nhomDuAnService;

        public DetailsModel(INhomDuAnService nhomDuAnService)
        {
            _nhomDuAnService = nhomDuAnService;
        }

        public NhomDuAn NhomDuAn { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhomduan = await _nhomDuAnService.GetNhomDuAnById((int)id);

            if (nhomduan is not null)
            {
                NhomDuAn = nhomduan;

                return Page();
            }

            return NotFound();
        }
    }
}
