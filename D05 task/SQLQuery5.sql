--1.	Create a cursor for Employee table that increases Employee salary by 10% if Salary <3000 and increases it by 20% if Salary >=3000. Use company DB
use company

declare c cursor
for select Salary 
from Employee
for update
declare @sal int
open c
fetch c into @sal 
while @@FETCH_STATUS=0
begin
if @sal<3000 
begin
	 update Employee set Salary=Salary+Salary*0.10
	 where current of c
end 
else update Employee set Salary=Salary+Salary*0.20
	 where current of c 
fetch c into @sal
end
close c
deallocate c
-------------------------------------------------------------
--2.	Display Department name with its manager name using cursor. Use ITI DB
use iti

declare  c2 cursor 
for 
select  Ins_Name,Dept_Name from Department , Instructor where Ins_Id=Dept_Manager  
for read only
declare @fname varchar(50),@Dname varchar(50)
open c2
fetch c2 into @fname ,@Dname 
while @@FETCH_STATUS=0
begin
select @fname 'EName' ,@Dname 'DName'
fetch c2 into @fname ,@Dname
end
close c2
deallocate c2
--------------------------------------
--3.	Try to display all students first name in one cell separated by comma. Using Cursor 
declare c cursor 
for 
select distinct St_Fname from Student
for read only 
declare @name varchar(20) , @allName varchar(80)
open c
fetch c into @name
while @@FETCH_STATUS =0
begin
set @allName=CONCAT(@allName,',',@name)
fetch c into @name
end 
select @allName
close c
deallocate c
----------------------------------------------------------
--4.	Create full, differential Backup for SD30_Company DB.
--DB->tasks-> backup->ful or defferential or transactional
----------------------------------------------------
--5.	Use import export wizard to display students data (ITI DB) in excel sheet
--from excel file---Data->from other sources->sql 
--------------------------------------------------------------------
--6.	Try to generate script from DB ITI that describes all tables and views in this DB
--DB-> tasks-> generate scripts
----------------------------------------------------------
--7.	Create a sequence object that allow values from 1 to 10 without cycling in a specific column and test it.
create sequence sq
start with 1
INCREMENT by 1
maxvalue 10
no cycle

create table squ
(
id int 
)

INSERT into squ
VALUES (NEXT VALUE FOR sq)