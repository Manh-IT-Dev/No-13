using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SWP_Booking.Repositories.Entities;

public partial class SwpBookingDbContext : DbContext
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public SwpBookingDbContext()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    {
    }

    public SwpBookingDbContext(DbContextOptions<SwpBookingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<DanhGia> DanhGia { get; set; }

    public virtual DbSet<DiemVi> DiemVis { get; set; }

    public virtual DbSet<LichGap> LichGaps { get; set; }

    public virtual DbSet<Mentor> Mentors { get; set; }

    public virtual DbSet<NhomDuAn> NhomDuAns { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    public virtual DbSet<ThongBao> ThongBaos { get; set; }

    public virtual DbSet<ThongKe> ThongKes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=Laptop\\SQLEXPRESS;Initial Catalog=SWP_BookingDB;Integrated Security=True;User iD=as;Password=28092005;Trust Server Certificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.IdAdmin).HasName("PK__Admin__69F5676638A7531A");

            entity.ToTable("Admin");

            entity.HasIndex(e => e.Email, "UQ__Admin__A9D10534155D7E35").IsUnique();

            entity.Property(e => e.IdAdmin)
                .ValueGeneratedNever()
                .HasColumnName("ID_Admin");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.MatKhau).HasMaxLength(255);
            entity.Property(e => e.Ten).HasMaxLength(255);
        });

        modelBuilder.Entity<DanhGia>(entity =>
        {
            entity.HasKey(e => e.IdDanhGia).HasName("PK__DanhGia__6C898AE1532F9EA8");

            entity.Property(e => e.IdDanhGia)
                .ValueGeneratedNever()
                .HasColumnName("ID_DanhGia");
            entity.Property(e => e.IdMentor).HasColumnName("ID_Mentor");
            entity.Property(e => e.IdSinhVien).HasColumnName("ID_SinhVien");
            entity.Property(e => e.NgayDanhGia).HasColumnType("datetime");
            entity.Property(e => e.NhanXet).HasColumnType("text");

            entity.HasOne(d => d.EmailMentor).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.IdMentor)
                .HasConstraintName("FK__DanhGia__ID_Ment__534D60F1");

            entity.HasOne(d => d.EmailSinhVien).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.IdSinhVien)
                .HasConstraintName("FK__DanhGia__ID_Sinh__52593CB8");
        });

        modelBuilder.Entity<DiemVi>(entity =>
        {
            entity.HasKey(e => e.IdDiemVi).HasName("PK__DiemVi__47C590BDE58F8689");

            entity.ToTable("DiemVi");

            entity.Property(e => e.IdDiemVi)
                .ValueGeneratedNever()
                .HasColumnName("ID_DiemVi");
            entity.Property(e => e.IdSinhVien).HasColumnName("ID_SinhVien");
            entity.Property(e => e.NgayCapNhat).HasColumnType("datetime");

            entity.HasOne(d => d.IdSinhVienNavigation).WithMany(p => p.DiemVis)
                .HasForeignKey(d => d.IdSinhVien)
                .HasConstraintName("FK__DiemVi__ID_SinhV__5165187F");
        });

        modelBuilder.Entity<LichGap>(entity =>
        {
            entity.HasKey(e => e.IdLichGap).HasName("PK__LichGap__F9FADFE848E7B885");

            entity.ToTable("LichGap");

            entity.Property(e => e.IdLichGap)
                .ValueGeneratedNever()
                .HasColumnName("ID_LichGap");
            entity.Property(e => e.IdMentor).HasColumnName("ID_Mentor");
            entity.Property(e => e.IdSinhVien).HasColumnName("ID_SinhVien");
            entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            entity.Property(e => e.TrangThai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Ðã xác nh?n");

            entity.HasOne(d => d.IdMentorNavigation).WithMany(p => p.LichGaps)
                .HasForeignKey(d => d.IdMentor)
                .HasConstraintName("FK__LichGap__ID_Ment__5070F446");

            entity.HasOne(d => d.IdSinhVienNavigation).WithMany(p => p.LichGaps)
                .HasForeignKey(d => d.IdSinhVien)
                .HasConstraintName("FK__LichGap__ID_Sinh__4F7CD00D");
        });

        modelBuilder.Entity<Mentor>(entity =>
        {
            entity.HasKey(e => e.IdMentor).HasName("PK__Mentor__9ADA71F3C9CA18E8");

            entity.ToTable("Mentor");

            entity.HasIndex(e => e.Email, "UQ__Mentor__A9D105340FD4D6D6").IsUnique();

            entity.Property(e => e.IdMentor)
                .ValueGeneratedNever()
                .HasColumnName("ID_Mentor");
            entity.Property(e => e.ChuyenMon).HasColumnType("text");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.KiNang).HasColumnType("text");
            entity.Property(e => e.LichLamViec).HasColumnType("text");
            entity.Property(e => e.Ten).HasMaxLength(255);
        });

        modelBuilder.Entity<NhomDuAn>(entity =>
        {
            entity.HasKey(e => e.IdNhom).HasName("PK__NhomDuAn__A6D1994F5EDA3862");

            entity.ToTable("NhomDuAn");

            entity.Property(e => e.IdNhom)
                .ValueGeneratedNever()
                .HasColumnName("ID_Nhom");
            entity.Property(e => e.ChuDeDuAn).HasMaxLength(255);
            entity.Property(e => e.IdSinhVien).HasColumnName("ID_SinhVien");
            entity.Property(e => e.TenNhom).HasMaxLength(255);
            entity.Property(e => e.TienDo).HasMaxLength(255);

            entity.HasOne(d => d.IdSinhVienNavigation).WithMany(p => p.NhomDuAns)
                .HasForeignKey(d => d.IdSinhVien)
                .HasConstraintName("FK__NhomDuAn__ID_Sin__4E88ABD4");
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.IdSinhVien).HasName("PK__SinhVien__61584889DEAB57E7");

            entity.ToTable("SinhVien");

            entity.HasIndex(e => e.Email, "UQ__SinhVien__A9D10534BF5268FB").IsUnique();

            entity.Property(e => e.IdSinhVien)
                .ValueGeneratedNever()
                .HasColumnName("ID_SinhVien");
            entity.Property(e => e.DiemVi).HasDefaultValue(0);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.LichSuGap).HasColumnType("text");
            entity.Property(e => e.MatKhau).HasMaxLength(255);
            entity.Property(e => e.Ten).HasMaxLength(255);
        });

        modelBuilder.Entity<ThongBao>(entity =>
        {
            entity.HasKey(e => e.IdThongBao).HasName("PK__ThongBao__4D0B05D40A317CF0");

            entity.ToTable("ThongBao");

            entity.Property(e => e.IdThongBao)
                .ValueGeneratedNever()
                .HasColumnName("ID_ThongBao");
            entity.Property(e => e.IdSinhVien).HasColumnName("ID_SinhVien");
            entity.Property(e => e.NgayGui).HasColumnType("datetime");
            entity.Property(e => e.NoiDung).HasColumnType("text");
            entity.Property(e => e.TrangThai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Chua d?c");

            entity.HasOne(d => d.IdSinhVienNavigation).WithMany(p => p.ThongBaos)
                .HasForeignKey(d => d.IdSinhVien)
                .HasConstraintName("FK__ThongBao__ID_Sin__5441852A");
        });

        modelBuilder.Entity<ThongKe>(entity =>
        {
            entity.HasKey(e => e.IdThongKe).HasName("PK__ThongKe__405C4D3D1D4836BF");

            entity.ToTable("ThongKe");

            entity.Property(e => e.IdThongKe)
                .ValueGeneratedNever()
                .HasColumnName("ID_ThongKe");
            entity.Property(e => e.IdAdmin).HasColumnName("ID_Admin");

            entity.HasOne(d => d.IdAdminNavigation).WithMany(p => p.ThongKes)
                .HasForeignKey(d => d.IdAdmin)
                .HasConstraintName("FK__ThongKe__ID_Admi__5535A963");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
