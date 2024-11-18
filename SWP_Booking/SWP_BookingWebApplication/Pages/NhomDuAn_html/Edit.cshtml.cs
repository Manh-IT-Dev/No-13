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

namespace SWP_BookingWebApplication.Pages.NhomDuAn_html
{
    public class EditModel : PageModel
    {
        private readonly INhomDuAnService _nhomDuAnService;
        private readonly ISinhVienService _sinhVienService;

        public EditModel(INhomDuAnService nhomDuAnService, ISinhVienService sinhVienService)
        {
            _nhomDuAnService = nhomDuAnService;
            _sinhVienService = sinhVienService;
        }


        [BindProperty]
        public NhomDuAn NhomDuAn { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhomduan = await _nhomDuAnService.GetNhomDuAnById((int)id);
            if (nhomduan == null)
            {
                return NotFound();
            }
            NhomDuAn = nhomduan;
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

            _nhomDuAnService.UpdateNhomDuAn(NhomDuAn);

            return RedirectToPage("./Index");
        }

        private bool NhomDuAnExists(int id)
        {
            return _nhomDuAnService.GetNhomDuAnById(id) != null;
        }
    }
}
