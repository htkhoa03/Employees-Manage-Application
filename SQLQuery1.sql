	-- Tạo cơ sở dữ liệu
CREATE DATABASE QuanLyNhanVien;
-- Sử dụng cơ sở dữ liệu mới
USE QuanLyNhanVien;

-- Tạo bảng Nhân viên
CREATE TABLE NhanVien (
    MaSo INT PRIMARY KEY,
    Ten NVARCHAR(100),
    NgaySinh DATE,
    Email NVARCHAR(100),
    PhongBan NVARCHAR(50),
    Luong VARBINARY(MAX),
    MaSoThue NVARCHAR(50),
    TenDangNhap NVARCHAR(50),
    MatKhau VARBINARY(MAX),
    VaiTro NVARCHAR(50)
);


-- Tạo stored procedure để thêm nhân viên và mã hóa lương và mật khẩu bằng SHA-256
CREATE PROCEDURE AddEmployee
    @MaSo INT,
    @Ten NVARCHAR(100),
    @NgaySinh DATE,
    @Email NVARCHAR(100),
    @PhongBan NVARCHAR(50),
    @Luong DECIMAL(10,2),
    @MaSoThue NVARCHAR(50),
    @TenDangNhap NVARCHAR(50),
    @MatKhau NVARCHAR(50),
    @VaiTro NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Mã hóa lương bằng AES
    DECLARE @EncryptedSalary VARBINARY(MAX);
    SET @EncryptedSalary = ENCRYPTBYPASSPHRASE('YourEncryptionPassphrase', CAST(@Luong AS NVARCHAR(50)));

    -- Mã hóa mật khẩu bằng AES
    DECLARE @EncryptedPassword VARBINARY(MAX);
    SET @EncryptedPassword = ENCRYPTBYPASSPHRASE('YourEncryptionPassphrase', @MatKhau);

    -- Thêm nhân viên vào bảng
    INSERT INTO NhanVien (MaSo, Ten, NgaySinh, Email, PhongBan, Luong, MaSoThue, TenDangNhap, MatKhau, VaiTro)
    VALUES (@MaSo, @Ten, @NgaySinh, @Email, @PhongBan, @EncryptedSalary, @MaSoThue, @TenDangNhap, @EncryptedPassword, @VaiTro);
END;
GO

-- Gọi stored procedure AddEmployee với các tham số tương ứng
EXEC AddEmployee @MaSo = 1, @Ten = N'Test Employee', @NgaySinh = '2000-01-01', @Email = N'test@example.com', @PhongBan = N'IT Department', @Luong = 5000.00, @MaSoThue = N'123456789', @TenDangNhap = N'testuser', @MatKhau = N'testpassword', @VaiTro = N'User';
EXEC AddEmployee @MaSo = 2, @Ten = N'Employee1', @NgaySinh = '2002-01-01', @Email = N'test@example.com', @PhongBan = N'IT Department', @Luong = 5010.00, @MaSoThue = N'123136789', @TenDangNhap = N'testuser1', @MatKhau = N'testpassword1', @VaiTro = N'User';
EXEC AddEmployee @MaSo = 3, @Ten = N'Employee2', @NgaySinh = '1998-05-01', @Email = N'admin@example.com', @PhongBan = N'IT Department', @Luong = 5010.00, @MaSoThue = N'12123213', @TenDangNhap = N'admin1', @MatKhau = N'adminpassword1', @VaiTro = N'Admin';
EXEC AddEmployee @MaSo = 4, @Ten = N'Employee3', @NgaySinh = '1999-12-11', @Email = N'userhr@example.com', @PhongBan = N'HumanResource', @Luong = 5510.00, @MaSoThue = N'65765213', @TenDangNhap = N'hradmin1', @MatKhau = N'hradmin1', @VaiTro = N'HumanResource_User';
EXEC AddEmployee @MaSo = 6, @Ten = N'Employee4', @NgaySinh = '1972-11-07', @Email = N'adminhr@example.com', @PhongBan = N'HumanResource', @Luong = 6000.00, @MaSoThue = N'1321312321', @TenDangNhap = N'hradmin2', @MatKhau = N'hradmin2', @VaiTro = N'HumanResource_Admin';

CREATE PROCEDURE UpdateEmployee
    @MaSo INT,
    @Ten NVARCHAR(100),
    @NgaySinh DATE,
    @Email NVARCHAR(100),
    @PhongBan NVARCHAR(50),
    @Luong DECIMAL(10,2),
    @MaSoThue NVARCHAR(50),
    @TenDangNhap NVARCHAR(50),
    @MatKhau NVARCHAR(50),
    @VaiTro NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Mã hóa lương bằng AES
    DECLARE @EncryptedSalary VARBINARY(MAX);
    SET @EncryptedSalary = ENCRYPTBYPASSPHRASE('YourEncryptionPassphrase', CAST(@Luong AS NVARCHAR(50)));

    -- Mã hóa mật khẩu bằng AES
    DECLARE @EncryptedPassword VARBINARY(MAX);
    SET @EncryptedPassword = ENCRYPTBYPASSPHRASE('YourEncryptionPassphrase', @MatKhau);

    -- Cập nhật thông tin nhân viên trong bảng
    UPDATE NhanVien
    SET Ten = @Ten,
        NgaySinh = @NgaySinh,
        Email = @Email,
        PhongBan = @PhongBan,
        Luong = @EncryptedSalary,
        MaSoThue = @MaSoThue,
        TenDangNhap = @TenDangNhap,
        MatKhau = @EncryptedPassword,
        VaiTro = @VaiTro
    WHERE MaSo = @MaSo;
END;


CREATE PROCEDURE LoginAndGetRole
    @TenDangNhap NVARCHAR(50),
    @MatKhau NVARCHAR(50),
    @VaiTro NVARCHAR(50) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Giải mã mật khẩu
    DECLARE @DecryptedPassword NVARCHAR(50);
    SELECT @DecryptedPassword = CONVERT(NVARCHAR(50), DECRYPTBYPASSPHRASE('YourEncryptionPassphrase', MatKhau))
    FROM NhanVien
    WHERE TenDangNhap = @TenDangNhap;

    -- Kiểm tra đăng nhập và lấy vai trò từ cơ sở dữ liệu
    IF @DecryptedPassword = @MatKhau
    BEGIN
        SELECT @VaiTro = VaiTro
        FROM NhanVien
        WHERE TenDangNhap = @TenDangNhap;
    END
    ELSE
    BEGIN
        -- Trường hợp mật khẩu không khớp
        SET @VaiTro = 'Invalid';
    END
END;


CREATE PROCEDURE GetEmployeesInUserDepartment
    @TenDangNhap NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @PhongBan NVARCHAR(50);

    -- Lấy thông tin về phòng ban của người dùng từ tên đăng nhập
    SELECT @PhongBan = PhongBan FROM NhanVien WHERE TenDangNhap = @TenDangNhap;

    -- Kiểm tra xem có tồn tại phòng ban cho người dùng hay không
    IF @PhongBan IS NOT NULL
    BEGIN
        -- Lấy thông tin của nhân viên trong phòng ban và giải mã dữ liệu lương
        SELECT MaSo, Ten, NgaySinh, Email, PhongBan,
               CAST(CONVERT(DECIMAL(10, 2), CAST(DecryptByPassPhrase('YourEncryptionPassphrase', CONVERT(VARBINARY(MAX), Luong, 1)) AS NVARCHAR(MAX))) AS DECIMAL(10, 2)) AS Luong,
               MaSoThue, TenDangNhap, VaiTro
        FROM NhanVien
        WHERE PhongBan = @PhongBan;
    END
    ELSE
    BEGIN
        -- Nếu không tìm thấy thông tin phòng ban cho người dùng
        PRINT 'Không tìm thấy thông tin phòng ban cho người dùng.';
    END
END;

CREATE PROCEDURE GetAllEmployeesExceptUserDepartment
    @TenDangNhap NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @PhongBan NVARCHAR(50);

    -- Lấy thông tin về phòng ban của người dùng từ tên đăng nhập
    SELECT @PhongBan = PhongBan FROM NhanVien WHERE TenDangNhap = @TenDangNhap;

    -- Kiểm tra xem có tồn tại phòng ban cho người dùng hay không
    IF @PhongBan IS NOT NULL
    BEGIN
        -- Lấy thông tin của nhân viên không thuộc phòng ban của người dùng và giải mã dữ liệu mật khẩu và lương
        SELECT MaSo, Ten, NgaySinh, Email, PhongBan,
               CAST(CONVERT(DECIMAL(10, 2), CAST(DecryptByPassPhrase('YourEncryptionPassphrase', CONVERT(VARBINARY(MAX), Luong, 1)) AS NVARCHAR(MAX))) AS DECIMAL(10, 2)) AS Luong,
               MaSoThue, TenDangNhap,
               CONVERT(NVARCHAR(50), DECRYPTBYPASSPHRASE('YourEncryptionPassphrase', MatKhau)) AS MatKhau,
               VaiTro
        FROM NhanVien
        WHERE PhongBan != @PhongBan;
    END
    ELSE
    BEGIN
        -- Nếu không tìm thấy thông tin phòng ban cho người dùng
        PRINT 'Không tìm thấy thông tin phòng ban cho người dùng.';
    END
END;

CREATE PROCEDURE GetAllEmployees
    @TenDangNhap NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @PhongBan NVARCHAR(50);

    -- Lấy thông tin về phòng ban của người dùng từ tên đăng nhập
    SELECT @PhongBan = PhongBan FROM NhanVien WHERE TenDangNhap = @TenDangNhap;

    -- Kiểm tra xem có tồn tại phòng ban cho người dùng hay không
    IF @PhongBan IS NOT NULL
    BEGIN
        -- Lấy thông tin của nhân viên không thuộc phòng ban của người dùng và giải mã dữ liệu mật khẩu và lương
        SELECT MaSo, Ten, NgaySinh, Email, PhongBan,
               CAST(CONVERT(DECIMAL(10, 2), CAST(DecryptByPassPhrase('YourEncryptionPassphrase', CONVERT(VARBINARY(MAX), Luong, 1)) AS NVARCHAR(MAX))) AS DECIMAL(10, 2)) AS Luong,
               MaSoThue, TenDangNhap,
               CONVERT(NVARCHAR(50), DECRYPTBYPASSPHRASE('YourEncryptionPassphrase', MatKhau)) AS MatKhau,
               VaiTro
        FROM NhanVien
    END
    ELSE
    BEGIN
        -- Nếu không tìm thấy thông tin phòng ban cho người dùng
        PRINT 'Không tìm thấy thông tin phòng ban cho người dùng.';
    END
END;


-- Tạo bảng nhật ký (audit table)
CREATE TABLE AuditLog (
    LogID INT PRIMARY KEY IDENTITY,
    ActionType NVARCHAR(50),
    TableName NVARCHAR(50),
    RecordID INT,
    RecordData NVARCHAR(MAX),
    ModifiedBy NVARCHAR(100),
    ModifiedDate DATETIME
);

-- Tạo trigger cho INSERT, UPDATE, DELETE trên bảng nhân viên
CREATE TRIGGER LogEmployeeChanges
ON NhanVien
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ActionType NVARCHAR(50);
    DECLARE @TableName NVARCHAR(50) = 'NhanVien';
    DECLARE @RecordID INT;
    DECLARE @RecordData NVARCHAR(MAX);
    DECLARE @ModifiedBy NVARCHAR(50) = SYSTEM_USER;
    DECLARE @ModifiedDate DATETIME = GETDATE();

    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        IF EXISTS (SELECT * FROM deleted)
        BEGIN
            SET @ActionType = 'UPDATE';
            SELECT @RecordData = (
                SELECT CONVERT(NVARCHAR(MAX), i.MaSo) + ',' + CONVERT(NVARCHAR(MAX), i.Ten) + ',' + CONVERT(NVARCHAR(MAX), i.NgaySinh) + ',' + CONVERT(NVARCHAR(MAX), i.Email) + ',' + CONVERT(NVARCHAR(MAX), i.PhongBan) + ',' + CONVERT(NVARCHAR(MAX), i.Luong) + ',' + CONVERT(NVARCHAR(MAX), i.MaSoThue) + ',' + CONVERT(NVARCHAR(MAX), i.TenDangNhap) + ',' + CONVERT(NVARCHAR(MAX), i.MatKhau) + ',' + CONVERT(NVARCHAR(MAX), i.VaiTro) 
                FROM inserted i
                WHERE i.MaSo = (SELECT MaSo FROM deleted)
            );
        END
        ELSE
        BEGIN
            SET @ActionType = 'INSERT';
            SELECT @RecordData = (
                SELECT CONVERT(NVARCHAR(MAX), i.MaSo) + ',' + CONVERT(NVARCHAR(MAX), i.Ten) + ',' + CONVERT(NVARCHAR(MAX), i.NgaySinh) + ',' + CONVERT(NVARCHAR(MAX), i.Email) + ',' + CONVERT(NVARCHAR(MAX), i.PhongBan) + ',' + CONVERT(NVARCHAR(MAX), i.Luong) + ',' + CONVERT(NVARCHAR(MAX), i.MaSoThue) + ',' + CONVERT(NVARCHAR(MAX), i.TenDangNhap) + ',' + CONVERT(NVARCHAR(MAX), i.MatKhau) + ',' + CONVERT(NVARCHAR(MAX), i.VaiTro) 
                FROM inserted i
            );
        END
    END
    ELSE
    BEGIN
        SET @ActionType = 'DELETE';
        SELECT @RecordData = (
            SELECT CONVERT(NVARCHAR(MAX), d.MaSo) + ',' + CONVERT(NVARCHAR(MAX), d.Ten) + ',' + CONVERT(NVARCHAR(MAX), d.NgaySinh) + ',' + CONVERT(NVARCHAR(MAX), d.Email) + ',' + CONVERT(NVARCHAR(MAX), d.PhongBan) + ',' + CONVERT(NVARCHAR(MAX), d.Luong) + ',' + CONVERT(NVARCHAR(MAX), d.MaSoThue) + ',' + CONVERT(NVARCHAR(MAX), d.TenDangNhap) + ',' + CONVERT(NVARCHAR(MAX), d.MatKhau) + ',' + CONVERT(NVARCHAR(MAX), d.VaiTro) 
            FROM deleted d
        );
    END

    -- Insert the log record into AuditLog table
    INSERT INTO AuditLog (ActionType, TableName, RecordID, RecordData, ModifiedBy, ModifiedDate)
    VALUES (@ActionType, @TableName, @RecordID, @RecordData, @ModifiedBy, @ModifiedDate);
END;


	SELECT * FROM AuditLog;

