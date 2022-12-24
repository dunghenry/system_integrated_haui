﻿CREATE DATABASE QLNV

GO

USE QLNV

GO


CREATE TABLE NhanVien(
	MaNV int PRIMARY KEY,
	TenNV nvarchar(30) NOT NULL,
	HsLuong decimal(3, 2) NOT NULL
)

INSERT INTO NhanVien VALUES(1, N'Trần Văn Dũng', 1.2)

SELECT * FROM NhanVien