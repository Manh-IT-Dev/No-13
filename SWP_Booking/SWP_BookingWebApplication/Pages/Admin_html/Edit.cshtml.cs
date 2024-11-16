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

namespace SWP_BookingWebApplication.Pages.Admin_html
{
    public class EditModel : PageModel
    {
        private readonly IAdminService _adminService;

        public EditModel(IAdminService adminService)
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
            if (admin == null)
            {
                return NotFound();
            }
            Admin = admin;
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

            _adminService.UpdateAdmin(Admin);

            return RedirectToPage("./Index");
        }

        private bool AdminExists(int id)
        {
            return _adminService.GetAdminById(id) != null;
        }
    }
}
