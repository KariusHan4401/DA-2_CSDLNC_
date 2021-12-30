﻿USE QUANLYCONCUNG
GO

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

/*SELECT * FROM BAN
SELECT * FROM DON_HANG WHERE MADH = 10000001
SELECT * FROM CHI_TIET_DON_HANG WHERE MADH = 10000001*/
-- PROCEDURE: Thêm chi tiết đơn hàng
GO
CREATE OR ALTER 
PROC USP_THEM_CTDH 
@MADH INT, @MASP INT, @SL INT, @GIAM_GIA INT
AS
BEGIN
	DECLARE @THANH_TIEN MONEY
	DECLARE @MACN INT
	SELECT @THANH_TIEN = (SELECT SP.GIA_BAN * @SL
						FROM SAN_PHAM SP
						WHERE SP.MASP = @MASP
						)
	SELECT @MACN = MACN FROM DON_HANG DH WHERE MADH = @MADH

	INSERT CHI_TIET_DON_HANG(MADH, MASP, SO_LUONG_MUA, GIAM_GIA, THANH_TIEN_MUA) VALUES (@MADH, @MASP, @SL, @GIAM_GIA, @THANH_TIEN)
	UPDATE DON_HANG
	SET DON_HANG.PHI_SAN_PHAM += @THANH_TIEN
	WHERE DON_HANG.MADH = @MADH
	UPDATE BAN
	SET SO_LUONG_TON = SO_LUONG_TON - @SL,
		SO_LUONG_DA_BAN = SO_LUONG_DA_BAN + @SL
	WHERE BAN.MASP = @MASP AND MACN = @MACN
END
GO
-- PROCEDURE: Khi cập nhật số lượng mua hoặc phần trăm giảm giá của chi tiết đơn hàng
CREATE OR ALTER PROC USP_UPDATE_SLMUA_GIAM_GIA_CTDH
@MADH INT, @MASP INT, @SO_LUONG_MUA INT, @GIAM_GIA INT
AS BEGIN
	-- CẬP NHẬT GIAM_GIA
	IF (@SO_LUONG_MUA IS NULL)
	BEGIN
		UPDATE CT
		SET GIAM_GIA = @GIAM_GIA, THANH_TIEN_MUA = SO_LUONG_MUA * (SAN_PHAM.GIA_BAN  - SAN_PHAM.GIA_BAN* @GIAM_GIA / 100)
		FROM CHI_TIET_DON_HANG CT JOIN SAN_PHAM ON CT.MASP = SAN_PHAM.MASP
		WHERE CT.MASP = @MASP AND CT.MADH = @MADH
	END
	-- CẬP NHẬT SO_LUONG_MUA
	ELSE IF (@GIAM_GIA IS NULL)
	BEGIN
		UPDATE CT
		SET SO_LUONG_MUA = @SO_LUONG_MUA, THANH_TIEN_MUA = @SO_LUONG_MUA * (SAN_PHAM.GIA_BAN  - SAN_PHAM.GIA_BAN* GIAM_GIA / 100)
		FROM CHI_TIET_DON_HANG CT JOIN SAN_PHAM ON CT.MASP = SAN_PHAM.MASP
		WHERE CT.MASP = @MASP AND CT.MADH = @MADH
	END
	-- Cập nhật phí sản phẩm ở DON_HANG
	UPDATE DON_HANG SET PHI_SAN_PHAM = (SELECT SUM(CT.THANH_TIEN_MUA)
										FROM CHI_TIET_DON_HANG CT
										WHERE CT.MADH = @MADH)
	WHERE MADH = @MADH
END

-- UPDATE TOÀN BỘ DỮ LIỆU THÀNH TIỀN Ở CHI TIẾT ĐƠN HÀNG
GO
CREATE OR ALTER PROC USP_UPDATE_ALL_CTDH
AS BEGIN
	-- CẬP NHẬT GIAM_GIA
	UPDATE CT
		SET THANH_TIEN_MUA = SO_LUONG_MUA * (SAN_PHAM.GIA_BAN  - SAN_PHAM.GIA_BAN* GIAM_GIA / 100)
		FROM CHI_TIET_DON_HANG CT JOIN SAN_PHAM ON CT.MASP = SAN_PHAM.MASP
	-- Cập nhật phí sản phẩm ở DON_HANG
	UPDATE DON_HANG SET PHI_SAN_PHAM = (SELECT SUM(CT.THANH_TIEN_MUA)
										FROM CHI_TIET_DON_HANG CT
										WHERE CT.MADH = DON_HANG.MADH)
END

--TRIGGER khi xóa chi tiết đơn hàng -> thay đối phí sản phẩm đơn hàng, số lượng tồn, bán
GO
CREATE OR ALTER
TRIGGER CHI_TIET_DON_HANG_DELETE
ON CHI_TIET_DON_HANG FOR DELETE
AS
BEGIN
	--cập nhật lại phí sản phẩm
	UPDATE DON_HANG
	SET PHI_SAN_PHAM = (SELECT SUM(CHI_TIET_DON_HANG.THANH_TIEN_MUA) 
						FROM CHI_TIET_DON_HANG WHERE CHI_TIET_DON_HANG.MADH = DON_HANG.MADH
						)
						WHERE DON_HANG.MADH IN (SELECT DISTINCT deleted.MADH FROM deleted)

	--cập nhật lại số lượng tồn và đã bán
	UPDATE BAN
	SET SO_LUONG_TON = SO_LUONG_TON + deleted.SO_LUONG_MUA,
		SO_LUONG_DA_BAN = SO_LUONG_DA_BAN - deleted.SO_LUONG_MUA
	FROM BAN JOIN deleted ON (BAN.MASP = deleted.MASP)
	WHERE BAN.MACN IN (SELECT DISTINCT DON_HANG.MACN
					FROM (
					(SELECT deleted.MADH 
					FROM deleted) AS A
					 JOIN DON_HANG 
					 ON (DON_HANG.MADH = A.MADH)))	
END

--TRIGGER khi thêm chi nhiết nhập hàng
GO
CREATE OR ALTER
TRIGGER CHI_TIET_NHAP_HANG_INSERT
ON CHI_TIET_NHAP_HANG FOR INSERT
AS
BEGIN
	--Cập nhật lại số lượng tồn
	UPDATE BAN
	SET SO_LUONG_TON = SO_LUONG_TON + inserted.SO_LUONG_NHAP
	FROM inserted JOIN BAN
	ON BAN.MASP = inserted.MASP
	WHERE BAN.MACN IN (SELECT DISTINCT PHIEU_NHAP_HANG.MACN 
						FROM PHIEU_NHAP_HANG JOIN inserted
						ON (PHIEU_NHAP_HANG.MAPN = inserted.MAPN))


	--Cập nhật số mặt hàng sau khi thêm mới CHI_TIET_NHAP_HANG
	UPDATE PHIEU_NHAP_HANG
	SET PHIEU_NHAP_HANG.TONG_SO_MAT_HANG += (SELECT COUNT(*)
											FROM inserted
											WHERE PHIEU_NHAP_HANG.MAPN = inserted.MAPN
											GROUP BY inserted.MAPN
											)
	WHERE PHIEU_NHAP_HANG.MAPN IN (SELECT DISTINCT MAPN
									FROM inserted)


	-- Update lại TONG_TIEN_NHAP ở PHIEU_NHAP_HANG
	UPDATE PHIEU_NHAP_HANG
	SET TONG_TIEN_NHAP = ( SELECT SUM(CTNH.THANH_TIEN_NHAP)
						   FROM CHI_TIET_NHAP_HANG CTNH
						   WHERE CTNH.MAPN = PHIEU_NHAP_HANG.MAPN
						   GROUP BY CTNH.MAPN )
	FROM PHIEU_NHAP_HANG
END


-- PROCEDURE: Update SO_LUONG_NHAP hoặc DON_GIA_NHAP của CHI TIET NHAP HANG
GO
CREATE OR ALTER PROC USP_UPDATE_CT_NHAP_HANG
@MAPN INT, @MASP INT, @SL INT, @DON_GIA INT
AS
BEGIN
	DECLARE @SL_BD INT
	SELECT @SL_BD = SO_LUONG_NHAP FROM CHI_TIET_NHAP_HANG 
	WHERE MAPN = @MAPN AND MASP = @MASP
	UPDATE BAN
	SET SO_LUONG_TON = SO_LUONG_TON - @SL_BD + @SL
	FROM PHIEU_NHAP_HANG PN  
	WHERE PN.MACN = BAN.MACN
	AND PN.MAPN = @MAPN AND BAN.MASP = @MASP
	
	IF (@SL IS NULL) UPDATE CHI_TIET_NHAP_HANG SET DON_GIA_NHAP = @DON_GIA
	ELSE IF (@DON_GIA IS NULL)  UPDATE CHI_TIET_NHAP_HANG SET SO_LUONG_NHAP = @SL
	-- Update lại TONG_TIEN_NHAP ở PHIEU_NHAP_HANG
	UPDATE PHIEU_NHAP_HANG
	SET TONG_TIEN_NHAP = ( SELECT SUM(CTNH.THANH_TIEN_NHAP)
						   FROM CHI_TIET_NHAP_HANG CTNH
						   WHERE CTNH.MAPN = @MAPN
						  )
	WHERE PHIEU_NHAP_HANG.MAPN = @MAPN
END

--TRIGGER khi xóa chi nhiết nhập hàng
GO
CREATE OR ALTER
TRIGGER CHI_TIET_NHAP_HANG_DELETE
ON CHI_TIET_NHAP_HANG FOR DELETE
AS
BEGIN
	--Cập nhật lại số lượng tồn của BAN
	UPDATE BAN
	SET SO_LUONG_TON = SO_LUONG_TON - deleted.SO_LUONG_NHAP
	FROM deleted JOIN BAN
	ON BAN.MASP = deleted.MASP
	WHERE BAN.MACN IN (SELECT DISTINCT PHIEU_NHAP_HANG.MACN 
						FROM PHIEU_NHAP_HANG JOIN deleted
						ON (PHIEU_NHAP_HANG.MAPN = deleted.MAPN))

	--Cập nhật số mặt hàng còn lại sau khi xóa CHI_TIET_NHAP_HANG
	UPDATE PHIEU_NHAP_HANG
	SET PHIEU_NHAP_HANG.TONG_SO_MAT_HANG -= (SELECT COUNT(*)
											FROM deleted
											WHERE PHIEU_NHAP_HANG.MAPN = deleted.MAPN
											GROUP BY deleted.MAPN
											)
	WHERE PHIEU_NHAP_HANG.MAPN IN (SELECT DISTINCT MAPN
									FROM deleted)

	-- Update lại TONG_TIEN_NHAP ở PHIEU_NHAP_HANG
	UPDATE PHIEU_NHAP_HANG
	SET TONG_TIEN_NHAP = TONG_TIEN_NHAP - (SELECT SUM(deleted.THANH_TIEN_NHAP)
											FROM deleted
											WHERE PHIEU_NHAP_HANG.MAPN = deleted.MAPN
											GROUP BY deleted.MAPN )
	WHERE PHIEU_NHAP_HANG.MAPN IN (SELECT DISTINCT MAPN FROM deleted)
END


GO
CREATE OR ALTER PROC USP_UPDATE_VOUCHER_DH
@MADH INT, @MA_VOUCHER INT
AS
BEGIN
	DECLARE @MAKH INT
	SELECT @MAKH = MAKH FROM DON_HANG WHERE MADH = @MAKH
	IF (@MA_VOUCHER IS NOT NULL)
	BEGIN
		UPDATE DON_HANG
		SET DON_HANG.MA_VOUCHER = @MA_VOUCHER, DON_HANG.PHI_GIAM = (SELECT CASE 
								WHEN DON_HANG.TG_LAP_DH BETWEEN V.TG_BAT_DAU AND V.TG_KET_THUC 
									THEN(CASE 
											WHEN V.PHAN_TRAM_GIAM_GIA = 0 OR (DON_HANG.PHI_SAN_PHAM * V.PHAN_TRAM_GIAM_GIA / 100) >= V.GIAM_TOI_DA THEN V.GIAM_TOI_DA
											WHEN (DON_HANG.PHI_SAN_PHAM * V.PHAN_TRAM_GIAM_GIA / 100) < V.GIAM_TOI_DA THEN DON_HANG.PHI_SAN_PHAM * V.PHAN_TRAM_GIAM_GIA / 100
									END)
								WHEN DON_HANG.TG_LAP_DH NOT BETWEEN V.TG_BAT_DAU AND V.TG_KET_THUC THEN 0
								END
								FROM VOUCHER V 
								WHERE DON_HANG.MADH = @MADH
								AND V.MA_VOUCHER = @MA_VOUCHER
								)
		WHERE DON_HANG.MADH = @MADH
	END
	ELSE UPDATE DON_HANG SET MA_VOUCHER = @MA_VOUCHER, PHI_GIAM = 0 WHERE MADH = @MADH

	UPDATE DH
	SET DIEM_TICH_LUY = (PHI_SAN_PHAM - PHI_GIAM)/ 100 *  THE.PHAN_TRAM_TICH_LUY
	FROM DON_HANG DH JOIN KHACH_HANG KH ON DH.MAKH = KH.MAKH
	JOIN THE ON THE.MA_THE = KH.MA_THE
	WHERE MADH = @MADH

	UPDATE KHACH_HANG
	SET TONG_DIEM_TICH_LUY = (SELECT SUM(DIEM_TICH_LUY)
								FROM DON_HANG DH WHERE DH.MAKH = @MAKH AND DH.MADH = @MADH)
	WHERE KHACH_HANG.MAKH = @MAKH
	
END

GO
CREATE OR ALTER PROC USP_THEM_DON_HANG
@MAKH INT, @MANV INT, @MA_VOUCHER INT, @PHI_VAN_CHUYEN MONEY, @HTTT NVARCHAR(50), @TG_LAP_DH DATETIME
AS
BEGIN
	DECLARE @MACN INT
	SELECT @MACN = NHAN_VIEN.MACN FROM NHAN_VIEN WHERE NHAN_VIEN.MANV = @MANV

	INSERT DON_HANG(MAKH, MANV, MACN, MA_VOUCHER, PHI_VAN_CHUYEN, HINH_THUC_THANH_TOAN, SO_NHA_DUONG, PHUONG_XA, QUAN_TP, TP_TINH, TG_LAP_DH)
	VALUES (@MAKH, @MANV, @MACN, @MA_VOUCHER, @PHI_VAN_CHUYEN, @HTTT, NULL, NULL, NULL, NULL, @TG_LAP_DH)

	UPDATE DON_HANG
	SET SO_NHA_DUONG = DC.SO_NHA_DUONG, PHUONG_XA = DC.PHUONG_XA, QUAN_TP = DC.QUAN_TP, TP_TINH = DC.TP_TINH
	FROM DIA_CHI_KH DC
	WHERE MAC_DINH = 1 AND DON_HANG.MADH = @MAKH
	AND DC.MAKH = @MAKH

END

GO

--TRIGGER trên bảng CHI_TIET_NHAP_HANG cho việc thêm
--Cập nhật số mặt hàng sau khi thêm mới CHI_TIET_NHAP_HANG
CREATE OR ALTER 
TRIGGER TG_TONGMATHANG_INSERT_CTNHAPHANG
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


--TRIGGER trên bảng CHI_TIET_NHAP_HANG cho việc xóa
--Cập nhật số mặt hàng còn lại sau khi xóa CHI_TIET_NHAP_HANG
GO
CREATE OR ALTER 
TRIGGER TG_TONGMATHANG_DELETE_CTNHAPHANG
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

GO
-- PROC: Update trạng thái của đơn hàng
CREATE OR ALTER 
PROC USP_UPDATE_TRANG_THAI
@MaDH INT, @TrangThai NVARCHAR(10), @ThoiGian DATETIME
AS
BEGIN
	DECLARE @TTBanDau NVARCHAR(10), @TGBanDau DATETIME
	SELECT @TTBanDau = DH.TRANG_THAI, @TGBanDau = DH.TG_TRANG_THAI
	FROM DON_HANG DH
	WHERE DH.MADH = @MaDH
	IF (@TGBanDau > @ThoiGian)
	BEGIN
		PRINT N'LỖI: Thời gian trạng thái mới < Thời gian trạng thái hiện tại'
		RETURN 1 -- Không thành công
	END
	IF (@TTBanDau IN (N'Đã giao', N'Đã hủy'))
	BEGIN
		PRINT N'Không cập nhật trạng thái đơn hàng khi đơn hàng đã giao / đã hủy'
		RETURN 1
	END
	IF (@TrangThai = N'Chờ giao' AND @TTBanDau IS NOT NULL)
	BEGIN
		PRINT N'Trạng thái phải cập nhật theo thứ tự: Chờ giao -> Đã giao/Đã hủy'
		RETURN 1
	END
	UPDATE DON_HANG SET TRANG_THAI = @TrangThai, TG_TRANG_THAI = @ThoiGian
	WHERE MADH = @MaDH
	IF (@TrangThai = N'Đã giao')
	BEGIN
		DECLARE @PHI MONEY,  @MANV INT
		SELECT @MANV = MANV, @PHI = PHI_SAN_PHAM  FROM DON_HANG WHERE MADH = @MaDH
		UPDATE NHAN_VIEN
		SET TONG_DON_BAN +=1, TONG_TIEN_BAN += @PHI
		WHERE MANV = @MANV
	END
	RETURN 0 -- Cập nhật thành công
END

-- Mỗi khách hàng chỉ có duy nhất 1 địa chỉ mặc định
GO
CREATE OR ALTER
PROC USP_ADD_DIA_CHI_MAC_DINH
@MaKH INT, @STT INT
AS
BEGIN
	UPDATE DIA_CHI_KH SET MAC_DINH = 1 WHERE MAKH = @MaKH AND STT = @STT
	UPDATE DIA_CHI_KH SET MAC_DINH = 0 WHERE MAKH = @MaKH AND STT != @STT
END


-- Hiệu suất làm việc của nhân viên thay đổi khi update MANV (nhân viên quản lý đơn hàng) của bảng DON_HANG
-- Update nhân viên phụ trách đơn hàng
GO
CREATE OR ALTER 
PROC USP_UPDATE_NV_DH
@NVSau INT, @MaDH INT
AS
BEGIN
	DECLARE @NVBanDau CHAR(8), @TongTien MONEY
	SELECT @NVBanDau = MANV, @TongTien = PHI_SAN_PHAM FROM DON_HANG
	WHERE MADH = @MaDH

	IF (@NVBanDau = @NVSau)
	BEGIN
		PRINT N'Nhân viên không thay đổi!'
		RETURN 0 -- Thành công
	END
	UPDATE NHAN_VIEN SET TONG_DON_BAN -=1, TONG_TIEN_BAN -= @TongTien
	WHERE MANV = @NVBanDau
	UPDATE NHAN_VIEN SET TONG_DON_BAN +=1, TONG_TIEN_BAN += @TongTien
	WHERE MANV = @NVSau
	UPDATE DON_HANG SET MANV = @NVSau WHERE MADH = @MaDH
	RETURN 0
END

--Cập nhật lượt yêu thích ở bảng SAN_PHAM 
		--khi insert YEUTHICH
GO
CREATE OR ALTER
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
CREATE OR ALTER
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
CREATE OR ALTER
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
CREATE OR ALTER
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

GO
-- Thống kê doanh thu của chi nhánh - Dùng khi cập nhật hoặc thêm thống kê
CREATE OR ALTER 
PROC USP_TINH_DOANH_THU
@MaCN INT,  @NgayThongKe DATE
AS
BEGIN
	DECLARE @DoanhThu MONEY
	SELECT @DoanhThu = SUM(PHI_SAN_PHAM)
	FROM DON_HANG
	WHERE MACN = @MaCN
	AND TRANG_THAI = N'Đã giao'
	AND CAST(TG_TRANG_THAI AS date) = @NgayThongKe

	IF EXISTS(SELECT MACN FROM DOANH_THU WHERE MACN = @MaCN AND NGAY_THONG_KE = @NgayThongKe)
	BEGIN
	UPDATE DOANH_THU SET DOANH_THU = @DoanhThu WHERE MACN = @MaCN AND NGAY_THONG_KE = @NgayThongKe
	END
	ELSE BEGIN
	INSERT DOANH_THU(MACN, NGAY_THONG_KE, DOANH_THU) VALUES (@MaCN, @NgayThongKe, @DoanhThu)
	END
END
GO
-- Thêm địa chỉ khách hàng (Tự động tính STT tiếp theo, không cần chèn vào)
CREATE OR ALTER PROC USP_INSERT_DIA_CHI_KH
@MAKH INT, @SONHA NVARCHAR(60), @PHUONG NVARCHAR(40), @QUAN NVARCHAR(40), @TP NVARCHAR(40), @MAC_DINH BIT
AS
BEGIN
	DECLARE @STT INT
	SELECT @STT = ISNULL(MAX(STT),0)+1
    FROM DIA_CHI_KH
    WHERE MAKH = @MAKH
	IF (@MAC_DINH = 1)
	BEGIN
		EXEC USP_ADD_DIA_CHI_MAC_DINH @MAKH, @STT
	END
	INSERT DIA_CHI_KH VALUES (@MAKH, @STT, @SONHA, @PHUONG, @QUAN, @TP, @MAC_DINH)
END

-- Xóa địa chỉ khách hàng
GO
CREATE OR ALTER PROC USP_DELETE_DIA_CHI_KH
@MAKH INT, @STT INT
AS
BEGIN
	DECLARE @MAX_STT INT
	SELECT @MAX_STT = MAX(STT) FROM DIA_CHI_KH
	DELETE DIA_CHI_KH WHERE MAKH = @MAKH AND STT = @STT
	UPDATE DIA_CHI_KH SET STT = @STT WHERE STT = @MAX_STT
END



-- FLOW ĐẶT HÀNG --
-- EXEC USP_THEM_DON_HANG --> EXEC USP_THEM_CTDH (thêm đủ các mặt hàng) --> EXEC USP_UPDATE_VOUCHER_DH để tính phí giảm, tổng phí và điểm tích lũy cuối cùng.






--====================================--
SELECT * FROM DIA_CHI_KH WHERE MAKH = 1707021
EXEC USP_ADD_DIA_CHI_MAC_DINH 1707021, 4
SELECT * FROM BAN WHERE MACN = 7608170 AND MASP = 5593976
EXEC USP_THEM_CTDH 10000004, 5593976, 3, 5
SELECT * FROM BAN WHERE MACN = 7608170 AND MASP = 5593976
SELECT * FROM DON_HANG  WHERE MADH = 10000004


EXEC USP_THEM_DON_HANG 1707021, 9303796, 3132929, 30000, N'COD', '2021-11-10 11:14:01.810'
EXEC USP_UPDATE_VOUCHER_DH 10000004, 3132929
SELECT * FROM CHI_TIET_DON_HANG WHERE MADH = 10000003
SELECT * FROM DON_HANG  WHERE MADH = 10000003
SELECT * FROM NHAN_VIEN  WHERE MACN = 7608170 
--CHẠY ĐỂ CẬP NHẬT LẠI THANH_TIEN_MUA ĐÚNG
UPDATE CHI_TIET_DON_HANG
SET THANH_TIEN_MUA = 0
UPDATE DON_HANG
SET DIEM_TICH_LUY = 0
SELECT * FROM DON_HANG WHERE MADH = 582511
SELECT CHI_TIET_DON_HANG.*, SP.GIA_BAN FROM CHI_TIET_DON_HANG JOIN SAN_PHAM SP ON SP.MASP = CHI_TIET_DON_HANG.MASP WHERE MADH = 582511
-- CHẠY ĐỂ CẬP NHẬT LẠI DOANH THU. KHI THÊM MỚI HOẶC CẬP NHẬT 1 THỐNG KÊ BẤT KỲ, CHẠY PROCEDURE USP_TINH_DOANH_THU
UPDATE DT SET DOANH_THU = (SELECT SUM(PHI_SAN_PHAM)
							FROM DON_HANG DH 
							WHERE DH.MACN = DT.MACN
							AND NGAY_THONG_KE = CAST(DH.TG_TRANG_THAI AS date)
							AND DH.TRANG_THAI = N'Đã giao'
							)
FROM DOANH_THU DT JOIN DON_HANG DH
ON DH.MACN = DT.MACN
AND NGAY_THONG_KE = CAST(DH.TG_TRANG_THAI AS date)
AND DH.TRANG_THAI = N'Đã giao'

SELECT SAN_PHAM.GIA_BAN, CTDH.*
FROM SAN_PHAM JOIN CHI_TIET_DON_HANG CTDH ON SAN_PHAM.MASP = CTDH.MASP

SELECT * FROM CHI_TIET_DON_HANG WHERE MADH = 582519

SELECT * FROM VOUCHER WHERE MA_VOUCHER = 3132929
SELECT * FROM DON_HANG
SELECT * FROM KHACH_HANG JOIN THE ON KHACH_HANG.MA_THE = THE.MA_THE
WHERE KHACH_HANG.MAKH = 707023

SELECT * FROM CHI_TIET_DON_HANG WHERE  MADH = 582509
SELECT * FROM DON_HANG

UPDATE CT
SET THANH_TIEN_MUA = SO_LUONG_MUA * SAN_PHAM.GIA_BAN *(  1 - GIAM_GIA / 100)
FROM CHI_TIET_DON_HANG CT JOIN SAN_PHAM ON CT.MASP = SAN_PHAM.MASP
WHERE  MADH = 582509

SELECT * FROM CHI_TIET_DON_HANG WHERE  MADH = 9999999
SELECT * FROM DON_HANG WHERE  MADH = 9999999

EXEC USP_UPDATE_SLMUA_GIAM_GIA_CTDH 9999999, 5593970, 3, NULL
SELECT * FROM DON_HANG WHERE  MADH = 9999999

SELECT * FROM CHI_TIET_DON_HANG WHERE  MADH = 9999999

SELECT * FROM SAN_PHAM  WHERE MASP IN (SELECT MASP FROM CHI_TIET_DON_HANG WHERE MADH = 9999999)
						