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
 CONSTRAINT [PK_TrinhDo] PRIMARY KEY CLUSTERED 
(
	[MaTrinhDo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

-- insert data to table TrinhDo
insert into TrinhDo2 values (N'001', N'đại học')
insert into TrinhDo2 values (N'002', N'cao đẳng')
insert into TrinhDo2 values (N'003', N'cấp 3')

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

insert into NhanVien2 values (N'001', N'vũ văn hùng', N'thái bình', N'0366310685', N'001')
insert into NhanVien2 values (N'002', N'nguyễn khắc hiếu', N'hà nội', N'0366310685', N'002')
insert into NhanVien2 values (N'003', N'phạm văn yên', N'quảng ninh', N'0366310685', N'003')
insert into NhanVien2 values (N'004', N'vũ việt tùng', N'phú thọ', N'0366310685', N'001')

-- create table NhaCungCap
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap2](
	[MaNCC] [varchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[SDT] [int] NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

insert into NhaCungCap2 values (N'001', N'trung nguyên', N'tây nguyên', N'0123111')
insert into NhaCungCap2 values (N'002', N'1994 cooktice', N'đan phượng', N'0999121')
insert into NhaCungCap2 values (N'003', N'1994 tea', N'hà nội', N'0129988')

-- create table KhachHang
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang2](
	[MaKH] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[SDT] [varchar](20) NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[DiaChi] [nvarchar](150) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

insert into KhachHang2 values (N'001', N'vũ văn hùng', N'0366310685', 0, N'thái bình', N'001')
insert into KhachHang2 values (N'001', N'nguyễn khắc hiếu', N'0366310685', 0, N'hà nội', N'001')
insert into KhachHang2 values (N'001', N'phạm văn yên', N'0366310685', 0, N'quảng ninh', N'001')
insert into KhachHang2 values (N'001', N'vũ việt tùng', N'0366310685', 0, N'sao hỏa', N'001')
INSERT [dbo].[KhachHang2] ([MaKH], [TenKH], [SDT], [GioiTinh], [DiaChi], [MaNV]) VALUES (N'kh1', N'Vũ Thu Hường', N'654', 0, N'Hưng Yên', N'001')
INSERT [dbo].[KhachHang2] ([MaKH], [TenKH], [SDT], [GioiTinh], [DiaChi], [MaNV]) VALUES (N'kh2', N'Hà Duy Hưng', N'777', 1, N'Hưng Yên', N'002')

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

insert into Hang2 values (N'001', N'cafe đá', N'ml', 50000, N'001', N'001', 100)
insert into Hang2 values (N'002', N'nước cam', N'l', 60000, N'002', N'002', 200)
insert into Hang2 values (N'003', N'trà chanh', N'ml', 30000, N'003', N'003', 300)

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

insert into HoaDon2 values ('001', '001', '004', '3/6/2020')
insert into HoaDon2 values ('002', '002', '003', '4/6/2020')
insert into HoaDon2 values ('003', '003', '002', '5/6/2020')
insert into HoaDon2 values ('004', '004', '001', '6/6/2020')
insert into HoaDon2 values ('005', '001', '004', '7/6/2020')
insert into HoaDon2 values ('006', '002', '003', '8/6/2020')
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayLap]) VALUES (N'001', N'001', N'001', CAST(0xEB3E0B00 AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayLap]) VALUES (N'002', N'002', N'002', CAST(0x013F0B00 AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayLap]) VALUES (N'003', N'003', N'003', CAST(0x013F0B00 AS Date))

-- create view HangTon
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[hangton2]
as
select HangHoa.MaHH,HangHoa.TenHang,NhaCungCap.TenNCC,HangHoa.DonGia,HangHoa.SoLuong
from HangHoa inner join NhaCungCap on HangHoa.MaNCC = NhaCungCap.MaNCC
group by HangHoa.MaHH,HangHoa.TenHang,NhaCungCap.TenNCC,HangHoa.DonGia,HangHoa.SoLuong
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 12/05/2018 15:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon2](
	[MaHD] [varchar](10) NOT NULL,
	[MaHH] [varchar](10) NOT NULL,
	[DonGia] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd1', N'gg', 30000, 2000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd1', N'gggg', 35000, 2000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd2', N'gg', 32000, 3000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd2', N'gggg', 35000, 2000)
/****** Object:  View [dbo].[BangLuong]    Script Date: 12/05/2018 15:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[BangLuong2]
as
select NhanVien.MaNV,NhanVien.TenNV, NhanVien.GioiTinh,NhanVien.DiaChi,CAST(NhanVien.RankNV AS int)as'Luong cung',Sum(HangHoa.HoaHong*ChiTietHoaDon.SoLuong)as'Hoa hong'
from HangHoa inner join ChiTietHoaDon on HangHoa.MaHH = ChiTietHoaDon.MaHH inner join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD inner join NhanVien on HoaDon.MaNV = NhanVien.MaNV
group by NhanVien.MaNV,NhanVien.TenNV, NhanVien.GioiTinh,NhanVien.DiaChi,CAST(NhanVien.RankNV AS int)
GO
/****** Object:  View [dbo].[InHoaDon]    Script Date: 12/05/2018 15:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[InHoaDon]
as
select ChiTietHoaDon.MaHD , ChiTietHoaDon.MaHH , HangHoa.TenHang, NhaCungCap.TenNCC , KhachHang.TenKH , KhachHang.GioiTinh , KhachHang.DiaChi ,KhachHang.SDT ,NhanVien.MaNV,NhanVien.TenNV, ChiTietHoaDon.DonGia , ChiTietHoaDon.SoLuong
from NhaCungCap inner join HangHoa on NhaCungCap.MaNCC = HangHoa.MaNCC inner join ChiTietHoaDon on HangHoa.MaHH = ChiTietHoaDon.MaHH inner join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD inner join KhachHang on HoaDon.MaKH = KhachHang.MaKH inner join NhanVien on KhachHang.MaNV = NhanVien.MaNV
group by ChiTietHoaDon.MaHD , ChiTietHoaDon.MaHH , HangHoa.TenHang, NhaCungCap.TenNCC , KhachHang.TenKH , KhachHang.GioiTinh , KhachHang.DiaChi ,KhachHang.SDT , ChiTietHoaDon.DonGia , ChiTietHoaDon.SoLuong,NhanVien.MaNV,NhanVien.TenNV
GO
/****** Object:  View [dbo].[hangban]    Script Date: 12/05/2018 15:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[hangban2]
as
select ChiTietHoaDon.MaHD, ChiTietHoaDon.MaHH , HangHoa.TenHang, KhachHang.TenKH , ChiTietHoaDon.DonGia,ChiTietHoaDon.SoLuong
from NhaCungCap inner join HangHoa on NhaCungCap.MaNCC = HangHoa.MaNCC inner join ChiTietHoaDon on HangHoa.MaHH = ChiTietHoaDon.MaHH inner join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD inner join KhachHang on HoaDon.MaKH = KhachHang.MaKH
group by ChiTietHoaDon.MaHD, ChiTietHoaDon.MaHH , HangHoa.TenHang,KhachHang.TenKH,ChiTietHoaDon.DonGia,ChiTietHoaDon.SoLuong
GO
/****** Object:  View [dbo].[DoanhThu]    Script Date: 12/05/2018 15:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[DoanhThu2]
as
select ChiTietHoaDon.MaHH,TenHang,ChiTietHoaDon.DonGia as'dongiaban',ChiTietHoaDon.SoLuong as'Soluongban',HangHoa.SoLuong as'Soluongnhap',HangHoa.DonGia as'dongianhap',HoaDon.NgayLap
from HangHoa inner join ChiTietHoaDon on HangHoa.MaHH = ChiTietHoaDon.MaHH inner join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD
group by ChiTietHoaDon.MaHH,TenHang,ChiTietHoaDon.DonGia,ChiTietHoaDon.SoLuong,HangHoa.SoLuong,HangHoa.DonGia,HoaDon.NgayLap
GO
/****** Object:  View [dbo].[DanhSachBan]    Script Date: 12/05/2018 15:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[DanhSachBan2]
as	
select ChiTietHoaDon.MaHD,KhachHang.TenKH,ChiTietHoaDon.MaHH,HangHoa.TenHang,NhaCungCap.TenNCC,ChiTietHoaDon.DonGia,ChiTietHoaDon.SoLuong,HoaDon.MaNV,NhanVien.TenNV,HoaDon.NgayLap
from NhaCungCap inner join HangHoa on NhaCungCap.MaNCC = HangHoa.MaNCC inner join ChiTietHoaDon on HangHoa.MaHH = ChiTietHoaDon.MaHH inner join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD inner join KhachHang on HoaDon.MaKH = KhachHang.MaKH inner join NhanVien on KhachHang.MaNV = NhanVien.MaNV
group by ChiTietHoaDon.MaHD,KhachHang.TenKH,ChiTietHoaDon.MaHH,HangHoa.TenHang,NhaCungCap.TenNCC,ChiTietHoaDon.DonGia,ChiTietHoaDon.SoLuong,HoaDon.MaNV,NhanVien.TenNV,HoaDon.NgayLap
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDon_HangHoa]    Script Date: 12/05/2018 15:09:49 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HangHoa] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HangHoa]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDon_HoaDon]    Script Date: 12/05/2018 15:09:49 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
/****** Object:  ForeignKey [FK_HangHoa_NhaCungCap]    Script Date: 12/05/2018 15:09:49 ******/
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_HoaDon_KhachHang]    Script Date: 12/05/2018 15:09:49 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
/****** Object:  ForeignKey [FK_HoaDon_NhanVien1]    Script Date: 12/05/2018 15:09:49 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien1] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien1]
GO
/****** Object:  ForeignKey [FK_KhachHang_NhanVien]    Script Date: 12/05/2018 15:09:49 ******/
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_NhanVien]
GO

-- uc2
create view ThongTinHoaDon2
as
	select	hd.ma_hoa_don as 'ma_hoa_don',
			hd.ma_khach_hang as 'ma_khach_hang', 
			kh.ho_ten as 'ten_khach_hang', 
            hd.ngay_lap as 'ngay_lap',
			hd.ma_nhan_vien as 'ma_nhan_vien', 
            nv.ho_ten as 'ten_nhan_vien',
			sum(hdct.so_luong*h.don_gia) as 'tong_tien'
	from HoaDon2 hd, KhachHang2 kh, NhanVien2 nv, HoaDonChiTiet2 hdct, Hang2 h
	where hd.ma_hoa_don = hdct.ma_hoa_don
		and hd.ma_khach_hang = kh.ma_khach_hang
		and hd.ma_nhan_vien = nv.ma_nhan_vien
		and hdct.ma_hang = h.ma_hang
	group by hd.ma_hoa_don, hd.ma_khach_hang, kh.ho_ten, hd.ngay_lap, hd.ma_nhan_vien, nv.ho_ten

	-- test
	select * from ThongTinHoaDon2

create view ThongTinMatHang2
as
	select	hdct.ma_hang as 'ma_hang', 
			h.ten_hang as 'ten_hang', 
			hdct.so_luong as 'so_luong', 
            h.don_gia as 'don_gia', 
            hdct.so_luong*h.don_gia as 'thanh_tien'
	from HoaDonChiTiet2 hdct, Hang2 h
	where hdct.ma_hang = h.ma_hang
	group by hdct.ma_hang, h.ten_hang, hdct.so_luong, h.don_gia

	-- test
	select * from ThongTinMatHang2

-- uc3
alter view BaoCaoBanHangNgayVaHangTon2
as
	select	ncc.ma_nha_cung_cap as 'ma_nha_cung_cap', 
			ncc.ten_nha_cung_cap as 'ten_don_vi', 
            hd.ngay_lap as 'ngay_lap', 
            nv.ho_ten as 'nguoi_lap',
			h.ma_hang as 'ma_hang', 
            h.ten_hang as 'ten_mat_hang', 
            h.don_vi_tinh as 'don_vi_tinh',
			hdct.ma_hoa_don as 'ma_hoa_don', 
            hdct.so_luong as 'so_luong_ban', 
            h.don_gia as 'don_gia', 
            sum(hdct.so_luong*h.don_gia) as 'thanh_tien'
	from NhaCungCap2 ncc
			inner join Hang2 h on ncc.ma_nha_cung_cap = h.ma_nha_cung_cap
			left join HoaDonChiTiet2 hdct on h.ma_hang = hdct.ma_hang
			left join HoaDon2 hd on hdct.ma_hoa_don = hd.ma_hoa_don
			left join NhanVien2 nv on hd.ma_nhan_vien = nv.ma_nhan_vien
	where 1=1
	group by ncc.ma_nha_cung_cap, ncc.ten_nha_cung_cap, hd.ngay_lap, nv.ho_ten,
			h.ma_hang, h.ten_hang, h.don_vi_tinh, hdct.ma_hoa_don, hdct.so_luong, h.don_gia

	-- test
	select * from BaoCaoBanHangNgayVaHangTon2
