using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Repositories.Interface;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.NhomDuAn_html
{
    public class IndexModel : PageModel
    {
        private readonly INhomDuAnService _nhomDuAnService;

        public IndexModel(INhomDuAnService nhomDuAnService)
        {
            _nhomDuAnService = nhomDuAnService;
        }

        public IList<NhomDuAn> NhomDuAn { get; set; } = default!;

        public async Task OnGetAsync()
        {
            NhomDuAn = await _nhomDuAnService.GetAllNhomDuAn();
        }
    }
}
