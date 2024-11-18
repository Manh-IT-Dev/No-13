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

namespace SWP_BookingWebApplication.Pages.ThongKe_html
{
    public class EditModel : PageModel
    {
        private readonly IThongKeService _thongKeService;
        private readonly IAdminService _adminService;

        public EditModel(IThongKeService thongKeService, IAdminService adminService)
        {
            _thongKeService = thongKeService;
            _adminService = adminService;
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
            if (thongke == null)
            {
                return NotFound();
            }
            ThongKe = thongke;
            ViewData["IdAdmin"] = new SelectList(await _adminService.GetAllAdmin(), "IdAdmin", "Email");
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

            _thongKeService.UpdateThongKe(ThongKe);

            return RedirectToPage("./Index");
        }

        private bool ThongKeExists(int id)
        {
            return _thongKeService.GetThongKeById(id) != null;
        }
    }
}
