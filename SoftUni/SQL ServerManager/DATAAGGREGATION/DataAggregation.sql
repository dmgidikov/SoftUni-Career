SELECT TOP (1000) [Id]
      ,[FirstName]
      ,[LastName]
      ,[Notes]
      ,[Age]
      ,[MagicWandCreator]
      ,[MagicWandSize]
      ,[DepositGroup]
      ,[DepositStartDate]
      ,[DepositAmount]
      ,[DepositInterest]
      ,[DepositCharge]
      ,[DepositExpirationDate]
      ,[IsDepositExpired]
  FROM [Gringotts].[dbo].[WizzardDeposits]

  
  SELECT 
	COUNT(Id) AS Count
FROM  WizzardDeposits

  SELECT 
	MAX (MagicWandSize) AS LongestMagicWand
  FROM WizzardDeposits

SELECT 
	DepositGroup,
    MAX (MagicWandSize) AS LongestMagicWand
FROM
    WizzardDeposits
GROUP BY DepositGroup

SELECT TOP (2)
	DepositGroup
FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize)

SELECT 
	DepositGroup,
	SUM (DepositAmount) AS TotalSum
FROM WizzardDeposits
GROUP BY DepositGroup


SELECT 
	DepositGroup,
	SUM (DepositAmount) AS TotalSum
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup


SELECT 
	DepositGroup,
	SUM (DepositAmount) AS TotalSum
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup
HAVING DepositAmount < 150000
ORDER BY TotalSum DESC


SELECT 
	DepositGroup,
	MagicWandCreator,
	MIN (DepositCharge) AS MinDepositCharge
FROM WizzardDeposits
GROUP BY DepositGroup, MagicWandCreator
ORDER BY MagicWandCreator, DepositGroup ASC

