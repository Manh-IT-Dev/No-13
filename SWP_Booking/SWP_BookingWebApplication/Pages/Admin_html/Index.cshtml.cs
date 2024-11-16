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
    public class IndexModel : PageModel
    {
        private readonly IAdminService _adminService;

        public IndexModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IList<Admin> Admin { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Admin = await _adminService.GetAllAdmin();
        }
    }
}
