using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.Mentor_html
{
    public class CreateModel : PageModel
    {
        private readonly IMentorService _mentorService;

        public CreateModel(IMentorService mentorService)
        {
            _mentorService = mentorService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Mentor Mentor { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _mentorService.AddMentor(Mentor);

            return RedirectToPage("./Index");
        }
    }
}
