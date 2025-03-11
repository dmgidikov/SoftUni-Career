-- 01. Find Names of All Employees by First Name

SELECT FirstName, LastName 
FROM Employees
WHERE FirstName LIKE 'SA%'

-- 02. Find Names of All employees by Last Name 

SELECT FirstName, LastName 
FROM Employees
WHERE LastName LIKE '%ei%'

-- 03. Find First Names of All Employees

SELECT FirstName 
FROM Employees
WHERE
	DepartmentID = 3 OR DepartmentID = 10
	AND HireDate BETWEEN 1995 AND 2005;
	
-- 04. Find All Employees Except Engineers

SELECT FirstName , LastName
FROM Employees
WHERE NOT JobTitle = 'engineer'

-- 05. Find Towns with Name Length

SELECT [Name]
FROM Towns
WHERE LEN(Name) = 5 OR  DATALENGTH(Name) = 6
ORDER BY Name

-- 06. Find Towns Starting With

SELECT TownID,[Name]
FROM Towns
WHERE Name LIKE 'M%' OR Name LIKE 'K%' OR Name LIKE 'B%' OR Name LIKE 'E%'
ORDER BY Name

-- 07. Find Towns NOT Starting With

SELECT TownID,[Name]
FROM Towns
WHERE Name NOT LIKE 'R%' AND Name NOT LIKE 'B%' AND Name NOT LIKE 'D%'
ORDER BY Name

-- 08. Create View Employees Hired After 2000 Year

GO
CREATE VIEW V_EMployeesHiredAfter2000 AS 
SELECT FirstName, LastName
FROM Employees
WHERE HireDate > '12-31-2000'
GO

-- 09. Length of Last Name

SELECT FirstName, LastName
FROM Employees
WHERE LEN(LastName) = 5

-- 10. Rank Employees by Salary

SELECT 
	EmployeeID,
	FirstName,
	LastName,
	Salary,
	DENSE_RANK() OVER(PARTITION BY SALARY ORDER BY EmployeeID) AS RANK
FROM Employees
WHERE Salary BETWEEN 10000 AND 50000
ORDER BY Salary DESC;

-- 11. Find All Employees with Rank 2 *

SELECT *
FROM(SELECT
	EmployeeID,
	FirstName,
	LastName,
	Salary,
	DENSE_RANK() OVER(PARTITION BY SALARY ORDER BY EmployeeID) AS RANK
FROM Employees
WHERE Salary BETWEEN 10000 AND 50000) AS MyTable
WHERE RANK = 2
ORDER BY Salary DESC;

--12 Countries Holding ‘A’ 3 or More Times

SELECT CountryName, IsoCode
FROM Countries
WHERE CountryName LIKE '%A%A%A%'
ORDER BY IsoCode

--13 Mix of Peak and River Names

SELECT PeakName, RiverName, LOWER(PeakName) + LOWER(RiverName) AS Mix
FROM Peaks, Rivers
WHERE RIGHT(PeakName, 1) = LEFT(RiverName, 1)
ORDER BY Mix