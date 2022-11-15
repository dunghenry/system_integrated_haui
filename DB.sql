CREATE DATABASE DB

GO

USE DB

GO

CREATE TABLE DanhMuc(
	MaDanhMuc int PRIMARY KEY,
	TenDanhMuc nvarchar(50) NOT NULL,
)


GO

CREATE TABLE SanPham(
	--Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Ma int NOT NULL PRIMARY KEY,
	Ten	nvarchar(50) NOT NULL,
	DonGia int NOT NULL,
	MaDanhMuc int NOT NULL
	FOREIGN KEY (MaDanhMuc) REFERENCES DanhMuc(MaDanhMuc)
)

INSERT INTO DanhMuc VALUES	(1, N'Danh Mục 1'),
							(2, N'Danh Mục 2'),
							(3, N'Danh Mục 3'),
							(4, N'Danh Mục 4')


SELECT * FROM DanhMuc;


INSERT INTO SanPham VALUES(1, N'San pham 1', 1000, 1),
							(2, N'San pham 2', 2000, 2)

							
INSERT INTO SanPham VALUES(3, N'San pham 3', 3000, 3),
							(4, N'San pham 4', 4000, 4)

SELECT * FROM SanPham;