use Company_SD
-- in group by you must inculde all columns in the select statement

--1.	Display (Using Union Function)
------a.	 The name and the gender of the dependence that's gender is Female and depending on Female Employee.
------b.	 And the male dependence that depends on Male Employee.

select D.Dependent_name ,E.Fname , D.sex
from Dependent D inner join Employee E
on D.ESSN = E.SSN  and D.sex = 'f' and E.sex = 'f'
union 
select D.Dependent_name ,E.Fname , D.sex
from Dependent D inner join Employee E
on D.ESSN = E.SSN and D.sex = 'm' and E.sex = 'm'

--2.	For each project, list the project name and the total hours per week (for all employees) spent on that project.
select Pname , sum(Hours) 
from Project , Works_for
where Pnumber = Pno
group by Pname

--3.	Display the data of the department which has the smallest employee ID over all employees' ID.
select *
from Departments , Employee
where Dnum = Dno and SSN = (select min(SSN) from Employee)

--4.	For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
select Dname  ,MAX(Salary) as Max_salary, min(Salary) as Min_salary, avg(Salary) as Avg_salary
from Departments , Employee
where Dnum = Dno 
group by Dname

--5.	List the full name of all managers who have no dependents.
select (fname + ' ' + lname) as Name
from Departments , Employee 
where MGRSSN = SSN 
except
select (fname + ' ' + lname) as Name
from Employee , Dependent
where ESSN = SSN

--6.	For each department-- if its average salary is less than the average salary of all employees-- display its number, name and number of its employees.

select Dnum , Dname , count(SSN) as employeesNum 
from Departments ,Employee
where Dnum= Dno
group by Dname , Dnum
having AVG(Salary) < (select AVG(Salary) from Employee)

--7.	Retrieve a list of employees names and the projects names they are working on ordered by department number and within each department, ordered alphabetically by last name, first name.
select Fname , Pname , Dno
from Employee E , Project P , Works_for W
where W.ESSN = E.SSN and P.Pnumber = W.pno
order by Dnum , Lname ,Fname

--8.	Try to get the max 2 salaries using subquery
select MAX(salary) 
from Employee 
union all
select MAX(salary) 
from Employee
where salary != (select MAX(salary) 
from Employee)

--9.	Get the full name of employees that is similar to any dependent name
select (fname + ' ' + lname) as Employee_Name
from Employee 
intersect
select Dependent_name as Dependent_name
from Dependent

--10.	Display the employee number and name if at least one of them have dependents (use exists keyword) self-study.
select SSN as employee_number , Fname +' '+ Lname as employee_name
from Employee
WHERE EXISTS (select Dependent_name from Dependent where ESSN = SSN) 

--11.	In the department table insert new department called "DEPT IT" , with id 100, employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'
insert into Departments values('DEPT IT' , 100 , 112233 , '1-11-2006')

--12.	Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department (id = 100), and they give you(your SSN =102672) her position (Dept. 20 manager) 

-------a.	First try to update her record in the department table
-------b.	Update your record to be department 20 manager.
-------c.	Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)

update Departments set MGRSSN = 968574 , [MGRStart Date]=GETDATE() where Dnum = 100
update Departments set MGRSSN = 102672 , [MGRStart Date]=GETDATE() where Dnum = 20
update Employee set Superssn = 102672 where SSN = 102660

--13.	Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344) so try to delete his data from your database in case you know that you will be temporarily in his position.
-----Hint: (Check if Mr. Kamel has dependents, works as a department manager, supervises any employees or works in any projects and handle these cases).

update Departments 
set MGRSSN = 102672 , [MGRStart Date]=GETDATE() 
where MGRSSN = 223344

update Employee 
set Superssn = 102672 
where Superssn = 223344

update Works_for 
set ESSn = 102672 
where ESSn = 223344

delete from Dependent where ESSN = 223344
delete from Employee where SSN = 223344


--14.	Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30%

update Employee 
set Salary =  Salary*1.3 
from Employee,Works_for,Project 
where Essn = SSN and Pno = Pnumber and pname = 'Al Rabwah'

--------------------------------------------------------

update Employee 
 set Salary=Salary*1.3
 from Employee , Project
where Dnum=Dno and Pname = 'Al Rabwah'

INSERT INTO Employee
VALUES ('Nora' ,'Ghaly' ,112236 , NULL ,NULL , NULL , NULL ,NULL ,NULL);

Delete from Employee where SSN in (112234 , 112235 ,112236)
select * from Employee