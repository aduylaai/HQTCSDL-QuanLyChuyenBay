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

INSERT INTO TrangThaiChuyenBay (TenTrangThaiChuyenBay) VALUES
(N'Có sẵn'),
(N'Không có sẵn');

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

INSERT INTO TrangThaiVe (TenTTV) VALUES
(N'Có sẵn'),
(N'Đã đặt'),
(N'Đã sử dụng');

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
    CONSTRAINT FK_PHIEUDATVE_KHACHHANG FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
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
    CONSTRAINT FK_HOADON_PHIEUDATVE FOREIGN KEY (MaPhieuDat) REFERENCES PhieuDatVe(MaPhieuDat)
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