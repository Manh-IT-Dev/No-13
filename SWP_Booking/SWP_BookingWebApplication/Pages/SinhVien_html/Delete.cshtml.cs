using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.SinhVien_html
{
    public class DeleteModel : PageModel
    {
        private readonly ISinhVienService _sinhVienService;

        public DeleteModel(ISinhVienService sinhVienService)
        {
            _sinhVienService = sinhVienService;
        }

        [BindProperty]
        public SinhVien SinhVien { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sinhvien = await _sinhVienService.GetSinhVienById((int)id);

            if (sinhvien is not null)
            {
                SinhVien = sinhvien;

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

            _sinhVienService.DeleteSinhVien((int)id);

            return RedirectToPage("./Index");
        }
    }
}
