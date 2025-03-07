-- 02. Find All information about Departments

SELECT * FROM Departments

-- 03. Find all department names

SELECT [Name] FROM Departments

-- 04. FInd Salary of each employee

SELECT FirstName, LastName, Salary
FROM Employees

-- 05. Find full name of each employee

SELECT FirstName, MiddleName, LastName
FROM Employees

-- 06. Find Email Address of each Employee

SELECT FirstName + '.' + LastName + '@softuni.bg' AS [Full Email Address]
FROM Employees

-- 07. find all different employee's salaries

SELECT DISTINCT Salary
FROM Employees

-- 08. Find all Information About Employees

SELECT * 
FROM Employees
WHERE JobTitle = 'Sales Representative'

-- 09. Find Names of All Employees by Salary in Range

SELECT FirstName, LastName, JobTitle
FROM Employees
WHERE Salary BETWEEN 20000 AND 30000

-- 10. Find Names of All Employees 

SELECT FirstName + ' ' + MiddleName + ' ' + LastName AS [Full Name] 
FROM Employees
WHERE Salary = 25000 OR Salary = 14000 OR Salary = 12500 OR Salary = 23600

-- 11. Find All Employees Without Manager

SELECT FirstName, LastName
FROM Employees
WHERE ManagerID IS NULL

-- 12. Find All Employees with Salary More Than 50000

SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary > 50000 
ORDER BY Salary DESC

-- 13. Find 5 Best Paid Employees.

SELECT TOP 5 FirstName, LastName
FROM Employees
ORDER BY Salary DESC

-- 14. Find All Employees Except Marketing

SELECT FirstName, LastName
FROM Employees
WHERE NOT DepartmentID = 4

-- 15. Sort Employees Table

SELECT *
FROM Employees
ORDER BY 
	Salary DESC,
	FirstName,
	LastName DESC,
	MiddleName;

-- 16. Create View Employees with Salaries

GO
CREATE VIEW V_EmployeesSalaries AS
SELECT FirstName, LastName, Salary
FROM Employees
GO

SELECT * FROM V_EmployeesSalaries

-- 17. Create View Employees with Job Titles

GO
CREATE VIEW V_EmployeeNameJobTitle AS
SELECT FirstName + ' ' + ISNULL(MiddleName, '') + ' ' + LastName AS [Full Name], JobTitle
FROM Employees
GO

SELECT * FROM V_EmployeeNameJobTitle

-- 18. Distinct Job Titles

SELECT DISTINCT JobTitle 
FROM Employees

-- 19. Find First 10 Started Projects

SELECT TOP 10 *
FROM Projects
WHERE StartDate < CURRENT_TIMESTAMP
ORDER BY StartDate, Name

-- 20. Last 7 Hired Employees

SELECT TOP 7 *
FROM Employees
ORDER BY HireDate DESC

-- 21. Increase Salaries

UPDATE Employees
SET Salary *= 1.12
WHERE DepartmentID = 1 OR DepartmentID = 2 OR DepartmentID = 4 OR DepartmentID = 11

SELECT Salary
FROM Employees

-- 22. All Mountain Peaks

SELECT PeakName
FROM Peaks
ORDER BY PeakName

-- 23. Biggest Countries by Population

SELECT TOP 30 CountryName, Population
FROM Countries
WHERE ContinentCode = 'EU'
ORDER BY Population DESC, CountryName

-- 24. *Countries and Currency (Euro / Not Euro)

SELECT CountryName, CountryCode, 
CASE 
	WHEN CurrencyCode = 'EUR' THEN 'Euro' 
    ELSE 'Not Euro'
END AS [Currency]
FROM Countries
ORDER BY CountryName