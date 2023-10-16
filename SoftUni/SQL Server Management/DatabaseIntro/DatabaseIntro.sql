--DATABESA INTRODUCTION

--1) Create Datebase

CREATE DATABASE Minions
USE [Minions]

--2) Create Tables

CREATE TABLE Minions (
Id int NOT NULL PRIMARY KEY,
Name nvarchar(50) NOT NULL,
Age int,
);

CREATE TABLE Towns (
Id int NOT NULL PRIMARY KEY,
Name nvarchar(50) NOT NULL,
);

--3) Alter Minions Table

ALTER TABLE Minions
ADD TownID int NOT NULL

ALTER TABLE Minions
ADD CONSTRAINT FK_MinionsTowns
FOREIGN KEY(TownID) REFERENCES Towns(Id);

--4) Insert Records in Both Tables

INSERT INTO Towns(Id, Name)
VALUES
(1, 'Sofia'),
(2, 'Plovdiv'),
(3, 'Varna');

INSERT INTO Minions (Id, Name, Age, TownId)
VALUES
(1, 'Kevin', 22, 1),
(2, 'Bob', 15, 3),
(3, 'Steward', NULL, 2);

--5) Truncate Table Minions

TRUNCATE TABLE Minions

--6) Drop All Tables

DROP TABLE Minions
DROP TABLE Towns

--7) Create Table People 

CREATE TABLE People(
Id int UNIQUE,
Name nvarchar(200) NOT NULL,
Picture image,
Height DECIMAL (7,2),
[Weight] DECIMAL (5,2),
Gender bit,
Birthdate DATE NOT NULL,
Biography nvarchar(max)
CONSTRAINT PK_PEOPLE
PRIMARY KEY (Id)
)

--8) Create Table Users

CREATE TABLE Users(
Id int UNIQUE,
Username nvarchar(30) NOT NULL,
Password nvarchar(26) NOT NULL,
ProfilePicture image, 
LastLoginTime DATE,
IsDeleted bit,
CONSTRAINT PK_Users
PRIMARY KEY (Id)
)

--9) Change Primary Key

ALTER TABLE Users
DROP CONSTRAINT PK_Users;

ALTER TABLE Users
ADD CONSTRAINT PK_Users
PRIMARY KEY(Id, Username);

--10) Add Check Constraint

ALTER TABLE Users
ADD CONSTRAINT CHK_PasswordLenght
CHECK (Len(Password) > 5);

--11) Set Default Value of a Field

ALTER TABLE Users
ADD CONSTRAINT df_LastLoginTime
DEFAULT CURRENT_TIMESTAMP FOR LastLoginTime;

--12) SetUniqe Filed

ALTER TABLE Users
DROP CONSTRAINT PK_Users

ALTER TABLE Users
ADD CONSTRAINT PK_Users
PRIMARY KEY (Username)

ALTER TABLE Users
ADD CONSTRAINT UC_Users
UNIQUE (Username)

--13) Movie Database

CREATE DATABASE Movies
USE [Movies]

CREATE TABLE Directors(
Id int,
DirectorName nvarchar(50),
Notes nvarchar(max)
CONSTRAINT PK_Directors
PRIMARY KEY (Id))

CREATE TABLE Genres(
Id int,
GenreName nvarchar(50),
Notes nvarchar(max)
CONSTRAINT PK_Genres
PRIMARY KEY (Id))

CREATE TABLE Categories(
Id int,
CategoryName nvarchar(50),
Notes nvarchar(max)
CONSTRAINT PK_Categories
PRIMARY KEY (Id))

CREATE TABLE Movies(
Id int,
Title nvarchar(50),
DirectorId int,
CopyrightYear int,
Length decimal (3,2),
GenreId int,
CategoryId int,
Rating float,
Notes nvarchar(max)
CONSTRAINT PK_Movies
PRIMARY KEY (Id))


