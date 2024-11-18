using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SWP_Mentor_Booking_System.Pages
{
    public class DangNhapModel : PageModel
    {
        private readonly ILogger<DangNhapModel> _logger;

        public DangNhapModel(ILogger<DangNhapModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
