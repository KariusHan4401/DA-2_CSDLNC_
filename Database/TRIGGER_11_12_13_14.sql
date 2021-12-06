﻿USE QUANLYCONCUNG;

--Khi update SO_LUONG/DON_GIA_NHAP cho CHI_TIET_PHIEU_NHAP
GO
CREATE 
--ALTER
TRIGGER TRG_THANHTIENNHAP_TONGTIENNHAP_FOR_UPDATE_INSERT_CTPN
ON CHI_TIET_NHAP_HANG
FOR INSERT, UPDATE
AS
BEGIN
	-- THANH_TIEN_NHAP = DON_GIA_NHAP * SO_LUONG_NHAP
	UPDATE CHI_TIET_NHAP_HANG
	SET THANH_TIEN_NHAP = CTNH.DON_GIA_NHAP * CTNH.SO_LUONG_NHAP
	FROM CHI_TIET_NHAP_HANG CTNH
	JOIN inserted ON inserted.MAPN = CTNH.MAPN AND inserted.MASP = CTNH.MASP	

	-- Update lại TONG_TIEN_NHAP ở PHIEU_NHAP_HANG
	UPDATE PHIEU_NHAP_HANG
	SET TONG_TIEN_NHAP = ( SELECT SUM(CTNH.THANH_TIEN_NHAP)
						   FROM CHI_TIET_NHAP_HANG CTNH
						   WHERE CTNH.MAPN = PHIEU_NHAP_HANG.MAPN
						   GROUP BY CTNH.MAPN )
	FROM PHIEU_NHAP_HANG
END

-- Khi delete CHI_TIET_PHIEU_NHAP
GO
CREATE 
--ALTER
TRIGGER TG_TONGTIENNHAP_FOR_DELETE_CTPN
ON CHI_TIET_NHAP_HANG FOR DELETE
AS
BEGIN
	-- Update lại TONG_TIEN_NHAP ở PHIEU_NHAP_HANG
	UPDATE PHIEU_NHAP_HANG
	SET TONG_TIEN_NHAP = TONG_TIEN_NHAP - (SELECT SUM(deleted.THANH_TIEN_NHAP)
											FROM deleted
											WHERE PHIEU_NHAP_HANG.MAPN = deleted.MAPN
											GROUP BY deleted.MAPN )
	WHERE PHIEU_NHAP_HANG.MAPN IN (SELECT DISTINCT MAPN FROM deleted)
END

--Cập nhật lượt yêu thích ở bảng SAN_PHAM
	--khi insert YEUTHICH
GO
CREATE 
--ALTER
TRIGGER TG_LUOTYEUTHICH_FOR_INSERT_YEUTHICH
ON YEUTHICH FOR INSERT
AS
BEGIN
	UPDATE SAN_PHAM
	SET LUOT_YEU_THICH += ( SELECT COUNT(MAKH)
							FROM SAN_PHAM SP JOIN inserted
							ON SP.MASP = inserted.MASP
							GROUP BY SP.MASP)
	WHERE SAN_PHAM.MASP IN (SELECT DISTINCT MASP FROM inserted)
END

	-- Khi delete YEUTHICH
GO
CREATE 
--ALTER
TRIGGER TG_LUOTYEUTHICH_FOR_DELETE_YEUTHICH
ON YEUTHICH FOR DELETE
AS
BEGIN
	UPDATE SAN_PHAM
	SET LUOT_YEU_THICH -= ( SELECT COUNT(MAKH)
							FROM SAN_PHAM SP JOIN deleted
							ON SP.MASP = deleted.MASP
							GROUP BY SP.MASP)
	WHERE SAN_PHAM.MASP IN (SELECT DISTINCT MASP FROM deleted)
END

-- Cập nhật lượt bình luận ở bảng SAN_PHAM

	-- Khi insert BINH_LUAN
GO
CREATE 
--ALTER
TRIGGER TG_LUOTBINHLUAN_FOR_INSERT_BINHLUAN
ON BINH_LUAN FOR INSERT
AS
BEGIN
	UPDATE SAN_PHAM
	SET LUOT_BINH_LUAN += ( SELECT COUNT(*)
							FROM SAN_PHAM SP JOIN inserted
							ON SP.MASP = inserted.MASP
							GROUP BY SP.MASP)
	WHERE SAN_PHAM.MASP IN (SELECT DISTINCT MASP FROM inserted)
END

	-- Khi delete BINH_LUAN
GO
CREATE 
--ALTER
TRIGGER TG_LUOTBINHLUAN_FOR_DELETE_BINHLUAN
ON BINH_LUAN FOR DELETE
AS
BEGIN
	UPDATE SAN_PHAM
	SET LUOT_BINH_LUAN -= ( SELECT COUNT(MAKH)
							FROM SAN_PHAM SP JOIN deleted
							ON SP.MASP = deleted.MASP
							GROUP BY SP.MASP)
	WHERE SAN_PHAM.MASP IN (SELECT DISTINCT MASP FROM deleted)
END
