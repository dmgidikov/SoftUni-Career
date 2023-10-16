-- BASIC CRUD 
-- USING ALREADY CREATED DATABASES FROM SOFTUNI

USE [SoftUni]

--1) Find All Information About Departments

SELECT * 
FROM Departments

--2) Find all Department Names

SELECT [Name]
FROM Departments

--3) Find Salary of Each Employee

SELECT 
	FirstName,
	LastName,
	Salary
FROM Employees

--4) Find Full Name of Each Employee

SELECT 
	FirstName,
	MiddleName,
	LastName
FROM Employees

--5) Find Email Address of Each Employee

SELECT 
	(FirstName + '.' + LastName + '@softuni.bg') AS 'Full Email Address'
FROM Employees

--6) Find All Different Employee’s Salaries

SELECT 
	DISTINCT Salary
FROM Employees

--7)  Find all Information About employees whose job title is “Sales Representative"

SELECT *
FROM Employees
WHERE JobTitle = 'Sales Representative';

--8) Find Names of All Employees by Salary in Range

SELECT 
	FirstName,
	LastName,
	JobTitle
FROM Employees
WHERE Salary BETWEEN 20000 AND 30000;

/* -- 9) Write a SQL query to find the full name of all employees whose salary is 
    25000, 14000, 12500 or 23600. Full Name is combination of first, middle and last name 
    (separated with single space) and they should be in one column called “Full Name”. */

SELECT 
	CONCAT_WS (' ', FirstName, MiddleName, LastName) AS FullName
FROM Employees
WHERE Salary = 25000 OR SALARY = 14000 OR SALARY = 12500  OR SALARY = 23600;


-- 10) Find All Employees Without Manager

SELECT
	FirstName,
	LastName
FROM Employees
WHERE ManagerID IS NOT NULL;

-- 11)  Find All Employees with Salary More Than

SELECT
	FirstName,
	LastName,
	Salary
FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC;

-- 12) Find 5 Best Paid Employees

SELECT TOP 5(FirstName), LastName
FROM Employees
ORDER BY Salary DESC;

-- 13) Find All Employees whose department ID is different from 4.

SELECT 
	FirstName,
	LastName
FROM Employees
WHERE DepartmentID != 4

--14) Sort Employees Table
	/* 	
	•	First by salary in decreasing order
	•	Then by first name alphabetically
	•	Then by last name descending
	•	Then by middle name alphabetically */

SELECT *	
FROM Employees
ORDER BY Salary DESC, FirstName, LastName DESC, MiddleName;


-- 15) Create View Employees with Salaries


GO
CREATE VIEW V_EmployeesSalaries  AS
SELECT
	FirstName,
	LastName,
	Salary
FROM Employees;


-- 16) Create View Employees with Job Titles

GO
CREATE VIEW V_EmployeeNameJobTitle AS
SELECT
	FirstName + ' ' +
CASE 
	WHEN MiddleName IS NULL THEN LastName
	ELSE MiddleName + ' ' + LastName
END
	AS FullName,
	JobTitle
FROM Employees;

-- 17) Distinct Job Titles


SELECT 
	DISTINCT JobTitle
FROM Employees


-- 18)   Find First 10 Started Projects


SELECT TOP 10 *
FROM Projects
ORDER BY StartDate, Name;


--19) Last 7 Hired Employees


SELECT TOP 7
	FirstName, 
	LastName,
	HireDate
FROM Employees
ORDER BY HireDate DESC;


-- 20) Increase Salaries


UPDATE Employees
SET Salary = Salary + (Salary * 0.12)
WHERE DepartmentID = 1 OR DepartmentID = 2 OR DepartmentID = 4 OR DepartmentID = 11
SELECT Salary FROM Employees;


USE [Geography]


 -- 21) Display all mountain peaks in alphabetical order.


 SELECT 
	PeakName
 FROM Peaks
 ORDER BY PeakName ASC;


 -- 22) Biggest Countries by Population


 SELECT TOP 30
	CountryName,
	Population
 FROM Countries
 WHERE ContinentCode = 'EU'
 ORDER BY Population DESC, CountryName ASC;


 -- 23*) *Countries and Currency (Euro / Not Euro)    *Not included in final score

 SELECT 
	CountryName,
	CountryCode,
CASE
WHEN CurrencyCode = 'EUR' THEN 'Euro'
ELSE 'Not Euro'
END
AS [Currency]
 FROM Countries
 ORDER BY CountryName ASC;


 -- 24) Display all characters in alphabetical order. 


 USE [Diablo]

 SELECT 
	Name
FROM Characters
ORDER BY Name ASC

