using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.DiemVi_html
{
    public class CreateModel : PageModel
    {
        private readonly IDiemViService _diemViService;
        private readonly ISinhVienService _sinhVienService;
        public CreateModel(IDiemViService diemViService, ISinhVienService sinhVienService)
        {
            _diemViService = diemViService;
            _sinhVienService = sinhVienService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            ViewData["IdSinhVien"] = new SelectList(await _sinhVienService.GetAllSinhVien(), "IdSinhVien", "Email");
            return Page();
        }

        [BindProperty]
        public DiemVi DiemVi { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _diemViService.AddDiemVi(DiemVi);

            return RedirectToPage("./Index");
        }
    }
}
