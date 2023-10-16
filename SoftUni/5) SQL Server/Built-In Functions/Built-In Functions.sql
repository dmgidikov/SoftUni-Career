-- BUILT-IN FUNCTIONS

USE [SoftUni]

-- 1) Find Names of All Employees by First Name

SELECT 
	FirstName,
	LastName
FROM Employees
WHERE FirstName LIKE 'Sa%';


-- 2) Find Names of All Employees by Last Name 


SELECT 
	FirstName,
	LastName
FROM Employees
WHERE LastName LIKE '%ei%';


-- 3) Find First Names of All Employees


SELECT 
	FirstName
FROM Employees
WHERE DepartmentID = 3 OR DepartmentID = 10;


-- 4) Find All Employees Except Engineers


SELECT 
	FirstName,
	LastName
FROM Employees
WHERE JobTitle != 'Engineering' AND JobTitle != 'Engineering Manager';


-- 5) Find Towns with Name Length


SELECT 
	Name
FROM Towns
WHERE LEN(Name) = 5 OR LEN(Name) = 6
ORDER BY Name ASC;


-- 6) eFind Towns Starting With


SELECT 	*
FROM Towns
WHERE Name LIKE 'M%' OR  Name LIKE 'K%'
		   OR  Name LIKE 'B%' OR  Name LIKE 'E%'
ORDER BY Name ASC;


-- 7) Find Towns Not Starting With



SELECT 	*
FROM Towns
WHERE Name NOT LIKE 'R%' AND  Name NOT LIKE 'D%' AND  Name NOT LIKE 'B%'
ORDER BY Name ASC;


-- 8) Create View Employees Hired After 2000 Year


GO
CREATE VIEW [V_EmployeesHiredAfter2000] AS
SELECT 
	FirstName,
	LastName
FROM Employees
WHERE HireDate > 2000;
GO


-- 9) Length of Last Name


SELECT
	FirstName,
	LastName
FROM Employees
WHERE LEN(LastName) = 5


-- 10) Rank Employees by Salary



SELECT 
	EmployeeID,
	FirstName,
	LastName,
	Salary,
	DENSE_RANK() OVER(PARTITION BY SALARY ORDER BY EmployeeID) AS RANK
FROM Employees
WHERE Salary BETWEEN 10000 AND 50000
ORDER BY Salary DESC;



-- 11)  Find All Employees with Rank 2 (not included in final score)


SELECT *
FROM (SELECT 
	EmployeeID,
	FirstName,
	LastName,
	Salary,
	DENSE_RANK() OVER(PARTITION BY SALARY ORDER BY EmployeeID) AS RANK
FROM Employees
WHERE Salary BETWEEN 10000 AND 50000) AS MyTable
WHERE RANK = 2
ORDER BY Salary DESC;


-- 12) Countries Holding 'A' 3 or More Times

USE [Geography]

SELECT 
	CountryName,
	IsoCode
FROM Countries
WHERE CountryName LIKE '%a%a%a%'
ORDER BY IsoCode;


-- 13) Mix of Peak and River Names


SELECT 
	PeakName,
	RiverName,
	CONCAT(LOWER (PeakName), LOWER (SUBSTRING (RiverName, 1, 10))) AS Mix
FROM Peaks, Rivers
WHERE RIGHT(PeakName, 1) = LEFT(RiverName, 1)
ORDER BY Mix;