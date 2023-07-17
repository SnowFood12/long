create database WINFORM

GO 
CREATE TABLE TAIKHOAN(
	TenDangNhap varchar(30) primary key , 
	MatKhau varchar(30) , 
	SoDienThoai varchar(11) 
);	

create table SanPham(
	MaSanPham varchar (20) primary key , 
	TenSanPham nvarchar (50) , 
	GiaBan SMALLMONEY , 
	SoLuong tinyint ,
	NgayNhapKho date , 
	HanSuDung date , 
	NgaySanXuat date, 
);

create table HoaDon (
	MaHoaDon tinyint IDENTITY(1,1) primary key ,
	TenHoaDon nvarchar(50)
);
create table HoaDon1 (
	MaHoaDon tinyint IDENTITY(1,1) primary key ,
	TenDoiTac nvarchar(50), 
	SoLuongHang tinyint ,
	MaSanPham varchar (20),
	NgayTaoHoaDon datetime , 
	TongTien SMALLMONEY, 
	TenDangNhap varchar(30), 
	SoDienThoaiDoiTac varchar(11),
	DiaChiDoiTac nvarchar(50) ,
	foreign key (TenDangNhap) references TAIKHOAN(TenDangNhap)
);

create table DoiTac(
	MaDoiTac tinyint IDENTITY(1,1), 
	MaHoaDon tinyint IDENTITY(1,1),
	foreign key (MaHoaDon) references HoaDon1(MaHoaDon), 
);

INSERT INTO SanPham  VALUES ('SP006', N'Thịt đông lạnh', 50, 100 , '12/12/2022', '12/01/2023' , '10/12/2022')

select * from SanPham
