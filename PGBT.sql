CREATE DATABASE QLLuong

GO

USE QLLuong

GO

CREATE TABLE DonVi(
	MaDonVi int PRIMARY KEY,
	TenDonVi nvarchar(50) NOT NULL
)

GO

CREATE TABLE NhanVien(
	Ma int PRIMARY KEY,
	HoTen varchar(50) NOT NULL,
	NgaySinh date NOT NULL,
	GioiTinh varchar(6) NOT NULL,
	Hesluong decimal(3, 2),
	MaDonVi int FOREIGN KEY (MaDonVi) REFERENCES DonVi(MaDonVi) ON UPDATE CASCADE ON DELETE CASCADE,
)


SELECT GETDATE()


INSERT INTO DonVi VALUES (1, N'Don vi 1'),
							(2, N'Don vi 1'),
							(3, N'Don vi 1'),
							(4, N'Don vi 1')

INSERT INTO NhanVien VALUES(1, N'Tran Van A', N'2001-08-30', N'Nam', 1.2, 1)

INSERT INTO NhanVien VALUES(2, N'Tran Van B', N'2001-08-30', N'Nu', 1.5, 2)

INSERT INTO NhanVien VALUES(3, N'Tran Van C', N'2001-08-30', N'Nam', 1.5, 1)

SELECT * FROM DonVi

SELECT * FROM NhanVien