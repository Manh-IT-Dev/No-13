using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.ThongKe_html
{
    public class IndexModel : PageModel
    {
        private readonly IThongKeService _thongKeService;

        public IndexModel(IThongKeService thongKeService)
        {
            _thongKeService = thongKeService;
        }

        public IList<ThongKe> ThongKe { get; set; } = default!;

        public async Task OnGetAsync()
        {
            ThongKe = await _thongKeService.GetAllThongKe();
        }
    }
}
