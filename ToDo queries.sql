-- CREATE DATABASE ToDo;

-- create table Employee(
-- Id int Primary Key auto_increment not null,
-- `Name` nvarchar(30),
-- HoursAvailable float,
-- Title nvarchar(40)
-- );

-- create table ToDo(
-- Id int Primary Key auto_increment not null,
-- `Name` nvarchar(30),
-- HoursNeeded float,
-- IsCompleted bool
-- );

-- insert into todo values(0,'Mow Lawn', 1.5,false );
-- insert into todo values(0, 'Wash dishes', .5, true),
-- (0, 'Do Laundry', 2.0, false);

select * from todo;

-- -- Lines 20 and 21 is referencing the employee id within the employee table . Takes the EmployeeID and maps it to the Employee table ID
-- -- this is a many to many table . With many to many all tasks may be tackled by any number of employees and vice versa
-- -- one to many, it would be one task as many employees , but each employee may have only one task
-- create table Assignments(
-- Id int Primary Key auto_increment not null,
-- EmployeeId int,
-- ToDoId int,
-- foreign key (EmployeeId) references Employee(Id),
-- foreign key (ToDoId) references ToDo(Id)
-- );

-- insert into employee values(1, 'Maddy', 40, 'Associate Software Engineer in Training'),
-- (2, 'Caroline', 35, 'Senior Software Engineer'),
-- (3, 'David', 40, 'Director'),
-- (4, 'Hina', 40, 'Team Leader');

-- insert into employee values(0, 'Sleezy Pete', 20, 'President of Acquisition'),
-- (0, 'Hank Hill', 10, 'Propane Salesman');