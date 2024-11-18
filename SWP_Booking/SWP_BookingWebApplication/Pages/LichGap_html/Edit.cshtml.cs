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

namespace SWP_BookingWebApplication.Pages.LichGap_html
{
    public class EditModel : PageModel
    {
        private readonly ILichGapService _lichGapService;
        private readonly ISinhVienService _sinhVienService;
        private readonly IMentorService _mentorService;

        public EditModel(ILichGapService lichGapService, ISinhVienService sinhVienService, IMentorService mentorService)
        {
            _lichGapService = lichGapService;
            _sinhVienService = sinhVienService;
            _mentorService = mentorService;
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
            if (lichgap == null)
            {
                return NotFound();
            }
            LichGap = lichgap;
            var sinhvien = await _sinhVienService.GetAllSinhVien();
            var mentor = await _mentorService.GetAllMentor();
            ViewData["IdMentor"] = new SelectList(mentor, "IdMentor", "Email");
            ViewData["IdSinhVien"] = new SelectList(sinhvien, "IdSinhVien", "Email");
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

            _lichGapService.UpdateLichGap(LichGap);

            return RedirectToPage("./Index");
        }

        private bool LichGapExists(int id)
        {
            return _lichGapService.GetLichGapById(id) != null;
        }
    }
}
