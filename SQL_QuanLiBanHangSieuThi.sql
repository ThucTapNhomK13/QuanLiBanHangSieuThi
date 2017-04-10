create database QuanLiBanHangSieuThi

use QuanLiBanHangSieuThi

create table NhanVien
(
manhanvien varchar(10) primary key,
hoten nvarchar(200),
quequan nvarchar(100),
diachi nvarchar(100),
gioitinh nvarchar,
tongiao nvarchar(20),
cmtnd varchar(12),
ngaysinh datetime,
luong float,
chucvu nvarchar(20),
gianhangma nvarchar(10)
)

alter table NhanVien
alter column gianhangma varchar(10)
alter table NhanVien
alter column gioitinh nvarchar(10)
alter table NhanVien
add  sdt varchar(12)

create table GianHang
(
magianhang varchar(10) primary key,
tengianhang nvarchar(30),
vitri nvarchar(50),
nguoiquanlima varchar(10)
)
create table QuanLi
(
maquanli varchar(10) primary key,
tenquanli nvarchar(30)
)

create table HoaDon
(
mahoadon varchar(10) primary key,
khachhangma varchar(10),
nhanvienma varchar(10),
ngayviet datetime,
khuyenmai float,
tonggia float,
)

create table ChiTietHoaDon
(
mahoadon varchar(10),
mathangma varchar(10),
soluong int ,
primary key (mahoadon , mathangma)
)
create table MatHang
(
mamathang varchar(10) primary key,
tenmathang nvarchar(200),
soluongcon int,
loaihang nvarchar(100),
gia float,
nhaccma varchar(10)
)

create table NhaCungCap
(
manhacc varchar(10) primary key,
tennhacc nvarchar(50),
mathangma varchar(10),
giamathang float,
soluong int
)

create table KhachHang
(
makhachhang varchar(10) primary key,
tenkhachhang nvarchar(50),
ngaysinh datetime,
gioitinh nvarchar(5),
cmtnd varchar(12),
diachi nvarchar(100),
sdt nvarchar(12)
)
