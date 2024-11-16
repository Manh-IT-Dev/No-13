using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.Admin_html
{
    public class CreateModel : PageModel
    {
        private readonly IAdminService _adminService;

        public CreateModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var Admins = await _adminService.GetAllAdmin();
            ViewData["Admin"] = new SelectList(Admins, "IdAdmin", "Ten", "Email");
            return Page();
        }

        [BindProperty]
        public Admin Admin { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _adminService.AddAdmin(Admin);

            return RedirectToPage("./Index");
        }
    }
}
