/*UPDATE 1: create database, table, view, ... (HUNG)*/
-- create database for group 2
CREATE DATABASE QL_BANHANG2
GO

-- using this database
USE [QL_BanHang2]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admin2](
	[TaiKhoan] [varchar](100) NOT NULL,
	[MatKhau] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Admin_1] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Admin2] ([TaiKhoan], [MatKhau]) VALUES (N'admin', N'123456')
INSERT [dbo].[Admin2] ([TaiKhoan], [MatKhau]) VALUES (N'1', N'1')

-- create table TrinhDo
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TrinhDo2](
	[MaTrinhDo] [varchar](100) NOT NULL,
	[TenTrinhDo] [nvarchar](200) NOT NULL,
	[LuongCung] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_TrinhDo] PRIMARY KEY CLUSTERED 
(
	[MaTrinhDo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

-- insert data to table TrinhDo
insert into TrinhDo2 values (N'td001', N'đại học', N'80000000')
insert into TrinhDo2 values (N'td002', N'cao đẳng', N'90000000')
insert into TrinhDo2 values (N'td003', N'cấp 3', N'100000000')

-- create table NhanVien
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien2](
	[MaNV] [varchar](100) NOT NULL,
	[TenNV] [nvarchar](200) NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[SDT] [varchar](20) NOT NULL,
	[MaTrinhDo] [varchar](100) NOT NULL,
	[TaiKhoan] [varchar](100) NOT NULL,
	[MatKhau] [varchar](100) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

insert into NhanVien2 values (N'nv001', N'vũ văn hùng', 0, N'thái bình', N'0366310685', N'td001', '1', '1')
insert into NhanVien2 values (N'nv002', N'nguyễn khắc hiếu', 0, N'hà nội', N'0366310685', N'td002', '2', '2')
insert into NhanVien2 values (N'nv003', N'phạm văn yên', 0, N'quảng ninh', N'0366310685', N'td003', '3', '3')
insert into NhanVien2 values (N'nv004', N'vũ việt tùng', 0, N'phú thọ', N'0366310685', N'td001', '4', '4')

-- create table NhaCungCap
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap2](
	[MaNCC] [varchar](100) NOT NULL,
	[TenNCC] [nvarchar](200) NOT NULL,
	[SDT] [int] NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

insert into NhaCungCap2 values (N'ncc001', N'trung nguyên', N'0123111', N'tây nguyên')
insert into NhaCungCap2 values (N'ncc002', N'1994 cooktice', N'0999121', N'đan phượng')
insert into NhaCungCap2 values (N'ncc003', N'1994 tea', N'0129988', N'hà nội')

-- create table KhachHang
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang2](
	[MaKH] [varchar](100) NOT NULL,
	[TenKH] [nvarchar](200) NOT NULL,
	[SDT] [varchar](20) NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[MaNV] [varchar](100) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

insert into KhachHang2 values (N'kh001', N'vũ văn hùng', N'0366310685', 0, N'thái bình', N'nv001')
insert into KhachHang2 values (N'kh002', N'nguyễn khắc hiếu', N'0366310685', 0, N'hà nội', N'nv001')
insert into KhachHang2 values (N'kh003', N'phạm văn yên', N'0366310685', 0, N'quảng ninh', N'nv001')
insert into KhachHang2 values (N'kh004', N'vũ việt tùng', N'0366310685', 0, N'sao hỏa', N'nv001')

-- create table LoaiHang
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiHang2](
	[MaLoai] [varchar](100) NOT NULL,
	[TenLoai] [nvarchar](200) NOT NULL,
	[GhiChu] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_LoaiHang] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

insert into LoaiHang2 values ('lh001', N'cafe', N'không ngọt')
insert into LoaiHang2 values ('lh002', N'nước ép', N'ngon')
insert into LoaiHang2 values ('lh003', N'trà', N'chua')

-- create table Hang
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hang2](
	[MaHH] [varchar](100) NOT NULL,
	[TenHang] [nvarchar](200) NOT NULL,
	[DonViTinh] [nvarchar](10) NOT NULL,
	[DonGia] [int] NOT NULL,
	[MaLoai] [nvarchar](100) NOT NULL,
	[MaNCC] [varchar](100) NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

insert into Hang2 values (N'h001', N'cafe đá', N'ml', 50000, N'lh001', N'ncc001', 100)
insert into Hang2 values (N'h002', N'nước cam', N'l', 60000, N'lh002', N'ncc002', 200)
insert into Hang2 values (N'h003', N'trà chanh', N'ml', 30000, N'lh003', N'ncc003', 300)

-- create table HoaDon
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon2](
	[MaHD] [varchar](10) NOT NULL,
	[MaKH] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[NgayLap] [date] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

insert into HoaDon2 values ('hd001', 'kh001', 'nv004', '3/6/2020')
insert into HoaDon2 values ('hd002', 'kh002', 'nv003', '4/6/2020')
insert into HoaDon2 values ('hd003', 'kh003', 'nv002', '5/6/2020')
insert into HoaDon2 values ('hd004', 'kh004', 'nv001', '6/6/2020')
insert into HoaDon2 values ('hd005', 'kh001', 'nv004', '7/6/2020')
insert into HoaDon2 values ('hd006', 'kh002', 'nv003', '8/6/2020')

-- create view HangTon
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[HangTon2]
as
select Hang2.MaHH,Hang2.TenHang,NhaCungCap2.TenNCC,Hang2.DonGia,Hang2.SoLuong
from Hang2 inner join NhaCungCap2 on Hang2.MaNCC = NhaCungCap2.MaNCC
group by Hang2.MaHH,Hang2.TenHang,NhaCungCap2.TenNCC,Hang2.DonGia,Hang2.SoLuong
GO

-- create table ChiTietHoaDon
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon2](
	[MaHDCT] [varchar](100) NOT NULL,
	[MaHH] [varchar](100) NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHDCT] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

insert into ChiTietHoaDon2 values (N'hd1', N'h001', 2000)
insert into ChiTietHoaDon2 values (N'hd1', N'h002', 2000)
insert into ChiTietHoaDon2 values (N'hd2', N'h003', 3000)
insert into ChiTietHoaDon2 values (N'hd2', N'h004', 2000)


-- create table LichSuGia
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LichSuGia2](
	[MaHH] [varchar](10) NOT NULL,
	[NgayBatDau] [date] NOT NULL,
	[NgayKetThuc] [date] NOT NULL,
	[DonGia] [int] NOT NULL,
	[NgayCapNhat] [date] NOT NULL,
 CONSTRAINT [PK_LichSuGia] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC,
	[NgayBatDau] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

insert into LichSuGia2 values ('h001', '1/6/2020', '6/6/2020', 40000, '7/6/2020')
insert into LichSuGia2 values ('h002', '2/6/2020', '7/6/2020', 50000, '6/6/2020')
insert into LichSuGia2 values ('h003', '3/6/2020', '8/6/2020', 60000, '4/6/2020')

-- create view DoanhThu
GO
use QL_BanHang2
go
alter view [dbo].[DoanhThu2]
as
select ChiTietHoaDon2.MaHH,TenHang,Hang2.DonGia as'dongiaban',ChiTietHoaDon2.SoLuong as'Soluongban',Hang2.SoLuong as'Soluongnhap',Hang2.DonGia as'dongianhap',HoaDon2.NgayLap
from Hang2 inner join ChiTietHoaDon2 on Hang2.MaHH = ChiTietHoaDon2.MaHH inner join HoaDon2 on ChiTietHoaDon2.MaHDCT = HoaDon2.MaHD
group by ChiTietHoaDon2.MaHH,TenHang,Hang2.DonGia,ChiTietHoaDon2.SoLuong,Hang2.SoLuong,Hang2.DonGia,HoaDon2.NgayLap



-- create view DanhSachBan
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[DanhSachBan2]
as	
select ChiTietHoaDon2.MaHDCT,KhachHang2.TenKH,ChiTietHoaDon2.MaHH,Hang2.TenHang,NhaCungCap2.TenNCC,Hang2.DonGia,ChiTietHoaDon2.SoLuong,HoaDon2.MaNV,NhanVien2.TenNV,HoaDon2.NgayLap
from NhaCungCap2 inner join Hang2 on NhaCungCap2.MaNCC = Hang2.MaNCC inner join ChiTietHoaDon2 on Hang2.MaHH = ChiTietHoaDon2.MaHH inner join HoaDon2 on ChiTietHoaDon2.MaHDCT = HoaDon2.MaHD inner join KhachHang2 on HoaDon2.MaKH = KhachHang2.MaKH inner join NhanVien2 on KhachHang2.MaNV = NhanVien2.MaNV
group by ChiTietHoaDon2.MaHDCT,KhachHang2.TenKH,ChiTietHoaDon2.MaHH,Hang2.TenHang,NhaCungCap2.TenNCC,Hang2.DonGia,ChiTietHoaDon2.SoLuong,HoaDon2.MaNV,NhanVien2.TenNV,HoaDon2.NgayLap
GO

/*UPDATE 2: EDIT VIEW (YEN)*/
use QL_BANHANG2
go
drop view BangLuong2
drop view DoanhThu2

create view [dbo].[DoanhThu2]
as
select ChiTietHoaDon2.MaHH,TenHang,Hang2.DonGia as'dongiaban',ChiTietHoaDon2.SoLuong as'Soluongban',Hang2.SoLuong as'Soluongnhap',Hang2.DonGia as'dongianhap',HoaDon2.NgayLap
from Hang2 inner join ChiTietHoaDon2 on Hang2.MaHH = ChiTietHoaDon2.MaHH inner join HoaDon2 on ChiTietHoaDon2.MaHDCT = HoaDon2.MaHD
group by ChiTietHoaDon2.MaHH,TenHang,Hang2.DonGia,ChiTietHoaDon2.SoLuong,Hang2.SoLuong,Hang2.DonGia,HoaDon2.NgayLap

create view [dbo].[BangLuong2]
as
select NhanVien2.MaNV,NhanVien2.TenNV, NhanVien2.GioiTinh,NhanVien2.DiaChi,TrinhDo2.LuongCung as'Luong cung'
from NhanVien2 left join TrinhDo2 on NhanVien2.MaTrinhDo = TrinhDo2.MaTrinhDo
group by NhanVien2.MaNV,NhanVien2.TenNV, NhanVien2.GioiTinh,NhanVien2.DiaChi,TrinhDo2.LuongCung

select * from BangLuong2
/*UPDATE 3: INSERT RIGH DATA TO TABLE*/
-- insert data to table TrinhDo
insert into TrinhDo2 values (N'TĐ1', N'Quản lý', '10000')
insert into TrinhDo2 values (N'TĐ2', N'Nhân viên chạy bàn', '5000')
insert into TrinhDo2 values (N'TĐ3', N'Nhan viên pha chế', '3000')
insert into TrinhDo2 values (N'TĐ4', N'Bảo vệ', '1000')
-- insert data to table NhanVien
insert into NhanVien2 values (N'NV1', N'vũ văn hùng', 0, N'thái bình', N'0366310685', N'TĐ1', '1', '1')
insert into NhanVien2 values (N'NV2', N'nguyễn khắc hiếu', 0, N'hà nội', N'0366310685', N'TĐ2', '1', '1')
insert into NhanVien2 values (N'NV3', N'phạm văn yên', 0, N'quảng ninh', N'0366310685', N'TĐ3', '1', '1')
insert into NhanVien2 values (N'NV4', N'vũ việt tùng', 0, N'phú thọ', N'0366310685', N'TĐ1', '1', '1')
insert into NhanVien2 values (N'NV5', N'vũ trường giang', 0, N'bắc giang', N'0366310685', N'TĐ4', '1', '1')
insert into NhanVien2 values (N'NV6', N'phan hải', 0, N'phú thọ', N'0366310685', N'TĐ2', '1', '1')
insert into NhanVien2 values (N'NV7', N'văn đức', 0, N'phú thọ', N'0366310685', N'TĐ2', '1', '1')
-- insert data to table NhaCungCap
insert into NhaCungCap2 values (N'001', N'trung nguyên', N'0123111', N'tây nguyên')
insert into NhaCungCap2 values (N'002', N'phúc long', N'0999121', N'đan phượng')
insert into NhaCungCap2 values (N'003', N'Monin', N'0129988', N'hà nội')
insert into NhaCungCap2 values (N'004', N'Cty Ocean', N'0123111', N'Mê linh')
insert into NhaCungCap2 values (N'005', N'Cty tnhh Swing', N'0999121', N'đan phượng')
insert into NhaCungCap2 values (N'006', N'Ozy', N'0129988', N'hà nội')
-- insert data to table KhachHang
insert into KhachHang2 values (N'001', N'vũ văn hùng', N'0366310685', 0, N'thái bình', N'001')
insert into KhachHang2 values (N'002', N'nguyễn khắc hiếu', N'0366310685', 0, N'hà nội', N'003')
insert into KhachHang2 values (N'003', N'phạm văn yên', N'0366310685', 0, N'quảng ninh', N'004')
insert into KhachHang2 values (N'004', N'vũ việt tùng', N'0366310685', 0, N'sao hỏa', N'002')
insert into KhachHang2 values (N'005', N'Nguyễn văn tiến', N'0366310685', 0, N'thái bình', N'006')
insert into KhachHang2 values (N'006', N'Trần văn hiếu', N'0366310685', 0, N'hà nội', N'001')
insert into KhachHang2 values (N'007', N'Nguyễn đình trọng', N'0366310685', 0, N'quảng ninh', N'005')
insert into KhachHang2 values (N'008', N'Văn biên', N'0366310685', 0, N'thái bình', N'002')
insert into KhachHang2 values (N'009', N'Peter', N'0366310685', 0, N'hà nội', N'003')
insert into KhachHang2 values (N'010', N'Phạm thị thanh', N'0366310685', 0, N'quảng ninh', N'001')
insert into KhachHang2 values (N'011', N'Trần văn phú', N'0366310685', 0, N'sao hỏa', N'001')
-- insert data to table LoaiHang
insert into LoaiHang2 values ('001', N'cafe', N'cafe phin')
insert into LoaiHang2 values ('002', N'cafe', N'nâu, sữa')
insert into LoaiHang2 values ('003', N'trà', N'nóng')
insert into LoaiHang2 values ('004', N'trà', N'lạnh')
insert into LoaiHang2 values ('005', N'cafe', N'không ngọt')
insert into LoaiHang2 values ('006', N'nước ép', N'Tươi mát')
insert into LoaiHang2 values ('007', N'trà', N'trà chanh')
-- insert data to table Hang
insert into Hang2 values (N'hang1', N'cafe đá', N'nvđ', 20000, N'001', N'001', 100)
insert into Hang2 values (N'hang2', N'cafe nâu', N'nvđ', 20000, N'003', N'005', 200)
insert into Hang2 values (N'hang3', N'trà chanh', N'vnđ', 15000, N'003', N'003', 300)
insert into Hang2 values (N'hang4', N'sinh tố xoài', N'vnđ', 30000, N'005', N'001', 100)
insert into Hang2 values (N'hang5', N'nước cam', N'vnđ', 30000, N'006', N'006', 200)
insert into Hang2 values (N'hang6', N'ép dưa hấu', N'vnđ', 25000, N'002', N'003', 300)
insert into Hang2 values (N'hang7', N'cafe cốt dừa', N'vnđ', 35000, N'005', N'001', 100)
insert into Hang2 values (N'hang8', N'nước ép dứa', N'vnđ', 30000, N'004', N'005', 200)
insert into Hang2 values (N'hang9', N'trà đào cam xả', N'vnđ', 35000, N'004', N'003', 300)
insert into Hang2 values (N'hang10', N'Bạc sỉu', N'vnđ', 25000, N'001', N'001', 100)
insert into Hang2 values (N'hang11', N'trà sữa', N'vnđ', 30000, N'002', N'002', 200)
insert into Hang2 values (N'hang12', N'trà bưởi nhài', N'vnđ', 30000, N'003', N'003', 300)
-- insert data to table HoaDon
insert into HoaDon2 values ('hd1', '001', '004', '3/6/2020')
insert into HoaDon2 values ('hd2', '002', '003', '4/6/2020')
insert into HoaDon2 values ('hd3', '003', '002', '5/6/2020')
insert into HoaDon2 values ('hd4', '004', '001', '6/6/2020')
insert into HoaDon2 values ('005', '005', '004', '7/6/2020')
insert into HoaDon2 values ('hd6', '006', '003', '8/6/2020')
insert into HoaDon2 values ('hd7', '001', '004', '3/6/2020')
insert into HoaDon2 values ('hd8', '007', '003', '4/6/2020')
insert into HoaDon2 values ('hd9', '003', '002', '5/6/2020')
insert into HoaDon2 values ('hd10', '0010', '001', '6/6/2020')
insert into HoaDon2 values ('hd11', '001', '004', '7/6/2020')
insert into HoaDon2 values ('hd12', '002', '003', '8/6/2020')
-- insert data to table ChiTietHoaDon
insert into ChiTietHoaDon2 values  (N'hd001', N'hang1', 2000)
insert into ChiTietHoaDon2 values  (N'hd003', N'hang2', 2000)
insert into ChiTietHoaDon2 values  (N'hd002', N'hang3', 3000)
insert into ChiTietHoaDon2 values  (N'hd004', N'hang4', 2000)
insert into ChiTietHoaDon2 values  (N'hd006', N'hang1', 2000)
insert into ChiTietHoaDon2 values  (N'hd007', N'hang2', 2000)
insert into ChiTietHoaDon2 values  (N'hd008', N'hang3', 3000)
insert into ChiTietHoaDon2 values  (N'hd009', N'hang4', 2000)
-- insert data to table LichSuGia
insert into LichSuGia2 values ('001', '1/6/2020', '6/6/2020', 150000, '7/6/2020')
insert into LichSuGia2 values ('002', '2/6/2020', '7/6/2020',60000, '6/6/2020')
insert into LichSuGia2 values ('004', '3/6/2020', '8/6/2020', 120000, '4/6/2020')
insert into LichSuGia2 values ('005', '1/6/2020', '6/6/2020', 35000, '7/6/2020')
insert into LichSuGia2 values ('003', '2/6/2020', '7/6/2020', 20000, '6/6/2020')
insert into LichSuGia2 values ('003', '3/6/2020', '8/6/2020', 60000, '4/6/2020')


/*UPDATE 4: CREATE VIEW HOA DON*/
use QL_BANHANG2
go
create view HoaDonView
as
	select hd.MaHD, hd.NgayLap, nv.MaNV, nv.TenNV, kh.MaKH, kh.TenKH, sum(cthd.SoLuong * h.DonGia) as 'TongTien' from HoaDon2 hd 
	inner join KhachHang2 kh on hd.MaKH = kh.MaKH 
	inner join NhanVien2 nv on hd.MaNV = nv.MaNV
	left join ChiTietHoaDon2 cthd on hd.MaHD = cthd.MaHDCT
	left join Hang2 h on cthd.MaHH = h.MaHH
	group by hd.MaHD, hd.NgayLap, nv.MaNV, nv.TenNV, kh.MaKH, kh.TenKH

select * from HoaDonView order by HoaDonView.NgayLap desc

-- create trigger for chitiethoadon

create trigger insert_chitiethoadon
on ChiTietHoaDon2
for insert
as
	begin
		declare @soluong int
		declare @soluongban int
		select @soluong = Hang2.SoLuong from Hang2 inner join inserted on Hang2.MaHH = inserted.MaHH 
		
		select @soluongban = inserted.SoLuong from inserted
		
		Update Hang2 set Hang2.SoLuong = Hang2.SoLuong - @soluongban
		from Hang2 inner join inserted on Hang2.MaHH = inserted.MaHH
	end

create trigger delete_chitiethoadon
on ChiTietHoaDon2
for delete
as
	begin
		update Hang2 set Hang2.SoLuong = Hang2.SoLuong + deleted.SoLuong
		from Hang2 inner join deleted
		on Hang2.MaHH = deleted.MaHH
		where Hang2.MaHH = deleted.MaHH
	end


/*UPDATE 5: CREATE VIEW CHITIETHOADON*/
create view ChiTietHoaDonView
as
	select cthd.MaHDCT, cthd.MaHH, h.TenHang, cthd.SoLuong, h.DonGia, cthd.SoLuong * h.DonGia as 'ThanhTien'
	from ChiTietHoaDon2 cthd inner join Hang2 h on cthd.MaHH = h.MaHH
	group by cthd.MaHDCT, cthd.MaHH, h.TenHang, cthd.SoLuong, h.DonGia

select * from ChiTietHoaDonView



/*-- create view BangLuong
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[BangLuong2]
as
select NhanVien2.MaNV,NhanVien2.TenNV, NhanVien2.GioiTinh, NhanVien2.DiaChi, CAST(NhanVien.RankNV AS int)as'Luong cung',Sum(HangHoa.HoaHong*ChiTietHoaDon.SoLuong)as'Hoa hong'
from HangHoa inner join ChiTietHoaDon on HangHoa.MaHH = ChiTietHoaDon.MaHH inner join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD inner join NhanVien on HoaDon.MaNV = NhanVien.MaNV
group by NhanVien.MaNV,NhanVien.TenNV, NhanVien.GioiTinh,NhanVien.DiaChi,CAST(NhanVien.RankNV AS int)
GO*/


-- create view InHoaDon
/*SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[InHoaDon]
as
select ChiTietHoaDon2.MaHD , ChiTietHoaDon2.MaHH , Hang2.TenHang, NhaCungCap2.TenNCC , KhachHang2.TenKH , KhachHang2.GioiTinh , KhachHang2.DiaChi ,KhachHang2.SDT ,NhanVien2.MaNV,NhanVien2.TenNV, ChiTietHoaDon2.DonGia , ChiTietHoaDon2.SoLuong
from NhaCungCap2 inner join Hang2 on NhaCungCap2.MaNCC = Hang2.MaNCC inner join ChiTietHoaDon2 on Hang2.MaHH = ChiTietHoaDon2.MaHH inner join HoaDon2 on ChiTietHoaDon2.MaHD = HoaDon2.MaHD inner join KhachHang2 on HoaDon2.MaKH = KhachHang2.MaKH inner join NhanVien2 on KhachHang2.MaNV = NhanVien2.MaNV
group by ChiTietHoaDon2.MaHD , ChiTietHoaDon2.MaHH , Hang2.TenHang, NhaCungCap2.TenNCC , KhachHang2.TenKH , KhachHang2.GioiTinh , KhachHang2.DiaChi ,KhachHang2.SDT , ChiTietHoaDon2.DonGia , ChiTietHoaDon2.SoLuong,NhanVien2.MaNV, NhanVien2.TenNV
GO


-- create view HangBan
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[HangBan2]
as
select ChiTietHoaDon2.MaHD, ChiTietHoaDon2.MaHH , Hang2.TenHang, KhachHang2.TenKH , ChiTietHoaDon2.DonGia,ChiTietHoaDon2.SoLuong
from NhaCungCap2 inner join Hang2 on NhaCungCap2.MaNCC = Hang2.MaNCC inner join ChiTietHoaDon2 on Hang2.MaHH = ChiTietHoaDon2.MaHH inner join HoaDon2 on ChiTietHoaDon2.MaHD = HoaDon2.MaHD inner join KhachHang2 on HoaDon2.MaKH = KhachHang2.MaKH
group by ChiTietHoaDon2.MaHD, ChiTietHoaDon2.MaHH , Hang2.TenHang,KhachHang2.TenKH,ChiTietHoaDon2.DonGia,ChiTietHoaDon2.SoLuong

*/
