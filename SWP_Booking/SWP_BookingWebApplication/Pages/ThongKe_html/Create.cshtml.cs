using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.ThongKe_html
{
    public class CreateModel : PageModel
    {
        private readonly IThongKeService _thongKeService;
        private readonly IAdminService _adminService;

        public CreateModel(IThongKeService thongKeService, IAdminService adminService)
        {
            _thongKeService = thongKeService;
            _adminService = adminService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            ViewData["IdAdmin"] = new SelectList(await _adminService.GetAllAdmin(), "IdAdmin", "Email");
            return Page();
        }

        [BindProperty]
        public ThongKe ThongKe { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _thongKeService.AddThongKe(ThongKe);

            return RedirectToPage("./Index");
        }
    }
}
