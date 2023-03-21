USE [NORTHWND]
SELECT * FROM EmployeeSample

--nth highest salary


--insert

--update

--delete

--CTE

--TOP

--Group by
--WITH supplierProduct AS (
--	select *, ROW_NUMBER() OVER(PARTITION BY p.SupplierId Order by p.UnitPrice desc) as [Rank] from Products p
--)
--select * from supplierProduct where [Rank] = 1
