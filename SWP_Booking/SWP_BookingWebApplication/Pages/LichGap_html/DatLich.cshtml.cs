using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.SinhVien_html
{
    public class DatLichModel : PageModel
    {
        private readonly ILichGapService _lichGapService;
        private readonly ISinhVienService _sinhVienService;
        private readonly IMentorService _mentorService;

        public DatLichModel(ILichGapService lichGapService, ISinhVienService sinhVienService, IMentorService mentorService)
        {
            _lichGapService = lichGapService;
            _sinhVienService = sinhVienService;
            _mentorService = mentorService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var sinhvien = await _sinhVienService.GetAllSinhVien();
            var mentor = await _mentorService.GetAllMentor();
            ViewData["IdSinhVien"] = new SelectList(sinhvien, "IdSinhVien", "Email");
            ViewData["IdMentor"] = new SelectList(mentor, "IdMentor", "Email");
            return Page();
        }

        [BindProperty]
        public LichGap LichGap { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _lichGapService.AddLichGap(LichGap);

            return RedirectToPage("./Index");
        }
    }
}
