CREATE DATABASE QuanLyBanVeMayBay
USE QuanLyBanVeMayBay

-------------------
use master
DROP DATABASE QuanLyBanVeMayBay
-------------------

CREATE TABLE TaiKhoan (
    MaTaiKhoan INT IDENTITY(1,1) PRIMARY KEY,
    TenTaiKhoan NVARCHAR(50) UNIQUE, -- Đảm bảo tên tài khoản là duy nhất
    MatKhau NVARCHAR(100)
);

CREATE TABLE KhachHang (
    MaKhachHang INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100),
    DiaChi NVARCHAR(255),
    Email NVARCHAR(100),
    NgaySinh DATE CHECK (NgaySinh <= GETDATE()), -- Kiểm tra ngày sinh nhỏ hơn hoặc bằng ngày hiện tại
    SoDienThoai NVARCHAR(20) UNIQUE, -- Đảm bảo số điện thoại là duy nhất
    MaTaiKhoan INT,
    CONSTRAINT FK_KHACHHANG_TAIKHOAN FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan)
);

CREATE TABLE HanhKhach (
    MaHanhKhach INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100),
    DiaChi NVARCHAR(255),
    GioiTinh NVARCHAR(10),
    QuocTich NVARCHAR(50),
    NgaySinh DATE CHECK (NgaySinh <= GETDATE()), -- Kiểm tra ngày sinh nhỏ hơn hoặc bằng ngày hiện tại
    SoDienThoai NVARCHAR(20) UNIQUE, -- Đảm bảo số điện thoại là duy nhất
    Email NVARCHAR(100),
    CCCD_Passport NVARCHAR(20) UNIQUE -- Đảm bảo CCCD/Passport là duy nhất
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

CREATE TABLE ChuyenBay (
    MaChuyenBay INT IDENTITY(1,1) PRIMARY KEY,
    MaHangHangKhong INT,
    MaTrangThaiChuyenBay INT,
    MaLoTrinh INT,
	GiaBay MONEY,
    CONSTRAINT FK_CHUYENBAY_SANBAY FOREIGN KEY (MaLoTrinh) REFERENCES LoTrinh(MaLoTrinh),
    CONSTRAINT FK_CHUYENBAY_HHK FOREIGN KEY (MaHangHangKhong) REFERENCES HangHangKhong(MaHangHangKhong),
    CONSTRAINT FK_CHUYENBAY_TRANGTHAI FOREIGN KEY (MaTrangThaiChuyenBay) REFERENCES TrangThaiChuyenBay(MaTrangThaiChuyenBay)
);

CREATE TABLE HangGhe (
    MaHangGhe INT IDENTITY(1,1) PRIMARY KEY,
    TenHangGhe NVARCHAR(50),
);

CREATE TABLE GiaHangGhe (
    MaHangGhe INT PRIMARY KEY,
    Gia DECIMAL(18, 2) CHECK (Gia > 0), -- Giá phải lớn hơn 0
    CONSTRAINT FK_HANGGHE_GIA FOREIGN KEY (MaHangGhe) REFERENCES HangGhe(MaHangGhe)
);

CREATE TABLE TrangThaiVe (
   MaTTV INT IDENTITY(1,1),
   TenTTV nvarchar(20),
   CONSTRAINT PK_TTV PRIMARY KEY (MATTV)
);

CREATE TABLE Ve (
    MaVe INT IDENTITY(1,1) PRIMARY KEY,
	MaHK INT NOT NULL,
	MaTTV INT NOT NULL,
	CONSTRAINT FK_VEMAYBAY_TRANGTHAIVE FOREIGN KEY (MaTTV) REFERENCES TrangThaiVe(MaTTV),
	CONSTRAINT FK_VEMAYBAY_HANHKHACH FOREIGN KEY (MaHK) REFERENCES HANHKHACH(MaHanhKhach)
);

CREATE TABLE ChiTietVe (
	MaVe INT,
	MaChuyenBay INT,
    NgayDi DATE,
    NgayDen DATE,
	MaHangGhe int,
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
(N'Minh123', N'0123456789'), 
(N'Khoa345', N'963852741'),
(N'Duy678', N'147258369'),
(N'Luân901', N'987654321'),
(N'Đăng666', N'123456789')

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
INSERT INTO HanhKhach (HoTen, DiaChi, GioiTinh, QuocTich, NgaySinh, SoDienThoai, Email, CCCD_Passport) VALUES 
(N'Nguyễn Thị Xuân', N'Hà Nội', N'Nữ', N'Việt Nam', '1993-02-14', N'0126456790', N'nguyenthixuan@gmail.com', N'123456789'),
(N'Trần Văn Yên', N'TP Hồ Chí Minh', N'Nam', N'Việt Nam', '1989-10-01', N'0987654322', N'tranvanyen@gmail.com', N'234567890'),
(N'Lê Văn Thọ', N'Đà Nẵng', N'Nam', N'Việt Nam', '1990-07-07', N'0123456788', N'levantho@gmail.com', N'345678901'),
(N'Nguyễn Văn Mạnh', N'Huế', N'Nam', N'Việt Nam', '1986-12-12', N'0987654319', N'nguyenvanmanh@gmail.com', N'456789012'),
(N'Phạm Thị Quỳnh Như', N'Cần Thơ', N'Nữ', N'Việt Nam', '1995-04-05', N'0123456792', N'phamthiquynhnhu@gmail.com', N'567890123')

--Bảng TrangThaiChuyenBay
INSERT INTO TrangThaiChuyenBay (TenTrangThaiChuyenBay) VALUES
(N'Có sẵn'),
(N'Không có sẵn')

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
INSERT INTO ChuyenBay (MaHangHangKhong, MaTrangThaiChuyenBay, MaLoTrinh, GiaBay) VALUES 
(1, 1, 1, 1500000), -- Vietnam Airlines, Có sẵn, Hà Nội - TP Hồ Chí Minh
(2, 2, 2, 1200000), -- VietJet Air, Không có sẵn, TP Hồ Chí Minh - Đà Nẵng
(1, 1, 3, 1300000), -- Vietnam Airlines, Có sẵn, Hà Nội - Đà Nẵng
(3, 1, 4, 1100000), -- Bamboo Airways, Có sẵn, Đà Nẵng - Nha Trang
(2, 1, 5, 2000000) -- VietJet Air, Có sẵn, Nha Trang - Phú Quốc

--Bảng HangGhe
INSERT INTO HangGhe (TenHangGhe) VALUES
(N'Phổ thông'),
(N'Thương gia'),
(N'Hạng nhất'),
(N'Tiết kiệm')

--Bảng GiaHangGhe
INSERT INTO GiaHangGhe (MaHangGhe, Gia) VALUES 
(1, 150000), -- Phổ thông
(2, 500000), -- Thương gia
(3, 1000000), -- Hạng nhất
(4, 120000) -- Tiết kiệm

--Bảng Ve
INSERT INTO Ve (MaHK, MaTTV) VALUES 
(1, 1), -- Hành khách 1, Trạng thái vé: Có sẵn
(2, 2), -- Hành khách 2, Trạng thái vé: Đã đặt
(3, 1), -- Hành khách 3, Trạng thái vé: Có sẵn
(4, 3), -- Hành khách 4, Trạng thái vé: Đã sử dụng
(5, 1) -- Hành khách 5, Trạng thái vé: Có sẵn

--Bảng ChiTietVe
INSERT INTO ChiTietVe (MaVe, MaChuyenBay, NgayDi, NgayDen, MaHangGhe) Values
(1, 1, '2024-11-10', '2024-11-10', 1), -- Vé 1, Chuyến bay 1, Hạng ghế: Phổ thông
(2, 2, '2024-11-15', '2024-11-15', 2), -- Vé 2, Chuyến bay 2, Hạng ghế: Thương gia
(3, 3, '2024-11-20', '2024-11-20', 1), -- Vé 3, Chuyến bay 3, Hạng ghế: Phổ thông
(4, 4, '2024-11-25', '2024-11-25', 3), -- Vé 4, Chuyến bay 4, Hạng ghế: Hạng nhất
(5, 5, '2024-12-01', '2024-12-01', 4) -- Vé 5, Chuyến bay 5, Hạng ghế: Tiết kiệm

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
(3, 5) -- Phiếu đặt 3, Vé 5

--Bảng HoaDon
INSERT INTO HoaDon (MaPhieuDat, TongTien) VALUES 
(1, 3000000), -- Phiếu đặt 1, Tổng tiền: 3,000,000 VND
(2, 1500000), -- Phiếu đặt 2, Tổng tiền: 1,500,000 VND
(3, 4500000), -- Phiếu đặt 3, Tổng tiền: 4,500,000 VND
(4, 2000000), -- Phiếu đặt 4, Tổng tiền: 2,000,000 VND
(5, 3500000) -- Phiếu đặt 5, Tổng tiền: 3,500,000 VND

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
