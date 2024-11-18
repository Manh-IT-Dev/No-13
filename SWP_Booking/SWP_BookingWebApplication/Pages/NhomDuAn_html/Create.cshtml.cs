using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.NhomDuAn_html
{
    public class CreateModel : PageModel
    {
        private readonly INhomDuAnService _nhomDuAnService;
        private readonly ISinhVienService _sinhVienService;

        public CreateModel(INhomDuAnService nhomDuAnService, ISinhVienService sinhVienService)
        {
            _nhomDuAnService = nhomDuAnService;
            _sinhVienService = sinhVienService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            ViewData["IdSinhVien"] = new SelectList(await _sinhVienService.GetAllSinhVien(), "IdSinhVien", "Email");
            return Page();
        }

        [BindProperty]
        public NhomDuAn NhomDuAn { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _nhomDuAnService.AddNhomDuAn(NhomDuAn);

            return RedirectToPage("./Index");
        }
    }
}
