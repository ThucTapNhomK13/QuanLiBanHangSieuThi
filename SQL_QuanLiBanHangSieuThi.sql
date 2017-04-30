USE [master]
GO
/****** Object:  Database [QuanLiBanHangSieuThi]    Script Date: 30-Apr-17 9:24:37 AM ******/
CREATE DATABASE [QuanLiBanHangSieuThi]
GO
USE [QuanLiBanHangSieuThi]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 30-Apr-17 9:24:38 AM ******/
CREATE TABLE [dbo].[ChiTietHoaDon](
	[mahoadon] [varchar](10) NOT NULL,
	[mathangma] [varchar](10) NOT NULL,
	[soluong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC,
	[mathangma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 30-Apr-17 9:24:38 AM ******/
CREATE TABLE [dbo].[DangNhap](
	[tendangnhap] [varchar](50) NOT NULL,
	[matkhau] [varchar](50) NULL,
 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED 
(
	[tendangnhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GianHang]    Script Date: 30-Apr-17 9:24:38 AM ******/
CREATE TABLE [dbo].[GianHang](
	[magianhang] [varchar](10) NOT NULL,
	[tengianhang] [nvarchar](30) NULL,
	[vitri] [nvarchar](50) NULL,
	[nguoiquanlima] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[magianhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 30-Apr-17 9:24:38 AM ******/
CREATE TABLE [dbo].[HoaDon](
	[mahoadon] [varchar](10) NOT NULL,
	[khachhangma] [varchar](10) NULL,
	[nhanvienma] [varchar](10) NULL,
	[ngayviet] [datetime] NULL,
	[khuyenmai] [float] NULL,
	[tonggia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 30-Apr-17 9:24:38 AM ******/
CREATE TABLE [dbo].[KhachHang](
	[makhachhang] [varchar](10) NOT NULL,
	[tenkhachhang] [nvarchar](50) NULL,
	[ngaysinh] [datetime] NULL,
	[gioitinh] [nvarchar](5) NULL,
	[cmtnd] [varchar](12) NULL,
	[diachi] [nvarchar](100) NULL,
	[sdt] [nvarchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[makhachhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 30-Apr-17 9:24:38 AM ******/
CREATE TABLE [dbo].[MatHang](
	[mamathang] [varchar](10) NOT NULL,
	[tenmathang] [nvarchar](200) NULL,
	[soluongcon] [int] NULL,
	[loaihang] [nvarchar](100) NULL,
	[gia] [float] NULL,
	[nhaccma] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[mamathang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 30-Apr-17 9:24:38 AM ******/
CREATE TABLE [dbo].[NhaCungCap](
	[manhacc] [varchar](10) NOT NULL,
	[tennhacc] [nvarchar](50) NULL,
	[mathangma] [varchar](10) NULL,
	[giamathang] [float] NULL,
	[soluong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[manhacc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 30-Apr-17 9:24:38 AM ******/
CREATE TABLE [dbo].[NhanVien](
	[manhanvien] [varchar](10) NOT NULL,
	[hoten] [nvarchar](200) NULL,
	[quequan] [nvarchar](100) NULL,
	[diachi] [nvarchar](100) NULL,
	[gioitinh] [nvarchar](10) NULL,
	[tongiao] [nvarchar](20) NULL,
	[cmtnd] [varchar](12) NULL,
	[ngaysinh] [datetime] NULL,
	[luong] [float] NULL,
	[chucvu] [nvarchar](20) NULL,
	[gianhangma] [varchar](10) NULL,
	[sdt] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QuanLi]    Script Date: 30-Apr-17 9:24:38 AM ******/
CREATE TABLE [dbo].[QuanLi](
	[maquanli] [varchar](10) NOT NULL,
	[tenquanli] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[maquanli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DangNhap] ([tendangnhap], [matkhau]) VALUES (N'hungcuong', N'123456')
INSERT [dbo].[DangNhap] ([tendangnhap], [matkhau]) VALUES (N'tuananh', N'123456')
INSERT [dbo].[GianHang] ([magianhang], [tengianhang], [vitri], [nguoiquanlima]) VALUES (N'01', N'Tap hoa', N'NB31', N'01')
INSERT [dbo].[KhachHang] ([makhachhang], [tenkhachhang], [ngaysinh], [gioitinh], [cmtnd], [diachi], [sdt]) VALUES (N'01', N'Le Manh Thang', CAST(N'1990-11-11 00:00:00.000' AS DateTime), N'Nham ', N'01232234', N'Ha Noi', N'089242423')
INSERT [dbo].[MatHang] ([mamathang], [tenmathang], [soluongcon], [loaihang], [gia], [nhaccma]) VALUES (N'01', N'Sua', 1000, NULL, 5000, NULL)
INSERT [dbo].[MatHang] ([mamathang], [tenmathang], [soluongcon], [loaihang], [gia], [nhaccma]) VALUES (N'02', N'My tom', 100, NULL, 3000, NULL)
INSERT [dbo].[NhanVien] ([manhanvien], [hoten], [quequan], [diachi], [gioitinh], [tongiao], [cmtnd], [ngaysinh], [luong], [chucvu], [gianhangma], [sdt]) VALUES (N'01', N'Vu Hung Cuong', N'Ninh Binh', N'Ha Noi', N'Nam', N'khong', N'1000223224', CAST(N'1999-10-14 00:00:00.000' AS DateTime), 1000000, N'01', N'01', N'01111111')
INSERT [dbo].[QuanLi] ([maquanli], [tenquanli]) VALUES (N'01', N'Hung Cuong')
INSERT [dbo].[QuanLi] ([maquanli], [tenquanli]) VALUES (N'02', N'Manh Cong')
INSERT [dbo].[QuanLi] ([maquanli], [tenquanli]) VALUES (N'03', N'Le Tuan')
USE [master]
GO
ALTER DATABASE [QuanLiBanHangSieuThi] SET  READ_WRITE 
GO
