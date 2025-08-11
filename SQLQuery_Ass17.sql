create database ass3
use ass3
create table Department (
    deptId int primary key identity(1,1),
    deptName varchar(20) check (deptName in ('HR', 'Sales', 'Accts', 'IT'))
)

create table Employee (
    employeeId int primary key identity(1,1),       
    name varchar(100) not null,                     
    exp int check (exp >= 2),                       
    salary int check (salary between 12000 and 30000), 
    departmentId int foreign key references Department(deptId),
    managerId int,                                  
    age int check (age between 26 and 60) default 26 
);

create procedure InsertOrUpdateEmployee
    @employeeId int = null,
    @name varchar(100),
    @exp int,
    @salary int,
    @departmentId int,
    @managerId int
as
begin
    if exists (select 1 from employee where employeeId = @employeeId)
    begin
        update employee
        set name = @name, exp = @exp, salary = @salary,
            departmentId = @departmentId, managerId = @managerId
        where employeeId = @employeeId;

        print 'Record Updated';
    end
    else
    begin
        insert into employee (name, exp, salary, departmentId, managerId)
        values (@name, @exp, @salary, @departmentId, @managerId);

        print 'Record Inserted';
    end
end;

create procedure DeleteEmployee
    @employeeId int
as
begin
    if exists (select 1 from employee where employeeId = @employeeId)
    begin
        delete from employee where employeeId = @employeeId;
        print 'Record Deleted';
    end
    else
    begin
        print 'Invalid Employee ID. Record Not Found.';
    end
end;

-- Insert departments
insert into Department (deptName)
values ('HR'), ('Sales'), ('Accts'), ('IT');

-- Insert employees using procedure
exec InsertOrUpdateEmployee 
    @name = 'Shruti',
    @exp = 3,
    @salary = 25000,
    @departmentId = 1,
    @managerId = null;

exec InsertOrUpdateEmployee 
    @name = 'Rahul',
    @exp = 5,
    @salary = 28000,
    @departmentId = 2,
    @managerId = 1;

exec InsertOrUpdateEmployee 
    @name = 'Neha',
    @exp = 4,
    @salary = 23000,
    @departmentId = 1,
    @managerId = 1;
    select * from employee

    select * from department
--1
select 
    e.employeeId as [Employee ID],
    e.name as [Name of Employee],
    e.salary as [Salary of Employee],
    d.deptName,
    m.name as [Manager Name]
from 
    employee e
left join 
    department d on e.departmentId = d.deptId
left join 
    employee m on e.managerId = m.employeeId;
 --2
 select 
    name,
    salary,
    salary + 3000 as [Incremented Salary]
from employee;
--3
select 
    d.deptName,
    sum(e.salary) as [Total Salary]
from 
    employee e
join 
    department d on e.departmentId = d.deptId
group by 
    d.deptName;

--4
select 
    d.deptName,
    sum(e.salary) as [Total Salary],
    max(e.salary) as [Max Salary],
    avg(e.salary) as [Avg Salary]
from 
    employee e
join 
    department d on e.departmentId = d.deptId
group by 
    d.deptName;

 --5
 select 
    row_number() over (order by employeeId) as [Seq No],
    *
from employee;

--6
select 
    name,
    salary,
    rank() over (order by salary desc) as [Salary Rank]
from employee;

--7
select 
    name,
    salary,
    rank() over (order by salary desc) as [Salary Rank]
from employee;
--8
alter table employee add age int default 26 check (age between 26 and 60);

--10
update employee set age = 26 where age is null;
--11
select count(*) as [Total Departments] from Department;




