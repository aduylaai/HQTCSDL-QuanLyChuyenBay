CREATE DATABASE QuanLyBanVeMayBay
USE QuanLyBanVeMayBay

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
    TenTrangThaiChuyenBay NVARCHAR(40),
    TrangThai NVARCHAR(20) DEFAULT 'Chưa khởi hành' -- Giá trị mặc định cho trạng thái chuyến bay
);
CREATE TABLE ChuyenBay (
    MaChuyenBay INT IDENTITY(1,1) PRIMARY KEY,
    MaHangHangKhong INT,
    MaTrangThaiChuyenBay INT,
    MaLoTrinh INT,
    CONSTRAINT FK_CHUYENBAY_SANBAY FOREIGN KEY (MaLoTrinh) REFERENCES LoTrinh(MaLoTrinh),
    CONSTRAINT FK_CHUYENBAY_HHK FOREIGN KEY (MaHangHangKhong) REFERENCES HangHangKhong(MaHangHangKhong),
    CONSTRAINT FK_CHUYENBAY_TRANGTHAI FOREIGN KEY (MaTrangThaiChuyenBay) REFERENCES TrangThaiChuyenBay(MaTrangThaiChuyenBay)
);


CREATE TABLE VeMayBay (
    MaVe INT IDENTITY(1,1) PRIMARY KEY,
    MaChuyenBay INT,
    NgayDi DATE,
    NgayDen DATE,
    TrangThai NVARCHAR(50) DEFAULT 'Chưa khởi hành', -- Đặt giá trị mặc định cho trạng thái
    CONSTRAINT FK_VEMAYBAY_CHUYENBAY FOREIGN KEY (MaChuyenBay) REFERENCES ChuyenBay(MaChuyenBay)
);


CREATE TABLE HangGhe (
    MaHangGhe INT IDENTITY(1,1) PRIMARY KEY,
    TenHangGhe NVARCHAR(50),
    MaVe INT,
    CONSTRAINT FK_HANGGHE_VE FOREIGN KEY (MaVe) REFERENCES VeMayBay(MaVe)
);

CREATE TABLE GiaHangGhe (
    MaHangGhe INT PRIMARY KEY,
    Gia DECIMAL(18, 2) CHECK (Gia > 0), -- Giá phải lớn hơn 0
    CONSTRAINT FK_HANGGHE_GIA FOREIGN KEY (MaHangGhe) REFERENCES HangGhe(MaHangGhe)
);

CREATE TABLE PhieuDatVe (
    MaPhieuDat INT IDENTITY(1,1) PRIMARY KEY,
    MaKhachHang INT,
    NgayDat DATE,
    SoLuongHanhKhach INT CHECK (SoLuongHanhKhach > 0), -- Số lượng hành khách phải lớn hơn 0
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
('user4', 'password321'),
('user5', 'password654');

INSERT INTO KhachHang (HoTen, DiaChi, Email, NgaySinh, SoDienThoai, MaTaiKhoan) VALUES 
('Nguyen Van A', 'Ha Noi', 'a@gmail.com', '1990-01-01', '0123456789', 1),
('Le Thi B', 'Ho Chi Minh', 'b@gmail.com', '1992-05-10', '0987654321', 2),
('Tran Van C', 'Da Nang', 'c@gmail.com', '1985-03-15', '0123445566', 3),
('Pham Thi D', 'Hai Phong', 'd@gmail.com', '1991-12-25', '0111222333', 4),
('Hoang Van E', 'Can Tho', 'e@gmail.com', '1988-07-30', '0222333444', 5);

INSERT INTO HanhKhach (HoTen, DiaChi, GioiTinh, QuocTich, NgaySinh, SoDienThoai, Email, CCCD_Passport) VALUES 
('Nguyen Anh A', 'Ha Noi', 'Nam', 'Viet Nam', '1993-04-12', '0321654987', 'hanhkhach1@gmail.com', 'C123456789'),
('Tran Anh B', 'Ho Chi Minh', 'Nam', 'Viet Nam', '1989-11-22', '0981234567', 'hanhkhach2@gmail.com', 'C987654321'),
('Le Thi C', 'Da Nang', 'Nu', 'Viet Nam', '1995-08-09', '0909876543', 'hanhkhach3@gmail.com', 'P654321987'),
('Pham Anh D', 'Hai Phong', 'Nu', 'Viet Nam', '1990-02-28', '0912345678', 'hanhkhach4@gmail.com', 'P321456987'),
('Nguyen Van E', 'Can Tho', 'Nam', 'Viet Nam', '1988-06-18', '0935678901', 'hanhkhach5@gmail.com', 'C567890123');

INSERT INTO SanBay (TenSanBay, TenThanhPho, VietTatSanBay) VALUES 
('Noi Bai', 'Ha Noi', 'HAN'),
('Tan Son Nhat', 'Ho Chi Minh', 'SGN'),
('Da Nang', 'Da Nang', 'DAD'),
('Cam Ranh', 'Nha Trang', 'CXR'),
('Can Tho', 'Can Tho', 'VCA');

INSERT INTO HangHangKhong (TenHangHangKhong) VALUES 
('Vietnam Airlines'),
('VietJet Air'),
('Bamboo Airways'),
('Pacific Airlines'),
('Vasco');

INSERT INTO LoTrinh (MaSB_Di, MaSB_Den) VALUES 
(1, 2),
(2, 3),
(3, 4),
(4, 5),
(5, 1);

INSERT INTO TrangThaiChuyenBay (TenTrangThaiChuyenBay, TrangThai) VALUES 
('Chưa khởi hành', 'Chưa khởi hành'),
('Đang bay', 'Đang bay'),
('Hoàn tất', 'Hoàn tất'),
('Bị hủy', 'Bị hủy'),
('Hoãn', 'Hoãn');

INSERT INTO ChuyenBay (MaHangHangKhong, MaTrangThaiChuyenBay, MaLoTrinh) VALUES 
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 4),
(5, 5, 5);

INSERT INTO VeMayBay (MaChuyenBay, NgayDi, NgayDen, TrangThai) VALUES 
(1, '2024-11-01', '2024-11-01', 'Chưa khởi hành'),
(2, '2024-11-02', '2024-11-02', 'Đang bay'),
(3, '2024-11-03', '2024-11-03', 'Hoàn tất'),
(4, '2024-11-04', '2024-11-04', 'Bị hủy'),
(5, '2024-11-05', '2024-11-05', 'Hoãn');

INSERT INTO HangGhe (TenHangGhe, MaVe) VALUES 
('Hạng phổ thông', 1),
('Hạng thương gia', 2),
('Hạng nhất', 3),
('Hạng tiết kiệm', 4),
('Hạng phổ thông đặc biệt', 5);

INSERT INTO GiaHangGhe (MaHangGhe, Gia) VALUES 
(1, 1500000),
(2, 3000000),
(3, 5000000),
(4, 1000000),
(5, 2000000);

INSERT INTO PhieuDatVe (MaKhachHang, NgayDat, SoLuongHanhKhach) VALUES 
(1, '2024-10-01', 2),
(2, '2024-10-02', 1),
(3, '2024-10-03', 3),
(4, '2024-10-04', 2),
(5, '2024-10-05', 1);

INSERT INTO ChiTietDatVe (MaPhieuDat, MaVe, MaHanhKhach) VALUES 
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 4),
(5, 5, 5);

INSERT INTO HoaDon (MaPhieuDat, TongTien) VALUES 
(1, 3000000),
(2, 1500000),
(3, 4500000),
(4, 2000000),
(5, 1000000);

INSERT INTO GiamGia (Code, MucGiamGia) VALUES 
('DISCOUNT10', 10.00),
('DISCOUNT20', 20.00),
('DISCOUNT30', 30.00),
('DISCOUNT40', 40.00),
('DISCOUNT50', 50.00);

INSERT INTO GiamGiaHoaDon (MaHoaDon, MaGiamGia) VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);

INSERT INTO TienIch (TenTienIch, GiaTienIch) VALUES 
('WiFi', 50000),
('Bữa ăn nhẹ', 100000),
('Ghế rộng hơn', 200000),
('Giải trí trên chuyến bay', 150000),
('Phòng chờ sân bay', 250000),
('Hành lý ký gửi 10kg', 300000),
('Nâng hạng ghế', 500000),
('Đưa đón sân bay', 400000),
('Bữa ăn cao cấp', 250000),
('Dịch vụ hướng dẫn sân bay', 150000),
('Chăn và gối', 50000),
('Tai nghe cách âm', 70000),
('Bảo hiểm du lịch', 150000);

INSERT INTO PhieuDat_TienIch (MaPhieuDat, MaTienIch) VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);











