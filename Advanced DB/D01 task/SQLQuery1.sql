use SD

--1) create Department Table
create Table Department (
	DeptNo varchar(2),
	DeptName varchar(20),
	Location loc,
	constraint PK primary key (DeptNo)
)

drop table Department

--create custom (new)   datatype 
--	nchar(2)   default:NY   values in (NY,DS,KW)
sp_addtype loc,'nchar(2)'
create rule r1 as @x in ('NY','DS','KW')
create default def1 as 'NY'

sp_bindrule r1,loc

sp_bindefault def1,loc

-----------------------------------------

--2) create Employee Table

create table Employee (
	EmpNo int,
	EmpFname varchar(20) not null,
	EmpLname varchar(20) not null,
	DeptNo varchar(2),
	salary int,
	constraint PKEmp primary key (EmpNo),
	constraint FKEmp foreign key (DeptNo) references Department(DeptNo),
	constraint uniEmp Unique (salary),
)


create rule r2 as @x < 6000
sp_bindrule r2 , 'Employee.salary'


alter table Employee add TelephoneNumber int

alter table Employee drop column TelephoneNumber
-------------------------------------------

--3) create schema

create schema Company 

alter schema company transfer Department

create schema Human_Resource 

alter schema Human_Resource transfer Employee 

----------------------------------------
--4)Display Query

sp_helpConstraint 'Human_Resource.Employee'

-------------------------------------------

--5)Create Synonym 

create synonym Emp for Human_Resource.Employee
--Invalid object name 'Employee'.
Select * from Employee
--the full table
Select * from Human_Resource.Employee
--Invalid object name 'Emp'.
Select * from Emp
--Invalid object name 'Human_Resource.Emp'.
Select * from Human_Resource.Emp


-------------------------------------------

--6)Increase the budget of the project 

update Company.Project set Budget += (Budget*10/100) where ProjectNo  in (select ProjectNo from  Works_on where EmpNo = 10102)

----------------------------------------------

--7)Change the name of the department 

update Company.department set DeptName = 'Sales' where DeptNo = (select DeptNo from Human_Resource.Employee where EmpFname = 'James')

----------------------------------------

--8)Change the enter date 

update Works_on set Enter_Date = '2007.12.12' where ProjectNo = 'p1' and  EmpNo in (select EmpNo from Human_Resource.Employee where DeptNo = (select DeptNo from Company.Department where DeptName = 'Sales'))

--------------------------------------

--9)Delete the information 
Delete from works_on where EmpNo in (select EmpNo from Human_Resource.Employee where DeptNo in (select DeptNo from Company.Department where Location = 'KW'))

-----------------------------------------
------------------------------------------------------

insert into works_on VALUES (11111 , 'p3' , 'Clerk' , '2007.2.16') 
--The INSERT statement conflicted with the FOREIGN KEY constraint "FK_Works_on_Employee". 
--The conflict occurred in database "SD", table "Human_Resource.Employee", column 'EmpNo'.

-------------------------------------------------

update works_on set EmpNo = 11111 where EmpNo = 10102
--The UPDATE statement conflicted with the FOREIGN KEY constraint "FK_Works_on_Employee". 
--The conflict occurred in database "SD", table "Human_Resource.Employee", column 'EmpNo'.

----------------------------------------------------
update Human_Resource.Employee set EmpNo = 22222 where EmpNo = 10102
--The UPDATE statement conflicted with the REFERENCE constraint "FK_Works_on_Employee". 
--The conflict occurred in database "SD", table "dbo.Works_on", column 'EmpNo'.
-----------------------------------------------------

delete from Human_Resource.Employee where EmpNo = 10102

--The DELETE statement conflicted with the REFERENCE constraint "FK_Works_on_Employee". 
--The conflict occurred in database "SD", table "dbo.Works_on", column 'EmpNo'.
