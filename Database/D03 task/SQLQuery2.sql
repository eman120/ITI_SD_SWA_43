use Company_SD
--1.	Display the Department id, name and id and the name of its manager.
select Dnum as Department_ID, Dname as Department_Name ,MGRSSN as Manager_ID ,Fname as Name
from Departments inner join Employee
on MGRSSN =SSN

--2.	Display the name of the departments and the name of the projects under its control.
select Dname , Pname
from Departments d inner join project p
on d.Dnum =p.Dnum 

--3.	Display the full data about all the dependence associated with the name of the employee they depend on him/her.
select * , Fname 
from Dependent inner join Employee
on ESSN = SSN

--4.	Display the Id, name and location of the projects in Cairo or Alex city.
select Pnumber , Pname , Plocation
from project
where City = 'Cairo' or City = 'Alex'
--------------------------------------
select Pnumber , Pname , Plocation
from project
where City in ('Cairo' ,'Alex')

--5.	Display the Projects full data of the projects with a name starts with "a" letter.
select * 
from Project
where Pname LIKE 'a%'

--6.	display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select *
from Employee 
where Dno = 30 and Salary between 1000 and 2000

--7.	Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.

select distinct  Fname
 from Employee , Project , Works_for 
 where Dno =10 and  Hours*7>=10 and  Pname = 'AL Rabwah'
 ---------------------------------------------
select distinct  Fname
 from Employee inner join Project  
 on Dno =10   
 inner join Works_for
 on Hours*7>=10 and  Pname = 'AL Rabwah'

 --8.	Find the names of the employees who directly supervised with Kamel Mohamed.

 select Fname 
 from Employee 
 where Superssn = 223344
 -------------------------------
 select E.Fname 
 from Employee E , Employee S
 where E.Superssn= S.SSN and S.Fname = 'Kamel' and S.Lname = 'Mohamed'

 --9.Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.

 select Fname , Pname 
 from Employee  inner join Project 
 on Dno = Dnum order by Pname
 
 --10.	For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate.
 select Pnumber , Dname , Lname , Address , Bdate
 from Project p  inner join Departments d 
 on p.Dnum = d. Dnum and City = 'Cairo'
 inner join 
 Employee
 on MGRSSN = SSN

 --11.	Display All Data of the managers
 select * 
 from Employee  inner join Departments
 on MGRSSN = SSN

 --12.	Display All Employees data and the data of their dependents even if they have no dependents
 select * 
 from Employee left outer join Dependent
 on SSN = ESSN
--13.	Insert your personal data to the employee table as a new employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.
 insert into Employee values ('Eman' , 'Mohammed' , 102672 , 11-16-1999 , '50, 25 st, El tahrir city' , 'F' ,3000 , 112233 , 30)
--14.	Insert another employee with personal data your friend as new employee in department number 30, SSN = 102660, but don’t enter any value for salary or supervisor number to him.
 insert into Employee values ('Esraa' , 'Mohammed' , 102660 , 9-29-1996 , '50, 25 st, El tahrir city' , 'F' ,Null , Null ,30)

--15.	Upgrade your salary by 20 % of its last value.
 update Employee  set Salary= Salary*1.2 where Fname = 'Eman'
 update Employee  set Salary= Salary*1.2 where SSN = 102672

select * from Employee
