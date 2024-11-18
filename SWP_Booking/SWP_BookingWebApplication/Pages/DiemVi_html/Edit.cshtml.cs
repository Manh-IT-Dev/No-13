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

namespace SWP_BookingWebApplication.Pages.DiemVi_html
{
    public class EditModel : PageModel
    {
        private readonly IDiemViService _diemViService;
        private readonly ISinhVienService _sinhVienService;

        public EditModel(IDiemViService diemViService, ISinhVienService sinhVienService)
        {
            _diemViService = diemViService;
            _sinhVienService = sinhVienService;
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
            if (diemvi == null)
            {
                return NotFound();
            }
            DiemVi = diemvi;
            ViewData["IdSinhVien"] = new SelectList(await _sinhVienService.GetAllSinhVien(), "IdSinhVien", "Email");
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

            _diemViService.UpdateDiemVi(DiemVi);

            return RedirectToPage("./Index");
        }

        private bool DiemViExists(int id)
        {
            return _diemViService.GetDiemViById(id) != null;
        }
    }
}
