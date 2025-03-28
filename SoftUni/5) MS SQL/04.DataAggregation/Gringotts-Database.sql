-- 01. Records’ Count

SELECT COUNT(*) AS [Count]
FROM WizzardDeposits

-- 02. Longest Magic Wand

SELECT MAX(MagicWandSize) AS LongestMagicWand
FROM WizzardDeposits

-- 03. Longest Magic Wand per Deposit Groups

SELECT DepositGroup, MAX(MagicWandSize) AS LongestMagicWand
FROM WizzardDeposits
GROUP BY DepositGroup

-- 04. Smallest Deposit Group per Magic Wand Size

SELECT TOP(2) DepositGroup
FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize)

-- 05. Deposit Sum

SELECT DepositGroup, SUM(DepositAmount) AS [TotalSum]
FROM WizzardDeposits
GROUP BY DepositGroup

-- 06. Deposits Sum for Ollivander Family

SELECT DepositGroup, SUM(DepositAmount) AS [TotalSum]
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup

-- 07. Deposits Filter

SELECT DepositGroup, SUM(DepositAmount) AS [TotalSum]
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup
HAVING  SUM(DepositAmount) < 150000
ORDER BY SUM(DepositAmount) DESC

-- 08. Deposits Charge

SELECT 
	DepositGroup, 
	MagicWandCreator,
	MIN(DepositCharge) AS MinDepositCharge
FROM WizzardDeposits
GROUP BY DepositGroup, MagicWandCreator
ORDER BY MagicWandCreator, DepositGroup

-- 09. Age Groups

SELECT 
	AgeGroup, 
	COUNT(*) FROM (
SELECT 
	CASE
	  WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
	  WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
	  WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
	  WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
	  WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
	  WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
	  WHEN Age >= 61 THEN '[61+]'
	END AS [AgeGroup]
FROM WizzardDeposits
	) AS AgeGroup
GROUP BY AgeGroup.AgeGroup


-- 10. First Letter

SELECT SUBSTRING(FirstName, 1, 1)  AS [FirstLetter]
FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest'
GROUP BY SUBSTRING (FirstName, 1, 1) 
ORDER BY FirstLetter

-- 11. Average Interest 

SELECT DepositGroup, IsDepositExpired, AVG(DepositInterest) AS [AverageInterest]
FROM WizzardDeposits
WHERE DepositStartDate > '01/01/1985'
GROUP BY DepositGroup, IsDepositExpired
ORDER BY DepositGroup DESC, IsDepositExpired


-- 12. * Rich Wizard, Poor Wizard

SELECT SUM(ws.Difference)
FROM
(
    SELECT DepositAmount -
    (
        SELECT DepositAmount
        FROM WizzardDeposits AS wsd
        WHERE wsd.Id = wd.Id + 1
    ) AS Difference
    FROM WizzardDeposits AS wd
) AS ws; 


-- using softunit db
--13. Departments Total Salaries

SELECT DepartmentID, SUM(Salary) AS [TotalSalary]
FROM Employees
GROUP BY DepartmentID
ORDER BY DepartmentID


--14. Employees Minimum Salaries

SELECT
	DepartmentID, 
	MIN(Salary) AS [MinimumSalary]
FROM Employees
WHERE 
	DepartmentID = 2 OR DepartmentID = 5 OR DepartmentID = 7 AND 
	HireDate > '01/01/2000'	
GROUP BY DepartmentID


-- 15. Employees Average Salaries

SELECT * INTO NewTable
FROM Employees
WHERE Salary > 3000

DELETE 
FROM NewTable
WHERE ManagerID = 42

UPDATE NewTable
SET Salary += 5000
WHERE DepartmentID = 1

SELECT 
	DepartmentID,
	AVG(Salary) AS AverageSalary
FROM NewTable
GROUP BY DepartmentID


-- 16. Employees Maximum Salaries

SELECT 
	DepartmentID,
	MAX(Salary) AS MaxSalary
FROM Employees
GROUP BY DepartmentID
HAVING MAX(Salary) BETWEEN 30000 AND 70000


-- 17. Employees Count Salaries

SELECT COUNT(Salary) AS Count
FROM Employees
WHERE ManagerID IS NULL


-- 18. 3rd Highest Salary

SELECT Salaries.DepartmentID, Salaries.ThirdHighestSalary FROM
(
	SELECT
		DepartmentID, 
		MAX(Salary) AS [ThirdHighestSalary],
		DENSE_RANK() OVER (PARTITION BY DepartmentId ORDER BY Salary DESC) AS RANK
	FROM Employees
	GROUP BY DepartmentID, Salary
) AS Salaries
WHERE RANK = 3


-- 19. **Salary Challenge

SELECT TOP 10
	FirstName,
	LastName,
	DepartmentID
FROM Employees AS Emp1
WHERE Salary > 
(
	SELECT AVG (Salary) 
	FROM Employees AS Emp2
	WHERE Emp1.DepartmentID = Emp2.DepartmentID
	GROUP BY DepartmentID
)
ORDER BY DepartmentID
