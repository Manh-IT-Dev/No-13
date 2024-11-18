using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWP_Booking.Repositories.Entities;
using SWP_Booking.Services.Interface;

namespace SWP_BookingWebApplication.Pages.DanhGia_html
{
    public class IndexModel : PageModel
    {
        private readonly IDanhGiaService _danhGiaService;

        public IndexModel(IDanhGiaService danhGiaService)
        {
            _danhGiaService = danhGiaService;
        }

        public IList<DanhGia> DanhGia { get; set; } = default!;

        public async Task OnGetAsync()
        {
            DanhGia = await _danhGiaService.GetAllDanhGia();
        }
    }
}
