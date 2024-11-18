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

namespace SWP_BookingWebApplication.Pages.DanhGia_html
{
    public class EditModel : PageModel
    {
        private readonly IDanhGiaService _danhGiaService;
        private readonly IMentorService _mentorService;
        private readonly ISinhVienService _sinhVienService;

        public EditModel(IDanhGiaService danhGiaService, IMentorService mentorService, ISinhVienService sinhVienService)
        {
            _danhGiaService = danhGiaService;
            _mentorService = mentorService;
            _sinhVienService = sinhVienService;
        }

        [BindProperty]
        public DanhGia DanhGia { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var danhgia = await _danhGiaService.GetDanhGiaById((int)id);
            if (danhgia == null)
            {
                return NotFound();
            }
            DanhGia = danhgia;
            var mentor = await _mentorService.GetAllMentor();
            var sinhvien = await _sinhVienService.GetAllSinhVien();
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

            _danhGiaService.UpdateDanhGia(DanhGia);

            return RedirectToPage("./Index");
        }

        private bool DanhGiaExists(int id)
        {
            return _danhGiaService.GetDanhGiaById(id) != null;
        }
    }
}
