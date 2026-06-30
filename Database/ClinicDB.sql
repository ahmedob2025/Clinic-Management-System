USE ClinicDB;
GO

IF OBJECT_ID('Bills', 'U') IS NOT NULL DROP TABLE Bills;
IF OBJECT_ID('Appointments', 'U') IS NOT NULL DROP TABLE Appointments;
IF OBJECT_ID('Doctors', 'U') IS NOT NULL DROP TABLE Doctors;
IF OBJECT_ID('Patients', 'U') IS NOT NULL DROP TABLE Patients;
IF OBJECT_ID('Users', 'U') IS NOT NULL DROP TABLE Users;
GO


CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Role NVARCHAR(20) CHECK (Role IN ('Admin', 'Reception')) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    IsActive BIT NOT NULL ,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE()

);

CREATE TABLE Patients (
    PatientID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20) NOT NULL,
    Gender NVARCHAR(10) CHECK (Gender IN ('Male', 'Female')),
    BirthDate DATE NOT NULL,
    Address NVARCHAR(200),
    CreateedDate DATETIME DEFAULT GETDATE()
);

CREATE TABLE Doctors (
    DoctorID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    Specialization NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20) NOT NULL,
    ConsultationFee DECIMAL(10,2) NOT NULL
);

CREATE TABLE Appointments (
    AppointmentID INT PRIMARY KEY IDENTITY(1,1),
    PatientID INT NOT NULL,
    DoctorID INT NOT NULL,
    AppointmentDate DATE NOT NULL,
    AppointmentTime TIME NOT NULL,
    Status NVARCHAR(20) DEFAULT 'Scheduled' CHECK (Status IN ('Scheduled', 'Completed', 'Cancelled')),
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID) ON DELETE CASCADE,
    FOREIGN KEY (DoctorID) REFERENCES Doctors(DoctorID) ON DELETE CASCADE,
    CONSTRAINT UQ_Doctor_TimeSlot UNIQUE (DoctorID, AppointmentDate, AppointmentTime)
);

CREATE TABLE Bills (
    BillID INT PRIMARY KEY IDENTITY(1,1),
    AppointmentID INT UNIQUE NOT NULL,
    Amount DECIMAL(10,2) NOT NULL,
    PaymentStatus NVARCHAR(20) DEFAULT 'Unpaid' CHECK (PaymentStatus IN ('Paid', 'Unpaid')),
    PaymentDate DATE,
    FOREIGN KEY (AppointmentID) REFERENCES Appointments(AppointmentID) ON DELETE CASCADE
);




IF OBJECT_ID('VerifyUser', 'P') IS NOT NULL DROP PROC VerifyUser;
GO

CREATE PROC VerifyUser

    @Username NVARCHAR(50),
    @Password NVARCHAR(50)
AS
BEGIN
    SELECT UserID, Username, Role
    FROM Users
    WHERE Username = @Username
      AND Password = @Password;
END
GO


EXEC VerifyUser 'admin', '123';

USE ClinicDB;
GO




use ClinicDB;
insert into Users (Username,Password,FullName,Role,IsActive) values('admin1','123','Ahmed Obaidat' , 'Admin',1);
select * from Users;
