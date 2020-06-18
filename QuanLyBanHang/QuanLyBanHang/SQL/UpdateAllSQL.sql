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


/*UPDATE 2: EDIT VIEW (YEN)*/
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


/*UPDATE 3: INSERT RIGH DATA TO TABLE*/
-- insert data to table TrinhDo
insert into TrinhDo2 values (N'TĐ1', N'Quản lý')
insert into TrinhDo2 values (N'TĐ2', N'Nhân viên chạy bàn')
insert into TrinhDo2 values (N'TĐ3', N'Nhan viên pha chế')
insert into TrinhDo2 values (N'TĐ4', N'Bảo vệ')
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
INSERT [dbo].[ChiTietHoaDon2] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd1', N'hang1', 130000, 2000)
INSERT [dbo].[ChiTietHoaDon2] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd3', N'hang2', 70000, 2000)
INSERT [dbo].[ChiTietHoaDon2] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd2', N'hang3', 65000, 3000)
INSERT [dbo].[ChiTietHoaDon2] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd4', N'hang4', 35000, 2000)
INSERT [dbo].[ChiTietHoaDon2] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd6', N'hang1', 124000, 2000)
INSERT [dbo].[ChiTietHoaDon2] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd7', N'hang2', 115000, 2000)
INSERT [dbo].[ChiTietHoaDon2] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd8', N'hang3', 80000, 3000)
INSERT [dbo].[ChiTietHoaDon2] ([MaHD], [MaHH], [DonGia], [SoLuong]) VALUES (N'hd9', N'hang4', 12000, 2000)
-- insert data to table LichSuGia
insert into LichSuGia2 values ('001', '1/6/2020', '6/6/2020', 150000, '7/6/2020')
insert into LichSuGia2 values ('002', '2/6/2020', '7/6/2020',60000, '6/6/2020')
insert into LichSuGia2 values ('004', '3/6/2020', '8/6/2020', 120000, '4/6/2020')
insert into LichSuGia2 values ('005', '1/6/2020', '6/6/2020', 35000, '7/6/2020')
insert into LichSuGia2 values ('003', '2/6/2020', '7/6/2020', 20000, '6/6/2020')
insert into LichSuGia2 values ('003', '3/6/2020', '8/6/2020', 60000, '4/6/2020')