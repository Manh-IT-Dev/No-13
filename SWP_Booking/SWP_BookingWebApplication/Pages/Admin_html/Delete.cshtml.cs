using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.Admin_html
{
    public class DeleteModel : PageModel
    {
        private readonly IAdminService _adminService;

        public DeleteModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public Admin Admin { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _adminService.GetAdminById((int)id);

            if (admin is not null)
            {
                Admin = admin;

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

            _adminService.DeleteAdmin((int)id);

            return RedirectToPage("./Index");
        }
    }
}
