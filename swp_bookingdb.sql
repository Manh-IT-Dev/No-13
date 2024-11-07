USE master
GO

CREATE DATABASE SWP_BookingDB
GO

USE SWP_BookingDB
GO

CREATE TABLE [SinhVien] (
  [ID_SinhVien] integer PRIMARY KEY,
  [Ten] nvarchar(255) NOT NULL,
  [Email] nvarchar(255) UNIQUE NOT NULL,
  [MatKhau] nvarchar(255) NOT NULL,
  [DiemVi] integer DEFAULT 0,
  [LichSuGap] text
)
GO

CREATE TABLE [Mentor] (
  [ID_Mentor] integer PRIMARY KEY,
  [Ten] nvarchar(255) NOT NULL,
  [Email] nvarchar(255) UNIQUE NOT NULL,
  [KiNang] text,
  [ChuyenMon] text,
  [LichLamViec] text
)
GO

CREATE TABLE [Admin] (
  [ID_Admin] integer PRIMARY KEY,
  [Ten] nvarchar(255) NOT NULL,
  [Email] nvarchar(255) UNIQUE NOT NULL,
  [MatKhau] nvarchar(255) NOT NULL
)
GO

CREATE TABLE [NhomDuAn] (
  [ID_Nhom] integer PRIMARY KEY,
  [TenNhom] nvarchar(255) NOT NULL,
  [ChuDeDuAn] nvarchar(255) NOT NULL,
  [ID_SinhVien] integer,
  [TienDo] nvarchar(255)
)
GO

CREATE TABLE [LichGap] (
  [ID_LichGap] integer PRIMARY KEY,
  [ID_SinhVien] integer,
  [ID_Mentor] integer,
  [ThoiGian] datetime NOT NULL,
  [TrangThai] VARCHAR(20) NOT NULL DEFAULT 'Đã xác nhận' CHECK (TrangThai IN ('Đã xác nhận', 'Đã hủy', 'Hoàn thành'))
)
GO

CREATE TABLE [DiemVi] (
  [ID_DiemVi] integer PRIMARY KEY,
  [ID_SinhVien] integer,
  [SoDiem] integer,
  [NgayCapNhat] datetime
)
GO

CREATE TABLE [DanhGia] (
  [ID_DanhGia] integer PRIMARY KEY,
  [ID_SinhVien] integer,
  [ID_Mentor] integer,
  [DiemDanhGia] integer,
  [NhanXet] text,
  [NgayDanhGia] datetime
)
GO

CREATE TABLE [ThongBao] (
  [ID_ThongBao] integer PRIMARY KEY,
  [ID_SinhVien] integer,
  [NoiDung] text,
  [NgayGui] datetime,
  [TrangThai] varchar(20) NOT NULL DEFAULT 'Chưa đọc' CHECK (TrangThai IN ('Đã đọc','Chưa đọc'))
)
GO

CREATE TABLE [ThongKe] (
  [ID_ThongKe] integer PRIMARY KEY,
  [ID_Admin] integer,
  [SoBuoiGap] integer,
  [SuDungDiemVi] integer,
  [DanhGiaHieuQua] float
)
GO

ALTER TABLE [NhomDuAn] ADD FOREIGN KEY ([ID_SinhVien]) REFERENCES [SinhVien] ([ID_SinhVien])
GO

ALTER TABLE [LichGap] ADD FOREIGN KEY ([ID_SinhVien]) REFERENCES [SinhVien] ([ID_SinhVien])
GO

ALTER TABLE [LichGap] ADD FOREIGN KEY ([ID_Mentor]) REFERENCES [Mentor] ([ID_Mentor])
GO

ALTER TABLE [DiemVi] ADD FOREIGN KEY ([ID_SinhVien]) REFERENCES [SinhVien] ([ID_SinhVien])
GO

ALTER TABLE [DanhGia] ADD FOREIGN KEY ([ID_SinhVien]) REFERENCES [SinhVien] ([ID_SinhVien])
GO

ALTER TABLE [DanhGia] ADD FOREIGN KEY ([ID_Mentor]) REFERENCES [Mentor] ([ID_Mentor])
GO

ALTER TABLE [ThongBao] ADD FOREIGN KEY ([ID_SinhVien]) REFERENCES [SinhVien] ([ID_SinhVien])
GO

ALTER TABLE [ThongKe] ADD FOREIGN KEY ([ID_Admin]) REFERENCES [Admin] ([ID_Admin])
GO
