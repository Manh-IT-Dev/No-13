using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.DiemVi_html
{
    public class DetailsModel : PageModel
    {
        private readonly IDiemViService _diemViService;

        public DetailsModel(IDiemViService diemViService)
        {
            _diemViService = diemViService;
        }

        public DiemVi DiemVi { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diemvi = await _diemViService.GetDiemViById((int)id);

            if (diemvi is not null)
            {
                DiemVi = diemvi;

                return Page();
            }

            return NotFound();
        }
    }
}
