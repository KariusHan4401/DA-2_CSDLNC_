USE QUANLYCONCUNG
GO
CREATE OR ALTER 
PROC uspTimDiaChiCN
(
	@QuanFlag AS BIT,
	@Quan AS NVARCHAR(40),
	@TPFlag AS BIT,
	@Tpho AS NVARCHAR(40)
)
AS
BEGIN
	--Kiểm tra dữ liệu "Quận" có tồn tại trong CSDL
	IF NOT EXISTS (SELECT QUAN_TP FROM CHI_NHANH WHERE QUAN_TP = @Quan)
	BEGIN
		PRINT N'KIỂM TRA LẠI THÔNG TIN'
		RETURN
	END
	--Kiểm tra dữ liệu "Thành phố" có tồn tại trong CSDL
	IF NOT EXISTS (SELECT TP_TINH FROM CHI_NHANH WHERE TP_TINH = @Tpho)
	BEGIN
		PRINT N'KIỂM TRA LẠI THÔNG TIN'
		RETURN
	END

	IF @QuanFlag = 1 AND @TPFlag = 0
	BEGIN
		SELECT MACN, SO_NHA_DUONG,
			PHUONG_XA, QUAN_TP, TP_TINH
		FROM CHI_NHANH CN 
		WHERE QUAN_TP = @Quan
		RETURN
	END
	IF @TPFlag = 1 AND @QuanFlag = 0
	BEGIN
		SELECT MACN, SO_NHA_DUONG, PHUONG_XA, QUAN_TP, TP_TINH
		FROM CHI_NHANH CN 
		WHERE TP_TINH = @Tpho
		RETURN
	END
	IF @TPFlag = 1 AND @QuanFlag = 1
	BEGIN
		SELECT MACN, SO_NHA_DUONG, PHUONG_XA, QUAN_TP, TP_TINH
		FROM CHI_NHANH CN 
		WHERE TP_TINH = @Tpho 
			AND QUAN_TP = @Quan
		RETURN
	END
	ELSE RETURN
END

GO
CREATE OR ALTER
PROC uspTimKH
(
	@IDKH AS CHAR(8)
)
AS
BEGIN
	--Kiểm tra mã khách hàng có tồn tại không
	IF NOT EXISTS(SELECT MAKH FROM KHACH_HANG  WHERE MAKH = @IDKH)
	BEGIN
		PRINT N'DỮ LIỆU KHÔNG TỒN TẠI'
		RETURN
	END
	
	SELECT MAKH, TENKH, EMAIL_KH,SDT_KH, NGSINH_KH
	FROM KHACH_HANG
	WHERE MAKH = @IDKH
END

--Tìm với địa chỉ CN tại Quan_TP: 2
EXEC uspTimDiaChiCN 1,2,0,N'Kon Tum'
--Tìm với địa chỉ CN tại Quan_TP: 13
EXEC uspTimDiaChiCN 1,13,0,N'Kon Tum'
--Tìm với địa chỉ CN tại Quan_TP: 2, TP_Tinh: KonTum
EXEC uspTimDiaChiCN 1,2,1,N'Kon Tum'
--Tìm với địa chỉ CN tại TP_Tinh: KonTum
EXEC uspTimDiaChiCN 0,2,1,N'Kon Tum'
--Tìm với địa chỉ CN tại TP_Tinh: Alaska
EXEC uspTimDiaChiCN 0,2,1,N'Alaska'

--Tìm thông tin khách hàng
EXEC uspTimKH 'BH000001'
EXEC uspTimKH 'KH000001'