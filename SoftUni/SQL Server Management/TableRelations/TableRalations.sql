-- Table Relations

CREATE DATABASE TableRelations

USE [TableRelations]

-- 1) One-To-One Relationship

CREATE TABLE Persons (
PersonID int NOT NULL,
FirstName nvarchar(50),
Salary decimal(15,2),
PassportID int NOT NULL
CONSTRAINT PK_Persons
PRIMARY KEY (PersonID)
);

CREATE TABLE Passports (
PassportID int NOT NULL,
PassportNumber nvarchar(10)
CONSTRAINT PK_Passports
PRIMARY KEY (PassportID)
);

ALTER TABLE Persons
ADD CONSTRAINT FK_PersonsPassports
FOREIGN KEY (PassportID) 
REFERENCES 	Passports(PassportID)


-- 2) One-To-Many Relationship


CREATE TABLE Models (
ModelID int NOT NULL,
Name nvarchar(10),
ManufacturerID int NOT NULL
CONSTRAINT PK_Models
PRIMARY KEY (ModelID)
);


CREATE TABLE Manufacturers (
ManufacturerID int NOT NULL,
Name nvarchar(15),
EstablishedOn Date
CONSTRAINT PK_Manufacturers
PRIMARY KEY (ManufacturerID)
);


ALTER TABLE Models
ADD CONSTRAINT FK_ModelsManufacturers
FOREIGN KEY (ManufacturerID) 
REFERENCES 	Manufacturers(ManufacturerID)


-- 3) Many-To-Many Relationship


CREATE TABLE Students(
StudentID int NOT NULL,
Name nvarchar(50)
CONSTRAINT PK_Students
PRIMARY KEY (StudentID)
)

CREATE TABLE Exams(
ExamID int NOT NULL,
Name nvarchar(50)
CONSTRAINT PK_Exams
PRIMARY KEY (ExamID)
)

CREATE TABLE StudentsExams(
StudentID int NOT NULL,
ExamID int NOT NULL
CONSTRAINT PK_StudentsExams
PRIMARY KEY (StudentID, ExamID)
)

ALTER TABLE StudentsExams
ADD CONSTRAINT FK_StudentsStudentsExams
FOREIGN KEY (StudentID)
REFERENCES Students(StudentID)

ALTER TABLE StudentsExams
ADD CONSTRAINT FK_ExamsStudentsExams
FOREIGN KEY (ExamID)
REFERENCES Exams(ExamID)


-- 4) Self-Referencing


CREATE TABLE Teachers(
TeacherID int NOT NULL,
Name nvarchar(50),
ManagerID int
CONSTRAINT PK_Teachers
PRIMARY KEY (TeacherID)
)

ALTER TABLE Teachers
ADD CONSTRAINT FK_Teachers
FOREIGN KEY (ManagerID)
REFERENCES Teachers(TeacherID)


