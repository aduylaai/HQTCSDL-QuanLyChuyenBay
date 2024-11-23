CREATE DATABASE QuanLyBanVeMayBay
USE QuanLyBanVeMayBay

-------------------
USE master;
GO
ALTER DATABASE QuanLyBanVeMayBay SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO

DROP DATABASE QuanLyBanVeMayBay
-------------------
----bang tai khoan
CREATE TABLE TaiKhoan (
    MaTaiKhoan INT IDENTITY(1,1) PRIMARY KEY,
    TenTaiKhoan NVARCHAR(50) UNIQUE, -- Đảm bảo tên tài khoản là duy nhất
    MatKhau NVARCHAR(100)
)

CREATE TABLE KhachHang (
    MaKhachHang INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100),
    DiaChi NVARCHAR(255),
    Email NVARCHAR(100),
    NgaySinh DATE CHECK (NgaySinh <= GETDATE()), -- Kiểm tra ngày sinh nhỏ hơn hoặc bằng ngày hiện tại
    SoDienThoai NVARCHAR(20) UNIQUE, -- Đảm bảo số điện thoại là duy nhất
    MaTaiKhoan INT,
    CONSTRAINT FK_KHACHHANG_TAIKHOAN FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan)
)

CREATE TABLE HanhKhach (
    MaHanhKhach INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100),
    DiaChi NVARCHAR(255),
    GioiTinh NVARCHAR(10),
    QuocTich NVARCHAR(50),
    NgaySinh DATE CHECK (NgaySinh <= GETDATE()), -- Kiểm tra ngày sinh nhỏ hơn hoặc bằng ngày hiện tại
    SoDienThoai NVARCHAR(20) UNIQUE, -- Đảm bảo số điện thoại là duy nhất
    Email NVARCHAR(100),
    CCCD_Passport NVARCHAR(20) UNIQUE, -- Đảm bảo CCCD/Passport là duy nhất
	MaKhachHang INT,
	CONSTRAINT FK_HANHKHACH_KHACHHANG foreign key (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);

CREATE TABLE SanBay (
    MaSanBay INT IDENTITY(1,1) PRIMARY KEY,
    TenSanBay NVARCHAR(100) UNIQUE, -- Đảm bảo tên sân bay là duy nhất
    TenThanhPho NVARCHAR(100),
    VietTatSanBay NVARCHAR(10) UNIQUE -- Đảm bảo viết tắt sân bay là duy nhất
);

CREATE TABLE LoTrinh (
    MaLoTrinh INT IDENTITY(1,1) PRIMARY KEY,
	TenLoTrinh NVARCHAR(100),
    MaSB_Di INT,
    MaSB_Den INT,
	CONSTRAINT FK_MASBDI_SB FOREIGN KEY (MaSB_Di) REFERENCES SANBAY(MaSanBay),
	CONSTRAINT FK_MASBDEN_SB FOREIGN KEY (MaSB_Den) REFERENCES SANBAY(MaSanBay),
);

CREATE TABLE HangHangKhong (
    MaHangHangKhong INT IDENTITY(1,1) PRIMARY KEY,
    TenHangHangKhong NVARCHAR(100) NOT NULL -- Tên hãng hàng không không được null
);


CREATE TABLE TrangThaiChuyenBay (
    MaTrangThaiChuyenBay INT IDENTITY(1,1) PRIMARY KEY,
    TenTrangThaiChuyenBay NVARCHAR(40) 
);
CREATE TABLE MayBay (
    MaMayBay INT IDENTITY(1,1) PRIMARY KEY,
    TenMayBay NVARCHAR(100) NOT NULL,
    SucChuaToiDa INT CHECK (SucChuaToiDa > 0) -- Sức chứa phải lớn hơn 0
);

CREATE TABLE ChuyenBay (
    MaChuyenBay INT IDENTITY(1,1) PRIMARY KEY,
    MaHangHangKhong INT,
    MaTrangThaiChuyenBay INT,
    MaLoTrinh INT,
	MaMayBay INT,
	GiaBay MONEY,
	NgayGioDi DATETIME NOT NULL,
    NgayGioDen DATETIME NOT NULL,
    CONSTRAINT FK_CHUYENBAY_SANBAY FOREIGN KEY (MaLoTrinh) REFERENCES LoTrinh(MaLoTrinh),
    CONSTRAINT FK_CHUYENBAY_HHK FOREIGN KEY (MaHangHangKhong) REFERENCES HangHangKhong(MaHangHangKhong),
    CONSTRAINT FK_CHUYENBAY_TRANGTHAI FOREIGN KEY (MaTrangThaiChuyenBay) REFERENCES TrangThaiChuyenBay(MaTrangThaiChuyenBay),
    CONSTRAINT FK_CHUYENBAY_MAYBAY FOREIGN KEY (MaMayBay) REFERENCES MayBay(MaMayBay)

);

CREATE TABLE HangGhe (
    MaHangGhe INT IDENTITY(1,1) PRIMARY KEY,
    TenHangGhe NVARCHAR(50),
);


CREATE TABLE MayBay_HangGhe (
	MaMBHG INT IDENTITY(1,1) PRIMARY KEY, 
    MaMayBay INT,
    MaHangGhe INT,
    SoGhe INT CHECK (SoGhe > 0), -- Số ghế phải lớn hơn 0
    CONSTRAINT FK_MayBay_HangGhe_MayBay FOREIGN KEY (MaMayBay) REFERENCES MayBay(MaMayBay),
    CONSTRAINT FK_MayBay_HangGhe_HangGhe FOREIGN KEY (MaHangGhe) REFERENCES HangGhe(MaHangGhe)
);

CREATE TABLE GiaHangGhe (
    MaHangGhe INT,
	MaHHK INT,
    Gia DECIMAL(18, 2) CHECK (Gia > 0), -- Giá phải lớn hơn 0
	CONSTRAINT PK_GiaHangGhe Primary Key (MaHangGhe, MaHHK),
    CONSTRAINT FK_HANGGHE_GIA FOREIGN KEY (MaHangGhe) REFERENCES HangGhe(MaHangGhe),
	CONSTRAINT FK_HANGGHE_HHK FOREIGN KEY (MaHHK) REFERENCES HangHangKhong(MaHangHangKhong)
);


CREATE TABLE TrangThaiVe (
   MaTTV INT IDENTITY(1,1),
   TenTTV nvarchar(20),
   CONSTRAINT PK_TTV PRIMARY KEY (MATTV)
);

CREATE TABLE Ve (

    MaVe INT IDENTITY(1,1) PRIMARY KEY,
	MaHanhKhach INT NOT NULL,
	MaTTV INT NOT NULL,
	CONSTRAINT FK_VEMAYBAY_TRANGTHAIVE FOREIGN KEY (MaTTV) REFERENCES TrangThaiVe(MaTTV),
	CONSTRAINT FK_VEMAYBAY_HANHKHACH FOREIGN KEY (MaHanhKhach) REFERENCES HanhKhach(MaHanhKhach)
);

CREATE TABLE ChiTietVe (
    MaVe INT PRIMARY KEY,
    MaChuyenBay INT NOT NULL,
	MaHangGhe int,
    CONSTRAINT FK_CTV_VE FOREIGN KEY (MaVe) REFERENCES Ve(MaVe),
	CONSTRAINT FK_CTV_CHUYENBAY FOREIGN KEY (MaChuyenBay) REFERENCES ChuyenBay(MaChuyenBay),
	CONSTRAINT FK_CTV_HANGGHE FOREIGN KEY (MaHangGhe) REFERENCES HangGhe(MaHangGhe)
);

CREATE TABLE PhieuDat (
    MaPhieuDat INT IDENTITY(1,1) PRIMARY KEY,
    MaKhachHang INT not null,
    NgayDat DATE,
    SoLuongHanhKhach INT CHECK (SoLuongHanhKhach > 0), -- Số lượng hành khách phải lớn hơn 0
    CONSTRAINT FK_PHIEUDAT_KHACHHANG FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);

CREATE TABLE ChiTietPhieuDat (
    MaPhieuDat INT,
    MaVe INT,
    CONSTRAINT PK_CHITIETDATVE PRIMARY KEY (MaPhieuDat, MaVe),
    CONSTRAINT FK_CHITIETDATVE_PHIEUDATVE FOREIGN KEY (MaPhieuDat) REFERENCES PhieuDat(MaPhieuDat),
    CONSTRAINT FK_CHITIETDATVE_VEMAYBAY FOREIGN KEY (MaVe) REFERENCES Ve(MaVe),
);

CREATE TABLE HoaDon (
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    MaPhieuDat INT,
    TongTien DECIMAL(18, 2) CHECK (TongTien >= 0), -- Tổng tiền không được nhỏ hơn 0
    CONSTRAINT FK_HOADON_PHIEUDATVE FOREIGN KEY (MaPhieuDat) REFERENCES PhieuDat(MaPhieuDat)
);

CREATE TABLE GiamGia (
    MaGiamGia INT IDENTITY(1,1) PRIMARY KEY,
    Code NVARCHAR(20),
    MucGiamGia DECIMAL(18, 2) CHECK (MucGiamGia > 0) -- Mức giảm giá phải lớn hơn 0
);

CREATE TABLE GiamGiaHoaDon (
	MaGiamGiaHoaDon int IDENTITY(1,1),
    MaHoaDon INT,
    MaGiamGia INT,
    CONSTRAINT PK_HD_GG PRIMARY KEY (MaGiamGiaHoaDon),
    CONSTRAINT FK_HD_GG_HOADON FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    CONSTRAINT FK_HD_GG_GIAMGIA FOREIGN KEY (MaGiamGia) REFERENCES GiamGia(MaGiamGia)
);

CREATE TABLE TienIch (
    MaTienIch INT IDENTITY(1,1) PRIMARY KEY,
    TenTienIch NVARCHAR(100),
    GiaTienIch DECIMAL(18, 2) CHECK (GiaTienIch > 0) -- Giá tiền phải lớn hơn 0
);

CREATE TABLE DatTienIch (
    MaDatTienIch INT IDENTITY(1,1) PRIMARY KEY,
    MaPhieuDat INT,
    MaTienIch INT,
    CONSTRAINT FK_PD_TI_TIENICH FOREIGN KEY (MaTienIch) REFERENCES TienIch(MaTienIch),
    CONSTRAINT FK_PD_TI_PhieuDat FOREIGN KEY (MaPhieuDat) REFERENCES PhieuDat(MaPhieuDat)
);

-- Bảng TaiKhoan
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau) VALUES 
(N'Admin', N'Admin@123'), 
(N'minh123', N'0123456789'), 
(N'khoa345', N'963852741'),
(N'duy678', N'147258369'),
(N'luan901', N'987654321'),
(N'dang666', N'123456789')

-- Bảng KhachHang
INSERT INTO KhachHang (HoTen, DiaChi, Email, NgaySinh, SoDienThoai, MaTaiKhoan) VALUES 
(N'Nguyễn Minh Luân', N'Hà Nội', N'nguyenminhluan@gmail.com', '2004-01-01', N'0123456789', 1),
(N'Trần Thị Oanh', N'TP Hồ Chí Minh', N'tranthioanh@gmail.com', '2004-05-15', N'0987654321', 2),
(N'Lê Văn Thịnh', N'Đà Nẵng', N'levanthinh@gmail.com', '2002-09-20', N'0123456780', 3), 
(N'Phạm Thị Dung', N'Huế', N'phamthidung@gmail.com', '2005-12-25', N'0987654320', 4),
(N'Nguyễn Văn Duy', N'Cần Thơ', N'nguyenvanduy@gmail.com', '2001-03-30', N'0123456791', 5)

-- Bảng SanBay
INSERT INTO SanBay (TenSanBay, TenThanhPho, VietTatSanBay) VALUES 
(N'Noi Bai International Airport', N'Hà Nội', N'HAN'),
(N'Tan Son Nhat International Airport', N'Hồ Chí Minh', N'SGN'),
(N'Da Nang International Airport', N'Đà Nẵng', N'DAD'), 
(N'Cam Ranh International Airport', N'Nha Trang', N'CXR'),
(N'Phu Quoc International Airport', N'Phú Quốc', N'PQC')

-- Bảng HangHangKhong
INSERT INTO HangHangKhong (TenHangHangKhong) VALUES 
(N'Vietnam Airlines'),
(N'Vietjet Air'),
(N'Bamboo Airways'),
(N'Pacific Airlines'),
(N'VASCO')

-- Bảng HanhKhach
INSERT INTO HanhKhach (HoTen, DiaChi, GioiTinh, QuocTich, NgaySinh, SoDienThoai, Email, CCCD_Passport, MaKhachHang) VALUES 
(N'Nguyễn Thị Xuân', N'Hà Nội', N'Nữ', N'Việt Nam', '1993-02-14', N'0126456790', N'nguyenthixuan@gmail.com', N'123456789',1),
(N'Trần Văn Yên', N'TP Hồ Chí Minh', N'Nam', N'Việt Nam', '1989-10-01', N'0987654322', N'tranvanyen@gmail.com', N'234567890',2),
(N'Lê Văn Thọ', N'Đà Nẵng', N'Nam', N'Việt Nam', '1990-07-07', N'0123456788', N'levantho@gmail.com', N'345678901',3),
(N'Nguyễn Văn Mạnh', N'Huế', N'Nam', N'Việt Nam', '1986-12-12', N'0987654319', N'nguyenvanmanh@gmail.com', N'456789012',3),
(N'Phạm Thị Quỳnh Như', N'Cần Thơ', N'Nữ', N'Việt Nam', '1995-04-05', N'0123456792', N'phamthiquynhnhu@gmail.com', N'567890123',4),
(N'Lê Thị Hồng', N'Hải Phòng', N'Nữ', N'Việt Nam', '1992-03-18', N'0123654789', N'lethihong@gmail.com', N'678901234',5),
(N'Phạm Văn Tuấn', N'Quảng Nam', N'Nam', N'Việt Nam', '1985-11-25', N'0987543211', N'phamvantuan@gmail.com', N'789012345',5),
(N'Bùi Thị Thu Hà', N'Bình Dương', N'Nữ', N'Việt Nam', '1994-09-09', N'0123789456', N'buithithuha@gmail.com', N'890123456',1),
(N'Trần Quang Huy', N'Nha Trang', N'Nam', N'Việt Nam', '1987-06-30', N'0978543210', N'tranquanghuy@gmail.com', N'901234567',2);

--Bảng TrangThaiChuyenBay
INSERT INTO TrangThaiChuyenBay (TenTrangThaiChuyenBay) VALUES
(N'Có sẵn'),
(N'Không có sẵn')

---Bảng máy bay
INSERT INTO MayBay (TenMayBay, SucChuaToiDa)
VALUES 
    (N'Boeing 737',200 ),
    (N'Airbus A320',180),
    (N'Boeing 747',190),
    (N'Airbus A380',170),
    (N'Cessna 172',250);

--Bảng TrangThaiVe
INSERT INTO TrangThaiVe (TenTTV) VALUES
(N'Có sẵn'),
(N'Đã đặt'),
(N'Đã sử dụng')

--Bảng LoTrinh
INSERT INTO LoTrinh (TenLoTrinh, MaSB_Di, MaSB_Den) VALUES 
	(N'Hà Nội - TP Hồ Chí Minh',1, 2), -- Từ Hà Nội đến TP Hồ Chí Minh
	(N'TP Hồ Chí Minh - Đà Nẵng', 2, 3), -- Từ TP Hồ Chí Minh đến Đà Nẵng
	(N'Hà Nội - Đà Nẵng', 1, 3), -- Từ Hà Nội đến Đà Nẵng
	(N'Đà Nẵng - Nha Trang', 3, 4), -- Từ Đà Nẵng đến Nha Trang
	(N'Nha Trang - Phú Quốc', 4, 5) -- Từ Nha Trang đến Phú Quốc


--Bảng ChuyenBay
INSERT INTO ChuyenBay (MaHangHangKhong, MaTrangThaiChuyenBay, MaLoTrinh,MaMayBay,GiaBay,NgayGioDi,NgayGioDen) VALUES 
(1, 1, 1,1,1500000,'2024-11-25 08:00:00','2024-11-25 10:30:00'), -- Vietnam Airlines, Có sẵn, Hà Nội - TP Hồ Chí Minh
(2, 2, 2,2,1200000,'2024-11-25 09:00:00','2024-11-25 10:45:00'), -- VietJet Air, Không có sẵn, TP Hồ Chí Minh - Đà Nẵng
(1, 1, 3,2,1300000,'2024-11-25 15:00:00','2024-11-25 16:30:00'), -- Vietnam Airlines, Có sẵn, Hà Nội - Đà Nẵng
(3, 1, 4,4,1100000,'2024-11-25 08:00:00','2024-11-25 08:45:00'), -- Bamboo Airways, Có sẵn, Đà Nẵng - Nha Trang
(2, 1, 5,5,2000000,'2024-11-25 08:00:00','2024-11-25 09:30:00') -- VietJet Air, Có sẵn, Nha Trang - Phú Quốc

--Bảng HangGhe
INSERT INTO HangGhe (TenHangGhe) VALUES
(N'Phổ thông'),
(N'Thương gia'),
(N'Hạng nhất'),
(N'Tiết kiệm')

INSERT INTO MayBay_HangGhe (MaMayBay, MaHangGhe, SoGhe)
VALUES 
    (1, 1, 20),  -- Máy bay 1 có 20 ghế Hạng Nhất
    (1, 2, 30),  -- Máy bay 1 có 30 ghế Hạng Thương Gia
    (1, 3, 150), -- Máy bay 1 có 100 ghế Hạng Phổ Thông

    (2, 1, 10),  -- Máy bay 2 có 10 ghế Hạng Nhất
    (2, 2, 20),  -- Máy bay 2 có 20 ghế Hạng Thương Gia
    (2, 3, 150), -- Máy bay 2 có 150 ghế Hạng Phổ Thông

    (3, 1, 30),  -- Máy bay 3 có 15 ghế Hạng Nhất
    (3, 2, 40),  -- Máy bay 3 có 25 ghế Hạng Thương Gia
    (3, 3, 120), -- Máy bay 3 có 200 ghế Hạng Phổ Thông

    (4, 1, 30),  -- Máy bay 4 có 30 ghế Hạng Nhất
    (4, 2, 40),  -- Máy bay 4 có 40 ghế Hạng Thương Gia
    (4, 3, 100), -- Máy bay 4 có 300 ghế Hạng Phổ Thông

    (5, 1, 50),
    (5, 2, 80),
    (5, 3, 120);   

--Bảng GiaHangGhe
INSERT INTO GiaHangGhe (MaHangGhe, MaHHK,Gia) VALUES 
-- VN Airlines
(1, 1,700000), -- Phổ thông
(2, 1, 1200000), -- Thương gia
(3, 1, 3000000), -- Hạng nhất
(4, 1,300000), -- Tiết kiệm
-- Vietjet Air
(1, 2, 450000), -- Phổ thông
(2, 2, 1000000), -- Thương gia
(4, 2,275000), -- Tiết kiệm
-- Bamboo Airways
(1, 3, 450000), -- Phổ thông
(2, 3, 1100000), -- Thương gia
(4, 3,299000), -- Tiết kiệm
-- Pacific Airlines
(1, 4, 420000), -- Phổ thông
(2, 4, 900000), -- Thương gia
(4, 4, 280000), -- Tiết kiệm
-- VASCO
(1, 5, 380000), -- Phổ thông
(4, 5, 250000) -- Tiết kiệm


--Bảng Ve
INSERT INTO Ve (MaHanhKhach, MaTTV) VALUES 
(1, 1), -- Hành khách 1, Trạng thái vé: Có sẵn
(2, 2), -- Hành khách 2, Trạng thái vé: Đã đặt
(3, 1), -- Hành khách 3, Trạng thái vé: Có sẵn
(4, 3), -- Hành khách 4, Trạng thái vé: Đã sử dụng
(5, 1), -- Hành khách 5, Trạng thái vé: Có sẵn
(6, 1), -- Hành khách 6, Trạng thái vé: Có sẵn
(7, 2), -- Hành khách 7, Trạng thái vé: Đã đặt
(8, 1), -- Hành khách 8, Trạng thái vé: Có sẵn
(9, 3); -- Hành khách 9, Trạng thái vé: Đã sử dụng

--Bảng ChiTietVe
INSERT INTO ChiTietVe (MaVe, MaChuyenBay, MaHangGhe) Values
(1, 1, 1), -- Vé 1, Chuyến bay 1, Hạng ghế: Phổ thông
(2, 2, 1), -- Vé 2, Chuyến bay 2, Hạng ghế: Phổ thông
(3, 3, 2), -- Vé 3, Chuyến bay 3, Hạng ghế: Thương gia
(4, 4, 3), -- Vé 4, Chuyến bay 4, Hạng ghế: Hạng nhất
(5, 5, 4), -- Vé 5, Chuyến bay 5, Hạng ghế: Tiết kiệm
(6, 2, 2), -- Vé 6, Chuyến bay 2, Hạng ghế: Thương gia
(7, 3, 1), -- Vé 7, Chuyến bay 3, Hạng ghế: Phổ thông
(8, 4, 3), -- Vé 8, Chuyến bay 4, Hạng ghế: Hạng nhất
(9, 5, 4); -- Vé 9, Chuyến bay 5, Hạng ghế: Tiết kiệm

--Bảng PhieuDat
INSERT INTO PhieuDat (MaKhachHang, NgayDat, SoLuongHanhKhach) Values
(1, '2024-11-01', 2), -- Khách hàng 1, đặt vé cho 2 hành khách
(2, '2024-11-02', 1), -- Khách hàng 2, đặt vé cho 1 hành khách
(3, '2024-11-03', 3), -- Khách hàng 3, đặt vé cho 3 hành khách
(4, '2024-11-04', 1), -- Khách hàng 4, đặt vé cho 1 hành khách
(5, '2024-11-05', 2) -- Khách hàng 5, đặt vé cho 2 hành khách

--Bảng ChiTietPhieuDat
INSERT INTO ChiTietPhieuDat (MaPhieuDat, MaVe) VALUES 
(1, 1), -- Phiếu đặt 1, Vé 1
(1, 2), -- Phiếu đặt 1, Vé 2
(2, 3), -- Phiếu đặt 2, Vé 3
(3, 4), -- Phiếu đặt 3, Vé 4
(3, 5), -- Phiếu đặt 3, Vé 5
(3, 6), -- Phiếu đặt 3, Vé 6
(4, 7), -- Phiếu đặt 4, Vé 7
(5, 8), -- Phiếu đặt 5, Vé 8
(5, 9); -- Phiếu đặt 5, Vé 9

--Bảng HoaDon
INSERT INTO HoaDon (MaPhieuDat, TongTien) VALUES 
(1, 2000000), -- Phiếu đặt 1, Tổng tiền: 2,000,000 VND
(2, 1500000), -- Phiếu đặt 2, Tổng tiền: 1,500,000 VND
(3, 4200000), -- Phiếu đặt 3, Tổng tiền: 4,200,000 VND
(4, 1000000), -- Phiếu đặt 4, Tổng tiền: 1,000,000 VND
(5, 2700000) -- Phiếu đặt 5, Tổng tiền: 2,700,000 VND

--Bảng GiamGia
INSERT INTO GiamGia (Code, MucGiamGia) VALUES 
('GIAM10', 10.00), -- Mã giảm giá 10%
('GIAM20', 20.00), -- Mã giảm giá 20%
('GIAM50', 50.00), -- Mã giảm giá 50%
('NEWUSER', 15.00), -- Mã giảm giá cho người dùng mới 15%
('VIPMEMBER', 25.00) -- Mã giảm giá cho thành viên VIP 25%

--Bảng GiamGiaHoaDon
INSERT INTO GiamGiaHoaDon (MaHoaDon, MaGiamGia) VALUES 
(1, 1), -- Áp dụng mã GIAM10 cho hóa đơn 1
(2, 2), -- Áp dụng mã GIAM20 cho hóa đơn 2
(3, 3), -- Áp dụng mã GIAM50 cho hóa đơn 3
(4, 4), -- Áp dụng mã NEWUSER cho hóa đơn 4
(5, 5) -- Áp dụng mã VIPMEMBER cho hóa đơn 5

--Bảng TienIch
INSERT INTO TienIch (TenTienIch, GiaTienIch) VALUES 
(N'Bữa ăn trên máy bay', 150000), -- Bữa ăn trên máy bay, giá: 150,000 VND
(N'Gửi thêm hành lý', 250000), -- Gửi thêm hành lý, giá: 250,000 VND
(N'Ưu tiên lên máy bay', 200000), -- Ưu tiên lên máy bay, giá: 200,000 VND
(N'Chọn chỗ ngồi', 100000), -- Chọn chỗ ngồi, giá: 100,000 VND
(N'Truy cập Wi-Fi', 50000), -- Truy cập Wi-Fi, giá: 50,000 VND
(N'Truy cập phòng chờ hạng sang', 300000), -- Phòng chờ hạng sang, giá: 300,000 VND
(N'Bảo hiểm chuyến bay', 200000), -- Bảo hiểm chuyến bay, giá: 200,000 VND
(N'Trợ lý cá nhân', 500000), -- Trợ lý cá nhân, giá: 500,000 VND
(N'Dịch vụ spa', 400000), -- Dịch vụ spa, giá: 400,000 VND
(N'Nâng cấp ghế ngồi', 600000) -- Nâng cấp ghế ngồi, giá: 600,000 VND

--Bảng DatTienIch
INSERT INTO DatTienIch (MaPhieuDat, MaTienIch) VALUES 
(1, 1), -- Phiếu đặt 1, Tiện ích: Bữa ăn trên máy bay
(1, 2), -- Phiếu đặt 1, Tiện ích: Gửi thêm hành lý
(2, 3), -- Phiếu đặt 2, Tiện ích: Ưu tiên lên máy bay
(3, 4), -- Phiếu đặt 3, Tiện ích: Chọn chỗ ngồi
(4, 5) -- Phiếu đặt 4, Tiện ích: Truy cập Wi-Fi

--//--
-- Trigger
-- Xóa tài khoản khi có thao tác xóa khách hàng

-- Tạo KhachHang mới khi có TaiKhoan mới được tạo
CREATE TRIGGER trg_TaoKhachHangMoiKhiCoTaiKhoanMoi
ON TaiKhoan
AFTER INSERT
AS
BEGIN
    DECLARE @MaTaiKhoan INT;
    DECLARE @TenTaiKhoan NVARCHAR(50);

    -- Lấy mã tài khoản và tên tài khoản từ tài khoản mới vừa được thêm vào
    SELECT @MaTaiKhoan = MaTaiKhoan, @TenTaiKhoan = TenTaiKhoan FROM inserted;

    -- Tạo một khách hàng mới chỉ với mã tài khoản và tên tài khoản, các trường khác để NULL
    INSERT INTO KhachHang (MaTaiKhoan, HoTen, DiaChi, Email, NgaySinh, SoDienThoai)
    VALUES (@MaTaiKhoan, @TenTaiKhoan, NULL, NULL, NULL, NULL);
END;

--//--

Select * from TaiKhoan
Select * from KhachHang
Select * from HanhKhach
Select * from Ve
Select * from PhieuDat
Select * from ChiTietPhieuDat
Select * from ChiTietVe
Select * from TrangThaiVe
Select * from TrangThaiChuyenBay
Select * from ChuyenBay
Select * from HangGhe
Select * from HangHangKhong
Select * from GiaHangGhe
Select * from SanBay
Select * from LoTrinh
Select * from TienIch
Select * from DatTienIch
Select * from GiamGia
Select * from HoaDon
Select * from GiamGiaHoaDon

-- Stored Proc
-- Hàm mã hóa mật khẩu
CREATE FUNCTION func_MaHoaMatKhau(@MatKhau varchar(100))
Returns varchar(256)
as
	begin
		return convert(varchar(256),hashbytes('SHA_256',@MatKhau),1)
	end;

	
--//--
-- Tạo login + user cho tài khoản:
CREATE PROC sp_TaoLoginUser 
    @TenTaiKhoan NVARCHAR(100), 
    @MatKhau NVARCHAR(256)
AS
BEGIN
    BEGIN TRY
        -- Tạo Login (Sử dụng chuỗi động để tạo câu lệnh SQL)
        DECLARE @SQL NVARCHAR(MAX);
        SET @SQL = 'CREATE LOGIN [' + @TenTaiKhoan + '] WITH PASSWORD = ''' + @MatKhau + ''';';
        
        -- Thực thi câu lệnh tạo Login
        EXEC sp_executesql @SQL;

        -- Tạo User trong cơ sở dữ liệu QuanLyBanVeMayBay
        SET @SQL = 'USE QuanLyBanVeMayBay; CREATE USER [' + @TenTaiKhoan + '] FOR LOGIN [' + @TenTaiKhoan + '];';

        -- Thực thi câu lệnh tạo User
        EXEC sp_executesql @SQL;
        
        PRINT 'Tạo Login và User thành công.';
    END TRY
    BEGIN CATCH
        PRINT 'Đã xảy ra lỗi: ' + ERROR_MESSAGE();
    END CATCH
END

--Cursor tạo login và user cho csdl
DECLARE @TenTaiKhoan NVARCHAR(100), 
        @MatKhau NVARCHAR(256);


DECLARE c_TaiKhoan CURSOR FOR
    SELECT TenTaiKhoan, MatKhau
    FROM TaiKhoan;  

-- Mở cursor
OPEN c_TaiKhoan;

-- Lấy giá trị từ cursor vào biến
FETCH NEXT FROM c_TaiKhoan INTO @TenTaiKhoan, @MatKhau;

-- Duyệt qua tất cả các bản ghi trong cursor
WHILE @@FETCH_STATUS = 0
BEGIN
    -- Gọi stored procedure để tạo Login và User
    EXEC sp_TaoLoginUser @TenTaiKhoan, @MatKhau;

    -- Lấy bản ghi tiếp theo
    FETCH NEXT FROM c_TaiKhoan INTO @TenTaiKhoan, @MatKhau;
END;

-- Đóng và giải phóng cursor
CLOSE c_TaiKhoan;
DEALLOCATE c_TaiKhoan;

PRINT 'Đã tạo tài khoản và user cho tất cả các tài khoản trong bảng.';


-- Phân quyền
-- Admin 
	ALTER ROLE db_accessadmin ADD MEMBER Admin;
	GRANT SELECT, DELETE, UPDATE, INSERT ON SCHEMA::dbo TO Admin;
-- User
-- Tạo nhóm quyền cho user:
	CREATE ROLE customer_role
	GRANT SELECT, INSERT, UPDATE ON dbo.HanhKhach TO customer_role;
	GRANT SELECT, INSERT, UPDATE ON dbo.Ve TO customer_role;
	GRANT SELECT, INSERT, UPDATE ON dbo.ChiTietVe TO customer_role;
	GRANT SELECT, INSERT, UPDATE ON dbo.PhieuDat TO customer_role;
	GRANT SELECT, INSERT, UPDATE ON dbo.ChiTietPhieuDat TO customer_role;
	GRANT SELECT, INSERT, UPDATE ON dbo.HoaDon TO customer_role;
	GRANT SELECT, INSERT, UPDATE ON dbo.DatTienIch TO customer_role;
	GRANT SELECT ON SCHEMA::dbo TO customer_role;

	-- Add member
	ALTER ROLE customer_role Add member dang666
	ALTER ROLE customer_role Add member duy678
	ALTER ROLE customer_role Add member khoa345
	ALTER ROLE customer_role Add member luan901
	ALTER ROLE customer_role Add member minh123

	-- Thủ tục thêm vai trò cho khách
	CREATE PROC sp_AddRoleTaiKhoanMoi @TenTaiKhoan NVARCHAR(100)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);


    SET @sql = N'ALTER ROLE customer_role ADD MEMBER ' + QUOTENAME(@TenTaiKhoan);


    EXEC sp_executesql @sql;
END;


-- Gỡ quyền khách
CREATE PROCEDURE sp_GoQuyen
    @TenTaiKhoan NVARCHAR(100) 
AS
BEGIN

    DECLARE @sql NVARCHAR(MAX);
    
    SET @sql = N'ALTER ROLE customer_role DROP MEMBER ' + QUOTENAME(@TenTaiKhoan);

    EXEC sp_executesql @sql;
END;

-- Tạo tài khoản khách hàng
CREATE PROCEDURE sp_CreateTaiKhoan
    @TenTaiKhoan NVARCHAR(50),
    @MatKhau NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan)
    BEGIN
        RAISERROR('Tên tài khoản đã tồn tại.', 16, 1);
        RETURN;
    END

    DECLARE @MatKhauMaHoa NVARCHAR(256);
    SET @MatKhauMaHoa = dbo.func_MaHoaMatKhau(@MatKhau);
	exec sp_AddRoleTaiKhoanMoi @TenTaiKhoan

    INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau)
    VALUES (@TenTaiKhoan, @MatKhauMaHoa);

END;


-- Xóa tài khoản
CREATE PROCEDURE sp_XoaTaiKhoan 
    @MaTaiKhoan INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Kiểm tra xem tài khoản có liên kết với khách hàng nào không
        -- Nếu có, xóa các bản ghi trong bảng KhachHang liên quan
        DELETE FROM KhachHang WHERE MaTaiKhoan = @MaTaiKhoan;

        -- Tiếp tục xóa tài khoản trong bảng TaiKhoan

		DELETE FROM TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;


-- Đổi mật khẩu tài khoản
CREATE PROCEDURE sp_DoiMatKhau
    @TenTaiKhoan NVARCHAR(255),
    @MatKhau NVARCHAR(255)
AS
BEGIN
    -- Mã hóa mật khẩu
    DECLARE @MatKhauMaHoa NVARCHAR(256);
    SET @MatKhauMaHoa = dbo.func_MaHoaMatKhau(@MatKhau);

    -- Cập nhật thông tin tài khoản
    UPDATE TaiKhoan
    SET MatKhau = @MatKhauMaHoa
    WHERE TenTaiKhoan = @TenTaiKhoan;
END;

-- Cập nhật thông tin khách



--//--
-- Tra cứu thông tin khách hàng theo Tài khoản
CREATE FUNCTION func_ThongTinKhachHangTheoTaiKhoan(@TenTaiKhoan varchar(50))
RETURNS TABLE
AS
RETURN
(
	select kh.HoTen,kh.MaKhachHang, kh.DiaChi, kh.SoDienThoai, kh.NgaySinh, kh.Email
	From KhachHang kh
	Join TaiKhoan tk on tk.MaTaiKhoan = kh.MaTaiKhoan
	where tk.TenTaiKhoan = @TenTaiKhoan
);

select * from func_ThongTinKhachHangTheoTaiKhoan('Admin')





--Minh
--Stored Proc ThemHoaDon
CREATE PROCEDURE sp_ThemHoaDon 
    @MaPhieuDat INT,
    @TongTien DECIMAL(18, 2) OUTPUT,  -- Tham số đầu ra để trả về tổng tiền
    @MaHoaDonMoi INT OUTPUT -- Tham số đầu ra để trả về mã hóa đơn vừa được thêm
AS
BEGIN
    BEGIN TRY
        -- Kiểm tra mã phiếu đặt hợp lệ
        IF NOT EXISTS (SELECT 1 FROM ChiTietPhieuDat WHERE MaPhieuDat = @MaPhieuDat)
        BEGIN
            RAISERROR(N'Mã phiếu đặt không tồn tại.', 16, 1);
            RETURN;
        END

        -- Kiểm tra nếu mã phiếu đặt đã có hóa đơn
        IF dbo.func_KiemTraMaPhieuDat(@MaPhieuDat) = 1
        BEGIN
            RAISERROR(N'Mã phiếu đặt đã được sử dụng cho một hóa đơn khác.', 16, 1);
            RETURN;
        END

        -- Gọi function tính tổng tiền và gán giá trị vào @TongTien
        SET @TongTien = dbo.func_TinhTongTien(@MaPhieuDat);

        -- Thêm mới một hóa đơn với tổng tiền đã tính được
        INSERT INTO HoaDon (MaPhieuDat, TongTien)
        VALUES (@MaPhieuDat, @TongTien);

        -- Gán giá trị mã hóa đơn mới tạo vào biến đầu ra
        SET @MaHoaDonMoi = SCOPE_IDENTITY();
    END TRY
    BEGIN CATCH
        -- Lấy thông tin lỗi từ hàm hệ thống
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        -- Trả lỗi với thông tin chi tiết
        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;


-------------------Test
-- Khai báo các biến để lưu giá trị đầu ra
DECLARE @TongTien DECIMAL(18, 2);
DECLARE @MaHoaDonMoi INT;

-- Giá trị đầu vào để kiểm tra
DECLARE @MaPhieuDat INT = 2; -- Thay đổi giá trị này để test các trường hợp khác nhau

-- Gọi stored procedure
BEGIN TRY
    EXEC sp_ThemHoaDon 
        @MaPhieuDat = @MaPhieuDat, 
        @TongTien = @TongTien OUTPUT, 
        @MaHoaDonMoi = @MaHoaDonMoi OUTPUT;

    -- In kết quả ra để kiểm tra
    PRINT N'Tổng tiền: ' + CAST(@TongTien AS NVARCHAR);
    PRINT N'Mã hóa đơn mới: ' + CAST(@MaHoaDonMoi AS NVARCHAR);
END TRY
BEGIN CATCH
    -- Bắt lỗi và in ra thông báo lỗi
    PRINT N'Lỗi: ' + ERROR_MESSAGE();
END CATCH;


-------Stored proc Sửa Hóa Đơn
CREATE PROCEDURE sp_SuaHoaDon
    @MaHoaDon INT,                -- Mã hóa đơn cần sửa
    @MaPhieuDat INT = NULL        -- Mã phiếu đặt mới (tùy chọn, nếu cần thay đổi)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Kiểm tra mã phiếu đặt mới (nếu được truyền vào) có trùng không
        IF @MaPhieuDat IS NOT NULL AND dbo.func_KiemTraMaPhieuDat(@MaPhieuDat) = 1
        BEGIN
            RAISERROR(N'Hóa đơn của mã phiếu đặt này đã tồn tại trong hệ thống! Không thể sửa.', 16, 1);
            RETURN;
        END

        -- Nếu có mã phiếu đặt mới, cập nhật vào hóa đơn
        IF @MaPhieuDat IS NOT NULL
        BEGIN
            UPDATE HoaDon
            SET MaPhieuDat = @MaPhieuDat
            WHERE MaHoaDon = @MaHoaDon;
        END

        -- Lấy mã phiếu đặt hiện tại sau khi cập nhật (nếu có)
        DECLARE @CurrentMaPhieuDat INT;
        SELECT @CurrentMaPhieuDat = MaPhieuDat 
        FROM HoaDon 
        WHERE MaHoaDon = @MaHoaDon;

        -- Tính lại tổng tiền từ function func_TinhTongTien
        DECLARE @NewTongTien DECIMAL(18, 2);
        SET @NewTongTien = dbo.func_TinhTongTien(@CurrentMaPhieuDat);

        -- Cập nhật tổng tiền mới vào hóa đơn
        UPDATE HoaDon
        SET TongTien = @NewTongTien
        WHERE MaHoaDon = @MaHoaDon;

        PRINT N'Cập nhật hóa đơn thành công.';
    END TRY
    BEGIN CATCH
        -- Bắt lỗi trong quá trình cập nhật
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(N' %s', 16, 1, @ErrorMessage);
    END CATCH
END;

drop proc sp_SuaHoaDon

-----------Test
EXEC sp_SuaHoaDon 
    @MaHoaDon = 1,
    @MaPhieuDat = 1; -- Thay đổi mã phiếu đặt thành 2 và tính lại tổng tiền

select * from hoadon




-----------------------Stored proc Xóa Hóa Đơn 
CREATE PROCEDURE sp_XoaHoaDon
    @MaHoaDon INT -- Mã hóa đơn cần xóa
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Xóa các ràng buộc liên quan trước (nếu có)
        -- Ví dụ: Xóa thông tin giảm giá liên quan đến hóa đơn
        DELETE FROM GiamGiaHoaDon
        WHERE MaHoaDon = @MaHoaDon;

        -- Xóa hóa đơn
        DELETE FROM HoaDon
        WHERE MaHoaDon = @MaHoaDon;

        PRINT N'Xóa hóa đơn thành công.';
    END TRY
    BEGIN CATCH
        -- Bắt lỗi trong quá trình xóa
        RAISERROR(N'Không thể xóa hóa đơn.', 16, 1);
    END CATCH
END;



EXEC sp_XoaHoaDon @MaHoaDon = 23;



--Stored proc Thêm mã giảm giá
CREATE PROCEDURE sp_ThemMaGiamGia
    @Code NVARCHAR(20),          -- Code giảm giá
    @MucGiamGia DECIMAL(18, 2)  -- Mức giảm giá
AS
BEGIN
    BEGIN TRY
        -- Kiểm tra xem Code đã tồn tại chưa
        IF dbo.func_KiemTraCodeGiamGia(@Code) = 1
        BEGIN
            RAISERROR(N'Code giảm giá này đã tồn tại.', 16, 1);
            RETURN;
        END

        -- Thêm mã giảm giá mới vào bảng
        INSERT INTO GiamGia (Code, MucGiamGia)
        VALUES (@Code, @MucGiamGia);

        PRINT N'Thêm mã giảm giá thành công.';
    END TRY
    BEGIN CATCH
        -- Bắt lỗi và trả về thông báo
        RAISERROR(N'Không thể thêm mã giảm giá vì code đã tồn tại.', 16, 1);
    END CATCH
END;



------------Test
DECLARE @Code NVARCHAR(20) = 'Friday';
DECLARE @MucGiamGia DECIMAL(18, 2) = 20.0; -- 20%

EXEC sp_ThemMaGiamGia
    @Code = @Code,
    @MucGiamGia = @MucGiamGia;




--Procedure Sửa Mã Giảm Giá
CREATE PROCEDURE sp_SuaMaGiamGia
(
    @MaGiamGia INT,              -- Mã giảm giá cần sửa
    @Code NVARCHAR(20),          -- Code mới cần cập nhật
    @MucGiamGia DECIMAL(18, 2)   -- Mức giảm giá mới
)
AS
BEGIN

    -- Kiểm tra xem tên tiện ích mới có bị trùng không (tránh trùng tên với tiện ích khác)
    IF dbo.func_KiemTraCodeGiamGia(@Code) = 1 
    BEGIN
        PRINT N'Code giảm giá này đã tồn tại trong hệ thống! Không thể sửa';
        RETURN;  -- Dừng lại nếu code giảm giá mới bị trùng
    END

    -- Cập nhật thông tin mã giảm giá
        UPDATE GiamGia
        SET Code = @Code,
            MucGiamGia = @MucGiamGia
        WHERE MaGiamGia = @MaGiamGia;

    PRINT N'Mã giảm giá đã được cập nhật thành công!';
END;


drop proc sp_SuaMaGiamGia

select * from GiamGia

-------Test
DECLARE @MaGiamGia INT = 7;  -- Mã giảm giá cần sửa
DECLARE @Code NVARCHAR(20) = N'GIAM0';
DECLARE @MucGiamGia DECIMAL(18, 2) = 25.0; -- 15%

EXEC sp_SuaMaGiamGia
    @MaGiamGia = @MaGiamGia,
    @Code = @Code,
    @MucGiamGia = @MucGiamGia;



--------Stored procedure XoaMaGiamGia
CREATE PROCEDURE sp_XoaMaGiamGia
    @MaGiamGia INT -- Mã giảm giá cần xóa
AS
BEGIN

    -- Xóa mã giảm giá
    DELETE FROM GiamGia
    WHERE MaGiamGia = @MaGiamGia;

    -- Thông báo thành công
    PRINT N'Mã giảm giá đã được xóa thành công.';
END;
drop proc sp_XoaMaGiamGia
---------------Test
DECLARE @MaGiamGia INT = 7; -- Mã giảm giá cần xóa

EXEC sp_XoaMaGiamGia @MaGiamGia = @MaGiamGia;



drop function func_TinhTongTien
--Function
CREATE FUNCTION func_TinhTongTien (@MaPhieuDat INT)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @TongTienVe DECIMAL(18, 2) = 0;
    DECLARE @TongTienTienIch DECIMAL(18, 2) = 0;
    DECLARE @PhanTramGiam DECIMAL(5, 2) = 0;
    DECLARE @TongTruocGiam DECIMAL(18, 2) = 0;
    DECLARE @TongTien DECIMAL(18, 2);

    -- Tính tổng tiền vé
    SELECT @TongTienVe = SUM(ChuyenBay.GiaBay + GiaHangGhe.Gia)
    FROM ChiTietPhieuDat, Ve, ChiTietVe, ChuyenBay, GiaHangGhe
    WHERE ChiTietPhieuDat.MaVe = Ve.MaVe
    AND Ve.MaVe = ChiTietVe.MaVe
    AND ChiTietVe.MaChuyenBay = ChuyenBay.MaChuyenBay
    AND ChiTietVe.MaHangGhe = GiaHangGhe.MaHangGhe
    AND ChiTietPhieuDat.MaPhieuDat = @MaPhieuDat
	AND ChuyenBay.MaHangHangKhong = GiahangGhe.MaHHK;

    -- Tính tổng tiền tiện ích
    SELECT @TongTienTienIch = SUM(TienIch.GiaTienIch)
    FROM DatTienIch, TienIch 
    WHERE DatTienIch.MaTienIch = TienIch.MaTienIch
    AND DatTienIch.MaPhieuDat = @MaPhieuDat;

    -- Tổng tiền trước giảm giá
    SET @TongTruocGiam = @TongTienVe + @TongTienTienIch;

    -- Lấy mức giảm giá
	SELECT @PhanTramGiam = COALESCE(MAX(GiamGia.MucGiamGia), 0)
    FROM GiamGiaHoaDon, GiamGia, HoaDon 
    WHERE GiamGiaHoaDon.MaGiamGia = GiamGia.MaGiamGia
	AND HoaDon.MaHoaDon= GiamGiaHoaDon.MaHoaDon
    AND HoaDon.MaPhieuDat = @MaPhieuDat;

    --Tính tổng tiền sau giảm giá
    SET @TongTien = @TongTruocGiam * (1 - @PhanTramGiam / 100.0);

    RETURN @TongTien;
END;



------------------Test
SELECT dbo.func_TinhTongTien(2) AS TongTien;;


---------Function kiểm tra mã phiếu đặt
CREATE FUNCTION func_KiemTraMaPhieuDat (
    @MaPhieuDat NVARCHAR(20) -- Code cần kiểm tra
)
RETURNS BIT
AS
BEGIN
    DECLARE @Exists BIT;

    -- Kiểm tra sự tồn tại của code trong bảng GiamGia
    IF EXISTS (SELECT 1 FROM HoaDon WHERE MaPhieuDat = @MaPhieuDat)
    BEGIN
        SET @Exists = 1;  -- Hóa đơn có mã phiếu đặt này đã tồn tại
    END
    ELSE
    BEGIN
        SET @Exists = 0;  -- Hóa đơn có mã phiếu đặt này không tồn tại
    END
    RETURN @Exists;
END;

---------Function kiểm tra code giảm giá
CREATE FUNCTION func_KiemTraCodeGiamGia (
    @Code NVARCHAR(20) -- Code cần kiểm tra
)
RETURNS BIT
AS
BEGIN
    DECLARE @Exists BIT;

    -- Kiểm tra sự tồn tại của code trong bảng GiamGia
    IF EXISTS (SELECT 1 FROM GiamGia WHERE Code = @Code)
    BEGIN
        SET @Exists = 1;  -- code đã tồn tại
    END
    ELSE
    BEGIN
        SET @Exists = 0;  -- code không tồn tại
    END
    RETURN @Exists;
END;





--Trigger Cập Nhật Tổng Tiền Hóa Đơn khi thêm hoặc xóa vé 
CREATE TRIGGER trg_CapNhatTongTienHoaDon
ON ChiTietPhieuDat
AFTER INSERT, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Khai báo biến lưu tổng tiền
    DECLARE @MaPhieuDat INT;

    -- Kiểm tra thêm hay xóa để lấy MaPhieuDat
    IF EXISTS (SELECT 1 FROM INSERTED)
    BEGIN
        SELECT TOP 1 @MaPhieuDat = MaPhieuDat FROM INSERTED;
    END
    ELSE IF EXISTS (SELECT 1 FROM DELETED)
    BEGIN
        SELECT TOP 1 @MaPhieuDat = MaPhieuDat FROM DELETED;
    END

    -- Cập nhật lại tổng tiền hóa đơn
    IF @MaPhieuDat IS NOT NULL
    BEGIN
        DECLARE @TongTien DECIMAL(18, 2);

        -- Gọi function tính tổng tiền
        SET @TongTien = dbo.func_TinhTongTien(@MaPhieuDat);

        -- Cập nhật tổng tiền trong bảng HoaDon
        UPDATE HoaDon
        SET TongTien = @TongTien
        WHERE MaPhieuDat = @MaPhieuDat;
    END
END;


-----Thêm dữ liệu để test
insert into Ve values (8,2)
INSERT INTO ChiTietVe (MaVe, MaChuyenBay, NgayDi, NgayDen, MaHangGhe) Values
(11, 1, '2024-11-10', '2024-11-10', 1) -- Vé 11, Chuyến bay 1, Hạng ghế: Phổ thông
-----Test thêm vé
INSERT INTO ChiTietPhieuDat (MaPhieuDat, MaVe) 
VALUES (2, 11); -- Thay giá trị 1 và 101 với dữ liệu phù hợp

-----Test xóa vé
DELETE FROM ChiTietPhieuDat
WHERE MaPhieuDat = 2 AND MaVe = 11;






------LUÂN
----===============================================================---------------------
----================================================================--------------------
----proc tao ve
CREATE PROCEDURE sp_TaoVe
    @MaHK INT,
    @MaChuyenBay INT,
    @NgayDi DATE,
    @NgayDen DATE,
    @MaHangGhe INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @MaHK IS NOT NULL AND NOT EXISTS (SELECT 1 FROM HanhKhach WHERE MaHanhKhach = @MaHK)
    BEGIN
        RAISERROR(N'Hành khách không tồn tại.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM ChuyenBay WHERE MaChuyenBay = @MaChuyenBay)
    BEGIN
        RAISERROR(N'Mã chuyến bay không tồn tại.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM HangGhe WHERE MaHangGhe = @MaHangGhe)
    BEGIN
        RAISERROR(N'Mã hạng ghế không tồn tại.', 16, 1);
        RETURN;
    END

    IF @NgayDi < GETDATE() 
    BEGIN
        RAISERROR(N'Ngày đi phải lớn hơn hoặc bằng ngày hiện tại.', 16, 1);
        RETURN;
    END

    IF @NgayDen < GETDATE() 
    BEGIN
        RAISERROR(N'Ngày đến phải lớn hơn hoặc bằng ngày hiện tại.', 16, 1);
        RETURN;
    END

    IF @NgayDi > @NgayDen
    BEGIN
        RAISERROR(N'Ngày đi phải nhỏ hơn hoặc bằng ngày đến.', 16, 1);
        RETURN;
    END

    DECLARE @MaVe INT;
    INSERT INTO Ve (MaHanhKhach, MaTTV)
    VALUES (@MaHK, 1); 

    SET @MaVe = SCOPE_IDENTITY();

    INSERT INTO ChiTietVe (MaVe, MaChuyenBay, NgayDi, NgayDen, MaHangGhe)
    VALUES (@MaVe, @MaChuyenBay, @NgayDi, @NgayDen, @MaHangGhe);

    PRINT N'Vé và chi tiết vé đã được tạo thành công .';
END;

-- Trường hợp có hành khách (MaHK không NULL)
EXEC sp_TaoVe 
    @MaHK = 1,            
    @MaChuyenBay = 2,     
    @NgayDi = '2024-12-01', 
    @NgayDen = '2024-12-01',
    @MaHangGhe = 2;        
	select*from ve
	select*from ChiTietVe
-- Trường hợp không có hành khách (MaHK NULL)
EXEC sp_TaoVe 
    @MaHK = NULL,           
    @MaChuyenBay = 1,    
    @NgayDi = '2024-12-01', 
    @NgayDen = '2024-12-01',
    @MaHangGhe = 2;         

	EXEC sp_TaoVe
    @MaHK = 1,                
    @MaChuyenBay = 1,      
    @NgayDi = '2024-12-25',  
    @NgayDen = '2024-12-30', 
    @MaHangGhe = 2;           -

	------proc xóa vé
CREATE PROCEDURE sp_XoaVe
    @MaVe INT
AS
BEGIN
    SET NOCOUNT ON;
    IF dbo.fn_KiemTraVeTrongPhieuDat(@MaVe) = 1
    BEGIN
        RAISERROR(N'Vé này đang được sử dụng trong phiếu đặt, không thể xóa.', 16, 1);
        RETURN;
    END

    DELETE FROM ChiTietVe
    WHERE MaVe = @MaVe;

    DELETE FROM Ve
    WHERE MaVe = @MaVe;

    PRINT N'Vé và chi tiết vé đã được xóa thành công.';
END;

---câu lệnh thực thi
EXEC sp_XoaVe @MaVe = 10;

EXEC sp_XoaVe @MaVe = 2;

----proc sua chi tiet ve
	CREATE PROCEDURE sp_SuaVeVaChiTiet
    @MaVe INT,            
    @MaHK INT,           
    @MaTTV INT,           
    @MaChuyenBay INT,     
    @NgayDi DATE,         
    @NgayDen DATE,        
    @MaHangGhe INT        
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM Ve WHERE MaVe = @MaVe)
    BEGIN
        RAISERROR(N'Vé không tồn tại.', 16, 1);
        RETURN;
    END
    IF NOT EXISTS (SELECT 1 FROM HanhKhach WHERE MaHanhKhach = @MaHK)
    BEGIN
        RAISERROR(N'Hành khách không tồn tại.', 16, 1);
        RETURN;
    END
    IF @MaTTV NOT IN (1, 2, 3)
    BEGIN
        RAISERROR(N'Mã trạng thái vé không hợp lệ.', 16, 1);
        RETURN;
    END
    IF NOT EXISTS (SELECT 1 FROM ChiTietVe WHERE MaVe = @MaVe)
    BEGIN
        RAISERROR(N'Chi tiết vé không tồn tại.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM ChuyenBay WHERE MaChuyenBay = @MaChuyenBay)
    BEGIN
        RAISERROR(N'Mã chuyến bay không tồn tại.', 16, 1);
        RETURN;
    END

    IF @NgayDi > @NgayDen
    BEGIN
        RAISERROR(N'Ngày đi phải nhỏ hơn hoặc bằng ngày đến.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM HangGhe WHERE MaHangGhe = @MaHangGhe)
    BEGIN
        RAISERROR(N'Mã hạng ghế không tồn tại.', 16, 1);
        RETURN;
    END
   
    UPDATE Ve
    SET MaHanhKhach = @MaHK, MaTTV = @MaTTV
    WHERE MaVe = @MaVe;

    UPDATE ChiTietVe
    SET MaChuyenBay = @MaChuyenBay, NgayDi = @NgayDi, NgayDen = @NgayDen, MaHangGhe = @MaHangGhe
    WHERE MaVe = @MaVe;

    PRINT N'Vé và chi tiết vé đã được cập nhật thành công.';
END;
EXEC sp_SuaVeVaChiTiet
    @MaVe = 1, 
    @MaHK = 2, 
    @MaTTV = 2, 
    @MaChuyenBay = 3, 
    @NgayDi = '2024-11-16', 
    @NgayDen = '2024-11-17', 
    @MaHangGhe = 4;

--------FUNCTION--------------------
-----kiểm tra vé có được đặt hông
CREATE FUNCTION fn_KiemTraVeTrongPhieuDat
(
    @MaVe INT
)
RETURNS BIT
AS
BEGIN
    DECLARE @KetQua BIT;

    IF EXISTS (SELECT 1 FROM ChiTietPhieuDat WHERE MaVe = @MaVe)
    BEGIN
        SET @KetQua = 1;  
    END

    ELSE
    BEGIN
        SET @KetQua = 0;  
    END

    RETURN @KetQua;
END;

----------------TRIGGER---------------
--CẬP NHẬT TRẠNG THÁI PHIẾU ĐẶT 
CREATE TRIGGER trg_CapNhatTrangThaiVe
ON ChiTietPhieuDat
AFTER INSERT, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
        UPDATE Ve
        SET MaTTV = 2
        WHERE MaVe IN (SELECT MaVe FROM inserted);
    END

    IF EXISTS (SELECT 1 FROM deleted)
    BEGIN
        UPDATE Ve
        SET MaTTV = 1
        WHERE MaVe IN (SELECT MaVe FROM deleted);
    END

    PRINT N'MaTTV đã được cập nhật thành công cho các vé được thêm hoặc xóa.';
END;
--============================================================================================================================================-----------------------
--============================================================================================================================================--------------------------

-- Khoa
-- Stored Proc

-- Tìm kiếm chuyến bay theo lộ trình và ngày đi 


CREATE PROCEDURE sp_TimKiemChuyenBay
    @MaHangHangKhong INT = NULL,    
    @MaTrangThaiChuyenBay INT = NULL,     
    @MaLoTrinh INT = NULL,   
    @MaMayBay INT = NULL,   
    @GiaBayMin MONEY = NULL,   
    @GiaBayMax MONEY = NULL 
AS
BEGIN
    SELECT 
        c.MaChuyenBay, 
        h.TenHangHangKhong, 
        t.TenTrangThaiChuyenBay, 
        l.TenLoTrinh, 
        m.TenMayBay, 
        c.GiaBay
    FROM 
        ChuyenBay c
    INNER JOIN 
        HangHangKhong h ON c.MaHangHangKhong = h.MaHangHangKhong
    INNER JOIN 
        TrangThaiChuyenBay t ON c.MaTrangThaiChuyenBay = t.MaTrangThaiChuyenBay
    INNER JOIN 
        LoTrinh l ON c.MaLoTrinh = l.MaLoTrinh
    INNER JOIN 
        MayBay m ON c.MaMayBay = m.MaMayBay
    WHERE 
        (@MaHangHangKhong IS NULL OR c.MaHangHangKhong = @MaHangHangKhong)
        AND (@MaTrangThaiChuyenBay IS NULL OR c.MaTrangThaiChuyenBay = @MaTrangThaiChuyenBay)
        AND (@MaLoTrinh IS NULL OR c.MaLoTrinh = @MaLoTrinh)
        AND (@MaMayBay IS NULL OR c.MaMayBay = @MaMayBay)
        AND (@GiaBayMin IS NULL OR c.GiaBay >= @GiaBayMin)
        AND (@GiaBayMax IS NULL OR c.GiaBay <= @GiaBayMax)
    ORDER BY 
        c.MaChuyenBay;
END

-- Tìm kiếm theo hãng hàng không và lộ trình
EXEC sp_TimKiemChuyenBay @MaHangHangKhong = 1;

-- Tìm kiếm tất cả chuyến bay với giá bay từ 500 đến 1000
EXEC sp_TimKiemChuyenBay @GiaBayMin = 500, @GiaBayMax = 100000000;

-- Tìm kiếm theo tất cả các tiêu chí
EXEC sp_TimKiemChuyenBay @MaHangHangKhong = 1, @MaTrangThaiChuyenBay = 2, @MaLoTrinh = 3, @MaMayBay = 4, @GiaBayMin = 1000, @GiaBayMax = 50000000;

-- Cạp nhật trạng thái chuyến bay 




-- Thêm mới chuyến bay

CREATE PROCEDURE sp_ThemMoiChuyenBay
(
    @MaHangHangKhong INT,
    @MaTrangThaiChuyenBay INT,
    @MaLoTrinh INT,
    @MaMayBay INT,
    @GiaBay MONEY
)
AS
BEGIN

    IF dbo.fn_KiemTraTonTaiChuyenBay(@MaHangHangKhong, @MaTrangThaiChuyenBay, @MaLoTrinh, @MaMayBay) = 1
    BEGIN
        PRINT N'Chuyến bay đã tồn tại!';
        RETURN;  -- Dừng lại nếu chuyến bay đã tồn tại
    END

    INSERT INTO ChuyenBay (MaHangHangKhong, MaTrangThaiChuyenBay, MaLoTrinh, MaMayBay, GiaBay)
    VALUES (@MaHangHangKhong, @MaTrangThaiChuyenBay, @MaLoTrinh, @MaMayBay, @GiaBay);

    PRINT N'Chuyến bay đã được thêm mới thành công!';
END;

EXEC sp_ThemMoiChuyenBay @MaHangHangKhong = 5, @MaTrangThaiChuyenBay = 2, @MaLoTrinh = 2, @MaMayBay = 4, @GiaBay = 1500000;


-- Xóa chuyến bay

CREATE PROCEDURE sp_XoaChuyenBay
(
    @MaChuyenBay INT
)
AS
BEGIN
    -- Kiểm tra xem chuyến bay đã bán vé hay chưa
    IF dbo.fn_KiemTraChuyenBayBanVeChua(@MaChuyenBay) = 1
    BEGIN
        PRINT N'Chuyến bay này đã bán vé, không thể xóa!';
        RETURN;  -- Dừng lại nếu chuyến bay đã bán vé
    END

    -- Nếu chuyến bay chưa bán vé, tiến hành xóa chuyến bay
    DELETE FROM ChuyenBay
    WHERE MaChuyenBay = @MaChuyenBay;

    PRINT N'Chuyến bay đã được xóa thành công!';
END;


EXEC sp_XoaChuyenBay @MaChuyenBay = 6;


-- Sửa  chuyến bay

CREATE PROCEDURE sp_SuaTTChuyenBay
(
    @MaChuyenBay INT,            
    @MaHangHangKhong INT,      
    @MaTrangThaiChuyenBay INT,       
    @MaLoTrinh INT,                
    @MaMayBay INT,     
    @GiaBay MONEY              
)
AS
BEGIN
    -- Kiểm tra xem chuyến bay mới đã tồn tại chưa
    IF dbo.fn_KiemTraTonTaiChuyenBay(@MaChuyenBay, @MaTrangThaiChuyenBay, @MaLoTrinh, @MaMayBay) = 1
    BEGIN
        PRINT N'Chuyến bay này đã tồn tại, không thể sửa!';
        RETURN;  -- Dừng lại nếu chuyến bay đã tồn tại
    END

    -- Cập nhật thông tin chuyến bay
    UPDATE ChuyenBay
    SET
        MaHangHangKhong = @MaHangHangKhong,
        MaTrangThaiChuyenBay = @MaTrangThaiChuyenBay,
        MaLoTrinh = @MaLoTrinh,
        MaMayBay = @MaMayBay,
        GiaBay = @GiaBay
    WHERE MaChuyenBay = @MaChuyenBay;

    PRINT N'Thông tin chuyến bay đã được sửa thành công!';
END;


EXEC sp_SuaTTChuyenBay @MaChuyenBay = 5, @MaHangHangKhong = 3, @MaTrangThaiChuyenBay = 2, @MaLoTrinh = 5, @MaMayBay = 4, @GiaBay = 5000000;      


-- Thêm máy bay

CREATE PROCEDURE sp_ThemMayBay
(
    @TenMayBay NVARCHAR(100),
    @SucChuaToiDa INT               
)
AS
BEGIN
    -- Kiểm tra xem máy bay với tên này đã tồn tại chưa
    IF dbo.fn_KiemTraTonTaiMayBay(@TenMayBay) = 1
    BEGIN
        PRINT N'Máy bay này đã tồn tại!';
        RETURN;  -- Dừng lại nếu máy bay đã tồn tại
    END

    -- Thêm mới máy bay
    INSERT INTO MayBay (TenMayBay, SucChuaToiDa)
    VALUES (@TenMayBay, @SucChuaToiDa);

    PRINT N'Máy bay đã được thêm thành công!';
END;


EXEC sp_ThemMayBay @TenMayBay = 'Boeing 666', @SucChuaToiDa = 300; 


-- Xóa máy bay

CREATE PROCEDURE sp_XoaMayBay
(
    @MaMayBay INT           
)
AS
BEGIN
    -- Kiểm tra xem máy bay có đang được sử dụng trong chuyến bay nào không
    IF dbo.fn_KiemTraMayBayDuocDung(@MaMayBay) = 1
    BEGIN
        PRINT N'Máy bay này đang được sử dụng trong chuyến bay, không thể xóa!';
        RETURN;  -- Dừng lại nếu máy bay đang được sử dụng
    END

    -- Tiến hành xóa máy bay
    DELETE FROM MayBay
    WHERE MaMayBay = @MaMayBay;

    PRINT N'Máy bay đã được xóa thành công!';
END;

EXEC sp_XoaMayBay @MaMayBay = 6; 


-- Sửa thông tin máy bay

CREATE PROCEDURE sp_SuaTTMayBay
(
    @MaMayBay INT,               
    @TenMayBay NVARCHAR(100),  
    @SucChuaToiDa INT       
)
AS
BEGIN
    -- Kiểm tra xem tên máy bay mới đã tồn tại chưa
    IF dbo.fn_KiemTraTonTaiMayBay(@TenMayBay) = 1
    BEGIN
        PRINT N'Máy bay với tên này đã tồn tại, không thể sửa!';
        RETURN;  -- Dừng lại nếu tên máy bay đã tồn tại
    END

    -- Tiến hành sửa thông tin máy bay
    UPDATE MayBay
    SET TenMayBay = @TenMayBay,    -- Sửa tên máy bay
        SucChuaToiDa = @SucChuaToiDa  -- Sửa sức chứa
    WHERE MaMayBay = @MaMayBay;

    PRINT N'Thông tin máy bay đã được sửa thành công!';
END;

EXEC dbo.sp_SuaTTMayBay @MaMayBay = 1, @TenMayBay = 'Boeing 737 M', @SucChuaToiDa = 330; 


-- Thêm tiện ích


CREATE PROCEDURE sp_ThemTienIch
(
    @TenTienIch NVARCHAR(100),
    @GiaTienIch DECIMAL(18, 2)   
)
AS
BEGIN
    -- Kiểm tra xem tiện ích với tên này đã tồn tại chưa
    IF dbo.fn_KiemTraTonTaiTienIch(@TenTienIch) = 1
    BEGIN
        PRINT N'Tiện ích này đã tồn tại trong hệ thống!';
        RETURN;  -- Dừng lại nếu tiện ích đã tồn tại
    END

    -- Thêm tiện ích vào bảng TienIch
    INSERT INTO TienIch (TenTienIch, GiaTienIch)
    VALUES (@TenTienIch, @GiaTienIch);

    PRINT N'Tiện ích đã được thêm thành công!';
END;

EXEC sp_ThemTienIch @TenTienIch = 'WiFi Premium', @GiaTienIch = 100000.00;


-- Xóa tiện ích

CREATE PROCEDURE sp_XoaTienIch
(
    @MaTienIch INT   -- Tên tiện ích cần xóa
)
AS
BEGIN

    -- Xóa tiện ích từ bảng TienIch
    DELETE FROM TienIch
    WHERE MaTienIch = @MaTienIch;

    PRINT N'Tiện ích đã được xóa thành công!';
END;


EXEC sp_XoaTienIch @MaTienIch = 11;


-- Sửa tiện ích


CREATE PROCEDURE sp_SuaTienIch
(
    @MaTienIch INT,            
    @TenTienIch NVARCHAR(100), 
    @GiaTienIch DECIMAL(18, 2) 
)
AS
BEGIN

    -- Kiểm tra xem tên tiện ích mới có bị trùng không (tránh trùng tên với tiện ích khác)
    IF dbo.fn_KiemTraTonTaiTienIch(@TenTienIch) = 1 
    BEGIN
        PRINT N'Tên tiện ích này đã tồn tại trong hệ thống! Không thể sửa';
        RETURN;  -- Dừng lại nếu tên tiện ích mới bị trùng
    END

    -- Cập nhật thông tin tiện ích
    UPDATE TienIch
    SET TenTienIch = @TenTienIch,
        GiaTienIch = @GiaTienIch
    WHERE MaTienIch = @MaTienIch;

    PRINT N'Thông tin tiện ích đã được cập nhật thành công!';
END;

EXEC sp_SuaTienIch @MaTienIch = 1, @TenTienIchMoi = 'Bữa ăn nhẹ', @GiaTienIchMoi = 150.00;


-- Function




-- Kiểm tra chuyến bay đã tồn tại chưa

CREATE FUNCTION fn_KiemTraTonTaiChuyenBay
(
    @MaHangHangKhong INT,
    @MaTrangThaiChuyenBay INT,
    @MaLoTrinh INT,
    @MaMayBay INT
)
RETURNS BIT
AS
BEGIN
    DECLARE @Exists BIT;

    -- Kiểm tra xem chuyến bay có tồn tại không dựa trên các tham số truyền vào
    IF EXISTS (
        SELECT 1
        FROM ChuyenBay
        WHERE MaHangHangKhong = @MaHangHangKhong
          AND MaTrangThaiChuyenBay = @MaTrangThaiChuyenBay
          AND MaLoTrinh = @MaLoTrinh
          AND MaMayBay = @MaMayBay
    )
    BEGIN
        SET @Exists = 1;  -- Chuyến bay đã tồn tại
    END
    ELSE
    BEGIN
        SET @Exists = 0;  -- Chuyến bay chưa tồn tại
    END

    RETURN @Exists;
END;


-- Kiểm tra chuyến bay đã bán vé chưa

CREATE FUNCTION fn_KiemTraChuyenBayBanVeChua
(
    @MaChuyenBay INT
)
RETURNS BIT
AS
BEGIN
    DECLARE @Exists BIT;

    -- Kiểm tra xem chuyến bay có nằm trong ChiTietVe không
    IF EXISTS (
        SELECT 1
        FROM ChiTietVe
        WHERE MaChuyenBay = @MaChuyenBay
    )
    BEGIN
        SET @Exists = 1;  -- Chuyến bay đã bán vé
    END
    ELSE
    BEGIN
        SET @Exists = 0;  -- Chuyến bay chưa bán vé
    END

    RETURN @Exists;
END;


-- Kiểm tra tồn tại máy bay

CREATE FUNCTION fn_KiemTraTonTaiMayBay
(
    @TenMayBay NVARCHAR(100)        
)
RETURNS BIT
AS
BEGIN
    DECLARE @Exists BIT;

    -- Kiểm tra sự tồn tại của máy bay với tên đã cho
    IF EXISTS (
        SELECT 1
        FROM MayBay
        WHERE TenMayBay = @TenMayBay
    )
    BEGIN
        SET @Exists = 1;  -- Máy bay đã tồn tại
    END
    ELSE
    BEGIN
        SET @Exists = 0;  -- Máy bay không tồn tại
    END

    RETURN @Exists;
END;


-- Kiểm tra máy bay được dùng chưa 

CREATE FUNCTION fn_KiemTraMayBayDuocDung
(
    @MaMayBay INT       
)
RETURNS BIT
AS
BEGIN
    DECLARE @IsUsed BIT;

    -- Kiểm tra xem máy bay có đang được sử dụng trong chuyến bay nào không
    IF EXISTS (
        SELECT 1
        FROM ChuyenBay
        WHERE MaMayBay = @MaMayBay
    )
    BEGIN
        SET @IsUsed = 1;  -- Máy bay đang được sử dụng
    END
    ELSE
    BEGIN
        SET @IsUsed = 0;  -- Máy bay không được sử dụng
    END

    RETURN @IsUsed;
END;

-- Kiem tra tồn tại tiện ích

CREATE FUNCTION fn_KiemTraTonTaiTienIch
(
    @TenTienIch NVARCHAR(100)   
)
RETURNS BIT
AS
BEGIN
    DECLARE @IsExist BIT;

    -- Kiểm tra xem tiện ích có tồn tại trong bảng TienIch không
    IF EXISTS (
        SELECT 1
        FROM TienIch
        WHERE TenTienIch = @TenTienIch
    )
    BEGIN
        SET @IsExist = 1;  -- Tiện ích đã tồn tại
    END
    ELSE
    BEGIN
        SET @IsExist = 0;  -- Tiện ích không tồn tại
    END

    RETURN @IsExist;
END;



