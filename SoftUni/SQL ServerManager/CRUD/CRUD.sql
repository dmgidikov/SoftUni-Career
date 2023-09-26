SELECT * FROM Departments

SELECT [Name] FROM Departments

SELECT FirstName, LastName, Salary FROM Employees 

SELECT FirstNAme, MiddleName, LastName  FROM Employees 

SELECT (FirstName + '.' + LastName +'@softuni.bg') 
AS [Full Email Address] FROM Employees

SELECT DISTINCT Salary FROM Employees

SELECT * FROM Employees
WHERE JobTitle = 'Sales Representative'

SELECT FirstNAme, LastName, JobTitle FROM Employees
WHERE Salary BETWEEN 20000 AND 30000;

SELECT FirstName + ' ' + MiddleName + ' ' + LastName AS [Full Name] FROM Employees
WHERE (Salary = 25000 OR Salary = 14000 OR Salary = 12500 OR  Salary = 23600);

SELECT FirstName,LastName 
  FROM Employees
 WHERE ManagerID IS NULL

 SELECT FirstName, LastName, Salary
 FROM Employees
 WHERE Salary > 50000
 ORDER BY Salary DESC

SELECT TOP (5) FirstName, LastName 
FROM Employees
 ORDER BY Salary DESC 

 SELECT FirstName, LastName 
 FROM Employees
 WHERE NOT DepartmentID = (4)

 SELECT * FROM Employees
 ORDER BY 
 Salary DESC,
 FirstName ASC,
 LastName DESC,
 MiddleName ASC

 GO
 CREATE VIEW V_EmployeesSalaries AS
 SELECT FirstName, LastName, Salary
 FROM Employees
 GO

 GO
 CREATE VIEW V_EmployeeNameJobTitle AS
 SELECT FirstName + ' ' +
 CASE
 WHEN MiddleName IS NULL THEN LastName
 ELSE MiddleName + ' ' + LastName
 END
 AS [FullName], JobTitle
 FROM Employees
 GO
