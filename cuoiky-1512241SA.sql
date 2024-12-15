create database QuanLyNhaHangTrangVyMinh
go
use QuanLyNhaHangTrangVyMinh

go

---Create table QuanTriVien
create table QuanTriVien (
	maAD char(10) primary key,
	tenAD nvarchar(80),
	tenDN nvarchar(50),
	matkhau nvarchar (50)
)
go
---Create table NhanVienNhaHang
create table NhanVienNhaHang (
	maNV char(10) primary key,
	tenNV nvarchar(80),
	ngaysinh nvarchar(50),
	gioitinh nvarchar(30),
	diachi nvarchar(100),
	email nvarchar(100),
	sdt nvarchar (50)
)
go

---Create table DanhMucMonAn
create table DanhMucMonAn (
	maDM char(10) primary key,
	tenDM nvarchar(80),
	mota nvarchar(255)
)
ALTER TABLE DanhMucMonAn
ALTER COLUMN mota NVARCHAR(MAX);

---Create table MonAn
create table MonAn (
	maMA char(10) primary key,
	tenMA nvarchar(80),
	gia int,
	maDM char(10) foreign key references DanhMucMonAn(maDM)
		on delete cascade
		on update cascade,
)
go
---Create table HoaDon
create table HoaDon (
	maHD char(10) primary key,
	ngaytao nvarchar(50)
)
go 
---Create table HoaDon
create table ChiTietHoaDon (
	maCT char(10) primary key,
	maMA char(10) foreign key references MonAn(maMA)
		on delete cascade
		on update cascade,
	soluong int,
	maHD char(10) foreign key references HoaDon(maHD)
		on delete cascade
		on update cascade,
)

----- Insert dữ liệu
---Table Admin
insert into QuanTriVien( maAD, tenAD, tenDN, matkhau) 
values ('1',N'Admin','admin1','12345')
go 

go

insert into NhanVienNhahang (maNV, tenNV, ngaysinh, gioitinh,diachi, email, sdt)
values 
	('NV00001',N'Lê Thị Huyền Trang', '13/05/2004',N'Nữ',N'Quảng Trị','lethihtrang998877@gmail.com','0877022760'),
	('NV00002',N'Trần Như Anh Minh', '12/02/2004',N'Nam',N'Tây Nguyên','TranNhuAnhMinh@gmail.com','0329920177'),
		('NV00003',N'Trần Thanh Vỹ', '12/06/2004',N'Nam',N'Huế','TranThanhVy@gmail.com','0456668990')
go
insert into DanhMucMonAn values 
	('DM00001',N'Món khai vị',N'Món khai vị là phần mở đầu hoàn hảo cho bất kỳ bữa ăn nào, giúp kích thích vị giác và tạo cảm giác hào hứng cho thực khách. Các món ăn trong danh mục này thường được chế biến nhẹ nhàng, hài hòa giữa hương vị và cách trình bày, mang đến sự hấp dẫn ngay từ lần đầu thưởng thức.'),
	('DM00002',N'Món Chính',N'Món chính là trái tim của bữa ăn, tập trung vào sự đa dạng và phong phú trong cách chế biến. Các món ăn được lựa chọn cẩn thận để mang lại hương vị đậm đà, cung cấp dinh dưỡng đầy đủ, và thường được phối hợp với cơm hoặc các loại bánh mì, mì để làm no bụng thực khách.'),
	('DM00003',N'Món Nướng',N'Món nướng là sự kết hợp hoàn hảo giữa kỹ thuật chế biến khéo léo và hương vị đặc trưng. Với lớp ngoài giòn thơm, bên trong mềm ngọt, các món ăn trong danh mục này không chỉ hấp dẫn về vị giác mà còn mang lại trải nghiệm thú vị khi thưởng thức. Mùi thơm lan tỏa từ món nướng sẽ làm say đắm bất kỳ ai.'),
	('DM00004',N'Món Tráng Miệng',N'Món tráng miệng là phần kết thúc nhẹ nhàng, ngọt ngào cho bữa ăn. Với sự tinh tế trong cách chế biến, các món ăn trong danh mục này mang đến cảm giác sảng khoái, xoa dịu vị giác, và để lại ấn tượng khó quên. Chúng là lựa chọn lý tưởng để hoàn thiện hành trình ẩm thực của bạn.')
go
insert into MonAn values 
	('MA00001',N'Chả Giò Tôm Thịt',20000,'DM00001'),
	('MA00002',N'Gỏi Ngó Sen Tôm Thịt',35000,'DM00001'),
	('MA00003',N'Súp Bắp Gà Xé',50000,'DM00001'),
	('MA00004',N'Bánh Cuốn Thịt Nướng',35000,'DM00001'),
	('MA00005',N'Chè Xanh Rau Má',25000,'DM00001'),

	('MA00006',N'Cơm Chiên Hải Sản',25000,'DM00002'),
	('MA00007',N'Sườn Non Ram Mặn',70000,'DM00002'),
	('MA00008',N'Gà Quay Sốt Mật Ong',200000,'DM00002'),
	('MA00009',N'Bò Kho Nước Dừa',350000,'DM00002'),
	('MA00010',N'Tôm Hấp Nước Dừa',300000,'DM00002'),

	('MA00011',N'Bò Nướng Lá Lốt',250000,'DM00003'),
	('MA00012',N'Sườn Cừu Nướng Thảo Mộc',75000,'DM00003'),
	('MA00013',N'Gà Nướng Muối Ớt',350000,'DM00003'),

	
	('MA00014',N'Chè Khúc Bạch',25000,'DM00004'),
	('MA00015',N'Bánh Mochi Kem Lạnh',35000,'DM00004')
go
insert into HoaDon values
	('HD00001','25/11/2024')
go
insert into ChiTietHoaDon values 
	('CT00001', 'MA00001',3,'HD00001')

select * from DanhMucMonAn
select * from MonAn
select * from QuanTriVien
select * from NhanVienNhaHang
select * from HoaDon
select * from ChiTietHoaDon