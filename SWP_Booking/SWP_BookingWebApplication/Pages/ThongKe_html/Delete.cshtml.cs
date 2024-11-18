using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.ThongKe_html
{
    public class DeleteModel : PageModel
    {
        private readonly IThongKeService _thongKeService;

        public DeleteModel(IThongKeService thongKeService)
        {
            _thongKeService = thongKeService;
        }


        [BindProperty]
        public ThongKe ThongKe { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thongke = await _thongKeService.GetThongKeById((int)id);

            if (thongke is not null)
            {
                ThongKe = thongke;

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

            _thongKeService.DeleteThongKe((int)id);

            return RedirectToPage("./Index");
        }
    }
}
