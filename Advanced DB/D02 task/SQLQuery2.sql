--1.	Create a scalar function that takes date and returns Month name of that date.
create function dateMonth (@date date)
returns varchar(20)
begin 
--set @date = CAST(@date AS date)
declare @dat varchar(20)
set @dat =  datename(mm , @date)
return @dat
end

--calling
select dbo.dateMonth(getdate())

--------------------------------------------------------
--2.	 Create a multi-statements table-valued function that takes 2 integers and returns the values between them.
alter function numericalSequence (@x int , @y int)
returns @t table
		(
		sequence int
		)
as 
begin
		while (@x != @y)
	begin
		if @x <@y
			begin
			    insert into @t
	     	    select @x 
		        select @x +=1;
			end
		if @x > @y
			begin
				insert into @t
				select @x 
				set @x-=1;
			end
	   end
return
end

select * from dbo.numericalSequence(9 , 5)
select * from dbo.numericalSequence(0 , 5)

----------------------------------------------------------------
USE ITI

--3.	 Create inline function that takes Student No and returns Department Name with Student full name.
create function DeptName(@Id int)
returns table 
as 
return (
select concat (St_Fname , ' ' , st_Lname) as fullName , Dept_Name 
from Student S, Department D
where St_Id = @Id and S.Dept_Id = D.Dept_Id
)

select * from dbo.DeptName(4)

--------------------------------------------------------------

--4.	Create a scalar function that takes Student ID and returns a message to user 
--a.	If first name and Last name are null then display 'First name & last name are null'
--b.	If First name is null then display 'first name is null'
--c.	If Last name is null then display 'last name is null'
--d.	Else display 'First name & last name are not null'

--create function stdMessage(@Id int)  --for first time
alter function stdMessage(@Id int)
returns varChar(50)
begin
declare @Fname varChar(50)
declare @Lname varChar(50)
declare @message varChar(50)

select @Fname =  St_Fname from Student where St_Id = @Id
select @Lname = St_Lname from Student where St_Id = @Id 

		if @Fname is NULL and @Lname is NULL
		set @message = 'First name & last name are null'
		else if @Fname is NULL
		set @message = 'First name is null'
		else if @Lname is NULL
		set @message = 'last name is null'
		else
		set @message = 'First name & last name are not null'
return @message
end

select dbo.stdMessage(1)

-----------------------------------------------------------------

--5.	Create inline function that takes integer which represents manager ID and displays department name, Manager Name and hiring date 

alter function ManagerData(@Id int)
returns table 
as 
return (
select Dept_Name , Ins_Name as Manager_Name , Manager_hiredate
from Instructor I, Department D
where Dept_Manager = @Id and I.Ins_Id = D.Dept_Manager
)

select * from ManagerData(8)

---------------------------------------------------

--6.	Create multi-statements table-valued function that takes a string
--If string='first name' returns student first name
--If string='last name' returns student last name 
--If string='full name' returns Full Name from student table 
--Note: Use “ISNULL” function

alter function stdName(@name varChar(20))
returns @t table
		(
		 student_name nvarchar(50)
		)
as
begin
		if @name = 'full name'
		insert @t
		select St_Fname+' '+St_Lname as Full_Name
		from student
		else if @name = 'first name'
		insert @t
		select St_Fname as First_Name
		from student
		else if @name = 'last name'
		insert @t
		select St_Lname as Last_Name
		from student
return 
end

select * from stdName('first name')
---------------------------------------------

--7.	Write a query that returns the Student No and Student first name without the last char

select St_Id, substring(St_Fname, 1, (len(St_Fname) - 1)) from Student
------------------------------------------------------
--8.	Wirte query to delete all grades for the students Located in SD Department 

delete from Stud_Course where St_Id in (select St_Id from Student where Dept_Id = (select Dept_Id from Department where Dept_Location = 'SD'))

select St_Id from Student where Dept_Id = (select Dept_Id from Department where Dept_Location = 'SD')

--delete Sc
--from Stud_Course Sc inner join Student S
--on Sc.St_Id = S.St_Id 
--inner join Department D
--on S.Dept_Id = D.Dept_Id 
--where D.Dept_Location = 'SD'