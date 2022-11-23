CREATE DATABASE QLBANHANG

GO

USE QLBANHANG

GO 

CREATE TABLE DanhMuc(
	MaDanhMuc int PRIMARY KEY,
	TenDanhMuc varchar(50) NOT NULL
)

GO

--ALTER TABLE DanhMuc
--ALTER COLUMN TenDanhMuc nvarchar(255)

CREATE TABLE SanPham(
	Ma int PRIMARY KEY,
	Ten varchar(50) NOT NULL,
	DonGia float NOT NULL,
	MaDanhMuc int FOREIGN KEY (MaDanhMuc) REFERENCES DanhMuc(MaDanhMuc) ON UPDATE CASCADE ON DELETE CASCADE,
)

--ALTER TABLE SanPham
--ALTER COLUMN Ten nvarchar(255)

--insert data to table DanhMuc
INSERT INTO DanhMuc VALUES(1, N'Điện tử')
INSERT INTO DanhMuc VALUES(2, N'Thời trang nam')
INSERT INTO DanhMuc VALUES(3, N'Đồng hồ')

--insert data to table SanPham
INSERT INTO SanPham VALUES (1, N'Ti vi', 800, 1)
INSERT INTO SanPham VALUES (2, N'Tai nghe bluetooth F9', 100, 1)

INSERT INTO SanPham VALUES (3, N'Thắt lưng nam LV', 15, 2)
INSERT INTO SanPham VALUES (4, N'Áo Thun nam ngắn tay', 20, 2)

INSERT INTO SanPham VALUES (5, N'Apple Watch Series 3 42mm GPS', 500, 3)
INSERT INTO SanPham VALUES (6, N'Đồng hồ nữ citizentt dạng lắc tay', 150, 3)

-- delete all records table DanhMuc
--DELETE FROM DanhMuc

SELECT * FROM DanhMuc

SELECT * FROM SanPham

-- test query
SELECT DanhMuc.MaDanhMuc, DanhMuc.TenDanhMuc, SanPham.Ma as N'Ma SP', SanPham.Ten, SanPham.DonGia
FROM DanhMuc
INNER JOIN SanPham
ON DanhMuc.MaDanhMuc = SanPham.MaDanhMuc
WHERE DanhMuc.MaDanhMuc = 1