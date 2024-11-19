-- Tạo cơ sở dữ liệu CD_Management
CREATE DATABASE CD_Management;
GO
USE CD_Management;
GO

-- Tạo bảng Account
CREATE TABLE Account (
    Id VARCHAR(255) NOT NULL PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL,
    Role NVARCHAR(255) NOT NULL
);

CREATE TABLE Bang (
	MaBang NVARCHAR(50) NOT NULL PRIMARY KEY,
	TenBang NVARCHAR(50) NOT NULL,
	SoLuong INT NOT NULL,
	DonGiaBan FLOAT NOT NULL,
	TheLoai NVARCHAR(200) NOT NULL,
	TacGia NVARCHAR(200) NOT NULL
)

CREATE TABLE Khach (
	MaKhach NVARCHAR(50) NOT NULL PRIMARY KEY,
	TenKhach NVARCHAR(50) NOT NULL,
	DienThoai NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(50) NOT NULL
)

CREATE TABLE PhieuMuon (
	 MaHDMuon NVARCHAR(50) NOT NULL PRIMARY KEY,
	NgayMuon DATETIME NOT NULL,
	NgayTra DATETIME NOT NULL,
	MaKhach NVARCHAR(50) NOT NULL,
	TienCoc FLOAT NOT NULL,
	TienTra FLOAT NOT NULL,
	HoatDong BIT NOT NULL,
	FOREIGN KEY (MaKhach) REFERENCES Khach(MaKhach) ON DELETE CASCADE
);


CREATE TABLE PhieuTra (
	MaHDTra NVARCHAR(50) NOT NULL PRIMARY KEY,
	MaHDMuon NVARCHAR(50) NOT NULL,
	NgayTraHang DATETIME,
	GhiChu NVARCHAR(50),
	TongTien FLOAT NOT NULL,
	SoTienPhat FLOAT
	FOREIGN KEY (MaHDMuon) REFERENCES PhieuMuon(MaHDMuon) ON DELETE CASCADE
)

CREATE TABLE ChiTietPhieuMuon (
	MaHDBan NVARCHAR(50) NOT NULL,
	MaBang NVARCHAR(50) NOT NULL,
	SoLuong INT NOT NULL,
	DonGia FLOAT NOT NULL,
	Coc FLOAT NOT NULL,
	TienCoc FLOAT NOT NULL
	FOREIGN KEY (MaHDBan) REFERENCES PhieuMuon(MaHDMuon) ON DELETE CASCADE,
	FOREIGN KEY (MaBang) REFERENCES Bang(MaBang) ON DELETE CASCADE
)

CREATE TABLE NhaCungCap (
    MaNhaCungCap NVARCHAR(50) NOT NULL PRIMARY KEY,
    TenNhaCungCap NVARCHAR(255) NOT NULL,
    SoDienThoai NVARCHAR(50),
    DiaChi NVARCHAR(255),
    Email NVARCHAR(255)
);

CREATE TABLE QuanLyKho (
    MaKho NVARCHAR(50) NOT NULL PRIMARY KEY,
    MaBang NVARCHAR(50) NOT NULL,
    LoaiGiaoDich NVARCHAR(50) NOT NULL, -- 'Nhap' hoặc 'Xuat'
    SoLuong INT NOT NULL,
    NgayGiaoDich DATETIME NOT NULL,
    NhaCungCapId NVARCHAR(50),
    GhiChu NVARCHAR(255),
    FOREIGN KEY (MaBang) REFERENCES Bang(MaBang) ON DELETE CASCADE,
    FOREIGN KEY (NhaCungCapId) REFERENCES NhaCungCap(MaNhaCungCap) ON DELETE SET NULL
);

--INSERT INTO Bang (MaBang, TenBang, SoLuong, DonGiaBan, TheLoai, TacGia) VALUES 
--    ('BD001', N'Bên Trên Tầng Lầu', 50, 50000, N'Nhạc Trẻ', N'Tăng Duy Tân'),
--    ('BD002', N'Hạ Cánh Nơi Anh', 20, 150000, N'Phim Tình Cảm', 'Park Ji-eun'),
--    ('BD003', N'Mây Lang Thang', 30, 55000, N'Nhạc Pop', 'Tùng TeA & PC'),
--    ('BD004', N'Trạng Tí Phiêu Lưu Ký', 15, 120000, N'Phim Hoạt Hình', N'Nguyễn Quang Dũng'),
--    ('BD005', N'Thương Em', 40, 60000, N'Nhạc Trẻ', N'Châu Khải Phong');

--INSERT INTO Khach (MaKhach, TenKhach, DienThoai, DiaChi) VALUES 
--    ('KH001', N'Lê Đức Anh Minh', '0912345678', N'Hà Nội'),
--    ('KH002', N'Võ Thị Hồng Điệp', '0987654321', N'Hồ Chí Minh'),
--    ('KH003', N'Mai Quốc Hữu', '0923456789', N'Đà Nẵng'),
--    ('KH004', N'Trần Chí Nhân', '0976543210', N'Cần Thơ'),
--    ('KH005', N'Lưu Đại Hải', '0934567890', N'Hải Phòng');

-- INSERT INTO PhieuMuon (MaHDMuon, NgayMuon, NgayTra, MaKhach, TienCoc, TienTra, HoatDong) VALUES 
--    ('PM001', '2023-10-01', '2023-10-15', 'KH001', 100000, 300000, 1),
--    ('PM002', '2023-10-05', '2023-10-20', 'KH002', 150000, 450000, 1),
--    ('PM003', '2023-10-10', '2023-10-25', 'KH003', 120000, 360000, 1),
--    ('PM004', '2023-10-15', '2023-10-30', 'KH004', 130000, 390000, 1),
--    ('PM005', '2023-10-20', '2023-11-05', 'KH005', 90000, 270000, 1);

--INSERT INTO PhieuTra (MaHDTra, MaHDMuon, NgayTraHang, GhiChu, TongTien, SoTienPhat) VALUES 
--    ('PT001', 'PM001', '2023-10-15', N'Hoàn thành', 300000, 0),
--    ('PT002', 'PM002', '2023-10-20', N'Hoàn thành', 450000, 0),
--    ('PT003', 'PM003', '2023-10-25', N'Hoàn thành', 360000, 0),
--    ('PT004', 'PM004', '2023-10-30', N'Hoàn thành', 390000, 0),
--    ('PT005', 'PM005', '2023-11-05', N'Hoàn thành', 270000, 10000);

--INSERT INTO ChiTietPhieuMuon (MaHDBan, MaBang, SoLuong, DonGia, Coc, TienCoc) VALUES 
--    ('PM001', 'BD001', 2, 50000, 10000, 20000),
--    ('PM001', 'BD002', 1, 150000, 20000, 20000),
--    ('PM002', 'BD003', 3, 55000, 10000, 30000),
--    ('PM003', 'BD004', 1, 120000, 15000, 15000),
--    ('PM004', 'BD005', 2, 60000, 10000, 20000);

--INSERT INTO NhaCungCap (MaNhaCungCap, TenNhaCungCap, SoDienThoai, DiaChi, Email) VALUES 
--    ('NCC001', N'Công ty TNHH Băng Đĩa Sài Gòn', '0281234567', N'Hồ Chí Minh', 'info@bangdia.vn'),
--    ('NCC002', N'Công ty CP Phát Hành Băng Đĩa Hà Nội', '0247654321', N'Hà Nội', 'contact@phathanh.vn'),
--    ('NCC003', N'Nhà Phân Phối Băng Đĩa Đà Nẵng', '0234123456', N'Đà Nẵng', 'support@dangang.vn'),
--    ('NCC004', N'Cửa Hàng Đĩa Nhạc Cần Thơ', '0292384765', N'Cần Thơ', 'sale@cuahangct.vn'),
--    ('NCC005', N'Phân Phối Băng Đĩa Hải Phòng', '0319876543', N'Hải Phòng', 'bangdia@haiphong.vn');

--INSERT INTO QuanLyKho (MaKho, MaBang, LoaiGiaoDich, SoLuong, NgayGiaoDich, NhaCungCapId, GhiChu) VALUES 
--    ('KHO001', 'BD001', 'Nhap', 30, '2023-09-20', 'NCC001', N'Nhập hàng từ NCC001'),
--    ('KHO002', 'BD002', 'Nhap', 20, '2023-09-25', 'NCC002', N'Nhập hàng từ NCC002'),
--    ('KHO003', 'BD003', 'Xuat', 10, '2023-10-05', 'NCC003', N'Xuất hàng cho khách'),
--    ('KHO004', 'BD004', 'Nhap', 15, '2023-10-10', 'NCC004', N'Nhập hàng từ NCC004'),
--    ('KHO005', 'BD005', 'Xuat', 5, '2023-10-15', 'NCC005', N'Xuất hàng cho khách');
