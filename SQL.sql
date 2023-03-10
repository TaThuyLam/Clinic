USE [QuanLyPhongKham]
GO
/****** Object:  User [BuiThanhXuan]    Script Date: 12/30/2022 11:19:55 PM ******/
CREATE USER [BuiThanhXuan] FOR LOGIN [BuiThanhXuan] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [CaoNhatToan]    Script Date: 12/30/2022 11:19:55 PM ******/
CREATE USER [CaoNhatToan] FOR LOGIN [CaoNhatToan] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [DoanNgocThanhVy]    Script Date: 12/30/2022 11:19:55 PM ******/
CREATE USER [DoanNgocThanhVy] FOR LOGIN [DoanNgocThanhVy] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Hang]    Script Date: 12/30/2022 11:19:55 PM ******/
CREATE USER [Hang] FOR LOGIN [Hang] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [LuongNgocHaiDang]    Script Date: 12/30/2022 11:19:55 PM ******/
CREATE USER [LuongNgocHaiDang] FOR LOGIN [LuongNgocHaiDang] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [NguyenThiThuyHang]    Script Date: 12/30/2022 11:19:55 PM ******/
CREATE USER [NguyenThiThuyHang] FOR LOGIN [NguyenThiThuyHang] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [TranThiAnhThu]    Script Date: 12/30/2022 11:19:55 PM ******/
CREATE USER [TranThiAnhThu] FOR LOGIN [TranThiAnhThu] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [abc]    Script Date: 12/30/2022 11:19:55 PM ******/
CREATE ROLE [abc]
GO
/****** Object:  DatabaseRole [Admin]    Script Date: 12/30/2022 11:19:55 PM ******/
CREATE ROLE [Admin]
GO
/****** Object:  DatabaseRole [BacSi]    Script Date: 12/30/2022 11:19:55 PM ******/
CREATE ROLE [BacSi]
GO
/****** Object:  DatabaseRole [KeToan]    Script Date: 12/30/2022 11:19:55 PM ******/
CREATE ROLE [KeToan]
GO
/****** Object:  DatabaseRole [NhanVien]    Script Date: 12/30/2022 11:19:55 PM ******/
CREATE ROLE [NhanVien]
GO
sys.sp_addrolemember @rolename = N'KeToan', @membername = N'BuiThanhXuan'
GO
sys.sp_addrolemember @rolename = N'Admin', @membername = N'CaoNhatToan'
GO
sys.sp_addrolemember @rolename = N'BacSi', @membername = N'DoanNgocThanhVy'
GO
sys.sp_addrolemember @rolename = N'Admin', @membername = N'Hang'
GO
sys.sp_addrolemember @rolename = N'NhanVien', @membername = N'LuongNgocHaiDang'
GO
sys.sp_addrolemember @rolename = N'KeToan', @membername = N'NguyenThiThuyHang'
GO
sys.sp_addrolemember @rolename = N'NhanVien', @membername = N'TranThiAnhThu'
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IdDichvVu]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AUTO_IdDichvVu](@tenloai nvarchar(50)) 
RETURNS INT
AS
BEGIN
	declare @maloai int, @id int
	set @maloai = (select maloaidv from LoaiDichVu where tenloaidv = @tenloai)
	set @id = @maloai * 1000 + 1

	return @id
END
GO
/****** Object:  UserDefinedFunction [dbo].[XuatTrangthaiTT]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[XuatTrangthaiTT](@tt char(3))
RETURNS NVarchar
AS
BEGIN
	if(@tt='N')
		return N'Chưa thanh toán'
	else
		return N'Đã thanh toán'
	return ''
END
GO
/****** Object:  Table [dbo].[BANGTHUOC]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANGTHUOC](
	[mathuoc] [float] NULL,
	[tenthuoc] [nvarchar](255) NULL,
	[donvi] [nvarchar](255) NULL,
	[dongia] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BENHNHAN]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BENHNHAN](
	[mabn] [int] NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[dichi] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](3) NULL,
	[sodienthoai] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[mabn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETDONTHUOC]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETDONTHUOC](
	[madonthuoc] [int] NULL,
	[mathuoc] [int] NULL,
	[sang] [int] NULL,
	[trua] [int] NULL,
	[chieu] [int] NULL,
	[toi] [int] NULL,
	[soluong] [int] NULL,
	[thanhtien] [int] NULL,
	[lieudung] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETPHIEUDICHVU]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUDICHVU](
	[maphieudichvu] [int] NULL,
	[madv] [int] NULL,
	[soluong] [int] NULL,
	[trangthai] [nvarchar](50) NULL,
	[ketqua] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[madv] [int] NOT NULL,
	[tendv] [nvarchar](50) NULL,
	[dongia] [int] NULL,
	[donvi] [nvarchar](10) NULL,
	[maloaidv] [int] NULL,
	[maphong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[madv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DONTHUOC]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONTHUOC](
	[madonthuoc] [int] NOT NULL,
	[maphieukham] [int] NULL,
	[ghichu] [ntext] NULL,
	[songaythuoc] [int] NULL,
	[tongcong] [int] NULL,
	[trangthaithanhtoan] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[madonthuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIDICHVU]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIDICHVU](
	[maloaidv] [int] NOT NULL,
	[tenloaidv] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[maloaidv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[manv] [int] NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[trinhdo] [nvarchar](50) NULL,
	[chuyenmon] [nvarchar](50) NULL,
	[chucvu] [nvarchar](50) NULL,
	[taikhoan] [char](20) NULL,
	[matkhau] [char](10) NULL,
	[ngaysinh] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUDICHVU]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUDICHVU](
	[maphieudichvu] [int] NOT NULL,
	[maphieukham] [int] NULL,
	[ghichu] [nvarchar](50) NULL,
	[tongcong] [int] NULL,
	[trangthaithanhtoan] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[maphieudichvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUKHAMBENH]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUKHAMBENH](
	[maphieukham] [int] NOT NULL,
	[mabn] [int] NULL,
	[ngaykham] [date] NULL,
	[tenbs] [nvarchar](50) NULL,
	[tennv] [nvarchar](50) NULL,
	[chuandoan] [nvarchar](50) NULL,
	[benhkemtheo] [nvarchar](50) NULL,
	[diungthuoc] [nvarchar](50) NULL,
	[ngaytaikham] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[maphieukham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[maphong] [int] NOT NULL,
	[tenphong] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[maphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THUOC]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUOC](
	[mathuoc] [int] NOT NULL,
	[tenthuoc] [nvarchar](50) NULL,
	[dongia] [float] NULL,
	[donvi] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[mathuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHITIETDONTHUOC]  WITH CHECK ADD FOREIGN KEY([madonthuoc])
REFERENCES [dbo].[DONTHUOC] ([madonthuoc])
GO
ALTER TABLE [dbo].[CHITIETDONTHUOC]  WITH CHECK ADD FOREIGN KEY([mathuoc])
REFERENCES [dbo].[THUOC] ([mathuoc])
GO
ALTER TABLE [dbo].[CHITIETPHIEUDICHVU]  WITH CHECK ADD FOREIGN KEY([maphieudichvu])
REFERENCES [dbo].[PHIEUDICHVU] ([maphieudichvu])
GO
ALTER TABLE [dbo].[CHITIETPHIEUDICHVU]  WITH CHECK ADD FOREIGN KEY([madv])
REFERENCES [dbo].[DICHVU] ([madv])
GO
ALTER TABLE [dbo].[DICHVU]  WITH CHECK ADD FOREIGN KEY([maloaidv])
REFERENCES [dbo].[LOAIDICHVU] ([maloaidv])
GO
ALTER TABLE [dbo].[DICHVU]  WITH CHECK ADD FOREIGN KEY([maphong])
REFERENCES [dbo].[PHONG] ([maphong])
GO
ALTER TABLE [dbo].[DONTHUOC]  WITH CHECK ADD FOREIGN KEY([maphieukham])
REFERENCES [dbo].[PHIEUKHAMBENH] ([maphieukham])
GO
ALTER TABLE [dbo].[PHIEUDICHVU]  WITH CHECK ADD FOREIGN KEY([maphieukham])
REFERENCES [dbo].[PHIEUKHAMBENH] ([maphieukham])
GO
ALTER TABLE [dbo].[PHIEUKHAMBENH]  WITH CHECK ADD FOREIGN KEY([mabn])
REFERENCES [dbo].[BENHNHAN] ([mabn])
GO
/****** Object:  StoredProcedure [dbo].[sp_AddDichVu]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_AddDichVu] @ten nvarchar(50),
						@dongia int,
						@donvi nvarchar(10),
						@tenloai nvarchar(50),
						@tenphong nvarchar(50)
as
begin
	declare @maloai int
	set @maloai=(select maloaidv from LOAIDICHVU where tenloaidv=@tenloai)
	declare @maphong int
	set @maphong=(select maphong from PHONG where tenphong=@tenphong)
	declare @dem int
	set @dem=(@maloai*1000+1)
	if exists (select * from DICHVU where tendv=@ten)
	begin
		raiserror(N'Dịch vụ đã tồn tại!!!',16,1)
		return
	end
	else
		begin transaction
		begin try
			while( exists (select * from DICHVU with (updlock) where madv=@dem))
				set @dem=@dem+1
			insert into DICHVU
			values(@dem,@ten,@dongia,@donvi,@maloai,@maphong)
			commit
		end try
		begin catch
			DECLARE @ErrMsg VARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg='Lỗi'+ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
end
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatDichVu]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_CapNhatDichVu] @madv int,
						@ten nvarchar(50),
						@dongia int,
						@donvi nvarchar(10),
						@maloai int,
						@maphong int
as
begin
	if not exists (select * from DICHVU where madv=@madv)
	begin
		raiserror(N'Dịch vụ không tồn tại!!!',16,1)
		return
	end
	else
		begin try
			UPDATE DICHVU SET tendv=@ten,dongia=@dongia,donvi=@donvi,maloaidv=@maloai,maphong=@maphong where madv=@madv
		end try
		begin catch
			DECLARE @ErrMsg VARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg='Lỗi'+ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
end
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatPhieuKhamBenh]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_CapNhatPhieuKhamBenh] @maphieukham int,
						@chuandoan nvarchar(50),
						@benhkemtheo nvarchar(50),
						@diungthuoc nvarchar(50),
						@ngaytaikham date
as
begin
		if not exists (select * from PHIEUKHAMBENH where maphieukham=@maphieukham)
	begin
		raiserror(N'Phiếu khám không tồn tại!!!',16,1)
		return
	end
	else
	begin
		begin transaction
		begin try
			update PHIEUKHAMBENH set chuandoan=@chuandoan, benhkemtheo=@benhkemtheo,diungthuoc=@diungthuoc,ngaytaikham=@ngaytaikham where maphieukham=@maphieukham
			commit
		end try
		begin catch
			DECLARE @ErrMsg NVARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg=ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatSoNgayThuoc]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_CapNhatSoNgayThuoc] @maphieukham int,
									@soluong int
as
begin
	UPDATE DONTHUOC SET songaythuoc=@soluong where madonthuoc=@maphieukham
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ChinhSuaBenhNhan]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ChinhSuaBenhNhan] @mabn int,
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
			DECLARE @ErrMsg NVARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg=ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ChinhSuaDichVu]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_ChinhSuaDichVu] @madv int,
						@ten nvarchar(50),
						@dongia int,
						@donvi nvarchar(10),
						@tenloai nvarchar(50),
						@tenphong nvarchar(50)
as
begin
	if not exists (select * from DICHVU where madv=@madv)
	begin
		raiserror(N'Dịch vụ không không tồn tại!!!',16,1)
		return
	end
	else
	begin
		begin try
			declare @maloai int
			set @maloai=(select maloaidv from LOAIDICHVU where tenloaidv=@tenloai)
			declare @maphong int
			set @maphong=(select maphong from PHONG where tenphong=@tenphong)
			update DICHVU
			set tendv =@ten, dongia=@dongia,donvi=@donvi,maloaidv=@maloai,maphong=@maphong
			where madv=@madv
		end try
		begin catch
			DECLARE @ErrMsg VARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg='Lỗi'+ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ChinhSuaNhanVien]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ChinhSuaNhanVien] @manv int,
						@ten nvarchar(50),
						 @trinhdo nvarchar(50),
						  @chuyenmon nvarchar(50),
						   @chucvu nvarchar(50),
						    @taikhoan char(50),
							   @ngaysinh date
as
begin
	if not exists (select * from NHANVIEN where manv=@manv)
	begin
		raiserror(N'Nhân viên không không tồn tại!!!',16,1)
		return
	end
	else
	begin
		begin transaction
		begin try
			update NHANVIEN
			set hoten =@ten, trinhdo=@trinhdo,chuyenmon=@chuyenmon,chucvu=@chucvu,taikhoan=@taikhoan,ngaysinh=@ngaysinh
			where manv=@manv
			commit
		end try
		begin catch
			DECLARE @ErrMsg NVARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg=ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ChinhSuaPhieuKhamBenh]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ChinhSuaPhieuKhamBenh] @maphieukham int,
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
	if not exists (select * from PHIEUKHAMBENH where maphieukham=@maphieukham)
	begin
		raiserror(N'Phiếu khám không tồn tại!!!',16,1)
		return
	end
	else
	begin
		begin transaction
		begin try
			exec sp_ChinhSuaBenhNhan @mabn,@hoten,@ngaysinh,@diachi,@gioitinh,sodienthoai
			UPDATE PHIEUKHAMBENH
			SET tenbs=@bacsi,tennv =@nhanvien
			where maphieukham=@maphieukham
			commit
		end try
		begin catch
			DECLARE @ErrMsg NVARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg=ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ChinhSuaThuoc]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ChinhSuaThuoc] @mathuoc int,
						@ten nvarchar(50),
						@dongia int,
						@donvi nvarchar(10)
as
begin
	if not exists (select * from THUOC where mathuoc=@mathuoc)
	begin
		raiserror(N'Thuốc không không tồn tại!!!',16,1)
		return
	end
	else
	begin
		begin try
			update THUOC
			set tenthuoc =@ten, dongia=@dongia,donvi=@donvi
			where mathuoc=@mathuoc
		end try
		begin catch
			DECLARE @ErrMsg NVARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg=ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachChiTietDichVu]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DanhSachChiTietDichVu] @maphieudv int
AS
BEGIN
	select madv,soluong,trangthai,ketqua
	from CHITIETPHIEUDICHVU where maphieudichvu=@maphieudv
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachChiTietDonThuoc]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DanhSachChiTietDonThuoc] @search int
AS
BEGIN
	select ROW_NUMBER()  OVER (ORDER BY tenthuoc) AS  N'STT',
			tenthuoc as N'Tên thuốc', 
			soluong as N'Số lượng',
			dongia as N'Đơn giá',
			soluong*dongia as N'Thành tiền'
	from CHITIETDONTHUOC Join DONTHUOC on DONTHUOC.madonthuoc=CHITIETDONTHUOC.madonthuoc 
				join THUOC on THUOC.mathuoc=CHITIETDONTHUOC.mathuoc
	where  maphieukham = @search
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachChiTietPhieuDichVu]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DanhSachChiTietPhieuDichVu] @search int
AS
BEGIN
	select ROW_NUMBER()  OVER (ORDER BY tendv) AS  N'STT',
			tendv as N'Tên dịch vụ', 
			soluong as N'Số lượng',
			dongia as N'Đơn giá',
			soluong*dongia as N'Thành tiền'
	from CHITIETPHIEUDICHVU Join PHIEUDICHVU on PHIEUDICHVU.maphieudichvu=CHITIETPHIEUDICHVU.maphieudichvu 
				join DICHVU on DICHVU.madv=CHITIETPHIEUDICHVU.madv
	where  maphieukham = @search
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachDichVu]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DanhSachDichVu]
AS
BEGIN
	select madv as N'Mã dịch vụ',
			tendv as N'Tên dịch vụ', 
			dongia as N'Đơn giá', 
			donvi as N'Đơn vị', 
			tenloaidv as N'Loại dịch vụ', 
			tenphong N'Tên phòng'
	from DICHVU Join LOAIDICHVU on DICHVU.maloaidv=LOAIDICHVU.maloaidv 
				join PHONG on DICHVU.maphong=PHONG.maphong
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachDonThuoc]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_DanhSachDonThuoc]
AS
BEGIN
	select madonthuoc as N'Mã phiếu khám',
			hoten as N'Tên bệnh nhân', 
			ngaysinh as N'Ngày sinh',
			tongcong as N'Tổng tiền', 
			trangthaithanhtoan as N'Trạng thái thanh toán'
	from PHIEUKHAMBENH Join DONTHUOC on DONTHUOC.maphieukham=PHIEUKHAMBENH.maphieukham 
				join BENHNHAN on BENHNHAN.mabn=PHIEUKHAMBENH.mabn
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachDonThuocChuaTT]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_DanhSachDonThuocChuaTT]
AS
BEGIN
	select madonthuoc as N'Mã phiếu khám',
			hoten as N'Tên bệnh nhân', 
			ngaysinh as N'Ngày sinh',
			tongcong as N'Tổng tiền'
	from PHIEUKHAMBENH Join DONTHUOC on DONTHUOC.maphieukham=PHIEUKHAMBENH.maphieukham 
				join BENHNHAN on BENHNHAN.mabn=PHIEUKHAMBENH.mabn
	where trangthaithanhtoan='N'
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachHoSoBenhNhan]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_DanhSachHoSoBenhNhan]
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
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachNhanVien]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_DanhSachNhanVien]
AS
BEGIN
	select manv as N'Mã nhân viên',hoten as N'Họ tên',chucvu as N'Chức vụ',chuyenmon as N'Chuyên môn',trinhdo as N'Trình độ',taikhoan as N'Tài khoản',ngaysinh as N'Ngày sinh'
	from NHANVIEN
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachPhieuDichVu]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DanhSachPhieuDichVu]
AS
BEGIN
	select maphieudichvu as N'Mã phiếu khám',
			hoten as N'Tên bệnh nhân', 
			ngaysinh as N'Ngày sinh',
			tongcong as N'Tổng tiền', 
			trangthaithanhtoan as N'Trạng thái thanh toán'
	from PHIEUKHAMBENH Join PHIEUDICHVU on PHIEUDICHVU.maphieukham=PHIEUKHAMBENH.maphieukham 
				join BENHNHAN on BENHNHAN.mabn=PHIEUKHAMBENH.mabn
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachPhieuDichVuChuaTT]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DanhSachPhieuDichVuChuaTT]
AS
BEGIN
	select maphieudichvu as N'Mã phiếu khám',
			hoten as N'Tên bệnh nhân', 
			ngaysinh as N'Ngày sinh',
			tongcong as N'Tổng tiền'
	from PHIEUKHAMBENH Join PHIEUDICHVU on PHIEUDICHVU.maphieukham=PHIEUKHAMBENH.maphieukham 
				join BENHNHAN on BENHNHAN.mabn=PHIEUKHAMBENH.mabn
	where trangthaithanhtoan='N'
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachPhieuKham]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_DanhSachPhieuKham]
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
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachPhieuKhamTheoNgay]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_DanhSachPhieuKhamTheoNgay] @datefrom date,
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
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhSachThuoc]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DanhSachThuoc]
AS
BEGIN
	select mathuoc as N'Mã thuốc',tenthuoc as N'Tên thuốc',donvi as N'Đơn vị',dongia as N'Đơn giá'
	from THUOC
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraDangNhap]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_KiemTraDangNhap] @username char(50),
								@pass char(20)
AS
BEGIN
	if(not exists( Select * From NHANVIEN where taikhoan=@username))
		raiserror(N'Người dùng không tồn tại!!!',16,1)
	else if(( Select matkhau From NHANVIEN where taikhoan=@username)!=@pass)
		raiserror(N'Sai mật khẩu!!!',16,1)
		else
			Select * From NHANVIEN where taikhoan=@username and matkhau=@pass

END
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachPhieuKham]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayDanhSachPhieuKham]
as
begin
	select *
	from PHIEUKHAMBENH join BENHNHAN on PHIEUKHAMBENH.mabn=BENHNHAN.mabn
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachPhieuKhamChuaKham]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_LayDanhSachPhieuKhamChuaKham]
as
begin
	select maphieukham as N'Mã phiếu',hoten as N'Bệnh nhân', YEAR(ngaysinh) as N'Năm sinh', gioitinh as N'Giới tính', tenbs as N'Bác sĩ'
	from PHIEUKHAMBENH join BENHNHAN on PHIEUKHAMBENH.mabn=BENHNHAN.mabn
	where chuandoan='' and benhkemtheo ='' and diungthuoc='' 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachPKTheoNgayK]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_LayDanhSachPKTheoNgayK] @ngay date
as
begin
	select maphieukham as N'Mã phiếu',hoten as N'Bệnh nhân', YEAR(ngaysinh) as N'Năm sinh', gioitinh as N'Giới tính', tenbs as N'Bác sĩ'
	from PHIEUKHAMBENH join BENHNHAN on PHIEUKHAMBENH.mabn=BENHNHAN.mabn
	where ngaykham=@ngay
	
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachPKTheoTenBN]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_LayDanhSachPKTheoTenBN] @ten nvarchar(50)
as
begin
	select maphieukham as N'Mã phiếu',hoten as N'Bệnh nhân', YEAR(ngaysinh) as N'Năm sinh', gioitinh as N'Giới tính', tenbs as N'Bác sĩ'
	from PHIEUKHAMBENH join BENHNHAN on PHIEUKHAMBENH.mabn=BENHNHAN.mabn
	where hoten like N'%'+@ten+'%'
	
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachTatCa]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_LayDanhSachTatCa]
as
begin
	select maphieukham as N'Mã phiếu',hoten as N'Bệnh nhân', YEAR(ngaysinh) as N'Năm sinh', gioitinh as N'Giới tính', tenbs as N'Bác sĩ'
	from PHIEUKHAMBENH join BENHNHAN on PHIEUKHAMBENH.mabn=BENHNHAN.mabn
	
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachTenBacSi]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayDanhSachTenBacSi]
as
begin
	select hoten +' - BS.'+chuyenmon 
	from NHANVIEN 
	where chucvu=N'Bác Sĩ'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachTenNhanVien]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayDanhSachTenNhanVien]
as
begin
	select hoten +' - '+chucvu 
	from NHANVIEN 
	where chucvu=N'Nhân viên tiếp nhận'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_TaoPhieuDichVu]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_TaoPhieuDichVu] @maphieukham int,
						@ghichu nvarchar(50),
						@tongcong int,
						@trangthai char(3)
as
begin transaction
	if exists (select * from PHIEUDICHVU where maphieukham=@maphieukham)
	begin
		UPDATE PHIEUDICHVU SET ghichu=@ghichu,tongcong=@tongcong,trangthaithanhtoan=@trangthai
	end
	else
		begin try
			INSERT INTO PHIEUDICHVU VALUES(@maphieukham,@maphieukham,@ghichu,@tongcong,@trangthai)
		end try
		begin catch
			DECLARE @ErrMsg VARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg='Lỗi'+ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
commit
GO
/****** Object:  StoredProcedure [dbo].[sp_TaoPhieuKhamBenh]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_TaoPhieuKhamBenh] @hoten nvarchar(50),
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
	else
		begin try
			set @mabn= (select mabn from BENHNHAN where hoten=@hoten and ngaysinh=@ngaysinh and gioitinh=@gioitinh and sodienthoai=@sodienthoai)
			while( exists (select * from PHIEUKHAMBENH with (updlock) where maphieukham=@mapkb))
				set @mapkb=@mapkb+1
			insert into PHIEUKHAMBENH
			values(@mapkb,@mabn,GETDATE(),@bacsi,@nhanvien,'','','','')
			
		end try
		begin catch
			DECLARE @ErrMsg NVARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg=ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
commit
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemBenhNhan]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ThemBenhNhan] @hoten nvarchar(50),
						@ngaysinh date,
						@diachi nvarchar(50),
						@gioitinh nvarchar(3),
						@sodienthoai char(10)
as
begin
	declare @dem int
	set @dem=1
		begin transaction
		begin try
			while( exists (select * from BENHNHAN with (updlock) where mabn=@dem))
				set @dem=@dem+1
			insert into BENHNHAN(mabn, hoten, ngaysinh, dichi,gioitinh,sodienthoai)
			values(@dem,@hoten,@ngaysinh,@diachi,@gioitinh,@sodienthoai)
			commit
		end try
		begin catch
			DECLARE @ErrMsg NVARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg=ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemChiTietDichVu]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ThemChiTietDichVu] @maphieukham int,
									@madichvu int,
									@soluong int
as
begin
	if not exists (select * from PHIEUDICHVU where maphieudichvu=@maphieukham)
	begin
		INSERT INTO PHIEUDICHVU VALUES (@maphieukham,@maphieukham,'',0,'N')
	end
	begin
		begin transaction
		begin try
			if not exists (select * from CHITIETPHIEUDICHVU where maphieudichvu=@maphieukham and madv=@madichvu)
				INSERT INTO CHITIETPHIEUDICHVU VALUES(@maphieukham,@madichvu,@soluong,N'Chưa thực hiện','')
			else
				UPDATE CHITIETPHIEUDICHVU SET soluong= @soluong where maphieudichvu=@maphieukham and madv=@madichvu
			declare @tongtien int
			set @tongtien=(select SUM(soluong*dongia) from CHITIETPHIEUDICHVU join DICHVU on CHITIETPHIEUDICHVU.madv=DICHVU.madv where CHITIETPHIEUDICHVU.maphieudichvu=@maphieukham)
			UPDATE PHIEUDICHVU SET tongcong=@tongtien where maphieukham=@maphieukham
			commit
		end try
		begin catch
			DECLARE @ErrMsg NVARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg=ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemChiTietDonThuoc]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ThemChiTietDonThuoc] @madonthuoc int,
									@mathuoc int,
									@sang int,
									@trua int,
									@chieu int,
									@toi int,
									@soluong int,
									@lieudung nvarchar(50)
as
begin
	if not exists (select * from DONTHUOC where madonthuoc=@madonthuoc)
	begin
		INSERT INTO DONTHUOC VALUES (@madonthuoc,@madonthuoc,'',0,0,'N')
	end
	begin
		begin transaction
		begin try
			if not exists (select * from CHITIETDONTHUOC 
			where madonthuoc=@madonthuoc and mathuoc=@mathuoc)
			begin
				INSERT INTO CHITIETDONTHUOC VALUES(@madonthuoc,@mathuoc,@sang,@trua,@chieu,@toi,@soluong,0,@lieudung)
			end
				UPDATE CHITIETDONTHUOC SET soluong= @soluong, sang=@sang,trua=@trua,chieu=@chieu,toi=@toi,lieudung=@lieudung where madonthuoc=@madonthuoc and mathuoc=@mathuoc
				
		DECLARE @thanhtien int
		SET @thanhtien=(Select dongia*soluong from CHITIETDONTHUOC C,THUOC T where C.mathuoc=T.mathuoc and madonthuoc=@madonthuoc and c.mathuoc=@mathuoc)
		UPDATE CHITIETDONTHUOC SET thanhtien = @thanhtien where madonthuoc= @madonthuoc and mathuoc=@mathuoc
		DECLARE @tongcong int, @tongthantien int, @songaythuoc int
		SET @tongthantien = (Select Sum(thanhtien) from CHITIETDONTHUOC where madonthuoc=@madonthuoc)
		SET @songaythuoc = (Select songaythuoc from DONTHUOC where madonthuoc=@madonthuoc)
		SET @tongcong = @tongthantien * @songaythuoc
		UPDATE DONTHUOC SET tongcong = @tongcong where madonthuoc=@madonthuoc
			commit
		end try
		begin catch
			DECLARE @ErrMsg NVARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg=ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemChiTietThuoc]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_ThemChiTietThuoc] @maphieukham int,
									@mathuoc int,
									@sang int,
									@trua int,
									@chieu int,
									@toi int,
									@soluong int,
									@lieudung nvarchar(50)
as
begin
	if not exists (select * from DONTHUOC where madonthuoc=@maphieukham)
	begin
		INSERT INTO DONTHUOC VALUES (@maphieukham,@maphieukham,'',0,0,'N')
	end
	begin
		begin transaction
		begin try
			DECLARE @thanhtien FLOAT
			SET @thanhtien=(SELECT dongia FROM THUOC where mathuoc=@mathuoc)*@soluong*1.0
			if not exists (select * from CHITIETDONTHUOC where madonthuoc=@maphieukham and mathuoc=@mathuoc)
			begin
				INSERT INTO CHITIETDONTHUOC VALUES(@maphieukham,@mathuoc,@sang,@trua,@chieu,@toi,@soluong,@thanhtien,@lieudung)
			end
			else
				UPDATE CHITIETDONTHUOC SET soluong= @soluong, sang=@sang,trua=@trua,chieu=@chieu,toi=@toi,lieudung=@lieudung,thanhtien=@thanhtien where madonthuoc=@maphieukham and mathuoc=@mathuoc
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
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNhanVien]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ThemNhanVien] @ten nvarchar(50),
						 @trinhdo nvarchar(50),
						  @chuyenmon nvarchar(50),
						   @chucvu nvarchar(50),
						    @taikhoan char(50),
							   @ngaysinh date
as
begin
	declare @dem int
	set @dem=1
		begin transaction
		begin try
			while( exists (select * from NHANVIEN with (updlock) where manv=@dem))
				set @dem=@dem+1
			declare @matkhau char(10)
			set @matkhau=(select RTRIM(CONVERT(char(2),DAY(@ngaysinh)))+RTRIM(CONVERT(char(2),month(@ngaysinh)))+CONVERT(char(4),year(@ngaysinh)))
			insert into NHANVIEN
			values(@dem,@ten,@trinhdo,@chuyenmon,@chucvu,@taikhoan,@matkhau,@ngaysinh)
			commit
		end try
		begin catch
			DECLARE @ErrMsg NVARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg=ERROR_MESSAGE()
			RAISERROR (@ErrMsg,16,1)
		end catch
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemThuoc]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ThemThuoc] @ten nvarchar(50),
						@dongia int,
						@donvi nvarchar(10)
as
begin
	declare @dem int
	set @dem=1
	if exists (select * from THUOC where tenthuoc=@ten and donvi=@donvi)
	begin
		raiserror(N'Thuốc đã tồn tại!!!',16,1)
		return
	end
	else
		begin transaction
		begin try
			while( exists (select * from THUOC with (updlock) where mathuoc=@dem))
				set @dem=@dem+1
			insert into THUOC
			values(@dem,@ten,@dongia,@donvi)
			commit
		end try
		begin catch
			DECLARE @ErrMsg NVARCHAR(max)
			ROLLBACK
			SELECT @ErrMsg=ERROR_MESSAGE();
			RAISERROR (@ErrMsg,16,1)
		end catch
end
GO
/****** Object:  StoredProcedure [dbo].[sp_TimBenhNhan]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_TimBenhNhan] @hoten nvarchar(50)
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
GO
/****** Object:  StoredProcedure [dbo].[sp_TimDonThuocChuaTT]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimDonThuocChuaTT] @search int
AS
BEGIN
	select madonthuoc as N'Mã phiếu khám',
			hoten as N'Tên bệnh nhân', 
			ngaysinh as N'Ngày sinh',
			tongcong as N'Tổng tiền'
	from PHIEUKHAMBENH Join DONTHUOC on DONTHUOC.maphieukham=PHIEUKHAMBENH.maphieukham 
				join BENHNHAN on BENHNHAN.mabn=PHIEUKHAMBENH.mabn
	where trangthaithanhtoan='N' and madonthuoc = @search
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemDichVu]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimKiemDichVu] @ten nvarchar(50)
AS
BEGIN
	select madv as N'Mã dịch vụ',
			tendv as N'Tên dịch vụ', 
			dongia as N'Đơn giá', 
			donvi as N'Đơn vị', 
			tenloaidv as N'Tên loại dịch vụ', 
			tenphong N'Tên phòng'
	from DICHVU Join LOAIDICHVU on DICHVU.maloaidv=LOAIDICHVU.maloaidv 
				join PHONG on DICHVU.maphong=PHONG.maphong
	where tendv Like '%'+@ten+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemNhanVien]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimKiemNhanVien] @ten nvarchar(50)
AS
BEGIN
	select manv as N'Mã nhân viên',hoten as N'Họ tên',chucvu as N'Chức vụ',chuyenmon as N'Chuyên môn',trinhdo as N'Trình độ',taikhoan as N'Tài khoản',ngaysinh as N'Ngày sinh'
	from NHANVIEN
	where hoten Like '%'+@ten+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimKiemThuoc]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimKiemThuoc] @ten nvarchar(50)
AS
BEGIN
	select mathuoc as N'Mã thuốc',tenthuoc as N'Tên thuốc',donvi as N'Đơn vị',dongia as N'Đơn giá'
	from THUOC
	where tenthuoc Like '%'+@ten+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimPhieuDichVuChuaTT]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimPhieuDichVuChuaTT] @search int
AS
BEGIN
	select maphieudichvu as N'Mã phiếu khám',
			hoten as N'Tên bệnh nhân', 
			ngaysinh as N'Ngày sinh',
			tongcong as N'Tổng tiền'
	from PHIEUKHAMBENH Join PHIEUDICHVU on PHIEUDICHVU.maphieukham=PHIEUKHAMBENH.maphieukham 
				join BENHNHAN on BENHNHAN.mabn=PHIEUKHAMBENH.mabn
	where trangthaithanhtoan='N' and  maphieudichvu = @search

	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimPhieuKham]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_TimPhieuKham] @hoten nvarchar(50)
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
	where hoten Like '%'+@hoten+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_TimPhieuKhamTheoMaPK]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_TimPhieuKhamTheoMaPK] @maphieukham int
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
	where maphieukham = @maphieukham
end
GO
/****** Object:  StoredProcedure [dbo].[sp_XacNhanDonThuocTT]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XacNhanDonThuocTT] @mapdt int
	AS
	BEGIN
				UPDATE DONTHUOC
				set trangthaithanhtoan='Y' where madonthuoc=@mapdt
				RAISERROR (N'Đã lưu thanh toán',16,1)
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_XacNhanPhieuDVTT]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XacNhanPhieuDVTT] @mapdv int
AS
BEGIN
			UPDATE PHIEUDICHVU
			set trangthaithanhtoan='Y' where maphieudichvu=@mapdv
			RAISERROR (N'Đã lưu thanh toán',16,1)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaBenhNhan]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_XoaBenhNhan] @mabn int
as
begin
	begin try
			Delete from BENHNHAN where mabn=@mabn
	end try
		begin catch
			RAISERROR (N'Không thể xóa bệnh nhân này!!!',16,1)
		end catch
end
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaChiTietDichVu]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaChiTietDichVu] @maphieukham int
as
begin
	delete from CHITIETPHIEUDICHVU where maphieudichvu=@maphieukham
end
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaChiTietDonThuoc]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaChiTietDonThuoc] @maphieukham int
as
begin
	delete from CHITIETDONTHUOC where madonthuoc=@maphieukham
end
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaDichVu]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_XoaDichVu] @madv int
as
begin
	begin try
			delete from DICHVU where madv=@madv		end try
		begin catch
			RAISERROR (N'Không thể xóa dịch vụ này!!!',16,1)
		end catch
end
	
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaNhanVien]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_XoaNhanVien] @manv int
as
begin
	begin try
			delete from NHANVIEN where manv=@manv
		end try
		begin catch
			RAISERROR (N'Không thể xóa nhân viên này!!!',16,1)
		end catch
end
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaPhieuKhamBenh]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_XoaPhieuKhamBenh] @mapk int
as
	begin try
		Delete from PHIEUKHAMBENH where maphieukham=@mapk
		end try
		begin catch
			Raiserror('Không thể xóa',16,1)
		end catch
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaThuoc]    Script Date: 12/30/2022 11:19:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_XoaThuoc] @mathuoc int
as
begin
	begin try
			delete from THUOC where mathuoc=@mathuoc
		end try
		begin catch
			RAISERROR (N'Không thể xóa thuốc này!!!',16,1)
		end catch
end
GO
