﻿CREATE DATABASE QUANLYCONCUNG
GO
USE QUANLYCONCUNG
GO
CREATE TABLE THE (
	MA_THE INT IDENTITY(1000,1),
	LOAI_THE NVARCHAR(30) CHECK(LOAI_THE IN(N'Thường', N'Vip Gold', N'Vip Diamond')),
	PHAN_TRAM_TICH_LUY INT DEFAULT 0,

	CONSTRAINT PK_THE PRIMARY KEY(MA_THE)
)
GO

CREATE TABLE KHACH_HANG (
	MAKH INT IDENTITY(100000,1),
	TENKH NVARCHAR(100),
	EMAIL_KH VARCHAR(60),
	SDT_KH CHAR(10),
	NGSINH_KH DATE,
	TONG_DIEM_TICH_LUY INT DEFAULT 0,
	MAT_KHAU VARCHAR(50) NOT NULL,
	TAI_KHOAN VARCHAR(50) NOT NULL UNIQUE,
	MA_THE INT,

	CONSTRAINT PK_KHACH_HANG PRIMARY KEY(MAKH),
	CONSTRAINT FK_KH_THE FOREIGN KEY(MA_THE) REFERENCES THE(MA_THE)

)
GO

CREATE TABLE DIA_CHI_KH (
	MAKH INT,
	STT INT,
	SO_NHA_DUONG NVARCHAR(60) NOT NULL,
	PHUONG_XA NVARCHAR(40) NOT NULL,
	QUAN_TP NVARCHAR(40) NOT NULL,
	TP_TINH NVARCHAR(40) NOT NULL,
	MAC_DINH BIT DEFAULT 0,
	
	CONSTRAINT FK_DC_KH FOREIGN KEY(MAKH) REFERENCES KHACH_HANG(MAKH),
	CONSTRAINT PK_DIA_CHI_KH PRIMARY KEY(MAKH, STT)
)

GO
CREATE TABLE EM_BE (
	MA_BE INT IDENTITY(100000,1),
	MA_BAME INT,
	TEN_BE NVARCHAR(100),
	NGSINH_BE DATE,
	GIOI_TINH BIT,

	CONSTRAINT FK_BE_BAME FOREIGN KEY (MA_BAME) REFERENCES KHACH_HANG(MAKH),
	CONSTRAINT PK_EM_BE PRIMARY KEY(MA_BE)
)

GO
CREATE TABLE THUONG_HIEU (
	MATH INT IDENTITY(100000,1),
	TEN_TH NVARCHAR(20),
	MO_TA NVARCHAR(300),

	CONSTRAINT PK_THUONG_HIEU PRIMARY KEY(MATH)
)

GO 
CREATE TABLE LOAI_HANG (
		MALH INT IDENTITY(100000,1),
		TEN_LH NVARCHAR(30),

		CONSTRAINT PK_LOAI_HANG PRIMARY KEY(MALH)
)


GO
CREATE TABLE VOUCHER (
	MA_VOUCHER INT IDENTITY(100000,1),
	PHAN_TRAM_GIAM_GIA INT DEFAULT 0,
	GIAM_TOI_DA MONEY DEFAULT 10000,
	TG_BAT_DAU DATETIME NOT NULL,
	TG_KET_THUC DATETIME,

	CONSTRAINT PK_VOUCHER PRIMARY KEY (MA_VOUCHER)
)

GO
CREATE TABLE CHI_NHANH (
	MACN INT IDENTITY(100000,1),
	NVQL INT,
	SDT_CN CHAR(10),
	SO_NHA_DUONG NVARCHAR(60) UNIQUE,
	PHUONG_XA NVARCHAR(40),
	QUAN_TP NVARCHAR(40),
	TP_TINH NVARCHAR(40),

	CONSTRAINT PK_CNHANH PRIMARY KEY(MACN)
)

GO
CREATE TABLE NHAN_VIEN (
	MANV INT IDENTITY(100000,1),
	TEN_NV NVARCHAR(100),
	MACN INT,
	SDT CHAR(10),
	CMND VARCHAR(12) UNIQUE,
	NGAY_BAT_DAU_LAM DATE NOT NULL,
	NGAY_NGHI_VIEC DATE CHECK (NGAY_NGHI_VIEC <= GETDATE()),
	SO_NHA_DUONG NVARCHAR(60),
	PHUONG_XA NVARCHAR(40),
	QUAN_TP NVARCHAR(40),
	TP_TINH NVARCHAR(40),
	LUONG MONEY DEFAULT 1350000,
	TONG_DON_BAN INT DEFAULT 0,
	TONG_TIEN_BAN INT DEFAULT 0,

	CONSTRAINT FK_NV_CN FOREIGN KEY (MACN) REFERENCES CHI_NHANH (MACN),
	CONSTRAINT PK_NHAN_VIEN PRIMARY KEY (MANV)
)

GO
-- ALTER TABLE CHI_NHANH ADD CONSTRAINT FK_CN_NVQL FOREIGN KEY(NVQL) REFERENCES NHAN_VIEN (MANV)

GO
CREATE TABLE DON_HANG (
	MADH INT IDENTITY(100000,1) PRIMARY KEY,
	MAKH INT,
	MANV INT,
	MACN INT,
	MA_VOUCHER INT,
	PHI_SAN_PHAM MONEY DEFAULT 0,
	PHI_VAN_CHUYEN MONEY DEFAULT 0,
	PHI_GIAM MONEY DEFAULT 0,
	HINH_THUC_THANH_TOAN NVARCHAR(50) CHECK(HINH_THUC_THANH_TOAN IN (N'COD',N'ATM',N'VNPAY-QR',N'VISA',N'MASTERCARD',N'JCB',N'ZALOPAY',N'MOMO')),
	TONG_PHI AS (PHI_SAN_PHAM + PHI_VAN_CHUYEN - PHI_GIAM),
	SO_NHA_DUONG NVARCHAR(60),
	PHUONG_XA NVARCHAR(40),
	QUAN_TP NVARCHAR(40),
	TP_TINH NVARCHAR(40),
	TG_LAP_DH DATETIME NOT NULL,
	TRANG_THAI NVARCHAR(10) CHECK(TRANG_THAI IN (N'Chờ giao', N'Đã giao', N'Đã hủy')),
	TG_TRANG_THAI DATETIME,
	DIEM_TICH_LUY INT DEFAULT 0,

	CONSTRAINT FK_DH_KH FOREIGN KEY (MAKH)  REFERENCES KHACH_HANG(MAKH),
	CONSTRAINT FK_DH_NV  FOREIGN KEY (MANV)  REFERENCES NHAN_VIEN (MANV),
	CONSTRAINT FK_DH_CN  FOREIGN KEY (MACN)  REFERENCES CHI_NHANH (MACN),
	CONSTRAINT FK_DH_VOUCHER FOREIGN KEY (MA_VOUCHER) REFERENCES VOUCHER(MA_VOUCHER)
)


GO
CREATE TABLE SAN_PHAM (
	MASP INT IDENTITY(100000,1),
	MALH INT,
	MATH INT NOT NULL,
	TEN_SP NVARCHAR(100),
	HINH_ANH VARCHAR(500),
	MO_TA NVARCHAR(1000),
	LUOT_YEU_THICH INT DEFAULT 0,
	LUOT_BINH_LUAN INT DEFAULT 0,
	GIA_BAN MONEY,

	CONSTRAINT PK_SAN_PHAM PRIMARY KEY(MASP),
	CONSTRAINT FK_SP_LH FOREIGN KEY (MALH) REFERENCES LOAI_HANG (MALH),
	CONSTRAINT FK_SP_TH FOREIGN KEY (MATH) REFERENCES THUONG_HIEU (MATH)
)

GO
CREATE TABLE CHI_TIET_DON_HANG (
	MADH INT,
	MASP INT,
	SO_LUONG_MUA INT DEFAULT 1,
	GIAM_GIA INT DEFAULT 0,
	THANH_TIEN_MUA MONEY,

	CONSTRAINT FK_CTDH_DH FOREIGN KEY (MADH) REFERENCES DON_HANG(MADH),
	CONSTRAINT FK_CTDH_SP FOREIGN KEY (MASP) REFERENCES SAN_PHAM(MASP),
	CONSTRAINT PK_DH_SP PRIMARY KEY (MADH,MASP)
)

GO
CREATE TABLE NHA_CUNG_CAP (
	MANCC INT IDENTITY(100000,1),
	MATH INT NOT NULL,
	TEN_NCC NVARCHAR(100),
	SO_NHA_DUONG NVARCHAR(60),
	PHUONG_XA NVARCHAR(40),
	QUAN_TP NVARCHAR(40),
	TP_TINH NVARCHAR(40),

	CONSTRAINT PK_NCC PRIMARY KEY (MANCC),
	CONSTRAINT FK_NCC_TH FOREIGN KEY(MATH)  REFERENCES THUONG_HIEU(MATH)
)

GO
CREATE TABLE PHIEU_NHAP_HANG (
	MAPN INT IDENTITY(100000,1),
	MANCC INT,
	MACN INT,
	NGAY_LAP DATETIME NOT NULL,
	TONG_TIEN_NHAP MONEY DEFAULT 0,
	TONG_SO_MAT_HANG INT DEFAULT 0,
	
	CONSTRAINT FK_PN_NCC FOREIGN KEY(MANCC) REFERENCES NHA_CUNG_CAP(MANCC),
	CONSTRAINT FK_PN_CN FOREIGN KEY(MACN) REFERENCES CHI_NHANH(MACN),
	CONSTRAINT PK_PHIEU_NHAP_HANG PRIMARY KEY(MAPN)
)

GO
CREATE TABLE CHI_TIET_NHAP_HANG (
	MAPN INT,
	MASP INT,
	SO_LUONG_NHAP INT,
	DON_GIA_NHAP MONEY,
	THANH_TIEN_NHAP AS (SO_LUONG_NHAP * DON_GIA_NHAP),

	CONSTRAINT PK_CT_NHAP_HANG PRIMARY KEY(MAPN, MASP),	
	CONSTRAINT FK_CTNH_PN FOREIGN KEY(MAPN) REFERENCES PHIEU_NHAP_HANG(MAPN),
	CONSTRAINT FK_CTNH_SP FOREIGN KEY(MASP) REFERENCES SAN_PHAM(MASP)
)

GO
CREATE TABLE BAN (
	MASP INT,
	MACN INT,
	SO_LUONG_TON INT DEFAULT 0,
	SO_LUONG_DA_BAN INT DEFAULT 0,

	CONSTRAINT PK_BAN PRIMARY KEY(MASP, MACN),
	CONSTRAINT FK_BAN_SP FOREIGN KEY(MASP) REFERENCES SAN_PHAM (MASP),
	CONSTRAINT FK_BAN_CN FOREIGN KEY(MACN) REFERENCES CHI_NHANH (MACN)
)

GO
CREATE TABLE BINH_LUAN (
	MAKH INT,
	MASP INT,
	NOI_DUNG NVARCHAR(1000),
	NGAY_DANG DATETIME,

	CONSTRAINT FK_BL_KH FOREIGN KEY(MAKH) REFERENCES KHACH_HANG(MAKH),
	CONSTRAINT FK_BL_SP FOREIGN KEY(MASP) REFERENCES SAN_PHAM(MASP),
	CONSTRAINT PK_BINH_LUAN PRIMARY KEY(MAKH, MASP)
)

GO
CREATE TABLE YEUTHICH (
	MAKH INT,
	MASP INT,

	CONSTRAINT PK_KH_SP PRIMARY KEY (MAKH,MASP),
	CONSTRAINT FK_YT_KH FOREIGN KEY (MAKH) REFERENCES  KHACH_HANG(MAKH),
	CONSTRAINT FK_YT_SP FOREIGN KEY (MASP)  REFERENCES SAN_PHAM(MASP)
)

GO
CREATE TABLE CHAM_CONG (
	MANV INT,
	TG_VAO_CA DATETIME,
	TG_RA_CA DATETIME CHECK (TG_RA_CA <= GETDATE()),

	CONSTRAINT PK_CHAM_CONG PRIMARY KEY(MANV, TG_VAO_CA, TG_RA_CA),
	CONSTRAINT FK_CC_NV FOREIGN KEY (MANV) REFERENCES NHAN_VIEN(MANV)
)

GO
/*CREATE TABLE DOANH_THU (
	MACN INT,
	NGAY_THONG_KE DATE NOT NULL,
	DOANH_THU MONEY,

	CONSTRAINT PK_DOANH_THU PRIMARY KEY (MACN, NGAY_THONG_KE),
	CONSTRAINT FK_DT_CN FOREIGN KEY (MACN) REFERENCES CHI_NHANH(MACN)
)

GO*/
CREATE TABLE LICH_SU_LUONG (
	MANV INT,
	MOC_THOI_GIAN DATE NOT NULL,
	LUONG MONEY,

	CONSTRAINT PK_LICH_SU_LUONG PRIMARY KEY (MANV, MOC_THOI_GIAN),
	CONSTRAINT FK_LSL_NV FOREIGN KEY (MANV) REFERENCES NHAN_VIEN(MANV)
)

ALTER TABLE NHAN_VIEN
ADD CONSTRAINT TG_BD_KT_NV CHECK(NGAY_NGHI_VIEC > NGAY_BAT_DAU_LAM)
GO

--Thời gian vào ca và ra ca của nhân viên
ALTER TABLE CHAM_CONG
ADD CONSTRAINT TG_VAO_RA_CA CHECK(TG_RA_CA > TG_VAO_CA)
GO

--Thời gian bắt đầu áp dụng và kết thúc của voucher
ALTER TABLE VOUCHER
ADD CONSTRAINT TG_SU_DUNG_VOUCHER CHECK(TG_KET_THUC > TG_BAT_DAU)

ALTER TABLE DON_HANG
ADD CONSTRAINT TG_TGLAP CHECK(TG_LAP_DH < TG_TRANG_THAI)

