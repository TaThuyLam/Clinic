CREATE TABLE NHANVIEN(
    manv int  primary key,
    hoten nvarchar(50),
    trinhdo nvarchar(50),
    chuyenmon nvarchar(50),
    chucvu nvarchar(50),
    taikhoan char(20),
    matkhau char(10)
)
CREATE TABLE BENHNHAN(
   mabn int primary key,
   hoten nvarchar(50),
   ngaysinh nvarchar(50),
    dichi nvarchar(50),
    gioitinh nvarchar(3),
    sodienthoai char(10)
)



CREATE TABLE LOAIDICHVU(
    maloaidv int primary key,
    tenloaidv nvarchar(50)
)

CREATE TABLE PHONG(
    maphong int primary key,
    tenphong nvarchar(50)
)
CREATE TABLE DICHVU(
    madv int primary key,
    tendv nvarchar(50),
    dongia int,
    donvi nvarchar(10),
    maloaidv int,
    maphong int,
    FOREIGN KEY (maloaidv) REFERENCES LOAIDICHVU(maloaidv),
    FOREIGN KEY (maphong) REFERENCES PHONG(maphong)
)

CREATE TABLE THUOC(
    mathuoc int primary key,
    tenthuoc nvarchar(50),
    dongia float,
    donvi nvarchar(10)
    )
CREATE TABLE PHIEUKHAMBENH(
    maphieukham int primary key,
    mabn int,
    ngaykham date,
    tenbs nvarchar(50),
    tennv nvarchar(50),
    chuandoan nvarchar(50),
    benhkemtheo nvarchar(50),
    diungthuoc nvarchar(50),
    ngaytaikham date,
    FOREIGN KEY (mabn) REFERENCES BENHNHAN(mabn)
)

CREATE TABLE PHIEUDICHVU(
    maphieudichvu int primary key,
    maphieukham int,
    ghichu nvarchar(50),
    tongcong int,
    trangthaithanhtoan char(1),
    FOREIGN KEY (maphieukham) REFERENCES PHIEUKHAMBENH(maphieukham)
)
CREATE TABLE CHITIETPHIEUDICHVU(
    maphieudichvu int,
    madv int,
    soluong int,
    trangthai nvarchar(50),
    ketqua nvarchar(50),
    FOREIGN KEY (maphieudichvu) REFERENCES PHIEUDICHVU(maphieudichvu),
       FOREIGN KEY (madv) REFERENCES DICHVU(madv)
)
CREATE TABLE DONTHUOC(
    madonthuoc int primary key,
    maphieukham int,
    ghichu NTEXT,
	songaythuoc int,
    tongcong int,
    trangthaithanhtoan char(1),
    FOREIGN KEY (maphieukham) REFERENCES PHIEUKHAMBENH(maphieukham)
)
CREATE TABLE CHITIETDONTHUOC(
    madonthuoc int,
    mathuoc int,
	sang int,
	trua int,
	chieu int,
	toi int,
    soluong int,
	thanhtien float,
    lieudung nvarchar(50),
	FOREIGN KEY (madonthuoc) REFERENCES DONTHUOC(madonthuoc),
	FOREIGN KEY (mathuoc) REFERENCES THUOC(mathuoc)
)

-- Thêm loại dịch vụ
INSERT INTO LOAIDICHVU VALUES(1,N'Khám bệnh')
INSERT INTO LOAIDICHVU VALUES(2,N'Chẩn đoán hình ảnh')
INSERT INTO LOAIDICHVU VALUES(3,N'Điện tâm đồ')
INSERT INTO LOAIDICHVU VALUES(4,N'Xét nghiệm')
-- Thêm phòng
INSERT INTO PHONG VALUES(1,N'PHÒNG KHÁM BỆNH')
INSERT INTO PHONG VALUES(2,N'PHÒNG CHỤP X-QUANG')
INSERT INTO PHONG VALUES(3,N'PHÒNG TIM MẠCH')
INSERT INTO PHONG VALUES(4,N'PHÒNG XÉT NGHIỆM')
-- Thêm dịch vụ
INSERT INTO DICHVU VALUES(1001,N'Khám nội tổng hợp',100000,'lan',1,1)
INSERT INTO DICHVU VALUES(1002,N'Khám ngoại',100000,'lan',1,1)

INSERT INTO DICHVU VALUES(2001,N'Siêu âm ổ bụng tổn quát',120000,'lan',2,2)
INSERT INTO DICHVU VALUES(2002,N'Siêu âm thai 2D',150000,'lan',2,2)
INSERT INTO DICHVU VALUES(2003,N'Siêu âm thai 4D',300000,'lan',2,2)
INSERT INTO DICHVU VALUES(2004,N'Siêu âm tử cung phần phụ',120000,'lan',2,2)
INSERT INTO DICHVU VALUES(2005,N'Siêu âm đầu dò âm đạo',150000,'lan',2,2)
INSERT INTO DICHVU VALUES(2006,N'Siêu âm tuyến vú 2 bênh',200000,'lan',2,2)
INSERT INTO DICHVU VALUES(2007,N'Siêu âm tuyến giáp',150000,'lan',2,2)
INSERT INTO DICHVU VALUES(2008,N'Siêu âm khớp(1 bộ phận)',120000,'lan',2,2)
INSERT INTO DICHVU VALUES(2009,N'Siêu âm phần mềm',100000,'lan',2,2)
INSERT INTO DICHVU VALUES(2010,N'Siêu âm Doppler mạch (1 bộ phận)',200000,'lan',2,2)
INSERT INTO DICHVU VALUES(2011,N'Siêu âm màng phổi',100000,'lan',2,2)
INSERT INTO DICHVU VALUES(2012,N'XQ tim phổi thẳng',100000,'lan',2,2)
INSERT INTO DICHVU VALUES(2013,N'XQ tim phổi nghiêng',100000,'lan',2,2)
INSERT INTO DICHVU VALUES(2014,N'XQ cột sống T-N (1 bộ phận)',150000,'lan',2,2)
INSERT INTO DICHVU VALUES(2015,N'XQ ổ bụng không chuẩn bị',100000,'lan',2,2)
INSERT INTO DICHVU VALUES(2016,N'XQ hệ tiết niệu',100000,'lan',2,2)
INSERT INTO DICHVU VALUES(2017,N'XQ khung chậu',100000,'lan',2,2)
INSERT INTO DICHVU VALUES(2018,N'XQ xương chi T-N (1 bộ phận)',150000,'lan',2,2)
INSERT INTO DICHVU VALUES(2019,N'XQ khớp T-N(1 khớp)',150000,'lan',2,2)
INSERT INTO DICHVU VALUES(2020,N'XQ so T-N',150000,'lan',2,2)
INSERT INTO DICHVU VALUES(2021,N'XQ Blondeau - Hirtz',150000,'lan',2,2)

INSERT INTO DICHVU VALUES(3001,N'Điện tâm đồ',50000,'lan',3,3)

INSERT INTO DICHVU VALUES(4001,N'Glucose máu',35000,'lan',4,4)
INSERT INTO DICHVU VALUES(4002,N'Ure',35000,'lan',4,4)
INSERT INTO DICHVU VALUES(4003,N'Creatinin',35000,'lan',4,4)
INSERT INTO DICHVU VALUES(4004,N'AST',35000,'lan',4,4)
INSERT INTO DICHVU VALUES(4005,N'ALT',35000,'lan',4,4)
INSERT INTO DICHVU VALUES(4006,N'GGT',40000,'lan',4,4)
INSERT INTO DICHVU VALUES(4007,N'Acid uric',40000,'lan',4,4)
INSERT INTO DICHVU VALUES(4008,N'Amylase',50000,'lan',4,4)
INSERT INTO DICHVU VALUES(4009,N'Cholesterol',35000,'lan',4,4)
INSERT INTO DICHVU VALUES(4010,N'Triglycerid',35000,'lan',4,4)
INSERT INTO DICHVU VALUES(4011,N'Bilirubin TT',35000,'lan',4,4)
INSERT INTO DICHVU VALUES(4012,N'Bilirubin TP',35000,'lan',4,4)
INSERT INTO DICHVU VALUES(4013,N'Protein máu',35000,'lan',4,4)
INSERT INTO DICHVU VALUES(4014,N'Albumin',35000,'lan',4,4)
INSERT INTO DICHVU VALUES(4015,N'Sắt huyết thanh',35000,'lan',4,4)
INSERT INTO DICHVU VALUES(4016,N'Calci TP',35000,'lan',4,4)


select madv as N'Mã dịch vụ',
		tendv as N'Tên dịch vụ', 
		dongia as N'Đơn giá', 
		donvi as N'Đơn vị tính', 
		tendv as N'Tên dịch vụ', 
		tenphong as N'Tên phòng' 
from DICHVU DV,LOAIDICHVU LDV,PHONG P 
where DV.maloaidv=LDV.maloaidv and DV.maphong=P.maphong

select * from NHANVIEN


INSERT INTO NHANVIEN VALUES(19110139,N'Tạ Thúy Lam',N'Đại học',N'Đa khoa',N'Bác sĩ','TaThuyLam','123456789')
INSERT INTO NHANVIEN VALUES(19110622,N'Đoàn Ngọc Thanh Vy',N'Đại học',N'Tim',N'Bác sĩ','DoanNgocThanhVy','123456789')
INSERT INTO NHANVIEN VALUES(19110432,N'Nguyễn Thị Thúy Hằng',N'Đại học',N'Kế toán',N'Kế toán','NguyenThiThuyHang','123456789')
INSERT INTO NHANVIEN VALUES(19110118,N'Bùi Thanh Xuân',N'Đại học',N'Tài chính kế toán',N'Kế toán','BuiThanhXuan','123456789')
INSERT INTO NHANVIEN VALUES(19110092,N'Trần Thị Anh Thư',N'Đại học',N'Điều dưỡng',N'Nhân viên tiếp nhận','TranThiAnhThu','123456789')
INSERT INTO NHANVIEN VALUES(19111195,N'Lương Ngọc Hải Đăng',N'Đại học',N'Điều dưỡng',N'Nhân viên tiếp nhận','LuongNgocHaiDang','123456789')


------------------------------------- hÀM KIỂM TRA ĐĂNG NHẬP------------------------------------------------------------
CREATE PROC sp_KiemTraDangNhap @username char(50),
								@pass char(20)
AS
BEGIN
	if(not exists( Select * From NHANVIEN where taikhoan=@username))
		raiserror(N'Người dùng không tồn tại!!!',16,1)
	else if(( Select matkhau From NHANVIEN where taikhoan=@username)!=@pass)
		raiserror(N'Sai mật khẩu!!!',16,1)
		else
			Select chucvu From NHANVIEN where taikhoan=@username and matkhau=@pass

END



exec sp_KiemTraDangNhap 'TaThuyLam','12345789'
-----------------------------------HÀM XEM DANH SÁCH HỒ SƠ BỆNH NHÂN------------------------------------------------------
create proc sp_DanhSachHoSoBenhNhan
as
begin
	select mabn as N'Mã bệnh nhân', 
			hoten as N'Họ và tên', 
			ngaysinh as N'Ngày sinh', 
			dichi as N'Địa chỉ', 
			gioitinh as N'Giới tính', 
			sodienthoai as N'Số điện thoại'
	from BENHNHAN
end

-----------------------------------HÀM THÊM BỆNH NHÂN---------------------------------------------------------------
create proc sp_ThemBenhNhan @hoten nvarchar(50),
						@ngaysinh date,
						@diachi nvarchar(50),
						@gioitinh nvarchar(3),
						@sodienthoai char(10)
as
begin
	declare @dem int
	set @dem=1
	if exists (select * from BENHNHAN where hoten=@hoten and ngaysinh=@ngaysinh and gioitinh=@gioitinh and sodienthoai=@sodienthoai)
	begin
		raiserror(N'Bệnh nhân đã được tạo!!!',16,1)
		return
	end
	else if(@ngaysinh>GETDATE())
		raiserror(N'Ngày sinh không được lớn hơn ngày hiện tại',16,1)
		else
		begin
		begin transaction
		begin try
			while( exists (select * from BENHNHAN with (updlock) where mabn=@dem))
				set @dem=@dem+1
			insert into BENHNHAN(mabn, hoten, ngaysinh, dichi,gioitinh,sodienthoai)
			values(@dem,@hoten,@ngaysinh,@diachi,@gioitinh,@sodienthoai)
			commit
		end try
		begin catch
			DECLARE @ErrMsg VARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg='Lỗi'+ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
	end
end
-----------------------------------HÀM XÓA HỒ SƠ BỆNH NHÂN---------------------------------------------------------------
create proc sp_XoaBenhNhan @mabn int
as
begin
	if(not exists(select * from BENHNHAN where mabn=@mabn))
		Raiserror('Bệnh nhân không tồn tại',16,1)
	else
	begin
		if(exists (select * from PHIEUKHAMBENH where mabn=@mabn))
		begin
			delete from PHIEUKHAMBENH where mabn=@mabn
		end
		Delete from BENHNHAN where mabn=@mabn
	end
end
-----------------------------------TÌM KIẾM HỒ SƠ BỆNH NHÂN---------------------------------------------------------------
create proc sp_TimBenhNhan @hoten nvarchar(50)
as
begin
	select mabn as N'Mã bệnh nhân', 
			hoten as N'Họ và tên', 
			ngaysinh as N'Ngày sinh', 
			dichi as N'Địa chỉ', 
			gioitinh as N'Giới tính', 
			sodienthoai as N'Số điện thoại'
	from BENHNHAN 
	where hoten like '%'+@hoten+'%'

end

exec sp_TimBenhNhan 'a'
-----------------------------------HÀM CHỈNH SỬA HỒ SƠ BỆNH NHÂN---------------------------------------------------------------
create proc sp_ChinhSuaBenhNhan @mabn int,
						@hoten nvarchar(50),
						@ngaysinh date,
						@diachi nvarchar(50),
						@gioitinh nvarchar(3),
						@sodienthoai char(10)
as
begin
	if not exists (select * from BENHNHAN where mabn=@mabn)
	begin
		raiserror(N'Bệnh nhân không tồn tại!!!',16,1)
		return
	end
	else
	begin
		begin transaction
		begin try
			update BENHNHAN
			set hoten =@hoten, ngaysinh=@ngaysinh,dichi=@diachi,gioitinh=@gioitinh,sodienthoai=@sodienthoai
			where mabn=@mabn
			commit
		end try
		begin catch
			DECLARE @ErrMsg VARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg='Lỗi'+ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
	end
end
-------------------------------------------TẠO PHIẾU KHÁM----------------------------------------------------
alter proc sp_TaoPhieuKhamBenh @hoten nvarchar(50),
						@ngaysinh date,
						@diachi nvarchar(50),
						@gioitinh nvarchar(3),
						@sodienthoai char(10),
						@bacsi nvarchar(50),
						@nhanvien nvarchar(50)
as
begin transaction
	declare @mapkb int
	declare @mabn int
	set @mapkb=1
	if not exists (select * from BENHNHAN where hoten=@hoten and ngaysinh=@ngaysinh and gioitinh=@gioitinh and sodienthoai=@sodienthoai)
	begin
		exec sp_ThemBenhNhan @hoten, @ngaysinh, @diachi, @gioitinh, @sodienthoai
	end
	set @mabn= (select mabn from BENHNHAN where hoten=@hoten and ngaysinh=@ngaysinh and gioitinh=@gioitinh and sodienthoai=@sodienthoai)
	begin transaction
		begin try
			while( exists (select * from PHIEUKHAMBENH with (updlock) where maphieukham=@mapkb))
				set @mapkb=@mapkb+1
			insert into PHIEUKHAMBENH
			values(@mapkb,@mabn,GETDATE(),@bacsi,@nhanvien,'','','','')
			commit
		end try
		begin catch
			DECLARE @ErrMsg VARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg='Lỗi'+ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
commit
-----------------------------------HÀM XEM DANH SÁCH PHIẾU KHÁM BỆNH------------------------------------------------------
create proc sp_DanhSachPhieuKham
as
begin
	select maphieukham as N'Mã phiếu khám', 
			ngaykham as N'Ngày khám',
			hoten as N'Họ và tên', 
			ngaysinh as N'Ngày sinh', 
			dichi as N'Địa chỉ', 
			gioitinh as N'Giới tính',
			tenbs as N'Bác sĩ',
			tennv as N'Nhân viên'
			
	from PHIEUKHAMBENH join BENHNHAN on PHIEUKHAMBENH.mabn=BENHNHAN.mabn
end
-----------------------------------HÀM XEM DANH SÁCH PHIẾU KHÁM BỆNH THEO NGÀY------------------------------------------------------
CREATE proc sp_DanhSachPhieuKhamTheoNgay @datefrom date,
									@dateto date
as
begin
	if(@datefrom>@dateto)
	begin
		Raiserror('Ngày bắt đầu phải trước hoặc cùng ngày với ngày kết thúc!!!',16,1)
		return
	end
	else
	begin
		select maphieukham as N'Mã phiếu khám', 
					ngaykham as N'Ngày khám',
			hoten as N'Họ và tên', 
			ngaysinh as N'Ngày sinh', 
			dichi as N'Địa chỉ', 
			gioitinh as N'Giới tính',
			tenbs as N'Bác sĩ',
			tennv as N'Nhân viên'
		from PHIEUKHAMBENH join BENHNHAN on PHIEUKHAMBENH.mabn=BENHNHAN.mabn
		where ngaykham>=@datefrom and ngaykham<=@dateto
	end
end
--------------------------------------LẤY DANH SÁCH BÁC SĨ------------------------------
CREATE PROC sp_LayDanhSachTenBacSi
as
begin
	select hoten +' - BS.'+chuyenmon 
	from NHANVIEN 
	where chucvu=N'Bác Sĩ'
end
--------------------------------------LẤY DANH SÁCH NHÂN VIÊN------------------------------
create PROC sp_LayDanhSachTenNhanVien
as
begin
	select hoten +' - '+chucvu 
	from NHANVIEN 
	where chucvu=N'Nhân viên tiếp nhận'
end
-----------------------------------HÀM XÓA PHIẾU KHÁM BỆNH---------------------------------------------------------------
create proc sp_XoaPhieuKhamBenh @mapk int
as
begin
	if(exists(select * from PHIEUKHAMBENH where maphieukham=@mapk))
		Delete from PHIEUKHAMBENH where maphieukham=@mapk
	else
		Raiserror('Phiếu khám không tồn tại',16,1)
end

exec sp_DanhSachHoSoBenhNhan
-----------------------------------HÀM CHỈNH SỬA PHIẾU KHÁM BỆNH---------------------------------------------------------------
create proc sp_ChinhSuaPhieuKhamBenh @maphieukham int,
						@mabn int,
						@hoten nvarchar(50),
						@ngaysinh date,
						@diachi nvarchar(50),
						@gioitinh nvarchar(3),
						@sodienthoai char(10),
						@bacsi nvarchar(50),
						@nhanvien nvarchar(50)
as
begin
		if not exists (select * from BENHNHAN where mabn=@mabn)
	begin
		raiserror(N'Hồ sơ bệnh nhân chưa có!!!',16,1)
		return
	end
	else
	begin
		begin transaction
		begin try
			update BENHNHAN set hoten =@hoten, ngaysinh=@ngaysinh,dichi=@diachi,gioitinh=@gioitinh,sodienthoai=@sodienthoai where mabn=@mabn
			update PHIEUKHAMBENH set tenbs=@bacsi, tennv=@nhanvien where maphieukham=@maphieukham

			commit
		end try
		begin catch
			DECLARE @ErrMsg VARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg='Lỗi'+ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
	end
end
-----------------------------------HÀM CẬP NHẬT PHIẾU KHÁM BỆNH---------------------------------------------------------------
create proc sp_CapNhatPhieuKhamBenh @maphieukham int,
						@khamlamsang nvarchar(50),
						@benhkemtheo nvarchar(50),
						@diungthuoc nvarchar(50),
						@ngaytaikham date
as
begin
		if not exists (select * from PHIEUKHAMBENH where maphieukham=@maphieukham)
	begin
		raiserror(N'Phiếu khám chưa có!!!',16,1)
		return
	end
	else
	begin
		begin transaction
		begin try
			update PHIEUKHAMBENH set @khamlamsang=@khamlamsang, benhkemtheo=@benhkemtheo,diungthuoc=@diungthuoc where maphieukham=@maphieukham
			commit
		end try
		begin catch
			DECLARE @ErrMsg VARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg='Lỗi'+ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
	end
end
------------------------------------------------LẤY DANH SÁCH DỊCH VỤ------------------------------------------------
CREATE PROCEDURE sp_DanhSachDichVu
AS
BEGIN
	select madv as N'Mã dịch vụ',
			tendv as N'Tên dịch vụ', 
			dongia as N'Đơn giá', 
			donvi as N'Đơn vị', 
			tenloaidv as N'Tên dịch vụ', 
			tenphong N'Tên phòng'
	from DICHVU Join LOAIDICHVU on DICHVU.maloaidv=LOAIDICHVU.maloaidv 
				join PHONG on DICHVU.maphong=PHONG.maphong
	
END
-------------------------------------------------LẤY DANH SÁCH PHIẾU KHÁM BỆNH--------------------------------------
create proc sp_LayDanhSachPhieuKham
as
begin
	select *
	from PHIEUKHAMBENH join BENHNHAN on PHIEUKHAMBENH.mabn=BENHNHAN.mabn
end
-------------------------------------------------THÊM CHI TIẾT DỊCH VỤ--------------------------------------
alter proc sp_ThemChiTietDichVu @maphieukham int,
									@madichvu int,
									@soluong int
as
begin
	if not exists (select * from PHIEUDICHVU where maphieudichvu=@maphieukham)
	begin
		INSERT INTO PHIEUDICHVU VALUES (@maphieukham,@maphieukham,null,null,null)
	end
	begin
		begin transaction
		begin try
			if not exists (select * from CHITIETPHIEUDICHVU where maphieudichvu=@maphieukham and madv=@madichvu)
				INSERT INTO CHITIETPHIEUDICHVU VALUES(@maphieukham,@madichvu,@soluong,N'Chưa thực hiện','')
			else
				UPDATE CHITIETPHIEUDICHVU SET soluong= @soluong where maphieudichvu=@maphieukham and madv=@madichvu
			commit
		end try
		begin catch
			DECLARE @ErrMsg VARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg='Lỗi'+ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
	end
end
-------------------------------------------------XÓA CHI TIẾT DỊCH VỤ THEO MÃ PHIẾU DỊCH VỤ--------------------------------------
create proc sp_XoaChiTietDichVu @maphieukham int
as
begin
	delete from CHITIETPHIEUDICHVU where maphieudichvu=@maphieukham
end
-------------------------------------------------XEM CHI TIẾT DỊCH VỤ THEO MÃ PHIẾU DỊCH VỤ--------------------------------------
ALter PROCEDURE sp_DanhSachChiTietDichVu @maphieudv int
AS
BEGIN
	select madv,soluong,trangthai,ketqua
	from CHITIETPHIEUDICHVU where maphieudichvu=@maphieudv
END

------------------------------------------------LẤY DANH SÁCH THUỐC------------------------------------------------
CREATE PROCEDURE sp_DanhSachThuoc
AS
BEGIN
	select mathuoc,tenthuoc,donvi,dongia
	from THUOC
END

select * from DONTHUOC

use QuanLyPhongKham
