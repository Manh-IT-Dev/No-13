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
    public class DeleteModel : PageModel
    {
        private readonly ILichGapService _lichGapService;

        public DeleteModel(ILichGapService lichGapService)
        {
            _lichGapService = lichGapService;
        }

        [BindProperty]
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

        public IActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _lichGapService.DeleteLichGap((int)id);

            return RedirectToPage("./Index");
        }
    }
}
