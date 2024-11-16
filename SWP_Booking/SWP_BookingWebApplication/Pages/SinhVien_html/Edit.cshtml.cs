using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.SinhVien_html
{
    public class EditModel : PageModel
    {
        private readonly ISinhVienService _sinhVienService;

        public EditModel(ISinhVienService sinhVienService)
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
            if (sinhvien == null)
            {
                return NotFound();
            }
            SinhVien = sinhvien;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _sinhVienService.UpdateSinhVien(SinhVien);

            return RedirectToPage("./Index");
        }

        private bool SinhVienExists(int id)
        {
            return _sinhVienService.GetSinhVienById(id) != null;
        }
    }
}
