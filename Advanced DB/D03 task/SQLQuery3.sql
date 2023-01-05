use iti

--1.	 Create a view that displays student full name, course name if the student has a grade more than 50. 
create view Vstud 
as 
select St_Fname + ' ' + St_Lname as full_name , Crs_Name 
from Student S inner join Stud_Course SC on S.St_Id = SC.St_Id inner join Course C on SC.Crs_Id = C.Crs_Id
where Grade > 50

select * from Vstud
------------------------------------------------
--2.	 Create an Encrypted view that displays manager names and the topics they teach. 
create view Vmanag
WITH ENCRYPTION
as 
select Ins_Name , Top_Name 
from Instructor I inner join Ins_Course IC on I.Ins_Id = IC.Ins_Id 
inner join Course C on IC.Crs_Id = C.Crs_Id inner join Topic T on C.Top_Id = T.Top_Id
SP_HELPTEXT V1

select * from Vmanag
-----------------------------------------------------
--3.	Create a view that will display Instructor Name, Department Name for the ‘SD’ or ‘Java’ Department 

create view VIns
as 
select Ins_Name , Dept_Name 
from Instructor I inner join Department D on I.Dept_Id = D.Dept_Id 
where Dept_Name in ('SD' , 'Java')

select * from VIns
-----------------------------------------------------
--4.	 Create a view “V1” that displays student data for student who lives in Alex or Cairo. 
--Note: Prevent the users to run the following query 
--Update V1 set st_address=’tanta’
--Where st_address=’alex’;

create view V1
as 
select *
from Student
where St_Address in ('Alex' , 'Cairo')
with check option
select * from V1 

Update V1 set St_Address='tanta' Where St_Address='alex';
--The attempted insert or update failed because the target view either specifies WITH CHECK OPTION or 
--spans a view that specifies WITH CHECK OPTION and one or more rows resulting from the operation did not qualify under the CHECK OPTION constraint.


-----------------------------------------------------
-----------------------------------------------------
use SD

--5.	Create a view that will display the project name and the number of employees work on it. “Use SD database”

create view Vproj
as 
select ProjectName , count(EmpNo) as Number
from Company.Project P inner join Works_on W
on P.ProjectNo = W.ProjectNo
group by ProjectName

select * from Vproj 
-----------------------------------------------------
-----------------------------------------------------
use iti

--6.	Create index on column (Hiredate) that allow u to cluster the data in table Department. What will happen?

create clustered index i1
on Department(Manager_hiredate)

--Cannot create more than one clustered index on table 'Department'. 
--Drop the existing clustered index 'PK_Department' before creating another.

-----------------------------------------------------
--7.	Create index that allow u to enter unique ages in student table. What will happen? 
create unique index i2
on student(St_Age)

--The CREATE UNIQUE INDEX statement terminated because a duplicate key was found for the object name 'dbo.Student' and the index name 'i2'. The duplicate key value is (21).

-----------------------------------------------------
--8.	Using Merge statement between the following two tables [User ID, Transaction Amount]
create table User_ID
(
Xid int ,
Xvalue int
)

create table Transaction_Amount
(
Yid int ,
Yvalue int
)

Merge into User_ID as U
using Transaction_Amount as T
on U.Xid = T.Yid

when matched then
	update 
		set U.Xvalue = T.Yvalue
when not matched then  --not matched by target
	Insert 
	values(T.Yid , T.Yvalue);

--===================================================================================================================================

use SD
--1)	Create view named   “v_clerk” that will display employee#,project#, the date of hiring of all the jobs of the type 'Clerk'.

create  view v_clerk
as 
select P.ProjectNo , E.EmpNo , W.Enter_Date
from Human_Resource.Employee E inner join Works_on W 
on E.EmpNo = W.EmpNo
inner join Company.Project P
on P.ProjectNo = W.ProjectNo
where Job = 'Clerk'

select * from v_clerk 
-----------------------------------------------------
--2)	 Create view named  “v_without_budget” that will display all the projects data without budget

create view v_without_budget
as 
select *
from Company.Project 
where Budget is null

select * from v_without_budget 

-----------------------------------------------------
--3)	Create view named  “v_count “ that will display the project name and the # of jobs in it

create view v_count
as 
select ProjectName , count(Job) as JobNo
from Company.Project P inner join Works_on W
on P.ProjectNo = W.ProjectNo
group by ProjectName

select * from v_count 

-----------------------------------------------------
--4)	 Create view named ” v_project_p2” that will display the emp#  for the project# ‘p2’
--use the previously created view  “v_clerk”

create view v_project_p2(Emp_No)
as 
select EmpNo
from v_clerk
where ProjectNo = 'p2'

select * from v_project_p2 

-----------------------------------------------------
--5)	modifey the view named  “v_without_budget”  to display all DATA in project p1 and p2 
alter view v_without_budget
as 
select *
from Company.Project P 
where ProjectNo in ('p1' , 'p2')

select * from v_without_budget 
-----------------------------------------------------
--6)	Delete the views  “v_ clerk” and “v_count”
drop view v_clerk
drop view v_count

-----------------------------------------------------
--7)	Create view that will display the emp# and emp lastname who works on dept# is ‘d2’
create view v_emp
as 
select EmpNo , EmpLname
from Human_Resource.Employee 
where DeptNo ='d2'

select * from v_emp 

-----------------------------------------------------
--8)	Display the employee  lastname that contains letter “J”
--Use the previous view created in Q#7

select EmpLname from v_emp where EmpLname like '%J%'
-----------------------------------------------------
--9)	Create view named “v_dept” that will display the department# and department name.
create view v_dept
as 
select DeptNo , DeptName
from Company.Department

select * from v_dept 
-----------------------------------------------------
--10)	using the previous view try enter new department data where dept# is ’d4’ and dept name is ‘Development’
insert into v_dept 
values('d4' , 'Development')

select * from v_dept 
-----------------------------------------------------
--11)	Create view name “v_2006_check” that will display employee#, the project# where he works 
--and the date of joining the project which must be from the first of January and the last of December 2006.

create view v_2006_check
as 
select EmpNo , ProjectNo , Enter_Date
from Works_on
where Enter_Date between'2006/1/1' and '2006/12/31' 

select * from v_2006_check