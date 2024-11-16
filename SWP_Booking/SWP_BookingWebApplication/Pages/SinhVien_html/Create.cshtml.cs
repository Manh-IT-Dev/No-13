using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.SinhVien_html
{
    public class CreateModel : PageModel
    {
        private readonly ISinhVienService _sinhVienService;

        public CreateModel(ISinhVienService sinhVienService)
        {
            _sinhVienService = sinhVienService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SinhVien SinhVien { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _sinhVienService.AddSinhVien(SinhVien);

            return RedirectToPage("./Index");
        }
    }
}
