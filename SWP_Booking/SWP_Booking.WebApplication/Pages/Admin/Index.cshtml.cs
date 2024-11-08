using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;

namespace SWP_Booking.WebApplication.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly SWP_Booking.Repositories.Entities.SwpBookingDbContext _context;

        public IndexModel(SWP_Booking.Repositories.Entities.SwpBookingDbContext context)
        {
            _context = context;
        }

        public IList<Admin> Admin { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Admin = await _context.Admins.ToListAsync();
        }
    }
}
