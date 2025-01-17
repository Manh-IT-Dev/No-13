﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly IDanhGiaService _danhGiaService;

        public DetailsModel(IDanhGiaService danhGiaService)
        {
            _danhGiaService = danhGiaService;
        }

        public DanhGia DanhGia { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var danhgia = await _danhGiaService.GetDanhGiaById((int)id);

            if (danhgia is not null)
            {
                DanhGia = danhgia;

                return Page();
            }

            return NotFound();
        }
    }
}
