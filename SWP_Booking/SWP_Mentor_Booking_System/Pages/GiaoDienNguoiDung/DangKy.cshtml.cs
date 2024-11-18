using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SWP_Mentor_Booking_System.Pages
{
    public class DangKyModel : PageModel
    {
        private readonly ILogger<DangKyModel> _logger;

        public DangKyModel(ILogger<DangKyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
