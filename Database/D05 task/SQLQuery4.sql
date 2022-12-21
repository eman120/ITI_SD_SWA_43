USE ITI

--1.	Retrieve number of students who have a value in their age. 
select St_Id
from Student
where St_Age is not null

--2.	Get all instructors Names without repetition
select distinct Ins_Name 
from Instructor

--3.	Display student with the following Format (use isNull function)
--      Student ID	Student Full Name	Department name
select isnull(St_Id , 'No ID') as [Student ID] , 
isnull(St_Fname + ' '+ St_Lname , 'No Name')  as [Student Full Name] , 
isnull(Dept_Name , 'No Department') as [Department name]
from Student S, Department D
where S.Dept_Id = D.Dept_Id

--4.	Display instructor Name and Department Name 
--      Note: display all the instructors if they are attached to a department or not
select Ins_Name , Dept_Name
from Instructor I left join Department D
on I.Dept_Id = D.Dept_Id

--5.	Display student full name and the name of the course he is taking For only courses which have a grade 
select  (St_Fname + ' '+ St_Lname) as [Student Full Name] , Crs_Name
from Student S , Stud_Course SC , Course C
where S.St_Id = SC.St_Id and SC.Crs_Id = C.Crs_Id and Sc.Grade is not null

--6.	Display number of courses for each topic name
select count(Crs_id) 
from Course C , Topic T
where C.Top_Id = T.Top_Id
group by Top_Name

--7.	Display max and min salary for instructors
select max(salary) as [Max Salary] , min(salary) as [Min Salary]
from Instructor 
group by Ins_Id

--8.	Display instructors who have salaries less than the average salary of all instructors.
select Ins_Name as [ Instructor Name ]
from Instructor 
where Salary < (select AVG(Salary)
				from Instructor) 

--9.	Display the Department name that contains the instructor who receives the minimum salary.
select Dept_Name as [Department name]
from Department D , Instructor I
where D.Dept_Id = I.Dept_Id and Salary = (select min(Salary)
											from Instructor)
--------------------------------------------------------
select top(1) Dept_Name
from Department d , Instructor i 
where d.Dept_Id=i.Dept_Id 
order by Salary asc
				
--10.	 Select max two salaries in instructor table. 
select top(2) Salary
from Instructor
order by Salary 

--11.	 Select instructor name and his salary but if there is no salary display instructor bonus keyword. “use coalesce Function”
select Ins_Name as [Instructor Name] , coalesce(convert(varchar(20) ,salary) , 'instructor bonus') as Salary
from Instructor

--12.	Select Average Salary for instructors 
select AVG(Salary)
from Instructor

--13.	Select Student first name and the data of his supervisor 
select (S.St_Fname + ' '+ S.St_Lname) as [Student Full Name]  , Sup.* 
from Student S left join Student Sup
on Sup.St_Id = S.St_super

------------------------------------------------
select (S.St_Fname + ' '+ S.St_Lname) as [Student Full Name]  , Sup.* 
from Student S, Student Sup
where S.St_super = Sup.St_Id

--14.	Write a query to select the highest two salaries in Each Department for instructors who have salaries. “using one of Ranking Functions”
select Result.Salary , Result.Dept_Id
from ( select I.Salary , I.Dept_Id , row_number() over (partition by I.Dept_Id order by salary) as RN
from Instructor I where I.Salary is not null) as Result 
where RN between 1 and 2

--15.	 Write a query to select a random  student from each department.  “using one of Ranking Functions”
select *
from ( select * , row_number() over (partition by S.Dept_Id order by newID()) as RN2
from Student S) as Result 
where RN2 = 1