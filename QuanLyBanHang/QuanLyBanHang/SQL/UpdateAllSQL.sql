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

insert into NhanVien2 values (N'001', N'vũ văn hùng', 0, N'thái bình', N'0366310685', N'001', '1', '1')
insert into NhanVien2 values (N'002', N'nguyễn khắc hiếu', 0, N'hà nội', N'0366310685', N'002', '1', '1')
insert into NhanVien2 values (N'003', N'phạm văn yên', 0, N'quảng ninh', N'0366310685', N'003', '1', '1')
insert into NhanVien2 values (N'004', N'vũ việt tùng', 0, N'phú thọ', N'0366310685', N'001', '1', '1')

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

insert into NhaCungCap2 values (N'001', N'trung nguyên', N'0123111', N'tây nguyên')
insert into NhaCungCap2 values (N'002', N'1994 cooktice', N'0999121', N'đan phượng')
insert into NhaCungCap2 values (N'003', N'1994 tea', N'0129988', N'hà nội')

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

insert into KhachHang2 values (N'001', N'vũ văn hùng', N'0366310685', 0, N'thái bình', N'001')
insert into KhachHang2 values (N'002', N'nguyễn khắc hiếu', N'0366310685', 0, N'hà nội', N'001')
insert into KhachHang2 values (N'003', N'phạm văn yên', N'0366310685', 0, N'quảng ninh', N'001')
insert into KhachHang2 values (N'004', N'vũ việt tùng', N'0366310685', 0, N'sao hỏa', N'001')

-- create table LoaiHang
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiHang2](
	[MaLoai] [varchar](100) NOT NULL,
	[TenLoai] [varchar](200) NOT NULL,
	[GhiChu] [varchar](500) NOT NULL,
 CONSTRAINT [PK_LoaiHang] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

insert into LoaiHang2 values ('001', 'cafe', 'không ngọt')
insert into LoaiHang2 values ('002', 'nước ép', 'ngon')
insert into LoaiHang2 values ('003', 'trà', 'chua')

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

-- create view HangTon
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
<<<<<<< HEAD
create view [dbo].[hangton2]
=======
create view [dbo].[HangTon2]
>>>>>>> a4bc4da740345377952cb926c2215ac748bf1135
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
	[MaHD] [varchar](100) NOT NULL,
	[MaHH] [varchar](100) NOT NULL,
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
INSERT [dbo].[ChiTietHoaDon2] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd1', N'001', 30000, 2000)
INSERT [dbo].[ChiTietHoaDon2] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd1', N'002', 35000, 2000)
INSERT [dbo].[ChiTietHoaDon2] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd2', N'003', 32000, 3000)
INSERT [dbo].[ChiTietHoaDon2] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd2', N'004', 35000, 2000)


-- create table LichSuGia
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LichSuGia2](
	[MaHang] [varchar](10) NOT NULL,
	[NgayBatDau] [date] NOT NULL,
	[NgayKetThuc] [date] NOT NULL,
	[DonGia] [int] NOT NULL,
	[NgayCapNhat] [date] NOT NULL,
 CONSTRAINT [PK_LichSuGia] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC,
	[NgayBatDau] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

insert into LichSuGia2 values ('001', '1/6/2020', '6/6/2020', 40000, '7/6/2020')
insert into LichSuGia2 values ('002', '2/6/2020', '7/6/2020', 50000, '6/6/2020')
insert into LichSuGia2 values ('003', '3/6/2020', '8/6/2020', 60000, '4/6/2020')

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
SET ANSI_NULLS ON
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
create view [dbo].[hangban2]
as
select ChiTietHoaDon2.MaHD, ChiTietHoaDon2.MaHH , Hang2.TenHang, KhachHang2.TenKH , ChiTietHoaDon2.DonGia,ChiTietHoaDon2.SoLuong
from NhaCungCap2 inner join Hang2 on NhaCungCap2.MaNCC = Hang2.MaNCC inner join ChiTietHoaDon2 on Hang2.MaHH = ChiTietHoaDon2.MaHH inner join HoaDon2 on ChiTietHoaDon2.MaHD = HoaDon2.MaHD inner join KhachHang2 on HoaDon2.MaKH = KhachHang2.MaKH
group by ChiTietHoaDon2.MaHD, ChiTietHoaDon2.MaHH , Hang2.TenHang,KhachHang2.TenKH,ChiTietHoaDon2.DonGia,ChiTietHoaDon2.SoLuong
GO


-- create view DoanhThu
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[DoanhThu2]
as
select ChiTietHoaDon2.MaHH,TenHang,ChiTietHoaDon2.DonGia as'dongiaban',ChiTietHoaDon2.SoLuong as'Soluongban',Hang2.SoLuong as'Soluongnhap',Hang2.DonGia as'dongianhap',HoaDon.NgayLap
from Hang2 inner join ChiTietHoaDon2 on Hang2.MaHH = ChiTietHoaDon2.MaHH inner join HoaDon2 on ChiTietHoaDon2.MaHD = HoaDon2.MaHD
group by ChiTietHoaDon2.MaHH,TenHang,ChiTietHoaDon2.DonGia,ChiTietHoaDon2.SoLuong,Hang2.SoLuong,Hang2.DonGia,HoaDon2.NgayLap
GO


-- create view DanhSachBan
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[DanhSachBan2]
as	
select ChiTietHoaDon2.MaHD,KhachHang2.TenKH,ChiTietHoaDon2.MaHH,Hang2.TenHang,NhaCungCap2.TenNCC,ChiTietHoaDon2.DonGia,ChiTietHoaDon2.SoLuong,HoaDon2.MaNV,NhanVien2.TenNV,HoaDon2.NgayLap
from NhaCungCap2 inner join Hang2 on NhaCungCap2.MaNCC = Hang2.MaNCC inner join ChiTietHoaDon2 on Hang2.MaHH = ChiTietHoaDon2.MaHH inner join HoaDon2 on ChiTietHoaDon2.MaHD = HoaDon2.MaHD inner join KhachHang2 on HoaDon2.MaKH = KhachHang2.MaKH inner join NhanVien2 on KhachHang2.MaNV = NhanVien2.MaNV
group by ChiTietHoaDon2.MaHD,KhachHang2.TenKH,ChiTietHoaDon2.MaHH,Hang2.TenHang,NhaCungCap2.TenNCC,ChiTietHoaDon2.DonGia,ChiTietHoaDon2.SoLuong,HoaDon2.MaNV,NhanVien2.TenNV,HoaDon2.NgayLap
GO

/*-- add fk for table ChiTietHoaDon
ALTER TABLE [dbo].[ChiTietHoaDon2]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HangHoa] FOREIGN KEY([MaHH])
REFERENCES [dbo].[Hang2] ([MaHH])
GO
ALTER TABLE [dbo].[ChiTietHoaDon2] CHECK CONSTRAINT [FK_ChiTietHoaDon_HangHoa]
GO

ALTER TABLE [dbo].[ChiTietHoaDon2]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon2] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon2] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO


-- add fk for table HangHoa
ALTER TABLE [dbo].[Hang2]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_MaLoai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiHang2] ([MaLoai])
GO
ALTER TABLE [dbo].[Hang2] CHECK CONSTRAINT [FK_HangHoa_MaLoai]
GO

ALTER TABLE [dbo].[HangHoa2]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap2] ([MaNCC])
GO
ALTER TABLE [dbo].[HangHoa2] CHECK CONSTRAINT [FK_HangHoa_NhaCungCap]
GO


-- add fk for table HoaDon
ALTER TABLE [dbo].[HoaDon2]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang2] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon2] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO

ALTER TABLE [dbo].[HoaDon2]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien1] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien2] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon2] CHECK CONSTRAINT [FK_HoaDon_NhanVien1]
GO


-- add fk for table KhachHang
ALTER TABLE [dbo].[KhachHang2]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien2] ([MaNV])
GO
ALTER TABLE [dbo].[KhachHang2] CHECK CONSTRAINT [FK_KhachHang_NhanVien]
GO

-- add fk for table NhanVien
ALTER TABLE [dbo].[NhanVien2]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TrinhDo] FOREIGN KEY([MaTrinhDo])
REFERENCES [dbo].[TrinhDo2] ([MaTrinhDo])
GO
ALTER TABLE [dbo].[NhanVien2] CHECK CONSTRAINT [FK_NhanVien_TrinhDo]
GO*/

/*-- uc2
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
	select * from BaoCaoBanHangNgayVaHangTon2*/


	GO
create view [dbo].[DoanhThu2]
as
select ChiTietHoaDon2.MaHH,TenHang,ChiTietHoaDon2.DonGia as'dongiaban',ChiTietHoaDon2.SoLuong as'Soluongban',Hang2.SoLuong as'Soluongnhap',Hang2.DonGia as'dongianhap',HoaDon2.NgayLap
from Hang2 inner join ChiTietHoaDon2 on Hang2.MaHH = ChiTietHoaDon2.MaHH inner join HoaDon2 on ChiTietHoaDon2.MaHD = HoaDon2.MaHD
group by ChiTietHoaDon2.MaHH,TenHang,ChiTietHoaDon2.DonGia,ChiTietHoaDon2.SoLuong,Hang2.SoLuong,Hang2.DonGia,HoaDon2.NgayLap

select *from DoanhThu2
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[BangLuong2]
as
select NhanVien2.MaNV,NhanVien2.TenNV, NhanVien2.GioiTinh,NhanVien2.DiaChi,CAST(NhanVien2.MaTrinhDo AS int)as'Luong cung'
from Hang2 inner join ChiTietHoaDon2 on Hang2.MaHH = ChiTietHoaDon2.MaHH inner join HoaDon2 on ChiTietHoaDon2.MaHD = HoaDon2.MaHD inner join NhanVien2 on HoaDon2.MaNV = NhanVien2.MaNV
group by NhanVien2.MaNV,NhanVien2.TenNV, NhanVien2.GioiTinh,NhanVien2.DiaChi,CAST(NhanVien2.MaTrinhDo AS int)

drop view BangLuong