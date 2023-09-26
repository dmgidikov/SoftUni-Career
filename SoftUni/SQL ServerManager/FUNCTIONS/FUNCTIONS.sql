SELECT * FROM Employees

SELECT CONCAT_WS
(', ', SUBSTRING(FirstName, 1, 1), SUBSTRING(LastName, 1, 1)) AS [FullName]
FROM Employees