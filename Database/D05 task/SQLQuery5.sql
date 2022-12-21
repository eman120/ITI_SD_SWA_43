USE AdventureWorks2012
--1.	Display the SalesOrderID, ShipDate of the SalesOrderHeader table (Sales schema) to show SalesOrders that occurred within the period ‘7/28/2002’ and ‘7/29/2014’
select SalesOrderID, ShipDate , OrderDate
from Sales.SalesOrderHeader
where OrderDate between '7/28/2002' and '7/29/2014'

--2.	Display only Products(Production schema) with a StandardCost below $110.00 (show ProductID, Name only)
select ProductID , Name , StandardCost
from Production.Product
where StandardCost < 110.00

--3.	Display ProductID, Name if its weight is unknown
select ProductID , Name , Weight 
from Production.Product
where Weight is null

--4.	 Display all Products with a Silver, Black, or Red Color
select ProductID , Name , Color
from Production.Product
where Color in ('Silver', 'Black', 'Red')

--5.	 Display any Product with a Name starting with the letter B
select *
from Production.Product
where Name like 'B%'

--6.	Run the following Query
--      UPDATE Production.ProductDescription
--      SET Description = 'Chromoly steel_High of defects'
--      WHERE ProductDescriptionID = 3
--      Then write a query that displays any Product description with underscore value in its description.
update Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3

select *
from Production.ProductDescription
where Description like '%[_]%'

--7.	Calculate sum of TotalDue for each OrderDate in Sales.SalesOrderHeader table for the period between  '7/1/2001' and '7/31/2014'
select sum(TotalDue) as Total 
from Sales.SalesOrderHeader
where OrderDate between '7/1/2001' and '7/31/2014'

--8.	 Display the Employees HireDate (note no repeated values are allowed)
select Distinct HireDate 
from HumanResources.Employee

--9.	 Calculate the average of the unique ListPrices in the Product table
select AVG(ListPrice)
from (select Distinct ListPrice
		from production.product ) as UniPrice

--10.	Display the Product Name and its ListPrice within the values of 100 and 120 the list should has the following format "The [product name] is only! [List price]" (the list will be sorted according to its ListPrice value)
select Name as [product name], ListPrice as [List price]
from Production.Product
where ListPrice between 100 and 120
order by ListPrice desc
--11.	
--    a)	 Transfer the rowguid ,Name, SalesPersonID, Demographics from Sales.Store table  in a newly created table named [store_Archive]
--           Note: Check your database to see the new table and how many rows in it?
--    b)	Try the previous query but without transferring the data? 
 select rowguid ,Name, SalesPersonID, Demographics into store_Archive 
 from Sales.Store
 select * from store_Archive
 select count(rowguid) from store_Archive

 select * into  store_Archive2 
 from Sales.Store
 where 1 = 2
 select * from store_Archive2
 select count(rowguid) from store_Archive2

--12.	Using union statement, retrieve the today’s date in different styles using convert or format funtion.
select convert (varchar(20) , GETDATE(),1) as d 
union 
select convert (varchar(20) , GETDATE(),4) as d 
union 
select convert (varchar(20) , GETDATE(),7) as d 
union 
select convert (varchar(20) , GETDATE(),112) as d 
union 
select convert (varchar(20) , GETDATE(),13) as d 