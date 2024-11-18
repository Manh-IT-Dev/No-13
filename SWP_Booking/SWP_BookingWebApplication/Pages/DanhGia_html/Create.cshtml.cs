using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.DanhGia_html
{
    public class CreateModel : PageModel
    {
        private readonly IDanhGiaService _danhGiaService;
        private readonly IMentorService _mentorService;
        private readonly ISinhVienService _sinhVienService;

        public CreateModel(IDanhGiaService danhGiaService, IMentorService mentorService, ISinhVienService sinhVienService)
        {
            _danhGiaService = danhGiaService;
            _mentorService = mentorService;
            _sinhVienService = sinhVienService;
        }

        public async Task<IActionResult> OnGetAsync()
        {

            ViewData["IdMentor"] = new SelectList(await _mentorService.GetAllMentor(), "IdMentor", "Email");
            ViewData["IdSinhVien"] = new SelectList(await _sinhVienService.GetAllSinhVien(), "IdSinhVien", "Email");
            return Page();
        }

        [BindProperty]
        public DanhGia DanhGia { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _danhGiaService.AddDanhGia(DanhGia);

            return RedirectToPage("./Index");
        }
    }
}
