create database QL_Luong
go

create table NhanVien
(
	MaNV nvarchar(10) not null,
	HoTen nvarchar(50),
	ChucVu nvarchar(50),
	NgaySinh date,
	GioiTinh nvarchar(10),
	STK nvarchar(20),
	TrangThai bit,
	Luong int,
	MatKhau char(100),
	constraint PK_MNV primary key (MaNV)
);

create table BieuPhiLuong
(
	MaBP nvarchar(10) not null Primary key,
	TenCT nvarchar(300),
	Luong float,
);

create table CongTac
(
	MaCongTac nvarchar(10) not null,
	MaBP nvarchar(10) not null,
	NoiDungCT nvarchar(300),
	ThoiGian date,

	constraint PK_CTCT Primary key (MaCongTac),
	constraint FK_CT_BPL foreign key (MaBP) references BieuPhiLuong(MaBP)
	
);

create table ChiTiet_CongTac
(
	MaCongTac nvarchar(10) not null,
	MaNV nvarchar(10) not null,
	
	TrangThai bit,
	constraint PK_MCT primary key (MaCongTac,MaNV),
	constraint FK_LCT_NV foreign key (MaNV) references NhanVien(MaNV),
	constraint FK_CTCT_LCT foreign key (MaCongTac) references CongTac(MaCongTac)
);



create table BangChiLuong
(
	MaBangChiLuong nvarchar(10) not null,
	MaNV nvarchar(10) not null,
	LuongChinh float,
	LuongLamThem float,

	constraint PK_BCL primary key (MaBangChiLuong),
	constraint FK_BCL_NV foreign key (MaNV) references NhanVien(MaNV)
);

create table LuongHoTro
(
	MaLHT varchar(10) not null,
	MaNV nvarchar(10) not null,
	NoiDungHT nvarchar (100),
	PhiHT int,
	thang date,
	constraint PK_LHT primary key (MaLHT),
	constraint FK_LHT_NV foreign key (MaNV) references NhanVien(MaNV)
);

create table LuongKhauTru
(
	MaLKT varchar(10) not null,
	MaNV nvarchar(10) not null,
	NoiDungKT nvarchar (100),
	PhiKT int,
	thang date,
	constraint PK_LKT primary key (MaLKT),
	constraint FK_LKT_NV foreign key (MaNV) references NhanVien(MaNV)
);



insert into NhanVien
values 
('nv001',N'Dương Hoàng Hiếu',N'Giáo Viên','07-04-2001','Nam','0875846521',1,7000000,'123'),
('nv002',N'Nguyễn Trọng Hiếu',N'Phục Vụ','12-08-2001','Nam','0875846521',0,4500000,'123'),
('nv003',N'Nguyễn Văn A',N'Phục Vụ','12-08-2001','Nam','0875846521',0,4500000,'123'),
('nv004',N'Nguyễn Văn b',N'Đoàn Trường','07-04-2001','Nam','0875846521',1,10000000,'123'),
('nv005',N'Nguyễn Văn c',N'Lao Công','12-08-2001',N'Nữ','0875846521',0,4000000,'123'),
('nv006',N'Nguyễn Văn d',N'Phục Vụ','12-08-2001','Nam','0875846521',0,4500000,'123'),
('nv007',N'Nguyễn Văn e',N'Giáo Viên','07-04-2001','Nam','0875846521',1,7000000,'123'),
('nv008',N'Nguyễn Văn g',N'Phục Vụ','12-08-2001','Nam','0875846521',0,4500000,'123'),
('nv009',N'Nguyễn Văn h',N'Lao Công','12-08-2001',N'Nữ','0875846521',0,4000000,'123'),
('nv010',N'Nguyễn Văn t',N'Giáo Viên','07-04-2001','Nam','0875846521',1,7000000,'123'),
('nv011',N'Nguyễn Văn f',N'Đoàn Trường','12-08-2001',N'Nữ','0875846521',0,10000000,'123'),
('nv012',N'Nguyễn Văn u',N'Phục Vụ','12-08-2001','Nam','0875846521',0,4500000,'123');

insert into BieuPhiLuong
values
('1','Giảng dạy',120000),
('2','Trực Ban',100000),
('3','Quét Dọn',80000),
('4','Công Việc khác',60000);

set dateformat DMY
insert into CongTac
values
('CT1','1',N'Giảng dạy Ca 1','1/12/2022'),
('CT2','1',N'Giảng dạy Ca 2','2/12/2022'),
('CT3','1',N'Giảng dạy Ca 3','1/12/2022'),
('CT4','2',N'Trực Ban Ca 1','1/12/2022'),
('CT5','2',N'Trực Ban Ca 2','4/12/2022'),
('CT6','2',N'Trực Ban Ca 3','1/12/2022'),
('CT7','3',N'Quét Dọn Ca 1','1/1/2022'),
('CT8','3',N'Quét Dọn Ca 2','1/1/2022'),
('CT9','4',N'Quét Dọn Ca 3','1/1/2022'),
('CT10','1',N'Giảng dạy Ca 1','3/12/2022'),
('CT11','1',N'Giảng dạy Ca 2','2/12/2022'),
('CT12','1',N'Giảng dạy Ca 3','15/12/2022'),
('CT13','2',N'Trực Ban Ca 1','1/2/2022'),
('CT14','2',N'Trực Ban Ca 2','1/3/2022'),
('CT15','2',N'Trực Ban Ca 3','1/3/2022'),
('CT16','3',N'Quét Dọn Ca 1','1/5/2022'),
('CT17','3',N'Quét Dọn Ca 2','1/6/2022'),
('CT18','4',N'Quét Dọn Ca 3','1/10/2022');

insert into ChiTiet_CongTac
values
('CT1','nv001',1),	
('CT3','nv001',1),
('CT2','nv001',0),
('CT6','nv002',1),	
('CT7','nv002',1),
('CT8','nv002',0),
('CT10','nv001',1),
('CT8','nv005',1),
('CT12','nv001',1),
('CT11','nv001',1);

set dateformat DMY
insert into LuongHoTro
values
('1','nv001',N'Thưởng Tết',2000000,'15/12/2022'),
('2','nv002',N'Phụ cấp mang thai',200000,'30/12/2022'),
('3','nv001',N'Thưởng Năng Suất',3000000,'14/12/2022'),
('4','nv002',N'Phụ cấp Gãy chân',100000,'15/12/2022');


insert into LuongKhauTru
values
('1','nv001',N'Bảo hiểm xã hội',2000000,'15/12/2022'),
('2','nv002',N'Bảo Hiểm tai nạn',200000,'30/12/2022'),
('3','nv001',N'Bảo Hiểm y Tế',3000000,'14/12/2022'),
('4','nv002',N'Phụ cấp Gãy chân',100000,'15/12/2022');
	select * from NhanVien where MaNV='nv001'
	select *from LuongHoTro where MaNV='nv001' and MONTH( thang)= 12 and year( thang)= 2022
	select *from LuongKhauTru where MaNV='nv001'  and MONTH( thang)= 12 and year( thang)= 2022
	select ct.NoiDungCT,ct.ThoiGian,ctct.TrangThai from BieuPhiLuong l ,ChiTiet_CongTac ctct,CongTac ct where l.MaBP=ct.MaBP and ctct.MaCongTac=ct.MaCongTac and ctct.MaNV='nv001' and ctct.TrangThai=1 and MONTH( ct.ThoiGian)= 1 and year( ct.ThoiGian)= 2022
	select ct.* , ctct.TrangThai from ChiTiet_CongTac ctct full outer join CongTac ct on ctct.MaCongTac=ct.MaCongTac  where ctct.MaNV='nv001' and ctct.TrangThai=1 and MONTH( ct.ThoiGian)= 1 and year( ct.ThoiGian)= 1