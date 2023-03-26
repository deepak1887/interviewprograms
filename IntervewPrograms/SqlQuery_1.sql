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
--Nth Highest salary
SELECT ename,sal from Employee e1 where 
        N-1 = (SELECT COUNT(DISTINCT sal)from Employee e2 where e2.sal > e1.sal) 

--solution 2
select Salary from EmployeeSample order by Salary desc offset 4 rows fetch next 1 rows only