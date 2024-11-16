using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.SinhVien_html
{
    public class IndexModel : PageModel
    {
        private readonly ISinhVienService _sinhVienService;

        public IndexModel(ISinhVienService sinhVienService)
        {
            _sinhVienService = sinhVienService;
        }

        public IList<SinhVien> SinhVien { get; set; } = default!;

        public async Task OnGetAsync()
        {
            SinhVien = await _sinhVienService.GetAllSinhVien();
        }
    }
}
