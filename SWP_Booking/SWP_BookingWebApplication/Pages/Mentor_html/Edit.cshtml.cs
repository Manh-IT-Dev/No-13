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

namespace SWP_BookingWebApplication.Pages.Mentor_html
{
    public class EditModel : PageModel
    {
        private readonly IMentorService _mentorService;

        public EditModel(IMentorService mentorService)
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
            if (mentor == null)
            {
                return NotFound();
            }
            Mentor = mentor;
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

            _mentorService.UpdateMentor(Mentor);

            return RedirectToPage("./Index");
        }

        private bool MentorExists(int id)
        {
            return _mentorService.GetMentorById(id) != null;
        }
    }
}
