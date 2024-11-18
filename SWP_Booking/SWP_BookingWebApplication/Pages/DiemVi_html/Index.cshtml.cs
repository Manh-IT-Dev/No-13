using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.DiemVi_html
{
    public class IndexModel : PageModel
    {
        private readonly IDiemViService _diemViService;

        public IndexModel(IDiemViService diemViService)
        {
            _diemViService = diemViService;
        }

        public IList<DiemVi> DiemVi { get; set; } = default!;

        public async Task OnGetAsync()
        {
            DiemVi = await _diemViService.GetAllDiemVi();
        }
    }
}
