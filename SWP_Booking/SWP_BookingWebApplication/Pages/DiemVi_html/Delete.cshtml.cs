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
    public class DeleteModel : PageModel
    {
        private readonly IDiemViService _diemViService;

        public DeleteModel(IDiemViService diemViService)
        {
            _diemViService = diemViService;
        }

        [BindProperty]
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

        public IActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _diemViService.DeleteDiemVi((int)id);

            return RedirectToPage("./Index");
        }
    }
}
