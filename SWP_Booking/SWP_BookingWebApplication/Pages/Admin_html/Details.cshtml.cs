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
    public class DetailsModel : PageModel
    {
        private readonly IAdminService _adminService;

        public DetailsModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

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
    }
}
