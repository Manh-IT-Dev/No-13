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
    public class DeleteModel : PageModel
    {
        private readonly IMentorService _mentorService;

        public DeleteModel(IMentorService mentorService)
        {
            _mentorService = mentorService;
        }

        [BindProperty]
        public Mentor Mentor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mentor = await _mentorService.GetMentorById((int)id);

            if (mentor is not null)
            {
                Mentor = mentor;

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

            _mentorService.DeleteMentor((int)id);

            return RedirectToPage("./Index");
        }
    }
}
