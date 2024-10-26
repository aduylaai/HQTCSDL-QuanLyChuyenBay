CREATE DATABASE QuanLyBanVeMayBay
USE QuanLyBanVeMayBay
-- NOTE DATABASE --
-- NHỚ DÙNG CHECK, DEFAULT, UNIQUE THEO NOTE TRONG TỪNG CÁI
-- AE XÓA CMT CỦA DUY MỖI KHI XONG NHA
-------------------

CREATE TABLE TaiKhoan (
    MaTaiKhoan INT IDENTITY(1,1) PRIMARY KEY,
    TenTaiKhoan NVARCHAR(50), -- CHO KHUA NAY UNIQUE
    MatKhau NVARCHAR(100),
);

CREATE TABLE KhachHang (
    MaKhachHang INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100),
    DiaChi NVARCHAR(255),
    Email NVARCHAR(100),
    NgaySinh DATE,
	SoDienThoai NVARCHAR(20),
    MaTaiKhoan INT,
    CONSTRAINT FK_KHACHHANG_TAIKHOAN FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan)
);

CREATE TABLE HanhKhach (
    MaHanhKhach INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100),
    DiaChi NVARCHAR(255),
	GioiTinh NVARCHAR(10),
    QuocTich NVARCHAR(50),
    NgaySinh DATE,
	SoDienThoai NVARCHAR(20),
    Email NVARCHAR(100),
    CCCD_Passport NVARCHAR(20)
);

CREATE TABLE SanBay (
    MaSanBay INT IDENTITY(1,1) PRIMARY KEY,
    TenSanBay NVARCHAR(100),
    TenThanhPho NVARCHAR(100),
    VietTatSanBay NVARCHAR(10) -- ĐÔI TÊN HỢP LÍ HƠN, NÀO NGHĨ RA DUY NÓI. CHO KHỨA NÀY UNIQUE
);

CREATE TABLE HangHangKhong (
    MaHangHangKhong INT IDENTITY(1,1) PRIMARY KEY,      
    TenHangHangKhong NVARCHAR(100) NOT NULL             
);

CREATE TABLE ChuyenBay (
    MaChuyenBay INT IDENTITY(1,1) PRIMARY KEY,
	MaHangHangKhong INT,
    MaSanBayDi INT,
    MaSanBayDen INT,
    DiemDi NVARCHAR(100), -- DOI THANH 1 BANG MOI GIONG MASANBAY
    DiemDen NVARCHAR(100),
    TrangThai NVARCHAR(50), -- DOI THANH 1 BANG MOI KIEU TRANGTHAICHUYENBAY(MaTTCB, TenTTCB) --> Có các trạng thái như Available, Unavail,...
    CONSTRAINT FK_CHUYENBAY_SANBAY_DI FOREIGN KEY (MaSanBayDi) REFERENCES SanBay(MaSanBay),
    CONSTRAINT FK_CHUYENBAY_SANBAY_TOI FOREIGN KEY (MaSanBayDen) REFERENCES SanBay(MaSanBay),
	CONSTRAINT FK_CHUYENBAY_HHK FOREIGN KEY (MaHangHangKhong) REFERENCES HangHangKhong(MaHangHangKhong)
);

CREATE TABLE VeMayBay (
    MaVe INT IDENTITY(1,1) PRIMARY KEY,
    MaChuyenBay INT,
    NgayDi DATE,
    NgayDen DATE,
    TrangThai NVARCHAR(50),
    CONSTRAINT FK_VEMAYBAY_CHUYENBAY FOREIGN KEY (MaChuyenBay) REFERENCES ChuyenBay(MaChuyenBay)
);

CREATE TABLE HangGhe (
    MaHangGhe INT IDENTITY(1,1) PRIMARY KEY,       
    TenHangGhe NVARCHAR(50),                       
    MaVe INT,                                 
    CONSTRAINT FK_HANGGHE_VE FOREIGN KEY (MaVe) REFERENCES VeMayBay(MaVe),
                              
);

CREATE TABLE GiaHangGhe (
    MaHangGhe INT  PRIMARY KEY,       
    Gia DECIMAL(18, 2),
    CONSTRAINT FK_HANGGHE_GIA FOREIGN KEY (MaHangGhe) REFERENCES HangGhe(MaHangGhe)
	
);
CREATE TABLE PhieuDatVe (
    MaPhieuDat INT IDENTITY(1,1) PRIMARY KEY,
    MaKhachHang INT,
    NgayDat DATE,
    SoLuongHanhKhach INT,
    CONSTRAINT FK_PHIEUDATVE_KHACHHANG FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);

CREATE TABLE ChiTietDatVe (
    MaPhieuDat INT,
    MaVe INT,
    MaHanhKhach INT,
    CONSTRAINT PK_CHITIETDATVE PRIMARY KEY (MaPhieuDat, MaVe, MaHanhKhach),
    CONSTRAINT FK_CHITIETDATVE_PHIEUDATVE FOREIGN KEY (MaPhieuDat) REFERENCES PhieuDatVe(MaPhieuDat),
    CONSTRAINT FK_CHITIETDATVE_VEMAYBAY FOREIGN KEY (MaVe) REFERENCES VeMayBay(MaVe),
    CONSTRAINT FK_CHITIETDATVE_HANHKHACH FOREIGN KEY (MaHanhKhach) REFERENCES HanhKhach(MaHanhKhach)
);

CREATE TABLE HoaDon ( -- HOA DON CHUA CO LIEN KET VOI PHIEU DAT LUAN OI T_T
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    MaPhieuDat INT,
    TongTien DECIMAL(18, 2),
    CONSTRAINT FK_HOADON_PHIEUDATVE FOREIGN KEY (MaPhieuDat) REFERENCES PhieuDatVe(MaPhieuDat)
);

CREATE TABLE GiamGia (
    MaGiamGia INT IDENTITY(1,1) PRIMARY KEY,
    Code NVARCHAR(20),
    MucGiamGia DECIMAL(18, 2)
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
    GiaTienIch DECIMAL(18, 2)
);

CREATE TABLE PhieuDat_TienIch (
    MaPhieuDat INT,
    MaTienIch INT,
    CONSTRAINT PK_PD_TI PRIMARY KEY (MaPhieuDat, MaTienIch),
    CONSTRAINT FK_PD_TI_PHIEUDATVE FOREIGN KEY (MaPhieuDat) REFERENCES PhieuDatVe(MaPhieuDat),
    CONSTRAINT FK_PD_TI_TIENICH FOREIGN KEY (MaTienIch) REFERENCES TienIch(MaTienIch)
);

INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau) VALUES 
('user1', 'password123'),
('user2', 'password456'),
('user3', 'password789'),
('user4', 'passwordabc'),
('user5', 'passwordxyz')

INSERT INTO KhachHang (HoTen, DiaChi, Email, NgaySinh, SoDienThoai, MaTaiKhoan) VALUES 
('Nguyen Van A', '123 Le Loi, Ha Noi', 'a.nguyen@example.com', '1985-05-20', '0901234567', 1),
('Tran Thi B', '456 Nguyen Trai, Da Nang', 'b.tran@example.com', '1990-08-12', '0912345678', 2),
('Le Van C', '789 Tran Phu, Ho Chi Minh', 'c.le@example.com', '1992-02-22', '0923456789', 3),
('Pham Thi D', '12 Hai Ba Trung, Hue', 'd.pham@example.com', '1988-11-10', '0934567890', 4),
('Vo Van E', '34 Le Duan, Can Tho', 'e.vo@example.com', '1995-07-15', '0945678901', 5)

INSERT INTO HanhKhach (HoTen, DiaChi, GioiTinh, QuocTich, NgaySinh, SoDienThoai, Email, CCCD_Passport)  VALUES 
('Nguyen Thi X', '123 Tran Hung Dao, Ha Noi', 'Female', 'Vietnam', '1993-03-12', '0902123456', 'x.nguyen@example.com', '123456789'),
('Tran Van Y', '456 Le Thanh Ton, Da Nang', 'Male', 'Vietnam', '1987-09-25', '0913123456', 'y.tran@example.com', '987654321'),
('Le Thi Z', '789 Pasteur, Ho Chi Minh', 'Female', 'Vietnam', '1991-12-05', '0924123456', 'z.le@example.com', '111222333'),
('Do Van M', '12 Bach Dang, Hai Phong', 'Male', 'Vietnam', '1994-01-18', '0935123456', 'm.do@example.com', '444555666'),
('Hoang Thi N', '34 Ly Tu Trong, Hue', 'Female', 'Vietnam', '1989-05-30', '0946123456', 'n.hoang@example.com', '777888999')

INSERT INTO SanBay (TenSanBay, TenThanhPho, VietTatSanBay) VALUES 
('Noi Bai International Airport', 'Ha Noi', 'HAN'),
('Tan Son Nhat International Airport', 'Ho Chi Minh', 'SGN'),
('Da Nang International Airport', 'Da Nang', 'DAD'),
('Cam Ranh International Airport', 'Khanh Hoa', 'CXR'),
('Phu Quoc International Airport', 'Kien Giang', 'PQC')

INSERT INTO HangHangKhong (TenHangHangKhong) VALUES 
('Vietnam Airlines'),
('VietJet Air'),
('Bamboo Airways'),
('Jetstar Pacific'),
('AirAsia')

INSERT INTO ChuyenBay (MaHangHangKhong, MaSanBayDi, MaSanBayDen, DiemDi, DiemDen, TrangThai) VALUES 
(1, 1, 2, 'Ha Noi', 'Ho Chi Minh', 'Scheduled'),
(2, 2, 3, 'Ho Chi Minh', 'Da Nang', 'Delayed'),
(3, 3, 4, 'Da Nang', 'Khanh Hoa', 'On Time'),
(4, 4, 1, 'Khanh Hoa', 'Ha Noi', 'Cancelled'),
(5, 5, 2, 'Phu Quoc', 'Ho Chi Minh', 'On Time')

INSERT INTO VeMayBay (MaChuyenBay, NgayDi, NgayDen, TrangThai) VALUES 
(1, '2024-11-01', '2024-11-01', 'Available'),
(2, '2024-11-02', '2024-11-02', 'Sold'),
(3, '2024-11-03', '2024-11-03', 'Reserved'),
(4, '2024-11-04', '2024-11-04', 'Available'),
(5, '2024-11-05', '2024-11-05', 'Available')

INSERT INTO HangGhe (TenHangGhe, MaVe) VALUES -- KIEM TRA LAI DU LIEU HANG GHE
('Economy', 1),
('Business', 2),
('First Class', 3),
('Economy', 4),
('Business', 5)

INSERT INTO GiaHangGhe (MaHangGhe, Gia) VALUES 
(1, 500000),
(2, 1500000),
(3, 2500000),
(4, 600000),
(5, 1700000)

INSERT INTO PhieuDatVe (MaKhachHang, NgayDat, SoLuongHanhKhach) VALUES 
(1, '2024-10-15', 3),
(2, '2024-10-16', 2),
(3, '2024-10-17', 4),
(4, '2024-10-18', 1),
(5, '2024-10-19', 5)

INSERT INTO ChiTietDatVe (MaPhieuDat, MaVe, MaHanhKhach) VALUES 
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 4),
(5, 5, 5)

INSERT INTO HoaDon (MaPhieuDat, TongTien) VALUES 
(1, 1500000),
(2, 3000000),
(3, 4500000),
(4, 600000),
(5, 7500000)

INSERT INTO GiamGia (Code, MucGiamGia) VALUES 
('SALE10', 10.0),
('SALE20', 20.0),
('SALE30', 30.0),
('SALE50', 50.0),
('SALE70', 70.0);

INSERT INTO GiamGiaHoaDon (MaHoaDon, MaGiamGia) VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5)

INSERT INTO TienIch (TenTienIch, GiaTienIch) VALUES -- THEM DU LIEU THUC TE KIEU, HANH LY XACH TAY (? KG), ...
('Extra Baggage', 200000),
('Priority Boarding', 150000),
('In-flight Meal', 100000),
('WiFi Access', 50000),
('Lounge Access', 300000)

INSERT INTO PhieuDat_TienIch (MaPhieuDat, MaTienIch) VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5)
