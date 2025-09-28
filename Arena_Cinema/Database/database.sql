CREATE DATABASE ArenaCinema;
USE ArenaCinema;

-- PEOPLE GROUP
CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY IDENTITY(1000,1),
    FullName NVARCHAR(100) NOT NULL,
    Phone VARCHAR(20) UNIQUE,
    Email NVARCHAR(100) UNIQUE,
    Address NVARCHAR(255),
    BirthDate DATE,
	HourWage int,  -- 20.000đ /h giờ tiền lương thuộc về nhân viên
    CCCD NVARCHAR(20) UNIQUE,
    Gender NVARCHAR(10), -- Nam, nữ, khác
    Role NVARCHAR(20), -- employee, admin
    Username VARCHAR(50) UNIQUE,
    PasswordHash VARCHAR(255),
    ImageUrl NVARCHAR(255),
	RegisterDate DATE DEFAULT GETDATE(),
    IsDeleted BIT DEFAULT 0 NOT NULL
);

CREATE TABLE Customer (
    CustomerID INT PRIMARY KEY IDENTITY(1000,1),
    FullName NVARCHAR(100),
    Phone VARCHAR(20) UNIQUE,
    Email NVARCHAR(100) UNIQUE,
    RegisterDate DATE DEFAULT GETDATE(),
    Point INT DEFAULT 0 CHECK (Point >= 0),
    VipLevel INT DEFAULT 0 CHECK (VipLevel >= 0),
    IsDeleted BIT DEFAULT 0 NOT NULL
);

CREATE TABLE EmployeeChange (
    ChangeID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT NOT NULL,
    Phone VARCHAR(20),
    Email NVARCHAR(100),
    Address NVARCHAR(255),
    BirthDate DATE,
    Username VARCHAR(50),
    PasswordHash VARCHAR(255),
    ImageUrl NVARCHAR(255),
    Status NVARCHAR(30), -- đang chờ, đã duyệt, đã từ chối
    CreatedDate DATETIME DEFAULT GETDATE(), -- (ngày tạo)
    ApprovedDate DATETIME,  -- (ngày duyệt)
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID) ON DELETE CASCADE
);

CREATE TABLE WorkShift (
    ShiftID INT PRIMARY KEY IDENTITY,
    EmployeeID INT NOT NULL,
    StartTime DATETIME NOT NULL,
    EndTime DATETIME NOT NULL,
    WorkingHours FLOAT CHECK (WorkingHours >= 0), -- (số giờ làm việc)
    SalaryPerHour DECIMAL(18,2) CHECK (SalaryPerHour >= 0),  -- Giờ tiền lương của ca đó, nhằm fix lỗi thay đổi tiền lương nhân viên
    Status NVARCHAR(30), -- Chờ duyệt ca, đã duyệt ca, vắng, đã hủy, không duyệt
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID) ON DELETE CASCADE
);

-- MOVIE GROUP
CREATE TABLE Movie (
    MovieID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(200) NOT NULL,
    DurationMinutes INT NOT NULL CHECK (DurationMinutes > 0),
    Genre NVARCHAR(100),
    Language NVARCHAR(50),
    AgeLimit NVARCHAR(10), -- P, 13+, 16+, 18+, ...
    Description NVARCHAR(MAX),
    ImageUrl NVARCHAR(255),
    IsDeleted BIT DEFAULT 0 NOT NULL
);

CREATE TABLE Room (
    RoomID INT PRIMARY KEY IDENTITY(1,1),
    RoomName NVARCHAR(100) NOT NULL UNIQUE,
    SeatCount INT CHECK (SeatCount >= 0),
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
    ShowTimeID INT PRIMARY KEY IDENTITY(1,1),
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
    TicketID INT PRIMARY KEY IDENTITY(1,1),
    ShowTimeID INT NOT NULL,
    SeatID INT NOT NULL,
    TicketType NVARCHAR(50),
    Price DECIMAL(18,2) CHECK (Price >= 0),
    Status NVARCHAR(20), -- có sẵn, đã bán
    IsDeleted BIT DEFAULT 0 NOT NULL,
    FOREIGN KEY (ShowTimeID) REFERENCES ShowTime(ShowTimeID) ON DELETE CASCADE,
    FOREIGN KEY (SeatID) REFERENCES Seat(SeatID) ON DELETE CASCADE,
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
    MovieProductID INT PRIMARY KEY IDENTITY,
    MovieID INT NOT NULL,
    ProductID INT NOT NULL,
    OfferType NVARCHAR(20), -- miễn phí, riêng biệt
    Quantity INT CHECK (Quantity >= 0),
    Note NVARCHAR(255),
    FOREIGN KEY (MovieID) REFERENCES Movie(MovieID) ON DELETE CASCADE,
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID) ON DELETE CASCADE,
    CONSTRAINT UQ_MovieProduct UNIQUE (MovieID, ProductID)
);

CREATE TABLE Invoice (
    InvoiceID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeID INT,
    CustomerID INT,
    IssueDate DATETIME DEFAULT GETDATE() NOT NULL, -- ngày phát hành
    TotalAmount DECIMAL(18,2) CHECK (TotalAmount >= 0), -- Tổng tiền (VND)
    Discount DECIMAL(18,2) DEFAULT 0 CHECK (Discount >= 0), -- Giám giá (VND)
    Status NVARCHAR(30), -- đang chờ xử lí, đã thanh toán, chưa thanh toán
    IsDeleted BIT DEFAULT 0 NOT NULL,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID) ON DELETE SET NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE SET NULL
);

CREATE TABLE InvoiceTicket (
    InvoiceTicketID INT PRIMARY KEY IDENTITY(1,1),
    InvoiceID INT NOT NULL,
    TicketID INT NOT NULL,
    Quantity INT DEFAULT 1 CHECK (Quantity > 0),
    UnitPrice DECIMAL(18,2) CHECK (UnitPrice >= 0),
    FOREIGN KEY (InvoiceID) REFERENCES Invoice(InvoiceID) ON DELETE CASCADE,
    FOREIGN KEY (TicketID) REFERENCES Ticket(TicketID) ON DELETE CASCADE,
    CONSTRAINT UQ_Invoice_Ticket UNIQUE (InvoiceID, TicketID)
);

CREATE TABLE InvoiceProduct (
    InvoiceProductID INT PRIMARY KEY IDENTITY(1,1),
    InvoiceID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT DEFAULT 1 CHECK (Quantity > 0),
    UnitPrice DECIMAL(18,2) CHECK (UnitPrice >= 0),
    FOREIGN KEY (InvoiceID) REFERENCES Invoice(InvoiceID) ON DELETE CASCADE,
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID) ON DELETE CASCADE,
    CONSTRAINT UQ_Invoice_Product UNIQUE (InvoiceID, ProductID)
);

CREATE TABLE Payment (
    PaymentID INT PRIMARY KEY IDENTITY(1,1),
    InvoiceID INT NOT NULL,
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









