create database DuLieu	
go
use DuLieu
go

--Tự tạo mã
create FUNCTION AUTO_IDKH()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaKH) FROM KHACHHANG) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaKH, 3)) FROM KHACHHANG
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'KH00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 and @ID <99 THEN 'KH0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99  THEN 'KH' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
create FUNCTION AUTO_IDTP()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaDat) FROM PHIEUTHUE) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaDat, 3)) FROM PHIEUTHUE
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'DP00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 and @ID <99 THEN 'DP0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99  THEN 'DP' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
create FUNCTION AUTO_IDNP()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaNhan) FROM PHIEUNHAN) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaNhan, 3)) FROM PHIEUNHAN
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'NP00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 and @ID <99 THEN 'NP0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99  THEN 'NP' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
create FUNCTION AUTO_IDDV()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaSDDV) FROM SDDV) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaSDDV, 3)) FROM SDDV
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'DV00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 and @ID <99 THEN 'DV0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99  THEN 'DV' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
create FUNCTION AUTO_IDHD()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaHD) FROM HOADON) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaHD, 3)) FROM HOADON
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'HD00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 and @ID <99 THEN 'HD0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99  THEN 'HD' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
--tạo bảng
create table KHACHHANG
(
MaKH char(5) primary key  CONSTRAINT IDKH DEFAULT DBO.AUTO_IDKH(),
Ten nvarchar(50),
CMND int,
GioiTinh nvarchar(4) check(GioiTinh IN('Nam',N'Nữ')),
SDT varchar(11),
)

create table LOAIPHONG
(
MaLP char(5) primary key,
TenLP nvarchar(20) NOT NULL,
ThietBi nvarchar(50),
GiaTien int,
)
go

create table PHONG
(
MaP char(5),
MaLP char(5) references LOAIPHONG(MaLP),
primary key(MaP)
)
go

create table NHANVIEN
(
MaNV char(10) primary key,
TenNV nvarchar(50),
SDT varchar(11),
NgaySinh date,
)
go
create table PHIEUTHUE
(
MaDat char(5) primary key CONSTRAINT IDTP DEFAULT DBO.AUTO_IDTP(),
MaKH char(5) references KHACHHANG(MaKH),
TienDat int
)
go
create table CHITIETPHIEUTHUE
(
MaDat char(5)  REFERENCES PHIEUTHUE (MaDat) ,
MaP char(5) REFERENCES PHONG (MaP) ,
NgayDen date,
NgayDi date,
trangthai bit default '1',
Primary key(MaDat,MaP)
)
go
create table PHIEUNHAN
(
MaNhan char(5) primary key CONSTRAINT IDNP DEFAULT DBO.AUTO_IDNP(),
MaDat char(5)  REFERENCES PHIEUTHUE (MaDat) ,
MaKH char(5) references KHACHHANG(MaKH),
)
go
create table CHITIETPHIEUNHAN
(
MaNhan char(5) REFERENCES PHIEUNHAN (MaNhan),
MaP char(5) REFERENCES PHONG (MaP),
HoTen nvarchar(50),
CMND int,
NgayNhan date,
NgayTraDuKien date,
NgayTraThucTe date,
Primary key(MaNhan,MaP)
)
go
create table DICHVU
(
MaDV char(5) primary key,
TenDV nvarchar(20) NOT NULL,
DonGia int
)
go
create table SDDV
(
MaSDDV char(5) primary key CONSTRAINT IDDV DEFAULT DBO.AUTO_IDDV(),
MaNhan char(5) ,
MaP char(5) ,
MaDV char(5) references DICHVU(MaDV),
NgaySD date default(getdate()),
SoLuong int,
GhiChu nvarchar(150),
FOREIGN KEY(MaNhan,MaP) 
REFERENCES CHITIETPHIEUNHAN (MaNhan,MaP) 
)
go
create table DANGNHAP
(
MaNV char(10) references NHANVIEN(MaNV) primary key,
MatKhau varchar(30),
)
go
create table HOADON
(
MaHD char(5) primary key CONSTRAINT IDHD DEFAULT DBO.AUTO_IDHD(),
MaNV char(10) references NHANVIEN(MaNV),
MaKH char(5) references KHACHHANG(MaKH),
MaNhan char(5) REFERENCES PHIEUNHAN (MaNhan),
TienDichVu int,
TienPhong int,
GiamGia int,
TongTien int,
NgayLap date default(getdate())
)
go
create table CHITIETHOADON
(
MaHD char(5) references HOADON(MaHD),
MaP char(5) references PHONG(MaP),
MaSDDV char(5) references SDDV(MaSDDV),
primary key(mahd,masddv,map)
)
go
-- thủ tục thêm dữ liệu
 --thu tuc, thêm PHIEUTHUE
create proc addPHIEUTHUE (@madat char(5),@makh char(5),@tiendat int)
as
begin
insert into PHIEUTHUE(MaDat,MaKH,TienDat)
values (@madat,@makh,@tiendat)
end
go
create function xacnhan(@manhan char(5),@map char(5)) returns int
as
begin
declare @kq int
select @kq=count(map) from CHITIETHOADON a,HOADON b where a.MaHD=b.MaHD and b.MaNhan=@manhan and a.MaP=@map
return @kq
end
go
--trigger
create trigger xoanhanvien on dbo.dangnhap instead of
delete
as
declare @ma char(10)
begin
select @ma=MaNV from deleted
delete from NHANVIEN where MaNV=@ma
delete from DANGNHAP where MaNV=@ma
end
--thu tuc, thêm CHITIETPHIEUTHUE
create proc addCHITIETPHIEUTHUE (@madat char(5),@map char(5),@ngayden date,@ngaydi date)
as
begin
insert into CHITIETPHIEUTHUE (MaDat,MaP,NgayDen,NgayDi)
values (@madat,@map,@ngayden,@ngaydi)
end
go
--thu tuc, them PHIEUNHAN
create PROC addPHIEUNHAN (@MaN char(5),@MaD char(5),@MaKH char(5))
as
begin
insert into PHIEUNHAN(MaNhan,MaDat,MaKH)
values (@MaN,@MaD,@MaKH)
end
go
create proc addCHITIETPHIEUNHAN (@ma char(5),@map char(5),@hoten nvarchar(50),@cmnd int, @ngaynhan date,@ngaydi date)
as
begin
insert into CHITIETPHIEUNHAN(MaNhan,MaP,HoTen,CMND,NgayNhan ,NgayTraDuKien,NgayTraThucTe)
values (@ma,@map ,@hoten,@cmnd, @ngaynhan,@ngaydi,@ngaydi)
end
go

create proc addDICHVU (@madv char(5),@ten nvarchar(20),@gia int)
as
begin
insert into DICHVU(MaDV,TenDV,DonGia)
values (@madv,@ten,@gia)
end
go
create proc addHOADON (@mahd char(5),@manv char(10),@makh char(5),@manhan char(5),@dichvu int,@phong int,@giam int,@tong int,@ngay date)
as
begin
insert into HOADON(MaHD ,MaNV,MaKH,MaNhan,TienPhong,TienDichVu,GiamGia,TongTien,NgayLap)
values (@mahd,@manv,@makh,@manhan,@dichvu,@phong,@giam,@tong, @ngay)
end
go
create proc addCHITIETHOADON (@mahd char(5),@map char(5),@masddv char(5))
as
begin
insert into CHITIETHOADON(MaHD ,MaP,MaSDDV)
values (@mahd,@map,@masddv)
end
go
create proc addNHANVIEN (@manv char(10),@ten nvarchar(50),@sdt varchar(11), @ngay date)
as
begin
insert into NHANVIEN(MaNV,TenNV,SDT,NgaySinh)
values (@manv ,@ten,@sdt, @ngay)
end
go
create proc addPHONG (@map char(5),@malp char(5))
as
begin
insert into PHONG(MaP,MaLP)
values (@map,@malp)
end
go
create proc addLOAIPHONG (@malp char(5), @tenlp nvarchar(20), @thietbi nvarchar(50),@giatien int)
as
begin
insert into LOAIPHONG(MaLP,TenLP,ThietBi,GiaTien)
values (@malp, @tenlp, @thietbi,@giatien)
end
go
create proc addKHACHHANG (@makh char(5),@tenkh nvarchar(50), @cmnd int,@gioitinh nvarchar(4),@sdt varchar(11))
as
begin
insert into KHACHHANG(MaKH,Ten,CMND,GioiTinh,SDT)
values (@makh,@tenkh,@cmnd,@gioitinh,@sdt)
end
go
create proc addKHACHHANG2 (@tenkh nvarchar(50), @cmnd int,@gioitinh nvarchar(4),@sdt varchar(11))
as
begin
insert into KHACHHANG(MaKH,Ten,CMND,GioiTinh,SDT)
values (dbo.AUTO_IDKH(),@tenkh,@cmnd,@gioitinh,@sdt)
end
go
create proc addDANGNHAP (@manv char(10),@mk varchar(30))
as
begin
insert into DANGNHAP (MaNV,MatKhau)
values (@manv,@mk)
end
go

--thu tuc, them SDDV
create proc addSDDV (@MaN char(5),@MaP char(5), @MaDV char(5), @ngay date, @soluong int, @ghichu nvarchar(50))
as
begin
insert into SDDV(MaSDDV,MaNhan,MaP,MaDV,NgaySD,SoLuong,GhiChu)
values (dbo.AUTO_IDDV(),@MaN,@MaP,@MaDV,@ngay,@soluong,@ghichu)
end
go
create proc xemDV (@MaP char(5), @MaN char(5))
as
begin
select MaPhong=SDDV.MaP,SddV.MaNhan,TenDV from DICHVU,SDDV,CHITIETPHIEUNHAN as a where Sddv.MaDV=DICHVU.MaDV and  a.MaP=SDDV.MaP and a.MaP=@MaP and NgaySD between NgayNhan and NgayTraDuKien
end
go
--bảng KHACHHANG
create proc seaMaKH @kh char(5)
as
begin
select * from KHACHHANG
where MaKH=@kh
end
go
create proc seaCMND @kh int
as
begin
select * from KHACHHANG
where CMND=@kh
end
go
create proc seaTenKH @kh nvarchar(50)
as
begin
select * from KHACHHANG
where Ten like N'%'+@kh+'%'
end
go
create proc seaPhong @kh nvarchar(50)
as
begin
select MaP from CHITIETPHIEUNHAN
where HoTen like N'%'+@kh+'%' and GETDATE() between NgayNhan and NgayTraDuKien
end
go
create proc hoadondv @man char(5),@map char(5)
as
begin
select MaP,TenDV,NgaysD,DonGia,Soluong from sddv,dichvu where sddv.MaDV=DICHVU.MaDV and MaNhan=@man and map=@map and TenDV !=  N'Hệ Thống' 
end
go
create proc LayPhong
as
begin
select PHIEUTHUE.MaDat,MaP,MaKH,NgayDen,NgayDi from PHIEUTHUE,CHITIETPHIEUTHUE 
where PHIEUTHUE.MaDat=CHITIETPHIEUTHUE.MaDat and getdate()<NgayDi and CHITIETPHIEUTHUE.MaDat not in (select MaDat from PHIEUNHAN)
order by NgayDen 
end
go
create proc xoaall
as
begin
delete from CHITIETHOADON
delete from CHITIETPHIEUTHUE
delete from HOADON
delete from CHITIETPHIEUNHAN
delete from SDDV
delete from PHIEUNHAN
delete from PHIEUTHUE
end
go
create proc LayPhong
as
begin
select PHIEUTHUE.MaDat,MaP,MaKH,NgayDen,NgayDi from PHIEUTHUE,CHITIETPHIEUTHUE 
where PHIEUTHUE.MaDat=CHITIETPHIEUTHUE.MaDat and getdate()<NgayDi and CHITIETPHIEUTHUE.MaDat not in (select MaDat from PHIEUNHAN)
order by NgayDen 
end
go
-- nap du lieu
--bangkhachhang
addKHACHHANG 'KH001', N'Lê Kế Hưng', '123456001', 'Nam', '0969038327' 
go
addKHACHHANG 'KH002', N'Nguyễn Tuấn Thành', '123456002', 'Nam', '01627583500' 
go
addKHACHHANG 'KH003',N'Phạm Thanh Tâm','201714402',N'Nữ','0906544538'
go
addKHACHHANG 'KH004', N'Nguyễn Minh Đức', '123456003', 'Nam', '0975407549' 
go
addKHACHHANG 'KH005', N'Nguyễn Vũ Nghĩa', '123456004', 'Nam', '0968241867' 
go
addKHACHHANG 'KH006', N'Vũ Văn Đông', '123456005', 'Nam', '01628274495' 
go
addKHACHHANG 'KH007', N'Nguyễn Đức Việt', '123456006', 'Nam', '0962841321' 
go
addKHACHHANG 'KH008', N'Hà Quang Tùng', '123456007', 'Nam', '0971501062' 
go
addKHACHHANG 'KH009', N'Ngô Đức Việt', '123456008', 'Nam', '0912994948' 
go
addKHACHHANG 'KH010', N'Nguyễn Xuân Dương', '123456009', 'Nam', '01667464323' 
go
addKHACHHANG 'KH011', N'Phạm Văn Đạt', '123456010', 'Nam', '0946620307' 
go
addKHACHHANG 'KH012', N'Lê Việt Hoàng', '123456011', 'Nam', '01686126685' 
go
addKHACHHANG 'KH013', N'Văn Sỹ Lực', '123456012', 'Nam', '01665982365' 
go
addKHACHHANG 'KH014', N'Ninh Văn Hiếu', '123456013', 'Nam', '0975804165' 
go
addKHACHHANG 'KH015', N'Vũ Mạnh Trung', '123456014', 'Nam', '0987805064' 
go
addKHACHHANG 'KH016', N'Nguyễn Đăng Hưng', '123456015', 'Nam', '0962425697' 
go
addKHACHHANG 'KH017', N'Bùi Quang Minh', '123456016', 'Nam', '0948716420' 
go
addKHACHHANG 'KH018', N'Vũ Hoàng Đức', '123456017', 'Nam', '01636277361' 
go
addKHACHHANG 'KH019', N'Đinh Quang Thức', '123456018', 'Nam', '01673410493' 
go
addKHACHHANG 'KH020', N'Phạm Quốc Thịnh', '123456019', 'Nam', '0971360788' 
go
addKHACHHANG 'KH021', N'Mai Quang Tùng', '123456020', 'Nam', '01687995734' 
go
addKHACHHANG 'KH022', N'Hà Tâm Đắc', '123456021', 'Nam', '0972181594' 
go
addKHACHHANG 'KH023', N'Lê Bảo Thoại', '123456022', 'Nam', '01665896889' 
go
addKHACHHANG 'KH024', N'Nguyễn Đình Vũ', '123456023', 'Nam', '0962423711' 
go
addKHACHHANG 'KH025', N'Lê Đức Huy', '123456024', 'Nam', '0987409534' 
go
addKHACHHANG 'KH026', N'Trần Minh Hoàng', '123456025', 'Nam', '01647510186' 
go
addKHACHHANG 'KH027', N'Nguyễn Trọng Đạt', '123456026', 'Nam', '01248510187' 
go
addKHACHHANG 'KH028', N'Lương Thành Hoàn', '123456027', 'Nam', '01665379461' 
go
addKHACHHANG 'KH029', N'Nguyễn Tài Hải', '123456028', 'Nam', '01665366605' 
go
addKHACHHANG 'KH030', N'Nguyễn Bá Hải', '123456029', 'Nam', '01675830634' 
go
addKHACHHANG 'KH031', N'Nguyễn Doãn Hoàng', '123456030', 'Nam', '01637357827' 
go
addKHACHHANG 'KH032', N'Trần Xuân Vũ', '123456031', 'Nam', '01637357828' 
go
addKHACHHANG 'KH033', N'Lê Văn Phong', '123456032', 'Nam', '0936498771' 
go
addKHACHHANG 'KH034', N'Lê Ngọc Nam', '123456033', 'Nam', '01633164195' 
go
addKHACHHANG 'KH035', N'Nguyễn Phương Thắng', '123456034', 'Nam', '0966249682' 
go
addKHACHHANG 'KH036', N'Bùi Ngọc Ánh', '123456035', 'Nam', '01243019397' 
go
addKHACHHANG 'KH037', N'Kiều Văn Đức', '123456036', 'Nam', '0987614687' 
go
addKHACHHANG 'KH038', N'Vũ Nguyễn Minh Hùng ', '123456037', 'Nam', '0989440932' 
go
addKHACHHANG 'KH039', N'Nguyễn Xuân Thông', '123456038', 'Nam', '0982562912' 
go
addKHACHHANG 'KH040', N'Nguyễn Khắc Giáp', '123456049', 'Nam', '01633779509' 
go
addKHACHHANG 'KH041', N'Lê Văn Long', '123456040', 'Nam', '0961236604' 
go
addKHACHHANG 'KH042', N'Nguyễn Quốc Nghĩa', '123456041', 'Nam', '01629129045' 
go
addKHACHHANG 'KH043', N'Lưu Trần Ân', '123456042', 'Nam', '0963056674' 
go
addKHACHHANG 'KH044', N'Lê Thị Quỳnh', '123456043', 'Nam', '01686180160' 
go
addKHACHHANG 'KH045', N'Lê Trung Hiếu', '123456044', 'Nam', '01686180161' 
go
addKHACHHANG 'KH046', N'Trần Nam Khánh', '123456045', 'Nam', '01676650607' 
go
addKHACHHANG 'KH047', N'Hoàng Viết Thái Hiệp', '123456046', 'Nam', '01666445061' 
go
addKHACHHANG 'KH048', N'Nguyễn Phúc Hưng', '123456047', 'Nam', '0968626177' 
go
addKHACHHANG 'KH049', N'Phan Đức Dũng', '123456048', 'Nam', '01667258933' 
go
addKHACHHANG 'KH050', N'Lê Thị Thảo', '123456059', 'Nam', '0968482267' 
go
addKHACHHANG 'KH051', N'Đậu Thị Thanh Huyền', '123456050', 'Nam', '0943472729' 
go
addKHACHHANG 'KH052', N'Nguyễn Hoàng Trí', '123456051', 'Nam', '01698622870' 
go
addKHACHHANG 'KH053', N'Phạm Đức Long', '123456052', 'Nam', '0983481417' 
go
addKHACHHANG 'KH054', N'Đặng Đình  Khích', '123456053', 'Nam', '0969080274' 
go
addKHACHHANG 'KH055', N'Cao Hữu Nhật', '123456054', 'Nam', '01676996328'  
go
addKHACHHANG 'KH056', N'Đinh Hải Khánh', '123456055', 'Nam', '0978509252' 
go
addKHACHHANG 'KH057', N'Trần Văn Thắng', '123456056', 'Nam', '01699406974'  
go
addKHACHHANG 'KH058', N'Trịnh Xuân Hoàng', '123456057', 'Nam', '01637250150'  
go
addKHACHHANG 'KH059', N'Cao Đình Dũng', '123456058', 'Nam', '0975179226'  
go
addKHACHHANG 'KH060', N'Vũ Tiến Đức', '123456069', 'Nam', '0971388629'  
go
addKHACHHANG 'KH061', N'Bùi Đức Tuấn', '123456060', 'Nam', '01654081101'  
go
addKHACHHANG 'KH062', N'Phạm Văn Cường', '123456061', 'Nam', '0981219074'  
go
addKHACHHANG 'KH063', N'Phạm Tiến Đại', '123456062', 'Nam', '01634132484'  
go
addKHACHHANG 'KH064', N'Nguyễn Hoàng Hiệp', '123456063', 'Nam', '01288494909' 
go
addKHACHHANG 'KH065', N'Lê Đức Khánh', '123456064', 'Nam', '0905700947'  
go
addKHACHHANG 'KH066', N'Nguyễn Phúc Tú', '123456065', 'Nam', '0978797135'  
go
addKHACHHANG 'KH067', N'Trần Minh Phát', '123456066', 'Nam', '01232680874'  
go
addKHACHHANG 'KH068', N'Nguyễn Phú Lập', '123456067', 'Nam', '01225881803'  
go
addKHACHHANG 'KH069', N'Phạm trung Hiếu', '123456068', 'Nam', '0978797139'  
go
addKHACHHANG 'KH070', N'Nguyễn Đình Hoàng', '123456070', 'Nam', '01669791576'  
go
addKHACHHANG 'KH071', N'Nguyễn Lương Hoàng', '123456071', 'Nam', '01627219564'  
go
addKHACHHANG 'KH072', N'Trần Công Luận', '123456072', 'Nam', '01685656455'  
go
addKHACHHANG 'KH073', N'Nguyễn Thị Hà', '123456073', 'Nam', '01658209398' 
go
addKHACHHANG 'KH074', N'Nguyễn Thị Bích Ngọc', '123456074', N'Nữ', '01649704927' 
go
addKHACHHANG 'KH075', N'Phạm Vũ Linh', '123456075', 'Nam', '01643445580' 
go
addKHACHHANG 'KH076', N'Nguyễn Minh Tú', '123456076', N'Nữ', '01665135866' 
go
addKHACHHANG 'KH077', N'Nguyễn Tiến Chiến', '123456077', 'Nam',  '0943969896' 
go
addKHACHHANG 'KH078', N'Nguyễn Trung Thành', '123456078', 'Nam', '0981080897' 
go
addKHACHHANG 'KH079', N'Đỗ Đức Lộc', '123456079', 'Nam', '0961933697' 
go
addKHACHHANG 'KH080', N'Lê Văn Đạt', '123456080', 'Nam', '0961108721' 
go
addKHACHHANG 'KH081', N'Nguyễn Anh Việt', '123456081', 'Nam', '0984850495' 
go
addKHACHHANG 'KH082', N'Nguyễn Quý Thắng', '123456082', 'Nam', '0972558724' 
go
addKHACHHANG 'KH083', N'Hoàng quốc Trọng', '123456083', 'Nam', '01239725256' 
go
addKHACHHANG 'KH084', N'Nguyễn Thị Hồng Nhung', '123456084', N'Nữ', '0986851667' 
go
addKHACHHANG 'KH085', N'Đậu Thị Kim Dung', '123456085', N'Nữ', '0942562296' 
go
addKHACHHANG 'KH086', N'Tăng Đại Dương', '123456086', 'Nam', '0981188304' 
go
addKHACHHANG 'KH087', N'Đinh Thị Phương', '123456087', N'Nữ', '01628652344' 
go
addKHACHHANG 'KH088', N'Vũ Ngọc Sơn', '123456088', 'Nam', '0932261938' 
go
addKHACHHANG 'KH089', N'Trần Đình Oánh', '123456089', 'Nam', '0962810485' 
go
addKHACHHANG 'KH090', N'Trần Hải Dương', '123456090', 'Nam', '0971854694' 
go
addKHACHHANG 'KH091', N'Trương Văn Tuấn', '123456091', 'Nam', '01645888339' 
go
addKHACHHANG 'KH092', N'Đặng Đức Trọng', '123456092', 'Nam', '0965510693' 
go
addKHACHHANG 'KH093', N'Dương Đình Hưng', '123456093', 'Nam', '01654110830' 
go
addKHACHHANG 'KH094', N'Lê Thị Phượng', '123456094', N'Nữ', '01659092184' 
go
addKHACHHANG 'KH095', N'Phạm Thị Việt Hoài', '123456095', N'Nữ', '0948239697' 
go
addKHACHHANG 'KH096', N'Lê Doãn An', '123456096', 'Nam', '01687271295' 
go
addKHACHHANG 'KH097', N'Phạm Huy Công', '123456097', 'Nam', '01633428848'
go
addKHACHHANG 'KH098', N'Nguyễn Văn Thái', '123456098', 'Nam', '0964632297'
go
addKHACHHANG 'KH099', N'Đỗ Đức Anh', '123456099', 'Nam', '0961986607'
go
addKHACHHANG 'KH100', N'Kiều Khắc Tráng', '123456100', 'Nam', '01687271299'
go
--bangnhavien
addNHANVIEN 'LT01', N'Nguyễn Văn An', '0123456000', ' 19970101' 
go 
addNHANVIEN 'LT02',  N'Nguyễn Thị Bình', '0123456111', '19960202'
go
addNHANVIEN 'LT03', N'Lê Văn Cường', '0123456222', '19950303'
go
addNHANVIEN 'LT04', N'Lê Thị Duyên', '0123456333',	'19940404'
go
addNHANVIEN 'LT05', N'Trần Văn Em','0123456444', '19930505'
go
addNHANVIEN 'LT06', N'Trần Thị Phương', '0123456555', '19920606'
go
addNHANVIEN 'LT07', N'Phan Văn Giang', '0123456666', '19910707'
go
addNHANVIEN 'LT08', N'Phan Thị Hồng', '0123456777', '19900808'
go
addNHANVIEN 'LT09', N'Vũ Văn Iuận', '0123456888', '19890909'
go
addNHANVIEN 'LT10', N'Vũ Thị Kha', '0123456999', '19871010'
go
addNHANVIEN 'Boss', 'Night Fury', '123456789', '20000101'
go
-- NHANVIEN
addDANGNHAP 'LT01', 'NhanVien01'
go
addDANGNHAP 'LT02', 'NhanVien02'
go
addDANGNHAP 'LT03', 'NhanVien03'
go
addDANGNHAP 'LT04', 'NhanVien04'
go
addDANGNHAP 'LT05', 'NhanVien05'
go
addDANGNHAP 'LT06', 'NhanVien06'
go
addDANGNHAP 'LT07', 'NhanVien07'
go
addDANGNHAP 'LT08', 'NhanVien08'
go
addDANGNHAP 'LT09', 'NhanVien09'
go
addDANGNHAP 'LT10', 'NhanVien10'
go
addDANGNHAP 'Boss', '123'
go

--LOAIPHONG	
addLOAIPHONG 'ST01', N' Standard đơn', N'Cảnh thành phố, máy lạnh, tủ lạnh, điện thoại, ti vi, nước nóng, bồn tắm, máy sấy tóc, Internet Wireless',' 100000'
go
addLOAIPHONG 'ST02', N' Standard đôi', N' Cảnh thành phố, máy lạnh, tủ lạnh, điện thoại, ti vi, nước nóng, bồn tắm, máy sấy tóc, Internet Wireless',' 100000'
go
addLOAIPHONG 'ST03', N' Standard ba',  N' Cảnh thành phố, máy lạnh, tủ lạnh, điện thoại, ti vi, nước nóng, bồn tắm, máy sấy tóc, Internet Wireless',' 120000'
go
addLOAIPHONG 'S01', N' superior đơn' , N' Cảnh thành phố, máy lạnh, tủ lạnh, điện thoại, ti vi, nước nóng, bồn tắm, máy sấy tóc, Internet Wireless',' 120000'
go
addLOAIPHONG 'S02', N' superior đôi', N' Cảnh thành phố, máy lạnh, tủ lạnh, điện thoại, ti vi, nước nóng, bồn tắm, máy sấy tóc, Internet Wireless',' 120000'
go
addLOAIPHONG 'S03', N' superior ba', N' Cảnh thành phố, máy lạnh, tủ lạnh, điện thoại, ti vi, nước nóng, bồn tắm, máy sấy tóc, Internet Wireless',' 150000'
go
addLOAIPHONG 'D02', N' Deluxe đôi', N' Cảnh thành phố, máy lạnh, tủ lạnh, điện thoại, ti vi, nước nóng, bồn tắm, máy sấy tóc, Internet Wireless',' 160000'
go
addLOAIPHONG 'SD01', N' Senior Deluxe đơn', N' Cảnh thành phố, máy lạnh, tủ lạnh, điện thoại, ti vi, nước nóng, bồn tắm, máy sấy tóc, Internet Wireless',' 180000'
go
addLOAIPHONG 'SD02', N' Senior Deluxe đôi', N' Cảnh thành phố, máy lạnh, tủ lạnh, điện thoại, ti vi, nước nóng, bồn tắm, máy sấy tóc, Internet Wireless',' 180000'
go
--Bang PHONG

addPHONG '101' , 'ST01'
go
addPHONG '102' , 'ST01'
go
addPHONG '103' , 'ST01'
go
addPHONG '104' , 'ST01'
go
addPHONG '105' , 'ST01'
go
addPHONG '106' , 'ST02'
go
addPHONG '107' , 'ST02'
go
addPHONG '108' , 'ST02'
go
addPHONG '109' , 'ST02'
go
addPHONG '110' , 'ST02'
go
addPHONG '111' , 'ST03'
go
addPHONG '112' , 'ST03'
go
addPHONG '201' , 'S01'
go
addPHONG '202' , 'S01'
go
addPHONG '203' , 'S01'
go
addPHONG '204' , 'S02'
go
addPHONG '205' , 'S02'
go
addPHONG '206' , 'S02'
go
addPHONG '207' , 'S03'
go
addPHONG '208' , 'S03'
go
addPHONG '209' , 'S03'
go
addPHONG '301' , 'D02'
go
addPHONG '302' , 'D02'
go
addPHONG '303' , 'D02'
go
addPHONG '304' , 'D02'
go
addPHONG '305' , 'SD01'
go
addPHONG '306' , 'SD01'
go
addPHONG '307' , 'SD02'
go
addPHONG '308' , 'SD02'
go
--DICHVU
addDICHVU 'SV00',N'Hệ Thống','0'
 go
addDICHVU 'SV01',N'Quầy Bar','1000000'
 go
addDICHVU 'SV02','Spa ','200000'
 go
addDICHVU 'SV03','Fitness Center','50000'
 go
addDICHVU 'SV04','Party room','2000000'
 go
addDICHVU 'SV05','Office Service','50000'
 go
addDICHVU 'SV06','Express laundry service','20000'
 go
addDICHVU 'SV07',N'Dịch vụ cho thuê xe','100000'
 go
addDICHVU 'SV08',N'Dịch vụ đưa đón','200000'
 go
addDICHVU 'SV09',N'Phục vụ phòng ','200000'
 go
addDICHVU 'SV10',N'Đặt vé du lịch, máy bay','50000'
 go
addDICHVU 'SV11',N'Bán hàng lưu niệm','200000'
 go
addDICHVU 'SV12',N'Dịch vụ bể bơi','80000'
 go
addDICHVU 'SV13','Karaoke','150000'
 go
addDICHVU 'SV14','Tennis','100000'
 go
addDICHVU 'SV15','Billard','60000'
 go
addDICHVU 'SV16',N'Chăm sóc trẻ','100000'
 go



addPHIEUTHUE 'DP001','KH001','1000000'
go
addPHIEUTHUE 'DP002','KH002','2000000'
go
addPHIEUTHUE 'DP003','KH003','3000000'
go
addPHIEUTHUE 'DP004','KH004','4000000'
go
addPHIEUTHUE 'DP005','KH005','5000000'
go

addCHITIETPHIEUTHUE 'DP001','101','20180101','20180120'
go
addCHITIETPHIEUTHUE 'DP002','102','20180201','20180220'
go
addCHITIETPHIEUTHUE 'DP003','103','20180101','20180211'
go
addCHITIETPHIEUTHUE 'DP004','104','20180121','20180321'
go
addCHITIETPHIEUTHUE 'DP005','105','20180401','20180411'
go

addPHIEUNHAN 'NP001','DP001','KH001'
go
addPHIEUNHAN 'NP002','DP002','KH002'
go
addPHIEUNHAN 'NP003','DP003','KH003'
go
addPHIEUNHAN 'NP004','DP004','KH004'
go
addPHIEUNHAN 'NP005','DP005','KH005'
go



addCHITIETPHIEUNHAN 'NP001','101',N'Lê Kế Hưng','123456001', '20180101','20180120'
go
addCHITIETPHIEUNHAN 'NP002','102', N'Nguyễn Tuấn Thành', '123456002', '20180201','20180220'
go
addCHITIETPHIEUNHAN 'NP003','103',N'Vũ Văn Dông', '123457003', '20180101','20180211'
go
addCHITIETPHIEUNHAN 'NP004','104', N'Nguyễn Minh đức', '123456003', '20180121','20180321'
go
addCHITIETPHIEUNHAN 'NP005','105', N'Nguy?n V? Ngh?a', '123456004', '20180401','20180411'
go

print dbo.AUTO_IDTP()

select Map as Phong,NgayDen,NgayDi from CHITIETPHIEUTHUE where ('20180303' between NgayDen and NgayDi) or ('20180415' between NgayDen and NgayDi)
select Map,NgayDen,NgayDi  from CHITIETPHIEUTHUE where '" + ngayden + "' between NgayDen and NgayDi or '" + ngaytra + "' between NgayDen and NgayDi

addKHACHHANG 'KH102',N'Phạm Thị Thanh Tâm','1233423',N'Nữ','067132484' 
addKHACHHANG 'KH103',N'Phạm Thị Thanh Tâm','1233423',N'Nữ','067132484' 

select * from CHITIETPHIEUNHAN

select MaP,TenDV from DICHVU,SDDV where DICHVU.MaDV = SDDV.MaDV

hoadondv 'NP012','206'
hoadondv 'NP012',' 206'

create FUNCTION DichVu()
RETURNS int
AS
BEGIN
	DECLARE @money int = 0
	while 
	RETURN @money
END
GO

select * from SDDV

select tong=sum(DonGia*SoLuong) from ()
 group by MaSDDV

 select tien=DonGia*SoLuong,MaSDDV from sddv,DICHVU where SDDV.MaDV=DICHVU.MaDV and MaNhan='NP012' and MaP='206'
  select tien=DonGia*SoLuong,MaSDDV from sddv,DICHVU where SDDV.MaDV=DICHVU.MaDV and MaNhan='NP012' and MaP='206  '
  select tien=DonGia*SoLuong,MaSDDV from sddv,DICHVU where SDDV.MaDV=DICHVU.MaDV and MaNhan='NP012' and MaP='206'
  select tien=DonGia*SoLuong,MaSDDV from sddv,DICHVU where SDDV.MaDV=DICHVU.MaDV and MaNhan='NP012' and MaP='206  '

	select ID=GiaTien from LOAIPHONG,PHONG where LOAIPHONG.MaLP=PHONG.MaLP and MaP='206'
	update CHITIETPHIEUNHAN set NgayTraThucTe = GETDATE() where MaNhan=''
	addHOADON 'HD001','LT01','KH003','NP012','8850000','240000','9090000','20180429'
	select * from CHITIETPHIEUNHAN
	select MaP,MaNhan,NgayNhan,NgayTraDuKien,Hoten from CHITIETPHIEUNHAN where getdate() between NgayNhan and NgayTraDuKien
	select * from hoadon

	select a.MaP,NgayNhan,NgayTraThucTe,thoigian=DATEDIFF(day,NgayNhan,NgayTraThucTe),TongTien from CHITIETPHIEUNHAN as a,HOADON as b,CHITIETHOADON as c where a.MaNhan = b.MaNhan and c.MaP=a.MaP

		create proc LayPhong
	as
	begin
	select PHIEUTHUE.MaDat,MaP,MaKH,NgayDen,NgayDi from PHIEUTHUE,CHITIETPHIEUTHUE 
	where PHIEUTHUE.MaDat=CHITIETPHIEUTHUE.MaDat and getdate()<NgayDi and CHITIETPHIEUTHUE.MaDat not in (select MaDat from PHIEUNHAN)
	order by NgayDen 
	end
	go
	-- vẫn đang test
	select MaP,MaNhan,NgayNhan,NgayTraDuKien,Hoten from CHITIETPHIEUNHAN as a
	where MaP not in (select MaP from CHITIETHOADON as b,HOADON where b.MaHD=HOADON.MaHD and HOADON.MaNhan=a.MaNhan)

	


	create

	select MaP from CHITIETPHIEUTHUE where trangthai = '1' and getdate() between NgayDen and NgayDi 
	
	select * from PHIEUNHAN
	select * from CHITIETPHIEUTHUE
	select MaNhan from CHITIETHOADON ct,HOADON hd where ct.MaHD=hd.MaHD and MaP='' and ct.MaHD=''


	delete from CHITIETPHIEUTHUE

	
	update CHITIETPHIEUTHUE set trangthai = '0' where MaDat = (select MaDat from PHIEUNHAN where MaNhan = 'NP001') 
	alter table CHITIETPHIEUTHUE
	add trangthai bit default '1'



GO

select MaP,MaNhan,NgayNhan,NgayTraDuKien,Hoten from CHITIETPHIEUNHAN where dbo.xacnhan(MaNhan,MaP)='0' and getdate() between NgayNhan and NgayTraDuKien  

