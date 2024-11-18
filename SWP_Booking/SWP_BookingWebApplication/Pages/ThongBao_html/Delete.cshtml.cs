using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.ThongBao_html
{
    public class DeleteModel : PageModel
    {
        private readonly IThongBaoService _thongBaoService;

        public DeleteModel(IThongBaoService thongBaoService)
        {
            _thongBaoService = thongBaoService;
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

            if (thongbao is not null)
            {
                ThongBao = thongbao;

                return Page();
            }

            return NotFound();
        }

        public IActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _thongBaoService.DeleteThongBao((int)id);

            return RedirectToPage("./Index");
        }
    }
}
