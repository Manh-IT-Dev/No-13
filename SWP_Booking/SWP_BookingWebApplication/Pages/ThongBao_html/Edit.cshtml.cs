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

namespace SWP_BookingWebApplication.Pages.ThongBao_html
{
    public class EditModel : PageModel
    {
        private readonly IThongBaoService _thongBaoService;
        private readonly ISinhVienService _sinhVienService;
        public EditModel(IThongBaoService thongBaoService, ISinhVienService sinhVienService)
        {
            _thongBaoService = thongBaoService;
            _sinhVienService = sinhVienService;
        }

        [BindProperty]
        public ThongBao ThongBao { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thongbao = await _thongBaoService.GetThongBaoById((int)id);
            if (thongbao == null)
            {
                return NotFound();
            }
            ThongBao = thongbao;
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

            _thongBaoService.UpdateThongBao(ThongBao);

            return RedirectToPage("./Index");
        }

        private bool ThongBaoExists(int id)
        {
            return _thongBaoService.GetThongBaoById(id) != null;
        }
    }
}
