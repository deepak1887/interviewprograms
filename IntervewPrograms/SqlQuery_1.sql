USE [NORTHWND]
--SELECT * FROM EmployeeSample

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
--SELECT ename,sal from Employee e1 where 
--        N-1 = (SELECT COUNT(DISTINCT sal)from Employee e2 where e2.sal > e1.sal) 

--solution 2
--select Salary from EmployeeSample order by Salary desc offset 4 rows fetch next 1 rows only

--Hirarichel data

--Declare @Id Int;
--set @Id = 130;
--with EmployeeCTE AS (
--	select EmployeeId, FirstName, ManagerId from EmployeeSample where EmployeeId = @Id
--	UNION ALL
--	select EmployeeSample.EmployeeId, EmployeeSample.FirstName, EmployeeSample.ManagerId from EmployeeSample
--	JOIN EmployeeCTE ON
--	EmployeeSample.EmployeeId = EmployeeCTE.ManagerId
--)
--select E1.FirstName, E2.FirstName from EmployeeCTE E1
--LEFT JOIN EmployeeCTE E2 on E1.ManagerId = E2.EmployeeId

--JOIN
--var result = entityFrameworkObjectContext.SomeClass
--            .Join(entityFrameworkObjectContext.SomeOtherClass,
--                sc => sc.property1,
--                soc => soc.property2,
--                (sc, soc) => new {sc, soc})
--            .Where(s => propertyValues.Any(pvals => pvals == es.sc.property1)
--            .Select(s => new ThirdNonEntityClass 
--            {
--                dataValue1 = s.sc.dataValueA,
--                dataValue2 = s.soc.dataValueB
--            })
--            .ToList();
-- left join
--var qry = Foo.GroupJoin(
--          Bar, 
--          foo => foo.Foo_Id,
--          bar => bar.Foo_Id,
--          (x,y) => new { Foo = x, Bars = y })
--       .SelectMany(
--           x => x.Bars.DefaultIfEmpty(),
--           (x,y) => new { Foo=x.Foo, Bar=y});


--Row_Number() --Rank() --Dense_Rank() 
--Row_Number() -It always generates a unique value for each row, even if they are the same and the ORDER BY clause cannot distinguish between them

--Rank() - The rank() function will assign the same rank to the same values i.e. which are not distinguishable by ORDER BY
--name    salary  rank
--Jackob  7000    1
--Peter   5000    2
--John    4000    3
--Shane   3000    4
--Rick    3000    4
--Sid     1000    6

--Dense_Rank() he dense_rank function is similar to the rank() window function i.e. same values will be assigned the same rank, 
--but the next different value will have a rank which is just one more than the previous ran
--name    salary dense_rank 
--Jackob  7000    1 
--Peter   5000    2 
--John    4000    3 
--Shane   3000    4 
--Rick    3000    4 
--Sid     1000    5
