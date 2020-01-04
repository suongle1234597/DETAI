ALTER PROC SP_KTBoDeNoiDung
	@NOIDUNG NVARCHAR(MAX),
	@A NVARCHAR(MAX),
	@B NVARCHAR(MAX),
	@C NVARCHAR(MAX),
	@D NVARCHAR(MAX)
AS
DECLARE @RESULT INT
BEGIN
SET @RESULT = 0
IF EXISTS (SELECT CAUHOI FROM BODE WHERE @NOIDUNG = cast([NOIDUNG] AS NVARCHAR(MAX)) AND @A = cast([A] AS NVARCHAR(MAX)) AND @B = cast([B] AS NVARCHAR(MAX)) AND @C = cast([C] AS NVARCHAR(MAX)) AND @D = cast([D] AS NVARCHAR(MAX))) 
	SET @RESULT = 1

SELECT @RESULT AS 'RESULT'
END

EXEC SP_KTBoDeNoiDung N'm?ng máy tính(compute netword) so v?i h? th?ng t?p trung multi-user', N'dễ phát triển hệ thống', N'tăng độ tin cậy', N'tiết kiệm chi phí', N'tất cả đều đúng'