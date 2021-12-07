﻿USE QUANLYCONCUNG
GO

--Thời gian bắt đầu công việc và nghỉ việc của nhân viên
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
GO

--TRIGGER Tính tổng tiền của đơn hàng: Tổng phí = phí sản phẩm + phí vận chuyển - phí giảm
CREATE OR ALTER TRIGGER TG_FOR_INSERT_DONHANG
ON DON_HANG FOR INSERT
AS
BEGIN
	IF EXISTS (SELECT inserted.MADH FROM VOUCHER V JOIN inserted ON V.MA_VOUCHER = inserted.MA_VOUCHER
				WHERE V.TG_BAT_DAU > inserted.TG_LAP_DH OR V.TG_KET_THUC < inserted.TG_LAP_DH)
	BEGIN
		PRINT(N'VOUCHER ÁP DỤNG KHÔNG HỢP LỆ!! VUI LÒNG KIỂM TRA THỜI GIAN SỬ DỤNG VOUCHER!!')
		ROLLBACK 
	END
	IF EXISTS (SELECT DH.MADH FROM DON_HANG DH JOIN inserted ON inserted.MADH = DH.MADH WHERE DH.MA_VOUCHER IS NOT NULL)
	BEGIN
		UPDATE DON_HANG
		SET DON_HANG.PHI_GIAM = (SELECT CASE 
								WHEN V.PHAN_TRAM_GIAM_GIA = 0 THEN V.GIAM_TOI_DA
								WHEN (DON_HANG.PHI_SAN_PHAM * V.PHAN_TRAM_GIAM_GIA) < V.GIAM_TOI_DA 
									THEN DON_HANG.PHI_SAN_PHAM * V.PHAN_TRAM_GIAM_GIA
								WHEN (DON_HANG.PHI_SAN_PHAM * V.PHAN_TRAM_GIAM_GIA) >= V.GIAM_TOI_DA THEN V.GIAM_TOI_DA
								END
								FROM VOUCHER V
								WHERE DON_HANG.MA_VOUCHER = V.MA_VOUCHER
								)
		WHERE DON_HANG.MADH IN (SELECT DISTINCT inserted.MADH FROM inserted)
	END
	IF EXISTS (SELECT DH.MADH FROM DON_HANG DH JOIN inserted ON inserted.MADH = DH.MADH WHERE DH.MA_VOUCHER IS NULL)
		BEGIN
			UPDATE DON_HANG
			SET TONG_PHI = PHI_SAN_PHAM + PHI_VAN_CHUYEN, PHI_GIAM = 0
			WHERE DON_HANG.MADH IN (SELECT DISTINCT inserted.MADH FROM inserted) AND DON_HANG.MA_VOUCHER IS NULL
		END	
	UPDATE DON_HANG
	SET TONG_PHI = CASE WHEN PHI_GIAM < PHI_VAN_CHUYEN + PHI_SAN_PHAM
	THEN DON_HANG.PHI_SAN_PHAM + DON_HANG.PHI_VAN_CHUYEN - DON_HANG.PHI_GIAM
	ELSE 0
	END
	WHERE DON_HANG.MADH IN (SELECT DISTINCT inserted.MADH FROM inserted)
	
	UPDATE NHAN_VIEN
	SET TONG_DON_BAN +=(SELECT COUNT(*) FROM inserted
						WHERE inserted.MANV = NHAN_VIEN.MANV),
	TONG_TIEN_BAN += (SELECT SUM(PHI_SAN_PHAM)
							FROM inserted
							WHERE inserted.MANV = NHAN_VIEN.MANV
							)
	WHERE NHAN_VIEN.MANV IN (SELECT DISTINCT inserted.MANV
										FROM inserted)
	UPDATE DON_HANG
	SET SO_NHA_DUONG = DC.SO_NHA_DUONG, PHUONG_XA = DC.PHUONG_XA, QUAN_TP = DC.QUAN_TP, TP_TINH = DC.TP_TINH
	FROM DIA_CHI_KH DC JOIN inserted ON inserted.MAKH = DC.MAKH
	WHERE MAC_DINH = 1 AND DON_HANG.MADH = inserted.MADH
END
GO

CREATE OR ALTER TRIGGER TG_TONGTIEN_VOUCHER_FOR_UPDATE_DONHANG
ON DON_HANG FOR UPDATE
AS
BEGIN
	IF EXISTS (SELECT inserted.MADH FROM VOUCHER V JOIN inserted ON V.MA_VOUCHER = inserted.MA_VOUCHER
				WHERE  inserted.TG_LAP_DH BETWEEN V.TG_BAT_DAU AND V.TG_KET_THUC)
		BEGIN
			IF EXISTS (SELECT DH.MADH FROM DON_HANG DH JOIN inserted ON inserted.MADH = DH.MADH WHERE DH.MA_VOUCHER IS NOT NULL)
				BEGIN
					UPDATE DON_HANG
					SET DON_HANG.PHI_GIAM = (SELECT CASE 
											WHEN V.PHAN_TRAM_GIAM_GIA = 0 THEN V.GIAM_TOI_DA
											WHEN (DON_HANG.PHI_SAN_PHAM * V.PHAN_TRAM_GIAM_GIA) < V.GIAM_TOI_DA 
												THEN DON_HANG.PHI_SAN_PHAM * V.PHAN_TRAM_GIAM_GIA
											WHEN (DON_HANG.PHI_SAN_PHAM * V.PHAN_TRAM_GIAM_GIA) >= V.GIAM_TOI_DA THEN V.GIAM_TOI_DA
											END
											FROM VOUCHER V
											WHERE DON_HANG.MA_VOUCHER = V.MA_VOUCHER
											)
					WHERE DON_HANG.MADH IN (SELECT DISTINCT inserted.MADH FROM inserted)
				END

				UPDATE DON_HANG
				SET TONG_PHI = CASE WHEN PHI_GIAM < PHI_VAN_CHUYEN + PHI_SAN_PHAM
				THEN DON_HANG.PHI_SAN_PHAM + DON_HANG.PHI_VAN_CHUYEN - DON_HANG.PHI_GIAM
				ELSE 0
				END
				WHERE DON_HANG.MADH IN (SELECT DISTINCT inserted.MADH FROM inserted)
		END
		IF EXISTS (SELECT DH.MADH FROM DON_HANG DH JOIN inserted ON inserted.MADH = DH.MADH WHERE DH.MA_VOUCHER IS NULL)
			BEGIN
				UPDATE DON_HANG
				SET TONG_PHI = PHI_SAN_PHAM + PHI_VAN_CHUYEN, PHI_GIAM = 0
				WHERE DON_HANG.MADH IN (SELECT DISTINCT inserted.MADH FROM inserted) AND DON_HANG.MA_VOUCHER IS NULL
			END				
	ELSE
		BEGIN
			IF EXISTS (SELECT DH.MADH FROM DON_HANG DH JOIN inserted ON inserted.MADH = DH.MADH WHERE DH.MA_VOUCHER IS NOT NULL)
				BEGIN
					PRINT(N'VOUCHER ĐÃ HẾT HẠN HOẶC CHƯA ĐẾN THỜI GIAN SỬ DỤNG!!') 
					PRINT(N'KIỂM TRA THỜI GIAN ÁP DỤNG VOUCHER VÀ THỜI GIAN LẬP ĐƠN HÀNG ÁP DỤNG CÁC VOUCHER NÀY')
				END
			
			UPDATE DON_HANG
			SET TONG_PHI = PHI_SAN_PHAM + PHI_VAN_CHUYEN, PHI_GIAM = 0
			WHERE DON_HANG.MADH IN (SELECT DISTINCT inserted.MADH FROM inserted)
		END
END
GO
UPDATE DON_HANG
SET TONG_PHI = 0
SELECT * FROM DON_HANG
--TRIGGER: Kiểm tra đơn hàng sử dụng voucher hợp lệ
CREATE OR ALTER TRIGGER TG_TONGTIEN_FOR_UPDATE_VOUCHER
ON VOUCHER FOR UPDATE
AS
BEGIN
	UPDATE DON_HANG
	SET TONG_PHI = 0
	WHERE DON_HANG.MA_VOUCHER IN (SELECT DISTINCT MA_VOUCHER FROM inserted)
END
GO

--TRIGGER trên bảng CHI_TIET_NHAP_HANG cho việc thêm
--Cập nhật số mặt hàng sau khi thêm mới CHI_TIET_NHAP_HANG
CREATE OR ALTER  TRIGGER TG_TONGMATHANG_INSERT_CTNHAPHANG
ON CHI_TIET_NHAP_HANG FOR INSERT
AS
BEGIN
	UPDATE PHIEU_NHAP_HANG
	SET PHIEU_NHAP_HANG.TONG_SO_MAT_HANG += (SELECT COUNT(*)
											FROM inserted
											WHERE PHIEU_NHAP_HANG.MAPN = inserted.MAPN
											GROUP BY inserted.MAPN
											)
	WHERE PHIEU_NHAP_HANG.MAPN IN (SELECT DISTINCT MAPN
									FROM inserted)
END
GO

--TRIGGER trên bảng CHI_TIET_NHAP_HANG cho việc xóa
--Cập nhật số mặt hàng còn lại sau khi xóa CHI_TIET_NHAP_HANG
CREATE OR ALTER  TRIGGER TG_TONGMATHANG_DELETE_CTNHAPHANG
ON CHI_TIET_NHAP_HANG FOR DELETE
AS
BEGIN
	UPDATE PHIEU_NHAP_HANG
	SET PHIEU_NHAP_HANG.TONG_SO_MAT_HANG -= (SELECT COUNT(*)
											FROM deleted
											WHERE PHIEU_NHAP_HANG.MAPN = deleted.MAPN
											GROUP BY deleted.MAPN
											)
	WHERE PHIEU_NHAP_HANG.MAPN IN (SELECT DISTINCT MAPN
									FROM deleted)
END
--------------------------------------------------------------------------------------
--TEST
INSERT NHAN_VIEN VALUES ('NV000001', N'Khanh', NULL, '0979123456', '079201006666', '12-06-2021', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT NHAN_VIEN VALUES ('NV000002', N'Lin', NULL, '0979123456', '079201006667', '12-06-2021', '12-05-2022', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
--SELECT * FROM NHAN_VIEN
GO

INSERT CHAM_CONG VALUES ('NV000001', '12-06-2021 07:00:00', '12-06-2021 16:00:00')
INSERT CHAM_CONG VALUES ('NV000001', '12-05-2021 09:00:00', '12-05-2021 15:00:00')
--SELECT * FROM CHAM_CONG
GO

INSERT VOUCHER(MA_VOUCHER, TG_BAT_DAU, TG_KET_THUC) VALUES ('VC000001', '11-06-2021', '12-06-2021')
INSERT VOUCHER VALUES ('VC000002', 0.1, 50000, '12-01-2021', '12-14-2021')
--DELETE FROM VOUCHER WHERE MA_VOUCHER = 'VC000001'
--SELECT * FROM VOUCHER
GO

INSERT KHACH_HANG VALUES('KH000002', N'Linh', N'linh69@gmail.com', NULL, NULL, 0 ,'KH000002', 'linh', NULL)
INSERT KHACH_HANG VALUES('KH000001', N'Lê Thương', 'thuongle@gmail.com', '0980265136', NULL, 0, 'KH000001', N'thuong', NULL)
GO

INSERT DIA_CHI_KH VALUES('KH000001', 1, N'123 Đường Kinh Dương Vương', N'An Lạc', N'Bình Tân',N'TP. Hồ Chí Minh', 1)
INSERT DIA_CHI_KH(MAKH, STT, SO_NHA_DUONG, PHUONG_XA, QUAN_TP, TP_TINH) VALUES('KH000001', 2, N'10/16A/2 Đường An Dương Vương', N'6', N'8',N'TP. Hồ Chí Minh'),
('KH000001', 3, N'2 Đường 19A', N'5', N'6',N'TP. Hồ Chí Minh')
INSERT DIA_CHI_KH VALUES('KH000002', 1, N'12/10 Đường Lô D', N'An Bình', N'Bình Chánh',N'TP. Hồ Chí Minh',1), 
('KH000002', 2, N'365/10 Đường Thành Thái', N'4', N'10',N'TP. Hồ Chí Minh', 0)
GO

INSERT DON_HANG VALUES('DH000001', 'KH000001', 'NV000001', NULL, NULL, 200000, 15000, 15000, 'VISA', 200000, NULL, NULL, NULL, NULL, '11-29-2021', N'Chờ giao', '11-30-2021')
INSERT DON_HANG VALUES('DH000002', 'KH000001', 'NV000002', NULL, 'VC000002', 100000, 15000, 15000, 'VISA', 510000, NULL, NULL, NULL, NULL, '12-1-2021', NULL, NULL)
INSERT DON_HANG VALUES('DH000003', 'KH000001', 'NV000002', NULL, 'VC000001', 300000, 35000, 15000, 'VISA', 510000, NULL, NULL, NULL, NULL, '12-06-2021', NULL, NULL)
--DELETE FROM DON_HANG WHERE MADH = 'DH000001'
--SELECT * FROM DON_HANG
GO
UPDATE DON_HANG
SET PHI_VAN_CHUYEN = 20000 WHERE MADH = 'DH000002'
--SELECT * FROM DON_HANG
GO

INSERT PHIEU_NHAP_HANG VALUES('PN000001', NULL, NULL, '12-05-2021', NULL, 0)
--DELETE FROM PHIEU_NHAP_HANG WHERE  MAPN = 'PN000001'


INSERT THUONG_HIEU VALUES('TH000001', 'aboot', NULL)

INSERT SAN_PHAM VALUES('SP000001', NULL, 'TH000001', N'Sữa cho mẹ bầu', NULL, NULL, NULL, NULL, NULL)
INSERT SAN_PHAM VALUES('SP000002', NULL, 'TH000001', N'Bỉm', NULL, NULL, NULL, NULL, NULL)
INSERT SAN_PHAM VALUES('SP000003', NULL, 'TH000001', N'Sữa hộp cho bé', NULL, NULL, NULL, NULL, NULL)
--DELETE FROM SAN_PHAM WHERE  MASP = 'SP000001'

INSERT CHI_TIET_NHAP_HANG VALUES('PN000001', 'SP000001', NULL, NULL, NULL)
INSERT CHI_TIET_NHAP_HANG VALUES('PN000001', 'SP000002', NULL, NULL, NULL)
INSERT CHI_TIET_NHAP_HANG VALUES('PN000001', 'SP000003', NULL, NULL, NULL)
--DELETE FROM CHI_TIET_NHAP_HANG WHERE  MAPN = 'PN000001' AND MASP = 'SP000001'
--SELECT * FROM PHIEU_NHAP_HANG
GO

UPDATE VOUCHER
SET PHAN_TRAM_GIAM_GIA = 0.15 WHERE MA_VOUCHER = 'VC000002'
--SELECT * FROM VOUCHER GO
--DON HANG 002 GIA GIAM FIXED THEO TI LE THAY DOI
--SELECT * FROM DON_HANG GO
GO

UPDATE VOUCHER
SET TG_BAT_DAU = '12-02-2021' WHERE MA_VOUCHER = 'VC000002'
--SELECT * FROM VOUCHER GO
--DON HANG 002 PHI GIAM = 0 DO KHONG THE AP DUNG VOUCHER
--SELECT * FROM DON_HANG GO
GO

UPDATE VOUCHER
SET TG_BAT_DAU = '11-01-2021' WHERE MA_VOUCHER = 'VC000002'
--SELECT * FROM DON_HANG
--DON HANG 002 BI ANH HUONG PHI GIAM
GO
UPDATE VOUCHER
SET TG_KET_THUC = '11-30-2021' WHERE MA_VOUCHER = 'VC000002'
--SELECT * FROM VOUCHER GO
--DON HANG 002 PHI GIAM = 0 DO KHONG THE AP DUNG VOUCHER
--SELECT * FROM DON_HANG GO
GO