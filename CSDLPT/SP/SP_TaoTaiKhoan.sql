ALTER PROC [dbo].[SP_TaoTaiKhoan]
	@LGNAME VARCHAR(50),
	@PASS VARCHAR(50),
	@USERNAME VARCHAR(50),
	@ROLE VARCHAR(50)
AS
BEGIN
  DECLARE @RET INT
  BEGIN TRY
	EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'TRACNGHIEM'     
  END TRY
  BEGIN CATCH
	RAISERROR('Tên tài khoản đã tồn tại. Mời nhập tên tài khoản khác', 16, 1)
  END CATCH                

  IF (@RET = 1)  -- LOGIN NAME BI TRUNG
     RETURN 1

  EXEC @RET = SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET = 1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME

  IF @ROLE= 'Truong' 
	BEGIN
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END

  IF @ROLE= 'Coso'
	BEGIN 
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
  IF @ROLE= 'Giangvien'
	BEGIN  
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
  IF @ROLE= 'Sinhvien'
	BEGIN  
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
END

EXEC SP_TaoTaiKhoan 'KDTHIEN', '123456', 'TH04', 'Giangvien'
