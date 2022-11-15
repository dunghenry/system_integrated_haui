CREATE DATABASE CSDLTEST

CREATE TABLE DanhMuc(
	MaDanhMuc char(10) not null PRIMARY KEY,
	TenDanhMuc varchar(100) not null
)

CREATE TABLE SanPham(
	Ma char(10) not null PRIMARY KEY,
	Ten varchar(100) not null,
	DonGia char(10) not null,
	MaDanhMuc char(10) not null,
	FOREIGN KEY (MaDanhMuc) REFERENCES DanhMuc(MaDanhMuc)
)

INSERT INTO DanhMuc VALUES	(N'DM01', N'Danh Mục 1'),
							(N'DM02', N'Danh Mục 2')

SELECT * FROM DanhMuc;


INSERT INTO SanPham VALUES(N'M01', N'San pham 1', N'chiec', N'DM01'),
							(N'M02', N'San pham 2', N'tui', N'DM02')

							
INSERT INTO SanPham VALUES(N'M03', N'San pham 3', N'30', N'DM01'),
							(N'M04', N'San pham 4', N'50', N'DM02')

SELECT * FROM SanPham;

UPDATE SanPham 
SET DonGia=N'100'
WHERE Ma=N'M02';


CREATE TABLE Person(
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY ,
	username VARCHAR(30) NOT NULL,
	email VARCHAR(50) NOT NULL UNIQUE,
	age INT NOT NULL,
	password VARCHAR(200) NOT NULL
)

SELECT * FROM Person