CREATE PROC [dbo].[SP_KiemTraTaiKhoanTrung]
	@LGNAME VARCHAR(50)
AS

DECLARE @CHECK NVARCHAR(10), @RESULT INT
  SELECT @CHECK=name FROM sys.server_principals WHERE name = 'kdthien'
  IF @CHECK IS NOT NULL
  SET @RESULT = 1
  ELSE SET @RESULT = 0

  SELECT @RESULT AS 'Result'  


