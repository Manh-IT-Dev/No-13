using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.Mentor_html
{
    public class IndexModel : PageModel
    {
        private readonly IMentorService _mentorService;

        public IndexModel(IMentorService mentorService)
        {
            _mentorService = mentorService;
        }

        public IList<Mentor> Mentor { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Mentor = await _mentorService.GetAllMentor();
        }
    }
}
