-- 01. Employee Address

SELECT TOP (5)
	e.EmployeeID, 
	e.JobTitle,
	e.AddressID,	
	a.AddressText 
FROM Employees e
	JOIN Addresses a ON e.AddressID = a.AddressID
ORDER BY AddressID


-- 02. Addresses with Towns


SELECT TOP (50)
	e.FirstName,
	e.LastName,
	t.[Name] AS Town,
	a.AddressText
FROM Employees AS e
	JOIN Addresses AS a ON e.AddressID = a.AddressID
	JOIN Towns AS t ON a.TownID = t.TownID
ORDER BY FirstName ASC, LastName DESC


-- 03. Sales Employee


SELECT 
	e.EmployeeID,
	e.FirstName,
	e.LastName,
	d.[Name] AS DepartmentName
FROM Employees AS e
	JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
ORDER BY e.EmployeeID


-- 04. Employee Departments


SELECT TOP (5)
	e.EmployeeID,
	e.FirstName,
	e.Salary,
	d.Name AS DepartmentName
FROM Employees AS e
	JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE e.Salary > 15000
ORDER BY e.DepartmentID



-- 05. Employees Without Projects



SELECT TOP (3)
	e.EmployeeID,
	e.FirstName
FROM Employees AS e
	LEFT JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
WHERE ep.EmployeeID IS NULL
ORDER BY e.EmployeeID



-- 06. Employees Hired After


SELECT 
	e.FirstName,
	e.LastName,
	e.HireDate,
	d.Name AS DeptName 
FROM Employees AS e
	JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE e.HireDate > '01/01/1999' AND d.Name IN ('Sales', 'Finance')
ORDER BY HireDate



-- 07. Employees With Projects



SELECT TOP (5)
	e.EmployeeID,
	e.FirstName,
	p.Name
FROM Employees AS e
	JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
	JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE p.StartDate > '08.13.2002' AND p.EndDate IS NULL
ORDER BY e.EmployeeID 



-- 08. Employee 24



SELECT 
	e.EmployeeID,
	e.FirstName,
CASE
    WHEN p.StartDate > '01/01/2005' THEN 'NULL'
    ELSE p.Name
END AS ProjectName
FROM Employees AS e
	JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
	JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE e.EmployeeID = 24 



-- 09. Employee Manager



SELECT 
	e.EmployeeID,
	e.FirstName,
	e.ManagerID,
	m.FirstName AS ManagerName
FROM Employees AS e
	JOIN Employees AS m ON e.ManagerID = m.EmployeeID
WHERE e.ManagerID IN (3,7)
ORDER BY e.EmployeeID



-- 10. Employee Summary 



SELECT TOP 50
	e.EmployeeID,
	CONCAT_WS(' ', e.FirstName, e.LastName) AS EmployeeName,
	CONCAT_WS(' ', m.FirstName, m.LastName) AS ManagerName,	
	d.Name
FROM Employees AS e
	JOIN Employees AS m ON e.ManagerID = m.EmployeeID
	JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
ORDER BY e.EmployeeID



-- 11. Min Avg Salary



SELECT AVG(Salary) AS AvarageSalary
FROM Employees
GROUP BY DepartmentID



-- 12. Highest peaks in Bulgaria




SELECT mc.CountryCode, m.MountainRange, p.PeakName, p.Elevation
FROM MountainsCountries as mc
	JOIN Mountains AS m ON mc.MountainId = m.Id
	JOIN Peaks AS p ON mc.MountainId = p.MountainId
WHERE p.Elevation > 2835 AND mc.CountryCode = 'BG'
ORDER BY Elevation DESC



-- 13. Count mountain ranges



SELECT mc.CountryCode, COUNT(m.MountainRange) AS MountainRanges
FROM MountainsCountries as mc
	JOIN Mountains AS m ON mc.MountainId = m.Id
WHERE mc.CountryCode IN ('BG', 'RU', 'US')
GROUP BY mc.CountryCode



-- 14. Countries with rivers



SELECT TOP 5
	c.CountryName, 
	r.RiverName
FROM Countries as c
	LEFT JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
	LEFT Join Rivers AS r ON cr.RiverId = r.Id
WHERE c.ContinentCode = 'AF'
ORDER BY c.CountryName