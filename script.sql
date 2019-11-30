USE [NewSqlQLBH]
GO
/****** Object:  Table [dbo].[BoPhan]    Script Date: 11/19/2019 11:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BoPhan](
	[Ma] [varchar](3) NOT NULL,
	[Ten] [nvarchar](256) NULL,
	[GhiChu] [text] NULL,
	[ConQuanLy] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHUCNANG]    Script Date: 11/19/2019 11:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHUCNANG](
	[ID] [int] NOT NULL,
	[ParentID] [int] NULL,
	[TenChucNang] [nvarchar](100) NULL,
	[TenTrongHeThong] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 11/19/2019 11:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[Ma] [varchar](8) NOT NULL,
	[Ten] [nvarchar](20) NULL,
	[GhiChu] [text] NULL,
	[ConQuanLy] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 11/19/2019 11:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHang] [varchar](10) NOT NULL,
	[TenHang] [nvarchar](256) NULL,
	[GiaMua] [float] NULL,
	[GiaBanSi] [float] NULL,
	[GiaBanLe] [float] NULL,
	[TinhChat] [nvarchar](50) NULL,
	[ConQuanLy] [bit] NULL,
	[MaVach] [varchar](10) NULL,
	[MaNhomHang] [varchar](8) NULL,
	[MaKhoHang] [varchar](7) NULL,
	[MaDonViTinh] [varchar](8) NULL,
	[SoLuong] [int] NULL,
	[SoLuongTon] [int] NULL,
	[TonKhoToiThieu] [int] NULL,
	[MaNhaCungCap] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/19/2019 11:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](8) NOT NULL,
	[TenKH] [nvarchar](100) NULL,
	[NguoiLienHe] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](256) NULL,
	[DienThoai] [varchar](20) NULL,
	[DiDong] [varchar](20) NULL,
	[Fax] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Website] [varchar](50) NULL,
	[MaSoThue] [varchar](30) NULL,
	[TenNganHang] [nvarchar](50) NULL,
	[ConQuanLy] [bit] NULL,
	[MaKhuVuc] [varchar](8) NULL,
	[SoTaiKhoan] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhoHang]    Script Date: 11/19/2019 11:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhoHang](
	[Ma] [varchar](7) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[LienHe] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](256) NULL,
	[DienThoai] [varchar](10) NULL,
	[ConQuanLy] [bit] NULL,
	[MaNguoiQuanLy] [varchar](8) NULL,
	[Fax] [varchar](20) NULL,
	[Email] [varchar](20) NULL,
	[KyHieu] [varchar](20) NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhuVuc]    Script Date: 11/19/2019 11:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhuVuc](
	[Ma] [varchar](8) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[GhiChu] [text] NULL,
	[ConQuanLy] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiPhieuIn]    Script Date: 11/19/2019 11:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhieuIn](
	[ID] [int] NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 11/19/2019 11:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[MaNguoiDung] [int] NOT NULL,
	[TenNguoiDung] [varchar](10) NULL,
	[TenHienThi] [nvarchar](100) NULL,
	[MatKhau] [varchar](10) NULL,
	[KichHoat] [bit] NULL,
	[MaVaiTro] [int] NULL,
	[MaNhanVien] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/19/2019 11:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaSo] [varchar](10) NOT NULL,
	[TenNhaCungCap] [nvarchar](200) NULL,
	[NguoiLienHe] [nvarchar](100) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](256) NULL,
	[DienThoai] [varchar](20) NULL,
	[DiDong] [varchar](20) NULL,
	[Fax] [nvarchar](30) NULL,
	[ConQuanLy] [bit] NULL,
	[MaKhuVuc] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/19/2019 11:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Ma] [varchar](8) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](256) NULL,
	[DienThoai] [varchar](15) NULL,
	[DiDong] [varchar](15) NULL,
	[Email] [varchar](50) NULL,
	[ConQuanLy] [bit] NULL,
	[MaBoPhan] [varchar](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhatKyHeThong]    Script Date: 11/19/2019 11:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhatKyHeThong](
	[NguoiDung] [varchar](8) NULL,
	[MayTinh] [nvarchar](15) NULL,
	[ThoiGian] [datetime] NOT NULL,
	[ChucNang] [nvarchar](50) NULL,
	[HanhDong] [nvarchar](20) NULL,
	[DoiTuong] [varchar](13) NULL,
PRIMARY KEY CLUSTERED 
(
	[ThoiGian] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhomHang]    Script Date: 11/19/2019 11:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhomHang](
	[Ma] [varchar](8) NOT NULL,
	[Ten] [nvarchar](256) NULL,
	[GhiChu] [nvarchar](100) NULL,
	[ConQuanLy] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TyGia]    Script Date: 11/19/2019 11:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TyGia](
	[Ma] [varchar](5) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[TyGiaQuyDoi] [float] NULL,
	[ConQuanLy] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VAITRO]    Script Date: 11/19/2019 11:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VAITRO](
	[MaVaiTro] [int] NOT NULL,
	[TenVaiTro] [nvarchar](100) NULL,
	[DienGiai] [nvarchar](100) NULL,
	[KichHoat] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaVaiTro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VAITRO_CHUCNANG]    Script Date: 11/19/2019 11:16:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VAITRO_CHUCNANG](
	[MaVaiTro] [int] NOT NULL,
	[MaChucNang] [int] NOT NULL,
	[TatCa] [bit] NULL,
	[TruyCap] [bit] NULL,
	[Them] [bit] NULL,
	[Xoa] [bit] NULL,
	[Sua] [bit] NULL,
	[InAn] [bit] NULL,
	[Nhap] [bit] NULL,
	[Xuat] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaVaiTro] ASC,
	[MaChucNang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_DonViTinh] FOREIGN KEY([MaDonViTinh])
REFERENCES [dbo].[DonViTinh] ([Ma])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_DonViTinh]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_KhoHang] FOREIGN KEY([MaKhoHang])
REFERENCES [dbo].[KhoHang] ([Ma])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_KhoHang]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_NhaCungCap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaSo])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_NhaCungCap]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_NhomHang] FOREIGN KEY([MaNhomHang])
REFERENCES [dbo].[NhomHang] ([Ma])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_NhomHang]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_KhuVuc] FOREIGN KEY([MaKhuVuc])
REFERENCES [dbo].[KhuVuc] ([Ma])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_KhuVuc]
GO
ALTER TABLE [dbo].[KhoHang]  WITH CHECK ADD  CONSTRAINT [FK_KhoHang_NhanVien] FOREIGN KEY([MaNguoiQuanLy])
REFERENCES [dbo].[NhanVien] ([Ma])
GO
ALTER TABLE [dbo].[KhoHang] CHECK CONSTRAINT [FK_KhoHang_NhanVien]
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUNG_NHANVIEN] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([Ma])
GO
ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [FK_NGUOIDUNG_NHANVIEN]
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUNG_VAITRO] FOREIGN KEY([MaVaiTro])
REFERENCES [dbo].[VAITRO] ([MaVaiTro])
GO
ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [FK_NGUOIDUNG_VAITRO]
GO
ALTER TABLE [dbo].[NhaCungCap]  WITH CHECK ADD  CONSTRAINT [FK_NhaCungCap_KhuVuc] FOREIGN KEY([MaKhuVuc])
REFERENCES [dbo].[KhuVuc] ([Ma])
GO
ALTER TABLE [dbo].[NhaCungCap] CHECK CONSTRAINT [FK_NhaCungCap_KhuVuc]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_BoPhan] FOREIGN KEY([MaBoPhan])
REFERENCES [dbo].[BoPhan] ([Ma])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_BoPhan]
GO
ALTER TABLE [dbo].[VAITRO_CHUCNANG]  WITH CHECK ADD  CONSTRAINT [FK_VTCN_CHUCNANG] FOREIGN KEY([MaChucNang])
REFERENCES [dbo].[CHUCNANG] ([ID])
GO
ALTER TABLE [dbo].[VAITRO_CHUCNANG] CHECK CONSTRAINT [FK_VTCN_CHUCNANG]
GO
ALTER TABLE [dbo].[VAITRO_CHUCNANG]  WITH CHECK ADD  CONSTRAINT [FK_VTCN_VAITRO] FOREIGN KEY([MaVaiTro])
REFERENCES [dbo].[VAITRO] ([MaVaiTro])
GO
ALTER TABLE [dbo].[VAITRO_CHUCNANG] CHECK CONSTRAINT [FK_VTCN_VAITRO]
GO
