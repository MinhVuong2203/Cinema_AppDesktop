CREATE DATABASE arenaapp;
USE arenaapp;

CREATE TABLE Role(
	RoleID INT PRIMARY KEY IDENTITY,
	RoleName NVARCHAR(100) NOT NULL
);
INSERT INTO Role (RoleName)
VALUES 
    (N'Admin'),
    (N'Nhân viên bán vé'),
    (N'Nhân viên kỹ thuật'),
    (N'Nhân viên phim'),
    (N'Tạp vụ'),
    (N'Bảo vệ');


-- PEOPLE GROUP
CREATE TABLE Employee (
    EmployeeID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    FullName NVARCHAR(100) NOT NULL,
    Phone VARCHAR(20) UNIQUE,
    Email NVARCHAR(100) UNIQUE,
    Address NVARCHAR(255),
    BirthDate DATE,
    HourWage INT,
    CCCD NVARCHAR(20) UNIQUE,
    Gender NVARCHAR(10),
    RoleId INT,
    ImageUrl NVARCHAR(255),
    RegisterDate DATE DEFAULT GETDATE(),
    IsDeleted BIT DEFAULT 0 NOT NULL,
	FOREIGN KEY (RoleId) REFERENCES Role(RoleID) ON UPDATE CASCADE ON DELETE SET NULL
);

SELECT 
    tc.CONSTRAINT_NAME,
    kcu.COLUMN_NAME
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc
JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE kcu
     ON tc.CONSTRAINT_NAME = kcu.CONSTRAINT_NAME
WHERE tc.CONSTRAINT_TYPE = 'UNIQUE'
  AND tc.TABLE_NAME = 'Employee';





INSERT INTO Employee (FullName, Phone, Email, Address, BirthDate, HourWage, CCCD, Gender, RoleId, ImageUrl)
VALUES
(N'Nguyễn Văn Anh', '0901000001', 'admin@cinema.vn', N'Quận 1, TP.HCM', '1990-01-01', 50000, N'079200000001', N'Nam', 1, N'/images/employees/admin.jpg'),
(N'Lê Thị Béo', '0901000002', 'sales@cinema.vn', N'Quận 2, TP.HCM', '1995-02-15', 30000, N'079200000002', N'Nữ', 2, N'/images/employees/sales.jpg'),
(N'Trần Văn Chú', '0901000003', 'technical@cinema.vn', N'Quận 3, TP.HCM', '1992-05-20', 32000, N'079200000003', N'Nam', 3, N'/images/employees/technical.jpg'),
(N'Phạm Thị Dung', '0901000004', 'movie@cinema.vn', N'Quận 4, TP.HCM', '1998-03-30', 28000, N'079200000004', N'Nữ', 4, N'/images/employees/movie.jpg'),
(N'Đỗ Văn Em', '0901000005', 'housekeeping@cinema.vn', N'Quận 5, TP.HCM', '1988-08-12', 25000, N'079200000005', N'Nam', 5, N'/images/employees/housekeeping.jpg'),
(N'Võ Thị Lài', '0901000006', 'security@cinema.vn', N'Quận 6, TP.HCM', '1991-09-09', 26000, N'079200000006', N'Nữ', 6, N'/images/employees/security.jpg');



CREATE TABLE Setting (
    EmployeeID UNIQUEIDENTIFIER PRIMARY KEY,         -- 🔹 vừa là khóa chính
    LanguageCode VARCHAR(10) DEFAULT 'vi-VN',        -- 🔹 mã ngôn ngữ
    FontText NVARCHAR(50) DEFAULT N'Segoe UI',       -- 🔹 font chữ
    SizeText INT DEFAULT 13,                         -- 🔹 kích thước chữ
    MainColor NVARCHAR(20) DEFAULT N'255,255,255',   -- 🔹 màu nền
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID) ON DELETE CASCADE
);
-- Trigger tạo Setting mặc định khi thêm nhân viên
CREATE OR ALTER TRIGGER trg_CreateSettingForEmployee
ON Employee
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Setting (EmployeeID, LanguageCode, FontText, SizeText, MainColor)
    SELECT i.EmployeeID, 'vi-VN', N'Segoe UI', 13, N'255,255,255'
    FROM inserted i;
END;
GO




CREATE TABLE Account(
	ID INT PRIMARY KEY IDENTITY,
	Username VARCHAR(50),
    PasswordHash VARCHAR(255),
	EmployeeID UNIQUEIDENTIFIER NOT NULL,
	RoleId INT NOT NULL,
	FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID) ON DELETE CASCADE,
	FOREIGN KEY (RoleId) REFERENCES Role(RoleId) ON DELETE CASCADE,
);

INSERT INTO Account (Username, PasswordHash, EmployeeID, RoleId)
VALUES
('admin', 'admin123',  (SELECT EmployeeID FROM Employee WHERE Email = 'admin@cinema.vn'), 1),
('sales', 'sales123',  (SELECT EmployeeID FROM Employee WHERE Email = 'sales@cinema.vn'), 2),
('tech', 'tech123',    (SELECT EmployeeID FROM Employee WHERE Email = 'technical@cinema.vn'), 3),
('movie', 'movie123',  (SELECT EmployeeID FROM Employee WHERE Email = 'movie@cinema.vn'), 4),
('house', 'house123',  (SELECT EmployeeID FROM Employee WHERE Email = 'housekeeping@cinema.vn'), 5),
('security', 'sec123', (SELECT EmployeeID FROM Employee WHERE Email = 'security@cinema.vn'), 6);


CREATE TABLE Customer (
    CustomerID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    FullName NVARCHAR(100),
    Phone VARCHAR(20) UNIQUE,
    Email NVARCHAR(100) UNIQUE,
	BirthDate NVARCHAR(100),
	Gender NVARCHAR(10),
    RegisterDate DATE DEFAULT GETDATE(),
    Point DECIMAL(18,2) DEFAULT 0 CHECK (Point >= 0), --1k - 1point, -- 500 point - Vip 1, 1000 point - Vip 2, 2000 point Vip 3, 5000 point - vip 4, 10000 point - vip 5
    VipLevel INT DEFAULT 0 CHECK (VipLevel >= 0),   -- Vip 1 - 3%, Vip 2 - 6%, Vip3 - 9%, Vip 4 - 12%, Vip 5 - 15%
    IsDeleted BIT DEFAULT 0 NOT NULL
);

CREATE TABLE WorkShift (
    ShiftID INT PRIMARY KEY IDENTITY,
    EmployeeID UNIQUEIDENTIFIER NOT NULL,
    StartTime DATETIME NOT NULL,
    EndTime DATETIME NOT NULL,
    WorkingHours FLOAT CHECK (WorkingHours >= 0), -- (số giờ làm việc)
    SalaryPerHour DECIMAL(18,2) CHECK (SalaryPerHour >= 0),  -- Giờ tiền lương của ca đó, nhằm fix lỗi thay đổi tiền lương nhân viên
    Status NVARCHAR(30), -- nghỉ phép, Vắng, Hoàn thành, Đang làm, Sắp làm
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID) ON DELETE CASCADE
);

-- MOVIE GROUP
CREATE TABLE Movie (
    MovieID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(200) NOT NULL,
    DurationMinutes INT NOT NULL CHECK (DurationMinutes > 0),
    Genre NVARCHAR(100),
    Language NVARCHAR(50), 
	Sub NVARCHAR(50), -- Tiếng anh, tiếng việt
	Dub BIT, -- Có, Không
    AgeLimit NVARCHAR(10), -- P, 13+, 16+, 18+, ...
	MovieType NVARCHAR(10),
	StartTime DATETIME,
	EndTime DATETIME,
    Description NVARCHAR(MAX),
	Preview NVARCHAR(MAX),
    ImageUrl NVARCHAR(255),
	LinkTrailer NVARCHAR(200),
    IsDeleted BIT DEFAULT 0 NOT NULL
);

CREATE TABLE Room (
    RoomID INT PRIMARY KEY IDENTITY(1,1),
    RoomName NVARCHAR(100) NOT NULL UNIQUE,
    SeatCount INT CHECK (SeatCount >= 0), -- Số lượng ghế: Max(150)
    Description NVARCHAR(MAX),
    RoomType NVARCHAR(50), -- '2D','3D','IMAX','4DX'
    ImageUrl NVARCHAR(255),
    IsDeleted BIT DEFAULT 0 NOT NULL
);

CREATE TABLE Seat (
    SeatID INT PRIMARY KEY IDENTITY (1,1),
    SeatName NVARCHAR(50) NOT NULL,
    SeatType NVARCHAR(50), -- 'Normal','VIP','Couple'
    RoomID INT NOT NULL,
    IsDeleted BIT DEFAULT 0 NOT NULL,
    FOREIGN KEY (RoomID) REFERENCES Room(RoomID) ON DELETE CASCADE,
    CONSTRAINT UQ_Seat UNIQUE (SeatName, RoomID)
);

CREATE TABLE ShowTime (
    ShowTimeID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    StartTime DATETIME NOT NULL,
    Price DECIMAL(18,2) NOT NULL CHECK (Price > 0),
    MovieID INT NOT NULL,
    RoomID INT NOT NULL,
    IsDeleted BIT DEFAULT 0 NOT NULL,
    FOREIGN KEY (MovieID) REFERENCES Movie(MovieID) ON DELETE CASCADE,
    FOREIGN KEY (RoomID) REFERENCES Room(RoomID) ON DELETE CASCADE
);


-- TICKET
CREATE TABLE Ticket (
    TicketID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    ShowTimeID UNIQUEIDENTIFIER NOT NULL,
    SeatID INT NOT NULL,
    TicketType NVARCHAR(50),
    Price DECIMAL(18,2) CHECK (Price >= 0),
    Status NVARCHAR(20),
	LockedBy UNIQUEIDENTIFIER NULL,  -- CustomerID
    LockedAt DATETIME NULL,
    IsDeleted BIT DEFAULT 0 NOT NULL,
    FOREIGN KEY (ShowTimeID) REFERENCES ShowTime(ShowTimeID) ON DELETE CASCADE,
    FOREIGN KEY (SeatID) REFERENCES Seat(SeatID),
    CONSTRAINT UQ_Ticket UNIQUE (ShowTimeID, SeatID)
);

-- PRODUCT GROUP
CREATE TABLE Product (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(100) NOT NULL,
    ProductType NVARCHAR(50), -- đồ ăn, đồ uống, quà lưu niệm, combo
    Price DECIMAL(18,2) CHECK (Price >= 0),
    ImageUrl NVARCHAR(255),
    IsDeleted BIT DEFAULT 0 NOT NULL
);

CREATE TABLE MovieProduct (
    MovieProductID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    MovieID INT NOT NULL,
    ProductID INT NOT NULL,
    OfferType NVARCHAR(20), -- miễn phí, riêng biệt
    Quantity INT CHECK (Quantity >= 0),
    Note NVARCHAR(255),
    FOREIGN KEY (MovieID) REFERENCES Movie(MovieID) ON DELETE CASCADE,
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID) ON DELETE CASCADE,
    CONSTRAINT UQ_MovieProduct UNIQUE (MovieID, ProductID)
);

-- INVOICE GROUP
CREATE TABLE Invoice (
    InvoiceID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    EmployeeID UNIQUEIDENTIFIER,
    CustomerID UNIQUEIDENTIFIER,
    IssueDate DATETIME DEFAULT GETDATE() NOT NULL, -- ngày phát hành
    TotalAmount DECIMAL(18,2) CHECK (TotalAmount >= 0), -- Tổng tiền (VND)
    Discount DECIMAL(18,2) DEFAULT 0 CHECK (Discount >= 0), -- Giám giá (VND)
    Status NVARCHAR(30), -- đang chờ xử lí, đã thanh toán, chưa thanh toán
    IsDeleted BIT DEFAULT 0 NOT NULL,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID) ON DELETE SET NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE SET NULL
);

CREATE TABLE InvoiceTicket (
    InvoiceTicketID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    InvoiceID UNIQUEIDENTIFIER NOT NULL,
    TicketID UNIQUEIDENTIFIER NOT NULL,
    Quantity INT DEFAULT 1 CHECK (Quantity > 0),
    UnitPrice DECIMAL(18,2) CHECK (UnitPrice >= 0),
    FOREIGN KEY (InvoiceID) REFERENCES Invoice(InvoiceID) ON DELETE CASCADE,
    FOREIGN KEY (TicketID) REFERENCES Ticket(TicketID) ON DELETE CASCADE,
    CONSTRAINT UQ_Invoice_Ticket UNIQUE (InvoiceID, TicketID)
);

CREATE TABLE InvoiceProduct (
    InvoiceProductID  UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    InvoiceID UNIQUEIDENTIFIER NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT DEFAULT 1 CHECK (Quantity > 0),
    UnitPrice DECIMAL(18,2) CHECK (UnitPrice >= 0),
    FOREIGN KEY (InvoiceID) REFERENCES Invoice(InvoiceID) ON DELETE CASCADE,
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID) ON DELETE CASCADE,
    CONSTRAINT UQ_Invoice_Product UNIQUE (InvoiceID, ProductID)
);

-- PAYMENT
CREATE TABLE Payment (
    PaymentID  UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    InvoiceID UNIQUEIDENTIFIER NOT NULL,
    Method NVARCHAR(50), -- tiền mặt, chuyển khoản
    Amount DECIMAL(18,2) CHECK (Amount >= 0), -- Số tiền
    PaymentTime DATETIME DEFAULT GETDATE(), -- Thời gian thanh toán
    FOREIGN KEY (InvoiceID) REFERENCES Invoice(InvoiceID) ON DELETE CASCADE
);


-- TABLE LANGUAGE
CREATE TABLE Language (
    LanguageCode VARCHAR(5) PRIMARY KEY, -- 'vi', 'en'
    LanguageName NVARCHAR(50) NOT NULL
);
INSERT INTO Language VALUES ('vi', N'Tiếng Việt'), ('en', N'English');

CREATE TABLE TextTranslation (
    TextKey VARCHAR(100) NOT NULL,        -- key duy nhất (ví dụ: ROLE_EMPLOYEE, STATUS_PAID)
    LanguageCode VARCHAR(5) NOT NULL,     -- 'vi', 'en'
    DisplayText NVARCHAR(255) NOT NULL,   -- chuỗi hiển thị
    PRIMARY KEY (TextKey, LanguageCode),
    FOREIGN KEY (LanguageCode) REFERENCES Language(LanguageCode)
);

-- Gender
INSERT INTO TextTranslation VALUES 
('MALE','vi',N'Nam'), ('MALE','en','Male'),
('FEMALE','vi',N'Nữ'), ('FEMALE','en','Female'),
('OTHER','vi',N'Khác'), ('OTHER','en','Other');

-- Role
INSERT INTO TextTranslation VALUES 
('EMPLOYEE','vi',N'Nhân viên'), ('EMPLOYEE','en','Employee'),
('ADMIN','vi',N'Quản trị'), ('ADMIN','en','Admin');

-- EmployeeChange Status
INSERT INTO TextTranslation VALUES
('PENDING','vi',N'Đang chờ'), ('PENDING','en','Pending'),
('APPROVED','vi',N'Đã duyệt'), ('APPROVED','en','Approved'),
('REJECTED','vi',N'Đã từ chối'), ('REJECTED','en','Rejected');

-- WorkShift Status
INSERT INTO TextTranslation VALUES
('SHIFT_PENDING','vi',N'Chờ duyệt ca'), ('SHIFT_PENDING','en','Pending approval'),
('SHIFT_APPROVED','vi',N'Đã duyệt ca'), ('SHIFT_APPROVED','en','Approved'),
('ABSENT','vi',N'Vắng'), ('ABSENT','en','Absent'),
('SHIFT_CANCELED','vi',N'Đã hủy'), ('SHIFT_CANCELED','en','Canceled'),
('SHIFT_REJECTED','vi',N'Không duyệt'), ('SHIFT_REJECTED','en','Rejected');

-- Movie AgeLimit
INSERT INTO TextTranslation VALUES
('AGE_P','vi',N'P (mọi lứa tuổi)'), ('AGE_P','en','P (all ages)'),
('AGE_13','vi',N'13+'), ('AGE_13','en','13+'),
('AGE_16','vi',N'16+'), ('AGE_16','en','16+'),
('AGE_18','vi',N'18+'), ('AGE_18','en','18+');

-- Movie Genre (bạn có thể mở rộng thêm nếu cần)
INSERT INTO TextTranslation VALUES
('GENRE_ACTION','vi',N'Hành động'), ('GENRE_ACTION','en','Action'),
('GENRE_COMEDY','vi',N'Hài'), ('GENRE_COMEDY','en','Comedy'),
('GENRE_DRAMA','vi',N'Tâm lý'), ('GENRE_DRAMA','en','Drama'),
('GENRE_HORROR','vi',N'Kinh dị'), ('GENRE_HORROR','en','Horror'),
('GENRE_ROMANCE','vi',N'Tình cảm'), ('GENRE_ROMANCE','en','Romance'),
('GENRE_SCIFI','vi',N'Khoa học viễn tưởng'), ('GENRE_SCIFI','en','Sci-Fi'),
('GENRE_ANIMATION','vi',N'Hoạt hình'), ('GENRE_ANIMATION','en','Animation'),
('GENRE_DOCU','vi',N'Tài liệu'), ('GENRE_DOCU','en','Documentary');

-- Movie Language (ví dụ)
INSERT INTO TextTranslation VALUES
('LANG_VI','vi',N'Tiếng Việt'), ('LANG_VI','en','Vietnamese'),
('LANG_EN','vi',N'Tiếng Anh'), ('LANG_EN','en','English'),
('LANG_JP','vi',N'Tiếng Nhật'), ('LANG_JP','en','Japanese'),
('LANG_KR','vi',N'Tiếng Hàn'), ('LANG_KR','en','Korean');

-- RoomType
INSERT INTO TextTranslation VALUES
('ROOM_2D','vi',N'2D'), ('ROOM_2D','en','2D'),
('ROOM_3D','vi',N'3D'), ('ROOM_3D','en','3D'),
('ROOM_IMAX','vi',N'IMAX'), ('ROOM_IMAX','en','IMAX'),
('ROOM_4DX','vi',N'4DX'), ('ROOM_4DX','en','4DX');

-- SeatType
INSERT INTO TextTranslation VALUES
('SEAT_NORMAL','vi',N'Thường'), ('SEAT_NORMAL','en','Normal'),
('SEAT_VIP','vi',N'VIP'), ('SEAT_VIP','en','VIP'),
('SEAT_COUPLE','vi',N'Đôi'), ('SEAT_COUPLE','en','Couple');

-- TicketType
INSERT INTO TextTranslation VALUES
('TICKET_STANDARD','vi',N'Tiêu chuẩn'), ('TICKET_STANDARD','en','Standard'),
('TICKET_STUDENT','vi',N'Sinh viên'), ('TICKET_STUDENT','en','Student'),
('TICKET_CHILD','vi',N'Trẻ em'), ('TICKET_CHILD','en','Child'),
('TICKET_COMBO','vi',N'Combo'), ('TICKET_COMBO','en','Combo');

-- Ticket Status
INSERT INTO TextTranslation VALUES
('AVAILABLE','vi',N'Còn trống'), ('AVAILABLE','en','Available'),
('SOLD','vi',N'Đã bán'), ('SOLD','en','Sold');

-- ProductType
INSERT INTO TextTranslation VALUES
('FOOD','vi',N'Đồ ăn'), ('FOOD','en','Food'),
('DRINK','vi',N'Đồ uống'), ('DRINK','en','Drink'),
('SOUVENIR','vi',N'Quà lưu niệm'), ('SOUVENIR','en','Souvenir'),
('COMBO','vi',N'Combo'), ('COMBO','en','Combo');

-- MovieProduct OfferType
INSERT INTO TextTranslation VALUES
('FREE','vi',N'Miễn phí'), ('FREE','en','Free'),
('SEPARATE','vi',N'Riêng biệt'), ('SEPARATE','en','Separate');

-- Invoice Status
INSERT INTO TextTranslation VALUES
('INVOICE_PENDING','vi',N'Đang chờ xử lí'), ('INVOICE_PENDING','en','Pending'),
('PAID','vi',N'Đã thanh toán'), ('PAID','en','Paid'),
('UNPAID','vi',N'Chưa thanh toán'), ('UNPAID','en','Unpaid');

-- Payment Method
INSERT INTO TextTranslation VALUES
('CASH','vi',N'Tiền mặt'), ('CASH','en','Cash'),
('BANK','vi',N'Chuyển khoản'), ('BANK','en','Bank Transfer');






DROP TABLE [dbo].[InvoiceTicket]
DROP TABLE [dbo].[InvoiceProduct]
DROP TABLE [dbo].[Payment]
DROP TABLE [dbo].[Invoice]
DROP TABLE [dbo].[Ticket]
DROP TABLE [dbo].[Seat]
DROP TABLE [dbo].[ShowTime]
DROP TABLE [dbo].[Room]
DROP TABLE [dbo].[MovieProduct]
DROP TABLE [dbo].[Product]
DROP TABLE [dbo].[Movie]
DROP TABLE [dbo].[Customer]
DROP TABLE [dbo].[EmployeeChange]
DROP TABLE [dbo].[WorkShift]
DROP TABLE [dbo].[Employee]

 
 INSERT INTO Employee 
(FullName, Phone, Email, Address, BirthDate, HourWage, CCCD, Gender, Role, Username, PasswordHash, ImageUrl, RegisterDate, IsDeleted)
VALUES
-- Quản lý
(N'Nguyễn Văn A', '0912345678', 'nguyenvana@company.com', N'123 Trần Hưng Đạo, Hà Nội', '1985-05-20', 30000, '012345678901', N'Nam', 'Admin', 'adminA', '123456', N'/images/adminA.jpg', GETDATE(), 0),

(N'Trần Thị B', '0923456789', 'tranthib@company.com', N'45 Lê Lợi, TP.HCM', '1990-08-15', 28000, '012345678902', N'Nữ', 'Admin', 'adminB', '123456', N'/images/adminB.jpg', GETDATE(), 0),

-- Nhân viên
(N'Lê Văn C', '0934567890', 'levanc@company.com', N'78 Hai Bà Trưng, Hà Nội', '1995-03-10', 20000, '012345678903', N'Nam', 'Employee', 'staffC', '123456', N'/images/staffC.jpg', GETDATE(), 0),

(N'Phạm Thị D', '0945678901', 'phamthid@company.com', N'56 Nguyễn Huệ, TP.HCM', '1998-11-25', 20000, '012345678904', N'Nữ', 'Employee', 'staffD', '123456', N'/images/staffD.jpg', GETDATE(), 0),

(N'Hoàng Văn E', '0956789012', 'hoange@company.com', N'12 Võ Thị Sáu, Đà Nẵng', '1997-07-07', 20000, '012345678905', N'Nam', 'Employee', 'staffE', '123456', N'/images/staffE.jpg', GETDATE(), 0),

(N'Ngô Thị F', '0967890123', 'ngothif@company.com', N'90 Lý Thường Kiệt, Huế', '2000-01-12', 20000, '012345678906', N'Nữ', 'Employee', 'staffF', '123456', N'/images/staffF.jpg', GETDATE(), 0);







