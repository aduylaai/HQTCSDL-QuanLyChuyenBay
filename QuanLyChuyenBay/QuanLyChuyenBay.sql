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
    MaMayBay INT,
    MaHangGhe INT,
    SoGhe INT CHECK (SoGhe > 0), -- Số ghế phải lớn hơn 0
    CONSTRAINT PK_MayBay_HangGhe PRIMARY KEY (MaMayBay, MaHangGhe),
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
	MaVe INT,
	MaChuyenBay INT,
    NgayDi DATE,
    NgayDen DATE,
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
    MaHoaDon INT,
    MaGiamGia INT,
    CONSTRAINT PK_HD_GG PRIMARY KEY (MaHoaDon, MaGiamGia),
    CONSTRAINT FK_HD_GG_HOADON FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    CONSTRAINT FK_HD_GG_GIAMGIA FOREIGN KEY (MaGiamGia) REFERENCES GiamGia(MaGiamGia)
);

CREATE TABLE TienIch (
    MaTienIch INT IDENTITY(1,1) PRIMARY KEY,
    TenTienIch NVARCHAR(100),
    GiaTienIch DECIMAL(18, 2) CHECK (GiaTienIch > 0) -- Giá tiền phải lớn hơn 0
);

CREATE TABLE DatTienIch (
    MaPhieuDat INT,
    MaTienIch INT,
    CONSTRAINT PK_PD_TI PRIMARY KEY (MaPhieuDat, MaTienIch),
    CONSTRAINT FK_PD_TI_TIENICH FOREIGN KEY (MaTienIch) REFERENCES TienIch(MaTienIch)
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
INSERT INTO LoTrinh (MaSB_Di, MaSB_Den) VALUES 
(1, 2), -- Từ Hà Nội đến TP Hồ Chí Minh
(2, 3), -- Từ TP Hồ Chí Minh đến Đà Nẵng
(1, 3), -- Từ Hà Nội đến Đà Nẵng
(3, 4), -- Từ Đà Nẵng đến Nha Trang
(4, 5) -- Từ Nha Trang đến Phú Quốc


--Bảng ChuyenBay
INSERT INTO ChuyenBay (MaHangHangKhong, MaTrangThaiChuyenBay, MaLoTrinh,MaMayBay,GiaBay) VALUES 
(1, 1, 1,1,1500000), -- Vietnam Airlines, Có sẵn, Hà Nội - TP Hồ Chí Minh
(2, 2, 2,2,1200000), -- VietJet Air, Không có sẵn, TP Hồ Chí Minh - Đà Nẵng
(1, 1, 3,2,1300000), -- Vietnam Airlines, Có sẵn, Hà Nội - Đà Nẵng
(3, 1, 4,4,1100000), -- Bamboo Airways, Có sẵn, Đà Nẵng - Nha Trang
(2, 1, 5,5,2000000) -- VietJet Air, Có sẵn, Nha Trang - Phú Quốc

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
INSERT INTO ChiTietVe (MaVe, MaChuyenBay, NgayDi, NgayDen, MaHangGhe) Values
(1, 1, '2024-11-10', '2024-11-10', 1), -- Vé 1, Chuyến bay 1, Hạng ghế: Phổ thông
(2, 2, '2024-11-15', '2024-11-15', 1), -- Vé 2, Chuyến bay 2, Hạng ghế: Phổ thông
(3, 3, '2024-11-20', '2024-11-20', 2), -- Vé 3, Chuyến bay 3, Hạng ghế: Thương gia
(4, 4, '2024-11-25', '2024-11-25', 3), -- Vé 4, Chuyến bay 4, Hạng ghế: Hạng nhất
(5, 5, '2024-12-01', '2024-12-01', 4), -- Vé 5, Chuyến bay 5, Hạng ghế: Tiết kiệm
(6, 2, '2024-11-15', '2024-11-15', 2), -- Vé 6, Chuyến bay 2, Hạng ghế: Thương gia
(7, 3, '2024-11-20', '2024-11-20', 1), -- Vé 7, Chuyến bay 3, Hạng ghế: Phổ thông
(8, 4, '2024-11-25', '2024-11-25', 3), -- Vé 8, Chuyến bay 4, Hạng ghế: Hạng nhất
(9, 5, '2024-12-01', '2024-12-01', 4); -- Vé 9, Chuyến bay 5, Hạng ghế: Tiết kiệm

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
-- Tạo tài khoản khách hàng
CREATE PROCEDURE sp_CreateTaiKhoan
    @TenTaiKhoan NVARCHAR(50),
    @MatKhau NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    -- Kiểm tra xem tên tài khoản đã tồn tại chưa
    IF EXISTS (SELECT 1 FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan)
    BEGIN
        RAISERROR('Tên tài khoản đã tồn tại.', 16, 1);
        RETURN;
    END
    -- Chèn tài khoản mới
    INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau)
    VALUES (@TenTaiKhoan, @MatKhau);
END

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
    -- Cập nhật thông tin tài khoản trong bảng TAIKHOAN
    UPDATE TAIKHOAN
    SET MatKhau = @MatKhau
    WHERE TenTaiKhoan = @TenTaiKhoan;
   
END





-- Cập nhật thông tin khách



--//--

-- Function
-- Tra cứu mã tài khoản khi biết tên tài khoản


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



--//--
-- Cursor
-- Trả về hành khách thuộc khách hàng



--Minh
--Stored Proc ThemHoaDon
CREATE PROCEDURE sp_ThemHoaDon 
    @MaPhieuDat INT,
    @TongTien DECIMAL(18, 2) OUTPUT,  -- Tham số đầu ra để trả về tổng tiền
    @MaHoaDonMoi INT OUTPUT -- Tham số đầu ra để trả về mã hóa đơn vừa được thêm
AS
BEGIN
    -- Kiểm tra mã phiếu đặt hợp lệ
    IF NOT EXISTS (SELECT 1 FROM ChiTietPhieuDat WHERE MaPhieuDat = @MaPhieuDat)
    BEGIN
        RAISERROR(N'Mã phiếu đặt không tồn tại.', 16, 1);
        RETURN;
    END

    -- Gọi function tính tổng tiền và gán giá trị vào @TongTien
    SET @TongTien = dbo.func_TinhTongTien(@MaPhieuDat);

    BEGIN TRY
        -- Thêm mới một hóa đơn với tổng tiền đã tính được
        INSERT INTO HoaDon (MaPhieuDat, TongTien)
        VALUES (@MaPhieuDat, @TongTien);
        
        -- Gán giá trị mã hóa đơn mới tạo vào biến đầu ra
        SET @MaHoaDonMoi = SCOPE_IDENTITY();
    END TRY
    BEGIN CATCH
        RAISERROR(N'Không thể thêm hóa đơn.', 16, 1);
        RETURN;
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





--Stored proc Thêm mã giảm giá
CREATE PROCEDURE sp_ThemMaGiamGia
    @Code NVARCHAR(20),  -- Code của mã giảm giá
    @MucGiamGia DECIMAL(5, 2) -- Mức giảm giá (phần trăm, từ 0 đến 100)
AS
BEGIN
    -- Kiểm tra nếu mức giảm giá không hợp lệ
    IF @MucGiamGia < 0 OR @MucGiamGia > 100
    BEGIN
        RAISERROR(N'Mức giảm giá phải nằm trong khoảng từ 0 đến 100.', 16, 1);
        RETURN;
    END

    -- Thêm mã giảm giá vào bảng GiamGia
    INSERT INTO GiamGia (Code, MucGiamGia)
    VALUES (@Code, @MucGiamGia);

    -- Thông báo thành công
    PRINT N'Mã giảm giá đã được thêm thành công.';
END;



------------Test
DECLARE @Code NVARCHAR(20) = 'Friday';
DECLARE @MucGiamGia DECIMAL(18, 2) = 20.0; -- 20%

EXEC sp_ThemMaGiamGia
    @Code = @Code,
    @MucGiamGia = @MucGiamGia;




--Procedure Sửa Mã Giảm Giá
CREATE PROCEDURE sp_SuaMaGiamGia
    @MaGiamGia INT,             -- Mã giảm giá cần sửa
    @Code NVARCHAR(100),  -- Code của mã giảm giá
    @MucGiamGia DECIMAL(5, 2) -- Mức giảm giá (phần trăm, từ 0 đến 100)
AS
BEGIN
    -- Kiểm tra nếu mức giảm giá không hợp lệ
    IF @MucGiamGia < 0 OR @MucGiamGia > 100
    BEGIN
        RAISERROR(N'Mức giảm giá phải nằm trong khoảng từ 0 đến 100.', 16, 1);
        RETURN;
    END

    -- Kiểm tra xem mã giảm giá có tồn tại hay không
    IF NOT EXISTS (SELECT 1 FROM GiamGia WHERE MaGiamGia = @MaGiamGia)
    BEGIN
        RAISERROR(N'Mã giảm giá không tồn tại.', 16, 1);
        RETURN;
    END

    -- Cập nhật thông tin mã giảm giá
    UPDATE GiamGia
    SET 
        Code = @Code,
        MucGiamGia = @MucGiamGia
    WHERE MaGiamGia = @MaGiamGia;

    -- Thông báo thành công
    PRINT N'Mã giảm giá đã được cập nhật thành công.';
END;


-------Test
DECLARE @MaGiamGia INT = 7;  -- Mã giảm giá cần sửa
DECLARE @Code NVARCHAR(20) = N'Tết';
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
    -- Kiểm tra sự tồn tại của mã giảm giá
    IF NOT EXISTS (SELECT 1 FROM GiamGia WHERE MaGiamGia = @MaGiamGia)
    BEGIN
        RAISERROR(N'Mã giảm giá không tồn tại.', 16, 1);
        RETURN;
    END

    -- Xóa mã giảm giá
    DELETE FROM GiamGia
    WHERE MaGiamGia = @MaGiamGia;

    -- Thông báo thành công
    PRINT N'Mã giảm giá đã được xóa thành công.';
END;

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




------luân 
-----PROC---------------------
-------PROC TẠO PHIẾU ĐẶT

CREATE TYPE DanhSachVeType AS TABLE
(
    MaVe INT,
    MaChuyenBay INT
);

CREATE TYPE DanhSachTienIchType AS TABLE
(
    MaTienIch INT
);

CREATE PROCEDURE sp_TaoPhieuDat
    @MaKhachHang INT,
    @NgayDat DATE,
    @SoLuongHanhKhach INT,
    @DanhSachVe DanhSachVeType READONLY,
    @DanhSachTienIch DanhSachTienIchType READONLY -- Thêm tham số tiện ích
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra mã khách hàng có tồn tại
    IF NOT EXISTS (SELECT 1 FROM KhachHang WHERE MaKhachHang = @MaKhachHang)
    BEGIN
        RAISERROR(N'Khách hàng không tồn tại.', 16, 1);
        RETURN;
    END

    -- Kiểm tra số lượng hành khách phải lớn hơn 0
    IF @SoLuongHanhKhach <= 0
    BEGIN
        RAISERROR(N'Số lượng hành khách phải lớn hơn 0.', 16, 1);
        RETURN;
    END

    -- Gọi hàm kiểm tra số lượng vé có sẵn
    IF dbo.fn_KiemTraSoVe(@DanhSachVe, @SoLuongHanhKhach) = 0
    BEGIN
        RAISERROR(N'Không đủ vé có sẵn.', 16, 1);
        RETURN;
    END
  
    -- Tạo phiếu đặt
    DECLARE @MaPhieuDat INT;
    INSERT INTO PhieuDat (MaKhachHang, NgayDat, SoLuongHanhKhach)
    VALUES (@MaKhachHang, @NgayDat, @SoLuongHanhKhach);

    SET @MaPhieuDat = SCOPE_IDENTITY();

    -- Thêm chi tiết phiếu đặt
    INSERT INTO ChiTietPhieuDat (MaPhieuDat, MaVe)
    SELECT @MaPhieuDat, MaVe
    FROM @DanhSachVe;

    -- Kiểm tra và thêm tiện ích vào bảng DatTienIch nếu có tiện ích được chọn
    IF EXISTS (SELECT 1 FROM @DanhSachTienIch)
    BEGIN
        INSERT INTO DatTienIch (MaPhieuDat, MaTienIch)
        SELECT @MaPhieuDat, MaTienIch
        FROM @DanhSachTienIch;
    END

    PRINT N'Phiếu đặt, chi tiết phiếu đặt, và tiện ích (nếu có) đã được tạo thành công.';
END;

----câu lệnh thục thi
DECLARE @DanhSachVe DanhSachVeType;
DECLARE @DanhSachTienIch DanhSachTienIchType;
DECLARE @NgayDat DATE = GETDATE();  -- Lưu ngày hiện tại vào biến @NgayDat


-- Thêm các mã vé vào danh sách vé
INSERT INTO @DanhSachVe (MaVe, MaChuyenBay) VALUES (1, 1)

-- Thêm các mã tiện ích vào danh sách tiện ích (nếu có)

-- Gọi thủ tục sp_TaoPhieuDat
EXEC sp_TaoPhieuDat 
    @MaKhachHang = 1,
    @NgayDat = @NgayDat,  -- Sử dụng biến @NgayDat
    @SoLuongHanhKhach = 1,
    @DanhSachVe = @DanhSachVe,
    @DanhSachTienIch = @DanhSachTienIch;
	SELECT*FROM ve
-----------
------------PROC XÓA PHIẾU ĐẶT
CREATE PROCEDURE sp_XoaPhieuDat
    @MaPhieuDat INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra phiếu đặt có tồn tại trong bảng PhieuDat không
    IF NOT EXISTS (SELECT 1 FROM PhieuDat WHERE MaPhieuDat = @MaPhieuDat)
    BEGIN
        RAISERROR(N'Phiếu đặt không tồn tại.', 16, 1);
        RETURN;
    END

    -- Kiểm tra phiếu đặt có tồn tại trong bảng HoaDon không (Sử dụng function kiểm tra khóa ngoại)
    IF dbo.fn_KiemTraPhieuDatKhoaNgoaiHoaDon(@MaPhieuDat) = 1
    BEGIN
        RAISERROR(N'Không thể xóa phiếu đặt vì phiếu này đã được thanh toán trong hóa đơn.', 16, 1);
        RETURN;
    END

    -- Kiểm tra phiếu đặt đã đặt tiện ích hay chưa (Sử dụng function kiểm tra tiện ích)
    IF dbo.fn_KiemTraPhieuDatKhoaNgoaiDatTienIch(@MaPhieuDat) = 1
    BEGIN
        RAISERROR(N'Không thể xóa phiếu đặt vì phiếu này đã đặt tiện ích.', 16, 1);
        RETURN;
    END

    -- Xóa các bản ghi trong DatTienIch liên quan đến MaPhieuDat (nếu có tiện ích)
    DELETE FROM DatTienIch
    WHERE MaPhieuDat = @MaPhieuDat;

    -- Xóa các bản ghi trong ChiTietPhieuDat liên quan đến MaPhieuDat
    DELETE FROM ChiTietPhieuDat
    WHERE MaPhieuDat = @MaPhieuDat;

    -- Xóa bản ghi trong PhieuDat
    DELETE FROM PhieuDat
    WHERE MaPhieuDat = @MaPhieuDat;

    PRINT N'Phiếu đặt và các chi tiết liên quan đã được xóa thành công.';
END;
---
---CÂU LỆNH THƯCJ THI
EXEC sp_XoaPhieuDat @MaPhieuDat = 7; -- Thay thế 1 bằng mã phiếu đặt bạn muốn xóa
select*from ve

----------PROC SỬA PHIẾU ĐẶT
CREATE PROCEDURE sp_SuaPhieuDat
    @MaPhieuDat INT,
    @MaKhachHang INT,
    @NgayDat DATE,
    @SoLuongHanhKhach INT,
    @DanhSachVe DanhSachVeType READONLY,
    @DanhSachTienIch DanhSachTienIchType READONLY
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra phiếu đặt có tồn tại
    IF NOT EXISTS (SELECT 1 FROM PhieuDat WHERE MaPhieuDat = @MaPhieuDat)
    BEGIN
        RAISERROR(N'Phiếu đặt không tồn tại.', 16, 1);
        RETURN;
    END

    -- Kiểm tra khách hàng có tồn tại trong bảng KhachHang
    IF NOT EXISTS (SELECT 1 FROM KhachHang WHERE MaKhachHang = @MaKhachHang)
    BEGIN
        RAISERROR(N'Khách hàng không tồn tại.', 16, 1);
        RETURN;
    END

    -- Kiểm tra ngày đặt phải lớn hơn ngày hiện tại
    IF @NgayDat < GETDATE()
    BEGIN
        RAISERROR(N'Ngày đặt phải lớn hơn ngày hiện tại.', 16, 1);
        RETURN;
    END

    -- Kiểm tra số lượng hành khách phải lớn hơn 0
    IF @SoLuongHanhKhach <= 0
    BEGIN
        RAISERROR(N'Số lượng hành khách phải lớn hơn 0.', 16, 1);
        RETURN;
    END

    -- Kiểm tra vé có sẵn cho số lượng hành khách mới (khi tăng số lượng hành khách)
    DECLARE @CountVe INT;
    SELECT @CountVe = COUNT(*) 
    FROM @DanhSachVe dv
    JOIN Ve v ON dv.MaVe = v.MaVe
    JOIN TrangThaiVe ttv ON v.MaTTV = ttv.MaTTV
    WHERE ttv.TenTTV = N'Có sẵn'

    IF @CountVe < @SoLuongHanhKhach
    BEGIN
        RAISERROR(N'Không đủ vé có sẵn cho số lượng hành khách mới.', 16, 1);
        RETURN;
    END

    -- Cập nhật phiếu đặt
    UPDATE PhieuDat
    SET MaKhachHang = @MaKhachHang, NgayDat = @NgayDat, SoLuongHanhKhach = @SoLuongHanhKhach
    WHERE MaPhieuDat = @MaPhieuDat;

    -- Xử lý khi giảm số lượng hành khách (cắt bớt vé cũ nếu số lượng giảm)
    IF @SoLuongHanhKhach < (SELECT SoLuongHanhKhach FROM PhieuDat WHERE MaPhieuDat = @MaPhieuDat)
    BEGIN
        -- Cắt bớt vé cũ nếu số lượng hành khách giảm
        DECLARE @Diff INT = (SELECT SoLuongHanhKhach FROM PhieuDat WHERE MaPhieuDat = @MaPhieuDat) - @SoLuongHanhKhach;
        
        -- Xóa vé thừa từ ChiTietPhieuDat
        DELETE FROM ChiTietPhieuDat
        WHERE MaPhieuDat = @MaPhieuDat
        AND MaVe NOT IN (SELECT TOP (@Diff) MaVe FROM ChiTietPhieuDat WHERE MaPhieuDat = @MaPhieuDat ORDER BY MaVe DESC); 
        
        -- Xóa tiện ích thừa nếu số lượng hành khách giảm
        DELETE FROM DatTienIch
        WHERE MaPhieuDat = @MaPhieuDat
        AND MaTienIch NOT IN (SELECT TOP (@Diff) MaTienIch FROM DatTienIch WHERE MaPhieuDat = @MaPhieuDat ORDER BY MaTienIch DESC);
    END

    -- Cập nhật lại chi tiết phiếu đặt (thêm vé mới hoặc cập nhật vé cũ)
    -- Xóa hết các vé cũ
    DELETE FROM ChiTietPhieuDat WHERE MaPhieuDat = @MaPhieuDat;

    -- Thêm các vé mới từ danh sách đã chọn
    INSERT INTO ChiTietPhieuDat (MaPhieuDat, MaVe)
    SELECT @MaPhieuDat, MaVe
    FROM @DanhSachVe;

    -- Nếu có tiện ích, thêm vào bảng DatTienIch
    IF EXISTS (SELECT 1 FROM @DanhSachTienIch)
    BEGIN
        INSERT INTO DatTienIch (MaPhieuDat, MaTienIch)
        SELECT @MaPhieuDat, MaTienIch
        FROM @DanhSachTienIch;
    END

    RAISERROR(N'Phiếu đặt và chi tiết phiếu đặt đã được cập nhật thành công.', 0, 1);
END;
SELECT*FROM PHIEUDAT
SELECT*FROM VE
----CÂU LỆNH THƯC THI
	DECLARE @DanhSachVe DanhSachVeType;
DECLARE @DanhSachTienIch DanhSachTienIchType;

-- Giả sử bạn đã có một phiếu đặt với mã 1 và muốn tăng số lượng hành khách lên 3
-- Chọn lại vé và tiện ích cho phiếu đặt

-- Danh sách vé mới (ví dụ vé 1, vé 2 và vé 3 cho chuyến bay)
INSERT INTO @DanhSachVe (MaVe, MaChuyenBay)
VALUES 
    (1, 1),  -- Vé 1 cho chuyến bay 1
    (5, 1),  -- Vé 2 cho chuyến bay 1
    (6, 1);  -- Vé 3 cho chuyến bay 1

-- Danh sách tiện ích (ví dụ tiện ích 1 và tiện ích 2)
INSERT INTO @DanhSachTienIch (MaTienIch)
VALUES 
    (1),  -- Tiện ích 1
    (2);  -- Tiện ích 2

-- Thực thi thủ tục với các tham số đầu vào
-- Tăng số lượng hành khách lên 3
EXEC sp_SuaPhieuDat
    @MaPhieuDat = 6,      -- Mã phiếu đặt cần sửa
    @MaKhachHang = 1,     -- Mã khách hàng
    @NgayDat = '2024-11-14', -- Ngày đặt mới
    @SoLuongHanhKhach = 1, -- Tăng số lượng hành khách lên 3
    @DanhSachVe = @DanhSachVe,    -- Danh sách vé mới
    @DanhSachTienIch = @DanhSachTienIch; -- Danh sách tiện ích (nếu có)


	-------proc tạo vé
	CREATE PROCEDURE sp_TaoVe
    @MaHK INT,
    @MaChuyenBay INT,
    @NgayDi DATE,
    @NgayDen DATE,
    @MaHangGhe INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra hành khách có tồn tại hay không nếu MaHK không NULL
    IF @MaHK IS NOT NULL AND NOT EXISTS (SELECT 1 FROM HanhKhach WHERE MaHanhKhach = @MaHK)
    BEGIN
        RAISERROR(N'Hành khách không tồn tại.', 16, 1);
        RETURN;
    END

    -- Kiểm tra mã chuyến bay có tồn tại không
    IF NOT EXISTS (SELECT 1 FROM ChuyenBay WHERE MaChuyenBay = @MaChuyenBay)
    BEGIN
        RAISERROR(N'Mã chuyến bay không tồn tại.', 16, 1);
        RETURN;
    END

    -- Kiểm tra mã hạng ghế có tồn tại không
    IF NOT EXISTS (SELECT 1 FROM HangGhe WHERE MaHangGhe = @MaHangGhe)
    BEGIN
        RAISERROR(N'Mã hạng ghế không tồn tại.', 16, 1);
        RETURN;
    END

    -- Kiểm tra ngày đi và ngày đến
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

    -- Tạo vé mới trong bảng Ve, tự động gán MaTTV = 2 (Đã đặt)
    DECLARE @MaVe INT;
    INSERT INTO Ve (MaHK, MaTTV)
    VALUES (@MaHK, 1); 

    SET @MaVe = SCOPE_IDENTITY();

    -- Thêm chi tiết vé vào bảng ChiTietVe
    INSERT INTO ChiTietVe (MaVe, MaChuyenBay, NgayDi, NgayDen, MaHangGhe)
    VALUES (@MaVe, @MaChuyenBay, @NgayDi, @NgayDen, @MaHangGhe);

    PRINT N'Vé và chi tiết vé đã được tạo thành công .';
END;


-- Trường hợp có hành khách (MaHK không NULL)
EXEC sp_TaoVe 
    @MaHK = 5,            -- Mã hành khách (có thể thay đổi theo nhu cầu)
    @MaChuyenBay = 2,     -- Mã chuyến bay (có thể thay đổi theo nhu cầu)
    @NgayDi = '2024-12-01', -- Ngày đi (có thể thay đổi theo nhu cầu)
    @NgayDen = '2024-12-01',-- Ngày đến (có thể thay đổi theo nhu cầu)
    @MaHangGhe = 2;         -- Mã hạng ghế (có thể thay đổi theo nhu cầu)
	select*from ve
	select*from ChiTietVe
-- Trường hợp không có hành khách (MaHK NULL)
EXEC sp_TaoVe 
    @MaHK = NULL,           -- Không có hành khách
    @MaChuyenBay = 1,     -- Mã chuyến bay
    @NgayDi = '2024-12-01', -- Ngày đi
    @NgayDen = '2024-12-01',-- Ngày đến
    @MaHangGhe = 2;         -- Mã hạng ghế



	------proc xóa vé
CREATE PROCEDURE sp_XoaVe
    @MaVe INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra vé có đang được sử dụng trong phiếu đặt không
    IF dbo.fn_KiemTraVeTrongPhieuDat(@MaVe) = 1
    BEGIN
        RAISERROR(N'Vé này đang được sử dụng trong phiếu đặt, không thể xóa.', 16, 1);
        RETURN;
    END

    -- Kiểm tra vé có đang được sử dụng trong ChiTietVe không
    IF dbo.fn_KiemTraVeTrongChiTietVe(@MaVe) = 1
    BEGIN
        RAISERROR(N'Vé này đang được tham chiếu trong ChiTietVe, không thể xóa.', 16, 1);
        RETURN;
    END

    -- Xóa vé trong bảng Ve
    DELETE FROM Ve
    WHERE MaVe = @MaVe;

    -- Xóa chi tiết vé trong bảng ChiTietVe
    DELETE FROM ChiTietVe
    WHERE MaVe = @MaVe;

    PRINT N'Vé và chi tiết vé đã được xóa thành công.';
END;

---câu lệnh thực thi
-- Ví dụ xóa vé có MaVe = 1
EXEC sp_XoaVe @MaVe = 10;

-- Ví dụ xóa vé có MaVe = 2
EXEC sp_XoaVe @MaVe = 2;
select*from chitietve
select*from ve
select*from chitietphieudat


---proc sửa vé
CREATE PROCEDURE sp_SuaVe
    @MaVe INT,         -- Mã vé cần sửa (không sửa)
    @MaHK INT,         -- Mã hành khách cần sửa
    @MaTTV INT         -- Mã trạng thái vé cần sửa (1: Có sẵn, 2: Đã đặt, 3: Đã sử dụng)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem mã vé có tồn tại trong bảng Ve không
    IF NOT EXISTS (SELECT 1 FROM Ve WHERE MaVe = @MaVe)
    BEGIN
        RAISERROR(N'Vé không tồn tại.', 16, 1);
        RETURN;
    END

    -- Kiểm tra xem mã hành khách có tồn tại trong bảng HanhKhach không
    IF NOT EXISTS (SELECT 1 FROM HanhKhach WHERE MaHanhKhach = @MaHK)
    BEGIN
        RAISERROR(N'Hành khách không tồn tại.', 16, 1);
        RETURN;
    END

    -- Kiểm tra xem mã trạng thái vé có hợp lệ không (1: Có sẵn, 2: Đã đặt, 3: Đã sử dụng)
    IF @MaTTV NOT IN (1, 2, 3)
    BEGIN
        RAISERROR(N'Mã trạng thái vé không hợp lệ.', 16, 1);
        RETURN;
    END

    -- Cập nhật vé
    UPDATE Ve
    SET MaHanhKhach = @MaHK, MaTTV = @MaTTV
    WHERE MaVe = @MaVe;

    PRINT N'Vé đã được cập nhật thành công.';
END;
--câu lệnh
EXEC sp_SuaVe
    @MaVe = 1,         -- Mã vé cần sửa
    @MaHK = 2,         -- Mã hành khách cần sửa
    @MaTTV = 1;        -- Mã trạng thái vé (1: Có sẵn)


----proc sua chi tiet ve
CREATE PROCEDURE sp_SuaChiTietVe
    @MaVe INT,            -- Mã vé cần sửa (không sửa)
    @MaChuyenBay INT,     -- Mã chuyến bay cần sửa
    @NgayDi DATE,         -- Ngày đi mới
    @NgayDen DATE,        -- Ngày đến mới
    @MaHangGhe INT        -- Mã hạng ghế mới
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem mã vé có tồn tại trong bảng ChiTietVe không
    IF NOT EXISTS (SELECT 1 FROM ChiTietVe WHERE MaVe = @MaVe)
    BEGIN
        RAISERROR(N'Chi tiết vé không tồn tại.', 16, 1);
        RETURN;
    END

    -- Kiểm tra xem mã chuyến bay có tồn tại trong bảng ChuyenBay không
    IF NOT EXISTS (SELECT 1 FROM ChuyenBay WHERE MaChuyenBay = @MaChuyenBay)
    BEGIN
        RAISERROR(N'Mã chuyến bay không tồn tại.', 16, 1);
        RETURN;
    END

    -- Kiểm tra ngày đi phải nhỏ hơn hoặc bằng ngày đến
    IF @NgayDi > @NgayDen
    BEGIN
        RAISERROR(N'Ngày đi phải nhỏ hơn hoặc bằng ngày đến.', 16, 1);
        RETURN;
    END

    -- Kiểm tra mã hạng ghế có tồn tại trong bảng HangGhe không
    IF NOT EXISTS (SELECT 1 FROM HangGhe WHERE MaHangGhe = @MaHangGhe)
    BEGIN
        RAISERROR(N'Mã hạng ghế không tồn tại.', 16, 1);
        RETURN;
    END

    -- Cập nhật chi tiết vé
    UPDATE ChiTietVe
    SET MaChuyenBay = @MaChuyenBay, NgayDi = @NgayDi, NgayDen = @NgayDen, MaHangGhe = @MaHangGhe
    WHERE MaVe = @MaVe;

    PRINT N'Chi tiết vé đã được cập nhật thành công.';
END;
---câuu lệnh thực thi
EXEC sp_SuaChiTietVe
    @MaVe = 1,            -- Mã vé cần sửa
    @MaChuyenBay = 2,     -- Mã chuyến bay mới
    @NgayDi = '2024-11-15', -- Ngày đi mới
    @NgayDen = '2024-11-15', -- Ngày đến mới
    @MaHangGhe = 2;        -- Mã hạng ghế mới

--------FUNCTION--------------------
-------KIỂM TRA SỐ VÉ CÓ SẲN
CREATE FUNCTION fn_KiemTraSoVe 
(
    @DanhSachVe DanhSachVeType READONLY,
    @SoLuongHanhKhach INT
)
RETURNS BIT
AS
BEGIN
    DECLARE @SoLuongVeHopLe INT;

    -- Đếm số lượng vé có mã trạng thái là 1 trong danh sách vé
    SELECT @SoLuongVeHopLe = COUNT(*)
    FROM Ve
    WHERE MaVe IN (SELECT MaVe FROM @DanhSachVe)
      AND MaTTV = 1;

    -- Trả về 1 nếu đủ vé, ngược lại trả về 0
    RETURN CASE WHEN @SoLuongVeHopLe >= @SoLuongHanhKhach THEN 1 ELSE 0 END;
END;

----KIỂM TRA PHIEUDAT CÓ TỒN TẠI Ở DATTIENICH HAY KHÔNG
CREATE FUNCTION fn_KiemTraPhieuDatKhoaNgoaiDatTienIch
(
    @MaPhieuDat INT
)
RETURNS BIT
AS
BEGIN
    DECLARE @Exists BIT = 0;

    IF EXISTS (SELECT 1 FROM DatTienIch WHERE MaPhieuDat = @MaPhieuDat)
    BEGIN
        SET @Exists = 1;
    END

    RETURN @Exists;
END;

----KIỂM TRA MÃ PHIẾU ĐẶT CÓ TỒN TẠI TRONG HÓA ĐƠN HAY KHONG
CREATE FUNCTION dbo.fn_KiemTraPhieuDatKhoaNgoaiHoaDon
(
    @MaPhieuDat INT
)
RETURNS BIT
AS
BEGIN
    DECLARE @Result BIT;

    -- Kiểm tra nếu MaPhieuDat tồn tại trong bảng HoaDon
    IF EXISTS (SELECT 1 FROM HoaDon WHERE MaPhieuDat = @MaPhieuDat)
    BEGIN
        SET @Result = 1; -- Phiếu đặt đã được sử dụng trong hóa đơn (là khóa ngoại)
    END
    ELSE
    BEGIN
        SET @Result = 0; -- Phiếu đặt chưa được sử dụng trong hóa đơn
    END

    RETURN @Result;
END;

-----kiểm tra vé có được đặt hông
CREATE FUNCTION fn_KiemTraVeTrongPhieuDat
(
    @MaVe INT
)
RETURNS BIT
AS
BEGIN
    DECLARE @KetQua BIT;

    -- Kiểm tra xem vé có đang được sử dụng trong Phiếu Đặt không
    IF EXISTS (SELECT 1 FROM ChiTietPhieuDat WHERE MaVe = @MaVe)
    BEGIN
        SET @KetQua = 1;  -- Vé đang được sử dụng
    END
    ELSE
    BEGIN
        SET @KetQua = 0;  -- Vé không được sử dụng
    END

    RETURN @KetQua;
END;
---kiểm tra vé có chitietve hay khong
CREATE FUNCTION dbo.fn_KiemTraVeTrongChiTietVe
(
    @MaVe INT
)
RETURNS BIT
AS
BEGIN
    DECLARE @IsUsed BIT;

    -- Kiểm tra xem vé có đang được tham chiếu trong bảng ChiTietVe không
    IF EXISTS (SELECT 1 FROM ChiTietVe WHERE MaVe = @MaVe)
    BEGIN
        SET @IsUsed = 1; -- Vé đang được sử dụng trong ChiTietVe
    END
    ELSE
    BEGIN
        SET @IsUsed = 0; -- Vé không được sử dụng trong ChiTietVe
    END

    RETURN @IsUsed;
END;

----------------TRIGGER---------------
--CẬP NHẬT TRẠNG THÁI PHIẾU ĐẶT 
CREATE TRIGGER trg_CapNhatTrangThaiVe
ON ChiTietPhieuDat
AFTER INSERT, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Cập nhật trạng thái MaTTV khi vé được thêm vào (đặt vé)
    IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
        UPDATE Ve
        SET MaTTV = 2
        WHERE MaVe IN (SELECT MaVe FROM inserted);
    END

    -- Cập nhật trạng thái MaTTV khi vé bị xóa
    IF EXISTS (SELECT 1 FROM deleted)
    BEGIN
        UPDATE Ve
        SET MaTTV = 1
        WHERE MaVe IN (SELECT MaVe FROM deleted);
    END

    PRINT N'MaTTV đã được cập nhật thành công cho các vé được thêm hoặc xóa.';
END;




