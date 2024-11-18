using SWP_Booking.Repositories.Entities;
using SWP_Booking.Repositories.Interface;
using SWP_Booking.Repositories;
using SWP_Booking.Services.Interface;
using SWP_Booking.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//DI
builder.Services.AddDbContext<SwpBookingDbContext>();
//DI Repositories
builder.Services.AddScoped<IAdminRepository, AdminRepository>();
builder.Services.AddScoped<ISinhVienRepository, SinhVienRepository>();
builder.Services.AddScoped<ILichGapRepository, LichGapRepository>();
builder.Services.AddScoped<IMentorRepository, MentorRepository>();
builder.Services.AddScoped<IDanhGiaRepository, DanhGiaRepository>();
builder.Services.AddScoped<IDiemViRepository, DiemViRepository>();
builder.Services.AddScoped<INhomDuAnRepository, NhomDuAnRepository>();
builder.Services.AddScoped<IThongBaoRepository, ThongBaoRepository>();
builder.Services.AddScoped<IThongKeRepository, ThongKeRepository>();

//DI Services
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<ISinhVienService, SinhVienService>();
builder.Services.AddScoped<ILichGapService, LichGapService>();
builder.Services.AddScoped<IMentorService, MentorService>();
builder.Services.AddScoped<IDanhGiaService, DanhGiaService>();
builder.Services.AddScoped<IDiemViService, DiemViService>();
builder.Services.AddScoped<INhomDuAnService, NhomDuAnService>();
builder.Services.AddScoped<IThongBaoService, ThongBaoService>();
builder.Services.AddScoped<IThongKeService, ThongKeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
