create database SNOWFOOD;

use SNOWFOOD;

GO 

create table SanPham(
	MaSanPham char (4) primary key , 
	TenSanPham nvarchar (50) not null, 
	GiaBan int not null, 
	SoLuong tinyint not null,
	NgayNhapKho datetime not null, 
	NgaySanXuat datetime not null,
	HanSuDung datetime not null, 
	TinhTrang nvarchar(15) check (TinhTrang = N'Còn tốt' or TinhTrang = N'Sắp hết hạn' or TinhTrang = N'Hết hạn') not null,
	GhiChu ntext,
);

create table DoiTac(
	MaDoiTac tinyint IDENTITY(1,1) primary key, 
	TenDoiTac nvarchar(100) not null, 
	DiaChi nvarchar(100) not null,
	SoDT char(10) not null,
	Email varchar(100) not null,
);

CREATE TABLE TaiKhoan(
	TenDangNhap char(4) primary key , 
	MatKhau varchar(30) not null, 
	HoVaTen nvarchar(100),
	SoDienThoai char(10) not null,
	Email varchar(100),
);

create table HoaDon (
	MaHoaDon tinyint IDENTITY(1,1) primary key ,
	MaDoiTac tinyint not null, 
	NgayTaoHoaDon datetime not null, 
	TongTien int not null, 
	NVTaoDon char(4) not null,
	foreign key (MaDoiTac) references DoiTac(MaDoiTac),
	foreign key (NVTaoDon) references TaiKhoan(TenDangNhap)
);

create table HoaDon_dsSanPham(
	MaHoaDonSanPham tinyint IDENTITY(1,1) primary key,
	MaSanPham varchar (20) not null,
	MaHoaDon tinyint not null,
	foreign key (MaHoaDon) references HoaDon(MaHoaDon)
);
INSERT INTO SanPham (MaSanPham, TenSanPham, GiaBan, SoLuong, NgayNhapKho, NgaySanXuat, HanSuDung, TinhTrang, GhiChu)
VALUES 
('SP01', N'Bột mì đa dụng', 20000, 50, '2022-01-01', '2021-12-01', '2024-12-01', N'Còn tốt', N''),
('SP02', N'Mì tôm Hảo Hảo', 5000, 100, '2023-11-01', '2022-10-01', '2024-10-01', N'Còn tốt', N''),
('SP03', N'Gạo tám xài', 25000, 80, '2022-03-01', '2021-12-01', '2023-12-01', N'Còn tốt', N''),
('SP04', N'Đường cát trắng', 15000, 120, '2022-02-01', '2021-12-01', '2023-07-01', N'Còn tốt', N''),
('SP05', N'Chanh tươi', 60000, 20, '2023-09-01', '2023-08-01', '2023-08-07', N'Hết hạn', N''),
('SP06', N'Ớt chuông', 35000, 30, '2023-04-01', '2023-03-01', '2023-03-07', N'Hết hạn', N''),
('SP07', N'Thịt lợn', 150000, 15, '2023-07-10', '2023-07-01', '2023-07-19', N'Sắp hết hạn', N''),
('SP08', N'Rau cải xanh', 20000, 25, '2023-07-01', '2023-06-01', '2023-07-06', N'Hết hạn', N''),
('SP09', N'Tôm sú', 90000, 10, '2023-07-02', '2023-07-01', '2023-07-06', N'Hết hạn', N''),
('SP10', N'Cá hồi tươi', 120000, 8, '2023-06-15', '2023-06-08', '2023-07-20', N'Sắp hết hạn', N'');


DELETE FROM SanPham

SELECT * FROM SanPham

	

	SELECT DISTINCT TinhTrang FROM SanPham